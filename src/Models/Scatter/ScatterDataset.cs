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

        [JsonPropertyName("showLine")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool ShowLine { get; set; } = false;

        [JsonPropertyName("tension")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Tension { get; set; } = 0;

        [JsonPropertyName("pointRadius")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? PointRadius { get; set; }

    }
}