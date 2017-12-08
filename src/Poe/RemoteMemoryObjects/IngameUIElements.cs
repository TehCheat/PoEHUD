using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public SkillBarElement SkillBar => ReadObjectAt<SkillBarElement>(0xB50);
        public SkillBarElement HiddenSkillBar => ReadObjectAt<SkillBarElement>(0xB58);
        public PoeChatElement ChatBox => ReadObjectAt<PoeChatElement>(0xBD0);
        public Element QuestTracker => ReadObjectAt<Element>(0xC00);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xC40);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xC48);
        public InventoryElement InventoryPanel => ReadObjectAt<InventoryElement>(0xC78);
        public Element TreePanel => ReadObjectAt<Element>(0xCA8);
        public Element AtlasPanel => ReadObjectAt<Element>(0xCB0);
        public Map Map => ReadObjectAt<Map>(0xD00);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xD08);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xF10);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xF78);
    }
}

