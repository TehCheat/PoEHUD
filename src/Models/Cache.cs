using PoeHUD.Controllers;
using PoeHUD.Models.CacheComponent;
using PoeHUD.Poe;
using PoeHUD.Poe.RemoteMemoryObjects;
using SharpDX;

namespace PoeHUD.Models
{
    public class Cache
    {
        private readonly GameController _gameController;
        private IngameState _ingameState = null;
        private Camera _camera;
        private Element _uiRoot;
        private IngameUIElements _ingameUi;
        private ServerData _serverData;
        private IngameData _data;
        private DiagnosticElement _fpsRectangle;
        private DiagnosticElement _latencyRectangle;
        private Entity _localPlayer;
        private RectangleF _window;
        private PlayerCache _player;
        private bool _enable = true;

        private static Cache _instance;

        public IngameState IngameState
        {
            get => _ingameState;
            set
            {
                if (_ingameState == null)
                    _ingameState = value;
            }
        }

        public Camera Camera
        {
            get => _camera;
            set
            {
                if(_camera==null)
                    _camera = value;
            }
        }

        public Element UIRoot
        {
            get => _uiRoot;
            set
            {
                if (_uiRoot == null)
                    _uiRoot = value;
            }
        }

        public IngameUIElements IngameUi
        {
            get => _ingameUi;
            set
            {
                if (_ingameUi == null)
                    _ingameUi = value;
            }
        }

        public ServerData ServerData
        {
            get => _serverData;
            set
            {
                if (_serverData==null)
                    _serverData = value;
            }
        }
    
        public IngameData Data
        {
            get => _data;
            set
            {
                if (_data == null)
                    _data = value;
            }
        }

        public DiagnosticElement FPSRectangle
        {
            get => _fpsRectangle;
            set
            {
                if (_fpsRectangle == null)
                    _fpsRectangle = value;
            }
        }

        public DiagnosticElement LatencyRectangle
        {
            get => _latencyRectangle;
            set
            {
                if (_latencyRectangle == null)
                    _latencyRectangle = value;
            }
        }

        public Entity LocalPlayer
        {
            get => _localPlayer;
            set
            {
                if (_localPlayer == null)
                    _localPlayer = value;
            }
        }

        public PlayerCache Player => _player ?? (_player = new PlayerCache(_gameController.Game.IngameState.Data.LocalPlayer));

        public RectangleF Window => _window.IsEmpty ? (_window= _gameController.Window.GetWindowRectangleReal()) :_window;


        public bool Enable
        {
            get { return _enable; }
            set
            {
                if (value)
                    UpdateCache();
                _enable = value;
            }
        }

        public Cache()
        {
            _window = RectangleF.Empty;
            _gameController = GameController.Instance;
           
        }
        public void UpdateCache()
        {
            _gameController.Game.RefreshTheGameState();
            _ingameState = null;
            _camera = null;
            _uiRoot = null;
            _ingameUi = null;
            _serverData = null;
            _data = null;
            _fpsRectangle = null;
            _latencyRectangle = null;
            _localPlayer = null;
            Player.UpdateCache(_gameController.Game.IngameState.Data.LocalPlayer);
            _window = _gameController.Window.GetWindowRectangleReal();
        }

        public void ForceUpdateWindowCache()
        {
            _window = _gameController.Window.GetWindowRectangleReal();
        }
    }
}