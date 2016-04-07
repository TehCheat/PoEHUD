using Antlr4.Runtime;
using PoeFilterParser;
using PoeFilterParser.Model;
using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using PoeHUD.Models.Enums;
using PoeHUD.Models.Interfaces;
using PoeHUD.Poe;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.Elements;
using PoeHUD.Poe.RemoteMemoryObjects;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PoeHUD.Hud.Loot
{
    public class ItemAlertPlugin : SizedPluginWithMapIcons<ItemAlertSettings>
    {
        private readonly HashSet<long> playedSoundsCache;
        private readonly Dictionary<EntityWrapper, AlertDrawStyle> currentAlerts;
        private readonly HashSet<CraftingBase> craftingBases;
        private readonly HashSet<string> currencyNames;
        private Dictionary<int, ItemsOnGroundLabelElement> currentLabels;
        private PoeFilterVisitor visitor;

        public ItemAlertPlugin(GameController gameController, Graphics graphics, ItemAlertSettings settings)
            : base(gameController, graphics, settings)
        {
            playedSoundsCache = new HashSet<long>();
            currentAlerts = new Dictionary<EntityWrapper, AlertDrawStyle>();
            currentLabels = new Dictionary<int, ItemsOnGroundLabelElement>();
            currencyNames = LoadCurrency();
            craftingBases = LoadCraftingBases();
            GameController.Area.OnAreaChange += OnAreaChange;
            PoeFilterInit(settings.FilePath);
            settings.FilePath.OnFileChanged += () => PoeFilterInit(settings.FilePath);
        }

        private void PoeFilterInit(string path)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    using (var fileStream = new StreamReader(path))
                    {
                        var input = new AntlrInputStream(fileStream.ReadToEnd());
                        var lexer = new PoeFilterLexer(input);
                        var tokens = new CommonTokenStream(lexer);
                        var parser = new PoeFilterParser.Model.PoeFilterParser(tokens);
                        parser.RemoveErrorListeners();
                        parser.AddErrorListener(new ErrorListener());
                        var tree = parser.main();
                        visitor = new PoeFilterVisitor(tree, GameController, Settings);
                    }
                }
                else
                {
                    Settings.Alternative.Value = false;
                }
            }
            catch (SyntaxErrorException ex)
            {
                Settings.FilePath.Value = string.Empty;
                Settings.Alternative.Value = false;
                MessageBox.Show($"Line: {ex.Line}:{ex.CharPositionInLine}, " +
                                $"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                visitor = null;
            }
            catch (Exception ex)
            {
                Settings.FilePath.Value = string.Empty;
                Settings.Alternative.Value = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Dispose()
        {
            GameController.Area.OnAreaChange -= OnAreaChange;
        }

        public override void Render()
        {
            try
            {
                base.Render();
                if (!Settings.Enable || WinApi.IsKeyDown(Keys.F10)) { return; }

                if (Settings.Enable)
                {
                    Vector2 playerPos = GameController.Player.GetComponent<Positioned>().GridPos;
                    Vector2 position = StartDrawPointFunc();
                    const int BOTTOM_MARGIN = 2;
                    bool shouldUpdate = false;

                    if (Settings.BorderSettings.Enable)
                    {
                        Dictionary<EntityWrapper, AlertDrawStyle> tempCopy = new Dictionary<EntityWrapper, AlertDrawStyle>(currentAlerts);
                        var keyValuePairs = tempCopy.AsParallel().Where(x => x.Key.IsValid).ToList();
                        foreach (var kv in keyValuePairs)
                        {
                            if (DrawBorder(kv.Key.Address) && !shouldUpdate)
                            {
                                shouldUpdate = true;
                            }
                        }
                    }

                    foreach (KeyValuePair<EntityWrapper, AlertDrawStyle> kv in currentAlerts.Where(x => x.Key.IsValid))
                    {
                        string text = GetItemName(kv);
                        if (text == null)
                        {
                            continue;
                        }

                        ItemsOnGroundLabelElement entityLabel;
                        if (!currentLabels.TryGetValue(kv.Key.Address, out entityLabel))
                        {
                            shouldUpdate = true;
                        }
                        else
                        {
                            if (Settings.ShowText && (!Settings.HideOthers || entityLabel.CanPickUp || entityLabel.MaxTimeForPickUp.TotalSeconds == 0))
                                position = DrawText(playerPos, position, BOTTOM_MARGIN, kv, text);
                        }
                    }
                    Size = new Size2F(0, position.Y); //bug absent width

                    if (shouldUpdate)
                    {
                        currentLabels = GameController.Game.IngameState.IngameUi.ItemsOnGroundLabels
                            .GroupBy(y => y.ItemOnGround.Address).ToDictionary(y => y.Key, y => y.First());
                    }
                }
            }
            catch
            {
                // do nothing
            }
        }

        private Vector2 DrawText(Vector2 playerPos, Vector2 position, int BOTTOM_MARGIN,
            KeyValuePair<EntityWrapper, AlertDrawStyle> kv, string text)
        {
            var padding = new Vector2(5, 2);
            Vector2 delta = kv.Key.GetComponent<Positioned>().GridPos - playerPos;
            Vector2 itemSize = DrawItem(kv.Value, delta, position, padding, text);
            if (itemSize != new Vector2())
            {
                position.Y += itemSize.Y + BOTTOM_MARGIN;
            }
            return position;
        }

        protected override void OnEntityAdded(EntityWrapper entity)
        {
            if (Settings.Enable && entity != null && !GameController.Area.CurrentArea.IsTown
                && !currentAlerts.ContainsKey(entity) && entity.HasComponent<WorldItem>())
            {
                IEntity item = entity.GetComponent<WorldItem>().ItemEntity;
                if (Settings.Alternative && !string.IsNullOrEmpty(Settings.FilePath))
                {
                    var result = visitor.Visit(item);
                    if (result != null)
                    {
                        AlertDrawStyle drawStyle = result;
                        PrepareForDrawingAndPlaySound(entity, drawStyle);
                    }
                }
                else
                {
                    ItemUsefulProperties props = initItem(item);
                    if (props == null)
                        return;
                    if (props.ShouldAlert(currencyNames, Settings))
                    {
                        AlertDrawStyle drawStyle = props.GetDrawStyle();
                        PrepareForDrawingAndPlaySound(entity, drawStyle);
                    }
                    Settings.Alternative.Value = false;
                }
            }
        }

        private void PrepareForDrawingAndPlaySound(EntityWrapper entity, AlertDrawStyle drawStyle)
        {
            currentAlerts.Add(entity, drawStyle);
            CurrentIcons[entity] = new MapIcon(entity, new HudTexture("currency.png", drawStyle.TextColor), () => Settings.ShowItemOnMap, Settings.LootIcon);

            if (Settings.PlaySound && !playedSoundsCache.Contains(entity.LongId))
            {
                playedSoundsCache.Add(entity.LongId);
                Sounds.AlertSound.Play(Settings.SoundVolume);
            }
        }

        protected override void OnEntityRemoved(EntityWrapper entity)
        {
            base.OnEntityRemoved(entity);
            currentAlerts.Remove(entity);
            currentLabels.Remove(entity.Address);
        }

        private static HashSet<CraftingBase> LoadCraftingBases()
        {
            if (!File.Exists("config/crafting_bases.txt"))
            {
                return new HashSet<CraftingBase>();
            }
            var hashSet = new HashSet<CraftingBase>();
            var parseErrors = new List<string>();
            string[] array = File.ReadAllLines("config/crafting_bases.txt");
            foreach (string text in array.Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x) && !x.StartsWith("#")))
            {
                string[] parts = text.Split(',');
                string itemName = parts[0].Trim();

                var item = new CraftingBase { Name = itemName };

                int tmpVal;
                if (parts.Length > 1 && int.TryParse(parts[1], out tmpVal))
                {
                    item.MinItemLevel = tmpVal;
                }

                if (parts.Length > 2 && int.TryParse(parts[2], out tmpVal))
                {
                    item.MinQuality = tmpVal;
                }

                const int RARITY_POSITION = 3;
                if (parts.Length > RARITY_POSITION)
                {
                    item.Rarities = new ItemRarity[parts.Length - 3];
                    for (int i = RARITY_POSITION; i < parts.Length; i++)
                    {
                        if (item.Rarities != null && !Enum.TryParse(parts[i], true, out item.Rarities[i - RARITY_POSITION]))
                        {
                            parseErrors.Add("Incorrect rarity definition at line: " + text);
                            item.Rarities = null;
                        }
                    }
                }

                if (!hashSet.Add(item))
                {
                    parseErrors.Add("Duplicate definition for item was ignored: " + text);
                }
            }

            if (parseErrors.Any())
            {
                throw new Exception("Error parsing config/crafting_bases.txt\r\n" + string.Join(Environment.NewLine, parseErrors));
            }

            return hashSet;
        }

        private static HashSet<string> LoadCurrency()
        {
            if (!File.Exists("config/currency.txt"))
            {
                return null;
            }
            var hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            string[] lines = File.ReadAllLines("config/currency.txt");
            lines.Where(x => !string.IsNullOrWhiteSpace(x) && !x.StartsWith("#")).ForEach(x => hashSet.Add(x.Trim().ToLowerInvariant()));
            return hashSet;
        }

        private bool DrawBorder(int entityAddress)
        {
            IngameUIElements ui = GameController.Game.IngameState.IngameUi;
            ItemsOnGroundLabelElement entityLabel;
            bool shouldUpdate = false;
            if (currentLabels.TryGetValue(entityAddress, out entityLabel))
            {
                if (entityLabel.IsVisible)
                {
                    RectangleF rect = entityLabel.Label.GetClientRect();
                    if ((ui.OpenLeftPanel.IsVisible && ui.OpenLeftPanel.GetClientRect().Intersects(rect)) ||
                        (ui.OpenRightPanel.IsVisible && ui.OpenRightPanel.GetClientRect().Intersects(rect)))
                    {
                        return false;
                    }

                    ColorNode borderColor = Settings.BorderSettings.BorderColor;
                    if (!entityLabel.CanPickUp)
                    {
                        borderColor = Settings.BorderSettings.NotMyItemBorderColor;
                        TimeSpan timeLeft = entityLabel.TimeLeft;
                        if (Settings.BorderSettings.ShowTimer && timeLeft.TotalMilliseconds > 0)
                        {
                            borderColor = Settings.BorderSettings.CantPickUpBorderColor;
                            Graphics.DrawText(timeLeft.ToString(@"mm\:ss"), Settings.BorderSettings.TimerTextSize, rect.TopRight.Translate(4, 0));
                        }
                    }
                    Graphics.DrawFrame(rect, Settings.BorderSettings.BorderWidth, borderColor);
                }
            }
            else
            {
                shouldUpdate = true;
            }
            return shouldUpdate;
        }

        private Vector2 DrawItem(AlertDrawStyle drawStyle, Vector2 delta, Vector2 position, Vector2 padding, string text)
        {
            padding.X -= drawStyle.BorderWidth;
            padding.Y -= drawStyle.BorderWidth;
            double phi;
            double distance = delta.GetPolarCoordinates(out phi);
            float compassOffset = Settings.TextSize + 8;
            Vector2 textPos = position.Translate(-padding.X - compassOffset, padding.Y);
            Size2 textSize = Graphics.DrawText(text, Settings.TextSize, textPos, drawStyle.TextColor, FontDrawFlags.Right);
            if (textSize == new Size2()) { return new Vector2(); }
            int iconSize = drawStyle.IconIndex >= 0 ? textSize.Height : 0;
            float fullHeight = textSize.Height + 2 * padding.Y + 2 * drawStyle.BorderWidth;
            float fullWidth = textSize.Width + 2 * padding.X + iconSize + 2 * drawStyle.BorderWidth + compassOffset;
            var boxRect = new RectangleF(position.X - fullWidth, position.Y, fullWidth - compassOffset, fullHeight);
            Graphics.DrawBox(boxRect, drawStyle.BackgroundColor);

            RectangleF rectUV = GetDirectionsUV(phi, distance);
            var rectangleF = new RectangleF(position.X - padding.X - compassOffset + 6, position.Y + padding.Y,
                textSize.Height, textSize.Height);
            Graphics.DrawImage("directions.png", rectangleF, rectUV);

            if (iconSize > 0)
            {
                const float ICONS_IN_SPRITE = 4;
                var iconPos = new RectangleF(textPos.X - iconSize - textSize.Width, textPos.Y, iconSize, iconSize);
                float iconX = drawStyle.IconIndex / ICONS_IN_SPRITE;
                var uv = new RectangleF(iconX, 0, (drawStyle.IconIndex + 1) / ICONS_IN_SPRITE - iconX, 1);
                Graphics.DrawImage("item_icons.png", iconPos, uv);
            }
            if (drawStyle.BorderWidth > 0)
            {
                Graphics.DrawFrame(boxRect, drawStyle.BorderWidth, drawStyle.BorderColor);
            }
            return new Vector2(fullWidth, fullHeight);
        }

        private ItemUsefulProperties initItem(IEntity item)
        {
            BaseItemType bit = GameController.Files.BaseItemTypes.Translate(item.Path);
            if (bit == null)
                return null;
            string name = bit.BaseName;
            CraftingBase craftingBase = new CraftingBase();
            if (Settings.Crafting)
            {
                foreach (CraftingBase cb in craftingBases
                    .Where(cb => cb.Name
                    .Equals(name, StringComparison.InvariantCultureIgnoreCase) || new Regex(cb.Name)
                    .Match(name).Success))
                {
                    craftingBase = cb;
                    break;
                }
            }

            return new ItemUsefulProperties(name, item, craftingBase);
        }

        private string GetItemName(KeyValuePair<EntityWrapper, AlertDrawStyle> kv)
        {
            string text;
            Entity itemEntity = kv.Key.GetComponent<WorldItem>().ItemEntity;
            EntityLabel labelForEntity = GameController.EntityListWrapper.GetLabelForEntity(itemEntity);
            if (labelForEntity == null)
            {
                if (!itemEntity.IsValid)
                {
                    return null;
                }
                text = kv.Value.Text;
            }
            else
            {
                text = labelForEntity.Text;
            }
            return text;
        }

        private void OnAreaChange(AreaController area)
        {
            playedSoundsCache.Clear();
            currentLabels.Clear();
            currentAlerts.Clear();
            CurrentIcons.Clear();
        }
    }
}