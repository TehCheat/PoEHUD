using PoeHUD.Poe.RemoteMemoryObjects;
using System;
using System.Collections.Generic;

namespace PoeHUD.Poe.Components
{
    public class Life : Component
    {
        public int MaxHP => Address != 0 ? M.ReadInt(Address + 0x50) : 1;
        public int CurHP => Address != 0 ? M.ReadInt(Address + 0x54) : 1;
        public int ReservedFlatHP => Address != 0 ? M.ReadInt(Address + 0x5C) : 0;
        public int ReservedPercentHP => Address != 0 ? M.ReadInt(Address + 0x60) : 0;
        public int MaxMana => Address != 0 ? M.ReadInt(Address + 0x88) : 1;
        public int CurMana => Address != 0 ? M.ReadInt(Address + 0x8C) : 1;
        public int ReservedFlatMana => Address != 0 ? M.ReadInt(Address + 0x94) : 0;
        public int ReservedPercentMana => Address != 0 ? M.ReadInt(Address + 0x98) : 0;
        public int MaxES => Address != 0 ? M.ReadInt(Address + 0xB8) : 0;
        public int CurES => Address != 0 ? M.ReadInt(Address + 0xBC) : 0;
        public float HPPercentage => CurHP / (float)(MaxHP - ReservedFlatHP - Math.Round(ReservedPercentHP * 0.01 * MaxHP));
        public float MPPercentage => CurMana / (float)(MaxMana - ReservedFlatMana - Math.Round(ReservedPercentMana * 0.01 * MaxMana));

        public float ESPercentage
        {
            get
            {
                if (MaxES != 0)
                {
                    return CurES / (float)MaxES;
                }
                return 0f;
            }
        }

        //public bool CorpseUsable => M.ReadBytes(Address + 0x238, 1)[0] == 1; // Total guess, didn't verify

        public List<Buff> Buffs
        {
            get
            {
                var list = new List<Buff>();
                long start = M.ReadLong(Address + 0xE8);
                long end = M.ReadLong(Address + 0xF0);
                int count = (int)(end - start) / 8;
                // Randomly bumping to 256 from 32... no idea what real value is.
                if (count <= 0 || count > 256)
                {
                    return list;
                }
                for (int i = 0; i < count; i++)
                {
                    long addr = M.ReadLong(start + i * 8);
                    if (addr == 0)
                        continue;
                    /*long addr2 = M.ReadLong(addr + 8);
                     if (addr2 == 0)
                         continue;*/
                    list.Add(ReadObject<Buff>(addr+8));
                }
                return list;
            }
        }

        public bool HasBuff(string buff)
        {
            return Buffs.Exists(x => x.Name == buff);
        }
    }
}