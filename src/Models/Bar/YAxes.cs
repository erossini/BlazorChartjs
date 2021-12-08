using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Bar
{
    /// <summary>
    /// YAxes
    /// </summary>
    public class YAxes
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="YAxes"/> is stacked.
        /// </summary>
        /// <value>
        ///   <c>true</c> if stacked; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("stacked")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Stacked { get; set; }
        /// <summary>
        /// Gets or sets the ticks.
        /// </summary>
        /// <value>
        /// The ticks.
        /// </value>
        [JsonPropertyName("ticks")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Ticks? Ticks { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
        /// <summary>
        /// Gets or sets the grid.
        /// </summary>
        /// <value>
        /// The grid.
        /// </value>
        [JsonPropertyName("grid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Grid? Grid { get; set; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("title")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AxesTitle? Title { get; set; }
    }
}
