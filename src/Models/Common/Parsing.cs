namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Class Parsing.
    /// </summary>
    public class Parsing
    {
        /// <summary>
        /// Gets or sets the xAxisKey.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonPropertyName("xAxisKey")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? xAxisKey { get; set; }


        /// <summary>
        /// Gets or sets the yAxisKey.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonPropertyName("yAxisKey")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? yAxisKey { get; set; }
    }
}
