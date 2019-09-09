namespace PoeHUD.Poe.Components
{
    public class Chest : Component
    {
        public bool IsOpened => Address != 0 && M.ReadByte(Address + 0x78) == 1;
        public bool IsLocked => Address != 0 && M.ReadByte(Address + 0x79) > 1;
        public bool IsStrongbox => Address != 0 && M.ReadLong(Address + 0xB8) > 0;
        public byte Quality => M.ReadByte(Address + 0x7C);

        private long StrongboxData => M.ReadLong(Address + 0x20);
        public bool DestroyingAfterOpen => Address != 0 && M.ReadByte(StrongboxData + 0x20) == 1;
        public bool IsLarge => Address != 0 && M.ReadByte(StrongboxData + 0x21) == 1;
        public bool Stompable => Address != 0 && M.ReadByte(StrongboxData + 0x22) == 1;
        public bool OpenOnDamage => Address != 0 && M.ReadByte(StrongboxData + 0x25) == 1;
        public bool OpenWhenDeamonsDie => Address != 0 && M.ReadByte(StrongboxData + 0x28) == 1;
    }
}