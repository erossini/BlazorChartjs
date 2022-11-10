namespace PSC.Blazor.Components.Chartjs.Models.Pie
{
    /// <summary>
    /// Pie Options
    /// </summary>
    /// <seealso cref="PSC.Blazor.Components.Chartjs.Models.Common.Options" />
    /// <seealso cref="PSC.Blazor.Components.Chartjs.Interfaces.IOptions" />
    public class PieOptions : Options, IOptions
    {
        /// <summary>
        /// Gets or sets the circumference.
        /// </summary>
        /// <value>
        /// The circumference.
        /// </value>
        [JsonPropertyName("circumference")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Circumference { get; set; }

        /// <summary>
        /// Gets or sets the rotation.
        /// </summary>
        /// <value>
        /// The rotation.
        /// </value>
        [JsonPropertyName("rotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Rotation { get; set; }
    }
}