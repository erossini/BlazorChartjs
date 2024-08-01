using Microsoft.JSInterop;
using System.Text.Json;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs 
{
    public class ChartJsInterop 
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public ChartJsInterop(IJSRuntime jsRuntime) 
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>("import",
                "./_content/PSC.Blazor.Components.Chartjs/Chart.js").AsTask());
        }

        public async ValueTask Setup(DotNetObjectReference<IChartConfig> dotNetObjectRef, IChartConfig Config) 
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("chartSetup", Config.CanvasId, dotNetObjectRef, Config);
        }

        public async ValueTask AddData(string CanvasId, List<string> labels, int datasetIndex, List<decimal?> data) 
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("addData", CanvasId, labels, datasetIndex, data);
        }

        public async ValueTask ClearData(string CanvasId)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("clearData", CanvasId);
        }

        public async ValueTask AddNewDataset<T>(string CanvasId, T dataset) where T : class 
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("addNewDataset", CanvasId, dataset);
        }
    }
}
