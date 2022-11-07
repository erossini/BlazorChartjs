namespace PSC.Blazor.Components.Chartjs.Models.Radar
{
    public class RadarDataset : Dataset
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
        /// Gets or sets the color of the border.
        /// </summary>
        /// <value>
        /// The color of the border.
        /// </value>
        [JsonPropertyName("borderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string BorderColor { get; set; }

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
        /// Gets or sets a value indicating whether this <see cref="RadarDataset"/> is fill.
        /// </summary>
        /// <value>
        ///   <c>true</c> if fill; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("fill")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Fill { get; set; }

        /// <summary>
        /// Gets or sets the color of the point background.
        /// </summary>
        /// <value>
        /// The color of the point background.
        /// </value>
        [JsonPropertyName("pointBackgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string PointBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the point border.
        /// </summary>
        /// <value>
        /// The color of the point border.
        /// </value>
        [JsonPropertyName("pointBorderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string PointBorderColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the point hover background.
        /// </summary>
        /// <value>
        /// The color of the point hover background.
        /// </value>
        [JsonPropertyName("pointHoverBackgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string PointHoverBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the point hover border.
        /// </summary>
        /// <value>
        /// The color of the point hover border.
        /// </value>
        [JsonPropertyName("pointHoverBorderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string PointHoverBorderColor { get; set; }
    }
}