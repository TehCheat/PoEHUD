using Newtonsoft.Json;

using PoeHUD.Hud.Settings;

namespace PoeHUD.Hud.AdvancedTooltip
{
    public class AdvancedTooltipSettings : SettingsBase
    {
        public AdvancedTooltipSettings()
        {
            Enable = true;
            ItemLevel = new ItemLevelSettings();
            ItemMods = new ItemModsSettings();
            WeaponDps = new WeaponDpsSettings();
			EstimatedPrice = new ToggleNode(true);
        }

        [JsonProperty("Item level")]
        public ItemLevelSettings ItemLevel { get; set; }

        [JsonProperty("Item mods")]
        public ItemModsSettings ItemMods { get; set; }

        [JsonProperty("Weapon DPS")]
        public WeaponDpsSettings WeaponDps { get; set; }

		[JsonProperty("Estimated Price")]
		public ToggleNode EstimatedPrice { get; set; }
	}
}