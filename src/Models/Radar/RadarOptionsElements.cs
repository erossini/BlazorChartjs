using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Radar
{
    /// <summary>
    /// Radar Options Elements
    /// </summary>
    public class RadarOptionsElements
    {
        /// <summary>
        /// Gets or sets the radar options elements line.
        /// </summary>
        /// <value>
        /// The radar options elements line.
        /// </value>
        [JsonPropertyName("line")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public RadarOptionsElementsLine Line { get; set; }
    }
}
