using System.Reflection.Emit;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Zoom options
    /// </summary>
    public class ZoomOptions
    {

        #region Events

        /// <summary>
        /// Gets or sets the on zoom event.
        /// </summary>
        /// <value>The on zoom event.</value>
        [JsonIgnore]
        public Func<ZoomContext, ValueTask>? OnZoomAsync { get; set; }

        /// <summary>
        /// Gets or sets the on zoom complete event.
        /// </summary>
        /// <value>The on zoom complete event.</value>
        [JsonIgnore]
        public Func<ZoomContext, ValueTask>? OnZoomCompleteAsync { get; set; }
        #endregion

        [JsonInclude]
        [JsonPropertyName("onZoomEnable")]
        public bool OnZoomEnable => OnZoomAsync != null;

        [JsonInclude]
        [JsonPropertyName("onZoomCompleteEnable")]
        public bool OnZoomCompleteEnable => OnZoomCompleteAsync != null;

        /// <summary>
        /// Gets or sets the drag.
        /// </summary>
        /// <value>
        /// The drag.
        /// </value>
        [JsonPropertyName("drag")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Drag? Drag { get; set; }

        /// <summary>
        /// Gets or sets the pinch.
        /// </summary>
        /// <value>
        /// The pinch.
        /// </value>
        [JsonPropertyName("pinch")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Pinch? Pinch { get; set; }

        /// <summary>
        /// Gets or sets the wheel.
        /// </summary>
        /// <value>
        /// The wheel.
        /// </value>
        [JsonPropertyName("wheel")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Wheel? Wheel { get; set; }

        /// <summary>
        /// Allowed zoom directions 'x' | 'y' | 'xy'.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        [JsonPropertyName("mode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Mode { get; set; }

        /// <summary>
        /// Which of the enabled zooming directions should only be available when the mouse cursor is over a scale for that axis 'x' | 'y' | 'xy'.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        [JsonPropertyName("scaleMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ScaleMode { get; set; }

        /// <summary>
        /// Allowed zoom directions when the mouse cursor is over a scale for that axis 'x' | 'y' | 'xy'.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        [JsonPropertyName("overScaleMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? OverScaleMode { get; set; }

        /// <summary>
        /// Gets or sets the limits.
        /// </summary>
        /// <value>
        /// The limits.
        /// </value>
        [JsonPropertyName("limits")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Limits? Limits { get; set; }

    }
}
