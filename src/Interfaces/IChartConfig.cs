namespace PSC.Blazor.Components.Chartjs.Interfaces
{
    public interface IChartConfig
    {
        string CanvasId { get; }
        string Type { get; set; }
        IOptions Options { get;  }
        //string OnAnimationComplete { get; set; }
    }
}