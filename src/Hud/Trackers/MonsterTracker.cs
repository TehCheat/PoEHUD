using PoeHUD.Controllers;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using PoeHUD.Models.Enums;
using PoeHUD.Models.Interfaces;
using PoeHUD.Poe.Components;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PoeHUD.Hud.Preload;

namespace PoeHUD.Hud.Trackers
{
    public class MonsterTracker : PluginWithMapIcons<MonsterTrackerSettings>
    {
        private readonly HashSet<long> alreadyAlertedOf;
        private readonly Dictionary<EntityWrapper, MonsterConfigLine> alertTexts;
        private readonly Dictionary<MonsterRarity, Func<EntityWrapper, Func<string, string>, CreatureMapIcon>> iconCreators;
        private readonly Dictionary<string, MonsterConfigLine> modAlerts, typeAlerts;
        private const string MOD_ALERTS = "config/monster_mod_alerts.txt";
        private const string MOD_ALERTS_PERSONAL = "config/monster_mod_alerts_personal.txt";
        private const string TYPE_ALERTS = "config/monster_name_alerts.txt";
        private const string TYPE_ALERTS_PERSONAL = "config/monster_name_alerts_personal.txt";

        public MonsterTracker(GameController gameController, Graphics graphics, MonsterTrackerSettings settings)
            : base(gameController, graphics, settings)
        {
            alreadyAlertedOf = new HashSet<long>();
            alertTexts = new Dictionary<EntityWrapper, MonsterConfigLine>();
            modAlerts = LoadConfig(MOD_ALERTS);
            typeAlerts = LoadConfig(TYPE_ALERTS);

            if (File.Exists(MOD_ALERTS_PERSONAL))
            {
                modAlerts = modAlerts.MergeLeft(LoadConfig(MOD_ALERTS_PERSONAL));
            }
            else
            {
                File.WriteAllText(MOD_ALERTS_PERSONAL , string.Empty);
            }

            if (File.Exists(TYPE_ALERTS_PERSONAL))
            {
                typeAlerts = typeAlerts.MergeLeft(LoadConfig(TYPE_ALERTS_PERSONAL));
            }
            else
            {
                File.WriteAllText(TYPE_ALERTS_PERSONAL, string.Empty);
            }
            Func<bool> monsterSettings = () => Settings.Monsters;
            iconCreators = new Dictionary<MonsterRarity, Func<EntityWrapper, Func<string, string>, CreatureMapIcon>>
            {
                { MonsterRarity.White, (e,f) => new CreatureMapIcon(e, f("ms-red.png"), monsterSettings, settings.WhiteMobIcon) },
                { MonsterRarity.Magic, (e,f) => new CreatureMapIcon(e, f("ms-blue.png"), monsterSettings, settings.MagicMobIcon) },
                { MonsterRarity.Rare, (e,f) => new CreatureMapIcon(e, f("ms-yellow.png"), monsterSettings, settings.RareMobIcon) },
                { MonsterRarity.Unique, (e,f) => new CreatureMapIcon(e, f("ms-purple.png"), monsterSettings, settings.UniqueMobIcon) }
            };
            GameController.Area.OnAreaChange += area =>
            {
                alreadyAlertedOf.Clear();
                alertTexts.Clear();
            };
        }

        public Dictionary<string, MonsterConfigLine> LoadConfig(string path)
        {
            return LoadConfigBase(path, 5).ToDictionary(line => line[0], line =>
            {
                var monsterConfigLine = new MonsterConfigLine
                {
                    Text = line[1],
                    SoundFile = line.ConfigValueExtractor(2),
                    Color = line.ConfigColorValueExtractor(3),
                    MinimapIcon = line.ConfigValueExtractor(4)
                };
                if (monsterConfigLine.SoundFile != null)
                    Sounds.AddSound(monsterConfigLine.SoundFile);
                return monsterConfigLine;
            });
        }

