using PoeHUD.Hud.Settings;
using SharpDX;

namespace PoeHUD.Hud.XpRate
{
    public sealed class XpRateSettings : SettingsBase
    {
        public XpRateSettings()
        {
            Enable = true;
            OnlyAreaName = false;
            ShowLatency = true;
            ShowFps = true;
            ShowInTown = true;
            TextSize = new RangeNode<int>(16, 10, 20);
            BackgroundColor = new ColorBGRA(0, 0, 0, 255);
            AreaTextColor = new ColorBGRA(140, 200, 255, 255);
            XphTextColor = new ColorBGRA(220, 190, 130, 255);
            TimeLeftColor = new ColorBGRA(220, 190, 130, 255);
            FpsTextColor = new ColorBGRA(220, 190, 130, 255);
            TimerTextColor = new ColorBGRA(220, 190, 130, 255);
            LatencyTextColor = new ColorBGRA(220, 190, 130, 255);
            DelveInfoTextcolor = new ColorBGRA(220, 190, 130, 255);
        }

        public ToggleNode ShowInTown { get; set; }
        public ToggleNode ShowLatency { get; set; }
        public ToggleNode ShowFps { get; set; }
        public ToggleNode OnlyAreaName { get; set; }
        public RangeNode<int> TextSize { get; set; }
        public ColorNode BackgroundColor { get; set; }
        public ColorNode AreaTextColor { get; set; }
        public ColorNode XphTextColor { get; set; }
        public ColorNode TimeLeftColor { get; set; }
        public ColorNode FpsTextColor { get; set; }
        public ColorNode TimerTextColor { get; set; }
        public ColorNode LatencyTextColor { get; set; }
        public ColorNode DelveInfoTextcolor { get; set; }
    }
}