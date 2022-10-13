namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public sealed class Line
    {
        [JsonPropertyName("borderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BorderColor { get; set; } 
     
        [JsonPropertyName("borderWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? BorderWidth { get; set; } 

    }
}