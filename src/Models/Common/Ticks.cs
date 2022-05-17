using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Ticks
    /// </summary>
    public class Ticks
    {
        /// <summary>
        /// Gets or sets the maximum rotation.
        /// </summary>
        /// <value>
        /// The maximum rotation.
        /// </value>
        [JsonPropertyName("maxRotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxRotation { get; set; }
        /// <summary>
        /// Gets or sets the minimum rotation.
        /// </summary>
        /// <value>
        /// The minimum rotation.
        /// </value>
        [JsonPropertyName("minRotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MinRotation { get; set; }
        /// <summary>
        /// Gets or sets the call back.
        /// </summary>
        /// <value>
        /// The call back.
        /// </value>
        [JsonPropertyName("callback")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CallBack { get; set; }
    }
}
