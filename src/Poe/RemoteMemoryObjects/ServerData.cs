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
        public StashElement StashPanel => Address != 0 ? GetObject<StashElement>(M.ReadLong(Address + 0x3C8, 0xA0, 0x78)) : null;

        public ushort TradeChatChannel => M.ReadUShort(Address + 0x4DC8);
        public ushort GlobalChatChannel => M.ReadUShort(Address + 0x4DD0);
        public byte MonsterLevel => M.ReadByte(Address + 0x5924);

        //if 51 - more than 50 monsters remaining (no exact number)
        //if 255 - not supported for current map (town or scenary map)
        public CharacterClass PlayerClass => (CharacterClass)(M.ReadByte(Address + 0x4810) & 0xF);
        public byte MonstersRemaining => M.ReadByte(Address + 0x5925);

        #region PlayerData
        public ushort LastActionId => M.ReadUShort(Address + 0x4E20);
        public int CharacterLevel => M.ReadInt(Address + 0x4814);
        public int PassiveRefundPointsLeft => M.ReadInt(Address + 0x4818);
        public int QuestPassiveSkillPoints => M.ReadInt(Address + 0x481C);
		public int FreePassiveSkillPointsLeft => M.ReadInt(Address + 0x4820);
		public int TotalAscendencyPoints => M.ReadInt(Address + 0x4824);
        public int SpentAscendencyPoints => M.ReadInt(Address + 0x4828);
        public string League => GetObject<NativeStringReader>(Address + 0x4868).Value;
        public PartyAllocation PartyAllocationType => (PartyAllocation)M.ReadByte(Address + 0x4a28);
        public bool IsInGame => GameController.UseGameStateController ? GameStateController.IsInGameState : NetworkState == NetworkStateE.Connected;
        public NetworkStateE NetworkState => (NetworkStateE)M.ReadByte(Address + 0x4850);
        public int Latency => M.ReadInt(Address + 0x48D0);
        public List<ushort> SkillBarIds
        {
            get
            {
                var result = new List<ushort>();

                var readAddr = Address + 0x4a98;
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
                var fisrPtr = M.ReadLong(Address + 0x47A0);
                var endPtr = M.ReadLong(Address + 0x47A8);
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
                var startPtr = M.ReadLong(Address + 0x4ad8);
                var endPtr = M.ReadLong(Address + 0x4ae0);
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
        private const int PlayerStashTabsStartOffset = 0x48e0;
        private const int PlayerStashTabsEndOffset = 0x48e8;


        public List<ServerStashTab> PlayerStashTabs => GetStashTabs(PlayerStashTabsStartOffset, PlayerStashTabsEndOffset);
        public List<ServerStashTab> GuildStashTabs => GetStashTabs(0x48F8, 0x4900);
        private List<ServerStashTab> GetStashTabs(int offsetBegin, int offsetEnd)
        {
            var firstAddr = M.ReadLong(Address + offsetBegin);
            var lastAddr = M.ReadLong(Address + offsetEnd);

            var tabs = M.ReadStructsArray<ServerStashTab>(firstAddr, lastAddr, ServerStashTab.StructSize, 5000);

            //Skipping hidden tabs of premium maps tab (read notes in StashTabController.cs)
            tabs.RemoveAll(x => (x.Flags & ServerStashTab.InventoryTabFlags.Hidden) == ServerStashTab.InventoryTabFlags.Hidden);
            return tabs;
        }
        #endregion
        #region Inventories
        public List<InventoryHolder> PlayerInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x4BA8);
                var lastAddr = M.ReadLong(Address + 0x4BB0);
                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 400);
            }
        }
        public List<InventoryHolder> NPCInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x4C50);
                var lastAddr = M.ReadLong(Address + 0x4C58);

                if (firstAddr == 0)
                    return new List<InventoryHolder>();

                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 100);
            }
        }

        public List<InventoryHolder> GuildInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x4CF8);
                var lastAddr = M.ReadLong(Address + 0x4D00);
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
        public List<WorldArea> CompletedAreas => GetAreas(0x4E90);
        public List<WorldArea> ShapedMaps => GetAreas(0x4ED0);
        public List<WorldArea> BonusCompletedAreas => GetAreas(0x4F10);
        public List<WorldArea> ElderGuardiansAreas => GetAreas(0x4F50);
        public List<WorldArea> ShaperElderAreas => GetAreas(0x4F90);

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


        public int GetBeastCapturedAmount(BestiaryCapturableMonster monster)
        {
            return M.ReadInt(Address + 0x5120 + monster.Id * 4);
        }


        public enum NetworkStateE : byte
        {
            None,
            Disconnected,
            Connecting,
            Connected
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