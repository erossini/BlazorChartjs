namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Plugins
    /// </summary>
    public class Plugins
    {
        /// <summary>
        /// Gets or sets the data labels.
        /// </summary>
        /// <value>The data labels.</value>
        [JsonPropertyName("datalabels")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DataLabels? DataLabels { get; set; }

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

        /// <summary>
        /// Gets or sets the crosshair.
        /// </summary>
        /// <value>
        /// The crosshair.
        /// </value>
        [JsonPropertyName("crosshair")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Crosshair? Crosshair { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("title")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Title? Title { get; set; }

        /// <summary>
        /// Gets or sets the zoom.
        /// </summary>
        /// <value>
        /// The zoom.
        /// </value>
        [JsonPropertyName("zoom")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Zoom? Zoom { get; set; }
    }
}