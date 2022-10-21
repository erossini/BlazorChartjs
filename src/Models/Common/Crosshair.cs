namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public sealed class Crosshair
    {
        [JsonPropertyName("cursor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Cursor { get; set; }

        [JsonPropertyName("vertical")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CrosshairLine? Vertical { get; set; }
        
        [JsonPropertyName("horizontal")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CrosshairLine? Horizontal { get; set; }

    }
}