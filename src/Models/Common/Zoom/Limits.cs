namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Limits
    /// </summary>
    public class Limits
    {

        /// <summary>
        /// Limits for x-axis.
        /// </summary>
        /// <value>
        /// X.
        /// </value>
        [JsonPropertyName("x")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ScaleLimits? X { get; set; }

        /// <summary>
        /// Limits for Y-axis.
        /// </summary>
        /// <value>
        /// Y.
        /// </value>
        [JsonPropertyName("y")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ScaleLimits? Y { get; set; }

        /// <summary>
        /// Limits for Y2-axis.
        /// </summary>
        /// <value>
        /// Y2.
        /// </value>
        [JsonPropertyName("y2")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ScaleLimits? Y2 { get; set; }
    }
}
