namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Ticks
    /// </summary>
    public class Ticks
    {
        /// <summary>
        /// Gets or sets the call back.
        /// </summary>
        /// <value>
        /// The call back.
        /// </value>
        [JsonPropertyName("callback")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CallBack { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        [JsonPropertyName("color")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Color { get; set; }

        /// <summary>
        /// Gets or sets the maximum rotation.
        /// </summary>
        /// <value>
        /// The maximum rotation.
        /// </value>
        [JsonPropertyName("maxRotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxRotation { get; set; }

        /// <summary>
        /// Gets or sets the minimum rotation.
        /// </summary>
        /// <value>
        /// The minimum rotation.
        /// </value>
        [JsonPropertyName("minRotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MinRotation { get; set; }
    }
}