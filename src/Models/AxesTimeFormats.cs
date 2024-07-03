using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models
{
    /// <summary>
    /// Class AxesTimeFormats. This class cannot be inherited.
    /// </summary>
    public sealed class AxesTimeFormats
    {
        /// <summary>
        /// Gets or sets the millisecond.
        /// </summary>
        /// <value>The millisecond.</value>
        [JsonPropertyName("millisecond")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Millisecond { get; set; }

        /// <summary>
        /// Gets or sets the second.
        /// </summary>
        /// <value>The second.</value>
        [JsonPropertyName("second")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Second { get; set; }

        /// <summary>
        /// Gets or sets the minute.
        /// </summary>
        /// <value>The minute.</value>
        [JsonPropertyName("minute")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Minute { get; set; }

        /// <summary>
        /// Gets or sets the hour.
        /// </summary>
        /// <value>The hour.</value>
        [JsonPropertyName("hour")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Hour { get; set; }

        /// <summary>
        /// Gets or sets the day.
        /// </summary>
        /// <value>The day.</value>
        [JsonPropertyName("day")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Day { get; set; }

        /// <summary>
        /// Gets or sets the week.
        /// </summary>
        /// <value>The week.</value>
        [JsonPropertyName("week")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Week { get; set; }

        /// <summary>
        /// Gets or sets the month.
        /// </summary>
        /// <value>The month.</value>
        [JsonPropertyName("month")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Month { get; set; }

        /// <summary>
        /// Gets or sets the quarter.
        /// </summary>
        /// <value>The quarter.</value>
        [JsonPropertyName("quarter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Quarter { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>The year.</value>
        [JsonPropertyName("year")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Year { get; set; }
    }
}
