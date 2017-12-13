using Newtonsoft.Json;
using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Models;
using PoeHUD.Poe.Components;
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

namespace PoeHUD.Hud.Health
{
    public class HealthBarPlugin : Plugin<HealthBarSettings>
    {
        private readonly Dictionary<CreatureType, List<HealthBar>> healthBars;
        private readonly DebuffPanelConfig debuffPanelConfig;

        public HealthBarPlugin(GameController gameController, Graphics graphics, HealthBarSettings settings)
            : base(gameController, graphics, settings)
        {
            CreatureType[] types = Enum.GetValues(typeof(CreatureType)).Cast<CreatureType>().ToArray();
            healthBars = new Dictionary<CreatureType, List<HealthBar>>(types.Length);
            foreach (CreatureType type in types)
            {
                healthBars.Add(type, new List<HealthBar>());
            }

            string json = File.ReadAllText("config/debuffPanel.json");
            debuffPanelConfig = JsonConvert.DeserializeObject<DebuffPanelConfig>(json);
            (new Coroutine(() => {foreach (var healthBar in healthBars)
                {
                    healthBar.Value.RemoveAll(hp => !hp.Entity.IsValid);
                } }, new WaitRender(10), nameof(HealthBarPlugin), "RemoveAll"))
                .AutoRestart(GameController.CoroutineRunner).Run();
        }

        public override void Render()
        {
            try
            {
                if (!Settings.Enable || WinApi.IsKeyDown(Keys.F10) || !GameController.InGame ||
                !Settings.ShowInTown && GameController.Area.CurrentArea.IsTown ||
                !Settings.ShowInTown && GameController.Area.CurrentArea.IsHideout)
                { return; }

                RectangleF windowRectangle = GameController.Window.GetWindowRectangle();
                var windowSize = new Size2F(windowRectangle.Width / 2560, windowRectangle.Height / 1600);

                Camera camera = GameController.Game.IngameState.Camera;
                Func<HealthBar, bool> showHealthBar = x => x.IsShow(Settings.ShowEnemies);
                //Not Parallel better for performance
                //Parallel.ForEach(healthBars, x => x.Value.RemoveAll(hp => !hp.Entity.IsValid));
                
                foreach (HealthBar healthBar in healthBars.SelectMany(x => x.Value).Where(hp => showHealthBar(hp) && hp.Entity.IsAlive))
                {
                    Vector3 worldCoords = healthBar.Entity.Pos;
                    Vector2 mobScreenCoords = camera.WorldToScreen(worldCoords.Translate(0, 0, -170), healthBar.Entity);
                    if (mobScreenCoords != new Vector2())
                    {
                        float scaledWidth = healthBar.Settings.Width * windowSize.Width;
                        float scaledHeight = healthBar.Settings.Height * windowSize.Height;
                        Color color = healthBar.Settings.Color;
                        float hpPercent = healthBar.Life.HPPercentage;
                        float esPercent = healthBar.Life.ESPercentage;
                        float hpWidth = hpPercent * scaledWidth;
                        float esWidth = esPercent * scaledWidth;
                        var bg = new RectangleF(mobScreenCoords.X - scaledWidth / 2, mobScreenCoords.Y - scaledHeight / 2, scaledWidth, scaledHeight);
                        var windowRect = GameController.Window.GetWindowRectangle();
                        var fixNotFullscreen = new RectangleF(windowRect.X + bg.X, windowRect.Y + bg.Y, bg.Width, bg.Height);
                        if (!windowRect.Intersects(fixNotFullscreen))
                            continue;
                        if (hpPercent <= 0.1f)
                        {
                            color = healthBar.Settings.Under10Percent;
                        }
                        bg.Y = DrawFlatLifeAmount(healthBar.Life, hpPercent, healthBar.Settings, bg);
                        var yPosition = DrawFlatESAmount(healthBar, bg);
                        yPosition = DrawDebuffPanel(new Vector2(bg.Left, yPosition), healthBar, healthBar.Life);
                        ShowDps(healthBar, new Vector2(bg.Center.X, yPosition));
                        DrawPercents(healthBar.Settings, hpPercent, bg);
                        DrawBackground(color, healthBar.Settings.Outline, bg, hpWidth, esWidth);
                    }
                }
            }
            catch
            {
                // do nothing
            }
        }

