using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
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

        public async void AddData(List<string?> labels, int datasetIndex, List<decimal?> data)
        {
            await JSModule.AddData(Config.CanvasId, labels, datasetIndex, data);
        }

        public async void AddDataset<T>(T dataset) where T : class
        {
            await JSModule.AddNewDataset(Config.CanvasId, dataset);
        }

        #endregion

        #endregion Parameters

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (Config != null)
            {
                if (OldConfig == null || Config != OldConfig)
                {
                    var dotNetObjectRef = DotNetObjectReference.Create(Config);

                    JSModule = new ChartJsInterop(JSRuntime);
                    await JSModule.Setup(dotNetObjectRef, Config);
                }

                OldConfig = Config;
            }
        }

        private ValueTask OnMouseOutAsync(MouseEventArgs mouseEventArgs)
        {
            if (Config.Options is Options { OnMouseOutAsync: { } } options)
                return options.OnMouseOutAsync(mouseEventArgs);
            else
                return ValueTask.CompletedTask;
        }

        #region JavaScript invokable functions

        [JSInvokable]
        public static string[] TitleCallbacks(DotNetObjectReference<IChartConfig> config, decimal[] parameters)
        {
            var ctx = new CallbackGenericContext(
                DatasetIndex: (int)parameters[0],
                DataIndex: (int)parameters[1],
                Value: parameters[2],
                ChartId: config.Value.GetChartId());

            if (config.Value.Options is Options options)
                return options.Plugins.Tooltip.Callbacks.Title(ctx);
            else
                throw new NotSupportedException();
        }

        [JSInvokable]
        public static string[] TooltipCallbacksLabel(DotNetObjectReference<IChartConfig> config, int[] parameters)
        {
            var ctx = new CallbackGenericContext(
                DatasetIndex: parameters[0],
                DataIndex: parameters[1],
                Value: parameters[2],
                ChartId: config.Value.GetChartId());

            if (config.Value.Options is Options options)
                return options.Plugins.Tooltip.Callbacks.Label(ctx);
            else
                throw new NotSupportedException();
        }

        [JSInvokable]
        public static async Task<ValueTask> OnClickAsync(DotNetObjectReference<IChartConfig> config, CallbackGenericContext ctx)
        {
            //await OnChartClick.InvokeAsync(ctx);            

            if (config.Value.Options is Options options && options.OnClickAsync != null)
                return options.OnClickAsync(ctx with { ChartId = config.Value.GetChartId() });
            else
                return ValueTask.CompletedTask;
        }

        [JSInvokable]
        public static async Task<ValueTask> OnHoverAsync(DotNetObjectReference<IChartConfig> config, HoverContext ctx)
        {
            if (config.Value.Options is Options options && options.OnHoverAsync != null)
                return options.OnHoverAsync(ctx);
            else
                return ValueTask.CompletedTask;
        }

        [JSInvokable]
        public static async Task<ValueTask> OnLegendClickAsync(DotNetObjectReference<IChartConfig> config, LegendClickContext ctx)
        {
            if (config.Value.Options is Options options && options?.Plugins?.Legend?.OnClickAsync != null)
                return options.Plugins.Legend.OnClickAsync(ctx);
            else
                return ValueTask.CompletedTask;
        }

        #endregion JavaScript invokable functions

        public void Dispose()
        {
        }
    }
}