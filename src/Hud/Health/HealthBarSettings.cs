using PoeHUD.Hud.Settings;

namespace PoeHUD.Hud.Health
{
    public sealed class HealthBarSettings : SettingsBase
    {
        public HealthBarSettings()
        {
            Enable = false;
            ShowInTown = false;
            ShowES = true;
            ShowIncrements = true;
            ShowEnemies = true;
            Players = new UnitSettings(0x008000ff, 0);
            Minions = new UnitSettings(0x90ee90ff, 0);
            NormalEnemy = new UnitSettings(0xff0000ff, 0, 0x66ff66ff, false);
            MagicEnemy = new UnitSettings(0xff0000ff, 0x8888ffff, 0x66ff99ff, false);
            RareEnemy = new UnitSettings(0xff0000ff, 0xffff77ff, 0x66ff99ff, false);
            UniqueEnemy = new UnitSettings(0xff0000ff, 0xffa500ff, 0x66ff99ff, false);
            ShowDebuffPanel = false;
            DebuffPanelIconSize = new RangeNode<int>(20, 15, 40);
        }

        public ToggleNode ShowInTown { get; set; }
        public ToggleNode ShowES { get; set; }
        public ToggleNode ShowIncrements { get; set; }
        public ToggleNode ShowEnemies { get; set; }

        [PoeHUD.Plugins.IgnoreMenu]
        public UnitSettings Players { get; set; }
        [PoeHUD.Plugins.IgnoreMenu]
        public UnitSettings Minions { get; set; }
        [PoeHUD.Plugins.IgnoreMenu]
        public UnitSettings NormalEnemy { get; set; }
        [PoeHUD.Plugins.IgnoreMenu]
        public UnitSettings MagicEnemy { get; set; }
        [PoeHUD.Plugins.IgnoreMenu]
        public UnitSettings RareEnemy { get; set; }
        [PoeHUD.Plugins.IgnoreMenu]
        public UnitSettings UniqueEnemy { get; set; }

        [PoeHUD.Plugins.Menu("Show Debuffs", 0)]
        public ToggleNode ShowDebuffPanel { get; set; }

        [PoeHUD.Plugins.Menu("Icon size", 1, 0)]
        public RangeNode<int> DebuffPanelIconSize { get; set; }
    }
}
