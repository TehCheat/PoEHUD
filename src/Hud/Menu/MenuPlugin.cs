using System;
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

        private string SelectedPluginName = null;

        private void CreateImGuiMenu()
        {
            bool tmp = Settings.Enable.Value;

            if (ImGui.BeginWindow("PoeHUD", ref tmp, WindowFlags.Default))
            {
                ImGui.Columns(2, "Columns", true);
                BasePlugin selectedPlugin = null;
                if (ImGui.BeginChild("Child1", true))
                {
                    var pluginNames = PluginExtensionPlugin.Plugins.Select(x => x.PluginName).ToList();
                    if (SelectedPluginName == null)
                        SelectedPluginName = pluginNames.FirstOrDefault();
                    SelectedPluginName = ImGuiExtension.ComboBox("Plugins", SelectedPluginName, pluginNames);

                    selectedPlugin = PluginExtensionPlugin.Plugins.FirstOrDefault(x => x.PluginName == SelectedPluginName);
                    ImGui.EndChild();
                }

                ImGui.NextColumn();

                if (ImGui.BeginChild("Child2", true))
                {
                    if (selectedPlugin != null)
                        selectedPlugin.Render();
                    else ImGui.Text("No plugin selected");
                    ImGui.EndChild();
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

/*        private void CreateMenu()
        {
            MenuRootButton = new RootButton(new Vector2(Settings.X, Settings.Y));
            MenuRootButton.eOnClose += delegate { SettingsHub.Save(settingsHub); };
            MenuItem CoreMenu = AddChild(MenuRootButton, "Core Settings");
            // Health bars
            HealthBarSettings healthBarPlugin = settingsHub.HealthBarSettings;
            MenuItem healthMenu = AddChild(CoreMenu, "Health bars", healthBarPlugin.Enable);
            MenuItem playersMenu = AddChild(healthMenu, "Players", healthBarPlugin.Players.Enable);
            MenuItem enemiesMenu = AddChild(healthMenu, "Enemies", healthBarPlugin.ShowEnemies);
            MenuItem minionsMenu = AddChild(healthMenu, "Minions", healthBarPlugin.Minions.Enable);
            AddChild(healthMenu, "Show energy shield", healthBarPlugin.ShowES);
            AddChild(healthMenu, "Show in town", healthBarPlugin.ShowInTown);
            MenuItem debuffPanelMenu = AddChild(healthMenu, "Show debuffs", healthBarPlugin.ShowDebuffPanel);
            AddChild(debuffPanelMenu, "Icon size", healthBarPlugin.DebuffPanelIconSize);
            AddChild(playersMenu, "Print percents", healthBarPlugin.Players.ShowPercents);
            AddChild(playersMenu, "Print health text", healthBarPlugin.Players.ShowHealthText);
            AddChild(playersMenu, "Width", healthBarPlugin.Players.Width);
            AddChild(playersMenu, "Height", healthBarPlugin.Players.Height);
            MenuItem playerDPSMenu = AddChild(playersMenu, "Floating combat text", healthBarPlugin.Players.ShowFloatingCombatDamage);
            AddChild(playerDPSMenu, "Text size", healthBarPlugin.Players.FloatingCombatTextSize);
            AddChild(playerDPSMenu, "Damage Color", healthBarPlugin.Players.FloatingCombatDamageColor);
            AddChild(playerDPSMenu, "Heal Color", healthBarPlugin.Players.FloatingCombatHealColor);
            AddChild(playerDPSMenu, "Number of lines", healthBarPlugin.Players.FloatingCombatStackSize);
            AddChild(minionsMenu, "Print percents", healthBarPlugin.Minions.ShowPercents);
            AddChild(minionsMenu, "Print health text", healthBarPlugin.Minions.ShowHealthText);
            AddChild(minionsMenu, "Width", healthBarPlugin.Minions.Width);
            AddChild(minionsMenu, "Height", healthBarPlugin.Minions.Height);
            MenuItem minionsDPSMenu = AddChild(minionsMenu, "Floating combat text", healthBarPlugin.Minions.ShowFloatingCombatDamage);
            AddChild(minionsDPSMenu, "Text size", healthBarPlugin.Minions.FloatingCombatTextSize);
            AddChild(minionsDPSMenu, "Damage color", healthBarPlugin.Minions.FloatingCombatDamageColor);
            AddChild(minionsDPSMenu, "Heal color", healthBarPlugin.Minions.FloatingCombatHealColor);
            AddChild(minionsDPSMenu, "Number of lines", healthBarPlugin.Minions.FloatingCombatStackSize);
            MenuItem whiteEnemyMenu = AddChild(enemiesMenu, "White", healthBarPlugin.NormalEnemy.Enable);
            AddChild(whiteEnemyMenu, "Print percents", healthBarPlugin.NormalEnemy.ShowPercents);
            AddChild(whiteEnemyMenu, "Print health text", healthBarPlugin.NormalEnemy.ShowHealthText);
            AddChild(whiteEnemyMenu, "Width", healthBarPlugin.NormalEnemy.Width);
            AddChild(whiteEnemyMenu, "Height", healthBarPlugin.NormalEnemy.Height);
            MenuItem whiteEnemyDPSMenu = AddChild(whiteEnemyMenu, "Floating combat text", healthBarPlugin.NormalEnemy.ShowFloatingCombatDamage);
            AddChild(whiteEnemyDPSMenu, "Text size", healthBarPlugin.NormalEnemy.FloatingCombatTextSize);
            AddChild(whiteEnemyDPSMenu, "Damage color", healthBarPlugin.NormalEnemy.FloatingCombatDamageColor);
            AddChild(whiteEnemyDPSMenu, "Heal color", healthBarPlugin.NormalEnemy.FloatingCombatHealColor);
            AddChild(whiteEnemyDPSMenu, "Number of lines", healthBarPlugin.NormalEnemy.FloatingCombatStackSize);
            MenuItem magicEnemyMenu = AddChild(enemiesMenu, "Magic", healthBarPlugin.MagicEnemy.Enable);
            AddChild(magicEnemyMenu, "Print percents", healthBarPlugin.MagicEnemy.ShowPercents);
            AddChild(magicEnemyMenu, "Print health text", healthBarPlugin.MagicEnemy.ShowHealthText);
            AddChild(magicEnemyMenu, "Width", healthBarPlugin.MagicEnemy.Width);
            AddChild(magicEnemyMenu, "Height", healthBarPlugin.MagicEnemy.Height);
            MenuItem magicEnemyDPSMenu = AddChild(magicEnemyMenu, "Floating combat text", healthBarPlugin.MagicEnemy.ShowFloatingCombatDamage);
            AddChild(magicEnemyDPSMenu, "Text size", healthBarPlugin.MagicEnemy.FloatingCombatTextSize);
            AddChild(magicEnemyDPSMenu, "Damage color", healthBarPlugin.MagicEnemy.FloatingCombatDamageColor);
            AddChild(magicEnemyDPSMenu, "Heal color", healthBarPlugin.MagicEnemy.FloatingCombatHealColor);
            AddChild(magicEnemyDPSMenu, "Number of lines", healthBarPlugin.MagicEnemy.FloatingCombatStackSize);
            MenuItem rareEnemyMenu = AddChild(enemiesMenu, "Rare", healthBarPlugin.RareEnemy.Enable);
            AddChild(rareEnemyMenu, "Print percents", healthBarPlugin.RareEnemy.ShowPercents);
            AddChild(rareEnemyMenu, "Print health text", healthBarPlugin.RareEnemy.ShowHealthText);
            AddChild(rareEnemyMenu, "Width", healthBarPlugin.RareEnemy.Width);
            AddChild(rareEnemyMenu, "Height", healthBarPlugin.RareEnemy.Height);
            MenuItem rareEnemyDPSMenu = AddChild(rareEnemyMenu, "Floating combat text", healthBarPlugin.RareEnemy.ShowFloatingCombatDamage);
            AddChild(rareEnemyDPSMenu, "Text size", healthBarPlugin.RareEnemy.FloatingCombatTextSize);
            AddChild(rareEnemyDPSMenu, "Damage color", healthBarPlugin.RareEnemy.FloatingCombatDamageColor);
            AddChild(rareEnemyDPSMenu, "Heal color", healthBarPlugin.RareEnemy.FloatingCombatHealColor);
            AddChild(rareEnemyDPSMenu, "Number of lines", healthBarPlugin.RareEnemy.FloatingCombatStackSize);
            MenuItem uniquesEnemyMenu = AddChild(enemiesMenu, "Uniques", healthBarPlugin.UniqueEnemy.Enable);
            AddChild(uniquesEnemyMenu, "Print percents", healthBarPlugin.UniqueEnemy.ShowPercents);
            AddChild(uniquesEnemyMenu, "Print health text", healthBarPlugin.UniqueEnemy.ShowHealthText);
            AddChild(uniquesEnemyMenu, "Width", healthBarPlugin.UniqueEnemy.Width);
            AddChild(uniquesEnemyMenu, "Height", healthBarPlugin.UniqueEnemy.Height);
            MenuItem uniqueEnemyDPSMenu = AddChild(uniquesEnemyMenu, "Floating combat text", healthBarPlugin.UniqueEnemy.ShowFloatingCombatDamage);
            AddChild(uniqueEnemyDPSMenu, "Text size", healthBarPlugin.UniqueEnemy.FloatingCombatTextSize);
            AddChild(uniqueEnemyDPSMenu, "Damage color", healthBarPlugin.UniqueEnemy.FloatingCombatDamageColor);
            AddChild(uniqueEnemyDPSMenu, "Heal color", healthBarPlugin.UniqueEnemy.FloatingCombatHealColor);
            AddChild(uniqueEnemyDPSMenu, "Number of lines", healthBarPlugin.UniqueEnemy.FloatingCombatStackSize);

            // Xph Display
            MenuItem xpRateMenu = AddChild(CoreMenu, "Xph & area", settingsHub.XpRateSettings.Enable, "F10");
            AddChild(xpRateMenu, "Only area name", settingsHub.XpRateSettings.OnlyAreaName);
            AddChild(xpRateMenu, "Show in town", settingsHub.XpRateSettings.ShowInTown);
            AddChild(xpRateMenu, "Font size", settingsHub.XpRateSettings.TextSize);
            AddChild(xpRateMenu, "Fps font color", settingsHub.XpRateSettings.FpsTextColor);
            AddChild(xpRateMenu, "Xph font color", settingsHub.XpRateSettings.XphTextColor);
            AddChild(xpRateMenu, "Area font color", settingsHub.PreloadAlertSettings.AreaTextColor);
            AddChild(xpRateMenu, "Time left color", settingsHub.XpRateSettings.TimeLeftColor);
            AddChild(xpRateMenu, "Timer font color", settingsHub.XpRateSettings.TimerTextColor);
            AddChild(xpRateMenu, "Latency font color", settingsHub.XpRateSettings.LatencyTextColor);
            AddChild(xpRateMenu, "Background color", settingsHub.XpRateSettings.BackgroundColor);
            AddChild(xpRateMenu, "Show latency", settingsHub.XpRateSettings.ShowLatency);
            AddChild(xpRateMenu, "Show fps", settingsHub.XpRateSettings.ShowFps);

            // Item Alert
            MenuItem itemAlertMenu = AddChild(CoreMenu, "Item alert", settingsHub.ItemAlertSettings.Enable);
            string[ ] itemAlertStaticMenuList = { "Custom Item Filter", "Item tooltips", "Play sound", "Show text", "Hide others", "Show border", "Dim Others" };
            MenuItem alternative = AddChild(itemAlertMenu, itemAlertStaticMenuList[0], settingsHub.ItemAlertSettings.Alternative, null, y => itemAlertStaticMenuList.All(x => x != (y as ToggleButton)?.Name));
            AddChild(alternative, settingsHub.ItemAlertSettings.FilePath);
            AddChild(alternative, "With border", settingsHub.ItemAlertSettings.WithBorder);
            AddChild(alternative, "With sound", settingsHub.ItemAlertSettings.WithSound);
            MenuItem tooltipMenu = AddChild(itemAlertMenu, itemAlertStaticMenuList[1], settingsHub.AdvancedTooltipSettings.Enable);
            MenuItem itemLevelMenu = AddChild(tooltipMenu, "Item level", settingsHub.AdvancedTooltipSettings.ItemLevel.Enable);
            AddChild(itemLevelMenu, "Text size", settingsHub.AdvancedTooltipSettings.ItemLevel.TextSize);
            AddChild(itemLevelMenu, "Text color", settingsHub.AdvancedTooltipSettings.ItemLevel.TextColor);
            AddChild(itemLevelMenu, "Background color", settingsHub.AdvancedTooltipSettings.ItemLevel.BackgroundColor);
            MenuItem itemModsMenu = AddChild(tooltipMenu, "Item mods", settingsHub.AdvancedTooltipSettings.ItemMods.Enable, "F9");
            AddChild(itemModsMenu, "Mods size", settingsHub.AdvancedTooltipSettings.ItemMods.ModTextSize);
            AddChild(itemModsMenu, "Tier 1 color", settingsHub.AdvancedTooltipSettings.ItemMods.T1Color);
            AddChild(itemModsMenu, "Tier 2 color", settingsHub.AdvancedTooltipSettings.ItemMods.T2Color);
            AddChild(itemModsMenu, "Tier 3 color", settingsHub.AdvancedTooltipSettings.ItemMods.T3Color);
            AddChild(itemModsMenu, "Suffix color", settingsHub.AdvancedTooltipSettings.ItemMods.SuffixColor);
            AddChild(itemModsMenu, "Prefix color", settingsHub.AdvancedTooltipSettings.ItemMods.PrefixColor);
            MenuItem weaponDpsMenu = AddChild(tooltipMenu, "Weapon Dps", settingsHub.AdvancedTooltipSettings.WeaponDps.Enable);
            MenuItem damageColors = AddChild(weaponDpsMenu, "Damage colors", settingsHub.AdvancedTooltipSettings.WeaponDps.Enable);
            AddChild(damageColors, "Cold damage", settingsHub.AdvancedTooltipSettings.WeaponDps.DmgColdColor);
            AddChild(damageColors, "Fire damage", settingsHub.AdvancedTooltipSettings.WeaponDps.DmgFireColor);
            AddChild(damageColors, "Lightning damage", settingsHub.AdvancedTooltipSettings.WeaponDps.DmgLightningColor);
            AddChild(damageColors, "Chaos damage", settingsHub.AdvancedTooltipSettings.WeaponDps.DmgChaosColor);
            AddChild(damageColors, "Physical damage", settingsHub.AdvancedTooltipSettings.WeaponDps.pDamageColor);
            AddChild(damageColors, "Elemental damage", settingsHub.AdvancedTooltipSettings.WeaponDps.eDamageColor);
            AddChild(weaponDpsMenu, "Text color", settingsHub.AdvancedTooltipSettings.WeaponDps.TextColor);
            AddChild(weaponDpsMenu, "Dps size", settingsHub.AdvancedTooltipSettings.WeaponDps.DpsTextSize);
            AddChild(weaponDpsMenu, "Dps text size", settingsHub.AdvancedTooltipSettings.WeaponDps.DpsNameTextSize);
            AddChild(weaponDpsMenu, "Background color", settingsHub.AdvancedTooltipSettings.WeaponDps.BackgroundColor);
            MenuItem itemSound = AddChild(itemAlertMenu, itemAlertStaticMenuList[2], settingsHub.ItemAlertSettings.PlaySound);
            AddChild(itemSound, "Sound volume", settingsHub.ItemAlertSettings.SoundVolume);
            MenuItem alertTextMenu = AddChild(itemAlertMenu, itemAlertStaticMenuList[3], settingsHub.ItemAlertSettings.ShowText);
            AddChild(alertTextMenu, "Text size", settingsHub.ItemAlertSettings.TextSize);
            AddChild(itemAlertMenu, itemAlertStaticMenuList[4], settingsHub.ItemAlertSettings.HideOthers);
            ItemAlertSettings dimOtherSettings = settingsHub.ItemAlertSettings;
            MenuItem dimOtherMenu = AddChild(itemAlertMenu, itemAlertStaticMenuList[6], dimOtherSettings.DimOtherByPercentToggle);
            AddChild(dimOtherMenu, "Dim Others By %", dimOtherSettings.DimOtherByPercent);
            BorderSettings borderSettings = settingsHub.ItemAlertSettings.BorderSettings;
            MenuItem showBorderMenu = AddChild(itemAlertMenu, itemAlertStaticMenuList[5], borderSettings.Enable);
            AddChild(showBorderMenu, "Border width", borderSettings.BorderWidth);
            AddChild(showBorderMenu, "Border color:", borderSettings.BorderColor);
            AddChild(showBorderMenu, "Can't pick up :", borderSettings.CantPickUpBorderColor);
            AddChild(showBorderMenu, "Not my item :", borderSettings.NotMyItemBorderColor);
            AddChild(showBorderMenu, "Show timer", borderSettings.ShowTimer);
            AddChild(showBorderMenu, "Timer text size", borderSettings.TimerTextSize);
            AddChild(itemAlertMenu, "Uniques", settingsHub.ItemAlertSettings.Uniques);
            AddChild(itemAlertMenu, "Rares", settingsHub.ItemAlertSettings.Rares);
            AddChild(itemAlertMenu, "Currency", settingsHub.ItemAlertSettings.Currency);
            AddChild(itemAlertMenu, "Maps", settingsHub.ItemAlertSettings.Maps);
            AddChild(itemAlertMenu, "RGB", settingsHub.ItemAlertSettings.Rgb);
            AddChild(itemAlertMenu, "Crafting bases", settingsHub.ItemAlertSettings.Crafting);
            AddChild(itemAlertMenu, "Divination cards", settingsHub.ItemAlertSettings.DivinationCards);
            AddChild(itemAlertMenu, "Jewels", settingsHub.ItemAlertSettings.Jewels);
            AddChild(itemAlertMenu, "Talisman", settingsHub.ItemAlertSettings.Talisman);
            QualityItemsSettings qualityItemsSettings = settingsHub.ItemAlertSettings.QualityItems;
            MenuItem qualityMenu = AddChild(itemAlertMenu, "Show quality items", qualityItemsSettings.Enable);
            MenuItem qualityWeaponMenu = AddChild(qualityMenu, "Weapons", qualityItemsSettings.Weapon.Enable);
            AddChild(qualityWeaponMenu, "Min. quality", qualityItemsSettings.Weapon.MinQuality);
            MenuItem qualityArmourMenu = AddChild(qualityMenu, "Armours", qualityItemsSettings.Armour.Enable);
            AddChild(qualityArmourMenu, "Min. quality", qualityItemsSettings.Armour.MinQuality);
            MenuItem qualityFlaskMenu = AddChild(qualityMenu, "Flasks", qualityItemsSettings.Flask.Enable);
            AddChild(qualityFlaskMenu, "Min. quality", qualityItemsSettings.Flask.MinQuality);
            MenuItem qualitySkillGemMenu = AddChild(qualityMenu, "Skill gems", qualityItemsSettings.SkillGem.Enable);
            AddChild(qualitySkillGemMenu, "Min. quality", qualityItemsSettings.SkillGem.MinQuality);

            // Preload Alert
            MenuItem preloadMenu = AddChild(CoreMenu, "Preload alert", settingsHub.PreloadAlertSettings.Enable, "F5");
            MenuItem masters = AddChild(preloadMenu, "Masters", settingsHub.PreloadAlertSettings.Masters);
            AddChild(masters, "Zana", settingsHub.PreloadAlertSettings.MasterZana);
            AddChild(masters, "Tora", settingsHub.PreloadAlertSettings.MasterTora);
            AddChild(masters, "Haku", settingsHub.PreloadAlertSettings.MasterHaku);
            AddChild(masters, "Vorici", settingsHub.PreloadAlertSettings.MasterVorici);
            AddChild(masters, "Elreon", settingsHub.PreloadAlertSettings.MasterElreon);
            AddChild(masters, "Vagan", settingsHub.PreloadAlertSettings.MasterVagan);
            AddChild(masters, "Catarina", settingsHub.PreloadAlertSettings.MasterCatarina);
            AddChild(masters, "Krillson", settingsHub.PreloadAlertSettings.MasterKrillson);
            MenuItem exiles = AddChild(preloadMenu, "Exiles", settingsHub.PreloadAlertSettings.Exiles);
            AddChild(exiles, "Orra Greengate", settingsHub.PreloadAlertSettings.OrraGreengate);
            AddChild(exiles, "Thena Moga", settingsHub.PreloadAlertSettings.ThenaMoga);
            AddChild(exiles, "Antalie Napora", settingsHub.PreloadAlertSettings.AntalieNapora);
            AddChild(exiles, "Torr Olgosso", settingsHub.PreloadAlertSettings.TorrOlgosso);
            AddChild(exiles, "Armios Bell", settingsHub.PreloadAlertSettings.ArmiosBell);
            AddChild(exiles, "Zacharie Desmarais", settingsHub.PreloadAlertSettings.ZacharieDesmarais);
            AddChild(exiles, "Minara Anenima", settingsHub.PreloadAlertSettings.MinaraAnenima);
            AddChild(exiles, "Igna Phoenix", settingsHub.PreloadAlertSettings.IgnaPhoenix);
            AddChild(exiles, "Jonah Unchained", settingsHub.PreloadAlertSettings.JonahUnchained);
            AddChild(exiles, "Damoi Tui", settingsHub.PreloadAlertSettings.DamoiTui);
            AddChild(exiles, "Xandro Blooddrinker", settingsHub.PreloadAlertSettings.XandroBlooddrinker);
            AddChild(exiles, "Vickas Giantbone", settingsHub.PreloadAlertSettings.VickasGiantbone);
            AddChild(exiles, "Eoin Greyfur", settingsHub.PreloadAlertSettings.EoinGreyfur);
            AddChild(exiles, "Tinevin Highdove", settingsHub.PreloadAlertSettings.TinevinHighdove);
            AddChild(exiles, "Magnus Stonethorn", settingsHub.PreloadAlertSettings.MagnusStonethorn);
            AddChild(exiles, "Ion Darkshroud", settingsHub.PreloadAlertSettings.IonDarkshroud);
            AddChild(exiles, "Ash Lessard", settingsHub.PreloadAlertSettings.AshLessard);
            AddChild(exiles, "Wilorin Demontamer", settingsHub.PreloadAlertSettings.WilorinDemontamer);
            AddChild(exiles, "Augustina Solaria", settingsHub.PreloadAlertSettings.AugustinaSolaria);
            AddChild(exiles, "Dena Lorenni", settingsHub.PreloadAlertSettings.DenaLorenni);
            AddChild(exiles, "Vanth Agiel", settingsHub.PreloadAlertSettings.VanthAgiel);
            AddChild(exiles, "Lael Furia", settingsHub.PreloadAlertSettings.LaelFuria);
            AddChild(exiles, "OyraOna", settingsHub.PreloadAlertSettings.OyraOna);
            AddChild(exiles, "BoltBrownfur", settingsHub.PreloadAlertSettings.BoltBrownfur);
            AddChild(exiles, "AilentiaRac", settingsHub.PreloadAlertSettings.AilentiaRac);
            AddChild(exiles, "UlyssesMorvant", settingsHub.PreloadAlertSettings.UlyssesMorvant);
            AddChild(exiles, "AurelioVoidsinger", settingsHub.PreloadAlertSettings.AurelioVoidsinger);
            MenuItem strongboxes = AddChild(preloadMenu, "Strongboxes", settingsHub.PreloadAlertSettings.Strongboxes);
            AddChild(strongboxes, "Arcanist", settingsHub.PreloadAlertSettings.ArcanistStrongbox);
            AddChild(strongboxes, "Artisan", settingsHub.PreloadAlertSettings.ArtisanStrongbox);
            AddChild(strongboxes, "Cartographer", settingsHub.PreloadAlertSettings.CartographerStrongbox);
            AddChild(strongboxes, "Diviner", settingsHub.PreloadAlertSettings.DivinerStrongbox);
            AddChild(strongboxes, "Gemcutter", settingsHub.PreloadAlertSettings.GemcutterStrongbox);
            AddChild(strongboxes, "Jeweller", settingsHub.PreloadAlertSettings.JewellerStrongbox);
            AddChild(strongboxes, "Blacksmith", settingsHub.PreloadAlertSettings.BlacksmithStrongbox);
            AddChild(strongboxes, "Armourer", settingsHub.PreloadAlertSettings.ArmourerStrongbox);
            AddChild(strongboxes, "Ornate", settingsHub.PreloadAlertSettings.OrnateStrongbox);
            AddChild(strongboxes, "Large", settingsHub.PreloadAlertSettings.LargeStrongbox);
            AddChild(strongboxes, "Perandus", settingsHub.PreloadAlertSettings.PerandusStrongbox);
            AddChild(strongboxes, "Kaom", settingsHub.PreloadAlertSettings.KaomStrongbox);
            AddChild(strongboxes, "Malachai", settingsHub.PreloadAlertSettings.MalachaiStrongbox);
            AddChild(strongboxes, "Epic", settingsHub.PreloadAlertSettings.EpicStrongbox);
            AddChild(strongboxes, "Simple", settingsHub.PreloadAlertSettings.SimpleStrongbox);
            MenuItem essences = AddChild(preloadMenu, "Essences", settingsHub.PreloadAlertSettings.Essence);
            AddChild(essences, "Remnant of Corruption", settingsHub.PreloadAlertSettings.RemnantOfCorruption);
            AddChild(essences, "Essence of Anger", settingsHub.PreloadAlertSettings.EssenceOfAnger);
            AddChild(essences, "Essence of Anguish", settingsHub.PreloadAlertSettings.EssenceOfAnguish);
            AddChild(essences, "Essence of Contempt", settingsHub.PreloadAlertSettings.EssenceOfContempt);
            AddChild(essences, "Essence of Delirium", settingsHub.PreloadAlertSettings.EssenceOfDelirium);
            AddChild(essences, "Essence of Doubt", settingsHub.PreloadAlertSettings.EssenceOfDoubt);
            AddChild(essences, "Essence of Dread", settingsHub.PreloadAlertSettings.EssenceOfDread);
            AddChild(essences, "Essence of Envy", settingsHub.PreloadAlertSettings.EssenceOfEnvy);
            AddChild(essences, "Essence of Fear", settingsHub.PreloadAlertSettings.EssenceOfFear);
            AddChild(essences, "Essence of Greed", settingsHub.PreloadAlertSettings.EssenceOfGreed);
            AddChild(essences, "Essence of Hatred", settingsHub.PreloadAlertSettings.EssenceOfHatred);
            AddChild(essences, "Essence of Horror", settingsHub.PreloadAlertSettings.EssenceOfHorror);
            AddChild(essences, "Essence of Hysteria", settingsHub.PreloadAlertSettings.EssenceOfHysteria);
            AddChild(essences, "Essence of Insanity", settingsHub.PreloadAlertSettings.EssenceOfInsanity);
            AddChild(essences, "Essence of Loathing", settingsHub.PreloadAlertSettings.EssenceOfLoathing);
            AddChild(essences, "Essence of Misery", settingsHub.PreloadAlertSettings.EssenceOfMisery);
            AddChild(essences, "Essence of Rage", settingsHub.PreloadAlertSettings.EssenceOfRage);
            AddChild(essences, "Essence of Scorn", settingsHub.PreloadAlertSettings.EssenceOfScorn);
            AddChild(essences, "Essence of Sorrow", settingsHub.PreloadAlertSettings.EssenceOfSorrow);
            AddChild(essences, "Essence of Spite", settingsHub.PreloadAlertSettings.EssenceOfSpite);
            AddChild(essences, "Essence of Suffering", settingsHub.PreloadAlertSettings.EssenceOfSuffering);
            AddChild(essences, "Essence of Torment", settingsHub.PreloadAlertSettings.EssenceOfTorment);
            AddChild(essences, "Essence of Woe", settingsHub.PreloadAlertSettings.EssenceOfWoe);
            AddChild(essences, "Essence of Wrath", settingsHub.PreloadAlertSettings.EssenceOfWrath);
            AddChild(essences, "Essence of Zeal", settingsHub.PreloadAlertSettings.EssenceOfZeal);
            MenuItem perandus = AddChild(preloadMenu, "Perandus Chests", settingsHub.PreloadAlertSettings.PerandusBoxes);
            AddChild(perandus, "Cadiro Trader", settingsHub.PreloadAlertSettings.CadiroTrader);
            AddChild(perandus, "Perandus Chest", settingsHub.PreloadAlertSettings.PerandusChestStandard);
            AddChild(perandus, "Perandus Cache", settingsHub.PreloadAlertSettings.PerandusChestRarity);
            AddChild(perandus, "Perandus Hoard", settingsHub.PreloadAlertSettings.PerandusChestQuantity);
            AddChild(perandus, "Perandus Coffer", settingsHub.PreloadAlertSettings.PerandusChestCoins);
            AddChild(perandus, "Perandus Jewellery", settingsHub.PreloadAlertSettings.PerandusChestJewellery);
            AddChild(perandus, "Perandus Safe", settingsHub.PreloadAlertSettings.PerandusChestGems);
            AddChild(perandus, "Perandus Treasury", settingsHub.PreloadAlertSettings.PerandusChestCurrency);
            AddChild(perandus, "Perandus Wardrobe", settingsHub.PreloadAlertSettings.PerandusChestInventory);
            AddChild(perandus, "Perandus Catalogue", settingsHub.PreloadAlertSettings.PerandusChestDivinationCards);
            AddChild(perandus, "Perandus Trove", settingsHub.PreloadAlertSettings.PerandusChestKeepersOfTheTrove);
            AddChild(perandus, "Perandus Locker", settingsHub.PreloadAlertSettings.PerandusChestUniqueItem);
            AddChild(perandus, "Perandus Archive", settingsHub.PreloadAlertSettings.PerandusChestMaps);
            AddChild(perandus, "Perandus Tackle Box", settingsHub.PreloadAlertSettings.PerandusChestFishing);
            AddChild(perandus, "Cadiro's Locker", settingsHub.PreloadAlertSettings.PerandusManorUniqueChest);
            AddChild(perandus, "Cadiro's Treasury", settingsHub.PreloadAlertSettings.PerandusManorCurrencyChest);
            AddChild(perandus, "Cadiro's Archive", settingsHub.PreloadAlertSettings.PerandusManorMapsChest);
            AddChild(perandus, "Cadiro's Jewellery", settingsHub.PreloadAlertSettings.PerandusManorJewelryChest);
            AddChild(perandus, "Cadiro's Catalogue", settingsHub.PreloadAlertSettings.PerandusManorDivinationCardsChest);
            AddChild(perandus, "Grand Perandus Vault", settingsHub.PreloadAlertSettings.PerandusManorLostTreasureChest);
            MenuItem corruptedMenu = AddChild(preloadMenu, "Corrupted Area", settingsHub.PreloadAlertSettings.CorruptedArea);
            AddChild(corruptedMenu, "Corrupted title", settingsHub.PreloadAlertSettings.CorruptedTitle, "F5");
            AddChild(corruptedMenu, "Corrupted color", settingsHub.PreloadAlertSettings.CorruptedAreaColor);
            AddChild(preloadMenu, "Background color", settingsHub.PreloadAlertSettings.BackgroundColor);
            AddChild(preloadMenu, "Font color", settingsHub.PreloadAlertSettings.DefaultTextColor);
            AddChild(preloadMenu, "Font size", settingsHub.PreloadAlertSettings.TextSize);

            // Monster alert
            MenuItem MonsterTrackerMenu = AddChild(CoreMenu, "Monster alert", settingsHub.MonsterTrackerSettings.Enable);
            MenuItem alertSound = AddChild(MonsterTrackerMenu, "Sound warning", settingsHub.MonsterTrackerSettings.PlaySound);
            AddChild(alertSound, "Sound volume", settingsHub.MonsterTrackerSettings.SoundVolume);
            MenuItem warningTextMenu = AddChild(MonsterTrackerMenu, "Text warning", settingsHub.MonsterTrackerSettings.ShowText);
            AddChild(warningTextMenu, "Text size", settingsHub.MonsterTrackerSettings.TextSize);
            AddChild(warningTextMenu, "Default text color:", settingsHub.MonsterTrackerSettings.DefaultTextColor);
            AddChild(warningTextMenu, "Background color:", settingsHub.MonsterTrackerSettings.BackgroundColor);
            AddChild(warningTextMenu, "Position X", settingsHub.MonsterTrackerSettings.TextPositionX);
            AddChild(warningTextMenu, "Position Y", settingsHub.MonsterTrackerSettings.TextPositionY);

            // Monster Kills
            MenuItem showMonsterKillsMenu = AddChild(CoreMenu, "Monster kills", settingsHub.KillCounterSettings.Enable);
            AddChild(showMonsterKillsMenu, "Show details", settingsHub.KillCounterSettings.ShowDetail);
            AddChild(showMonsterKillsMenu, "Show in town", settingsHub.KillCounterSettings.ShowInTown);
            AddChild(showMonsterKillsMenu, "Font color", settingsHub.KillCounterSettings.TextColor);
            AddChild(showMonsterKillsMenu, "Background color", settingsHub.KillCounterSettings.BackgroundColor);
            AddChild(showMonsterKillsMenu, "Label font size", settingsHub.KillCounterSettings.LabelTextSize);
            AddChild(showMonsterKillsMenu, "Kills font size", settingsHub.KillCounterSettings.KillsTextSize);

            // Dps options
            MenuItem showDpsMenu = AddChild(CoreMenu, "Show dps", settingsHub.DpsMeterSettings.Enable);
            AddChild(showDpsMenu, "Show in town", settingsHub.DpsMeterSettings.ShowInTown);
            AddChild(showDpsMenu, "Dps font size", settingsHub.DpsMeterSettings.DpsTextSize);
            AddChild(showDpsMenu, "Top dps font size", settingsHub.DpsMeterSettings.PeakDpsTextSize);
            AddChild(showDpsMenu, "Background color", settingsHub.DpsMeterSettings.BackgroundColor);
            AddChild(showDpsMenu, "Dps font color", settingsHub.DpsMeterSettings.DpsFontColor);
            AddChild(showDpsMenu, "Top dps font color", settingsHub.DpsMeterSettings.PeakFontColor);
            AddChild(showDpsMenu, "Show AOE", settingsHub.DpsMeterSettings.CalcAOE);
            AddChild(showDpsMenu, "Clear", settingsHub.DpsMeterSettings.ClearNode);

            // Map icons
            MenuItem mapIconsMenu = AddChild(CoreMenu, "Map Icons", settingsHub.MapIconsSettings.Enable);
            MenuItem iconSizeMenu = AddChild(mapIconsMenu, "Icon Sizes", settingsHub.MonsterTrackerSettings.ShowText);
            AddChild(iconSizeMenu, "White Mob Icons", settingsHub.MonsterTrackerSettings.WhiteMobIcon);
            AddChild(iconSizeMenu, "Magic Mob Icons", settingsHub.MonsterTrackerSettings.MagicMobIcon);
            AddChild(iconSizeMenu, "Rare Mob Icons", settingsHub.MonsterTrackerSettings.RareMobIcon);
            AddChild(iconSizeMenu, "Unique Mob Icons", settingsHub.MonsterTrackerSettings.UniqueMobIcon);
            AddChild(iconSizeMenu, "Minion Icons", settingsHub.MonsterTrackerSettings.MinionsIcon);
            AddChild(iconSizeMenu, "Master Icons", settingsHub.PoiTrackerSettings.MastersIcon);
            AddChild(iconSizeMenu, "Chest Icons", settingsHub.PoiTrackerSettings.ChestsIcon);
            AddChild(iconSizeMenu, "Strongbox Icons", settingsHub.PoiTrackerSettings.StrongboxesIcon);
            AddChild(iconSizeMenu, "Perandus Chest Icons", settingsHub.PoiTrackerSettings.PerandusChestIcon);
            AddChild(iconSizeMenu, "Breach Chest Icons", settingsHub.PoiTrackerSettings.BreachChestIcon);
            MenuItem itemLootIcon = AddChild(iconSizeMenu, "Item loot Icons", settingsHub.ItemAlertSettings.LootIcon);
            AddChild(iconSizeMenu, "Use border color for loot icon", settingsHub.ItemAlertSettings.LootIconBorderColor); // Adding a ToggleNode as a RangeNode child doesn't display it
            AddChild(mapIconsMenu, "Minimap Icons", settingsHub.MapIconsSettings.IconsOnMinimap);
            AddChild(mapIconsMenu, "Large map Icons", settingsHub.MapIconsSettings.IconsOnLargeMap);
            AddChild(mapIconsMenu, "Dropped Items", settingsHub.ItemAlertSettings.ShowItemOnMap);
            AddChild(mapIconsMenu, "Monsters", settingsHub.MonsterTrackerSettings.Monsters);
            AddChild(mapIconsMenu, "Minions", settingsHub.MonsterTrackerSettings.Minions);
            AddChild(mapIconsMenu, "Strongboxes", settingsHub.PoiTrackerSettings.Strongboxes);
            AddChild(mapIconsMenu, "Chests", settingsHub.PoiTrackerSettings.Chests);
            AddChild(mapIconsMenu, "Masters", settingsHub.PoiTrackerSettings.Masters);

            //Menu Settings
            MenuItem menuSettings = AddChild(CoreMenu, "Menu settings", settingsHub.MenuSettings.ShowMenu, "F12");
            AddChild(menuSettings, "Show ImGui Sample", settingsHub.MenuSettings.ShowImGuiSample);
            AddChild(menuSettings, "Menu font color", settingsHub.MenuSettings.MenuFontColor);
            AddChild(menuSettings, "Title font color", settingsHub.MenuSettings.TitleFontColor);
            AddChild(menuSettings, "Enabled color", settingsHub.MenuSettings.EnabledBoxColor);
            AddChild(menuSettings, "Disabled color", settingsHub.MenuSettings.DisabledBoxColor);
            AddChild(menuSettings, "Slider color", settingsHub.MenuSettings.SliderColor);
            AddChild(menuSettings, "Background color", settingsHub.MenuSettings.BackgroundColor);
            AddChild(menuSettings, "Menu font size", settingsHub.MenuSettings.MenuFontSize);
            AddChild(menuSettings, "Title font size", settingsHub.MenuSettings.TitleFontSize);
            AddChild(menuSettings, "Slider font size", settingsHub.MenuSettings.PickerFontSize);
            MenuItem performanceSettings = AddChild(CoreMenu, "Performance", settingsHub.PerformanceSettings.Enable);
            AddChild(performanceSettings, "FPS Render limit", settingsHub.PerformanceSettings.RenderLimit);
            AddChild(performanceSettings, "FPS Update entity limit", settingsHub.PerformanceSettings.UpdateEntityDataLimit);
            AddChild(performanceSettings, "Update areachange every N ms", settingsHub.PerformanceSettings.UpdateAreaLimit);
            AddChild(performanceSettings, "Use cache for most data", settingsHub.PerformanceSettings.Cache);
            AddChild(performanceSettings, "Update entity in parallel thread(Experimental/Unstable) [Need restart]", settingsHub.PerformanceSettings.ParallelEntityUpdate);
            AddChild(performanceSettings, "Update ingame state every N ms", settingsHub.PerformanceSettings.UpdateIngemeStateLimit);
            AddChild(performanceSettings, "Always Foreground", settingsHub.PerformanceSettings.AlwaysForeground);
            eInitMenu(MenuRootButton); //Spawning the menu in external plugins
        }*/
    }
}