namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public class Autocolors
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

    }
}
