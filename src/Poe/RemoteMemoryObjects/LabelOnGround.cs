using System;
using PoeHUD.Poe.Components;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class LabelOnGround : RemoteMemoryObject
    {
        private readonly Lazy<long> labelInfo;
        private readonly Lazy<string> debug;

        public LabelOnGround() {
            labelInfo = new Lazy<long>(GetLabelInfo);
            debug = new Lazy<string>(() =>
            {
                return ItemOnGround.HasComponent<WorldItem>()
                    ? ItemOnGround.GetComponent<WorldItem>().ItemEntity.GetComponent<Base>().Name
                    : ItemOnGround.Path;
            });
        }

		private long GetLabelInfo()
		{
			if (Label != null)
			{
				return Label.Address != 0 ? M.ReadLong(Label.Address + 0x3A8) : 0; // No idea if this is correct, but it's not 0x6A4
			}
			else return 0;
		}

        public bool IsVisible
		{
			get
			{
				if (Label != null)
				{
					return Label.IsVisible;
				}
				return false;
			}
		}

        public Entity ItemOnGround
        {
            get
            {
                var readObjectAt = ReadObjectAt<Entity>(0x10);
                return readObjectAt.Address == 0 ? null : readObjectAt;
            }
        }

        public Element Label
        {
            get
            {
                var readObjectAt = ReadObjectAt<Element>(0x18);
                return readObjectAt.Address == 0 ? null : readObjectAt;
            }
        }


        //Howto find CanPickUp offset:
        //You need few items on ground rolled to you, other rolled to ur party member.
        //In dev plugin open IngameUI->ItemOnGroundLabels
        //Find item that rolled to you (element->Label->Draw this), copy address of this label (element->Label->Address)
        //Open Structure Spider Advanced (https://github.com/Stridemann/StructureSpiderAdvanced)
        //Search for: Long
        //Address - (paste address of that label)
        //Value: 0 
        //Compare type: Equal
        //Do scan. Then do scan again but with address of label that rolled to party member just switch to "Compare type: NotEqual"
        //Repeat this multiple time with different labels and you get ur offset in 5-7 iterations.
        public bool CanPickUp
		{
			get
			{
				if (Label != null)
				{
					return M.ReadLong(Label.Address + 0x420) == 0;
				}
				else
				{
					// default to true?
					return true;
				}
			}
		}

        public TimeSpan TimeLeft
        {
            get
            {
                if (!CanPickUp)
                {
					if (labelInfo.Value != 0)
					{
						int futureTime = M.ReadInt(labelInfo.Value + 0x38);
						return TimeSpan.FromMilliseconds(futureTime - Environment.TickCount);
					}
					else return MaxTimeForPickUp;
                }

                return new TimeSpan();
            }
        }

        //Temp solution for pick it
        public TimeSpan MaxTimeForPickUp => TimeSpan.FromMinutes(2);
            //TimeSpan.Zero; // !CanPickUp ? TimeSpan.FromMilliseconds(M.Read<int>(labelInfo.Value + 0x34)) : new TimeSpan();

        public override string ToString() { return debug.Value; }
    }
}