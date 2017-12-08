using System;
using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{
    public class ItemsOnGroundLabelElement : Element
    {
        private readonly Lazy<long> labelInfo;

        public ItemsOnGroundLabelElement()
        {
            labelInfo = new Lazy<long>(GetLabelInfo);
        }

        public Element Label => ReadObjectAt<Element>(0x10); // LabelsOnGround
        public Entity ItemOnGround => ReadObjectAt<Entity>(0x18); //ItemsOnGround

        public Element LabelOnHover => ReadObjectAt<Element>(OffsetBuffers + 0x334);
        public Entity ItemOnHover => ReadObjectAt<Entity>(OffsetBuffers + 0x33C);

        public bool CanPickUp => labelInfo.Value == 0;

        public TimeSpan TimeLeft
        {
            get
            {
                if (!CanPickUp)
                {
                    int futureTime = M.ReadInt(labelInfo.Value + 0x38);
                    return TimeSpan.FromMilliseconds(futureTime - Environment.TickCount);
                }
                return new TimeSpan();
            }
        }

        public TimeSpan MaxTimeForPickUp => !CanPickUp ? TimeSpan.FromMilliseconds(M.ReadInt(labelInfo.Value + 0x34)) : new TimeSpan();
        public new bool IsVisible => Label.IsVisible;

        public new IEnumerable<ItemsOnGroundLabelElement> Children
        {
            get
            {
                long address = M.ReadLong(Address + OffsetBuffers + 0x34C);

                for (long nextAddress = M.ReadLong(address); nextAddress != address; nextAddress = M.ReadLong(nextAddress))
                {
                    yield return GetObject<ItemsOnGroundLabelElement>(nextAddress);
                }
            }
        }

        private long GetLabelInfo()
        {
            return Label.Address != 0 ? M.ReadLong(Label.Address + OffsetBuffers + 0x694) : 0;
        }
    }
}