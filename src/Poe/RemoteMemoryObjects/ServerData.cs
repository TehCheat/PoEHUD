using PoeHUD.Poe.Elements;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ServerData : RemoteMemoryObject
    {
        public bool IsInGame => Address != 0 ? InGameType == 3 : false;
        public int InGameType => Address != 0 ? M.ReadInt(Address + /*Offsets.InGameOffset*/ 0x43C8) : 0;//0 - not in game (login screen), 1 - loading location, 3 - on location
        public StashElement StashPanel => Address != 0 ? GetObject<StashElement>(M.ReadLong(Address + 0x3C0, 0xA0, 0x78)) : null;
    }
}