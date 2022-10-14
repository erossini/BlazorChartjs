namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public sealed class Callbacks
    {
        // https://www.chartjs.org/docs/3.7.1/configuration/tooltip.html

        [JsonInclude]
        [JsonPropertyName("hasLabel")]
        public bool HasLabel =>  Label != null;

        [JsonIgnore]
        public Func<TooltipContext, string[]>? Label { get; set; }
        
    }
}