        public override void Render()
        {
            try
            {
                if (!Settings.Enable || !Settings.ShowText) { return; }

                RectangleF rect = GameController.Window.GetWindowRectangle();
                float xPos = rect.Width * Settings.TextPositionX * 0.01f + rect.X;
                float yPos = rect.Height * Settings.TextPositionY * 0.01f + rect.Y;

                Vector2 playerPos = GameController.Player.GetComponent<Positioned>().GridPos;
                bool first = true;
                var rectBackground = new RectangleF();

                var groupedAlerts = alertTexts.Where(y => y.Key.IsAlive && y.Key.IsHostile).Select(y =>
                {
                    Vector2 delta = y.Key.GetComponent<Positioned>().GridPos - playerPos;
                    double phi;
                    double distance = delta.GetPolarCoordinates(out phi);
                    return new { Dic = y, Phi = phi, Distance = distance };
                })
                    .OrderBy(y => y.Distance)
                    .GroupBy(y => y.Dic.Value)
                    .Select(y => new { y.Key.Text, y.Key.Color, Monster = y.First(), Count = y.Count() }).ToList();

                foreach (var group in groupedAlerts)
                {
                    RectangleF uv = GetDirectionsUV(group.Monster.Phi, group.Monster.Distance);
                    string text = $"{@group.Text} {(@group.Count > 1 ? "(" + @group.Count + ")" : string.Empty)}";
                    var color = group.Color ?? Settings.DefaultTextColor;
                    Size2 textSize = Graphics.DrawText(text, Settings.TextSize, new Vector2(xPos, yPos), color, FontDrawFlags.Center);

                    rectBackground = new RectangleF(xPos - 30 - textSize.Width / 2f - 6, yPos, 80 + textSize.Width, textSize.Height);
                    rectBackground.X -= textSize.Height + 3;
                    rectBackground.Width += textSize.Height;

                    var rectDirection = new RectangleF(rectBackground.X + 3, rectBackground.Y, rectBackground.Height, rectBackground.Height);

                    if (first) // vertical padding above
                    {
                        rectBackground.Y -= 2;
                        rectBackground.Height += 5;
                        first = false;
                    }
                    Graphics.DrawImage("preload-start.png", rectBackground, Settings.BackgroundColor);
                    Graphics.DrawImage("directions.png", rectDirection, uv, color);
                    yPos += textSize.Height;
                }
                if (!first) // vertical padding below
                {
                    rectBackground.Y = rectBackground.Y + rectBackground.Height;
                    rectBackground.Height = 5;
                    Graphics.DrawImage("preload-start.png", rectBackground, Settings.BackgroundColor);
                }
            }
            catch
            {
                // do nothing
            }
        }

        protected override void OnEntityAdded(EntityWrapper entity)
        {
            if (!Settings.Enable || alertTexts.ContainsKey(entity))
            {
                return;
            }
            if (entity.IsAlive && entity.HasComponent<Monster>())
            {
                string text = entity.Path;
                if (text.Contains('@'))
                {
                    text = text.Split('@')[0];
                }
                MonsterConfigLine monsterConfigLine = null;
                if (typeAlerts.ContainsKey(text))
                {
                    monsterConfigLine = typeAlerts[text];
                    AlertHandler(monsterConfigLine, entity);
                }
                else
                {
                    string modAlert = entity.GetComponent<ObjectMagicProperties>().Mods.FirstOrDefault(x => modAlerts.ContainsKey(x));
                    if (modAlert != null)
                    {
                        monsterConfigLine = modAlerts[modAlert];
                        AlertHandler(monsterConfigLine, entity);
                    }
                }
                MapIcon mapIcon = GetMapIconForMonster(entity, monsterConfigLine);
                if (mapIcon != null)
                {
                    CurrentIcons[entity] = mapIcon;
                }
            }
        }

        private void AlertHandler(MonsterConfigLine monsterConfigLine, EntityWrapper entity)
        {
            alertTexts.Add(entity, monsterConfigLine);
            PlaySound(entity, monsterConfigLine.SoundFile);
        }

        protected override void OnEntityRemoved(EntityWrapper entity)
        {
            base.OnEntityRemoved(entity);
            alertTexts.Remove(entity);
        }

        private string[] HiddenIcons = new string[]
        {
            "ms-red-gray.png",      //White     
            "ms-blue-gray.png",     //Magic
            "ms-yellow-gray.png",   //Rare
            "ms-purple-gray.png"    //Uniq
        };

        private static List<string> IgnoreEntitiesList = new List<string>()
        {
            "GoddessOfJustice",
            "MonsterFireTrap2",
            "MonsterBlastRainTrap",
            "Metadata/Monsters/Frog/FrogGod/SilverOrb",
            "Metadata/Monsters/Frog/FrogGod/SilverPool"
        };

        private MapIcon GetMapIconForMonster(EntityWrapper entity, MonsterConfigLine monsterConfigLine)
        {
            // If ignored entity found, skip
            foreach (string _entity in IgnoreEntitiesList)
            {
                if (entity.Path.Contains(_entity))
                    return null;
            }

            if (!entity.IsHostile)
            {
                return new CreatureMapIcon(entity, "ms-cyan.png", () => Settings.Minions, Settings.MinionsIcon);
            }

            MonsterRarity monsterRarity = entity.GetComponent<ObjectMagicProperties>().Rarity;
            Func<EntityWrapper, Func<string, string>, CreatureMapIcon> iconCreator;

            string overrideIcon = null;
            var life = entity.GetComponent<Life>();
            if (life.HasBuff("hidden_monster"))
            {
                overrideIcon = HiddenIcons[(int)monsterRarity];
            }


            return iconCreators.TryGetValue(monsterRarity, out iconCreator)
                ? iconCreator(entity, text => monsterConfigLine?.MinimapIcon ?? overrideIcon ?? text) : null;
        }

        private void PlaySound(IEntity entity, string soundFile)
        {
            if (Settings.PlaySound && !alreadyAlertedOf.Contains(entity.Id))
            {
                if (!string.IsNullOrEmpty(soundFile))
                    Sounds.GetSound(soundFile).Play(Settings.SoundVolume);
                alreadyAlertedOf.Add(entity.Id);
            }
        }
    }
}