namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Pan
    /// </summary>
    public class Pan
    {
        /// <summary>
        /// Gets or sets enable panning
        /// </summary>
        /// <value>
        /// The enabled.
        /// </value>
        [JsonPropertyName("enabled")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the mode how allowed panning directions
        /// </summary>
        /// <value>
        /// The mode can have one of those values: x, y, xy (default)
        /// </value>
        [JsonPropertyName("mode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Mode { get; set; } = "xy";

        /// <summary>Gets or sets the modifier key.
        /// Modifier key required for panning with mouse</summary>
        /// <value>The modifier key can have one of those values: ctrl, alt, shift, meta. Default: null</value>
        [JsonPropertyName("modifierKey")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ModifierKey { get; set; }

        /// <summary>
        /// Gets or sets the over scale mode.
        /// Which of the enabled panning directions should only be available when the mouse cursor is over a scale for that axis.
        /// </summary>
        /// <value>
        /// The over scale mode can have one of those values: x, y, xy. Default: Undefined
        /// </value>
        [JsonPropertyName("overScaleMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? OverScaleMode { get; set; }

        /// <summary>
        /// Gets or sets the threshold.
        /// </summary>
        /// <value>
        /// The threshold. Default: 10
        /// </value>
        [JsonPropertyName("threshold")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Threshold { get; set; } = 10;
    }
}