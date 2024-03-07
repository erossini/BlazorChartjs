using PSC.Blazor.Components.Chartjs.Models.Bubble;
using PSC.Blazor.Components.Chartjs.Models.Scatter;

namespace PSC.Blazor.Components.Chartjs.Models.Common 
{
    [JsonDerivedType(typeof(CustomDataset), typeDiscriminator: "base")]
    [JsonDerivedType(typeof(BubbleDataset), typeDiscriminator: "bubbleData")]
    [JsonDerivedType(typeof(ScatterDataset), typeDiscriminator: "scatterData")]
    public class CustomDataset 
    {
        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        [JsonPropertyName("label")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Label { get; set; }
    }
    /// <summary>
    /// Datatset for charts
    /// </summary>
    public class CustomDataset<T> : CustomDataset where T : class 
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [JsonPropertyName("data")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual List<T> Data { get; set; }
    }
}
