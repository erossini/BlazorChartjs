window.setup = (id, dotnetConfig, jsonConfig) => {
    document.getElementById("chartcontainer" + id).style.display = 'none';
    document.getElementById("chartcontainer" + id).innerHTML = '&nbsp;';
    document.getElementById("chartcontainer" + id).innerHTML = '<canvas id="' + id + '"></canvas>';
    document.getElementById("chartcontainer" + id).style.display = '';

    var context2d = document.getElementById(id).getContext('2d');
    let config = eval(jsonConfig);
    if (config?.options?.plugins?.tooltip?.callbacks?.hasLabel) {
        config.options.plugins.tooltip.callbacks.hasLabel = undefined;
        config.options.plugins.tooltip.callbacks.label = function (ctx) {
            return DotNet.invokeMethod('PSC.Blazor.Components.Chartjs', 'TooltipCallbacksLabel',
                dotnetConfig, [ctx.datasetIndex, ctx.dataIndex]);
        };
    }

    if (config?.options?.hasOnHoverAsync) {
        config.options.hasOnHoverAsync = undefined;
        config.options.onHover = function (evt, activeElements, ch) {
            const canvasPosition = Chart.helpers.getRelativePosition(evt, ch);

            // Substitute the appropriate scale IDs
            const dataX = ch.scales.x.getValueForPixel(canvasPosition.x);
            const dataY = ch.scales.y.getValueForPixel(canvasPosition.y);

            DotNet.invokeMethodAsync('PSC.Blazor.Components.Chartjs', 'OnHoverAsync',
                dotnetConfig, [dataX, dataY]);
        };
    }

    var chart = new Chart(context2d, config);

    chart.options.onClick = function (event, array) {
        var rtn = -1;

        if (array !== undefined && array.length > 0)
            rtn = array[0].index;

        DotNet.invokeMethodAsync('PSC.Blazor.Components.Chartjs', 'ChartClick', rtn);
    };

    chart.options.plugins.legend.onClick = function (e, legendItem, legend) {
    };

    function getImage() {
        return chart.toDataURL("image/png");
    }
}