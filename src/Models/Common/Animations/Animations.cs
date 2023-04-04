namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Animations
    /// </summary>
    public class Animations
    {
        /// <summary>
        /// Gets or sets the colors.
        /// </summary>
        /// <value>
        /// Enables/Disables animation defined by the collection of 'colors' properties
        /// </value>
        [JsonPropertyName("colors")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Colors { get; set; }

        /// <summary>
        /// Gets or sets the tension.
        /// </summary>
        /// <value>
        /// The tension.
        /// </value>
        [JsonPropertyName("tension")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Tension? Tension { get; set; }

        /// <summary>
        /// Gets or sets the colors.
        /// </summary>
        /// <value>
        /// Enables/Disables animation defined by the 'x' property
        /// </value>
        [JsonPropertyName("x")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? X { get; set; }
    }
}
