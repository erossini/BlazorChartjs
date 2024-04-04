namespace PSC.Blazor.Components.Chartjs.Models.Radar
{
    /// <summary>
    /// Radar Options Scale
    /// </summary>
    public class RadarOptionsScales
	{
        /// <summary>
        /// Gets or sets the radial options.
        /// </summary>
        /// <value>
        /// The radar options scale radial.
        /// </value>
        [JsonPropertyName("r")]
		public RadarOptionsScalesRadial R { get; set; }
	}
}
