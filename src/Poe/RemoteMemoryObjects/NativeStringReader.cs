using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class NativeStringReader : RemoteMemoryObject
    {
        public string Value => ReadString(Address);

        public static string ReadString(long address)
        {
            var M = GameController.Instance.Memory;
            //uint Size = M.ReadUInt(address + 0x8);
            var Reserved = M.ReadUInt(address + 0x10);

            //var size = Size;
            //if (size == 0)
            //    return string.Empty;
            if (/*8 <= size ||*/ 8 <= Reserved)//Have no idea how to deal with this
            {
                var readAddr = M.ReadLong(address);
                return M.ReadStringU(readAddr);
            }
            else
            {
                return M.ReadStringU(address);
            }
        }
    }
}