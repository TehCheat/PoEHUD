using PoeHUD.Poe.Components;
using System;

namespace PoeHUD.Poe.Elements
{
    // Don't confuse this class name with it's purpose.
    // Purpose of this class is to handle/deal with Hover Items, rather than
    // Inventory Item. Hovered items can be on Chat, inventory or on ground.
    // However, if item isn't being hover on then this class isn't reponsible
    // for getting it's info and might give incorrect result.
    public class HoverItemIcon : Element
    {
        private ToolTipType? toolTip;

        public int InventPosX => M.ReadInt(Address + 0x390);
        public int InventPosY => M.ReadInt(Address + 0x394);
		public Element InventoryItemTooltip =>ReadObject<Element>(Address + 0x338);
		public Element ItemInChatTooltip => ReadObject<Element>(Address + 0x1A8);
		public ItemOnGroundTooltip ToolTipOnGround => Game.IngameState.IngameUi.ItemOnGroundTooltip;
	    public ToolTipType ToolTipType => GetToolTipType();

        public Element Tooltip
        {
            get
            {
                switch (ToolTipType)
                {
                    case ToolTipType.ItemOnGround:
                        return ToolTipOnGround.Tooltip;
                    case ToolTipType.InventoryItem:
                        return InventoryItemTooltip;
                    case ToolTipType.ItemInChat:
                        return ItemInChatTooltip.Children[1];
                }
                return null;
            }
        }

        public Element ItemFrame
        {
            get
            {
                switch (ToolTipType)
                {
                    case ToolTipType.ItemOnGround:
                        return ToolTipOnGround.ItemFrame;
                    case ToolTipType.ItemInChat:
                        return ItemInChatTooltip.Children[0];
                    default:
                        return null;
                }
            }
        }

        public Entity Item
        {
            get
            {
                switch (ToolTipType)
                {
                    case ToolTipType.ItemOnGround:
                        // This offset is same as Game.IngameState.IngameUi.ItemsOnGroundLabels offset.
                        ItemsOnGroundLabelElement le = Game.IngameState.IngameUi.ReadObjectAt<ItemsOnGroundLabelElement>(0x5A8);
                        Entity e = le.ItemOnHover;
                        if (e == null)
                            return null;
                        return e.GetComponent<WorldItem>().ItemEntity;
                    case ToolTipType.InventoryItem:
                        return ReadObject<Entity>(Address + 0x388);
                    case ToolTipType.ItemInChat:
                        // currently cannot find it.
                        return null;
                }
                return null;
            }
        }

        private ToolTipType GetToolTipType()
        {
            if (InventoryItemTooltip != null && InventoryItemTooltip.IsVisible)
            {
                return ToolTipType.InventoryItem;
            }
            if (ToolTipOnGround.Tooltip != null && ToolTipOnGround.TooltipUI != null && ToolTipOnGround.TooltipUI.IsVisible)
            {
                return ToolTipType.ItemOnGround;
            }
            if (ItemInChatTooltip.IsVisible && ItemInChatTooltip.ChildCount > 1 && ItemInChatTooltip.Children[0].IsVisible && 
                ItemInChatTooltip.Children[1].IsVisible)
            {
                return ToolTipType.ItemInChat;
            }
            return ToolTipType.None;
        }
    }

    public enum ToolTipType
    {
        None,
        InventoryItem,
        ItemOnGround,
        ItemInChat
    }
}
