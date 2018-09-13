using System;
using System.Collections.Generic;
using PoeHUD.Poe.Elements;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Models;
using PoeHUD.Poe.Components;
using PoeHUD.Models.Attributes;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ServerData : RemoteMemoryObject
    {
        //[Obsolete("Obsolete. Use StashTabs instead")]
        public StashElement StashPanel => Address != 0 ? GetObject<StashElement>(M.ReadLong(Address + 0x4C8, 0xA0, 0x78)) : null;

        public ushort TradeChatChannel => M.ReadUShort(Address + 0x5568);
        public ushort GlobalChatChannel => M.ReadUShort(Address + 0x5570);
        public byte MonsterLevel => M.ReadByte(Address + 0x60CC);

        //if 51 - more than 50 monsters remaining (no exact number)
        //if 255 - not supported for current map (town or scenary map)
        public CharacterClass PlayerClass => (CharacterClass)(M.ReadByte(Address + 0x4F90) & 0xF);
        public byte MonstersRemaining => M.ReadByte(Address + 0x60CD);

        #region PlayerData
        public ushort LastActionId => M.ReadUShort(Address + 0x55C0);
        public int CharacterLevel => M.ReadInt(Address + 0x4F94);
        public int PassiveRefundPointsLeft => M.ReadInt(Address + 0x4F98);
        public int QuestPassiveSkillPoints => M.ReadInt(Address + 0x4F9C);
		public int FreePassiveSkillPointsLeft => M.ReadInt(Address + 0x4FA0);
		public int TotalAscendencyPoints => M.ReadInt(Address + 0x4FA4);
        public int SpentAscendencyPoints => M.ReadInt(Address + 0x4FA8);
        public string League => NativeStringReader.ReadString(Address + 0x4FE8);
        public string Guild => NativeStringReader.ReadString(M.ReadLong(Address + 0x5210));
	    public PartyStatus PartyStatusType => (PartyStatus)M.ReadByte(Address + 0x4F08);
        public PartyAllocation PartyAllocationType => (PartyAllocation)M.ReadByte(Address + 0x5021);
        public bool IsInGame => GameController.UseGameStateController ? GameStateController.IsInGameState : NetworkState == NetworkStateE.Connected;
        public NetworkStateE NetworkState => (NetworkStateE)M.ReadByte(Address + 0x4FD0); // + 0x500
        public int Latency => M.ReadInt(Address + 0x5050);
        public List<ushort> SkillBarIds
        {
            get
            {
                var result = new List<ushort>();

                var readAddr = Address + 0x5218;
                for (int i = 0; i < 8; i++)
                {
                    result.Add(M.ReadUShort(readAddr));
                    readAddr += 2;
                }
                return result;
            }
        }
        public List<ushort> PassiveSkillIds
        {
            get
            {
                var fisrPtr = M.ReadLong(Address + 0x4F20);
                var endPtr = M.ReadLong(Address + 0x4F28);
                //var lastPtr = M.ReadLong(Address + 0x47B0);

                int total_stats = (int)(endPtr - fisrPtr);
                var bytes = M.ReadBytes(fisrPtr, total_stats);
                var result = new List<ushort>();

                for (int i = 0; i < bytes.Length; i += 2)
                {
                    var id = BitConverter.ToUInt16(bytes, i);
                    result.Add(id);
                }
                return result;
            }
        }
        #endregion
        public List<Player> NearestPlayers
        {
            get
            {
                var startPtr = M.ReadLong(Address + 0x5258);
                var endPtr = M.ReadLong(Address + 0x5260);
                startPtr += 16;//Don't ask me why. Just skipping first 2

                var result = new List<Player>();
                for (var addr = startPtr; addr < endPtr; addr += 16)//16 because we are reading each second pointer (pointer vectors)
                {
                    result.Add(ReadObject<Player>(addr));
                }
                return result;
            }
        }

        #region Stash Tabs
        public List<ServerStashTab> PlayerStashTabs => GetStashTabs(0x5060, 0x5068);
        public List<ServerStashTab> GuildStashTabs => GetStashTabs(0x5078, 0x5080);
        private List<ServerStashTab> GetStashTabs(int offsetBegin, int offsetEnd)
        {
            var firstAddr = M.ReadLong(Address + offsetBegin);
            var lastAddr = M.ReadLong(Address + offsetEnd);

            var tabs = M.ReadStructsArray<ServerStashTab>(firstAddr, lastAddr, ServerStashTab.StructSize, 500);

            //Skipping hidden tabs of premium maps tab (read notes in StashTabController.cs)
            tabs.RemoveAll(x => x.IsHidden);
            return tabs;
        }
        #endregion
        #region Inventories
        public List<InventoryHolder> PlayerInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x5338);
                var lastAddr = M.ReadLong(Address + 0x5340);
                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 400);
            }
        }
        public List<InventoryHolder> NPCInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x53E8);
                var lastAddr = M.ReadLong(Address + 0x53F0);

                if (firstAddr == 0)
                    return new List<InventoryHolder>();

                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 100);
            }
        }

        public List<InventoryHolder> GuildInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x5498);
                var lastAddr = M.ReadLong(Address + 0x54A0);
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
        #region Completed Areas
        public List<WorldArea> CompletedAreas => GetAreas(0x5660);
        public List<WorldArea> ShapedMaps => GetAreas(0x56A0);
        public List<WorldArea> BonusCompletedAreas => GetAreas(0x56E0);
        public List<WorldArea> ElderGuardiansAreas => GetAreas(0x5720);
        public List<WorldArea> ShaperElderAreas => GetAreas(0x5760);

        private List<WorldArea> GetAreas(int offset)
        {
            var result = new List<WorldArea>();
            var size = M.ReadInt(Address + offset - 0x8);
            var listStart = M.ReadLong(Address + offset);

            for (var addr = M.ReadLong(listStart); addr != listStart; addr = M.ReadLong(addr))
            {
                result.Add(GameController.Instance.Files.WorldAreas.GetByAddress(M.ReadLong(addr + 0x18)));
                if (--size < 0) break;
            }
            return result;
        }
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