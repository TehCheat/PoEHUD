using System;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using ImGuiNET;
using PoeHUD.Controllers;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using SharpDX;
using SharpDX.Direct3D9;

namespace PoeHUD.Hud.Menu
{
    public class MenuPlugin : Plugin<CoreSettings>
    {
        //For spawning the menu in external plugins
        public static event Action<int> eInitMenu = delegate { };
        public static IKeyboardMouseEvents KeyboardMouseEvents;
        private readonly SettingsHub settingsHub;
        private readonly MainMenuWindow MenuWindow;
        private RectangleF MenuToggleButtonRect;
        private bool isPoeGameVisible => (GameController.Window.IsForeground() || settingsHub.PerformanceSettings.AlwaysForeground);

        public MenuPlugin(GameController gameController, Graphics graphics, SettingsHub settingsHub) : base(gameController, graphics, settingsHub.MenuSettings)
        {
            this.settingsHub = settingsHub;
            KeyboardMouseEvents = Hook.GlobalEvents();
            KeyboardMouseEvents.MouseWheelExt += KeyboardMouseEvents_MouseWheelExt;
            KeyboardMouseEvents.KeyDown += KeyboardMouseEvents_KeyDown;
            KeyboardMouseEvents.KeyUp += KeyboardMouseEvents_KeyUp;
            KeyboardMouseEvents.KeyPress += KeyboardMouseEvents_KeyPress;
            KeyboardMouseEvents.MouseDownExt += KeyboardMouseEvents_MouseDownExt;
            KeyboardMouseEvents.MouseUpExt += KeyboardMouseEvents_MouseUpExt;
            KeyboardMouseEvents.MouseMove += KeyboardMouseEvents_MouseMove;

            MenuWindow = new MainMenuWindow(Settings, settingsHub);
            MenuToggleButtonRect = new RectangleF(10, 85, 80, 25);
        }
        public override void Dispose()
        {
            SettingsHub.Save(settingsHub);
            KeyboardMouseEvents.MouseWheelExt -= KeyboardMouseEvents_MouseWheelExt;
            KeyboardMouseEvents.KeyDown -= KeyboardMouseEvents_KeyDown;
            KeyboardMouseEvents.KeyUp -= KeyboardMouseEvents_KeyUp;
            KeyboardMouseEvents.KeyPress -= KeyboardMouseEvents_KeyPress;
            KeyboardMouseEvents.MouseDownExt -= KeyboardMouseEvents_MouseDownExt;
            KeyboardMouseEvents.MouseUpExt -= KeyboardMouseEvents_MouseUpExt;
            KeyboardMouseEvents.MouseMove -= KeyboardMouseEvents_MouseMove;
            KeyboardMouseEvents.Dispose();
        }

   
        public override void Render()
        {            
            if (Settings.ShowMenuButton)
            {
                Graphics.DrawImage("menu-background.png", MenuToggleButtonRect, new ColorBGRA(0, 0, 0, 230));
                Graphics.DrawText("≡", 16, MenuToggleButtonRect.TopLeft + new Vector2(25, 12), new ColorBGRA(255, 0, 0, 255), FontDrawFlags.VerticalCenter | FontDrawFlags.Center);
            }
            MenuWindow.Render();
        }

        private bool ImGuiWantCaptureMouse(IO io)
        {
            unsafe
            {
                return io.GetNativePointer()->WantCaptureMouse == 1 && isPoeGameVisible;
            }
        }
        private bool ImGuiWantTextInput(IO io)
        {
            unsafe
            {
                return io.GetNativePointer()->WantTextInput == 1 && isPoeGameVisible;
            }
        }
        private bool PoeIsHoveringInventoryStashTradeItem()
        {
            return GameController.Game.IngameState.UIHoverTooltip.Address != 0x00;
        }



        #region KeyboardMouseHandler
        private void KeyboardMouseEvents_KeyPress(object sender, KeyPressEventArgs e)
        {
            var io = ImGui.GetIO();

            if (io.AltPressed)
                return;

            unsafe
            {
                if (ImGuiWantTextInput(io))
                {
                    ImGui.AddInputCharacter(e.KeyChar);
                    e.Handled = true;
                }
            }
        }
        private void KeyboardMouseEvents_KeyUp(object sender, KeyEventArgs e)
        {
            var io = ImGui.GetIO();
            io.CtrlPressed = false;
            io.AltPressed = false;
            io.ShiftPressed = false;
            io.KeysDown[e.KeyValue] = false;
        }

