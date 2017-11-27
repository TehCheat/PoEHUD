using System.Collections.Generic;
using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Poe;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.RemoteMemoryObjects;
using SharpDX;

namespace PoeHUD.Models
{
    public class Cache
    {
        private readonly GameController _gameController;
        private IngameState _ingameState;
        private Camera _camera;
        private Element _uiRoot;
        private IngameUIElements _ingameUi;
        private ServerData _serverData;
        private IngameData _data;
        private DiagnosticElement _fpsRectangle;
        private DiagnosticElement _latencyRectangle;
        private Entity _localPlayer;
        private Actor _localPlayerActor;
        private RectangleF _window;
        private static Cache _instance;

        public IngameState IngameState => _ingameState ?? (_ingameState = _gameController.Game.IngameStateReal);

        public Camera Camera => _camera ?? (_camera = _gameController.Game.IngameState.CameraReal);

        public Element UIRoot => _uiRoot ?? (_uiRoot = _gameController.Game.IngameState.UIRootReal);

        public IngameUIElements IngameUi => _ingameUi ?? (_ingameUi = _gameController.Game.IngameState.IngameUiReal);

        public ServerData ServerData => _serverData ?? (_serverData = _gameController.Game.IngameState.ServerDataReal);

        public IngameData Data => _data ?? (_data = _gameController.Game.IngameState.DataReal);

        public DiagnosticElement FPSRectangle => _fpsRectangle ?? (_fpsRectangle = _gameController.Game.IngameState.FPSRectangleReal);

        public DiagnosticElement LatencyRectangle
        {
            get => _latencyRectangle ?? (_latencyRectangle = _gameController.Game.IngameState.LatencyRectangleReal);
        }

        public Entity LocalPlayer => _localPlayer ?? (_localPlayer = _gameController.Game.IngameState.Data.LocalPlayerReal);

        public Actor LocalPlayer_Actor => _localPlayerActor ?? (_localPlayerActor =
                                              _gameController.Game.IngameState.Data.LocalPlayerReal.GetComponent<Actor>());

        public RectangleF Window => _window.IsEmpty ? (_window = _gameController.Window.GetWindowRectangleReal()) : _window;


        public bool Enable { get; set; } = true;

        public Cache()
        {
            _window = RectangleF.Empty;
            _gameController = GameController.Instance;
            _gameController.Area.OnAreaChange += controller => { UpdateCache(); };
            (new Coroutine(() =>
            {
                _window = _gameController.Window.GetWindowRectangleReal();
            }, 100, nameof(Cache), "UpdateCache")
            { Priority = CoroutinePriority.Critical }).AutoRestart().Run();
        }

        public static Dictionary<string, int> ForDevolopDeleteThis = new Dictionary<string, int>();
        private void UpdateCache()
        {
            _ingameState = _gameController.Game.IngameStateReal;
            _camera = _gameController.Game.IngameState.CameraReal;
            _uiRoot = _gameController.Game.IngameState.UIRootReal;
            _ingameUi = _gameController.Game.IngameState.IngameUiReal;
            _serverData = _gameController.Game.IngameState.ServerDataReal;
            _data = _gameController.Game.IngameState.DataReal;
            _fpsRectangle = _gameController.Game.IngameState.FPSRectangleReal;
            _latencyRectangle = _gameController.Game.IngameState.LatencyRectangleReal;
            _localPlayer = _gameController.Game.IngameState.Data.LocalPlayerReal;
            _localPlayerActor = _gameController.Game.IngameState.Data.LocalPlayerReal.GetComponent<Actor>();
            _window = _gameController.Window.GetWindowRectangleReal();
        }

        public void ForceUpdateWindowCache()
        {
            _window = _gameController.Window.GetWindowRectangleReal();
        }
    }
}