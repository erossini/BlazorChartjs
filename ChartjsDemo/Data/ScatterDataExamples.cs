using PSC.Blazor.Components.Chartjs.Models.Scatter;

namespace ChartjsDemo.Data
{
    public static class ScatterDataExamples
    {
        public static string ScatterSimpleText = "Scatter Dataset";
        public static List<ScatterXYValue> ScatterDatasets = new List<ScatterXYValue>() {
            new ScatterXYValue() { X = -10, Y = 0 },
            new ScatterXYValue() { X = 0, Y = 10 },
            new ScatterXYValue() { X = 10, Y = 5 },
            new ScatterXYValue() { X = 0.5M, Y = 5.5M }
        };
        public static string ScatterMultiAxes = "Scatter Multi Axes";
        public static List<ScatterXYValue> ScatterMultiAxesDatasets = new List<ScatterXYValue>() {
            new ScatterXYValue() { X = -8, Y = 2 },
            new ScatterXYValue() { X = 5, Y = 6 },
            new ScatterXYValue() { X = 4, Y = 7 },
            new ScatterXYValue() { X = 3.5M, Y = 3.5M }
        };
    }
}
