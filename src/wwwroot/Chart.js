const DATA_TYPES = {
    "bar": "barData",
    "line": "lineData",
    "pie": "pieData",
    "doughnut": "doughnutData",
    "radar": "radarData",
    "polarArea": "polarData",
    "bubble": "bubbleData",
    "scatter": "scatterData"
};

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

export function chartSetup(id, dotnetConfig, jsonConfig) {
    let chartElement = document.getElementById("chartcontainer" + id);
    if (!chartElement) return;

    chartElement.style.display = 'none';
    chartElement.innerHTML = '&nbsp;';
    chartElement.innerHTML = '<canvas id="' + id + '"></canvas>';
    chartElement.style.display = '';

    var context2d = document.getElementById(id).getContext('2d');
    let config = eval(jsonConfig);

    if (config?.options?.plugins?.legend?.labels?.hasFilter) {
        config.options.plugins.legend.labels.hasFilter = undefined;
        config.options.plugins.legend.labels.filter = function (item, data) {
            let json = JSON.stringify(data);
            let jsonArray = [...json];

            let dataType = DATA_TYPES[jsonConfig.type];
            jsonArray.splice(1, 0, `"$type":"${dataType}",`);
            json = jsonArray.join("");

            return DotNet.invokeMethod('PSC.Blazor.Components.Chartjs', 'LegendLabelsFilter',
                dotnetConfig, item, JSON.parse(json))
        };
    }

    if (config?.options?.plugins?.tooltip?.callbacks?.hasLabel) {
        config.options.plugins.tooltip.callbacks.hasLabel = undefined;
        config.options.plugins.tooltip.callbacks.label = function (ctx) {
            var dsIndex = -1;
            var dIndex = -1;
            var vl = 0;
            if (ctx.datasetIndex >= 0 && ctx.dataIndex >= 0) {
                dsIndex = ctx.datasetIndex;
                dIndex = ctx.dataIndex;
                vl = chart.data.datasets[dsIndex].data[dIndex];
            }
            return DotNet.invokeMethod('PSC.Blazor.Components.Chartjs', 'TooltipCallbacksLabel',
                dotnetConfig, [dsIndex, dIndex, vl]);
        };
    }

    if (config?.options?.plugins?.tooltip?.callbacks?.hasCustomTitle) {
        config.options.plugins.tooltip.callbacks.hasCustomTitle = undefined;
        config.options.plugins.tooltip.callbacks.title = function (ctx) {
            var dsIndex = -1;
            var dIndex = -1;
            var vl = 0;
            if (ctx[0].datasetIndex >= 0 && ctx[0].dataIndex >= 0) {
                dsIndex = ctx[0].datasetIndex;
                dIndex = ctx[0].dataIndex;
                vl = chart.data.datasets[dsIndex].data[dIndex];
            }
            return DotNet.invokeMethod('PSC.Blazor.Components.Chartjs', 'TitleCallbacks',
                dotnetConfig, [dsIndex, dIndex, vl]);
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

            var rtn = {
                DataX: dataX,
                DataY: dataY
            };

            return DotNet.invokeMethodAsync('PSC.Blazor.Components.Chartjs', 'OnHoverAsync',
                dotnetConfig, rtn);
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

    if (config?.options?.scales != null) {
        var scales = Object.keys(config.options.scales);
        for (let scale of scales) {
            if (config.options.scales[scale]?.ticks?.hasCallback) {
                config.options.scales[scale].ticks.hasCallback = undefined;
                config.options.scales[scale].ticks.hasCallback = undefined;
                config.options.scales[scale].ticks.callback = function (value, index, ticks) {
                    return DotNet.invokeMethod('PSC.Blazor.Components.Chartjs', 'TicksCallback',
                        dotnetConfig, scale, value, index, ticks.map(tick => tick.value));
                };
            }
            if (config.options.scales[scale]?.ticks?.hasAsyncCallback) {
                config.options.scales[scale].ticks.hasAsyncCallback = undefined;
                config.options.scales[scale].ticks.callbackAsync = function (value, index, ticks) {
                    return DotNet.invokeMethodAsync('PSC.Blazor.Components.Chartjs', 'TicksCallbackAsync',
                        dotnetConfig, scale, value, index, ticks.map(tick => tick.value));
                };
            }
        }
    }

    if (typeof ChartDataLabels !== 'undefined' && config?.options?.registerDataLabels) {
        config?.options?.registerDataLabels == undefined;
        Chart.register(ChartDataLabels);
    }
    if (typeof ChartDataLabels !== 'undefined' && !config?.options?.registerDataLabels) {
        config?.options?.registerDataLabels == undefined;
        Chart.unregister(ChartDataLabels);
    }

    var chart = new Chart(context2d, config);
    if (crosshair_plugin) {
        chart.canvas.addEventListener("mousemove", (evt) => {
            crosshairLine(chart, evt, crosshair_plugin);
        });
    }

    chart.options.onClick = function (evt, activeElements, chart) {
        if (activeElements.length > 0) {
            var dsIndex = activeElements[0].datasetIndex;
            var dIndex = activeElements[0].index;
            var vl = 0;

            if (dsIndex >= 0 && dIndex >= 0) {
                vl = chart.data.datasets[dsIndex].data[dIndex];
            }

            var rtn = {
                DatasetIndex: dsIndex,
                DataIndex: dIndex,
                Value: vl
            };

            DotNet.invokeMethodAsync('PSC.Blazor.Components.Chartjs', 'OnClickAsync',
                dotnetConfig, rtn);
        }
    };

    chart.options.plugins.legend.onClick = function (e, legendItem) {
        var rtn = {
            LegendIndex: legendItem.index,
            LegendText: legendItem.text
        };

        DotNet.invokeMethodAsync('PSC.Blazor.Components.Chartjs', 'OnLegendClickAsync',
            dotnetConfig, rtn);
    };
}

export function addData(id, label, dataset, data) {
    var chart = Chart.getChart(id);

    if (label !== null)
        chart.data.labels.push(label);
    if (dataset < chart.data.datasets.length)
        chart.data.datasets[dataset].data.push(data);

    chart.update();
}

export function addNewDataset(id, dataset) {
    var chart = Chart.getChart(id);
    chart.data.datasets.push(dataset);
    chart.update();
}

export function clearData(id) {
    var chart = Chart.getChart(id);

    chart.data.labels = [];

    chart.data.datasets.forEach((dataset) => {
        dataset.data = [];
    });

    chart.update();
}