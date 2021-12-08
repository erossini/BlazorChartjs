using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Bar
{
    /// <summary>
    /// Data for Bar
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The labels.
        /// </value>
        [JsonProperty("labels")]
        public List<string> Labels { get; set; } = new List<string>();
        /// <summary>
        /// Gets or sets the datasets.
        /// </summary>
        /// <value>
        /// The datasets.
        /// </value>
        [JsonProperty("datasets")]
        public List<Dataset> Datasets { get; set; } = new List<Dataset>();
    }
}
