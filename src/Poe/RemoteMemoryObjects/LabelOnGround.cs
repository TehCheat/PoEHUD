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

        private long GetLabelInfo() { return Label.Address != 0 ? M.ReadLong(Label.Address + 0x3A8) : 0; } // No idea if this is correct, but it's not 0x6A4

        //Probably CanPickUp
        public int PickTest => M.ReadInt(Address + 0x10c);

        //Probably CanPickUp
        public int PickTest2 => M.ReadInt(Label.Address + 0x114);
        
        public bool IsVisible => Label.IsVisible;

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


        //Temp solution for pick it, need test PickTest and PickTest2
        public bool CanPickUp => true; //labelInfo.Value == 0;

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

        //Temp solution for pick it
        public TimeSpan MaxTimeForPickUp =>
            TimeSpan.Zero; // !CanPickUp ? TimeSpan.FromMilliseconds(M.Read<int>(labelInfo.Value + 0x34)) : new TimeSpan();

        public override string ToString() { return debug.Value; }
    }
}