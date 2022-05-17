using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Scales for Bar
    /// </summary>
    public class Scales
    {
        /// <summary>
        /// Gets or sets the x axes.
        /// </summary>
        /// <value>
        /// The x axes.
        /// </value>
        [JsonPropertyName("x")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public XAxes X { get; set; }
        /// <summary>
        /// Gets or sets the y axes.
        /// </summary>
        /// <value>
        /// The y axes.
        /// </value>
        [JsonPropertyName("y")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public YAxes Y { get; set; }
    }
}
