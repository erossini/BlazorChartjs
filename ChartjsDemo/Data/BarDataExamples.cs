namespace ChartjsDemo.Data;

public static class BarDataExamples
{
    public static List<string> SimpleBarText = new List<string>() { "January", "February", "March", "Aprl", "May", "June", "July" };
    public static List<DataItem> SimpleBar = new List<DataItem>() {
            new DataItem() { Name = "January", Value = 65 },
            new DataItem() { Name = "February", Value = 59 },
            new DataItem() { Name = "March", Value = 80 },
            new DataItem() { Name = "April", Value = 81 },
            new DataItem() { Name = "May", Value = 56 },
            new DataItem() { Name = "June", Value = 55 },
            new DataItem() { Name = "July", Value = 40 }
        };
}