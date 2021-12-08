using Newtonsoft.Json;
using PSC.Blazor.Components.Chartjs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Bar
{
    /// <summary>
    /// Chart config for Bars
    /// </summary>
    public class BarChartConfig
    {
        /// <summary>
        /// Gets or sets the canvas identifier.
        /// </summary>
        /// <value>
        /// The canvas identifier.
        /// </value>
        [JsonIgnore]
        public string CanvasId { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonProperty("type")]
        public string Type { get; set; } = ChartType.Bar;
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [JsonProperty("data")]
        public Data Data { get; set; } = new Data();
        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        [JsonProperty("options")]
        public Options Options { get; set; }
    }
}