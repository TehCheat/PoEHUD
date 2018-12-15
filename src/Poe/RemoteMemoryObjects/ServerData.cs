using System;
using System.Collections.Generic;
using PoeHUD.Poe.Elements;
using PoeHUD.Controllers;
using PoeHUD.Poe.Components;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class ServerData : RemoteMemoryObject
	{
		//[Obsolete("Obsolete. Use StashTabs instead")]
		public StashElement StashPanel => Address != 0 ? GetObject<StashElement>(M.ReadLong(Address + 0x4C8, 0xA0, 0x78)) : null;

		public PartyStatus PartyStatusType => (PartyStatus)M.ReadByte(Address + 0x5D88);

		public CharacterClass PlayerClass => (CharacterClass)(M.ReadByte(Address + 0x5B90) & 0xF);

		public List<ushort> PassiveSkillIds
		{
			get
			{
				var fisrPtr = M.ReadLong(Address + 0x5B20);
				var endPtr = M.ReadLong(Address + 0x5B28);

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
		public int CharacterLevel => M.ReadInt(Address + 0x5B94);
		public int PassiveRefundPointsLeft => M.ReadInt(Address + 0x5018);//TODO Fixme
		public int QuestPassiveSkillPoints => M.ReadInt(Address + 0x501C);//TODO Fixme
		public int FreePassiveSkillPointsLeft => M.ReadInt(Address + 0x5020);//TODO Fixme
		public int TotalAscendencyPoints => M.ReadInt(Address + 0x5024);//TODO Fixme
		public int SpentAscendencyPoints => M.ReadInt(Address + 0x5028);//TODO Fixme
		public float TimeInGame => M.ReadFloat(Address + 0x5C48);

		public NetworkStateE NetworkState => (NetworkStateE)M.ReadByte(Address + 0x5BD0);
		public bool IsInGame => true ? GameStateController.IsInGameState : NetworkState == NetworkStateE.Connected;

		public string League => NativeStringReader.ReadString(Address + 0x5BE8);
		public PartyAllocation PartyAllocationType => (PartyAllocation)M.ReadByte(Address + 0x50B5);//TODO Fixme
		public int Latency => M.ReadInt(Address + 0x5C50);
		#endregion
		#region Stash Tabs
		public List<ServerStashTab> PlayerStashTabs => GetStashTabs(0x5C60, 0x5C68);
		public List<ServerStashTab> GuildStashTabs => GetStashTabs(0x5C78, 0x5C80);
		private List<ServerStashTab> GetStashTabs(int offsetBegin, int offsetEnd)
		{
			var firstAddr = M.ReadLong(Address + offsetBegin);
			var lastAddr = M.ReadLong(Address + offsetEnd);

			var tabs = M.ReadStructsArray<ServerStashTab>(firstAddr, lastAddr, ServerStashTab.StructSize, 200);

			//Skipping hidden tabs of premium maps tab (read notes in StashTabController.cs)
			tabs.RemoveAll(x => x.IsHidden);
			return tabs;
		}
		#endregion

		public string Guild => NativeStringReader.ReadString(M.ReadLong(Address + 0x5290));//TODO Fixme

		public List<ushort> SkillBarIds
		{
			get
			{
				var result = new List<ushort>();

				var readAddr = Address + 0x5E18;
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
				var startPtr = M.ReadLong(Address + 0x5E58);
				var endPtr = M.ReadLong(Address + 0x5E60);

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
				var firstAddr = M.ReadLong(Address + 0x5F38);
				var lastAddr = M.ReadLong(Address + 0x5F40);
				return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 400);
			}
		}
		public List<InventoryHolder> NPCInventories
		{
			get
			{
				var firstAddr = M.ReadLong(Address + 0x5FE8);
				var lastAddr = M.ReadLong(Address + 0x5FF0);

				if (firstAddr == 0)
					return new List<InventoryHolder>();

				return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 100);
			}
		}

		public List<InventoryHolder> GuildInventories
		{
			get
			{
				var firstAddr = M.ReadLong(Address + 0x6098);
				var lastAddr = M.ReadLong(Address + 0x60A0);
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

		public ushort TradeChatChannel => M.ReadUShort(Address + 0x6190);
		public ushort GlobalChatChannel => M.ReadUShort(Address + 0x6198);
		public ushort LastActionId => M.ReadUShort(Address + 0x61E4);

		#region Completed Areas
		public List<WorldArea> ElderGuardiansAreas=> GetAreas(0x6230);//TODO Fixme
		public List<WorldArea> CompletedAreas => GetAreas(0x6260);
		public List<WorldArea> ShapedMaps => GetAreas(0x62A0);
		public List<WorldArea> BonusCompletedAreas => GetAreas(0x62E0);
		public List<WorldArea> UnknownAreas => GetAreas(0x6320);//TODO Fixme
		public List<WorldArea> MasterAreas => GetAreas(0x6360);
		public List<WorldArea> ShaperElderAreas => GetAreas(0x63A0);

		private List<WorldArea> GetAreas(int offset)
		{
			var result = new List<WorldArea>();
			var size = M.ReadInt(Address + offset - 0x8);
			var listStart = M.ReadLong(Address + offset);

		    if (size == 0 || size > 300)
		        return result;
		    listStart = M.ReadLong(listStart);
			for (var addr = M.ReadLong(listStart); addr != listStart; addr = M.ReadLong(addr))
			{
				result.Add(GameController.Instance.Files.WorldAreas.GetByAddress(M.ReadLong(addr + 0x18)));
				if (--size < 0) break;
			}
			return result;
		}
		#endregion
		#region Monster Info
		public byte MonsterLevel => M.ReadByte(Address + 0x6D44);
		public byte MonstersRemaining => M.ReadByte(Address + 0x6D45); // 51 = 50+, 255 = N/A (Town, etc.)
		#endregion
		#region Delve Info
		public int CurrentSulphiteAmount => M.ReadUShort(Address + 0x6DDC);
		public int CurrentAzuriteAmount => M.ReadInt(Address + 0x6DE8);
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