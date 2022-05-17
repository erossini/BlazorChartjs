using PSC.Blazor.Components.Chartjs.Models.Radar;

namespace ChartjsDemo.Data
{
    public static class RadarDataExamples
    {
        /// <summary>
        /// The radar simple text
        /// </summary>
        public static List<string> RadarSimpleText = new List<string>() {
            "Eating",
            "Drinking",
            "Sleeping",
            "Designing",
            "Coding",
            "Cycling",
            "Running"
        };

        /// <summary>
        /// The radar datasets
        /// </summary>
        public static List<RadarDataset> RadarDatasets = new List<RadarDataset>() {
            new RadarDataset() {
                Label = "My First Dataset",
                Data = new List<decimal>() { 65, 59, 90, 81, 56, 55, 40 },
                Fill = true,
                BackgroundColor = "rgba(255, 99, 132, 0.2)",
                BorderColor = "rgb(255, 99, 132)",
                PointBackgroundColor = "rgb(255, 99, 132)",
                PointBorderColor = "#fff",
                PointHoverBackgroundColor = "#fff",
                PointHoverBorderColor = "rgb(255, 99, 132)"
            },
            new RadarDataset() {
                Label = "My Second Dataset",
                Data =  new List<decimal>() { 28, 48, 40, 19, 96, 27, 100 },
                Fill = true,
                BackgroundColor = "rgba(54, 162, 235, 0.2)",
                BorderColor = "rgb(54, 162, 235)",
                PointBackgroundColor = "rgb(54, 162, 235)",
                PointBorderColor = "#fff",
                PointHoverBackgroundColor = "#fff",
                PointHoverBorderColor = "rgb(54, 162, 235)"
            }
        };
    }
}