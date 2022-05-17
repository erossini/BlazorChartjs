namespace PSC.Blazor.Components.Chartjs.Models.Scatter
{
    public class ScatterDataset : CustomDataset<ScatterXYValue>
    {
        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>
        /// <value>
        /// The color of the background.
        /// </value>
        [JsonPropertyName("backgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string BackgroundColor { get; set; }
    }
}