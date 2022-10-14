using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs
{
    public partial class Chart
    {
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
        /// Gets or sets the on chart click.
        /// </summary>
        /// <value>
        /// The on chart click.
        /// </value>
        [Parameter]
        public EventCallback<int> OnChartClick { get; set; }

        /// <summary>
        /// Gets or sets the on chart over.
        /// </summary>
        /// <value>
        /// The on chart over.
        /// </value>
        [Parameter]
        public EventCallback OnChartOver { get; set; }

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

        #endregion Parameters

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (Config != null)
            {
                if (OldConfig == null || Config != OldConfig)
                    await JSRuntime.InvokeVoidAsync("setup", Config.CanvasId, Config);
                OldConfig = Config;
            }
        }

        #region JavaScript invokable functions

        [JSInvokable]
        public static Task ChartClick(int indexValue)
        {
            return Task.CompletedTask;
        }

        [JSInvokable]
        public static Task ChartHover()
        {
            return Task.CompletedTask;
        }

        [JSInvokable]
        public static string ChartScaleXTicks(string val, int index)
        {
            return index % 2 == 0 ? val : "";
        }

        #endregion JavaScript invokable functions
    }
}