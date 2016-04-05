using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using PoeFilterParser.Model;
using PoeHUD.Controllers;
using PoeHUD.Models.Enums;
using PoeHUD.Models.Interfaces;
using PoeHUD.Poe.Components;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoeHUD.Hud.Loot
{
    public class PoeFilterVisitor : PoeFilterBaseVisitor<AlertDrawStyle>
    {
        private readonly GameController gameController;
        private readonly IParseTree tree;
        private readonly ItemAlertSettings settings;
        private IEntity entity;

        public PoeFilterVisitor(IParseTree tree, GameController gameController, ItemAlertSettings settings)
        {
            this.tree = tree;
            this.gameController = gameController;
            this.settings = settings;
        }

        public AlertDrawStyle Visit(IEntity entity)
        {
            this.entity = entity;
            return base.Visit(tree);
        }

        public override AlertDrawStyle VisitMain(PoeFilterParser.Model.PoeFilterParser.MainContext context)
        {
            if (entity == null || gameController == null || gameController.Files == null || gameController.Files.BaseItemTypes == null)
                return null;
            var filterEnabled = settings.WithBorder || settings.WithSound;
            var baseItemType = gameController.Files.BaseItemTypes.Translate(entity.Path);
            if (baseItemType == null)
                return null;
            var basename = baseItemType.BaseName;
            var dropLevel = baseItemType.DropLevel;
            var className = baseItemType.ClassName;
            var width = baseItemType.Width;
            var height = baseItemType.Height;
            var blocks = context.block();
            var mods = entity.GetComponent<Mods>();
            var isSkillHGem = entity.HasComponent<SkillGem>();
            var isMap = entity.HasComponent<Map>();
            var itemRarity = mods.ItemRarity;
            var quality = 0;
            if (entity.HasComponent<Quality>()) { quality = entity.GetComponent<Quality>().ItemQuality; }
            var text = string.Concat(quality > 0 ? "Superior " : string.Empty, basename);
            var sockets = entity.GetComponent<Sockets>();
            var numberOfSockets = sockets.NumberOfSockets;
            var largestLinkSize = sockets.LargestLinkSize;
            var socketGroup = sockets.SocketGroup;
            var path = entity.Path;

            Color defaultTextColor;
            //if (basename.Contains("Portal") || basename.Contains("Wisdom")) { return null; }
            if (basename.Contains("Scroll")) { return null; }
            if (path.Contains("Currency")) { defaultTextColor = HudSkin.CurrencyColor; }
            else if (path.Contains("DivinationCards")) { defaultTextColor = HudSkin.DivinationCardColor; }
            else if (path.Contains("Talismans")) { defaultTextColor = HudSkin.TalismanColor; }
            else if (isSkillHGem) { defaultTextColor = HudSkin.SkillGemColor; }
            else defaultTextColor = AlertDrawStyle.GetTextColorByRarity(itemRarity);
            var defaultBorderWidth = isMap || path.Contains("VaalFragment") ? 1 : 0;

            foreach (var block in blocks)
            {
                var isShow = block.visibility().SHOW() != null;
                var itemLevelCondition = true;
                var dropLevelCondition = true;
                var poeClassCondition = true;
                var poeBaseTypeCondition = true;
                var poeRarityCondition = true;
                var poeQualityCondition = true;
                var poeWidthCondition = true;
                var poeHeightCondition = true;
                var poeSocketsCondition = true;
                var poeLinkedSocketsCondition = true;
                var poeSocketGroupCondition = true;
                var backgroundColor = AlertDrawStyle.DefaultBackgroundColor;
                var borderColor = Color.White;
                var textColor = defaultTextColor;
                var borderWidth = defaultBorderWidth;
                var sound = -1;
                var statements = block.statement();

                foreach (var statement in statements)
                {
                    var poeItemLevelContext = statement.poeItemLevel();
                    if (poeItemLevelContext != null)
                    {
                        itemLevelCondition &= CalculateDigitsCondition(poeItemLevelContext.compareOpNullable(),
                            poeItemLevelContext.digitsParams(), mods.ItemLevel);
                    }
                    else {
                        var poeDropLevelContext = statement.poeDropLevel();
                        if (poeDropLevelContext != null)
                        {
                            dropLevelCondition &= CalculateDigitsCondition(poeDropLevelContext.compareOpNullable(),
                                poeDropLevelContext.digitsParams(), dropLevel);
                        }
                        else {
                            var poeClassContext = statement.poeClass();
                            if (poeClassContext != null)
                            {
                                poeClassCondition = poeClassContext.@params()
                                    .strValue().Any(y => className.Contains(GetRawText(y)));
                            }
                            else {
                                var poeBaseTypeContext = statement.poeBaseType();
                                if (poeBaseTypeContext != null)
                                {
                                    poeBaseTypeCondition = poeBaseTypeContext.@params()
                                        .strValue().Any(y => basename.Contains(GetRawText(y)));
                                }
                                else {
                                    var poeRarityContext = statement.poeRarity();
                                    if (poeRarityContext != null)
                                    {
                                        var compareFunc = OpConvertor(poeRarityContext.compareOpNullable());
                                        poeRarityCondition &= poeRarityContext.rariryParams().rarityValue().Any(y =>
                                        {
                                            ItemRarity poeItemRarity;
                                            Enum.TryParse(GetRawText(y), true, out poeItemRarity);
                                            return compareFunc((int)itemRarity, (int)poeItemRarity);
                                        });
                                    }
                                    else {
                                        var poeQualityContext = statement.poeQuality();
                                        if (poeQualityContext != null)
                                        {
                                            poeQualityCondition &= CalculateDigitsCondition(poeQualityContext.compareOpNullable(),
                                                poeQualityContext.digitsParams(), quality);
                                        }
                                        else {
                                            var poeWidthContext = statement.poeWidth();
                                            if (poeWidthContext != null)
                                            {
                                                poeWidthCondition &= CalculateDigitsCondition(poeWidthContext.compareOpNullable(),
                                                    poeWidthContext.digitsParams(), width);
                                            }
                                            else {
                                                var poeHeightContext = statement.poeHeight();
                                                if (poeHeightContext != null)
                                                {
                                                    poeHeightCondition &= CalculateDigitsCondition(poeHeightContext.compareOpNullable(),
                                                        poeHeightContext.digitsParams(), height);
                                                }
                                                else {
                                                    var poeSocketsContext = statement.poeSockets();
                                                    if (poeSocketsContext != null)
                                                    {
                                                        poeSocketsCondition &= CalculateDigitsCondition(poeSocketsContext.compareOpNullable(),
                                                            poeSocketsContext.digitsParams(), numberOfSockets);
                                                    }
                                                    else {
                                                        var poeLinkedSocketsContext = statement.poeLinkedSockets();
                                                        if (poeLinkedSocketsContext != null)
                                                        {
                                                            poeLinkedSocketsCondition &= CalculateDigitsCondition(poeLinkedSocketsContext.compareOpNullable(),
                                                                poeLinkedSocketsContext.digitsParams(), largestLinkSize);
                                                        }
                                                        else {
                                                            var poeSocketGroupContext = statement.poeSocketGroup();
                                                            if (poeSocketGroupContext != null)
                                                            {
                                                                poeSocketGroupCondition &= poeSocketGroupContext.socketParams()
                                                                    .socketValue().Any(y =>
                                                                    {
                                                                        var poeSocketGroup = GetRawText(y);
                                                                        return IsContainSocketGroup(socketGroup, poeSocketGroup);
                                                                    });
                                                            }
                                                            else {
                                                                var poeBackgroundColorContext = statement.poeBackgroundColor();
                                                                if (poeBackgroundColorContext != null)
                                                                {
                                                                    backgroundColor = ToColor(poeBackgroundColorContext.color());
                                                                }
                                                                else {
                                                                    var poeBorderColorContext = statement.poeBorderColor();
                                                                    if (poeBorderColorContext != null)
                                                                    {
                                                                        borderColor = ToColor(poeBorderColorContext.color()); borderWidth = borderColor.A == 0 ? 0 : 1;
                                                                    }
                                                                    else {
                                                                        var poeTextColorContext = statement.poeTextColor();
                                                                        if (poeTextColorContext != null)
                                                                        {
                                                                            textColor = ToColor(poeTextColorContext.color());
                                                                        }
                                                                        else {
                                                                            var poeAlertSoundContext = statement.poeAlertSound();
                                                                            if (poeAlertSoundContext != null)
                                                                            {
                                                                                sound = Convert.ToInt32(poeAlertSoundContext.id().GetText());
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (itemLevelCondition && dropLevelCondition && poeClassCondition && poeBaseTypeCondition &&
                    poeRarityCondition && poeQualityCondition && poeWidthCondition && poeHeightCondition &&
                    poeSocketsCondition && poeLinkedSocketsCondition && poeSocketGroupCondition)
                {
                    if (!isShow || (filterEnabled && !(settings.WithBorder && borderWidth > 0 || settings.WithSound && sound >= 0)))
                        return null;

                    int iconIndex;
                    if (largestLinkSize == 6) { iconIndex = 3; }
                    else if (numberOfSockets == 6) { iconIndex = 0; }
                    else if (IsContainSocketGroup(socketGroup, "RGB")) { iconIndex = 1; }
                    else iconIndex = -1;
                    return new AlertDrawStyle(text, textColor, borderWidth, borderColor, backgroundColor, iconIndex);
                }
            }
            return null;
        }

        private string GetRawText(ParserRuleContext context)
        {
            return context.GetText().Trim('"');
        }

        private bool CalculateDigitsCondition(
            PoeFilterParser.Model.PoeFilterParser.CompareOpNullableContext compareOpNullable,
            PoeFilterParser.Model.PoeFilterParser.DigitsParamsContext digitsParams, int value)
        {
            var compareFunc = OpConvertor(compareOpNullable);
            return digitsParams.DIGITS().Any(y =>
            {
                var poeValue = Convert.ToInt32(y.GetText());
                return compareFunc(value, poeValue);
            });
        }

        private bool IsContainSocketGroup(List<string> socketGroup, string str)
        {
            str = string.Concat(str.OrderBy(y => y)); return
                socketGroup.Select(group => string.Concat(group.OrderBy(y => y)))
                    .Any(sortedGroup => sortedGroup.Contains(str));
        }

        private Color ToColor(PoeFilterParser.Model.PoeFilterParser.ColorContext colorContext)
        {
            var red = Convert.ToByte(colorContext.red().GetText());
            var green = Convert.ToByte(colorContext.green().GetText());
            var blue = Convert.ToByte(colorContext.blue().GetText());
            var alphaContext = colorContext.alpha();
            var alpha = alphaContext.DIGITS() != null ? Convert.ToByte(alphaContext.GetText()) : 255;
            return new Color(red, green, blue, alpha);
        }

        private Func<int, int, bool> OpConvertor(
            PoeFilterParser.Model.PoeFilterParser.CompareOpNullableContext terminalnode)
        {
            var text = terminalnode.COMPAREOP()?.GetText() ?? "=";
            switch (text)
            {
                case "=": return (x, y) => x == y;
                case "<": return (x, y) => x < y;
                case ">": return (x, y) => x > y;
                case "<=": return (x, y) => x <= y;
                case ">=": return (x, y) => x >= y;
            }
            throw new ArrayTypeMismatchException();
        }
    }
}