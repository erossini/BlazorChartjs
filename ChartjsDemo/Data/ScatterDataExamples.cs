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
    }
}
