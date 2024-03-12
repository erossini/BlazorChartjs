using Microsoft.JSInterop;
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

        public async ValueTask AddNewDataset<T>(string CanvasId, T dataset, bool Update) where T : class
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("addNewDataset", CanvasId, dataset, Update);
        }

        public async ValueTask SetNewDataset<T>(string CanvasId, T dataset) where T : class
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("setNewDataset", CanvasId, dataset);
        }

        public async ValueTask UpdateChart(string CanvasId)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("UpdateChart", CanvasId);
        }
    }
}