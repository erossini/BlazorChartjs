using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Bar
{
    /// <summary>
    /// Grid
    /// </summary>
    public class Grid
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Grid"/> is display.
        /// </summary>
        /// <value>
        ///   <c>true</c> if display; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("display")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Display { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [draw border].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [draw border]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("drawBorder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DrawBorder { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [draw on chart area].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [draw on chart area]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("drawOnChartArea")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DrawOnChartArea { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [draw ticks].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [draw ticks]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("drawTicks")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DrawTicks { get; set; }
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        [JsonPropertyName("color")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Color { get; set; }
    }
}