        private void ShowDps(HealthBar healthBar, Vector2 point)
        {
            if (!healthBar.Settings.ShowFloatingCombatDamage)
            {
                return;
            }
            const int MARGIN_TOP = 2;
            const int LAST_DAMAGE_ADD_SIZE = 7;
            var fontSize = healthBar.Settings.FloatingCombatTextSize + LAST_DAMAGE_ADD_SIZE;
            var textHeight = Graphics.MeasureText("100500", fontSize).Height;

            healthBar.DpsRefresh();

            point = point.Translate(0, -textHeight - MARGIN_TOP);
            int i = 0;
            foreach (var dps in healthBar.DpsQueue)
            {
                i++;
                var damageColor = healthBar.Settings.FloatingCombatDamageColor;
                var sign = string.Empty;
                if (dps > 0)
                {
                    damageColor = healthBar.Settings.FloatingCombatHealColor;
                    sign = "+";
                }

                string dpsText = $"{sign}{dps}";
                Graphics.DrawText(dpsText, fontSize, point, Color.Black, FontDrawFlags.Center);
                point = point.Translate(0, -Graphics.DrawText(dpsText, fontSize,
                    point.Translate(1, 0), damageColor, FontDrawFlags.Center).Height - MARGIN_TOP);
                if (i == 1)
                {
                    fontSize -= LAST_DAMAGE_ADD_SIZE;
                }
            }
            healthBar.DpsDequeue();
        }

        private float DrawDebuffPanel(Vector2 startPoint, HealthBar healthBar, Life life)
        {
            var startY = startPoint.Y;
            if (!Settings.ShowDebuffPanel)
            {
                return startY;
            }
            var buffs = life.Buffs;
            if (buffs.Count > 0)
            {
                var isHostile = healthBar.Entity.IsHostile;
                int debuffTable = 0;
                foreach (var buff in buffs)
                {
                    var buffName = buff.Name;
                    if (HasDebuff(debuffPanelConfig.Bleeding, buffName, isHostile) ||
                    HasDebuff(debuffPanelConfig.Corruption, buffName, isHostile))
                        debuffTable |= 1;
                    else if (HasDebuff(debuffPanelConfig.Poisoned, buffName, isHostile))
                        debuffTable |= 2;
                    else if (HasDebuff(debuffPanelConfig.Chilled, buffName, isHostile) ||
                             HasDebuff(debuffPanelConfig.Frozen, buffName, isHostile))
                        debuffTable |= 4;
                    else if (HasDebuff(debuffPanelConfig.Burning, buffName, isHostile))
                        debuffTable |= 8;
                    else if (HasDebuff(debuffPanelConfig.Shocked, buffName, isHostile))
                        debuffTable |= 16;
                    else if (HasDebuff(debuffPanelConfig.WeakenedSlowed, buffName, isHostile))
                        debuffTable |= 32;
                }
                if (debuffTable > 0)
                {
                    startY -= Settings.DebuffPanelIconSize + 2;
                    var startX = startPoint.X;
                    DrawAllDebuff(debuffTable, startX, startY);
                }
            }
            return startY;
        }

        private void DrawAllDebuff(int debuffTable, float startX, float startY)
        {
            startX += DrawDebuff(() => (debuffTable & 1) == 1, startX, startY, 0, 4);
            startX += DrawDebuff(() => (debuffTable & 2) == 2, startX, startY, 1, 4);
            startX += DrawDebuff(() => (debuffTable & 4) == 4, startX, startY, 2);
            startX += DrawDebuff(() => (debuffTable & 8) == 8, startX, startY, 3, 4.5f);
            startX += DrawDebuff(() => (debuffTable & 16) == 16, startX, startY, 4, 5);
            DrawDebuff(() => (debuffTable & 32) == 32, startX, startY, 5);
        }

