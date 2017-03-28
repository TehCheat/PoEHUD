using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.Settings;
using PoeHUD.Models;
using PoeHUD.Models.Enums;
using PoeHUD.Poe;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.Elements;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Poe.RemoteMemoryObjects;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Color = SharpDX.Color;
using Graphics = PoeHUD.Hud.UI.Graphics;
using RectangleF = SharpDX.RectangleF;

namespace PoeHUD.Hud.AdvancedTooltip
{
    public class AdvancedTooltipPlugin : Plugin<AdvancedTooltipSettings>
    {
        private Color TColor;
        private bool holdKey;
        private readonly SettingsHub settingsHub;
        private Entity itemEntity;
		private int iLvl;
		private string uniqueName;
        private List<ModValue> mods = new List<ModValue>();
		private ItemRarity rarity;

		Dictionary<string, string> uniquePrices = LoadUniquePrices();

		public AdvancedTooltipPlugin(GameController gameController, Graphics graphics, AdvancedTooltipSettings settings, SettingsHub settingsHub)
            : base(gameController, graphics, settings)
        {
            this.settingsHub = settingsHub;
        }

        public override void Render()
        {
			try
			{
				UpdateToggleState();

				Element uiHover = GameController.Game.IngameState.UIHover;
				var inventoryItemIcon = uiHover.AsObject<InventoryItemIcon>();
				if (inventoryItemIcon == null || inventoryItemIcon.Address == 0)
					return;

				Entity poeEntity = inventoryItemIcon.Item;
				if (poeEntity.Address == 0 || !poeEntity.IsValid)
					return;
				var modsComponent = poeEntity.GetComponent<Mods>();
				var id = inventoryItemIcon.ToolTipType == ToolTipType.InventoryItem ? poeEntity.InventoryId : poeEntity.Id;

				if (itemEntity == null || itemEntity.Id != id)
				{
					iLvl = modsComponent.ItemLevel;
					uniqueName = modsComponent.UniqueName;
					rarity = modsComponent.ItemRarity;
					//if (string.IsNullOrWhiteSpace(name)) {
					//	BaseItemType bit = GameController.Files.BaseItemTypes.Translate(poeEntity.Path);
					//	if (bit != null)
					//		name = bit.BaseName;
					//}
					mods = modsComponent.ItemMods.Select(item => new ModValue(item, GameController.Files, iLvl)).ToList();
					itemEntity = poeEntity;
				}

				Element tooltip = inventoryItemIcon.Tooltip;
				if (tooltip != null)
					DrawItemProperties(tooltip.GetClientRect());
			}
			catch { }
        }

		private void UpdateToggleState()
		{
			if (!holdKey && WinApi.IsKeyDown(Keys.F9))
			{
				holdKey = true;
				Settings.ItemMods.Enable.Value = !Settings.ItemMods.Enable.Value;
				if (!Settings.ItemMods.Enable.Value)
				{
					SettingsHub.Save(settingsHub);
				}
			}
			else if (holdKey && !WinApi.IsKeyDown(Keys.F9))
			{
				holdKey = false;
			}
		}

		private void DrawItemProperties(RectangleF tooltipRect)
		{

			foreach (string tier in from item in mods where item.CouldHaveTiers() && item.Tier == 1 select " \u2605 ")
			{
				Graphics.DrawText(tier, 18, tooltipRect.TopLeft.Translate(0, 56), Settings.ItemMods.T1Color);
			}
			if (Settings.ItemLevel.Enable)
			{
				string itemLevel = Convert.ToString(iLvl);
				var imageSize = Settings.ItemLevel.TextSize + 10;
				Graphics.DrawText(itemLevel, Settings.ItemLevel.TextSize, tooltipRect.TopLeft.Translate(2, 2), Settings.ItemLevel.TextColor);
				Graphics.DrawImage("menu-colors.png", new RectangleF(tooltipRect.TopLeft.X - 2, tooltipRect.TopLeft.Y - 2, imageSize, imageSize), Settings.ItemLevel.BackgroundColor);
			}

			if (Settings.ItemMods.Enable)
			{
				float bottomTooltip = tooltipRect.Bottom + 5;
				var modPosition = new Vector2(tooltipRect.X + 50, bottomTooltip + 4);
				float height = mods.Aggregate(modPosition, (position, item) => DrawMod(item, position)).Y - bottomTooltip;
				if (height > 4)
				{
					var modsRect = new RectangleF(tooltipRect.X + 1, bottomTooltip, tooltipRect.Width, height);
					Graphics.DrawBox(modsRect, Settings.ItemMods.BackgroundColor);
				}
			}

			if (Settings.EstimatedPrice.Value && rarity == ItemRarity.Unique)
			{
				string price;
				if (!uniquePrices.TryGetValue(uniqueName, out price))
					price = "No price for: " + uniqueName;
				else
					price = "Est. price: " + price;
				var rc = tooltipRect.BottomRight.Translate(-2, -Settings.ItemLevel.TextSize - 2);
				Graphics.DrawText(price, Settings.ItemLevel.TextSize, rc, Settings.ItemLevel.TextColor, FontDrawFlags.Right);
			}

			if (Settings.WeaponDps.Enable && itemEntity.HasComponent<Weapon>())
			{
				int quality = itemEntity.GetComponent<Quality>().ItemQuality;
				DrawDps(tooltipRect, CalcWeaponDps(itemEntity.GetComponent<Weapon>(), mods, quality));
			}
		}

