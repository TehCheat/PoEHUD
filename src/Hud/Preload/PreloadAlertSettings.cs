using PoeHUD.Hud.Settings;
using SharpDX;

namespace PoeHUD.Hud.Preload
{
    public sealed class PreloadAlertSettings : SettingsBase
    {
        public PreloadAlertSettings()
        {
            Enable = true;
            Masters = true;
            Exiles = true;
            Strongboxes = true;
            PerandusBoxes = true;
            Essence = true;
            CorruptedArea = true;
            CorruptedTitle = true;
            TextSize = new RangeNode<int>(16, 10, 50);
            BackgroundColor = new ColorBGRA(0, 0, 0, 255);
            DefaultTextColor = new ColorBGRA(210, 210, 210, 255);
            AreaTextColor = new ColorBGRA(150, 200, 250, 255);
            CorruptedAreaColor = new ColorBGRA(208, 31, 144, 255);

            RemnantOfCorruption = new ColorBGRA(255, 255, 0, 255);
            EssenceOfAnger = new ColorBGRA(255, 255, 0, 255);
            EssenceOfHatred = new ColorBGRA(255, 255, 0, 255);
            EssenceOfWrath = new ColorBGRA(255, 255, 0, 255);
            EssenceOfMisery = new ColorBGRA(208, 31, 144, 255);
            EssenceOfTorment = new ColorBGRA(255, 255, 0, 255);
            EssenceOfFear = new ColorBGRA(255, 255, 0, 255);
            EssenceOfSuffering = new ColorBGRA(255, 255, 0, 255);
            EssenceOfEnvy = new ColorBGRA(208, 31, 144, 255);
            EssenceOfZeal = new ColorBGRA(255, 255, 0, 255);
            EssenceOfLoathing = new ColorBGRA(255, 255, 0, 255);
            EssenceOfScorn = new ColorBGRA(208, 31, 144, 255);
            EssenceOfSorrow = new ColorBGRA(255, 255, 0, 255);
            EssenceOfContempt = new ColorBGRA(255, 255, 0, 255);
            EssenceOfRage = new ColorBGRA(255, 255, 0, 255);
            EssenceOfDread = new ColorBGRA(208, 31, 144, 255);
            EssenceOfGreed = new ColorBGRA(208, 31, 144, 255);
            EssenceOfWoe = new ColorBGRA(208, 31, 144, 255);
            EssenceOfDoubt = new ColorBGRA(255, 255, 0, 255);
            EssenceOfSpite = new ColorBGRA(255, 255, 0, 255);
            EssenceOfHysteria = new ColorBGRA(255, 255, 0, 255);
            EssenceOfInsanity = new ColorBGRA(255, 255, 0, 255);
            EssenceOfHorror = new ColorBGRA(255, 255, 0, 255);
            EssenceOfDelirium = new ColorBGRA(255, 255, 0, 255);
            EssenceOfAnguish = new ColorBGRA(255, 255, 0, 255);

            CadiroTrader = new ColorBGRA(255, 128, 0, 255);
            PerandusChestStandard = new ColorBGRA(153, 255, 51, 255);
            PerandusChestRarity = new ColorBGRA(153, 255, 51, 255);
            PerandusChestQuantity = new ColorBGRA(153, 255, 51, 255);
            PerandusChestCoins = new ColorBGRA(153, 255, 51, 255);
            PerandusChestJewellery = new ColorBGRA(153, 255, 51, 255);
            PerandusChestGems = new ColorBGRA(153, 255, 51, 255);
            PerandusChestCurrency = new ColorBGRA(153, 255, 51, 255);
            PerandusChestInventory = new ColorBGRA(153, 255, 51, 255);
            PerandusChestDivinationCards = new ColorBGRA(153, 255, 51, 255);
            PerandusChestKeepersOfTheTrove = new ColorBGRA(153, 255, 51, 255);
            PerandusChestUniqueItem = new ColorBGRA(153, 255, 51, 255);
            PerandusChestMaps = new ColorBGRA(153, 255, 51, 255);
            PerandusChestFishing = new ColorBGRA(153, 255, 51, 255);
            PerandusManorUniqueChest = new ColorBGRA(153, 255, 51, 255);
            PerandusManorCurrencyChest = new ColorBGRA(153, 255, 51, 255);
            PerandusManorMapsChest = new ColorBGRA(153, 255, 51, 255);
            PerandusManorJewelryChest = new ColorBGRA(153, 255, 51, 255);
            PerandusManorDivinationCardsChest = new ColorBGRA(153, 255, 51, 255);
            PerandusManorLostTreasureChest = new ColorBGRA(153, 255, 51, 255);

            MasterZana = new ColorBGRA(255, 255, 0, 255);
			MasterNiko = new ColorBGRA(100, 255, 255, 255);
			MasterEinhar = new ColorBGRA(100, 255, 255, 255);
			MasterAlva = new ColorBGRA(100, 255, 255, 255);
			MasterJun = new ColorBGRA(100, 255, 255, 255);
			MasterCatarina = new ColorBGRA(100, 255, 255, 255);
            MasterTora = new ColorBGRA(100, 255, 255, 255);
            MasterVorici = new ColorBGRA(100, 255, 255, 255);
            MasterHaku = new ColorBGRA(100, 255, 255, 255);
            MasterElreon = new ColorBGRA(100, 255, 255, 255);
            MasterVagan = new ColorBGRA(100, 255, 255, 255);
            MasterKrillson = new ColorBGRA(255, 0, 255, 255);

            ArcanistStrongbox = new ColorBGRA(255, 0, 255, 255);
            ArtisanStrongbox = new ColorBGRA(210, 210, 210, 255);
            CartographerStrongbox = new ColorBGRA(255, 255, 0, 255);
            DivinerStrongbox = new ColorBGRA(255, 0, 255, 255);
            GemcutterStrongbox = new ColorBGRA(27, 162, 155, 255);
            JewellerStrongbox = new ColorBGRA(210, 210, 210, 255);
            BlacksmithStrongbox = new ColorBGRA(210, 210, 210, 255);
            ArmourerStrongbox = new ColorBGRA(210, 210, 210, 255);
            OrnateStrongbox = new ColorBGRA(210, 210, 210, 255);
            LargeStrongbox = new ColorBGRA(210, 210, 210, 255);
            PerandusStrongbox = new ColorBGRA(175, 96, 37, 255);
            KaomStrongbox = new ColorBGRA(175, 96, 37, 255);
            MalachaiStrongbox = new ColorBGRA(175, 96, 37, 255);
            EpicStrongbox = new ColorBGRA(175, 96, 37, 255);
            SimpleStrongbox = new ColorBGRA(210, 210, 210, 255);

            OrraGreengate = new ColorBGRA(254, 192, 118, 255);
            ThenaMoga = new ColorBGRA(254, 192, 118, 255);
            AntalieNapora = new ColorBGRA(254, 192, 118, 255);
            TorrOlgosso = new ColorBGRA(254, 192, 118, 255);
            ArmiosBell = new ColorBGRA(254, 192, 118, 255);
            ZacharieDesmarais = new ColorBGRA(254, 192, 118, 255);
            MinaraAnenima = new ColorBGRA(254, 192, 118, 255);
            IgnaPhoenix = new ColorBGRA(254, 192, 118, 255);
            JonahUnchained = new ColorBGRA(254, 192, 118, 255);
            DamoiTui = new ColorBGRA(254, 192, 118, 255);
            XandroBlooddrinker = new ColorBGRA(254, 192, 118, 255);
            VickasGiantbone = new ColorBGRA(254, 192, 118, 255);
            EoinGreyfur = new ColorBGRA(254, 192, 118, 255);
            TinevinHighdove = new ColorBGRA(254, 192, 118, 255);
            MagnusStonethorn = new ColorBGRA(254, 192, 118, 255);
            IonDarkshroud = new ColorBGRA(254, 192, 118, 255);
            AshLessard = new ColorBGRA(254, 192, 118, 255);
            WilorinDemontamer = new ColorBGRA(254, 192, 118, 255);
            AugustinaSolaria = new ColorBGRA(254, 192, 118, 255);
            DenaLorenni = new ColorBGRA(254, 192, 118, 255);
            VanthAgiel = new ColorBGRA(254, 192, 118, 255);
            LaelFuria = new ColorBGRA(254, 192, 118, 255);
            OyraOna = new ColorBGRA(254, 192, 118, 255);
            BoltBrownfur = new ColorBGRA(254, 192, 118, 255);
            AilentiaRac = new ColorBGRA(254, 192, 118, 255);
            UlyssesMorvant = new ColorBGRA(254, 192, 118, 255);
            AurelioVoidsinger = new ColorBGRA(254, 192, 118, 255);
        }

