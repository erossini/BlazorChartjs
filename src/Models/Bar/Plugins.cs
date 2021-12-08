using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Bar
{
    /// <summary>
    /// Plugins
    /// </summary>
    public class Plugins
    {
        /// <summary>
        /// Gets or sets the legend.
        /// </summary>
        /// <value>
        /// The legend.
        /// </value>
        [JsonPropertyName("legend")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Legend? Legend { get; set; } = new Legend();
    }
}
