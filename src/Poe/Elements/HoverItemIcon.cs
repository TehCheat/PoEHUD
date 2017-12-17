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
        private readonly Func<Element> inventoryItemTooltip;
        private readonly Func<Element> itemInChatTooltip;
        private readonly Func<ItemOnGroundTooltip> toolTipOnground;
        private ToolTipType? toolTip;

        public int InventPosX => M.ReadInt(Address + 0xb60);
        public int InventPosY => M.ReadInt(Address + 0xb64);

        public HoverItemIcon()
        {
            toolTipOnground = () => Game.IngameState.IngameUi.ItemOnGroundTooltip;
            inventoryItemTooltip = () => ReadObject<Element>(Address + 0xB10);
            itemInChatTooltip = () => ReadObject<Element>(Address + 0x7E8);
        }

        public ToolTipType ToolTipType {
            get {
                try {
                    return (ToolTipType)(toolTip ?? (toolTip = GetToolTipType()));
                } catch (Exception)
                {
                    return ToolTipType.None;
                }
            }
        }

        public Element Tooltip
        {
            get
            {
                switch (ToolTipType)
                {
                    case ToolTipType.ItemOnGround:
                        return toolTipOnground().Tooltip;

                    case ToolTipType.InventoryItem:
                        return inventoryItemTooltip();
                    case ToolTipType.ItemInChat:
                        return itemInChatTooltip().Children[1];
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
                        return toolTipOnground().ItemFrame;
                    case ToolTipType.ItemInChat:
                        return itemInChatTooltip().Children[0];
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

                        ItemsOnGroundLabelElement le = Game.IngameState.IngameUi.ReadObjectAt<ItemsOnGroundLabelElement>(0xD08);
                        if (le == null)
                            return null;
                        Entity e = le.ItemOnHover;
                        if (e == null)
                            return null;
                        return e.GetComponent<WorldItem>().ItemEntity;
                    case ToolTipType.InventoryItem:
                        return ReadObject<Entity>(Address + 0xB60);
                    case ToolTipType.ItemInChat:
                        // currently cannot find it.
                        return null;
                }
                return null;
            }
        }

        private ToolTipType GetToolTipType()
        {
            if (inventoryItemTooltip() != null && inventoryItemTooltip().IsVisible)
            {
                return ToolTipType.InventoryItem;
            }
            if (toolTipOnground != null && toolTipOnground().Tooltip != null && toolTipOnground().TooltipUI != null && toolTipOnground().TooltipUI.IsVisible)
            {
                return ToolTipType.ItemOnGround;
            }
            if (itemInChatTooltip() != null && itemInChatTooltip().IsVisible && itemInChatTooltip().ChildCount > 1 && itemInChatTooltip().Children[0].IsVisible && itemInChatTooltip().Children[1].IsVisible)
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
