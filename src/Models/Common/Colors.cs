namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public class Colors
    {

        /// <summary>
        /// Enable or disable autocolors.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonPropertyName("enabled")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Enable or disable autocolors.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonPropertyName("forceOverride")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ForceOverride { get; set; }

    }
}
