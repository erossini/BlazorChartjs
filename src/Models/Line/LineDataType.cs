namespace PSC.Blazor.Components.Chartjs.Models.Line
{
    public class LineDataType
    {

        /// <summary>
        /// Gets or sets the x value.
        /// </summary>
        /// <value>
        /// x value
        /// </value>
        [JsonPropertyName("x")]
        public string X { get; set; } = null;

        /// <summary>
        /// Gets or sets the x value.
        /// </summary>
        /// <value>
        /// x value
        /// </value>
        [JsonPropertyName("y")]
        public string Y { get; set; } = null;
    }
}
