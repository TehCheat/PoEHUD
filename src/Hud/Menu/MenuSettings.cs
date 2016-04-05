using PoeHUD.Hud.Settings;
using SharpDX;

namespace PoeHUD.Hud.Menu
{
    public sealed class MenuSettings : SettingsBase
    {
        public MenuSettings()
        {
            Enable = true;
            X = 10; Y = 85;
            ShowMenu = true;
            TitleName = "X";
            TitleFontColor = new ColorBGRA(255, 0, 0, 255);
            EnabledBoxColor = new ColorBGRA(128, 128, 128, 255);
            DisabledBoxColor = new ColorBGRA(128, 0, 0, 230);
            BackgroundColor = new ColorBGRA(128, 0, 0, 230);
            MenuFontColor = new ColorBGRA(220, 190, 130, 255);
            SliderColor = new ColorBGRA(128, 128, 128, 255);
            TitleFontSize = new RangeNode<int>(16, 10, 20);
            MenuFontSize = new RangeNode<int>(16, 10, 20);
            PickerFontSize = new RangeNode<int>(16, 10, 20);
        }

        public string TitleName { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public ToggleNode ShowMenu { get; set; }
        public ColorNode TitleFontColor { get; set; }
        public ColorNode EnabledBoxColor { get; set; }
        public ColorNode DisabledBoxColor { get; set; }
        public ColorNode BackgroundColor { get; set; }
        public ColorNode MenuFontColor { get; set; }
        public ColorNode SliderColor { get; set; }
        public RangeNode<int> TitleFontSize { get; set; }
        public RangeNode<int> MenuFontSize { get; set; }
        public RangeNode<int> PickerFontSize { get; set; }
    }
}