namespace PSC.Blazor.Components.Chartjs.Models.Common {
    /// <summary>
    /// Legend Item
    /// </summary>
    public class LegendItem {
        //https://www.chartjs.org/docs/latest/configuration/legend.html#legend-item-interface

        [JsonPropertyName("text")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Text { get; set; }
        [JsonPropertyName("borderRadius")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? BorderRadius { get; set; }
        [JsonPropertyName("datasetIndex")]
        public int DatasetIndex { get; set; }
        [JsonPropertyName("fillStyle")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FillStyle { get; set; }
        [JsonPropertyName("fontColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FontColor { get; set; }
        [JsonPropertyName("hidden")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Hidden { get; set; }
        [JsonPropertyName("lineCap")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? LineCap { get; set; }
        [JsonPropertyName("lineDash")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<decimal?>? LineDash { get; set; }
        [JsonPropertyName("lineDashOffset")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? LineDashOffset { get; set; }
        [JsonPropertyName("lineJoin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? LineJoin { get; set; }
        [JsonPropertyName("lineWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? LineWidth { get; set; }
        [JsonPropertyName("rotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Rotation { get; set; }

    }
}