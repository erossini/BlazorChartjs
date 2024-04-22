﻿namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public sealed class AxesTime
    {

        /// <summary>
        /// Get or set the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [JsonPropertyName("source")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Source{ get; set; }

        /// <summary>
        /// Get or set the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [JsonPropertyName("displayFormats")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AxesTimeFormats? DisplayFormats { get; set; }

        /// <summary>
        /// If true, first day is Monday, else it's Sunday.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        [JsonPropertyName("isoWeekday")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsoWeekday { get; set; }

        /// <summary>
        /// Get or set the round.
        /// </summary>
        /// <value>
        /// The round.
        /// </value>
        [JsonPropertyName("round")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Round { get; set; }

        /// <summary>
        /// The format string to use for the tooltip.
        /// </summary>
        /// <value>
        /// The format.
        /// </value>
        [JsonPropertyName("tooltipFormat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TooltipFormat { get; set; }

        /// <summary>
        /// Force the unit to be a certain type.
        /// </summary>
        /// <value>
        /// The unit.
        /// </value>
        [JsonPropertyName("unit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Unit { get; set; }

        /// <summary>
        /// The minimum display format to be used for a time unit.
        /// </summary>
        /// <value>
        /// The unit.
        /// </value>
        [JsonPropertyName("minUnit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? MinUnit { get; set; }

    }

    public sealed class AxesTimeFormats
    {
        [JsonPropertyName("millisecond")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Millisecond{ get; set; }

        [JsonPropertyName("second")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Second { get; set; }

        [JsonPropertyName("minute")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Minute { get; set; }

        [JsonPropertyName("hour")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Hour { get; set; }

        [JsonPropertyName("day")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Day { get; set; }

        [JsonPropertyName("week")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Week { get; set; }

        [JsonPropertyName("month")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Month { get; set; }

        [JsonPropertyName("quarter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Quarter { get; set; }

        [JsonPropertyName("year")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Year { get; set; }
    }
}
