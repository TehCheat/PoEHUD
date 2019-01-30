using PoeHUD.Hud.Settings;
using SharpDX;
using ImGuiVector2 = System.Numerics.Vector2;
using ImGuiNET;
using Newtonsoft.Json;
using PoeHUD.Plugins;
using PoeHUD.Hud.Themes;
using System.Windows.Forms;

namespace PoeHUD.Hud.Menu
{
    public sealed class CoreSettings : SettingsBase
    {
        public CoreSettings()
        {
            Enable = true;
        }

        public ImGuiVector2 MenuWindowPos = new ImGuiVector2(200, 200);
        public ImGuiVector2 MenuWindowSize = new ImGuiVector2(600, 600);

        public bool IsCollapsed = false;
        public TreeNodeFlags CorePluginsTreeState;
        public TreeNodeFlags InstalledPluginsTreeNode;

        [Menu("Key Settings", 0)]
        public EmptyNode KeyMenuRoot { get; set; } = new EmptyNode();

        [Menu("Main Menu Key Toggle", 1, 0)]
        public HotkeyNode MainMenuKeyToggle { get; set; } = Keys.F12;

        [Menu("Show Main Menu button", 2, 0)]
        public ToggleNode ShowMenuButton { get; set; } = true;

        [Menu("Close HUD on Escape button", 3, 0)]
        public ToggleNode CloseOnEsc { get; set; } = true;

        [Menu("Close HUD on Space button", 4, 0)]
        public ToggleNode CloseOnSpace { get; set; } = false;

        [Menu("Reload plugin DLL on change")]
        public ToggleNode AutoReloadDllOnChanges { get; set; } = true;

        [Menu("Current Menu Theme")]
        public ListNode Theme { get; set; } = new ListNode() { Value = ThemeEditor.DefaultThemeName };

        [Menu("Developer", 100)]
        public EmptyNode DeveloperRoot { get; set; } = new EmptyNode();

        [JsonIgnore]
        [Menu("Show Imgui Demo", 101, 100)]
        public ToggleNode ShowImguiDemo { get; set; } = false;

        [Menu("Developer Mode", 102, 100)]
        public ToggleNode DeveloperMode { get; set; } = false;

        [Menu("Show plugins Render Time", 103, 102)]
        public ToggleNode ShowPluginsMS { get; set; } = false;

        [Menu("Use State Controller (BETA)", "Everything should works same, even better, but if you got some bugs - don't use it")]
        public ToggleNode UseStateController { get; set; } = false;

        /// <summary>
        /// Used for opening the last opened plugin after hud start
        /// </summary>
        public string LastOpenedPlugin = "";
    }
}