using System;
using PoeHUD.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Controllers;
using PoeHUD.Models.Enums;
using PoeHUD.Poe.Components;
using SharpDX;

namespace PoeHUD.Poe
{
    public sealed class Entity : RemoteMemoryObject, IEntity
    {
        private long ComponentLookup => M.ReadLong(Address, 0x40, 0x30);
        private long ComponentList => M.ReadLong(Address + 0x8);//0x40?
        private string _path;
        public string Path => _path ?? (_path = M.ReadStringU(M.ReadLong(Address, 0x18)));

        public string Metadata
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(Path))
                        return string.Empty;

                    var splitIndex = Path.IndexOf("@");

                    if (splitIndex != -1)
                        return Path.Substring(0, splitIndex);
                }
                catch (Exception e)
                {
                    return Path;
                }

                return Path;
            }
        }

        /// <summary>
        /// 0x65004D = "Me"(4 bytes) from word Metadata
        /// </summary>
        public bool IsValid => Address != 0 && M.ReadInt(Address, 0x18, 0) == 0x65004D;

        public uint Id => M.ReadUInt(Address + 0x40);// << 32 ^ Address;
        public int InventoryId => M.ReadInt(Address + 0x58);

        /// if you want to find parent(child) of Entity (for essence mobs) - it will be at 0x48 in a deph of 2-3 in first pointers

        public Positioned PositionedComp => ReadObject<Positioned>(Address + 0x50);

        public bool IsHostile => (PositionedComp.Reaction & 0x7f) != 1;
        public bool IsAlive => GetComponent<Life>().CurHP > 0;
        public bool IsTargetable => GetComponent<Targetable>().isTargetable;
        public bool CannotDieAura => HasBuff("monster_aura_cannot_die");
        public bool BestiaryMonsterCaptured => HasBuff("capture_monster_trapped");
        public bool IsHidden => HasStat((GameStat)GameController.Instance.Files.Stats.records["is_hidden_monster"].ID, out var stat) && stat > 0;
        public bool CannotBeDamagedStat => HasStat((GameStat)GameController.Instance.Files.Stats.records["cannot_be_damaged"].ID, out var stat) && stat == 1;
        public bool Invincible => CannotDieAura || CannotBeDamagedStat;
        public bool IsMapBoss => GetComponent<ObjectMagicProperties>().Mods.Any(a => a == "MonsterMapBoss");
        public bool IsEmerging
        {
            get
            {
                if (IsHidden)
                    return false;

                var m = Path;
                return 
                    //m.Contains("/SandSpitterEmerge/") ||//was ignoring this guys https://dl.dropboxusercontent.com/s/qgxl189iieu4dm2/PoeHUD_2019-03-30_13-43-00.png
                       //   m.Contains("/WaterElemental/") ||//https://dl.dropboxusercontent.com/s/d3qb1c0tg3mo1p6/PoeHUD_2019-03-24_23-04-01.png
                       m.Contains("/RootSpiders/") ||
                       m.Contains("ZombieMiredGraspEmerge") ||
                       m.Contains("ReliquaryMonsterEmerge");
            }
        }

        public bool HasStat(GameStat statType, out int value)
        {
            return GetComponent<Stats>().GameStatDictionary.TryGetValue(statType, out value);
        }

        public bool IsActive => IsHostile && IsAlive && IsTargetable && !IsHidden;
        public bool HasBuff(string buff) => GetComponent<Life>().Buffs.Any(x => x.Name == buff);
        public bool HasBuff(List<string> buffs) => !GetComponent<Life>().Buffs.TrueForAll(x => !buffs.Contains(x.Name));
        public float Distance => Vector2.Distance(GameController.Instance.Player.PositionedComp.GridPos, PositionedComp.GridPos);

        public Vector3 Pos
        {
            get
            {
                var p = GetComponent<Render>();
                return new Vector3(p.X, p.Y, p.Z);
            }
        }

        public Vector3 PosEntityCenter
        {
            get
            {
                var p = GetComponent<Render>();
                return new Vector3(p.X, p.Y, p.Z + p.Bounds.Z / 2);
            }
        }

        public bool HasComponent<T>() where T : Component, new()
        {
            long addr;
            return HasComponent<T>(out addr);
        }

        private bool HasComponent<T>(out long addr) where T : Component, new()
        {
            string name = typeof(T).Name;
            long componentLookup = ComponentLookup;
            addr = M.ReadLong(componentLookup);
            int i = 0;
            while (!M.ReadString(M.ReadLong(addr + 0x10)).Equals(name))
            {
                addr = M.ReadLong(addr);
                ++i;
                if (addr == componentLookup || addr == 0 || addr == -1 || i >= 200)
                    return false;
            }
            return true;
        }

        public T GetComponent<T>() where T : Component, new()
        {
            long addr;
            return HasComponent<T>(out addr) ? ReadObject<T>(ComponentList + M.ReadInt(addr + 0x18) * 8) : GetObject<T>(0);
        }

        public Dictionary<string, long> GetComponents()
        {
            var dictionary = new Dictionary<string, long>();
            long componentLookup = ComponentLookup;
            // the first address is a base object that doesn't contain a component, so read the first component
            long addr = M.ReadLong(componentLookup);
            while (addr != componentLookup && addr != 0 && addr != -1)
            {
                string name = M.ReadString(M.ReadLong(addr + 0x10));
                string nameStart = name;
                if (!string.IsNullOrWhiteSpace(name))
                {
                    char[] arr = name.ToCharArray();
                    arr = Array.FindAll(arr, (c => (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '-')));
                    name = new string(arr);
                }
                if (String.IsNullOrWhiteSpace(name) || name != nameStart)
                {
                    break;
                }
                long componentAddress = M.ReadLong(ComponentList + M.ReadInt(addr + 0x18) * 8);
                if (!dictionary.ContainsKey(name) && !string.IsNullOrWhiteSpace(name))
                    dictionary.Add(name, componentAddress);
                addr = M.ReadLong(addr);
            }
            return dictionary;
        }

        /*
        public string DebugReadComponents()
        {
            string result = "";

            long cList = M.ReadLong(Address + 0x8);
            result += "ComponentList (EntytaAddr + 0x8): " + System.Environment.NewLine + cList.ToString("x") + System.Environment.NewLine + System.Environment.NewLine;

            result += "ComponentLookupRead: " + System.Environment.NewLine + ComponentLookup.ToString("x") + System.Environment.NewLine;

            long CL_read1 = M.ReadLong(Address);
            result += "CL_read1 (EntytaAddr + 0x0): " + System.Environment.NewLine + CL_read1.ToString("x") + System.Environment.NewLine + System.Environment.NewLine;

            long CL_read2 = M.ReadLong(CL_read1 + 0x48);
            result += "CL_read2 (CL_read1 + 0x48): " + System.Environment.NewLine + CL_read2.ToString("x") + System.Environment.NewLine + System.Environment.NewLine;

            long CL_read3 = M.ReadLong(CL_read2 + 0x30);
            result += "CL_read3 (CL_read2 + 0x30): " + System.Environment.NewLine + CL_read3.ToString("x") + System.Environment.NewLine + System.Environment.NewLine;

            long CL_read4 = M.ReadLong(CL_read3 + 0x0);
            result += ">LookUp  (CL_read3 + 0x0): " + System.Environment.NewLine + CL_read4.ToString("x") + System.Environment.NewLine + System.Environment.NewLine;


            result += "ReadingComponents: " + System.Environment.NewLine;


            var dictionary = new Dictionary<string, long>();

            long componentLookup = ComponentLookup;
            long addr = componentLookup;



            do
            {
                result += "addr: " + addr.ToString("x") + System.Environment.NewLine;

                result += "NamePchar at (addr + 0x10): " + (addr + 0x10).ToString("x") + System.Environment.NewLine;
                string name = M.ReadString(M.ReadLong(addr + 0x10));
                result += "name: " + name + System.Environment.NewLine;


                result += "componentAddress (ComponentList + M.ReadInt(addr + 0x18) * 8): " + (addr + 0x10).ToString("x") + System.Environment.NewLine;
                long componentAddress = M.ReadInt(ComponentList + M.ReadInt(addr + 0x18) * 8);
                result += $"({ComponentList} + M.ReadInt({(addr + 0x18).ToString("x")}) * 8)" + System.Environment.NewLine;

                result += $"({ComponentList} + {(M.ReadInt(addr + 0x18)).ToString("x")} * 8)" + System.Environment.NewLine;
                result += $"({ComponentList} + {((M.ReadInt(addr + 0x18)) * 8).ToString("x")})" + System.Environment.NewLine;

                result += "FinalComponentAddress: " + componentAddress.ToString("x") + System.Environment.NewLine;


                if (!dictionary.ContainsKey(name) && !string.IsNullOrWhiteSpace(name))
                {
                    dictionary.Add(name, componentAddress);
                    result += $"AddComponent: {name} : {componentAddress.ToString("x")}" + System.Environment.NewLine;
                }
                else
                {
                    result += $"SkipComponent: {name} : {componentAddress.ToString("x")}. Allready contains or emptyCompName" + System.Environment.NewLine;
                }

                addr = M.ReadLong(addr);
                result += System.Environment.NewLine;

            } while (addr != componentLookup && addr != 0 && addr != -1);

            return result;
        }
        */

        public override string ToString()
        {
            return Path;
        }
    }
}
