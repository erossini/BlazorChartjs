namespace ChartjsDemo.Data
{
    public static class LineDataExamples
    {
        public static List<string> SimpleLineText = new List<string>() { "January", "February", "March", "April", "May", "June", "July" };
        public static List<decimal> SimpleLine = new List<decimal>() { 65, 59, 80, 81, 56, 55, 40 };
        public static List<decimal> SimpleLine2 = new List<decimal>() { 33, 25, 35, 51, 54, 76, 45 };

        // custom code
        public static List<string> CustomLineText = new List<string>() { "January", "February", "March", "April", "May", "June" };
        public static List<decimal> CustomLine = new List<decimal>() { 60, 80, 81, 56, 55, 40 };

        // multi axes
        public static List<string> MultiAxesLineText = new List<string>() { 
            "January;2015", "February;2015;Y", "March;2015", 
            "January;2016", "February;2016;Y", "March;2016" };
        public static List<decimal> MultiAxesLine = new List<decimal>() { 12, 19, 3, 5, 2, 3 };
    }
}