using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using PoeHUD.Poe.Components;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PoeHUD.Hud.Dps
{
    public class DpsMeterPlugin : SizedPlugin<DpsMeterSettings>
    {
        private const double DPS_PERIOD = 0.2;
        private DateTime lastTime;
        private readonly Dictionary<long, int> lastMonsters = new Dictionary<long, int>();
        private double MaxDpsAoe;
        private double MaxDpsSingle;
        private double CurrentDpsAoe;
        private double CurrentDpsSingle;
        private double CurrentDmgAoe;
        private double CurrentDmgSingle;
        private double[] SingleDamageMemory = new double[5];
        private double[] AOEDamageMemory = new double[5];

        public DpsMeterPlugin(GameController gameController, Graphics graphics, DpsMeterSettings settings)
            : base(gameController, graphics, settings)
        {
            Settings.ClearNode.OnPressed += Clear;

            lastTime = DateTime.Now;
            GameController.Area.OnAreaChange += area =>
            {
                Clear();
            };
        }

        private void Clear()
        {
            MaxDpsAoe = 0;
            MaxDpsSingle = 0;
            CurrentDpsAoe = 0;
            CurrentDpsSingle = 0;
            CurrentDmgAoe = 0;
            CurrentDmgSingle = 0;
            lastMonsters.Clear();
            lastTime = DateTime.Now;
            SingleDamageMemory = new double[5];
            AOEDamageMemory = new double[5];
            lastMonsters.Clear();
        }


        public override void Render()
        {
            if (!Settings.Enable ||
                !Settings.ShowInTown && GameController.Area.CurrentArea.IsTown ||
                !Settings.ShowInTown && GameController.Area.CurrentArea.IsHideout)
            { return; }

            DateTime nowTime = DateTime.Now;
            TimeSpan elapsedTime = nowTime - lastTime;
            if (elapsedTime.TotalSeconds > DPS_PERIOD)
            {
                CalculateDps(out var aoe, out var single);

                //Shift array
                //{ 1, 2, 3, 4, 5 }
                //{ 0, 1, 2, 3, 4 }
                Array.Copy(AOEDamageMemory, 0, AOEDamageMemory, 1, AOEDamageMemory.Length - 1);
                Array.Copy(SingleDamageMemory, 0, SingleDamageMemory, 1, SingleDamageMemory.Length - 1);

                AOEDamageMemory[0] = aoe;
                SingleDamageMemory[0] = single;

                if (single > 0)
                { 
                    CurrentDmgAoe = aoe;
                    CurrentDmgSingle = single;
                    CurrentDpsAoe = AOEDamageMemory.Sum();
                    CurrentDpsSingle = SingleDamageMemory.Sum();

                    MaxDpsAoe = Math.Max(CurrentDpsAoe, MaxDpsAoe);
                    MaxDpsSingle = Math.Max(CurrentDpsSingle, MaxDpsSingle);
                }

                lastTime = nowTime;
            }

            Vector2 position = StartDrawPointFunc();


            string layoutFix = Settings.ShowAOE.Value ? "      " : "";
            int offsetY = 0;
            if (Settings.ShowCurrentHitDamage.Value)
            {
                if(Settings.ShowAOE.Value)
                offsetY += Graphics.DrawText($"{CurrentDmgAoe}{layoutFix}  aoe hit", Settings.TextSize, position, Settings.DpsFontColor, FontDrawFlags.Right).Height;
                offsetY += Graphics.DrawText($"{CurrentDmgSingle}{layoutFix}        hit", Settings.TextSize, position.Translate(0, offsetY), Settings.PeakFontColor, FontDrawFlags.Right).Height;
            }

            if (Settings.ShowAOE.Value)
                offsetY += Graphics.DrawText($"{CurrentDpsAoe}{layoutFix} aoe dps", Settings.TextSize, position.Translate(0, offsetY), Settings.PeakFontColor, FontDrawFlags.Right).Height;
            offsetY += Graphics.DrawText($"{CurrentDpsSingle}{layoutFix}       dps", Settings.TextSize, position.Translate(0, offsetY), Settings.PeakFontColor, FontDrawFlags.Right).Height;

            if (Settings.ShowAOE.Value)
                offsetY += Graphics.DrawText($"{MaxDpsAoe} max aoe dps", Settings.TextSize, position.Translate(0, offsetY), Settings.PeakFontColor, FontDrawFlags.Right).Height;
            offsetY += Graphics.DrawText($"{MaxDpsSingle}{layoutFix} max dps", Settings.TextSize, position.Translate(0, offsetY), Settings.PeakFontColor, FontDrawFlags.Right).Height;

            var width = 150;
            var bounds = new RectangleF(position.X - 5 - width - 41, position.Y - 5, width + 50, offsetY + 10);

            Graphics.DrawImage("preload-start.png", bounds, Settings.BackgroundColor);
            Graphics.DrawImage("preload-end.png", bounds, Settings.BackgroundColor);

            Size = bounds.Size;
            Margin = new Vector2(0, 5);
        }

        private List<EntityWrapper> CachedMonsters = new List<EntityWrapper>();
        protected override void OnEntityAdded(EntityWrapper entityWrapper)
        {
            if (!entityWrapper.HasComponent<Monster>() || !entityWrapper.IsHostile || !entityWrapper.IsAlive) return;

            if (!CachedMonsters.Contains(entityWrapper))
                CachedMonsters.Add(entityWrapper);
        }

        protected override void OnEntityRemoved(EntityWrapper entityWrapper)
        {
            CachedMonsters.Remove(entityWrapper);
        }

        private void CalculateDps(out int aoeDamage, out int singleDamage)
        {
            aoeDamage = 0;
            singleDamage = 0;
            foreach (var monster in CachedMonsters)
            {
                var life = monster.GetComponent<Life>();
                if(!monster.IsAlive && Settings.HasCullingStrike.Value)
                {
                    continue;
                }
                int hp = monster.IsAlive ? life.CurHP + life.CurES : 0;

                if (hp > -1000000 && hp < 10000000)
                {
                    int lastHP;
                    if (lastMonsters.TryGetValue(monster.Id, out lastHP))
                    {
                        if (lastHP != hp)
                        {
                            int dmg = lastHP - hp;
                            aoeDamage += dmg;
                            singleDamage = Math.Max(singleDamage, dmg);
                        }
                    }
                    lastMonsters[monster.Id] = hp;
                }
            }
        }
    }
}