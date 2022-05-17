using PSC.Blazor.Components.Chartjs.Models.Common;
using System.Text.Json.Serialization;

namespace PSC.Blazor.Components.Chartjs.Models.Common
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
