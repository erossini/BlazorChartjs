namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public sealed class Tooltip
    {
        [JsonPropertyName("callbacks")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Callbacks? Callbacks { get; set; }
    }
}