        public ColorNode CadiroTrader { get; set; }

        public ToggleNode Essence { get; set; }
        public ColorNode RemnantOfCorruption { get; set; }
        public ColorNode EssenceOfAnger { get; set; }
        public ColorNode EssenceOfHatred { get; set; }
        public ColorNode EssenceOfWrath { get; set; }
        public ColorNode EssenceOfMisery { get; set; }
        public ColorNode EssenceOfTorment { get; set; }
        public ColorNode EssenceOfFear { get; set; }
        public ColorNode EssenceOfSuffering { get; set; }
        public ColorNode EssenceOfEnvy { get; set; }
        public ColorNode EssenceOfZeal { get; set; }
        public ColorNode EssenceOfLoathing { get; set; }
        public ColorNode EssenceOfScorn { get; set; }
        public ColorNode EssenceOfSorrow { get; set; }
        public ColorNode EssenceOfContempt { get; set; }
        public ColorNode EssenceOfRage { get; set; }
        public ColorNode EssenceOfDread { get; set; }
        public ColorNode EssenceOfGreed { get; set; }
        public ColorNode EssenceOfWoe { get; set; }
        public ColorNode EssenceOfDoubt { get; set; }
        public ColorNode EssenceOfSpite { get; set; }
        public ColorNode EssenceOfHysteria { get; set; }
        public ColorNode EssenceOfInsanity { get; set; }
        public ColorNode EssenceOfHorror { get; set; }
        public ColorNode EssenceOfDelirium { get; set; }
        public ColorNode EssenceOfAnguish { get; set; }

