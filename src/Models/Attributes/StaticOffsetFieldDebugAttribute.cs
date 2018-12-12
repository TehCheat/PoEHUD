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
        public int SliderOffsetMinMaxDelta = -1;
        public StaticOffsetFieldDebugAttribute() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticOffsetFieldDebugAttribute"/> class.
        /// </summary>
        /// <param name="sliderOffsetMinMaxDelta">You can set the slider min max using this.</param>
        public StaticOffsetFieldDebugAttribute(int sliderOffsetMinMaxDelta)
        {
            SliderOffsetMinMaxDelta = sliderOffsetMinMaxDelta;
        }
    }
}
