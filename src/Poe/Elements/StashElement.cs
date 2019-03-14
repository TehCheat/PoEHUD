using PoeHUD.Poe.RemoteMemoryObjects;
using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{
    using System;

    public class StashElement : Element
    {
        public long TotalStashes => StashInventoryPanel.ChildCount;
        public bool HasScrollBar => TotalStashes >= 30;

        public Element ExitButton => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0x2B8)) : null;//or (10, A88) or (708, AA0) or (998, 100) or better (AA0, 708)

        // Nice struct starts at 0xB80 till 0xBD0 and all are 8 byte long pointers.
        public Element StashTitlePanel => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0x2D8, 0x428)) : null;
        public Element StashInventoryPanel => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0x2D8, 0x438)) : null;
 
        public Element ViewAllStashButton => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0x2D8, 0x440)) : null;

        //Not easy to find it, coz it like a tooltipe element. Use IngameState.UIHoverTooltip instead IngameState.UIHover. Use it's address and StructureSpiderAdvanced to find it's offset fast.
        public Element ViewAllStashPanel => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0x2D8, 0x448)) : null;

        public Element MoveStashTabLabelsLeft_Button => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0x2D8, 0x450)) : null;
        public Element MoveStashTabLabelsRight_Button => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0x2D8, 0x458)) : null;


        public int IndexVisibleStash => M.ReadInt(Address + 0x2D8, 0x480);
        public Inventory VisibleStash => GetVisibleStash();
        private Inventory GetVisibleStash()
        {
            return GetStashInventoryByIndex(IndexVisibleStash);
        }

        public List<string> AllStashNames => GetAllStashNames();
        private List<string> GetAllStashNames()
        {
            List<string> ret = new List<string>();
            for (int i = 0; i < TotalStashes; i++)
            {
                ret.Add(GetStashName(i));
            }
            return ret;
        }

        public Inventory GetStashInventoryByIndex(int index)//This one is correct
        {
            if (index >= TotalStashes)
                return null;
            if (StashInventoryPanel.Children[index].ChildCount == 0)
                return null;
            return StashInventoryPanel.Children[index].Children[0].Children[0].AsObject<Inventory>();
        }

        public string GetStashName(int index)
        {
            if (index >= TotalStashes || index < 0)
                return string.Empty;

            //When users have a scrollbar we should read child 1 instead of 2
            var readChild = ViewAllStashPanel.GetChildAtIndex(HasScrollBar ? 1 : 2);
            var readChild2 = readChild.GetChildAtIndex(index);

            return readChild2.GetChildAtIndex((int)Math.Max(0, readChild2.ChildCount - 1)).Text;
        }
    }
}