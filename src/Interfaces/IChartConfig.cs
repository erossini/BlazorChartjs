namespace PSC.Blazor.Components.Chartjs.Interfaces
{
    public interface IChartConfig
    {
        string CanvasId { get; }
        string Type { get; set; }
        IOptions Options { get; }

        public Guid? GetChartId() => Guid.TryParse(CanvasId, out var chartId) ? chartId : null;
    }
}