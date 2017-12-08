using PoeHUD.Models;
using PoeHUD.Poe.RemoteMemoryObjects;
using System;

namespace PoeHUD.Controllers
{
    public class AreaController
    {
        private readonly GameController Root;

        public AreaController(GameController gameController)
        {
            Root = gameController;
        }

        public event Action<AreaController> OnAreaChange;

        public AreaInstance CurrentArea { get; private set; }

        public void RefreshState()
        {
            Root.Cache.UpdateCache();
            var igsd = Root.Game.IngameState.Data;
            AreaTemplate clientsArea = igsd.CurrentArea;
            int curAreaHash = igsd.CurrentAreaHash;

            if (CurrentArea != null && curAreaHash == CurrentArea.Hash)
                return;
            
            CurrentArea = new AreaInstance(clientsArea, curAreaHash, igsd.CurrentAreaLevel);
            OnAreaChange?.Invoke(this);
        }
    }
}