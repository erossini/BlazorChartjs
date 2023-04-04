using PSC.Blazor.Components.Chartjs.Models.Common;

namespace ChartjsDemo.Data
{
    public static class LineDataExamples
    {
        public static List<string> SimpleLineText = new List<string>() { "January", "February", "March", "April", "May", "June", "July" };
        public static List<decimal?> SimpleLine = new List<decimal?>() { 65, 59, 80, 81, 86, 55, 40 };
        public static List<decimal?> SimpleLine2 = new List<decimal?>() { 33, 25, 35, 51, 54, 76, 60 };
        public static List<decimal?> SimpleLine3 = new List<decimal?>() { 53, 91, 39, 61, 39, 87, 23 };

        // custom code
        public static List<string> CustomLineText = new List<string>() { "January", "February", "March", "April", "May", "June" };
        public static List<decimal?> CustomLine = new List<decimal?>() { 60, 80, 81, 56, 55, 40 };

        // multi axes
        public static List<string> MultiAxesLineText = new List<string>() { 
            "January;2015", "February;2015;Y", "March;2015", 
            "January;2016", "February;2016;Y", "March;2016" };
        public static List<decimal?> MultiAxesLine = new List<decimal?>() { 12, 19, 3, 5, 2, 3 };

        public static List<decimal?> BreakLine = new List<decimal?>() { 0, 20, 20, 60, 60, 120, null, 180, 120, 125, 105, 110, 170 };
        public static List<string> BreakLineText = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" };
    }
}