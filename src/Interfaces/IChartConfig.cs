using PSC.Blazor.Components.Chartjs.Models.Bar;
using PSC.Blazor.Components.Chartjs.Models.Bubble;
using PSC.Blazor.Components.Chartjs.Models.Doughnut;
using PSC.Blazor.Components.Chartjs.Models.Line;
using PSC.Blazor.Components.Chartjs.Models.Pie;
using PSC.Blazor.Components.Chartjs.Models.Polar;
using PSC.Blazor.Components.Chartjs.Models.Radar;
using PSC.Blazor.Components.Chartjs.Models.Scatter;

namespace PSC.Blazor.Components.Chartjs.Interfaces 
{
    public interface IChartConfig 
    {
        string CanvasId { get; }
        string Type { get; set; }
        IOptions Options { get; }
    }
}
