using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Bar
{
    /// <summary>
    /// Axes Title
    /// </summary>
    public class AxesTitle
    {
        [JsonPropertyName("display")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Display { get; set; } = null;
        [JsonPropertyName("text")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Text { get; set; }
    }
}