        private bool HasDebuff(Dictionary<string, int> dictionary, string buffName, bool isHostile)
        {
            int filterId;
            if (dictionary.TryGetValue(buffName, out filterId))
            {
                return filterId == 0 || isHostile == (filterId == 1);
            }
            return false;
        }

        private float DrawDebuff(Func<bool> predicate, float startX, float startY, int index, float marginFix = 0f)
        {
            if (predicate())
            {
                var size = Settings.DebuffPanelIconSize;
                const float ICON_COUNT = 6;
                float oneIconWidth = 1.0f / ICON_COUNT;
                if (marginFix > 0)
                    marginFix = oneIconWidth / marginFix;
                Graphics.DrawImage("debuff_panel.png", new RectangleF(startX, startY, size, size),
                    new RectangleF(index / ICON_COUNT + marginFix, 0, oneIconWidth - marginFix, 1f), Color.White);
                return size - 1.2f * size * marginFix * ICON_COUNT;
            }
            return 0;
        }

        protected override void OnEntityAdded(EntityWrapper entity)
        {
            var healthbarSettings = new HealthBar(entity, Settings);
            if (healthbarSettings.IsValid)
            {
                healthBars[healthbarSettings.Type].Add(healthbarSettings);
            }
        }

        private void DrawBackground(Color color, Color outline, RectangleF bg, float hpWidth, float esWidth)
        {
            if (outline != Color.Black)
            {
                Graphics.DrawFrame(bg, 2, outline);
            }
            string healthBar = Settings.ShowIncrements ? "healthbar_increment.png" : "healthbar.png";
            Graphics.DrawImage("healthbar_bg.png", bg, color);
            var hpRectangle = new RectangleF(bg.X, bg.Y, hpWidth, bg.Height);
            Graphics.DrawImage(healthBar, hpRectangle, color, hpWidth * 10 / bg.Width);
            if (Settings.ShowES)
            {
                bg.Width = esWidth;
                Graphics.DrawImage("esbar.png", bg);
            }
        }

        private float DrawFlatLifeAmount(Life life, float hpPercent,
            UnitSettings settings, RectangleF bg)
        {
            if (!settings.ShowHealthText)
            {
                return bg.Y;
            }

            string curHp = ConvertHelper.ToShorten(life.CurHP);
            string maxHp = ConvertHelper.ToShorten(life.MaxHP);
            string text = $"{curHp}/{maxHp}";
            Color color = hpPercent <= 0.1f ? settings.HealthTextColorUnder10Percent : settings.HealthTextColor;
            var position = new Vector2(bg.X + bg.Width / 2, bg.Y);
            Size2 size = Graphics.DrawText(text, settings.TextSize, position, color, FontDrawFlags.Center);
            return (int)bg.Y + (size.Height - bg.Height) / 2;
        }

        private float DrawFlatESAmount(HealthBar healthBar, RectangleF bg)
        {
            if (!healthBar.Settings.ShowHealthText || healthBar.Life.MaxES == 0)
            {
                return bg.Y;
            }

            string curES = ConvertHelper.ToShorten(healthBar.Life.CurES);
            string maxES = ConvertHelper.ToShorten(healthBar.Life.MaxES);
            string text = $"{curES}/{maxES}";
            Color color = healthBar.Settings.HealthTextColor;
            var position = new Vector2(bg.X + bg.Width / 2, bg.Y - 12);
            Size2 size = Graphics.DrawText(text, healthBar.Settings.TextSize, position, color, FontDrawFlags.Center);
            return (int)bg.Y + (size.Height - bg.Height) / 2 - 10;
        }

        private void DrawPercents(UnitSettings settings, float hpPercent, RectangleF bg)
        {
            if (settings.ShowPercents)
            {
                string text = Convert.ToString((int)(hpPercent * 100));
                var position = new Vector2(bg.X + bg.Width + 4, bg.Y);
                Graphics.DrawText(text, settings.TextSize, position, settings.PercentTextColor);
            }
        }
    }
}
