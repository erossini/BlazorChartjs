namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Crosshair
    /// </summary>
    public sealed class Crosshair
    {
        /// <summary>
        /// Gets or sets the cursor.
        /// </summary>
        /// <value>
        /// The cursor.
        /// </value>
        [JsonPropertyName("cursor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Cursor { get; set; }

        /// <summary>
        /// Gets or sets the horizontal.
        /// </summary>
        /// <value>
        /// The horizontal.
        /// </value>
        [JsonPropertyName("horizontal")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CrosshairLine? Horizontal { get; set; }

        /// <summary>
        /// Gets or sets the vertical.
        /// </summary>
        /// <value>
        /// The vertical.
        /// </value>
        [JsonPropertyName("vertical")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CrosshairLine? Vertical { get; set; }
    }
}