        private Vector2 DrawMod(ModValue item, Vector2 position)
        {
            const float EPSILON = 0.001f;
            const int MARGIN_BOTTOM = 4, MARGIN_LEFT = 50;

            Vector2 oldPosition = position;
            ItemModsSettings settings = Settings.ItemMods;

            string affix = item.AffixType == ModsDat.ModType.Prefix ? "[P]"
                : item.AffixType == ModsDat.ModType.Suffix ? "[S]" : "[?]";

            Dictionary<int, Color> TColors = new Dictionary<int, Color>
                {
                    { 1, settings.T1Color },
                    { 2, settings.T2Color },
                    { 3, settings.T3Color }
                };

            if (item.AffixType != ModsDat.ModType.Hidden)
            {
                if (item.CouldHaveTiers()) { affix += $" T{item.Tier} "; }

                if (item.AffixType == ModsDat.ModType.Prefix)
                {
                    Graphics.DrawText(affix, settings.ModTextSize, position.Translate(5 - MARGIN_LEFT, 0), settings.PrefixColor);
                    if (!TColors.TryGetValue(item.Tier, out TColor)) { TColor = settings.PrefixColor; }
                }

                if (item.AffixType == ModsDat.ModType.Suffix)
                {
                    Graphics.DrawText(affix, settings.ModTextSize, position.Translate(5 - MARGIN_LEFT, 0), settings.SuffixColor);
                    if (!TColors.TryGetValue(item.Tier, out TColor)) { TColor = settings.SuffixColor; }
                }
                Size2 textSize = Graphics.DrawText(item.AffixText, settings.ModTextSize, position, TColor);
                if (textSize != new Size2()) { position.Y += textSize.Height; }
            }

            for (int i = 0; i < 4; i++)
            {
                IntRange range = item.Record.StatRange[i];
                if (range.Min == 0 && range.Max == 0) { continue; }
                StatsDat.StatRecord stat = item.Record.StatNames[i];
                int value = item.StatValue[i];
                if (value <= -1000 || stat == null) { continue; }
                bool noSpread = !range.HasSpread();
                string line2 = string.Format(noSpread ? "{0}" : "{0} [{1}]", stat, range);
                Graphics.DrawText(line2, settings.ModTextSize, position, Color.Gainsboro);
                string statText = stat.ValueToString(value);
                Vector2 statPosition = position.Translate(-5, 0);
                Size2 txSize = Graphics.DrawText(statText, settings.ModTextSize, statPosition, Color.Gainsboro, FontDrawFlags.Right);
                position.Y += txSize.Height;
            }
            return Math.Abs(position.Y - oldPosition.Y) > EPSILON ? position.Translate(0, MARGIN_BOTTOM) : oldPosition;
        }

		public struct WeaponDps
		{
			public int iStrongestElement;
			public float Physical;
			public float Elemental;
		}

