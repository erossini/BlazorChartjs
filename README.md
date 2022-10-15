# Create chart with Chart.js in Blazor
This library is a wrap around [Chart.js](https://www.chartjs.org/) for using it with [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/). The components is build with .NET6.

Few important links:
* [Demo website](https://chartjs.puresourcecode.com/)
* Source code on [GitHub](https://github.com/erossini/BlazorChartjs)
* [Support forum](https://www.puresourcecode.com/forum/chart-js-for-blazor/)

## Installation
Fist, you have to add the component from [NuGet](https://www.nuget.org/packages/PSC.Blazor.Components.Chartjs/). Then, open your `index.html` or `_Host` and add at the end of the page the following scripts:

```
<script src="_content/PSC.Blazor.Components.Chartjs/lib/Chart.js/chart.js"></script>
<script src="_content/PSC.Blazor.Components.Chartjs/Chart.js"></script>
```

The first script is the [Chart.js](https://www.chartjs.org/) library version [3.9.1](https://github.com/chartjs/Chart.js/releases/tag/v3.9.1) because I'm using this version to create the components. You can use other sources for it but maybe you can face issues in other versions.

Then, open your `_Imports.razor` and add the following:

```
@using PSC.Blazor.Components.Chartjs
@using PSC.Blazor.Components.Chartjs.Enums
@using PSC.Blazor.Components.Chartjs.Models
@using PSC.Blazor.Components.Chartjs.Models.Common
@using PSC.Blazor.Components.Chartjs.Models.Bar
@using PSC.Blazor.Components.Chartjs.Models.Bubble
@using PSC.Blazor.Components.Chartjs.Models.Doughnut
@using PSC.Blazor.Components.Chartjs.Models.Line
@using PSC.Blazor.Components.Chartjs.Models.Pie
@using PSC.Blazor.Components.Chartjs.Models.Polar
@using PSC.Blazor.Components.Chartjs.Models.Radar
@using PSC.Blazor.Components.Chartjs.Models.Scatter
```

There is a namespace for each chart plus the common namespaces (Enum, Models and the base).

## Add a new chart
In your page you can create a new chart adding this code

```
<Chart Config="_config1" @ref="_chart1"></Chart>
```

In the code section you have to define those variables:

```
private BarChartConfig _config1;
private Chart _chart1;
```

Then, you can pass the configuration for the chart into `_config1` (in the example code above). For a bar chart, the configuration is

```
_config1 = new BarChartConfig()
{
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
        Scales = new Dictionary<string, Axis>()
        {
            {
                Scales.XAxisId, new Axis()
                {
                    Stacked = true,
                    Ticks = new Ticks()
                    {
                        MaxRotation = 0,
                        MinRotation = 0
                    }
                }
            },
            {
                Scales.YAxisId, new Axis()
                {
                    Stacked = true
                }
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
- [x] Bar chart
- [x] Line chart
- [x] Area
- [ ] Other charts
  - [x] Scatter
  - [ ] Scatter - Multi axis
  - [x] Doughnut
  - [x] Pie
  - [ ] Multi Series Pie
  - [x] Polar area
  - [x] Radar
  - [x] Radar skip points
  - [ ] Combo bar/line
  - [x] Stacked bar/line

---
    
## Other Blazor components

| Component name | Forum | Description |
|---|---|---|
| [DataTable for Blazor](https://www.puresourcecode.com/dotnet/net-core/datatable-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/datatables/) | DataTable component for Blazor WebAssembly and Blazor Server |
| [Markdown editor for Blazor](https://www.puresourcecode.com/dotnet/blazor/markdown-editor-with-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/markdown-editor-for-blazor/) |  This is a Markdown Editor for use in Blazor. It contains a live preview as well as an embeded help guide for users. |
| [Browser Detect for Blazor](https://www.puresourcecode.com/dotnet/blazor/browser-detect-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/browser-detect-for-blazor/) | Browser detect for Blazor WebAssembly and Blazor Server |
| [CodeSnipper for Blazor](https://www.puresourcecode.com/dotnet/blazor/code-snippet-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/codesnippet-for-blazor/) | Add code snippet in your Blazor pages for 196 programming languages with 243 styles |
| [Copy To Clipboard](https://www.puresourcecode.com/dotnet/blazor/copy-to-clipboard-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/copytoclipboard/) | Add a button to copy text in the clipbord | 
| SVG Icons and flags for Blazor | [Forum](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | Library with a lot of SVG icons and SVG flags to use in your Razor pages |
| [Modal dialog for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) |  Simple Modal Dialog for Blazor WebAssembly |
| [PSC.Extensions](https://www.puresourcecode.com/dotnet/net-core/a-lot-of-functions-for-net5/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) |  A lot of functions for .NET5 in a NuGet package that you can download for free. We collected in this package functions for everyday work to help you with claim, strings, enums, date and time, expressions... |
| [Quill for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-a-blazor-component-for-quill/) | [Forum](https://www.puresourcecode.com/forum/forum/quill-for-blazor/) |  Quill Component is a custom reusable control that allows us to easily consume Quill and place multiple instances of it on a single page in our Blazor application |
| [Segment for Blazor](https://www.puresourcecode.com/dotnet/blazor/segment-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/segments-for-blazor/) |  This is a Segment component for Blazor Web Assembly and Blazor Server |
| [Tabs for Blazor](https://www.puresourcecode.com/dotnet/blazor/tabs-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/tabs-for-blazor/) |  This is a Tabs component for Blazor Web Assembly and Blazor Server |
| [WorldMap for Blazor]() | [Forum](https://www.puresourcecode.com/forum/worldmap-for-blazor/) | Show world maps with your data |

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
