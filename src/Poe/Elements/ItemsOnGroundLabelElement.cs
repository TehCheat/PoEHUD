﻿using System;
using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{
    public class ItemsOnGroundLabelElement : Element
    {
		public Element Label => ReadObject<Element>(Address + 0x8);
		public Entity ItemOnGround => ReadObject<Entity>(Address + 0xC);

		private const int ChildStartOffset = 0x254;
		private const int ChildEndOffset = 0x258;

		private readonly Lazy<int> labelInfo;

        /*
        public ItemsOnGroundLabelElement()
        {
            //labelInfo = new Lazy<int>(GetLabelInfo);
        }
        */

        //public bool CanPickUp => labelInfo.Value == 0;

        /*
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
        */

        //public TimeSpan MaxTimeForPickUp => !CanPickUp ? TimeSpan.FromMilliseconds(M.ReadInt(labelInfo.Value + 0x1C)) : new TimeSpan();
        public new bool IsVisible => Label.IsVisible;

        public new IEnumerable<ItemsOnGroundLabelElement> Children
		{
		// iterate through child entities
		get
			{
                int address = M.ReadInt(M.ReadInt(Address + OffsetBuffers + ChildStartOffset));

                for (int nextAddress = M.ReadInt(address); nextAddress != address; nextAddress = M.ReadInt(nextAddress))
                {
                    yield return GetObject<ItemsOnGroundLabelElement>(nextAddress);
                }
            }
        }

        private int GetLabelInfo()
        {
            return Label.Address != 0 ? M.ReadInt(Label.Address + OffsetBuffers + 0x59C) : 0;
        }
    }
}