		private WeaponDps CalcWeaponDps(Weapon weapon, IEnumerable<ModValue> mods, int quality = 0)
		{
			float aSpd = (float)Math.Round(1000f / weapon.AttackTime, 2);
			int cntDamages = Enum.GetValues(typeof(DamageType)).Length;
			var doubleDpsPerStat = new float[cntDamages];
			float physDmgMultiplier = 1;
			int PhysHi = weapon.DamageMax;
			int PhysLo = weapon.DamageMin;
			foreach (ModValue mod in mods)
			{
				for (int iStat = 0; iStat < 4; iStat++)
				{
					IntRange range = mod.Record.StatRange[iStat];
					if (range.Min == 0 && range.Max == 0)
					{
						continue;
					}

					StatsDat.StatRecord theStat = mod.Record.StatNames[iStat];
					int value = mod.StatValue[iStat];
					switch (theStat.Key)
					{
						case "physical_damage_+%":
						case "local_physical_damage_+%":
							physDmgMultiplier += value / 100f;
							break;

						case "local_attack_speed_+%":
							aSpd *= (100f + value) / 100;
							break;

						case "local_minimum_added_physical_damage":
							PhysLo += value;
							break;
						case "local_maximum_added_physical_damage":
							PhysHi += value;
							break;

						case "local_minimum_added_fire_damage":
						case "local_maximum_added_fire_damage":
						case "unique_local_minimum_added_fire_damage_when_in_main_hand":
						case "unique_local_maximum_added_fire_damage_when_in_main_hand":
							doubleDpsPerStat[(int)DamageType.Fire] += value;
							break;

						case "local_minimum_added_cold_damage":
						case "local_maximum_added_cold_damage":
						case "unique_local_minimum_added_cold_damage_when_in_off_hand":
						case "unique_local_maximum_added_cold_damage_when_in_off_hand":
							doubleDpsPerStat[(int)DamageType.Cold] += value;
							break;

						case "local_minimum_added_lightning_damage":
						case "local_maximum_added_lightning_damage":
							doubleDpsPerStat[(int)DamageType.Lightning] += value;
							break;

						case "unique_local_minimum_added_chaos_damage_when_in_off_hand":
						case "unique_local_maximum_added_chaos_damage_when_in_off_hand":
						case "local_minimum_added_chaos_damage":
						case "local_maximum_added_chaos_damage":
							doubleDpsPerStat[(int)DamageType.Chaos] += value;
							break;
					}
				}
			}

			physDmgMultiplier += quality / 100f;
			PhysLo = (int)Math.Round(PhysLo * physDmgMultiplier);
			PhysHi = (int)Math.Round(PhysHi * physDmgMultiplier);
			doubleDpsPerStat[(int)DamageType.Physical] = PhysLo + PhysHi;

			WeaponDps result = new WeaponDps();

			aSpd = (float)Math.Round(aSpd, 2);
			result.Physical = doubleDpsPerStat[(int)DamageType.Physical] / 2 * aSpd;
			result.Elemental = 0;
			result.iStrongestElement = 0;

			float maxElement = 0;
			for (int i = 1; i < doubleDpsPerStat.Length; i++)
			{
				float damage = doubleDpsPerStat[i] / 2 * aSpd;
				if (damage > 0)
				{
					result.Elemental += damage ;
					if (damage > maxElement)
					{
						maxElement = damage;
						result.iStrongestElement = i;
					}
				}
			}
			return result;
		}

		public void DrawDps(RectangleF clientRect, WeaponDps dps)
		{
			WeaponDpsSettings settings = Settings.WeaponDps;
			Color[] elementalDmgColors = { Color.White,
				settings.DmgFireColor,
				settings.DmgColdColor,
				settings.DmgLightningColor,
				settings.DmgChaosColor
			};
			Color DpsColor = dps.iStrongestElement > 0 ? elementalDmgColors[dps.iStrongestElement] : settings.pDamageColor.Value;


			var textPosition = new Vector2(clientRect.Right - 2, clientRect.Y + 1);
            Size2 pDpsSize = dps.Physical > 0
                ? Graphics.DrawText(dps.Physical.ToString("#.#"), settings.DpsTextSize, textPosition, FontDrawFlags.Right)
                : new Size2();
            Size2 eDpsSize = dps.Elemental > 0
                ? Graphics.DrawText(dps.Elemental.ToString("#.#"), settings.DpsTextSize, textPosition.Translate(0, pDpsSize.Height), DpsColor, FontDrawFlags.Right)
                : new Size2();
            Vector2 dpsTextPosition = textPosition.Translate(0, pDpsSize.Height + eDpsSize.Height);
            Graphics.DrawText("dps", settings.DpsNameTextSize, dpsTextPosition, settings.TextColor, FontDrawFlags.Right);
            Graphics.DrawImage("preload-end.png", new RectangleF(textPosition.X - 86, textPosition.Y - 6, 90, 65), settings.BackgroundColor);
        }

		private static Dictionary<string, string> LoadUniquePrices()
		{
			var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			if (!File.Exists("config/unique_prices.txt"))
				return result; // dict will be empty
			
			string[] lines = File.ReadAllLines("config/unique_prices.txt");

			/* Sample line:
			 * Rigwald's Command, Midnight Bladewiki	One Handed Sword	68	
			 * +105.6%
			 * 7.2 x Exalted Orb611.3 x Chaos Orb	@
			 */

			string name;
			string[] priceSeparator = new[] { " Orb" };
			string[] currSeparator = new[] { " x " };

			for (int iLine = 0; iLine < lines.Length - 2; iLine++)
			{
				string line = lines[iLine];
				if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
					continue;

				int ixComma = line.IndexOf(',');
				if (ixComma < 0) continue; // some wrong data
				name = line.Substring(0, ixComma);

				iLine += 2;
				string priceResult = "";
				string priceTag = lines[iLine];
				string[] options = priceTag.Split(priceSeparator, StringSplitOptions.RemoveEmptyEntries);
				foreach(var opt in options)
				{
					string[] pp = opt.Split(currSeparator, StringSplitOptions.RemoveEmptyEntries);
					if (pp.Length != 2)
						continue;

					if (String.IsNullOrEmpty(priceResult))
						priceResult = pp[0] + " " + pp[1];
					else
						priceResult += " (or " + pp[0] + " " + pp[1] + ")";
				}

				if (!result.ContainsKey(name)) // some items have many variants - there's a separate line for each, this is not handled. ex: Vessel of Vinktar
					result.Add(name, priceResult);
			}
			return result;
		}
	}
} 