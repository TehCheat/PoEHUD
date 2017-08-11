using PoeHUD.Controllers;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using PoeHUD.Poe.Components;
using System.Collections.Generic;

namespace PoeHUD.Hud.Trackers
{
    public class PoiTracker : PluginWithMapIcons<PoiTrackerSettings>
    {
        private static readonly List<string> masters = new List<string>
        {
            "Metadata/NPC/Missions/Wild/Dex",
            "Metadata/NPC/Missions/Wild/DexInt",
            "Metadata/NPC/Missions/Wild/Int",
            "Metadata/NPC/Missions/Wild/Str",
            "Metadata/NPC/Missions/Wild/StrDex",
            "Metadata/NPC/Missions/Wild/StrDexInt",
            "Metadata/NPC/Missions/Wild/StrInt"
        };

        private static readonly List<string> cadiro = new List<string>
        {
            "Metadata/NPC/League/Cadiro"
        };

        private static readonly List<string> perandus = new List<string>
        {
            "Metadata/Chests/PerandusChests/PerandusChestStandard",
            "Metadata/Chests/PerandusChests/PerandusChestRarity",
            "Metadata/Chests/PerandusChests/PerandusChestQuantity",
            "Metadata/Chests/PerandusChests/PerandusChestCoins",
            "Metadata/Chests/PerandusChests/PerandusChestJewellery",
            "Metadata/Chests/PerandusChests/PerandusChestGems",
            "Metadata/Chests/PerandusChests/PerandusChestCurrency",
            "Metadata/Chests/PerandusChests/PerandusChestInventory",
            "Metadata/Chests/PerandusChests/PerandusChestDivinationCards",
            "Metadata/Chests/PerandusChests/PerandusChestKeepersOfTheTrove",
            "Metadata/Chests/PerandusChests/PerandusChestUniqueItem",
            "Metadata/Chests/PerandusChests/PerandusChestMaps",
            "Metadata/Chests/PerandusChests/PerandusChestFishing",
            "Metadata/Chests/PerandusChests/PerandusManorUniqueChest",
            "Metadata/Chests/PerandusChests/PerandusManorCurrencyChest",
            "Metadata/Chests/PerandusChests/PerandusManorMapsChest",
            "Metadata/Chests/PerandusChests/PerandusManorJewelryChest",
            "Metadata/Chests/PerandusChests/PerandusManorDivinationCardsChest",
            "Metadata/Chests/PerandusChests/PerandusManorLostTreasureChest"
        };

        private static readonly List<string> labyrinth = new List<string>
        {
            "Metadata/Chests/Labyrinth/LabyrinthTreasureKey",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest1",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest2",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest3",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest4",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest5",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest6",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest7",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest8",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest9",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest10",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest11",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest12",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest13",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest14",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest15",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest16",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest17",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest18",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest19",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest20",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest21",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest22",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest23",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest24",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest25",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest26",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest27",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest28",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest29",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest30",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest31",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest32",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest33",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest34",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest35",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest36",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest37",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest38",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest39",
            "Metadata/Chests/Labyrinth/Izaro/IzaroChest40"
    };

        public PoiTracker(GameController gameController, Graphics graphics, PoiTrackerSettings settings)
            : base(gameController, graphics, settings)
        { }

        public override void Render()
        {
            if (!Settings.Enable) { }
        }

        protected override void OnEntityAdded(EntityWrapper entity)
        {
            if (!Settings.Enable) { return; }

            MapIcon icon = GetMapIcon(entity);
            if (null != icon)
            {
                CurrentIcons[entity] = icon;
            }
        }

