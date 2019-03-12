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

        private static readonly List<string> masters_without_npc_component = new List<string>
        {
            "Metadata/Terrain/Leagues/Incursion/Objects/IncursionPortal1"
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
            var ePath = e.Path;

            if (e.HasComponent<NPC>() && masters.Contains(ePath))
            {
                return new CreatureMapIcon(e, "ms-cyan.png", () => Settings.Masters, Settings.MastersIcon);
            }
            if (masters_without_npc_component.Contains(ePath))
            {
                return new CreatureMapIcon(e, "ms-cyan.png", () => Settings.Masters, Settings.MastersIcon);
            }
            if (e.HasComponent<NPC>() && cadiro.Contains(ePath))
            {
                return new CreatureMapIcon(e, "ms-green.png", () => Settings.Cadiro, Settings.CadiroIcon);
            }
            if (e.HasComponent<Chest>() && perandus.Contains(ePath))
            {
                return new ChestMapIcon(e, new HudTexture("strongbox.png", Settings.PerandusChestColor), () => Settings.PerandusChest, Settings.PerandusChestIconSize);
            }
            if (e.HasComponent<Chest>() && !e.GetComponent<Chest>().IsOpened)
            {
	            if (ePath.Contains("BreachChest"))
                {
                    return new ChestMapIcon(e, new HudTexture("strongbox.png", Settings.BreachChestColor), () => Settings.BreachChest, Settings.BreachChestIcon);
                }

                if (ePath == "Metadata/Chests/Prophecy/Divination")//From prophecy The Fortune Teller's Collection
                {
                    return new ChestMapIcon(e, new HudTexture("strongboxes/chest_divination.png",
                                                              e.GetComponent<ObjectMagicProperties>().Rarity), () => Settings.Strongboxes, Settings.StrongboxesIconSize);
                }
	            if (e.GetComponent<Chest>().IsStrongbox)
	            {
		            var chestIcon = "chest.png";
		            switch (ePath)
		            {
		                case "Metadata/Chests/StrongBoxes/StrongboxDivination":
		                    chestIcon = "chest_divination.png"; break;
			            case "Metadata/Chests/StrongBoxes/Ornate":
				            chestIcon = "chest_ornate.png"; break;
			            case "Metadata/Chests/StrongBoxes/Large":
				            chestIcon = "chest_large.png"; break;
			            case "Metadata/Chests/StrongBoxes/Jeweller":
				            chestIcon = "chest_jewelers.png"; break;
			            case "Metadata/Chests/StrongBoxes/Gemcutter":
				            chestIcon = "chest_gemscutter.png"; break;
			            case "Metadata/Chests/StrongBoxes/Artisan":
				            chestIcon = "chest_quality.png"; break;
			            case "Metadata/Chests/StrongBoxes/Armory":
				            chestIcon = "chest_weapon.png"; break;
						default:
							if(ePath.StartsWith("Metadata/Chests/StrongBoxes/Cartographer"))
								chestIcon = "chest_map.png";
							else if(ePath.StartsWith("Metadata/Chests/StrongBoxes/Arcanist"))
								chestIcon = "chest_no_quality.png"; 
							break;
		            }


		            return new ChestMapIcon(e, new HudTexture("strongboxes/" + chestIcon,
				            e.GetComponent<ObjectMagicProperties>().Rarity), () => Settings.Strongboxes, Settings.StrongboxesIconSize);
	            }

		        return new ChestMapIcon(e, new HudTexture("chest.png"), () => Settings.Chests, Settings.ChestsIcon);
            }

            if (ePath == "Metadata/Terrain/Leagues/Synthesis/Objects/SynthesisAirlockController")
            {
                return new ChestMapIcon(e, new HudTexture("strongbox.png", Settings.BreachChestColor), () => Settings.BreachChest, Settings.BreachChestIcon);
            }
            return null;
        }
    }
}
