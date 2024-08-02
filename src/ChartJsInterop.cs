using Microsoft.JSInterop;
using System.Text.Json;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs 
{
    /// <summary>
    /// Class ChartJsInterop.
    /// </summary>
    public class ChartJsInterop 
    {
        /// <summary>
        /// The module task
        /// </summary>
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartJsInterop"/> class.
        /// </summary>
        /// <param name="jsRuntime">The js runtime.</param>
        public ChartJsInterop(IJSRuntime jsRuntime) 
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>("import",
                "./_content/PSC.Blazor.Components.Chartjs/Chart.js").AsTask());
        }

        /// <summary>
        /// Setups the specified dot net object reference.
        /// </summary>
        /// <param name="dotNetObjectRef">The dot net object reference.</param>
        /// <param name="Config">The configuration.</param>
        /// <returns>ValueTask.</returns>
        public async ValueTask Setup(DotNetObjectReference<IChartConfig> dotNetObjectRef, IChartConfig Config) 
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("chartSetup", Config.CanvasId, dotNetObjectRef, Config);
        }

        /// <summary>
        /// Adds the data.
        /// </summary>
        /// <param name="CanvasId">The canvas identifier.</param>
        /// <param name="labels">The labels.</param>
        /// <param name="datasetIndex">Index of the dataset.</param>
        /// <param name="data">The data.</param>
        /// <returns>ValueTask.</returns>
        public async ValueTask AddData(string CanvasId, List<string> labels, int datasetIndex, List<decimal?> data) 
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("addData", CanvasId, labels, datasetIndex, data);
        }

        /// <summary>
        /// Adds the new dataset.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="CanvasId">The canvas identifier.</param>
        /// <param name="dataset">The dataset.</param>
        /// <returns>ValueTask.</returns>
        public async ValueTask AddNewDataset<T>(string CanvasId, T dataset) where T : class 
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("addNewDataset", CanvasId, dataset);
        }

        /// <summary>
        /// Clears the data.
        /// </summary>
        /// <param name="CanvasId">The canvas identifier.</param>
        /// <returns>ValueTask.</returns>
        public async ValueTask ClearData(string CanvasId)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("clearData", CanvasId);
        }
    }
}
