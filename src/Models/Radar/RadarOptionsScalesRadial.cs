namespace PSC.Blazor.Components.Chartjs.Models.Radar
{
    /// <summary>
    /// Radar Options Scale Radial
    /// </summary>
    public class RadarOptionsScalesRadial
	{
        /// <summary>
        /// If true, scale will include 0 if it is not already included.
        /// </summary>
		/// <value>
		/// Do the center start at 0 ?
		/// </value>
        [JsonPropertyName("beginAtZero")]
		public bool BeginAtZero { get; set; } = false;

        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value from data.
        /// </summary>
		/// <value>
		/// The maximum value of radar.
		/// </value>
        [JsonPropertyName("max")]
        public decimal? Max { get; set; }

        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value from data.
        /// </summary>
        /// <value>
        /// The minimum value of radar.
        /// </value>
        [JsonPropertyName("min")]
        public decimal? Min { get; set; }
	}
}
