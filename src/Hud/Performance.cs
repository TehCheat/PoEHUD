using PoeHUD.Hud.Settings;

namespace PoeHUD.Hud.Performance
{
    public sealed class  PerformanceSettings: SettingsBase
    {


        public PerformanceSettings()
        {
            Enable = true;
           
            UpdateEntityDataLimit = new RangeNode<int>(25,10,200);
            UpdateAreaLimit = new RangeNode<int>(100,25,1000);
            UpdateIngemeStateLimit = new RangeNode<int>(100,25,1000);
            IterCoroutinePerLoop = new RangeNode<int>(3,1,20);
            RenderLimit = new RangeNode<int>(60, 10,200);
            LoopLimit = new RangeNode<int>(5, 1,300);
            ParallelCoroutineLimit = new RangeNode<int>(3, 1,300);
            DpsUpdateTime = new RangeNode<int>(200, 20,600);
            Cache = new ToggleNode(true);
            ParallelEntityUpdate = new ToggleNode(false);
            AlwaysForeground = new ToggleNode(false); 
        }


        public RangeNode<int> UpdateEntityDataLimit { get; set; }
        public RangeNode<int> IterCoroutinePerLoop { get; set; }
        public RangeNode<int> UpdateIngemeStateLimit { get; set; }
        public RangeNode<int> UpdateAreaLimit { get; set; }
        public RangeNode<int> RenderLimit { get; set; }
        public RangeNode<int> LoopLimit { get; set; }
        public RangeNode<int> ParallelCoroutineLimit { get; set; }
        public RangeNode<int> DpsUpdateTime { get; set; }
        public ToggleNode Cache { get; set; }
        public ToggleNode ParallelEntityUpdate { get; set; }
        public ToggleNode AlwaysForeground { get; set; } 
        
    }
}
