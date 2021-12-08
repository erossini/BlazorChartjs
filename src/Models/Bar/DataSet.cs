using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Bar
{
    /// <summary>
    /// Datatset for Bar
    /// </summary>
    public class Dataset
    {
        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        [JsonPropertyName("label")]
        public string Label { get; set; }
        /// <summary>
        /// Gets or sets the stack.
        /// </summary>
        /// <value>
        /// The stack.
        /// </value>
        [JsonPropertyName("stack")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> Stack { get; set; }
        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>
        /// <value>
        /// The color of the background.
        /// </value>
        [JsonPropertyName("backgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> BackgroundColor { get; set; } = new List<string>();
        /// <summary>
        /// Gets or sets the color of the border.
        /// </summary>
        /// <value>
        /// The color of the background.
        /// </value>
        [JsonPropertyName("borderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> BorderColor { get; set; } = new List<string>();
        /// <summary>
        /// Gets or sets the width of the border.
        /// </summary>
        /// <value>
        /// The width of the border.
        /// </value>
        [JsonPropertyName("borderWidth")]
        public int? BorderWidth { get; set; }
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [JsonPropertyName("data")]
        public List<decimal> Data { get; set; }
        /// <summary>
        /// Gets or sets the background color hover.
        /// </summary>
        /// <value>
        /// The background color hover.
        /// </value>
        [JsonPropertyName("hoverBackgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string> HoverBackgroundColor { get; set; } = new List<string>();
    }
}
