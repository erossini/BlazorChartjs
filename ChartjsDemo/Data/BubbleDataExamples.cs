using PSC.Blazor.Components.Chartjs.Models.Bubble;

namespace ChartjsDemo.Data
{
    public static class BubbleDataExamples
    {
        public static List<string> SimpleBubbleText = new List<string>() { "First Dataset" };
        public static List<BubbleCoords> SimpleBubble = new List<BubbleCoords>() {
            new BubbleCoords() { R = 15, X = 20, Y = 30 },
            new BubbleCoords() { R = 10, X = 40, Y = 10 },
            new BubbleCoords() { R = 14, X = 30, Y = 20 },
        };
    }
}