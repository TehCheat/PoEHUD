using System;
using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{
    public class ItemsOnGroundLabelElement : Element
    {
        private readonly Lazy<int> labelInfo;

        public ItemsOnGroundLabelElement()
        {
            labelInfo = new Lazy<int>(GetLabelInfo);
        }

        public Entity ItemOnGround => ReadObject<Entity>(Address + 0xC);
        public Element Label => ReadObject<Element>(Address + 0x8);
        public bool CanPickUp => labelInfo.Value == 0;

        public TimeSpan TimeLeft
        {
            get
            {
                if (!CanPickUp)
                {
                    int futureTime = M.ReadInt(labelInfo.Value + 0x20);
                    return TimeSpan.FromMilliseconds(futureTime - Environment.TickCount);
                }
                return new TimeSpan();
            }
        }

        public TimeSpan MaxTimeForPickUp => !CanPickUp ? TimeSpan.FromMilliseconds(M.ReadInt(labelInfo.Value + 0x1C)) : new TimeSpan();
        public new bool IsVisible => Label.IsVisible;

        public new IEnumerable<ItemsOnGroundLabelElement> Children
        {
            get
            {
                int address = M.ReadInt(Address + 0x944);
                for (int nextAddress = M.ReadInt(address); nextAddress != address; nextAddress = M.ReadInt(nextAddress))
                {
                    yield return GetObject<ItemsOnGroundLabelElement>(nextAddress);
                }
            }
        }

        private int GetLabelInfo()
        {
            return Label.Address != 0 ? M.ReadInt(Label.Address + 0xBC4) : 0;
        }
    }
}