using System;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Poe.Elements;
using PoeHUD.Controllers;
using PoeHUD.Poe.Components;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ServerData : RemoteMemoryObject
    {
        public const int Skip = 20480;
        public BetrayalData BetrayalData => GetObject<BetrayalData>(M.ReadLong(Address + 0x3C8, 0x718));

        [Obsolete("Obsolete. Use GameController.Game.IngameState.IngameUi.StashElement instead")]
        public StashElement StashPanel => GameController.Instance.Game.IngameState.IngameUi.StashElement;// Address != 0 ? GetObject<StashElement>(M.ReadLong(Address + 0x4C8, 0xA0, 0x78)) : null; // needs fixed, but if it's obsolete, just remove it

        public CharacterClass PlayerClass => (CharacterClass)(M.ReadByte(Address + 0x63B0) & 0xF);

        public int GetBeastCapturedAmount(BestiaryCapturableMonster monster)
        {
            return M.ReadInt(Address + 0x5240 + monster.Id * 4);
        }

        public List<ushort> PassiveSkillIds
        {
            get
            {
                var fisrPtr = M.ReadLong(Address + 0x6340);
                var endPtr = M.ReadLong(Address + 0x6348);

                int skillIds = (int)(endPtr - fisrPtr);

                if (Math.Abs(skillIds) > 500)
                    return null;
                var bytes = M.ReadBytes(fisrPtr, skillIds);
                var result = new List<ushort>();

                for (int i = 0; i < bytes.Length; i += 2)
                {
                    var id = BitConverter.ToUInt16(bytes, i);
                    result.Add(id);
                }
                return result;
            }
        }
        #region PlayerData
        public int CharacterLevel => M.ReadInt(Address + 0x6394);
        public int PassiveRefundPointsLeft => M.ReadInt(Address + 0x6398);
        public int QuestPassiveSkillPoints => M.ReadInt(Address + 0x639C);
        public int FreePassiveSkillPointsLeft => (CharacterLevel - 1) + QuestPassiveSkillPoints - (PassiveSkillIds.Count - SpentAscendencyPoints);

        public int TotalAscendencyPoints => M.ReadInt(Address + 0x63A4);
        public int SpentAscendencyPoints => M.ReadInt(Address + 0x63A8);
        public int TimeInGame => M.ReadInt(Address + 0x6468);

        public NetworkStateE NetworkState => (NetworkStateE)M.ReadByte(Address + 0x63D0);
        public bool IsInGame => GameStateController.IsInGameState;

        public string League => NativeStringReader.ReadString(Address + 0x63E8);
        public PartyAllocation PartyAllocationType => (PartyAllocation)M.ReadByte(Address + 0x65C8);
        public int Latency => M.ReadInt(Address + 0x6470);
        #endregion
        #region Stash Tabs
        public List<ServerStashTab> PlayerStashTabs => GetStashTabs(0x6480, 0x6488);
        public List<ServerStashTab> GuildStashTabs => GetStashTabs(0x6498, 0x64A0);
        private List<ServerStashTab> GetStashTabs(int offsetBegin, int offsetEnd)
        {
            var firstAddr = M.ReadLong(Address + offsetBegin);
            var lastAddr = M.ReadLong(Address + offsetEnd);

            var tabs = M.ReadStructsArray<ServerStashTab>(firstAddr, lastAddr, ServerStashTab.StructSize, 5000);//Some players have 300 stash tabs, lol

            //Skipping hidden tabs of premium maps tab (read notes in StashTabController.cs)
            tabs.RemoveAll(x => x.IsHidden);
            return tabs;
        }
        #endregion

        public PartyStatus PartyStatusType => (PartyStatus)M.ReadByte(Address + 0x65A8);

        // New Guild is a structure pointed to at 0x65D0
        // 0x10 - Length of Guild Name
        // 0x00 - Name (either a pointer if length > 8 else Ustring)
        public string GuildName => NativeStringReader.ReadString(M.ReadLong(Address + 0x6630));

        public List<ushort> SkillBarIds
        {
            get
            {
                var result = new List<ushort>();

                var readAddr = Address + 0x6638;
                for (var i = 0; i < 8; i++)
                {
                    result.Add(M.ReadUShort(readAddr));
                    readAddr += 2;
                }
                return result;
            }
        }
        public List<Player> NearestPlayers
        {
            get
            {
                var startPtr = M.ReadLong(Address + 0x6690);
                var endPtr = M.ReadLong(Address + 0x6698);

                if (Math.Abs(endPtr - startPtr) / 8 > 50)
                    return null;

                startPtr += 16;//Don't ask me why. Just skipping first 2

                var result = new List<Player>();
                for (var addr = startPtr; addr < endPtr; addr += 16)//16 because we are reading each second pointer (pointer vectors)
                {
                    result.Add(ReadObject<Player>(addr));
                }
                return result;
            }
        }

        #region Inventories
        public List<InventoryHolder> PlayerInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x6770);
                var lastAddr = M.ReadLong(Address + 0x6778);
                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 400);
            }
        }
        public List<InventoryHolder> NPCInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x6828);
                var lastAddr = M.ReadLong(Address + 0x6830);

                if (firstAddr == 0)
                    return new List<InventoryHolder>();

                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 100);
            }
        }

        public List<InventoryHolder> GuildInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x68E0); // double check these
                var lastAddr = M.ReadLong(Address + 0x68E8);
                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 100);
            }
        }

        #region Utils functions
        public ServerInventory GetPlayerInventoryBySlot(InventorySlotE slot)
        {
            foreach (var inventory in PlayerInventories)
            {
                if (inventory.Inventory.InventSlot == slot)
                {
                    return inventory.Inventory;
                }
            }
            return null;
        }
        public ServerInventory GetPlayerInventoryByType(InventoryTypeE type)
        {
            foreach (var inventory in PlayerInventories)
            {
                if (inventory.Inventory.InventType == type)
                {
                    return inventory.Inventory;
                }
            }
            return null;
        }

        public ServerInventory GetPlayerInventoryBySlotAndType(InventoryTypeE type, InventorySlotE slot)
        {
            foreach (var inventory in PlayerInventories)
            {
                if (inventory.Inventory.InventType == type && inventory.Inventory.InventSlot == slot)
                {
                    return inventory.Inventory;
                }
            }
            return null;
        }

        #endregion
        #endregion

        public ushort TradeChatChannel => M.ReadUShort(Address + 0x69F8);
        public ushort GlobalChatChannel => M.ReadUShort(Address + 0x6A00);
        public ushort LastActionId => M.ReadUShort(Address + 0x6A4C);

        #region Completed Areas
        public List<WorldArea> UnknownAreas => GetAreas(0x6A88);
        public List<WorldArea> CompletedAreas => GetAreas(0x6AC8);
        public List<WorldArea> ShapedMaps => GetAreas(0x6B08);
        public List<WorldArea> BonusCompletedAreas => GetAreas(0x6B48);
        public List<WorldArea> ElderGuardiansAreas => GetAreas(0x6B88);
        public List<WorldArea> MasterAreas => GetAreas(0x6BC8);
        public List<WorldArea> ShaperElderAreas => GetAreas(0x6C08);

        private List<WorldArea> GetAreas(int offset)
        {
            var result = new List<WorldArea>();
            var size = M.ReadInt(Address + offset - 0x8);

            if (size == 0 || size > 300)
                return result;
            var listStart = M.ReadLong(Address + offset);

            for (var addr = M.ReadLong(listStart); addr != listStart; addr = M.ReadLong(addr))
            {

                var areaAddr = M.ReadLong(addr + 0x18);

                if (areaAddr != 0)
                {
                    var area = GameController.Instance.Files.WorldAreas.GetByAddress(areaAddr);
                    if (area != null)
                        result.Add(area);
                }

                if (--size < 0) break;
            }
            return result;
        }
        #endregion
        #region Monster Info
        public byte MonsterLevel => M.ReadByte(Address + 0x75AC);
        public byte MonstersRemaining => M.ReadByte(Address + 0x75AD); // 51 = 50+, 255 = N/A (Town, etc.)
        #endregion
        #region Delve Info
        public int CurrentSulphiteAmount => M.ReadUShort(Address + 0x7644);
        public int CurrentAzuriteAmount => M.ReadInt(Address + 0x7650);
        #endregion
        public enum NetworkStateE : byte
        {
            None,
            Disconnected,
            Connecting,
            Connected
        }

        public enum PartyStatus
        {
            PartyLeader,
            Invited,
            PartyMember,
            None,
        }

        public enum PartyAllocation : byte
        {
            FreeForAll,
            ShortAllocation,
            PermanentAllocation,
            None,
            NotInParty = 160
        }

        public enum CharacterClass
        {
            Scion,
            Marauder,
            Ranger,
            Witch,
            Duelist,
            Templar,
            Shadow,
            None
        }
    }
}
