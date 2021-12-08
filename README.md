# Create chart with Chart.js in Blazor
This library is a wrap around [Chart.js](https://www.chartjs.org/) for using it with [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/). The components is build with .NET6.

> I have just started this project and you have only the Bar Chart implementation. If you like the idea to have Chart.js in Blazor, please help me. Very appreciated!

## Installation
Fist, you have to add the component from [NuGet](https://www.nuget.org/packages/PSC.Blazor.Components.Chartjs/). Then, open your `index.html` or `_Host` and add at the end of the page the following scripts:

```
<script src="_content/PSC.Blazor.Components.Chartjs/lib/Chart.js/chart.js"></script>
<script src="_content/PSC.Blazor.Components.Chartjs/Chart.js"></script>
```

The first script is the Chart.js library version 3.5.1 because I'm using this version to create the components. You can use other sources for it but maybe you can face issues in other versions.

Then, open your `_Imports.razor` and add the following:

```
@using PSC.Blazor.Components.Chartjs
@using PSC.Blazor.Components.Chartjs.Enums
@using PSC.Blazor.Components.Chartjs.Models
@using PSC.Blazor.Components.Chartjs.Models.Bar
```

## Add a new chart
In your page you can create a new chart adding this code

```
<Chart Config="_config1" @ref="_chart1" Id="@Id1"></Chart>
```

In the code section you have to define those variables:

```
private string Id1 = "chart-name";
private BarChartConfig _config1;
private Chart _chart1;
```

Then, you can pass the configuration for the chart into `_config1` (in the example code above). For a bar chart, the configuration is

```
_config1 = new BarChartConfig()
{
    CanvasId = Id1,
    Type = ChartType.Bar,
    Options = new Options()
    {
        Plugins = new Plugins()
        {
            Legend = new Legend()
            {
                Align = LegendAlign.Center,
                Display = false,
                Position = LegendPosition.Right
            }
        },
        Scales = new Scales()
        {
            X = new XAxes()
            {
                Stacked = true,
                Ticks = new Ticks()
                {
                    MaxRotation = 0,
                    MinRotation = 0
                }
            },
            Y = new YAxes()
            {
                Stacked = true
            }
        }
    }
};
```

Then, you have to define the `Labels` and the `Datasets` like that

```
_config1.Data.Labels = BarDataExamples.SimpleBarText;
_config1.Data.Datasets.Add(new Dataset()
{
    Label = "Value",
    Data = BarDataExamples.SimpleBar.Select(l => l.Value).ToList(),
    BackgroundColor = Colors.Palette1,
    BorderColor = Colors.PaletteBorder1,
    BorderWidth = 1
});
```

The result of the code above is this chart

![image](https://user-images.githubusercontent.com/9497415/145194274-63997957-82ab-4b38-a2bf-bdd748c2b005.png)

## Implemented charts
- [ ] Bar chart
- [ ] Line chart
- [ ] Area
- [ ] Other charts
  - [ ] Scatter
  - [ ] Scatter - Multi axis
  - [ ] Doughnut
  - [ ] Pie
  - [ ] Multi Series Pie
  - [ ] Polar area
  - [ ] Radar
  - [ ] Radar skip points
  - [ ] Combo bar/line
  - [ ] Stacked bar/line

# Contributors
We thank everyone who has taken their time to open detailed issues, discuss problems with us or contribute code to the repository. Without you, projects like this would be very hard to maintain!

Check out the [list of contributors](https://github.com/erossini/BlazorChartjs/graphs/contributors).

## Other Blazor components

| Component name | Forum | Description |
|---|---|---|
| [DataTable for Blazor](https://www.puresourcecode.com/dotnet/net-core/datatable-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/datatables/) | DataTable component for Blazor WebAssembly and Blazor Server |
| [Markdown editor for Blazor](https://www.puresourcecode.com/dotnet/blazor/markdown-editor-with-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/markdown-editor-for-blazor/) |  This is a Markdown Editor for use in Blazor. It contains a live preview as well as an embeded help guide for users. |
| [Modal dialog for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) |  Simple Modal Dialog for Blazor WebAssembly |
| [PSC.Extensions](https://www.puresourcecode.com/dotnet/net-core/a-lot-of-functions-for-net5/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) |  A lot of functions for .NET5 in a NuGet package that you can download for free. We collected in this package functions for everyday work to help you with claim, strings, enums, date and time, expressions... |
| [Quill for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-a-blazor-component-for-quill/) | [Forum](https://www.puresourcecode.com/forum/forum/quill-for-blazor/) |  Quill Component is a custom reusable control that allows us to easily consume Quill and place multiple instances of it on a single page in our Blazor application |
| [Segment for Blazor](https://www.puresourcecode.com/dotnet/blazor/segment-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/segments-for-blazor/) |  This is a Segment component for Blazor Web Assembly and Blazor Server |
| [Tabs for Blazor](https://www.puresourcecode.com/dotnet/blazor/tabs-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/tabs-for-blazor/) |  This is a Tabs component for Blazor Web Assembly and Blazor Server |

## More examples and documentation
*   [Write a reusable Blazor component](https://www.puresourcecode.com/dotnet/blazor/write-a-reusable-blazor-component/)
*   [Getting Started With C# And Blazor](https://www.puresourcecode.com/dotnet/net-core/getting-started-with-c-and-blazor/)
*   [Setting Up A Blazor WebAssembly Application](https://www.puresourcecode.com/dotnet/blazor/setting-up-a-blazor-webassembly-application/)
*   [Working With Blazor Component Model](https://www.puresourcecode.com/dotnet/blazor/working-with-blazors-component-model/)
*   [Secure Blazor WebAssembly With IdentityServer4](https://www.puresourcecode.com/dotnet/blazor/secure-blazor-webassembly-with-identityserver4/)
*   [Blazor Using HttpClient With Authentication](https://www.puresourcecode.com/dotnet/blazor/blazor-using-httpclient-with-authentication/)
*   [InputSelect component for enumerations in Blazor](https://www.puresourcecode.com/dotnet/blazor/inputselect-component-for-enumerations-in-blazor/)
*   [Use LocalStorage with Blazor WebAssembly](https://www.puresourcecode.com/dotnet/blazor/use-localstorage-with-blazor-webassembly/)
*   [Modal Dialog component for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/)
*   [Create Tooltip component for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-tooltip-component-for-blazor/)
*   [Consume ASP.NET Core Razor components from Razor class libraries | Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/class-libraries?view=aspnetcore-5.0&tabs=visual-studio)
