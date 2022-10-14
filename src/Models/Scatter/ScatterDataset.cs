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

        /// <summary>
        /// Gets or sets the point radius.
        /// </summary>
        /// <value>
        /// The point radius.
        /// </value>
        [JsonPropertyName("pointRadius")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? PointRadius { get; set; }

        [JsonPropertyName("pointHitRadius")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? PointHitRadius { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether show line.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show line]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("showLine")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool ShowLine { get; set; } = false;

        /// <summary>
        /// Gets or sets the tension.
        /// </summary>
        /// <value>
        /// The tension.
        /// </value>
        [JsonPropertyName("tension")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Tension { get; set; } = 0;

        /// <summary>
        /// Gets or sets the y axis identifier.
        /// </summary>
        /// <value>
        /// The y axis identifier.
        /// </value>
        [JsonPropertyName("yAxisID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? YAxisId { get; set; }
    }
}