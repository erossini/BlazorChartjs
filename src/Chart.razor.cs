using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using PSC.Blazor.Components.Chartjs.Models.Bar;
using System.Text.Json;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs 
{
    /// <summary>
    /// Class Chart.
    /// Implements the <see cref="ComponentBase" />
    /// Implements the <see cref="System.IDisposable" />
    /// </summary>
    /// <seealso cref="ComponentBase" />
    /// <seealso cref="System.IDisposable" />
    public partial class Chart : IDisposable 
    {
        #region .NET Object references

        /// <summary>
        /// Gets or sets the js module.
        /// </summary>
        /// <value>The js module.</value>
        protected ChartJsInterop? JSModule { get; set; }

        #endregion .NET Object references

        #region Parameters

        /// <summary>
        /// Gets or sets the class.
        /// </summary>
        /// <value>
        /// The class.
        /// </value>
        [Parameter]
        public string? Class { get; set; }

        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        [Parameter]
        public IChartConfig Config { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        [Parameter]
        public string? Height { get; set; }

        /// <summary>
        /// Gets or sets the old configuration.
        /// </summary>
        /// <value>
        /// The old configuration.
        /// </value>
        public IChartConfig OldConfig { get; set; }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        /// <value>
        /// The style.
        /// </value>
        [Parameter]
        public string? Style { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        [Parameter]
        public string? Width { get; set; }

        #region Events

        /// <summary>
        /// Gets or sets the on chart click.
        /// </summary>
        /// <value>
        /// The on chart click.
        /// </value>
        [Parameter]
        public EventCallback<CallbackGenericContext> OnChartClick { get; set; }

        /// <summary>
        /// Gets or sets the on chart over.
        /// </summary>
        /// <value>
        /// The on chart over.
        /// </value>
        [Parameter]
        public EventCallback<HoverContext> OnChartOver { get; set; }

        /// <summary>
        /// Gets or sets the on legend click.
        /// </summary>
        /// <value>The on legend click.</value>
        [Parameter]
        public EventCallback<LegendClickContext> OnLegendClick { get; set; }

        #endregion

        #region Public functions

        /// <summary>
        /// Adds the data.
        /// </summary>
        /// <param name="labels">The labels.</param>
        /// <param name="datasetIndex">Index of the dataset.</param>
        /// <param name="data">The data.</param>
        public async void AddData(List<string?> labels, int datasetIndex, List<decimal?> data) 
        {
            await JSModule.AddData(Config.CanvasId, labels, datasetIndex, data);
        }

        /// <summary>
        /// Adds the dataset.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataset">The dataset.</param>
        public async void AddDataset<T>(T dataset) where T : class 
        {
            await JSModule.AddNewDataset(Config.CanvasId, dataset);
        }

        #endregion

        #endregion Parameters

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (Config != null) {
                if (OldConfig == null || Config != OldConfig) {
                    var dotNetObjectRef = DotNetObjectReference.Create(Config);

                    JSModule = new ChartJsInterop(JSRuntime);
                    await JSModule.Setup(dotNetObjectRef, Config);
                }

                OldConfig = Config;
            }
        }

        /// <summary>
        /// Handles the <see cref="E:MouseOutAsync" /> event.
        /// </summary>
        /// <param name="mouseEventArgs">The <see cref="Microsoft.AspNetCore.Components.Web.MouseEventArgs" /> instance containing the event data.</param>
        /// <returns>System.Threading.Tasks.ValueTask.</returns>
        private ValueTask OnMouseOutAsync(MouseEventArgs mouseEventArgs)
        {
            if (Config.Options is Options { OnMouseOutAsync: { } } options)
                return options.OnMouseOutAsync(mouseEventArgs);
            else
                return ValueTask.CompletedTask;
        }

        #region JavaScript invokable functions

        /// <summary>
        /// Clears the data.
        /// </summary>
        public async void ClearData()
        {
            await JSModule.ClearData(Config.CanvasId);
        }

        /// <summary>
        /// Legends the labels filter.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="item">The item.</param>
        /// <param name="data">The data.</param>
        /// <returns>System.Nullable&lt;System.Boolean&gt;.</returns>
        [JSInvokable]
        public static bool? LegendLabelsFilter(DotNetObjectReference<IChartConfig> config, LegendItem item, Data data)
        {
            var ctx = new LegendFilterContext(item, data);
            if (config.Value.Options is Options options)
                return options.Plugins.Legend.Labels.Filter(ctx);
            else
                throw new NotSupportedException();
        }

        /// <summary>
        /// Called when [click asynchronous].
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="ctx">The CTX.</param>
        /// <returns>System.Threading.Tasks.Task&lt;System.Threading.Tasks.ValueTask&gt;.</returns>
        [JSInvokable]
        public static async Task<ValueTask> OnClickAsync(DotNetObjectReference<IChartConfig> config, CallbackGenericContext ctx)
        {
            //await OnChartClick.InvokeAsync(ctx);

            if (config.Value.Options is Options options && options.OnClickAsync != null)
                return options.OnClickAsync(ctx);
            else
                return ValueTask.CompletedTask;
        }

        /// <summary>
        /// Called when [hover asynchronous].
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="ctx">The CTX.</param>
        /// <returns>System.Threading.Tasks.Task&lt;System.Threading.Tasks.ValueTask&gt;.</returns>
        [JSInvokable]
        public static async Task<ValueTask> OnHoverAsync(DotNetObjectReference<IChartConfig> config, HoverContext ctx)
        {
            if (config.Value.Options is Options options && options.OnHoverAsync != null)
                return options.OnHoverAsync(ctx);
            else
                return ValueTask.CompletedTask;
        }

        /// <summary>
        /// Called when [legend click asynchronous].
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="ctx">The CTX.</param>
        /// <returns>System.Threading.Tasks.Task&lt;System.Threading.Tasks.ValueTask&gt;.</returns>
        [JSInvokable]
        public static async Task<ValueTask> OnLegendClickAsync(DotNetObjectReference<IChartConfig> config, 
            LegendClickContext ctx)
        {
            if (config.Value.Options is Options options && options?.Plugins?.Legend?.OnClickAsync != null)
                return options.Plugins.Legend.OnClickAsync(ctx);
            else
                return ValueTask.CompletedTask;
        }

        /// <summary>
        /// Tickses the callback.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="scaleName">Name of the scale.</param>
        /// <param name="value">The value.</param>
        /// <param name="index">The index.</param>
        /// <param name="ticksValues">The ticks values.</param>
        /// <returns>System.String[].</returns>
        [JSInvokable]
        public static string[] TicksCallback(DotNetObjectReference<IChartConfig> config, 
            string scaleName, decimal value, int index, decimal[] ticksValues)
        {
            var ctx = new TicksCallbackContext(value, index, ticksValues);
            if (config.Value.Options is Options options)
                return options.Scales[scaleName].Ticks.Callback(ctx);
            else
                throw new NotSupportedException();
        }

        /// <summary>
        /// Tickses the callback asynchronous.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="scaleName">Name of the scale.</param>
        /// <param name="value">The value.</param>
        /// <param name="index">The index.</param>
        /// <param name="ticksValues">The ticks values.</param>
        /// <returns>System.Threading.Tasks.Task&lt;System.String[]&gt;.</returns>
        [JSInvokable]
        public static async Task<string[]> TicksCallbackAsync(DotNetObjectReference<IChartConfig> config, 
            string scaleName, decimal value, int index, decimal[] ticksValues)
        {
            var ctx = new TicksCallbackContext(value, index, ticksValues);
            if (config.Value.Options is Options options)
                return await options.Scales[scaleName].Ticks.CallbackAsync(ctx);
            else
                throw new NotSupportedException();
        }

        /// <summary>
        /// Titles the callbacks.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>System.String[].</returns>
        [JSInvokable]
        public static string[] TitleCallbacks(DotNetObjectReference<IChartConfig> config, decimal[] parameters)
        {
            var ctx = new CallbackGenericContext((int)parameters[0], (int)parameters[1], parameters[2]);
            if (config.Value.Options is Options options)
                return options.Plugins.Tooltip.Callbacks.Title(ctx);
            else
                throw new NotSupportedException();
        }

        /// <summary>
        /// Tooltips the callbacks label.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>System.String[].</returns>
        [JSInvokable]
        public static string[] TooltipCallbacksLabel(DotNetObjectReference<IChartConfig> config, decimal[] parameters)
        {
            var ctx = new CallbackGenericContext((int)parameters[0], (int)parameters[1], (int)parameters[2]);
            if (config.Value.Options is Options options)
                return options.Plugins.Tooltip.Callbacks.Label(ctx);
            else
                throw new NotSupportedException();
        }

        #endregion JavaScript invokable functions
    }
}
