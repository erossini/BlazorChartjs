namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Plugins
    /// </summary>
    public class Plugins
    {
        /// <summary>
        /// Gets or sets the legend.
        /// </summary>
        /// <value>
        /// The legend.
        /// </value>
        [JsonPropertyName("legend")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Legend? Legend { get; set; } = new Legend();

        /// <summary>
        /// Gets or sets the tooltip.
        /// </summary>
        /// <value>
        /// The tooltip.
        /// </value>
        [JsonPropertyName("tooltip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Tooltip? Tooltip { get; set; }

        [JsonPropertyName("crosshair")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Crosshair? Crosshair { get; set; }
    }
}