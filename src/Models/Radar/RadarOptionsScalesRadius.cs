namespace PSC.Blazor.Components.Chartjs.Models.Radar
{
    /// <summary>
    /// Radar Scales Radius Options
    /// </summary>
    public class RadarOptionsScalesRadius
    {
        /// <summary>
        /// If true, scale will include 0 if it is not already included.
        /// </summary>
        /// <value>
        /// The value if the chart need to start at zero
        /// </value>
        [JsonPropertyName("beginAtZero")]
        public bool BeginAtZero { get; set; } = false;

        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value from data.
        /// </summary>
        /// <value>
        /// The value of the max value
        /// </value>
        [JsonPropertyName("max")]
        public decimal? Max { get; set; }

        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value from data.
        /// </summary>
        /// <value>
        /// The value of the min value
        /// </value>
        [JsonPropertyName("min")]
        public decimal? Min { get; set; }
    }
}
