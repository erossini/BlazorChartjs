namespace PSC.Blazor.Components.Chartjs.Models.Doughnut
{
    public class DoughnutChartConfig : IChartConfig
    {
        /// <summary>
        /// Gets the canvas identifier.
        /// </summary>
        /// <value>
        /// The canvas identifier.
        /// </value>
        [JsonIgnore]
        public string CanvasId { get; } = Guid.NewGuid().ToString();
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonPropertyName("type")]
        public string Type { get; set; } = ChartType.Doughnut;
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [JsonPropertyName("data")]
        public DoughnutData Data { get; set; } = new DoughnutData();
        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        [JsonPropertyName("options")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Options Options { get; set; }
        IOptions IChartConfig.Options => this.Options;
        /// <summary>
        /// Gets or sets the on animation complete.
        /// </summary>
        /// <value>
        /// The on animation complete.
        /// </value>
        /// <exception cref="System.NotImplementedException"></exception>
        [JsonPropertyName("onAnimationComplete")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string OnAnimationComplete { get; set; }
    }
}
