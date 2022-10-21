namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Wheel
    /// </summary>
    public class Wheel
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

        /// <summary>Gets or sets the modifier key.
        /// Modifier key required for panning with mouse</summary>
        /// <value>The modifier key can have one of those values: ctrl, alt, shift, meta. Default: null</value>
        [JsonPropertyName("modifierKey")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ModifierKey { get; set; }

        /// <summary>
        /// Gets or sets the factor of zoom speed via mouse wheel
        /// </summary>
        /// <value>
        /// The factor of zoom speed via mouse wheel. Default: 0.1M
        /// </value>
        [JsonPropertyName("speed")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Speed { get; set; } = 0.1M;
    }
}