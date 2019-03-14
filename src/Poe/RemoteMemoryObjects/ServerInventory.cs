using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ServerInventory : RemoteMemoryObject
    {
        public InventoryTypeE InventType => (InventoryTypeE)M.ReadByte(Address);
        public InventorySlotE InventSlot => (InventorySlotE)M.ReadByte(Address + 0x1);
        public int Columns => M.ReadInt(Address + 0xc);
        public int Rows => M.ReadInt(Address + 0x10);
        public bool IsRequested => M.ReadByte(Address + 0x4) == 1;

        public List<InventSlotItem> InventorySlotItems => ReadHashMap(Address + 0x48).Values.ToList();
        public List<Entity> Items => ReadHashMap(Address + 0x48).Values.Select(x => x.Item).ToList();

        public Dictionary<int, InventSlotItem> ReadHashMap(long pointer)
        {
            var result = new Dictionary<int, InventSlotItem>();

            Stack<HashNode> stack = new Stack<HashNode>();
            var startNode = ReadObject<HashNode>(pointer);
            var item = startNode.Root;
            stack.Push(item);

            while (stack.Count != 0)
            {
                HashNode node = stack.Pop();
                if (!node.IsNull)
                    result.Add(node.Key, node.Value1);

                HashNode prev = node.Previous;
                if (!prev.IsNull)
                    stack.Push(prev);

                HashNode next = node.Next;
                if (!next.IsNull)
                    stack.Push(next);
            }
            return result;
        }

   
        public class HashNode : RemoteMemoryObject
        {
            public HashNode Previous => ReadObject<HashNode>(Address);
            public HashNode Root => ReadObject<HashNode>(Address + 0x8);
            public HashNode Next => ReadObject<HashNode>(Address + 0x10);
            //public readonly byte Unknown;
            public bool IsNull => M.ReadByte(Address + 0x19) != 0;
            //private readonly byte byte_0;
            //private readonly byte byte_1;
            public int Key => M.ReadInt(Address + 0x20);
            //public readonly int Useless;
            public InventSlotItem Value1 => ReadObject<InventSlotItem>(Address + 0x28);
            //public readonly long Value2;
        }

        public class InventSlotItem : RemoteMemoryObject
        {
            public Entity Item => ReadObject<Entity>(Address);
            public int PosX => M.ReadInt(Address + 0x8);
            public int PosY => M.ReadInt(Address + 0xc);
         
            public override string ToString()
            {
                return $"InventSlotItem. PosX: {PosX}, PosY: {PosY}, Item: {Item}";
            }
        }

    }

    public enum InventorySlotE
    {
        ArmourersWorkbench = 0x10,
        ArtisansBench = 0x13,
        Belt = 10,
        BlessingFont = 0x15,
        Boots = 9,
        BowmakersTools = 0x12,
        Chest = 1,
        Cursor = 12,
        DarkShrine = 0x1c,
        Divination = 0x1b,
        Flasks = 11,
        Gloves = 8,
        Head = 4,
        Headstones = 20,
        Leaguestone = 30,
        LeftHand = 2,
        LeftRing = 6,
        Main = 0,
        MapDevice = 13,
        Neck = 5,
        Npc = 0x1f,
        OffLeftHand = 14,
        OffRightHand = 15,
        PassiveTreeJewels = 0x17,
        RightHand = 3,
        RightRing = 7,
        SharpeningWheel = 0x11,
        Stash = 0x1a,
        Talisman = 0x1d
    }

    public enum InventoryTypeE
    {
        Belt = 9,
        Boots = 8,
        Chest = 1,
        Cursor = 11,
        Flasks = 10,
        Gloves = 7,
        Head = 4,
        Leaguestone = 0x10,
        LeftHand = 2,
        Main = 0,
        MapDevice = 12,
        Neck = 5,
        PassiveTree = 13,
        RightHand = 3,
        Rings = 6,
        Unknown1 = 14,
        Stash = 15,
        Unknown2 = 17,
        Trade = 18,
	    TinysTrialCraftTableCurrency_undefined = 24,

		/// <summary>
		/// Transmute, alter, regal, exalts
		/// </summary>
	    TinysTrialCraftTableCurrency = 25,
	    TinysTrialCraftTableItem = 26
    }
}
