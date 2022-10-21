namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Crosshair line
    /// </summary>
    public sealed class CrosshairLine
    {
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        [JsonPropertyName("color")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Color { get; set; }

        /// <summary>
        /// Gets or sets the dash.
        /// </summary>
        /// <value>
        /// The dash.
        /// </value>
        [JsonPropertyName("dash")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int[]? Dash { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        [JsonPropertyName("width")]
        public int Width { get; set; } = 1;
    }
}