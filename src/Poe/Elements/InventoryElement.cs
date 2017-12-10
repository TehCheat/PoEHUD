using PoeHUD.Models.Enums;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Elements
{
    public class InventoryElement : Element
    {
        private InventoryList AllInventories => GetObjectAt<InventoryList>(0xB20-8);
        public Inventory this[InventoryIndex k]
        {
            get
            {
                return AllInventories[k];
            }
        }
    }
}