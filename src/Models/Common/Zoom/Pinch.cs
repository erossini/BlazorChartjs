using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Pinch
    /// </summary>
    public class Pinch
    {
        /// <summary>
        /// Gets or sets enable zooming via pinch
        /// </summary>
        /// <value>
        /// The enabled.
        /// </value>
        [JsonPropertyName("enabled")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Enabled { get; set; }
    }
}
