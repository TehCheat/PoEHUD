using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Components
{
    public class Base : Component
    {

        public string Name
        {
            get
            {
                return NativeStringReader.ReadString(M.ReadLong(Address + 0x10) + 0x18);
            }
        }

        public int ItemCellsSizeX => M.ReadInt(Address + 0x10, 0x10);
        public int ItemCellsSizeY => M.ReadInt(Address + 0x10, 0x14);
        public bool isCorrupted => M.ReadByte(Address + 0xD8) == 1;
        public bool isShaper => M.ReadByte(Address + 0xD9) == 1;
        public bool isElder => M.ReadByte(Address + 0xDA) == 1;

        // 0x8 - link to base item
        // +0x10 - Name
        // +0x30 - Use hint
        // +0x50 - Link to Data/BaseItemTypes.dat

        // 0xC (+4) fileref to visual identity
    }
}
