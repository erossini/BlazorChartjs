namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Zoom
    /// </summary>
    public class Zoom
    {
        /// <summary>
        /// Gets or sets zooming via mouse wheel
        /// </summary>
        /// <value>
        /// The enabled.
        /// </value>
        [JsonPropertyName("enabled")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the limits.
        /// </summary>
        /// <value>
        /// The limits.
        /// </value>
        [JsonPropertyName("limits")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Limits? Limits { get; set; }

        /// <summary>
        /// Gets or sets the zoom direction
        /// </summary>
        /// <value>
        /// The mode. Values: x, y, xy
        /// </value>
        [JsonPropertyName("mode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Mode { get; set; } = "xy";

        /// <summary>
        /// Gets or sets the over scale mode.
        /// </summary>
        /// <value>
        /// The over scale mode. Values: x, y, xy
        /// </value>
        [JsonPropertyName("overScaleMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? OverScaleMode { get; set; }

        /// <summary>
        /// Gets or sets the pan.
        /// </summary>
        /// <value>
        /// The pan.
        /// </value>
        [JsonPropertyName("pan")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Pan? Pan { get; set; }

        /// <summary>
        /// Gets or sets the zoom options.
        /// </summary>
        /// <value>
        /// The zoom options.
        /// </value>
        [JsonPropertyName("zoom")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ZoomOptions? ZoomOptions { get; set; }
    }
}