using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Scatter
{
    /// <summary>
    /// Scatter XY Value
    /// </summary>
    public class ScatterXYValue
    {
        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>
        /// The x.
        /// </value>
        [JsonPropertyName("x")]
        public decimal X { get; set; }
        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>
        /// The y.
        /// </value>
        [JsonPropertyName("y")]
        public decimal Y { get; set; }
    }
}