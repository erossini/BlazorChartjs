namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public sealed class Elements
    {
        [JsonPropertyName("line")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Line? Line { get; set; } 
    }
}