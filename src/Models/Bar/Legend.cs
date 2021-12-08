using Newtonsoft.Json;
using PSC.Blazor.Components.Chartjs.Enums;
using PSC.Blazor.Components.Chartjs.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Bar
{
    /// <summary>
    /// 
    /// </summary>
    public class Legend
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Legend"/> is display.
        /// </summary>
        /// <value>
        ///   <c>true</c> if display; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("display")]
        public bool Display { get; set; } = true;
        /// <summary>
        /// Gets or sets the position. <seealso cref="LegendPosition"/>
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [JsonProperty("position")]
        public string Position { get; set; } = LegendPosition.ChartArea;
        /// <summary>
        /// Gets or sets the align. <seealso cref="LegendAlign"/>
        /// </summary>
        /// <value>
        /// The align.
        /// </value>
        [JsonProperty("align")]
        public string Align { get; set; } = LegendAlign.Center;
    }
}
