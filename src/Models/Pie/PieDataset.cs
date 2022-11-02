namespace PSC.Blazor.Components.Chartjs.Models.Pie
{
    /// <summary>
    /// Pie Dataset
    /// </summary>
    /// <seealso cref="PSC.Blazor.Components.Chartjs.Models.Common.Dataset" />
    public class PieDataset : Dataset
    {
        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>
        /// <value>
        /// The color of the background.
        /// </value>
        [JsonPropertyName("backgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> BackgroundColor { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the arc offset when hovered (in pixels)
        /// </summary>
        /// <value>
        /// The hover offset.
        /// </value>
        [JsonPropertyName("hoverOffset")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? HoverOffset { get; set; }
    }
}