        private MapIcon GetMapIcon(EntityWrapper e)
        {
            if (e.HasComponent<NPC>() && masters.Contains(e.Path))
            {
                return new CreatureMapIcon(e, "ms-cyan.png", () => Settings.Masters, Settings.MastersIcon);
            }
            if (e.HasComponent<NPC>() && cadiro.Contains(e.Path))
            {
                return new CreatureMapIcon(e, "ms-green.png", () => Settings.Cadiro, Settings.CadiroIcon);
            }
            if (e.HasComponent<Chest>() && perandus.Contains(e.Path))
            {
                return new ChestMapIcon(e, new HudTexture("strongbox.png", Settings.PerandusChestColor), () => Settings.PerandusChest, Settings.PerandusChestIcon);
            }
            if (e.HasComponent<Chest>() && labyrinth.Contains(e.Path))
            {
                if (e.Path.Contains("LabyrinthTreasureKey"))
                {
                    return new ChestMapIcon(e, new HudTexture("treasureicon.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.EndsWith("Chest1"))
                {
                    return new ChestMapIcon(e, new HudTexture("1.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.EndsWith("Chest2"))
                {
                    return new ChestMapIcon(e, new HudTexture("2.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.EndsWith("Chest3"))
                {
                    return new ChestMapIcon(e, new HudTexture("3.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.EndsWith("Chest4"))
                {
                    return new ChestMapIcon(e, new HudTexture("4.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.EndsWith("Chest5"))
                {
                    return new ChestMapIcon(e, new HudTexture("5.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.EndsWith("Chest6"))
                {
                    return new ChestMapIcon(e, new HudTexture("6.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.EndsWith("Chest7"))
                {
                    return new ChestMapIcon(e, new HudTexture("7.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.EndsWith("Chest8"))
                {
                    return new ChestMapIcon(e, new HudTexture("8.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.EndsWith("Chest9"))
                {
                    return new ChestMapIcon(e, new HudTexture("9.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest10"))
                {
                    return new ChestMapIcon(e, new HudTexture("10.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest11"))
                {
                    return new ChestMapIcon(e, new HudTexture("11.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest12"))
                {
                    return new ChestMapIcon(e, new HudTexture("12.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest13"))
                {
                    return new ChestMapIcon(e, new HudTexture("13.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest14"))
                {
                    return new ChestMapIcon(e, new HudTexture("14.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest15"))
                {
                    return new ChestMapIcon(e, new HudTexture("15.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest16"))
                {
                    return new ChestMapIcon(e, new HudTexture("16.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest17"))
                {
                    return new ChestMapIcon(e, new HudTexture("17.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest18"))
                {
                    return new ChestMapIcon(e, new HudTexture("18.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest19"))
                {
                    return new ChestMapIcon(e, new HudTexture("19.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest20"))
                {
                    return new ChestMapIcon(e, new HudTexture("20.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest21"))
                {
                    return new ChestMapIcon(e, new HudTexture("21.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest22"))
                {
                    return new ChestMapIcon(e, new HudTexture("22.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest23"))
                {
                    return new ChestMapIcon(e, new HudTexture("23.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest24"))
                {
                    return new ChestMapIcon(e, new HudTexture("24.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest25"))
                {
                    return new ChestMapIcon(e, new HudTexture("25.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest26"))
                {
                    return new ChestMapIcon(e, new HudTexture("26.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest27"))
                {
                    return new ChestMapIcon(e, new HudTexture("27.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest28"))
                {
                    return new ChestMapIcon(e, new HudTexture("28.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest29"))
                {
                    return new ChestMapIcon(e, new HudTexture("29.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest30"))
                {
                    return new ChestMapIcon(e, new HudTexture("30.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest31"))
                {
                    return new ChestMapIcon(e, new HudTexture("31.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest32"))
                {
                    return new ChestMapIcon(e, new HudTexture("32.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest33"))
                {
                    return new ChestMapIcon(e, new HudTexture("33.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest34"))
                {
                    return new ChestMapIcon(e, new HudTexture("34.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest35"))
                {
                    return new ChestMapIcon(e, new HudTexture("35.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest36"))
                {
                    return new ChestMapIcon(e, new HudTexture("36.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest37"))
                {
                    return new ChestMapIcon(e, new HudTexture("37.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest38"))
                {
                    return new ChestMapIcon(e, new HudTexture("38.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest39"))
                {
                    return new ChestMapIcon(e, new HudTexture("39.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                if (e.Path.Contains("Chest40"))
                {
                    return new ChestMapIcon(e, new HudTexture("40.png"), () => Settings.Labyrinth, Settings.LabyrinthIcon);
                }
                return new ChestMapIcon(e, new HudTexture("strongbox.png"), () => Settings.Strongboxes, Settings.StrongboxesIcon);
            }
            if (e.HasComponent<Chest>() && !e.GetComponent<Chest>().IsOpened)
            {
                if (e.Path.Contains("BreachChest"))
                {
                    return new ChestMapIcon(e, new HudTexture("strongbox.png", Settings.BreachChestColor), () => Settings.BreachChest, Settings.BreachChestIcon);
                }

                return e.GetComponent<Chest>().IsStrongbox
                    ? new ChestMapIcon(e, new HudTexture("strongbox.png",
                    e.GetComponent<ObjectMagicProperties>().Rarity), () => Settings.Strongboxes, Settings.StrongboxesIcon)
                    : new ChestMapIcon(e, new HudTexture("chest.png"), () => Settings.Chests, Settings.ChestsIcon);
            }
            return null;
        }
    }
}