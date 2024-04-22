namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Zoom options
    /// </summary>
    public class ZoomOptions
    {
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
    }
}