        public static bool HandleForKeySelector = false;
        public static Keys HandledForKeySelectorKey;
        private void KeyboardMouseEvents_KeyDown(object sender, KeyEventArgs e)
        {
            if (isPoeGameVisible)
            {
                if (HandleForKeySelector)
                {
                    HandledForKeySelectorKey = e.KeyCode;
                    e.Handled = true;
                    HandleForKeySelector = false;
                    return;
                }

                if (e.KeyCode == Settings.MainMenuKeyToggle)
                {
                    Settings.Enable.Value = !Settings.Enable.Value;
                    SettingsHub.Save(settingsHub);
                    e.Handled = true;
                }
                if(Settings.Enable.Value)
                {
                    if (Settings.CloseOnEsc.Value && e.KeyCode == Keys.Escape)
                    {
                        Settings.Enable.Value = !Settings.Enable.Value;
                        e.Handled = true;
                        return;
                    }
                    if (Settings.CloseOnSpace.Value && e.KeyCode == Keys.Space)
                    {
                        Settings.Enable.Value = !Settings.Enable.Value;
                        e.Handled = true;
                        return;
                    }
                }
            }

            var io = ImGui.GetIO();
            io.CtrlPressed = e.Control || e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey;
            // Don't know why but Alt is LMenu/RMenu
            io.AltPressed = e.Alt || e.KeyCode == Keys.LMenu || e.KeyCode == Keys.RMenu;
            io.ShiftPressed = e.Shift || e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey;

            if (io.AltPressed)
                return;

            unsafe
            {
                if (ImGuiWantTextInput(io))
                {
               
                    io.KeysDown[e.KeyValue] = true;
                    if(e.KeyCode != Keys.Capital &&
                        e.KeyCode != Keys.LShiftKey && e.KeyCode != Keys.RShiftKey &&
                        e.KeyCode != Keys.LControlKey && e.KeyCode != Keys.RControlKey &&
                        e.KeyCode != Keys.LWin && e.KeyCode != Keys.Apps)
                        e.Handled = true;
                }
            }
        }

        private void KeyboardMouseEvents_MouseWheelExt(object sender, MouseEventExtArgs e)
        {
            var io = ImGui.GetIO();
            if (ImGuiWantCaptureMouse(io))
            {
                if (e.Delta == 120)
                {
                    ImGui.GetIO().MouseWheel = 1;
                }
                else if (e.Delta == -120)
                {
                    ImGui.GetIO().MouseWheel = -1;
                }
                e.Handled = true;
            }
        }

        private void KeyboardMouseEvents_MouseUpExt(object sender, MouseEventExtArgs e)
        {
            var io = ImGui.GetIO();
            Vector2 mousePosition = GameController.Window.ScreenToClient(e.X, e.Y);
            io.MousePosition = new System.Numerics.Vector2(mousePosition.X, mousePosition.Y);
            switch (e.Button)
            {
                case MouseButtons.Left:
                    io.MouseDown[0] = false;
                    break;
                case MouseButtons.Right:
                    io.MouseDown[1] = false;
                    break;
                case MouseButtons.Middle:
                    io.MouseDown[2] = false;
                    break;
                case MouseButtons.XButton1:
                    io.MouseDown[3] = false;
                    break;
                case MouseButtons.XButton2:
                    io.MouseDown[4] = false;
                    break;
            }
            unsafe
            {
                if (ImGuiWantCaptureMouse(io) && PoeIsHoveringInventoryStashTradeItem())
                {
                    e.Handled = true;
                }
            }
        }
        private void KeyboardMouseEvents_MouseDownExt(object sender, MouseEventExtArgs e)
        {
            Vector2 mousePosition = GameController.Window.ScreenToClient(e.X, e.Y);

            if (isPoeGameVisible)
            {
                if (Settings.ShowMenuButton && MenuToggleButtonRect.Contains(mousePosition))
                {
                    Settings.Enable.Value = !Settings.Enable.Value;
                    e.Handled = true;
                    return;
                }
            }

            var io = ImGui.GetIO();
            io.MousePosition = new System.Numerics.Vector2(mousePosition.X, mousePosition.Y);

            if (ImGuiWantCaptureMouse(io))
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        io.MouseDown[0] = true;
                        e.Handled = true;
                        break;
                    case MouseButtons.Right:
                        io.MouseDown[1] = true;
                        e.Handled = true;
                        break;
                    case MouseButtons.Middle:
                        io.MouseDown[2] = true;
                        e.Handled = true;
                        break;
                    case MouseButtons.XButton1:
                        io.MouseDown[3] = true;
                        e.Handled = true;
                        break;
                    case MouseButtons.XButton2:
                        io.MouseDown[4] = true;
                        e.Handled = true;
                        break;
                }
            }
        }
        private void KeyboardMouseEvents_MouseMove(object sender, MouseEventArgs e)
        {
            var io = ImGui.GetIO();
            Vector2 mousePosition = GameController.Window.ScreenToClient(e.X, e.Y);
            io.MousePosition = new System.Numerics.Vector2(mousePosition.X, mousePosition.Y);
        }
        #endregion
    }
}