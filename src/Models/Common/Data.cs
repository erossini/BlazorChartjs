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
    /// Data for Charts
    /// </summary>
    [JsonDerivedType(typeof(Data), typeDiscriminator: "base")]
    [JsonDerivedType(typeof(BarData), typeDiscriminator: "barData")]
    [JsonDerivedType(typeof(DoughnutData), typeDiscriminator: "doughnutData")]
    [JsonDerivedType(typeof(LineData), typeDiscriminator: "lineData")]
    [JsonDerivedType(typeof(PieData), typeDiscriminator: "pieData")]
    [JsonDerivedType(typeof(PolarData), typeDiscriminator: "polarData")]
    [JsonDerivedType(typeof(RadarData), typeDiscriminator: "radarData")]
    [JsonDerivedType(typeof(BubbleData), typeDiscriminator: "bubbleData")]
    [JsonDerivedType(typeof(ScatterData), typeDiscriminator: "scatterData")]
    public class Data 
    {
        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The labels.
        /// </value>
        [JsonPropertyName("labels")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Labels { get; set; } = new List<string>();
    }

    /// <summary>
    /// Data for Charts
    /// </summary>
    public class Data<T> : Data where T : class 
    {
        /// <summary>
        /// Gets or sets the datasets.
        /// </summary>
        /// <value>
        /// The datasets.
        /// </value>
        [JsonPropertyName("datasets")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<T> Datasets { get; set; } = new List<T>();
    }
}
