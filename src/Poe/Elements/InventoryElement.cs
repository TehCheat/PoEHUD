using System;
using PoeHUD.Models.Enums;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Elements
{
    public class InventoryElement : Element
    {
        private InventoryList AllInventories => GetObjectAt<InventoryList>(OffsetBuffers + 0x434 + 0x08);
        public Inventory this[InventoryIndex k]
        {
            get
            {
                return AllInventories[k];
            }
        }

        //for debug
        [Obsolete("This property is for debug only, use indexer [InventoryIndex.PlayerInventory] instead")]
        private Inventory PlayerInventory => this[InventoryIndex.PlayerInventory];
    }
}