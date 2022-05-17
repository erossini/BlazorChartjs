namespace PSC.Blazor.Components.Chartjs.Models.Polar
{
    public class PolarDataset : Dataset
    {
        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>
        /// <value>
        /// The color of the background.
        /// </value>
        [JsonPropertyName("backgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> BackgroundColor { get; set; } = new List<string>();
    }
}