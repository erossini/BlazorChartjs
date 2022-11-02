using System.Diagnostics;

namespace ChartjsDemo.Data;

public static class BarDataExamples
{
    public static List<string> SimpleBarText = new List<string>() { "January", "February", "March", "April", "May", "June", "July" };
    public static List<DataItem> SimpleBar = new List<DataItem>() {
            new DataItem() { Name = "January", Value = 65 },
            new DataItem() { Name = "February", Value = 59 },
            new DataItem() { Name = "March", Value = 80 },
            new DataItem() { Name = "April", Value = 81 },
            new DataItem() { Name = "May", Value = 56 },
            new DataItem() { Name = "June", Value = 55 },
            new DataItem() { Name = "July", Value = 40 }
        };

    public static List<string> GroupedLabels = new List<string>() { "1900", "1950", "1999", "2050" };
    public static List<decimal> Grouped1 = new List<decimal>() { 133, 221, 783, 2478 };
    public static List<decimal> Grouped2 = new List<decimal>() { 408, 547, 675, 734 };
}