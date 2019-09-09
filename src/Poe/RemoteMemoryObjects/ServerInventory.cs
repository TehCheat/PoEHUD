using System.Collections.Generic;
using System.Linq;
using PoeHUD.Controllers;
using PoeHUD.Models.Enums;
using SharpDX;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ServerInventory : RemoteMemoryObject
    {
        public InventoryTypeE InventType => (InventoryTypeE) M.ReadInt(Address);
        public InventorySlotE InventSlot => (InventorySlotE) M.ReadByte(Address + 0x01);//was M.ReadInt(Address + 0x04);
        public int Columns => M.ReadInt(Address + 0x0C);
        public int Rows => M.ReadInt(Address + 0x10);

        public List<InventSlotItem> InventorySlotItems => ReadHashMap(Address + 0x48).Values.ToList();
        public List<Entity> Items => ReadHashMap(Address + 0x48).Values.Select(x => x.Item).ToList();

        public int TotalItemsCounts => M.ReadInt(Address + 0x50);

        public int ServerRequestCounter => M.ReadInt(Address + 0xA8);

        /// <summary>
        /// Will return the item based on x,y format.
        /// Give more control to caller on what to do with
        /// duplicate items (items taking more than 1 slot)
        /// or slots where items doesn't exists (return null).
        /// 
        /// NOTE: currently this won't work for currency type stashes.
        /// </summary>
        /// <param name="x">Inventory slot X axis</param>
        /// <param name="y">Inventory slot Y axis</param>
        /// <returns>InventSlotItem</returns>
        public InventSlotItem this[int x, int y]
        {
            get
            {
                long invAddr = M.ReadLong(Address + 0x30);
                y = y * Columns;
                long itmAddr = M.ReadLong(invAddr + ((x + y) * 8));
                if (itmAddr <= 0)
                    return null;
                return GetObject<InventSlotItem>(itmAddr);
            }
        }

        public Dictionary<int, InventSlotItem> ReadHashMap(long pointer)
        {
            var result = new Dictionary<int, InventSlotItem>();

            Stack<HashNode> stack = new Stack<HashNode>();
            var startNode = ReadObject<HashNode>(pointer);
            var item = startNode.Root;
            stack.Push(item);

            var stuckCounter = 500;
            while (stack.Count != 0 && stuckCounter-- > 0)
            {
                HashNode node = stack.Pop();

                if (!node.IsNull)
                    result[node.Key] = node.Value1;

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
            public bool IsNull => Address != 0 && M.ReadByte(Address + 0x19) != 0;

            //private readonly byte byte_0;
            //private readonly byte byte_1;
            public int Key => M.ReadInt(Address + 0x20);

            //public readonly int Useless;
            public InventSlotItem Value1 => ReadObject<InventSlotItem>(Address + 0x28);

            //public readonly long Value2;
        }

        public class InventSlotItem : RemoteMemoryObject
        {
            private struct ItemMinMaxLocation
            {
                private int XMin;
                private int YMin;
                private int XMax;
                private int YMax;

                public RectangleF GetItemRect(float invStartX, float invStartY, float cellsize)
                {
                    return new RectangleF(
                        invStartX + cellsize * XMin,
                        invStartY + cellsize * YMin,
                        (XMax - XMin) * cellsize,
                        (YMax - YMin) * cellsize);
                }

                public Vector2 InventoryPosition => new Vector2(XMin, YMin);

                public override string ToString()
                {
                    return $"({XMin}, {YMin}, {XMax}, {YMax})";
                }
            };

            public Entity Item => ReadObject<Entity>(Address);

            private ItemMinMaxLocation Location => M.IntptrToStruct<ItemMinMaxLocation>(
                M.ReadBytes(Address + 0x08, 0x0C * sizeof(int)));

            //public byte UnknownCounter => M.ReadByte(Address + 0x18);
            //public byte UnnknownInventoryID => M.ReadByte(Address + 0x19);

            private RectangleF ClientRect => GetClientRect();

            public Vector2 InventoryPosition => Location.InventoryPosition;

            public RectangleF GetClientRect()
            {
                var playerInventElement = GameController.Instance.Game.IngameState.IngameUi.InventoryPanel[InventoryIndex.PlayerInventory];
                var inventClientRect = playerInventElement.GetClientRect();
                var cellSize = inventClientRect.Width / 12;
                return Location.GetItemRect(inventClientRect.X, inventClientRect.Y, cellSize);
            }

            public override string ToString()
            {
                return $"InventSlotItem: {Location}, Item: {Item}";
            }
        }
    }

    /// <summary>
    /// Copied from GGPK -> Inventories.dat file
    /// Possible improvement -> read it from the in memory dad file
    /// </summary>
    public enum InventorySlotE
    {
        MainInventory1,
        BodyArmour1,
        Weapon1,
        Offhand1,
        Helm1,
        Amulet1,
        Ring1,
        Ring2,
        Gloves1,
        Boots1,
        Belt1,
        Flask1,
        Cursor1,
        Map1,
        Weapon2,
        Offhand2,
        StrMasterCrafting,
        StrDexMasterCrafting,
        DexMasterCrafting,
        DexIntMasterCrafting,
        IntMasterCrafting,
        StrIntMasterCrafting,
        PVPMasterCrafting,
        PassiveJewels1,
        AnimatedArmour1,
        GuildTag1,
        StashInventoryId,
        DivinationCardTrade,
        Darkshrine,
        TalismanTrade,
        Leaguestone1,
        BestiaryCrafting,
        IncursionSacrifice,
        BetrayalUnveiling,
        ItemSynthesisInput,
        ItemSynthesisOutput,
    }

    /// <summary>
    /// Copied from GGPK -> InventoryType.dat file
    /// Possible improvement -> read it from the in memory dad file
    /// </summary>
    public enum InventoryTypeE
    {
        MainInventory = 0x00,
        BodyArmour,
        Weapon,
        Offhand,
        Helm,
        Amulet,
        Ring,
        Gloves,
        Boots,
        Belt,
        Flask,
        Cursor,
        Map,
        PassiveJewels,
        AnimatedArmour,
        Crafting,
        Leaguestone,
        Unused,
        Currency,
        Offer,
        Divination,
        Essence,
        Fragment,
        MapStashInv,
        UniqueStashInv,
        CraftingSpreeCurrency,
        CraftingSpreeItem,
        NormalOrQuad
    }
}
