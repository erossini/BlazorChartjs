namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    ///
    /// </summary>
    public class Legend
    {
        /// <summary>
        /// Gets or sets the align. <seealso cref="LegendAlign"/>
        /// </summary>
        /// <value>
        /// The align.
        /// </value>
        [JsonPropertyName("align")]
        public string Align { get; set; } = LegendAlign.Center;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Legend"/> is display.
        /// </summary>
        /// <value>
        ///   <c>true</c> if display; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("display")]
        public bool Display { get; set; } = true;

        /// <summary>
        /// Gets or sets the position. <seealso cref="LegendPosition"/>
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [JsonPropertyName("position")]
        public string Position { get; set; } = LegendPosition.ChartArea;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Legend"/> is reverse.
        /// </summary>
        /// <value>
        ///   <c>true</c> if reverse; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("reverse")]
        public bool Reverse { get; set; } = false;
    }
}