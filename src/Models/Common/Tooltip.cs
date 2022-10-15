namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Tooltip
    /// </summary>
    public sealed class Tooltip
    {
        /// <summary>
        /// Gets or sets the callbacks.
        /// </summary>
        /// <value>
        /// The callbacks.
        /// </value>
        [JsonPropertyName("callbacks")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Callbacks? Callbacks { get; set; }
    }
}