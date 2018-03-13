using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using ImGuiNET;
using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Hud.Health;
using PoeHUD.Hud.Loot;
using PoeHUD.Hud.PluginExtension;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using PoeHUD.Plugins;
using SharpDX;

namespace PoeHUD.Hud.Menu
{
    public class MenuPlugin : Plugin<MenuSettings>
    {
        //For spawning the menu in external plugins
        public static event Action<int> eInitMenu = delegate { };

        public static IKeyboardMouseEvents KeyboardMouseEvents;
        private readonly SettingsHub settingsHub;
        private readonly MainMenuWindow MenuWindow;
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

            MenuWindow = new MainMenuWindow();
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
            KeyboardMouseEvents.Dispose();
        }
        public override void Render()
        {
            MenuWindow.Render();
            return;
            try
            {
                if (Settings.Enable)
                    CreateImGuiMenu();
            }
            catch (Exception e)
            {
                DebugPlug.DebugPlugin.LogMsg("Error Rendering PoeHUD Menu." + e.Message, 1);
            }
        }

        private int SelectedTab = 0;
        private int UniqueTabID = 0;
        private string SelectedPluginName = null;

        private void CreateImGuiMenu()
        {
            bool tmp = Settings.Enable.Value;

            ImGui.SetNextWindowPos(new System.Numerics.Vector2(Settings.X, Settings.Y), Condition.Appearing, new System.Numerics.Vector2(1, 1));
            if (ImGui.BeginWindow("PoeHUD", ref tmp, WindowFlags.Default))
            {
                ImGuiExtension.ImGuiExtension_ColorTabs("Main Tabs", 30, new List<string>() { "Settings", "Plugins" }, ref SelectedTab, ref UniqueTabID);

                if (SelectedTab == 0)
                {
                    CreateSettingsMenu();
                }
                if (SelectedTab == 1)
                {
                    CreatePluginsMenu();
                }

                ImGui.EndWindow();
            }

            Settings.Enable.Value = tmp;
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
        private void KeyboardMouseEvents_KeyDown(object sender, KeyEventArgs e)
        {
            if (isPoeGameVisible)
            {
                switch (e.KeyCode)
                {
                    case Keys.F12:
                        Settings.Enable.Value = !Settings.Enable.Value;
                        SettingsHub.Save(settingsHub);
                        break;
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
            var io = ImGui.GetIO();
            Vector2 mousePosition = GameController.Window.ScreenToClient(e.X, e.Y);
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

       private void CreateSettingsMenu()
        {
            //MenuRootButton = new RootButton(new Vector2(Settings.X, Settings.Y));
            //MenuRootButton.eOnClose += delegate { SettingsHub.Save(settingsHub); };
            ImGui.Text("Core Settings");

            // Health bars
            if (ImGui.TreeNode("Health bars"))
            {
                HealthBarSettings healthBarPlugin = settingsHub.HealthBarSettings;
                healthBarPlugin.Enable = ImGuiExtension.Checkbox("Enable", healthBarPlugin.Enable);

                healthBarPlugin.ShowES = ImGuiExtension.Checkbox("Show energy shield", healthBarPlugin.ShowES);
                healthBarPlugin.ShowInTown = ImGuiExtension.Checkbox("Show in town", healthBarPlugin.ShowInTown);

                if (ImGui.TreeNode("Players"))
                {
                    healthBarPlugin.Players.Enable = ImGuiExtension.Checkbox("Enable", healthBarPlugin.Players.Enable);

                    healthBarPlugin.Players.ShowPercents = ImGuiExtension.Checkbox("Print percents", healthBarPlugin.Players.ShowPercents);
                    healthBarPlugin.Players.ShowHealthText = ImGuiExtension.Checkbox("Print health text", healthBarPlugin.Players.ShowHealthText);
                    healthBarPlugin.Players.Width.Value = ImGuiExtension.FloatSlider("Width", healthBarPlugin.Players.Width);
                    healthBarPlugin.Players.Height.Value = ImGuiExtension.FloatSlider("Height", healthBarPlugin.Players.Height);

                    if (ImGui.TreeNode("Show debuffs"))
                    {
                        healthBarPlugin.ShowDebuffPanel = ImGuiExtension.Checkbox("Enable", healthBarPlugin.ShowDebuffPanel);

                        healthBarPlugin.DebuffPanelIconSize.Value = ImGuiExtension.IntSlider("Icon size", healthBarPlugin.DebuffPanelIconSize);

                        ImGui.TreePop();
                    }

                    if (ImGui.TreeNode("Floating combat text"))
                    {

                        healthBarPlugin.Players.FloatingCombatTextSize.Value = ImGuiExtension.IntSlider("Text size", healthBarPlugin.Players.FloatingCombatTextSize);
                        healthBarPlugin.Players.FloatingCombatDamageColor.Value = ImGuiExtension.ColorPicker("Damage color", healthBarPlugin.Players.FloatingCombatDamageColor);
                        healthBarPlugin.Players.FloatingCombatHealColor.Value = ImGuiExtension.ColorPicker("Heal Color", healthBarPlugin.Players.FloatingCombatHealColor);
                        healthBarPlugin.Players.FloatingCombatStackSize.Value = ImGuiExtension.IntSlider("Number of lines", healthBarPlugin.Players.FloatingCombatStackSize);

                        ImGui.TreePop();
                    }

                    ImGui.TreePop();
                }

                if (ImGui.TreeNode("Enemies"))
                {
                    healthBarPlugin.ShowEnemies = ImGuiExtension.Checkbox("Enable", healthBarPlugin.ShowEnemies);

                    if (ImGui.TreeNode("White"))
                    {
                        healthBarPlugin.NormalEnemy.Enable = ImGuiExtension.Checkbox("Enable", healthBarPlugin.NormalEnemy.Enable);

                        healthBarPlugin.NormalEnemy.ShowPercents = ImGuiExtension.Checkbox("Print percents", healthBarPlugin.NormalEnemy.ShowPercents);
                        healthBarPlugin.NormalEnemy.ShowHealthText = ImGuiExtension.Checkbox("Print health text", healthBarPlugin.NormalEnemy.ShowHealthText);
                        healthBarPlugin.NormalEnemy.Width.Value = ImGuiExtension.FloatSlider("Width", healthBarPlugin.NormalEnemy.Width);
                        healthBarPlugin.NormalEnemy.Height.Value = ImGuiExtension.FloatSlider("Height", healthBarPlugin.NormalEnemy.Height);

                        if (ImGui.TreeNode("Floating combat text"))
                        {
                            healthBarPlugin.NormalEnemy.FloatingCombatTextSize.Value = ImGuiExtension.IntSlider("Text size", healthBarPlugin.NormalEnemy.FloatingCombatTextSize);
                            healthBarPlugin.NormalEnemy.FloatingCombatDamageColor.Value = ImGuiExtension.ColorPicker("Damage color", healthBarPlugin.NormalEnemy.FloatingCombatDamageColor);
                            healthBarPlugin.NormalEnemy.FloatingCombatHealColor.Value = ImGuiExtension.ColorPicker("Heal Color", healthBarPlugin.NormalEnemy.FloatingCombatHealColor);
                            healthBarPlugin.NormalEnemy.FloatingCombatStackSize.Value = ImGuiExtension.IntSlider("Number of lines", healthBarPlugin.NormalEnemy.FloatingCombatStackSize);
                            ImGui.TreePop();
                        }

                        ImGui.TreePop();
                    }

                    if (ImGui.TreeNode("Magic"))
                    {
                        healthBarPlugin.MagicEnemy.Enable = ImGuiExtension.Checkbox("Enable", healthBarPlugin.MagicEnemy.Enable);

                        healthBarPlugin.MagicEnemy.ShowPercents = ImGuiExtension.Checkbox("Print percents", healthBarPlugin.MagicEnemy.ShowPercents);
                        healthBarPlugin.MagicEnemy.ShowHealthText = ImGuiExtension.Checkbox("Print health text", healthBarPlugin.MagicEnemy.ShowHealthText);
                        healthBarPlugin.MagicEnemy.Width.Value = ImGuiExtension.FloatSlider("Width", healthBarPlugin.MagicEnemy.Width);
                        healthBarPlugin.MagicEnemy.Height.Value = ImGuiExtension.FloatSlider("Height", healthBarPlugin.MagicEnemy.Height);

                        if (ImGui.TreeNode("Floating combat text"))
                        {
                            healthBarPlugin.MagicEnemy.FloatingCombatTextSize.Value = ImGuiExtension.IntSlider("Text size", healthBarPlugin.MagicEnemy.FloatingCombatTextSize);
                            healthBarPlugin.MagicEnemy.FloatingCombatDamageColor.Value = ImGuiExtension.ColorPicker("Damage color", healthBarPlugin.MagicEnemy.FloatingCombatDamageColor);
                            healthBarPlugin.MagicEnemy.FloatingCombatHealColor.Value = ImGuiExtension.ColorPicker("Heal Color", healthBarPlugin.MagicEnemy.FloatingCombatHealColor);
                            healthBarPlugin.MagicEnemy.FloatingCombatStackSize.Value = ImGuiExtension.IntSlider("Number of lines", healthBarPlugin.MagicEnemy.FloatingCombatStackSize);
                            ImGui.TreePop();
                        }

                        ImGui.TreePop();
                    }

                    if (ImGui.TreeNode("Rare"))
                    {
                        healthBarPlugin.RareEnemy.Enable = ImGuiExtension.Checkbox("Enable", healthBarPlugin.RareEnemy.Enable);

                        healthBarPlugin.RareEnemy.ShowPercents = ImGuiExtension.Checkbox("Print percents", healthBarPlugin.RareEnemy.ShowPercents);
                        healthBarPlugin.RareEnemy.ShowHealthText = ImGuiExtension.Checkbox("Print health text", healthBarPlugin.RareEnemy.ShowHealthText);
                        healthBarPlugin.RareEnemy.Width.Value = ImGuiExtension.FloatSlider("Width", healthBarPlugin.RareEnemy.Width);
                        healthBarPlugin.RareEnemy.Height.Value = ImGuiExtension.FloatSlider("Height", healthBarPlugin.RareEnemy.Height);

                        if (ImGui.TreeNode("Floating combat text"))
                        {
                            healthBarPlugin.RareEnemy.FloatingCombatTextSize.Value = ImGuiExtension.IntSlider("Text size", healthBarPlugin.RareEnemy.FloatingCombatTextSize);
                            healthBarPlugin.RareEnemy.FloatingCombatDamageColor.Value = ImGuiExtension.ColorPicker("Damage color", healthBarPlugin.RareEnemy.FloatingCombatDamageColor);
                            healthBarPlugin.RareEnemy.FloatingCombatHealColor.Value = ImGuiExtension.ColorPicker("Heal Color", healthBarPlugin.RareEnemy.FloatingCombatHealColor);
                            healthBarPlugin.RareEnemy.FloatingCombatStackSize.Value = ImGuiExtension.IntSlider("Number of lines", healthBarPlugin.RareEnemy.FloatingCombatStackSize);
                            ImGui.TreePop();
                        }

                        ImGui.TreePop();
                    }

                    if (ImGui.TreeNode("Uniques"))
                    {
                        healthBarPlugin.UniqueEnemy.Enable = ImGuiExtension.Checkbox("Enable", healthBarPlugin.RareEnemy.Enable);

                        healthBarPlugin.UniqueEnemy.ShowPercents = ImGuiExtension.Checkbox("Print percents", healthBarPlugin.UniqueEnemy.ShowPercents);
                        healthBarPlugin.UniqueEnemy.ShowHealthText = ImGuiExtension.Checkbox("Print health text", healthBarPlugin.UniqueEnemy.ShowHealthText);
                        healthBarPlugin.UniqueEnemy.Width.Value = ImGuiExtension.FloatSlider("Width", healthBarPlugin.UniqueEnemy.Width);
                        healthBarPlugin.UniqueEnemy.Height.Value = ImGuiExtension.FloatSlider("Height", healthBarPlugin.UniqueEnemy.Height);

                        if (ImGui.TreeNode("Floating combat text"))
                        {
                            healthBarPlugin.UniqueEnemy.FloatingCombatTextSize.Value = ImGuiExtension.IntSlider("Text size", healthBarPlugin.UniqueEnemy.FloatingCombatTextSize);
                            healthBarPlugin.UniqueEnemy.FloatingCombatDamageColor.Value = ImGuiExtension.ColorPicker("Damage color", healthBarPlugin.UniqueEnemy.FloatingCombatDamageColor);
                            healthBarPlugin.UniqueEnemy.FloatingCombatHealColor.Value = ImGuiExtension.ColorPicker("Heal Color", healthBarPlugin.UniqueEnemy.FloatingCombatHealColor);
                            healthBarPlugin.UniqueEnemy.FloatingCombatStackSize.Value = ImGuiExtension.IntSlider("Number of lines", healthBarPlugin.UniqueEnemy.FloatingCombatStackSize);
                            ImGui.TreePop();
                        }

                        ImGui.TreePop();
                    }

                    ImGui.TreePop();
                }

                if (ImGui.TreeNode("Minions"))
                {
                    healthBarPlugin.Minions.Enable = ImGuiExtension.Checkbox("Enable", healthBarPlugin.Minions.Enable);
                    healthBarPlugin.Minions.ShowPercents = ImGuiExtension.Checkbox("Print percents", healthBarPlugin.Minions.ShowPercents);
                    healthBarPlugin.Minions.ShowHealthText = ImGuiExtension.Checkbox("Print health text", healthBarPlugin.Minions.ShowHealthText);
                    healthBarPlugin.Minions.Width.Value = ImGuiExtension.FloatSlider("Width", healthBarPlugin.Minions.Width);
                    healthBarPlugin.Minions.Height.Value = ImGuiExtension.FloatSlider("Height", healthBarPlugin.Minions.Height);

                    if (ImGui.TreeNode("Floating combat text"))
                    {
                        healthBarPlugin.Minions.ShowFloatingCombatDamage = ImGuiExtension.Checkbox("Enable", healthBarPlugin.Minions.ShowFloatingCombatDamage);

                        healthBarPlugin.Minions.FloatingCombatTextSize.Value = ImGuiExtension.IntSlider("Text size", healthBarPlugin.Minions.FloatingCombatTextSize);
                        healthBarPlugin.Minions.FloatingCombatDamageColor.Value = ImGuiExtension.ColorPicker("Damage color", healthBarPlugin.Minions.FloatingCombatDamageColor);
                        healthBarPlugin.Minions.FloatingCombatHealColor.Value = ImGuiExtension.ColorPicker("Heal Color", healthBarPlugin.Minions.FloatingCombatHealColor);
                        healthBarPlugin.Minions.FloatingCombatStackSize.Value = ImGuiExtension.IntSlider("Number of lines", healthBarPlugin.Minions.FloatingCombatStackSize);
                    }

                }


                ImGui.TreePop();
            }

            if (ImGui.TreeNode("Xph & area"))
            {
                settingsHub.XpRateSettings.Enable = ImGuiExtension.Checkbox("Enable", settingsHub.XpRateSettings.Enable);

                settingsHub.XpRateSettings.OnlyAreaName = ImGuiExtension.Checkbox("Only area name", settingsHub.XpRateSettings.OnlyAreaName);
                settingsHub.XpRateSettings.ShowInTown = ImGuiExtension.Checkbox("Show in town", settingsHub.XpRateSettings.ShowInTown);
                settingsHub.XpRateSettings.TextSize.Value = ImGuiExtension.IntSlider("Font size", settingsHub.XpRateSettings.TextSize);
                settingsHub.XpRateSettings.FpsTextColor = ImGuiExtension.ColorPicker("Fps font color", settingsHub.XpRateSettings.FpsTextColor);
                settingsHub.XpRateSettings.XphTextColor = ImGuiExtension.ColorPicker("Xph font color", settingsHub.XpRateSettings.XphTextColor);
                settingsHub.XpRateSettings.AreaTextColor = ImGuiExtension.ColorPicker("Area font color", settingsHub.XpRateSettings.AreaTextColor);
                settingsHub.XpRateSettings.TimeLeftColor = ImGuiExtension.ColorPicker("Time left color", settingsHub.XpRateSettings.TimeLeftColor);
                settingsHub.XpRateSettings.TimerTextColor = ImGuiExtension.ColorPicker("Time font color", settingsHub.XpRateSettings.TimerTextColor);
                settingsHub.XpRateSettings.LatencyTextColor = ImGuiExtension.ColorPicker("Latency font color", settingsHub.XpRateSettings.LatencyTextColor);
                settingsHub.XpRateSettings.BackgroundColor = ImGuiExtension.ColorPicker("Background color", settingsHub.XpRateSettings.BackgroundColor);
                settingsHub.XpRateSettings.ShowLatency = ImGuiExtension.Checkbox("Show latency", settingsHub.XpRateSettings.ShowLatency);
                settingsHub.XpRateSettings.ShowFps = ImGuiExtension.Checkbox("Show fps", settingsHub.XpRateSettings.ShowFps);

                ImGui.TreePop();
            }

            if (ImGui.TreeNode("Item alert"))
            {
                settingsHub.ItemAlertSettings.Enable = ImGuiExtension.Checkbox("Enable", settingsHub.ItemAlertSettings.Enable);
                string[] itemAlertStaticMenuList = { "Item tooltips", "Play sound", "Show text", "Hide others", "Show border", "Dim Others" };

                if (ImGui.TreeNode("Custom Item Filter"))
                {
                    settingsHub.ItemAlertSettings.Alternative = ImGuiExtension.Checkbox("Enable", settingsHub.ItemAlertSettings.Alternative);

                    // TODO: This needs a new Imgui component to open up a file select?
                    //settingsHub.ItemAlertSettings.FilePath = ImGuiExtension.FilePath("", settingsHub.ItemAlertSettings.FilePath);
                    ImGui.Text("NOT IMPLEMENTED FILE SELECT");

                    settingsHub.ItemAlertSettings.WithBorder = ImGuiExtension.Checkbox("With border", settingsHub.ItemAlertSettings.WithBorder);
                    settingsHub.ItemAlertSettings.WithSound = ImGuiExtension.Checkbox("With sound", settingsHub.ItemAlertSettings.WithSound);

                    ImGui.TreePop();
                }


                if (ImGui.TreeNode("Item tooltips"))
                {
                    settingsHub.AdvancedTooltipSettings.Enable = ImGuiExtension.Checkbox("Enable", settingsHub.AdvancedTooltipSettings.Enable);

                    if (ImGui.TreeNode("Item Level"))
                    {
                        settingsHub.AdvancedTooltipSettings.ItemLevel.Enable = ImGuiExtension.Checkbox("Enable", settingsHub.AdvancedTooltipSettings.ItemLevel.Enable);

                        settingsHub.AdvancedTooltipSettings.ItemLevel.TextSize.Value = ImGuiExtension.IntSlider("Text size", settingsHub.AdvancedTooltipSettings.ItemLevel.TextSize);
                        settingsHub.AdvancedTooltipSettings.ItemLevel.TextColor = ImGuiExtension.ColorPicker("Text color", settingsHub.AdvancedTooltipSettings.ItemLevel.TextColor);
                        settingsHub.AdvancedTooltipSettings.ItemLevel.BackgroundColor = ImGuiExtension.ColorPicker("Background color", settingsHub.AdvancedTooltipSettings.ItemLevel.BackgroundColor);

                        ImGui.TreePop();
                    }

                    if (ImGui.TreeNode("Item mods"))
                    {
                        settingsHub.AdvancedTooltipSettings.ItemMods.Enable = ImGuiExtension.Checkbox("Enable", settingsHub.AdvancedTooltipSettings.ItemMods.Enable);

                        settingsHub.AdvancedTooltipSettings.ItemMods.ModTextSize.Value = ImGuiExtension.IntSlider("Mods size", settingsHub.AdvancedTooltipSettings.ItemMods.ModTextSize);
                        settingsHub.AdvancedTooltipSettings.ItemMods.T1Color = ImGuiExtension.ColorPicker("Tier 1 color", settingsHub.AdvancedTooltipSettings.ItemMods.T1Color);
                        settingsHub.AdvancedTooltipSettings.ItemMods.T2Color = ImGuiExtension.ColorPicker("Tier 2 color", settingsHub.AdvancedTooltipSettings.ItemMods.T2Color);
                        settingsHub.AdvancedTooltipSettings.ItemMods.T3Color = ImGuiExtension.ColorPicker("Tier 3 color", settingsHub.AdvancedTooltipSettings.ItemMods.T3Color);
                        settingsHub.AdvancedTooltipSettings.ItemMods.SuffixColor = ImGuiExtension.ColorPicker("Suffix color", settingsHub.AdvancedTooltipSettings.ItemMods.SuffixColor);
                        settingsHub.AdvancedTooltipSettings.ItemMods.PrefixColor = ImGuiExtension.ColorPicker("Prefix color", settingsHub.AdvancedTooltipSettings.ItemMods.PrefixColor);

                        ImGui.TreePop();
                    }

                    if (ImGui.TreeNode("Weapon Dps"))
                    {
                        settingsHub.AdvancedTooltipSettings.WeaponDps.Enable = ImGuiExtension.Checkbox("Enable", settingsHub.AdvancedTooltipSettings.WeaponDps.Enable);

                        if (ImGui.TreeNode("Damage colors"))
                        {
                            settingsHub.AdvancedTooltipSettings.WeaponDps.DmgColdColor = ImGuiExtension.ColorPicker("Cold damage", settingsHub.AdvancedTooltipSettings.WeaponDps.DmgColdColor);
                            settingsHub.AdvancedTooltipSettings.WeaponDps.DmgFireColor = ImGuiExtension.ColorPicker("Fire damage", settingsHub.AdvancedTooltipSettings.WeaponDps.DmgFireColor);
                            settingsHub.AdvancedTooltipSettings.WeaponDps.DmgLightningColor = ImGuiExtension.ColorPicker("Lightning damage", settingsHub.AdvancedTooltipSettings.WeaponDps.DmgLightningColor);
                            settingsHub.AdvancedTooltipSettings.WeaponDps.DmgChaosColor = ImGuiExtension.ColorPicker("Chaos damage", settingsHub.AdvancedTooltipSettings.WeaponDps.DmgChaosColor);
                            settingsHub.AdvancedTooltipSettings.WeaponDps.pDamageColor = ImGuiExtension.ColorPicker("Physical damage", settingsHub.AdvancedTooltipSettings.WeaponDps.pDamageColor);
                            settingsHub.AdvancedTooltipSettings.WeaponDps.eDamageColor = ImGuiExtension.ColorPicker("Elemental damage", settingsHub.AdvancedTooltipSettings.WeaponDps.eDamageColor);

                            ImGui.TreePop();
                        }

                        settingsHub.AdvancedTooltipSettings.WeaponDps.TextColor = ImGuiExtension.ColorPicker("Text color", settingsHub.AdvancedTooltipSettings.WeaponDps.TextColor);
                        settingsHub.AdvancedTooltipSettings.WeaponDps.DpsTextSize.Value = ImGuiExtension.IntSlider("Dps size", settingsHub.AdvancedTooltipSettings.WeaponDps.DpsTextSize);
                        settingsHub.AdvancedTooltipSettings.WeaponDps.DpsNameTextSize.Value = ImGuiExtension.IntSlider("Dps text size", settingsHub.AdvancedTooltipSettings.WeaponDps.DpsNameTextSize);
                        settingsHub.AdvancedTooltipSettings.WeaponDps.BackgroundColor = ImGuiExtension.ColorPicker("Background color", settingsHub.AdvancedTooltipSettings.WeaponDps.BackgroundColor);

                        ImGui.TreePop();
                    }

                    ImGui.TreePop();
                }

                if (ImGui.TreeNode("Play sound"))
                {
                    settingsHub.ItemAlertSettings.PlaySound = ImGuiExtension.Checkbox("Enable", settingsHub.ItemAlertSettings.PlaySound);

                    settingsHub.ItemAlertSettings.SoundVolume.Value = ImGuiExtension.IntSlider("Sound volume", settingsHub.ItemAlertSettings.SoundVolume);

                    ImGui.TreePop();
                }

                if (ImGui.TreeNode("Show text"))
                {
                    settingsHub.ItemAlertSettings.ShowText = ImGuiExtension.Checkbox("Enable", settingsHub.ItemAlertSettings.ShowText);
                    settingsHub.ItemAlertSettings.TextSize.Value = ImGuiExtension.IntSlider("Text size", settingsHub.ItemAlertSettings.TextSize);

                    ImGui.TreePop();
                }

                settingsHub.ItemAlertSettings.HideOthers = ImGuiExtension.Checkbox("Hide others", settingsHub.ItemAlertSettings.HideOthers);

                if (ImGui.TreeNode("Dim Others"))
                {
                    ItemAlertSettings dimOtherSettings = settingsHub.ItemAlertSettings;
                    dimOtherSettings.DimOtherByPercentToggle = ImGuiExtension.Checkbox("Enable", dimOtherSettings.DimOtherByPercentToggle);
                    dimOtherSettings.DimOtherByPercent.Value = ImGuiExtension.IntSlider("Dim Others By %", dimOtherSettings.DimOtherByPercent);

                    ImGui.TreePop();
                }

                if (ImGui.TreeNode("Show border"))
                {
                    BorderSettings borderSettings = settingsHub.ItemAlertSettings.BorderSettings;

                    borderSettings.Enable = ImGuiExtension.Checkbox("Enable", borderSettings.Enable);
                    borderSettings.BorderWidth.Value = ImGuiExtension.IntSlider("Border width", borderSettings.BorderWidth);
                    borderSettings.BorderColor = ImGuiExtension.ColorPicker("Border color:", borderSettings.BorderColor);
                    borderSettings.CantPickUpBorderColor = ImGuiExtension.ColorPicker("Can't pick up :", borderSettings.CantPickUpBorderColor);
                    borderSettings.NotMyItemBorderColor = ImGuiExtension.ColorPicker("Not my item :", borderSettings.NotMyItemBorderColor);
                    borderSettings.ShowTimer = ImGuiExtension.Checkbox("Show timer", borderSettings.ShowTimer);

                    ImGui.TreePop();
                }

                settingsHub.ItemAlertSettings.Uniques = ImGuiExtension.Checkbox("Uniques", settingsHub.ItemAlertSettings.Uniques);
                settingsHub.ItemAlertSettings.Rares = ImGuiExtension.Checkbox("Rares", settingsHub.ItemAlertSettings.Rares);
                settingsHub.ItemAlertSettings.Currency = ImGuiExtension.Checkbox("Currency", settingsHub.ItemAlertSettings.Currency);
                settingsHub.ItemAlertSettings.Maps = ImGuiExtension.Checkbox("Maps", settingsHub.ItemAlertSettings.Maps);
                settingsHub.ItemAlertSettings.Rgb = ImGuiExtension.Checkbox("RGB", settingsHub.ItemAlertSettings.Rgb);
                settingsHub.ItemAlertSettings.Crafting = ImGuiExtension.Checkbox("Crafting bases", settingsHub.ItemAlertSettings.Crafting);
                settingsHub.ItemAlertSettings.DivinationCards = ImGuiExtension.Checkbox("Divination cards", settingsHub.ItemAlertSettings.DivinationCards);
                settingsHub.ItemAlertSettings.Jewels = ImGuiExtension.Checkbox("Jewels", settingsHub.ItemAlertSettings.Jewels);
                settingsHub.ItemAlertSettings.Talisman = ImGuiExtension.Checkbox("Talisman", settingsHub.ItemAlertSettings.Talisman);

                if (ImGui.TreeNode("Quality Items"))
                {
                    QualityItemsSettings qualityItemsSettings = settingsHub.ItemAlertSettings.QualityItems;

                    qualityItemsSettings.Enable = ImGuiExtension.Checkbox("Enable", qualityItemsSettings.Enable);

                    if (ImGui.TreeNode("Weapons"))
                    {
                        qualityItemsSettings.Weapon.Enable = ImGuiExtension.Checkbox("Enable", qualityItemsSettings.Weapon.Enable);
                        qualityItemsSettings.Weapon.MinQuality.Value = ImGuiExtension.IntSlider("Min. quality", qualityItemsSettings.Weapon.MinQuality);

                        ImGui.TreePop();
                    }

                    if (ImGui.TreeNode("Armour"))
                    {
                        qualityItemsSettings.Armour.Enable = ImGuiExtension.Checkbox("Enable", qualityItemsSettings.Armour.Enable);
                        qualityItemsSettings.Armour.MinQuality.Value = ImGuiExtension.IntSlider("Min. quality", qualityItemsSettings.Armour.MinQuality);

                        ImGui.TreePop();
                    }


                    if (ImGui.TreeNode("Flasks"))
                    {
                        qualityItemsSettings.Flask.Enable = ImGuiExtension.Checkbox("Enable", qualityItemsSettings.Flask.Enable);
                        qualityItemsSettings.Flask.MinQuality.Value = ImGuiExtension.IntSlider("Min. quality", qualityItemsSettings.Flask.MinQuality);

                        ImGui.TreePop();
                    }


                    if (ImGui.TreeNode("Skill gems"))
                    {
                        qualityItemsSettings.SkillGem.Enable = ImGuiExtension.Checkbox("Enable", qualityItemsSettings.SkillGem.Enable);
                        qualityItemsSettings.SkillGem.MinQuality.Value = ImGuiExtension.IntSlider("Min. quality", qualityItemsSettings.SkillGem.MinQuality);

                        ImGui.TreePop();
                    }

                    ImGui.TreePop();
                }

                ImGui.TreePop();
            }

            if (ImGui.TreeNode("Preload alert"))
            {
                // TODO: Need hotkey here (F5 default)
                settingsHub.PreloadAlertSettings.Enable = ImGuiExtension.Checkbox("Enable", settingsHub.PreloadAlertSettings.Enable);

                if (ImGui.TreeNode("Masters"))
                {
                    settingsHub.PreloadAlertSettings.Masters = ImGuiExtension.Checkbox("Enable", settingsHub.PreloadAlertSettings.Masters);
                    settingsHub.PreloadAlertSettings.MasterZana = ImGuiExtension.ColorPicker("Zana", settingsHub.PreloadAlertSettings.MasterZana);
                    settingsHub.PreloadAlertSettings.MasterTora = ImGuiExtension.ColorPicker("Tora", settingsHub.PreloadAlertSettings.MasterTora);
                    settingsHub.PreloadAlertSettings.MasterHaku = ImGuiExtension.ColorPicker("Haku", settingsHub.PreloadAlertSettings.MasterHaku);
                    settingsHub.PreloadAlertSettings.MasterVorici = ImGuiExtension.ColorPicker("Vorici", settingsHub.PreloadAlertSettings.MasterVorici);
                    settingsHub.PreloadAlertSettings.MasterElreon = ImGuiExtension.ColorPicker("Elreon", settingsHub.PreloadAlertSettings.MasterElreon);
                    settingsHub.PreloadAlertSettings.MasterVagan = ImGuiExtension.ColorPicker("Vagan", settingsHub.PreloadAlertSettings.MasterVagan);
                    settingsHub.PreloadAlertSettings.MasterCatarina = ImGuiExtension.ColorPicker("Catarina", settingsHub.PreloadAlertSettings.MasterCatarina);
                    settingsHub.PreloadAlertSettings.MasterKrillson = ImGuiExtension.ColorPicker("Krillson", settingsHub.PreloadAlertSettings.MasterKrillson);

                    ImGui.TreePop();
                }

                if (ImGui.TreeNode("Exiles"))
                {
                    settingsHub.PreloadAlertSettings.Exiles = ImGuiExtension.Checkbox("Enable", settingsHub.PreloadAlertSettings.Exiles);
                    settingsHub.PreloadAlertSettings.OrraGreengate = ImGuiExtension.ColorPicker("Orra Greengate", settingsHub.PreloadAlertSettings.OrraGreengate);
                    settingsHub.PreloadAlertSettings.ThenaMoga = ImGuiExtension.ColorPicker("Thena Moga", settingsHub.PreloadAlertSettings.ThenaMoga);
                    settingsHub.PreloadAlertSettings.AntalieNapora = ImGuiExtension.ColorPicker("Antalie Napora", settingsHub.PreloadAlertSettings.AntalieNapora);
                    settingsHub.PreloadAlertSettings.TorrOlgosso = ImGuiExtension.ColorPicker("Torr Olgosso", settingsHub.PreloadAlertSettings.TorrOlgosso);
                    settingsHub.PreloadAlertSettings.ArmiosBell = ImGuiExtension.ColorPicker("Armios Bell", settingsHub.PreloadAlertSettings.ArmiosBell);
                    settingsHub.PreloadAlertSettings.ZacharieDesmarais = ImGuiExtension.ColorPicker("Zacharie Desmarais", settingsHub.PreloadAlertSettings.ZacharieDesmarais);
                    settingsHub.PreloadAlertSettings.MinaraAnenima = ImGuiExtension.ColorPicker("Minara Anenima", settingsHub.PreloadAlertSettings.MinaraAnenima);
                    settingsHub.PreloadAlertSettings.IgnaPhoenix = ImGuiExtension.ColorPicker("Igna Phoenix", settingsHub.PreloadAlertSettings.IgnaPhoenix);
                    settingsHub.PreloadAlertSettings.JonahUnchained = ImGuiExtension.ColorPicker("Jonah Unchained", settingsHub.PreloadAlertSettings.JonahUnchained);
                    settingsHub.PreloadAlertSettings.DamoiTui = ImGuiExtension.ColorPicker("Damoi Tui", settingsHub.PreloadAlertSettings.DamoiTui);
                    settingsHub.PreloadAlertSettings.XandroBlooddrinker = ImGuiExtension.ColorPicker("Xandro Blooddrinker", settingsHub.PreloadAlertSettings.XandroBlooddrinker);
                    settingsHub.PreloadAlertSettings.VickasGiantbone = ImGuiExtension.ColorPicker("Vickas Giantbone", settingsHub.PreloadAlertSettings.VickasGiantbone);
                    settingsHub.PreloadAlertSettings.EoinGreyfur = ImGuiExtension.ColorPicker("Eoin Greyfur", settingsHub.PreloadAlertSettings.EoinGreyfur);
                    settingsHub.PreloadAlertSettings.TinevinHighdove = ImGuiExtension.ColorPicker("Tinevin Highdove", settingsHub.PreloadAlertSettings.TinevinHighdove);
                    settingsHub.PreloadAlertSettings.ThenaMoga = ImGuiExtension.ColorPicker("Thena Moga", settingsHub.PreloadAlertSettings.ThenaMoga);
                    settingsHub.PreloadAlertSettings.AntalieNapora = ImGuiExtension.ColorPicker("Antalie Napora", settingsHub.PreloadAlertSettings.AntalieNapora);
                    settingsHub.PreloadAlertSettings.MagnusStonethorn = ImGuiExtension.ColorPicker("Magnus Stonethorn", settingsHub.PreloadAlertSettings.MagnusStonethorn);
                    settingsHub.PreloadAlertSettings.IonDarkshroud = ImGuiExtension.ColorPicker("Ion Darkshroud", settingsHub.PreloadAlertSettings.IonDarkshroud);
                    settingsHub.PreloadAlertSettings.AshLessard = ImGuiExtension.ColorPicker("Ash Lessard", settingsHub.PreloadAlertSettings.AshLessard);
                    settingsHub.PreloadAlertSettings.WilorinDemontamer = ImGuiExtension.ColorPicker("Wilorin Demontamer", settingsHub.PreloadAlertSettings.WilorinDemontamer);
                    settingsHub.PreloadAlertSettings.AugustinaSolaria = ImGuiExtension.ColorPicker("Augustina Solaria", settingsHub.PreloadAlertSettings.AugustinaSolaria);
                    settingsHub.PreloadAlertSettings.DenaLorenni = ImGuiExtension.ColorPicker("Dena Lorenni", settingsHub.PreloadAlertSettings.DenaLorenni);
                    settingsHub.PreloadAlertSettings.VanthAgiel = ImGuiExtension.ColorPicker("Vanth Agiel", settingsHub.PreloadAlertSettings.VanthAgiel);
                    settingsHub.PreloadAlertSettings.LaelFuria = ImGuiExtension.ColorPicker("Lael Furia", settingsHub.PreloadAlertSettings.LaelFuria);
                    settingsHub.PreloadAlertSettings.OyraOna = ImGuiExtension.ColorPicker("OyraOna", settingsHub.PreloadAlertSettings.OyraOna);
                    settingsHub.PreloadAlertSettings.BoltBrownfur = ImGuiExtension.ColorPicker("BoltBrownfur", settingsHub.PreloadAlertSettings.BoltBrownfur);
                    settingsHub.PreloadAlertSettings.AilentiaRac = ImGuiExtension.ColorPicker("AilentiaRac", settingsHub.PreloadAlertSettings.AilentiaRac);
                    settingsHub.PreloadAlertSettings.UlyssesMorvant = ImGuiExtension.ColorPicker("UlyssesMorvant", settingsHub.PreloadAlertSettings.UlyssesMorvant);
                    settingsHub.PreloadAlertSettings.AurelioVoidsinger = ImGuiExtension.ColorPicker("AurelioVoidsinger", settingsHub.PreloadAlertSettings.AurelioVoidsinger);

                    ImGui.TreePop();
                }

                if (ImGui.TreeNode("Strongboxes"))
                {
                    settingsHub.PreloadAlertSettings.Strongboxes = ImGuiExtension.Checkbox("Enable", settingsHub.PreloadAlertSettings.Strongboxes);
                    settingsHub.PreloadAlertSettings.ArcanistStrongbox = ImGuiExtension.ColorPicker("Arcanist", settingsHub.PreloadAlertSettings.ArcanistStrongbox);
                    settingsHub.PreloadAlertSettings.ArtisanStrongbox = ImGuiExtension.ColorPicker("Artisan", settingsHub.PreloadAlertSettings.ArtisanStrongbox);
                    settingsHub.PreloadAlertSettings.CartographerStrongbox = ImGuiExtension.ColorPicker("Cartographer", settingsHub.PreloadAlertSettings.CartographerStrongbox);
                    settingsHub.PreloadAlertSettings.DivinerStrongbox = ImGuiExtension.ColorPicker("Diviner", settingsHub.PreloadAlertSettings.DivinerStrongbox);
                    settingsHub.PreloadAlertSettings.GemcutterStrongbox = ImGuiExtension.ColorPicker("Gemcutter", settingsHub.PreloadAlertSettings.GemcutterStrongbox);
                    settingsHub.PreloadAlertSettings.JewellerStrongbox = ImGuiExtension.ColorPicker("Jeweller", settingsHub.PreloadAlertSettings.JewellerStrongbox);
                    settingsHub.PreloadAlertSettings.BlacksmithStrongbox = ImGuiExtension.ColorPicker("Blacksmith", settingsHub.PreloadAlertSettings.BlacksmithStrongbox);
                    settingsHub.PreloadAlertSettings.ArmourerStrongbox = ImGuiExtension.ColorPicker("Armourer", settingsHub.PreloadAlertSettings.ArmourerStrongbox);
                    settingsHub.PreloadAlertSettings.OrnateStrongbox = ImGuiExtension.ColorPicker("Ornate", settingsHub.PreloadAlertSettings.OrnateStrongbox);
                    settingsHub.PreloadAlertSettings.LargeStrongbox = ImGuiExtension.ColorPicker("Large", settingsHub.PreloadAlertSettings.LargeStrongbox);
                    settingsHub.PreloadAlertSettings.PerandusStrongbox = ImGuiExtension.ColorPicker("Perandus", settingsHub.PreloadAlertSettings.PerandusStrongbox);
                    settingsHub.PreloadAlertSettings.KaomStrongbox = ImGuiExtension.ColorPicker("Kaom", settingsHub.PreloadAlertSettings.KaomStrongbox);
                    settingsHub.PreloadAlertSettings.MalachaiStrongbox = ImGuiExtension.ColorPicker("Malachai", settingsHub.PreloadAlertSettings.MalachaiStrongbox);
                    settingsHub.PreloadAlertSettings.EpicStrongbox = ImGuiExtension.ColorPicker("Epic", settingsHub.PreloadAlertSettings.EpicStrongbox);
                    settingsHub.PreloadAlertSettings.SimpleStrongbox = ImGuiExtension.ColorPicker("Simple", settingsHub.PreloadAlertSettings.SimpleStrongbox);

                    ImGui.TreePop();
                }

                if (ImGui.TreeNode("Essenses"))
                {
                    settingsHub.PreloadAlertSettings.Essence = ImGuiExtension.Checkbox("Enable", settingsHub.PreloadAlertSettings.Essence);

                    settingsHub.PreloadAlertSettings.RemnantOfCorruption = ImGuiExtension.ColorPicker("Remnant of Corruption", settingsHub.PreloadAlertSettings.RemnantOfCorruption);
                    settingsHub.PreloadAlertSettings.EssenceOfAnger = ImGuiExtension.ColorPicker("Essence of Anger", settingsHub.PreloadAlertSettings.EssenceOfAnger);
                    settingsHub.PreloadAlertSettings.EssenceOfAnguish = ImGuiExtension.ColorPicker("Essence of Anguish", settingsHub.PreloadAlertSettings.EssenceOfAnguish);
                    settingsHub.PreloadAlertSettings.EssenceOfContempt = ImGuiExtension.ColorPicker("Essence of Contempt", settingsHub.PreloadAlertSettings.EssenceOfContempt);
                    settingsHub.PreloadAlertSettings.EssenceOfDelirium = ImGuiExtension.ColorPicker("Essence of Delirium", settingsHub.PreloadAlertSettings.EssenceOfDelirium);
                    settingsHub.PreloadAlertSettings.EssenceOfDoubt = ImGuiExtension.ColorPicker("Essence of Doubt", settingsHub.PreloadAlertSettings.EssenceOfDoubt);
                    settingsHub.PreloadAlertSettings.EssenceOfDread = ImGuiExtension.ColorPicker("Essence of Dread", settingsHub.PreloadAlertSettings.EssenceOfDread);
                    settingsHub.PreloadAlertSettings.EssenceOfEnvy = ImGuiExtension.ColorPicker("Essence of Envy", settingsHub.PreloadAlertSettings.EssenceOfEnvy);
                    settingsHub.PreloadAlertSettings.EssenceOfFear = ImGuiExtension.ColorPicker("Essence of Fear", settingsHub.PreloadAlertSettings.EssenceOfFear);
                    settingsHub.PreloadAlertSettings.EssenceOfGreed = ImGuiExtension.ColorPicker("Essence of Greed", settingsHub.PreloadAlertSettings.EssenceOfGreed);
                    settingsHub.PreloadAlertSettings.EssenceOfHatred = ImGuiExtension.ColorPicker("Essence of Hatred", settingsHub.PreloadAlertSettings.EssenceOfHatred);
                    settingsHub.PreloadAlertSettings.EssenceOfHorror = ImGuiExtension.ColorPicker("Essence of Horror", settingsHub.PreloadAlertSettings.EssenceOfHorror);
                    settingsHub.PreloadAlertSettings.EssenceOfHysteria = ImGuiExtension.ColorPicker("Essence of Hysteria", settingsHub.PreloadAlertSettings.EssenceOfHysteria);
                    settingsHub.PreloadAlertSettings.EssenceOfInsanity = ImGuiExtension.ColorPicker("Essence of Insanity", settingsHub.PreloadAlertSettings.EssenceOfInsanity);
                    settingsHub.PreloadAlertSettings.EssenceOfLoathing = ImGuiExtension.ColorPicker("Essence of Loathing", settingsHub.PreloadAlertSettings.EssenceOfLoathing);
                    settingsHub.PreloadAlertSettings.EssenceOfMisery = ImGuiExtension.ColorPicker("Essence of Misery", settingsHub.PreloadAlertSettings.EssenceOfMisery);
                    settingsHub.PreloadAlertSettings.EssenceOfRage = ImGuiExtension.ColorPicker("Essence of Rage", settingsHub.PreloadAlertSettings.EssenceOfRage);
                    settingsHub.PreloadAlertSettings.EssenceOfScorn = ImGuiExtension.ColorPicker("Essence of Scorn", settingsHub.PreloadAlertSettings.EssenceOfScorn);
                    settingsHub.PreloadAlertSettings.EssenceOfSorrow = ImGuiExtension.ColorPicker("Essence of Sorrow", settingsHub.PreloadAlertSettings.EssenceOfSorrow);
                    settingsHub.PreloadAlertSettings.EssenceOfSpite = ImGuiExtension.ColorPicker("Essence of Spite", settingsHub.PreloadAlertSettings.EssenceOfSpite);
                    settingsHub.PreloadAlertSettings.EssenceOfSuffering = ImGuiExtension.ColorPicker("Essence of Suffering", settingsHub.PreloadAlertSettings.EssenceOfSuffering);
                    settingsHub.PreloadAlertSettings.EssenceOfTorment = ImGuiExtension.ColorPicker("Essence of Torment", settingsHub.PreloadAlertSettings.EssenceOfTorment);
                    settingsHub.PreloadAlertSettings.EssenceOfWoe = ImGuiExtension.ColorPicker("Essence of Woe", settingsHub.PreloadAlertSettings.EssenceOfWoe);
                    settingsHub.PreloadAlertSettings.EssenceOfWrath = ImGuiExtension.ColorPicker("Essence of Wrath", settingsHub.PreloadAlertSettings.EssenceOfWrath);
                    settingsHub.PreloadAlertSettings.EssenceOfZeal = ImGuiExtension.ColorPicker("Essence of Zeal", settingsHub.PreloadAlertSettings.EssenceOfZeal);

                    ImGui.TreePop();
                }

                if (ImGui.TreeNode("Perandus Chests"))
                {
                    settingsHub.PreloadAlertSettings.PerandusBoxes = ImGuiExtension.Checkbox("Enable", settingsHub.PreloadAlertSettings.PerandusBoxes);

                    settingsHub.PreloadAlertSettings.RemnantOfCorruption = ImGuiExtension.ColorPicker("Remnant of Corruption", settingsHub.PreloadAlertSettings.RemnantOfCorruption);

                    settingsHub.PreloadAlertSettings.CadiroTrader = ImGuiExtension.ColorPicker("Cadiro Trader", settingsHub.PreloadAlertSettings.CadiroTrader);
                    settingsHub.PreloadAlertSettings.PerandusChestStandard = ImGuiExtension.ColorPicker("Perandus Chest", settingsHub.PreloadAlertSettings.PerandusChestStandard);
                    settingsHub.PreloadAlertSettings.PerandusChestRarity = ImGuiExtension.ColorPicker("Perandus Cache", settingsHub.PreloadAlertSettings.PerandusChestRarity);
                    settingsHub.PreloadAlertSettings.PerandusChestQuantity = ImGuiExtension.ColorPicker("Perandus Hoard", settingsHub.PreloadAlertSettings.PerandusChestQuantity);
                    settingsHub.PreloadAlertSettings.PerandusChestCoins = ImGuiExtension.ColorPicker("Perandus Coffer", settingsHub.PreloadAlertSettings.PerandusChestCoins);
                    settingsHub.PreloadAlertSettings.PerandusChestJewellery = ImGuiExtension.ColorPicker("Perandus Jewellery", settingsHub.PreloadAlertSettings.PerandusChestJewellery);
                    settingsHub.PreloadAlertSettings.PerandusChestGems = ImGuiExtension.ColorPicker("Perandus Safe", settingsHub.PreloadAlertSettings.PerandusChestGems);
                    settingsHub.PreloadAlertSettings.PerandusChestCurrency = ImGuiExtension.ColorPicker("Perandus Treasury", settingsHub.PreloadAlertSettings.PerandusChestCurrency);
                    settingsHub.PreloadAlertSettings.PerandusChestInventory = ImGuiExtension.ColorPicker("Perandus Wardrobe", settingsHub.PreloadAlertSettings.PerandusChestInventory);
                    settingsHub.PreloadAlertSettings.PerandusChestDivinationCards = ImGuiExtension.ColorPicker("Perandus Catalogue", settingsHub.PreloadAlertSettings.PerandusChestDivinationCards);
                    settingsHub.PreloadAlertSettings.PerandusChestKeepersOfTheTrove = ImGuiExtension.ColorPicker("Perandus Trove", settingsHub.PreloadAlertSettings.PerandusChestKeepersOfTheTrove);
                    settingsHub.PreloadAlertSettings.PerandusChestUniqueItem = ImGuiExtension.ColorPicker("Perandus Locker", settingsHub.PreloadAlertSettings.PerandusChestUniqueItem);
                    settingsHub.PreloadAlertSettings.PerandusChestMaps = ImGuiExtension.ColorPicker("Perandus Archive", settingsHub.PreloadAlertSettings.PerandusChestMaps);
                    settingsHub.PreloadAlertSettings.PerandusChestFishing = ImGuiExtension.ColorPicker("Perandus Tackle Box", settingsHub.PreloadAlertSettings.PerandusChestFishing);
                    settingsHub.PreloadAlertSettings.PerandusManorUniqueChest = ImGuiExtension.ColorPicker("Cadiro's Locker", settingsHub.PreloadAlertSettings.PerandusManorUniqueChest);
                    settingsHub.PreloadAlertSettings.PerandusManorCurrencyChest = ImGuiExtension.ColorPicker("Cadiro's Treasury", settingsHub.PreloadAlertSettings.PerandusManorCurrencyChest);
                    settingsHub.PreloadAlertSettings.PerandusManorMapsChest = ImGuiExtension.ColorPicker("Cadiro's Archive", settingsHub.PreloadAlertSettings.PerandusManorMapsChest);
                    settingsHub.PreloadAlertSettings.PerandusManorJewelryChest = ImGuiExtension.ColorPicker("Cadiro's Jewellery", settingsHub.PreloadAlertSettings.PerandusManorJewelryChest);
                    settingsHub.PreloadAlertSettings.PerandusManorDivinationCardsChest = ImGuiExtension.ColorPicker("Cadiro's Catalogue", settingsHub.PreloadAlertSettings.PerandusManorDivinationCardsChest);
                    settingsHub.PreloadAlertSettings.PerandusManorLostTreasureChest = ImGuiExtension.ColorPicker("Grand Perandus Vault", settingsHub.PreloadAlertSettings.PerandusManorLostTreasureChest);

                    ImGui.TreePop();
                }

                if (ImGui.TreeNode("Corrupted Area"))
                {
                    settingsHub.PreloadAlertSettings.CorruptedArea = ImGuiExtension.Checkbox("Enable", settingsHub.PreloadAlertSettings.CorruptedArea);
                    settingsHub.PreloadAlertSettings.CorruptedTitle = ImGuiExtension.Checkbox("Corrupted title", settingsHub.PreloadAlertSettings.CorruptedTitle);
                    settingsHub.PreloadAlertSettings.CorruptedAreaColor = ImGuiExtension.ColorPicker("Corrupted color", settingsHub.PreloadAlertSettings.CorruptedAreaColor);

                    ImGui.TreePop();
                }

                settingsHub.PreloadAlertSettings.BackgroundColor = ImGuiExtension.ColorPicker("Background color", settingsHub.PreloadAlertSettings.BackgroundColor);
                settingsHub.PreloadAlertSettings.DefaultTextColor = ImGuiExtension.ColorPicker("Font color", settingsHub.PreloadAlertSettings.DefaultTextColor);
                settingsHub.PreloadAlertSettings.TextSize.Value = ImGuiExtension.IntSlider("Font size", settingsHub.PreloadAlertSettings.TextSize);


                ImGui.TreePop();
            }

            if (ImGui.TreeNode("Monster alert"))
            {
                settingsHub.MonsterTrackerSettings.Enable = ImGuiExtension.Checkbox("Enable", settingsHub.MonsterTrackerSettings.Enable);

                if (ImGui.TreeNode("Sound warning"))
                {
                    settingsHub.MonsterTrackerSettings.PlaySound = ImGuiExtension.Checkbox("Enable", settingsHub.MonsterTrackerSettings.PlaySound);
                    settingsHub.MonsterTrackerSettings.SoundVolume.Value = ImGuiExtension.IntSlider("Sound volume", settingsHub.MonsterTrackerSettings.SoundVolume);

                    ImGui.TreePop();
                }

                if (ImGui.TreeNode("Text warning"))
                {
                    settingsHub.MonsterTrackerSettings.ShowText = ImGuiExtension.Checkbox("Enable", settingsHub.MonsterTrackerSettings.ShowText);
                    settingsHub.MonsterTrackerSettings.TextSize.Value = ImGuiExtension.IntSlider("Text size", settingsHub.MonsterTrackerSettings.TextSize);
                    settingsHub.MonsterTrackerSettings.DefaultTextColor = ImGuiExtension.ColorPicker("Default text color:", settingsHub.MonsterTrackerSettings.DefaultTextColor);
                    settingsHub.MonsterTrackerSettings.BackgroundColor = ImGuiExtension.ColorPicker("Background color:", settingsHub.MonsterTrackerSettings.BackgroundColor);
                    settingsHub.MonsterTrackerSettings.TextPositionX.Value = ImGuiExtension.IntSlider("Position X", settingsHub.MonsterTrackerSettings.TextPositionX);
                    settingsHub.MonsterTrackerSettings.TextPositionY.Value = ImGuiExtension.IntSlider("Position Y", settingsHub.MonsterTrackerSettings.TextPositionY);

                    ImGui.TreePop();
                }

                ImGui.TreePop();
            }

            if (ImGui.TreeNode("Monster kills"))
            {
                settingsHub.KillCounterSettings.Enable = ImGuiExtension.Checkbox("Enable", settingsHub.KillCounterSettings.Enable);
                settingsHub.KillCounterSettings.ShowDetail = ImGuiExtension.Checkbox("Show details", settingsHub.KillCounterSettings.ShowDetail);
                settingsHub.KillCounterSettings.ShowInTown = ImGuiExtension.Checkbox("Show in town", settingsHub.KillCounterSettings.ShowInTown);
                settingsHub.KillCounterSettings.TextColor = ImGuiExtension.ColorPicker("Font color", settingsHub.KillCounterSettings.TextColor);
                settingsHub.KillCounterSettings.BackgroundColor = ImGuiExtension.ColorPicker("Background color", settingsHub.KillCounterSettings.BackgroundColor);
                settingsHub.KillCounterSettings.LabelTextSize.Value = ImGuiExtension.IntSlider("Label font size", settingsHub.KillCounterSettings.LabelTextSize);
                settingsHub.KillCounterSettings.KillsTextSize.Value = ImGuiExtension.IntSlider("Kills font size", settingsHub.KillCounterSettings.KillsTextSize);

                ImGui.TreePop();
            }

            if (ImGui.TreeNode("Show dps"))
            {
                settingsHub.DpsMeterSettings.Enable = ImGuiExtension.Checkbox("Enable", settingsHub.DpsMeterSettings.Enable);
                settingsHub.DpsMeterSettings.ShowInTown = ImGuiExtension.Checkbox("Show in town", settingsHub.DpsMeterSettings.ShowInTown);
                settingsHub.DpsMeterSettings.DpsTextSize.Value = ImGuiExtension.IntSlider("Dps font size", settingsHub.DpsMeterSettings.DpsTextSize);
                settingsHub.DpsMeterSettings.PeakDpsTextSize.Value = ImGuiExtension.IntSlider("Top font size", settingsHub.DpsMeterSettings.PeakDpsTextSize);
                settingsHub.DpsMeterSettings.BackgroundColor = ImGuiExtension.ColorPicker("Background color", settingsHub.DpsMeterSettings.BackgroundColor);
                settingsHub.DpsMeterSettings.DpsFontColor = ImGuiExtension.ColorPicker("Dps font color", settingsHub.DpsMeterSettings.DpsFontColor);
                settingsHub.DpsMeterSettings.PeakFontColor = ImGuiExtension.ColorPicker("Top font color", settingsHub.DpsMeterSettings.PeakFontColor);
                settingsHub.DpsMeterSettings.CalcAOE = ImGuiExtension.Checkbox("Show AOE", settingsHub.DpsMeterSettings.CalcAOE);
                if (ImGui.Button("Clear"))
                {
                    settingsHub.DpsMeterSettings.ClearNode.OnPressed();
                }

                ImGui.TreePop();
            }

            if (ImGui.TreeNode("Map Icons"))
            {
                settingsHub.MapIconsSettings.Enable = ImGuiExtension.Checkbox("Enable", settingsHub.MapIconsSettings.Enable);

                if (ImGui.TreeNode("Icon Sizes"))
                {
                    settingsHub.MonsterTrackerSettings.ShowText = ImGuiExtension.Checkbox("Enable", settingsHub.MonsterTrackerSettings.ShowText);

                    settingsHub.MonsterTrackerSettings.WhiteMobIcon.Value = ImGuiExtension.IntSlider("White Mob Icons", settingsHub.MonsterTrackerSettings.WhiteMobIcon);
                    settingsHub.MonsterTrackerSettings.MagicMobIcon.Value = ImGuiExtension.IntSlider("Magic Mob Icons", settingsHub.MonsterTrackerSettings.MagicMobIcon);
                    settingsHub.MonsterTrackerSettings.RareMobIcon.Value = ImGuiExtension.IntSlider("Rare Mob Icons", settingsHub.MonsterTrackerSettings.RareMobIcon);
                    settingsHub.MonsterTrackerSettings.UniqueMobIcon.Value = ImGuiExtension.IntSlider("Unique Mob Icons", settingsHub.MonsterTrackerSettings.UniqueMobIcon);
                    settingsHub.MonsterTrackerSettings.MinionsIcon.Value = ImGuiExtension.IntSlider("Minion Icons", settingsHub.MonsterTrackerSettings.MinionsIcon);
                    settingsHub.PoiTrackerSettings.MastersIcon.Value = ImGuiExtension.IntSlider("Master Icons", settingsHub.PoiTrackerSettings.MastersIcon);
                    settingsHub.PoiTrackerSettings.ChestsIcon.Value = ImGuiExtension.IntSlider("Chest Icons", settingsHub.PoiTrackerSettings.ChestsIcon);
                    settingsHub.PoiTrackerSettings.StrongboxesIcon.Value = ImGuiExtension.IntSlider("Strongbox Icons", settingsHub.PoiTrackerSettings.StrongboxesIcon);
                    settingsHub.PoiTrackerSettings.PerandusChestIcon.Value = ImGuiExtension.IntSlider("Perandus Chest Icons", settingsHub.PoiTrackerSettings.PerandusChestIcon);
                    settingsHub.PoiTrackerSettings.BreachChestIcon.Value = ImGuiExtension.IntSlider("Breach Chest Icons", settingsHub.PoiTrackerSettings.BreachChestIcon);

                    ImGui.TreePop();
                }

                ImGui.TreePop();
            }


            // TODO: Need a hotkey here.
            // TODO: Is Enable the right thing to use here?
            settingsHub.MenuSettings.Enable = ImGuiExtension.Checkbox("Show Menu", settingsHub.MenuSettings.Enable);

            if (ImGui.TreeNode("Performance"))
            {
                settingsHub.PerformanceSettings.Enable = ImGuiExtension.Checkbox("Performance", settingsHub.PerformanceSettings.Enable);

                settingsHub.PerformanceSettings.RenderLimit.Value = ImGuiExtension.IntSlider("FPS Render limit", settingsHub.PerformanceSettings.RenderLimit);
                settingsHub.PerformanceSettings.UpdateEntityDataLimit.Value = ImGuiExtension.IntSlider("FPS Update entity limit", settingsHub.PerformanceSettings.UpdateEntityDataLimit);
                settingsHub.PerformanceSettings.UpdateAreaLimit.Value = ImGuiExtension.IntSlider("Update areachange every N ms", settingsHub.PerformanceSettings.UpdateAreaLimit);
                settingsHub.PerformanceSettings.Cache = ImGuiExtension.Checkbox("Use cache for most data", settingsHub.PerformanceSettings.Cache);
                settingsHub.PerformanceSettings.ParallelEntityUpdate = ImGuiExtension.Checkbox("Update entity in parallel thread(Experimental/Unstable) [Need restart]", settingsHub.PerformanceSettings.ParallelEntityUpdate);
                settingsHub.PerformanceSettings.UpdateIngemeStateLimit.Value = ImGuiExtension.IntSlider("Update ingame state every N ms", settingsHub.PerformanceSettings.UpdateIngemeStateLimit);
                settingsHub.PerformanceSettings.AlwaysForeground = ImGuiExtension.Checkbox("Always Foreground", settingsHub.PerformanceSettings.AlwaysForeground);

                ImGui.TreePop();
            }
        }

        private void CreatePluginsMenu()
        {
            ImGui.Columns(2, "Columns", true);
            BasePlugin selectedPlugin = null;
            if (ImGui.BeginChild("Child1", true))
            {
                var pluginNames = PluginExtensionPlugin.Plugins.Select(x => x.PluginName).ToList();
                if (SelectedPluginName == null)
                    SelectedPluginName = pluginNames.FirstOrDefault();

                pluginNames.ForEach(x => { if (ImGui.Selectable(x, SelectedPluginName == x)) SelectedPluginName = x; });

                selectedPlugin = PluginExtensionPlugin.Plugins.FirstOrDefault(x => x.PluginName == SelectedPluginName);
                ImGui.EndChild();
            }

            ImGui.NextColumn();

            if (ImGui.BeginChild("Child2", true))
            {
                if (selectedPlugin != null)
                    selectedPlugin.RenderMenu();
                else ImGui.Text("No plugin selected");
                ImGui.EndChild();
            }
        }
    }
}