using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Models;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class TheGame : RemoteMemoryObject
    {
        public TheGame(Memory m)
        {
            M = m;
            Address = m.ReadLong(Offsets.Base + m.AddressOfProcess, 0x8, 0xf8);//0xC40
            Game = this;
        }
        public IngameState IngameState => GameController.Instance.Cache.Enable ? GameController.Instance.Cache.IngameState : IngameStateReal;

        public IngameState IngameStateReal => ReadObject<IngameState>(Address + 0x38);

        public int AreaChangeCount => M.ReadInt(M.AddressOfProcess + Offsets.AreaChangeCount);
        public bool GameIsLoading => M.ReadInt(140698558134584) == 1;
    }
}