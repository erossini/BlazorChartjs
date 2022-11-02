namespace PSC.Blazor.Components.Chartjs.Models.Bar
{
    /// <summary>
    /// Bar Dataset
    /// </summary>
    /// <seealso cref="PSC.Blazor.Components.Chartjs.Models.Common.Dataset" />
    public class BarDataset : Dataset
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
        /// Gets or sets the color of the border.
        /// </summary>
        /// <value>
        /// The color of the background.
        /// </value>
        [JsonPropertyName("borderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> BorderColor { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the width of the border.
        /// </summary>
        /// <value>
        /// The width of the border.
        /// </value>
        [JsonPropertyName("borderWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? BorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the fill.
        /// </summary>
        /// <value>
        /// The fill.
        /// </value>
        [JsonPropertyName("fill")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Fill { get; set; }

        /// <summary>
        /// Gets or sets the background color hover.
        /// </summary>
        /// <value>
        /// The background color hover.
        /// </value>
        [JsonPropertyName("hoverBackgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> HoverBackgroundColor { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the stack.
        /// </summary>
        /// <value>
        /// The stack.
        /// </value>
        [JsonPropertyName("stack")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Stack { get; set; }
    }
}