        public ColorNode PerandusChestStandard { get; set; }
        public ColorNode PerandusChestRarity { get; set; }
        public ColorNode PerandusChestQuantity { get; set; }
        public ColorNode PerandusChestCoins { get; set; }
        public ColorNode PerandusChestJewellery { get; set; }
        public ColorNode PerandusChestGems { get; set; }
        public ColorNode PerandusChestCurrency { get; set; }
        public ColorNode PerandusChestInventory { get; set; }
        public ColorNode PerandusChestDivinationCards { get; set; }
        public ColorNode PerandusChestKeepersOfTheTrove { get; set; }
        public ColorNode PerandusChestUniqueItem { get; set; }
        public ColorNode PerandusChestMaps { get; set; }
        public ColorNode PerandusChestFishing { get; set; }
        public ColorNode PerandusManorUniqueChest { get; set; }
        public ColorNode PerandusManorCurrencyChest { get; set; }
        public ColorNode PerandusManorMapsChest { get; set; }
        public ColorNode PerandusManorJewelryChest { get; set; }
        public ColorNode PerandusManorDivinationCardsChest { get; set; }
        public ColorNode PerandusManorLostTreasureChest { get; set; }
        public ToggleNode PerandusBoxes { get; set; }
        public ToggleNode CorruptedArea { get; set; }
        public ToggleNode CorruptedTitle { get; set; }
        public ToggleNode Masters { get; set; }
        public ToggleNode Exiles { get; set; }
        public ToggleNode Strongboxes { get; set; }
        public RangeNode<int> TextSize { get; set; }
        public ColorNode BackgroundColor { get; set; }
        public ColorNode DefaultTextColor { get; set; }
        public ColorNode AreaTextColor { get; set; }
        public ColorNode CorruptedAreaColor { get; set; }
        public ColorNode MasterZana { get; set; }
		public ColorNode MasterNiko { get; set; }
		public ColorNode MasterEinhar { get; set; }
		public ColorNode MasterAlva { get; set; }
		public ColorNode MasterJun { get; set; }
		public ColorNode MasterCatarina { get; set; }
        public ColorNode MasterTora { get; set; }
        public ColorNode MasterVorici { get; set; }
        public ColorNode MasterHaku { get; set; }
        public ColorNode MasterElreon { get; set; }
        public ColorNode MasterVagan { get; set; }
        public ColorNode MasterKrillson { get; set; }
        public ColorNode ArcanistStrongbox { get; set; }
        public ColorNode ArtisanStrongbox { get; set; }
        public ColorNode CartographerStrongbox { get; set; }
        public ColorNode DivinerStrongbox { get; set; }
        public ColorNode GemcutterStrongbox { get; set; }
        public ColorNode JewellerStrongbox { get; set; }
        public ColorNode BlacksmithStrongbox { get; set; }
        public ColorNode ArmourerStrongbox { get; set; }
        public ColorNode OrnateStrongbox { get; set; }
        public ColorNode LargeStrongbox { get; set; }
        public ColorNode PerandusStrongbox { get; set; }
        public ColorNode KaomStrongbox { get; set; }
        public ColorNode MalachaiStrongbox { get; set; }
        public ColorNode EpicStrongbox { get; set; }
        public ColorNode SimpleStrongbox { get; set; }
        public ColorNode OrraGreengate { get; set; }
        public ColorNode ThenaMoga { get; set; }
        public ColorNode AntalieNapora { get; set; }
        public ColorNode TorrOlgosso { get; set; }
        public ColorNode ArmiosBell { get; set; }
        public ColorNode ZacharieDesmarais { get; set; }
        public ColorNode MinaraAnenima { get; set; }
        public ColorNode IgnaPhoenix { get; set; }
        public ColorNode JonahUnchained { get; set; }
        public ColorNode DamoiTui { get; set; }
        public ColorNode XandroBlooddrinker { get; set; }
        public ColorNode VickasGiantbone { get; set; }
        public ColorNode EoinGreyfur { get; set; }
        public ColorNode TinevinHighdove { get; set; }
        public ColorNode MagnusStonethorn { get; set; }
        public ColorNode IonDarkshroud { get; set; }
        public ColorNode AshLessard { get; set; }
        public ColorNode WilorinDemontamer { get; set; }
        public ColorNode AugustinaSolaria { get; set; }
        public ColorNode DenaLorenni { get; set; }
        public ColorNode VanthAgiel { get; set; }
        public ColorNode LaelFuria { get; set; }
        public ColorNode OyraOna { get; set; }
        public ColorNode BoltBrownfur { get; set; }
        public ColorNode AilentiaRac { get; set; }
        public ColorNode UlyssesMorvant { get; set; }
        public ColorNode AurelioVoidsinger { get; set; }
    }
}