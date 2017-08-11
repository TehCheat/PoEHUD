using PoeHUD.Hud.Settings;
using SharpDX;

namespace PoeHUD.Hud.Trackers
{
    public sealed class PoiTrackerSettings : SettingsBase
    {
        public PoiTrackerSettings()
        {
            Enable = true;
            Masters = true;
            Cadiro = true;
            Chests = true;
            Strongboxes = true;
            PerandusChest = true;
            BreachChest = true;
            Labyrinth = true;

            MastersIcon = new RangeNode<int>(8, 1, 16);
            CadiroIcon = new RangeNode<int>(8, 1, 16);
            StrongboxesIcon = new RangeNode<int>(14, 1, 28);
            ChestsIcon = new RangeNode<int>(3, 1, 6);
            PerandusChestIcon = new RangeNode<int>(14, 1, 28);
            BreachChestIcon = new RangeNode<int>(10, 1, 28);
            PerandusChestColor = new ColorBGRA(153, 255, 51, 255);
            BreachChestColor = new ColorBGRA(240, 100, 255, 255);
            LabyrinthIcon = new RangeNode<int>(14, 1, 28);
        }

        public ToggleNode Masters { get; set; }
        public ToggleNode Cadiro { get; set; }
        public ToggleNode Chests { get; set; }
        public ToggleNode Strongboxes { get; set; }
        public ToggleNode PerandusChest { get; set; }
        public ToggleNode BreachChest { get; set; }
        public RangeNode<int> MastersIcon { get; set; }
        public RangeNode<int> CadiroIcon { get; set; }
        public RangeNode<int> ChestsIcon { get; set; }
        public RangeNode<int> StrongboxesIcon { get; set; }
        public RangeNode<int> PerandusChestIcon { get; set; }
        public RangeNode<int> BreachChestIcon { get; set; }
        public ColorNode PerandusChestColor { get; set; }
        public ColorNode BreachChestColor { get; set; }
        public ToggleNode Labyrinth { get; set; }
        public RangeNode<int> LabyrinthIcon { get; set; }
    }
}
