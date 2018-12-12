using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    using System;

    public class NativeStringReader : RemoteMemoryObject
    {
        [Obsolete(@"Use Text property instead. 'Value' property will be removed later (Reason: bad name ¯\_(ツ)_/¯)")]
        public string Value => ReadString(Address);
        public string Text => ReadString(Address);

        public static string ReadString(long address)
        {
            var M = GameController.Instance.Memory;
            //uint Size = M.ReadUInt(address + 0x8);
            var Reserved = M.ReadUInt(address + 0x10);

            //var size = Size;
            //if (size == 0)//Size can't be 0!!! When 1 there is a string end char
            //    return string.Empty;
            if (Reserved >= 8)
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