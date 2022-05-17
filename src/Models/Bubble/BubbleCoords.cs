using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Bubble
{
    /// <summary>
    /// Bubble Coords
    /// </summary>
    public class BubbleCoords
    {
        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>
        /// The x.
        /// </value>
        [JsonPropertyName("x")]
        public int X { get; set; }
        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>
        /// The y.
        /// </value>
        [JsonPropertyName("y")]
        public int Y { get; set; }
        /// <summary>
        /// Gets or sets the r.
        /// </summary>
        /// <value>
        /// The r.
        /// </value>
        [JsonPropertyName("r")]
        public int R { get; set; }
    }
}
