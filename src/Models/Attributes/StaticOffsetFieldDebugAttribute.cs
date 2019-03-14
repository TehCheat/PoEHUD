namespace PoeHUD.Models.Attributes
{
    using System;

    /// <summary>
    /// Used by ImguiDebug plugin. Adds a slider to static field to fix some offset by dragging it
    /// Implements the <see cref="System.Attribute" />
    /// </summary>
    /// <seealso cref="System.Attribute" />
    public class StaticOffsetFieldDebugAttribute : Attribute
    {
        public int SliderMin = -1;
        public int SliderMax;

        public StaticOffsetFieldDebugAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticOffsetFieldDebugAttribute"/> class.
        /// </summary>
        /// <param name="sliderMin">You can set the slider min max using this.</param>
        public StaticOffsetFieldDebugAttribute(int sliderMin, int sliderMax)
        {
            SliderMin = sliderMin;
            SliderMax = sliderMax;
        }
    }
}
