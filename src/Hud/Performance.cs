using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PoeHUD.Hud.Settings;

namespace PoeHUD.Hud.Performance
{
    public sealed class PerformanceSettings : SettingsBase
    {
        public PerformanceSettings()
        {
            Enable = true;

            UpdateEntityDataLimit = new RangeNode<int>(25, 10, 200);
            RenderLimit = new RangeNode<int>(60, 10, 200);
            LoopLimit = new RangeNode<int>(1, 1, 300);
            Cache = new ToggleNode(true);
        }


        public RangeNode<int> UpdateEntityDataLimit { get; set; }
        public RangeNode<int> RenderLimit { get; set; }
        public RangeNode<int> LoopLimit { get; set; }
        public ToggleNode Cache { get; set; }
    }
}
