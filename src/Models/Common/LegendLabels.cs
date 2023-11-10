namespace PSC.Blazor.Components.Chartjs.Models.Common {
    /// <summary>
    /// Legend Label Configuration
    /// </summary>
    public class LegendLabels {
        //https://www.chartjs.org/docs/latest/configuration/legend.html#legend-label-configuration

        /// <summary>
        /// Gets a value indicating whether this instance has filter.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has filter; otherwise, <c>false</c>.
        /// </value>
        [JsonInclude]
        [JsonPropertyName("hasFilter")]
        public bool HasFilter => Filter != null;

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        [JsonIgnore]
        public Func<LegendFilterContext, bool?>? Filter { get; set; }
    }
}