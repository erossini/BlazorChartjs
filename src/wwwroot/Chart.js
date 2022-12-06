function crosshairLine(chart, evt, plugin) {
    const { canvas, ctx, chartArea: { left, right, top, bottom } } = chart;

    chart.update("none");

    if (plugin.cursor) {
        if (evt.offsetX >= left && evt.offsetX <= right && evt.offsetY <= bottom && evt.offsetY >= top) {
            canvas.style.cursor = plugin.cursor;
        } else
            canvas.style.cursor = "default";
    }

    if (plugin.vertical && evt.offsetX >= left && evt.offsetX <= right) {
        let line = plugin.vertical;

        ctx.save();
        ctx.beginPath();
        ctx.moveTo(evt.offsetX, top);
        ctx.lineTo(evt.offsetX, bottom);
        ctx.lineWidth = line.width;
        if (line.color)
            ctx.strokeStyle = line.color;
        if (line.dash)
            ctx.setLineDash(line.dash);
        ctx.stroke();
        ctx.restore();
    }

    if (plugin.horizontal && evt.offsetY <= bottom && evt.offsetY >= top) {
        let line = plugin.horizontal;

        ctx.save();
        ctx.beginPath();
        ctx.moveTo(left, evt.offsetY);
        ctx.lineTo(right, evt.offsetY);
        ctx.lineWidth = line.width;
        if (line.color)
            ctx.strokeStyle = line.color;
        if (line.dash)
            ctx.setLineDash(line.dash);
        ctx.stroke();
        ctx.restore();
    }
}

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

    let crosshair_plugin = config?.options?.plugins?.crosshair;
    if (config?.options?.plugins?.crosshair) {
        config.options.plugins.crosshair = undefined;
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

    if (config?.options?.groupXAxis) {
        config.options.groupXAxis = undefined;

        config.options.scales.x.ticks.callback = function (label) {
            let realLabel = this.getLabelForValue(label)
            var lbl = realLabel.split(";")[0];
            return lbl;
        }

        config.options.scales.xAxis2.type = 'category';
        config.options.scales.xAxis2.grid.drawOnChartArea = false;
        config.options.scales.xAxis2.ticks.callback = function (label) {
            let realLabel = this.getLabelForValue(label)

            var lbl = realLabel.split(";")[1];
            var position = realLabel.split(";")[2];
            if (position !== undefined && position !== '') {
                return lbl;
            } else {
                return "";
            }
        }
    }

    if (config?.options?.groupYAxis) {
        config.options.groupYAxis = undefined;

        config.options.scales.y.ticks.callback = function (label) {
            let realLabel = this.getLabelForValue(label)
            var lbl = realLabel.split(";")[0];
            return lbl;
        }

        config.options.scales.yAxis2.type = 'category';
        config.options.scales.yAxis2.grid.drawOnChartArea = false;
        config.options.scales.yAxis2.ticks.callback = function (label) {
            let realLabel = this.getLabelForValue(label)

            var lbl = realLabel.split(";")[1];
            var position = realLabel.split(";")[2];
            if (position !== undefined && position !== '') {
                return lbl;
            } else {
                return "";
            }
        }
    }

    var chart = new Chart(context2d, config);
    if (crosshair_plugin) {
        chart.canvas.addEventListener("mousemove", (evt) => {
            crosshairLine(chart, evt, crosshair_plugin);
        });
    }

    chart.options.onClick = function (event, array) {
        var rtn = -1;

        if (array !== undefined && array.length > 0)
            rtn = array[0].index;

        DotNet.invokeMethodAsync('PSC.Blazor.Components.Chartjs', 'ChartClick', rtn);
    };

    chart.options.plugins.legend.onClick = function (e, legendItem, legend) {
    };

    function getImage() {
        return chart.toBase64Image();
    }
}