using System.Collections.Generic;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Elements
{
    public class ItemsOnGroundLabelElement : Element
    {
        public Element LabelOnHover
        {
            get
            {
                var readObjectAt = ReadObjectAt<Element>(0x248);
                return readObjectAt.Address == 0 ? null : readObjectAt;
            }
        }

        public Entity ItemOnHover
        {
            get
            {
                var readObjectAt = ReadObjectAt<Entity>(0x250);
                return readObjectAt.Address == 0 ? null : readObjectAt;
            }
        }

        public string ItemOnHoverPath => ItemOnHover != null ? ItemOnHover.Path : "Null";
        public string LabelOnHoverText => LabelOnHover != null ? LabelOnHover.Text : "Null";


        public int CountLabels => M.ReadInt(Address + 0x268);
        public int CountLabels2 => M.ReadInt(Address + 0x2A8);

        public new List<LabelOnGround> LabelsOnGround
        {
            get
            {
                long address = M.ReadLong(Address + 0x2A0);

                var result = new List<LabelOnGround>();
                if (address <= 0)
                    return null;
                var limit = 0;
                for (long nextAddress = M.ReadLong(address); nextAddress != address; nextAddress = M.ReadLong(nextAddress))
                {
                    result.Add(GetObject<LabelOnGround>(nextAddress));
                    limit++;
                    if (limit > 1000)
                        return null;
                }

                return result;
            }
        }
    }
}