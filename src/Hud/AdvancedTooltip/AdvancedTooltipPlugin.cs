using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.Settings;
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
        private List<ModValue> mods = new List<ModValue>();

        public AdvancedTooltipPlugin(GameController gameController, Graphics graphics, AdvancedTooltipSettings settings, SettingsHub settingsHub)
            : base(gameController, graphics, settings)
        {
            this.settingsHub = settingsHub;
        }

        public override void Render()
        {
            try
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
                Element uiHover = GameController.Game.IngameState.UIHover;
                var inventoryItemIcon = uiHover.AsObject<HoverItemIcon>();

                Element tooltip = inventoryItemIcon.Tooltip;
                Entity poeEntity = inventoryItemIcon.Item;

                if (tooltip == null || poeEntity.Address == 0 || !poeEntity.IsValid) { return; }
                RectangleF tooltipRect = tooltip.GetClientRect();

               

                var modsComponent = poeEntity.GetComponent<Mods>();
                long id = 0;
                if (inventoryItemIcon.ToolTipType == ToolTipType.InventoryItem)
                {
               
                    id = poeEntity.InventoryId;
                }
                else
                {
                    id = poeEntity.Id;
                }

                if (itemEntity == null || itemEntity.Id != id)
                {
                    List<ItemMod> itemMods = modsComponent.ItemMods;
                    mods = itemMods.Select(item => new ModValue(item, GameController.Files, modsComponent.ItemLevel,
                        GameController.Files.BaseItemTypes.Translate(poeEntity.Path))).ToList();
                    itemEntity = poeEntity;
                }

                int t1 = 0;
                foreach (string tier in from item in mods where item.CouldHaveTiers() && item.Tier == 1 select " \u2605 ")
                {
                    Graphics.DrawText(tier, 18, tooltipRect.TopLeft.Translate(0 + 14 * t1++, 56), Settings.ItemMods.T1Color);
                }

                int t2 = 0;
                foreach (string tier in from item in mods where item.CouldHaveTiers() && item.Tier == 2 select " \u2605 ")
                {
                    Graphics.DrawText(tier, 18, tooltipRect.TopLeft.Translate(t1 * 14 + 14 * t2++, 56), Settings.ItemMods.T2Color);
                }

                if (Settings.ItemLevel.Enable)
                {
                    string itemLevel = Convert.ToString(modsComponent.ItemLevel);
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

                if (Settings.WeaponDps.Enable && poeEntity.HasComponent<Weapon>())
                {
                    DrawWeaponDps(tooltipRect);
                }
            }
            catch
            { }
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

            if (item.AffixType != ModsDat.ModType.Unique)
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

        private void DrawWeaponDps(RectangleF clientRect)
        {
            var weapon = itemEntity.GetComponent<Weapon>();
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
            WeaponDpsSettings settings = Settings.WeaponDps;
            Color[] elementalDmgColors = { Color.White,
                settings.DmgFireColor,
                settings.DmgColdColor,
                settings.DmgLightningColor,
                settings.DmgChaosColor
            };
            physDmgMultiplier += itemEntity.GetComponent<Quality>().ItemQuality / 100f;
            PhysLo = (int)Math.Round(PhysLo * physDmgMultiplier);
            PhysHi = (int)Math.Round(PhysHi * physDmgMultiplier);
            doubleDpsPerStat[(int)DamageType.Physical] = PhysLo + PhysHi;

            aSpd = (float)Math.Round(aSpd, 2);
            float pDps = doubleDpsPerStat[(int)DamageType.Physical] / 2 * aSpd;
            float eDps = 0;
            int firstEmg = 0;
            Color DpsColor = settings.pDamageColor;

            for (int i = 1; i < cntDamages; i++)
            {
                eDps += doubleDpsPerStat[i] / 2 * aSpd;
                if (doubleDpsPerStat[i] > 0)
                {
                    if (firstEmg == 0)
                    {
                        firstEmg = i;
                        DpsColor = elementalDmgColors[i];
                    }
                    else
                    {
                        DpsColor = settings.eDamageColor;
                    }
                }
            }

            var textPosition = new Vector2(clientRect.Right - 2, clientRect.Y + 1);
            Size2 pDpsSize = pDps > 0
                ? Graphics.DrawText(pDps.ToString("#.#") + " pDps", settings.DpsTextSize, textPosition, FontDrawFlags.Right)
                : new Size2();
            Size2 eDpsSize = eDps > 0
                ? Graphics.DrawText(eDps.ToString("#.#") + " eDps", settings.DpsTextSize,
                    textPosition.Translate(0, pDpsSize.Height), DpsColor, FontDrawFlags.Right)
                : new Size2();

            var dps = pDps + eDps;
            Size2 dpsSize = dps > 0
              ? Graphics.DrawText(dps.ToString("#.#") + " Dps", settings.DpsTextSize,
                  textPosition.Translate(0, pDpsSize.Height + eDpsSize.Height), Color.White, FontDrawFlags.Right)
              : new Size2();
            Vector2 dpsTextPosition = textPosition.Translate(0, pDpsSize.Height + eDpsSize.Height + dpsSize.Height);
            Graphics.DrawText("dps", settings.DpsNameTextSize, dpsTextPosition, settings.TextColor, FontDrawFlags.Right);
            Graphics.DrawImage("preload-end.png", new RectangleF(textPosition.X - 86, textPosition.Y - 6, 90, 65), settings.BackgroundColor);
        }
    }
}
