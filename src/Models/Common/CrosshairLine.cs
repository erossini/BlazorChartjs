namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public sealed class CrosshairLine
    {
        [JsonPropertyName("color")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Color { get; set; }

        [JsonPropertyName("width")] 
        public int Width { get; set; } = 1;

        [JsonPropertyName("dash")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int[]? Dash { get; set; }

    }
}