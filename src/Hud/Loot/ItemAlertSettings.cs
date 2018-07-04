using Newtonsoft.Json;
using PoeHUD.Hud.Settings;

namespace PoeHUD.Hud.Loot
{
    public sealed class ItemAlertSettings : SettingsBase
    {
        public ItemAlertSettings()
        {
            Enable = true;
            ShowItemOnMap = true;
            Crafting = false;
            ShowText = true;
            HideOthers = true;
            PlaySound = true;
            SoundVolume = new RangeNode<int>(40, 0, 100);
            TextSize = new RangeNode<int>(16, 10, 50);
            Rares = true;
            Uniques = true;
            Maps = true;
            Currency = true;
            DivinationCards = true;
            Jewels = true;
            Talisman = true;
            Rgb = true;
            MinLinks = new RangeNode<int>(5, 0, 6);
            MinSockets = new RangeNode<int>(6, 0, 6);
            LootIcon = new RangeNode<int>(7, 1, 14);
            DimOtherByPercent = new RangeNode<int>(100, 1, 100);
            DimOtherByPercentToggle = true;
            LootIconBorderColor = false;
            QualityItems = new QualityItemsSettings();
            BorderSettings = new BorderSettings();
            WithBorder = true;
            WithSound = false;
            ShouldUseFilterFile = true;
            FilePath = "config/NeverSink-SEMI-STRICT.filter";
        }

        public ToggleNode ShowItemOnMap { get; set; }
        public ToggleNode Crafting { get; set; }
        public ToggleNode ShowText { get; set; }
        public RangeNode<int> DimOtherByPercent { get; set; }
        public ToggleNode DimOtherByPercentToggle { get; set; }
        public ToggleNode HideOthers { get; set; }
        public ToggleNode PlaySound { get; set; }
        public RangeNode<int> SoundVolume { get; set; }
        public RangeNode<int> TextSize { get; set; }
        public ToggleNode Rares { get; set; }
        public ToggleNode Uniques { get; set; }
        public ToggleNode Maps { get; set; }
        public ToggleNode Currency { get; set; }
        public ToggleNode DivinationCards { get; set; }
        public ToggleNode Jewels { get; set; }
        public ToggleNode Talisman { get; set; }

        [JsonProperty("RGB")]
        public ToggleNode Rgb { get; set; }

        public RangeNode<int> MinLinks { get; set; }
        public RangeNode<int> MinSockets { get; set; }
        public RangeNode<int> LootIcon { get; set; }
        public ToggleNode LootIconBorderColor { get; set; }

        [PoeHUD.Plugins.IgnoreMenu]
        [JsonProperty("Show quality items")]
        public QualityItemsSettings QualityItems { get; set; }
        [PoeHUD.Plugins.IgnoreMenu]
        public BorderSettings BorderSettings { get; set; }
        public ToggleNode WithBorder { get; set; }
        public ToggleNode WithSound { get; set; }
        public ToggleNode ShouldUseFilterFile { get; set; }
        public FileNode FilePath { get; set; }
    }
}