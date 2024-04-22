using PSC.Blazor.Components.Chartjs.Models.Bar;
using PSC.Blazor.Components.Chartjs.Models.Bubble;
using PSC.Blazor.Components.Chartjs.Models.Doughnut;
using PSC.Blazor.Components.Chartjs.Models.Line;
using PSC.Blazor.Components.Chartjs.Models.Pie;
using PSC.Blazor.Components.Chartjs.Models.Polar;
using PSC.Blazor.Components.Chartjs.Models.Radar;
using PSC.Blazor.Components.Chartjs.Models.Scatter;

namespace PSC.Blazor.Components.Chartjs.Models.Common 
{
    /// <summary>
    /// Datatset for charts
    /// </summary>
    [JsonDerivedType(typeof(Dataset), typeDiscriminator: "base")]
    [JsonDerivedType(typeof(BarDataset), typeDiscriminator: "barDataset")]
    [JsonDerivedType(typeof(DoughnutDataset), typeDiscriminator: "doughnutDataset")]
    [JsonDerivedType(typeof(LineDataset), typeDiscriminator: "lineDataset")]
    [JsonDerivedType(typeof(PieDataset), typeDiscriminator: "pieDataset")]
    [JsonDerivedType(typeof(PolarDataset), typeDiscriminator: "polarDataset")]
    [JsonDerivedType(typeof(RadarDataset), typeDiscriminator: "radarDataset")]
    public class Dataset 
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [JsonPropertyName("data")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual List<decimal?> Data { get; set; }

        /// <summary>
        /// Gets or sets the data labels.
        /// </summary>
        /// <value>The data labels.</value>
        [JsonPropertyName("datalabels")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DataLabels? DataLabels { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        [JsonPropertyName("label")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        [JsonPropertyName("order")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
    }
}
