namespace PoeHUD.Poe.Components
{
    public class Chest : Component
    {
        public bool IsOpened => Address != 0 && M.ReadByte(Address + 0x58) == 1;
        public bool IsLocked => Address != 0 && M.ReadByte(Address + 0x59) > 1;
        public bool IsStrongbox => Address != 0 && M.ReadLong(Address + 0x98) > 0;
        public byte Quality => M.ReadByte(Address + 0x5C);

        private long StrongboxData => M.ReadLong(Address + 0x20);
        public bool DestroyingAfterOpen => Address != 0 && M.ReadByte(StrongboxData + 0x20) == 1;
        public bool IsLarge => Address != 0 && M.ReadByte(StrongboxData + 0x21) == 1;
        public bool Stompable => Address != 0 && M.ReadByte(StrongboxData + 0x22) == 1;
        public bool OpenOnDamage => Address != 0 && M.ReadByte(StrongboxData + 0x25) == 1;
        public bool OpenWhenDeamonsDie => Address != 0 && M.ReadByte(StrongboxData + 0x28) == 1;
    }
}