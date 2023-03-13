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

The first script is the Chart.js library version 3.7.1 because I'm using this version to create the components. You can use other sources for it but maybe you can face issues in other versions.

Then, open your `_Imports.razor` and add the following:

```csharp
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

```csharp
private BarChartConfig _config1;
private Chart _chart1;
```

Then, you can pass the configuration for the chart into `_config1` (in the example code above). For a bar chart, the configuration is

```csharp
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

```csharp
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

![image](https://user-images.githubusercontent.com/9497415/196763122-306142fa-e810-47fc-af06-12d4889ab21f.png)

## Implemented charts
- [x] Bar chart
- [x] Line chart
- [x] Area
- [x] Other charts
  - [x] Scatter
  - [x] Scatter - Multi axis
  - [x] Doughnut
  - [x] Pie
  - [x] Multi Series Pie
  - [x] Polar area
  - [x] Radar
  - [x] Radar skip points
  - [x] Combo bar/line
  - [x] Stacked bar/line


## Add labels to the chart

I added the `chartjs-plugin-datalabels` plugin in the component. This plugin shows the labels for each point in each graph. For more details abour this plugin, visit its [website](https://chartjs-plugin-datalabels.netlify.app/).

![image](https://user-images.githubusercontent.com/9497415/224721251-da6959de-2b20-4d42-926b-b036de6695ee.png)

First, in the _index.html_, we have to add after the `chart.js` script, another script for this component. It is important to add the script for `chartjs-plugin-datalabels` after `chart.js`. If the order is different, the plugin could not work. For example

```
<script src="_content/PSC.Blazor.Components.Chartjs/lib/Chart.js/chart.js"></script>
<script src="_content/PSC.Blazor.Components.Chartjs/lib/hammer.js/hammer.js"></script>
<script src="_content/PSC.Blazor.Components.Chartjs/lib/chartjs-plugin-zoom/chartjs-plugin-zoom.js"></script>
<script src="_content/PSC.Blazor.Components.Chartjs/lib/chartjs-plugin-datalabels/chartjs-plugin-datalabels.js"></script>
```

In the code, you have to change the property `RegisterDataLabels` under `Options` to `true`. That asks to the component to register the library if the library is added to the page and there is data to show. For example, if I define a `LineChartConfig` the code is

```csharp
_config1 = new LineChartConfig()
{
    Options = new Options()
    {
        RegisterDataLabels = true,
        Plugins = new Plugins()
        {
            DataLabels = new DataLabels()
            {
                Align = DatalabelsAlign.Start,
                Anchor = DatalabelsAnchor.Start,
            }
        }
    }
};
```

With this code, the component will register the library in `chart.js`. It is possible to define a `DataLabels` for the entire chart. Also, each dataset can have its own `DataLabels` that rewrites the common settings.

---
    
## PureSourceCode.com

[PureSourceCode.com](https://www.puresourcecode.com/) is my personal blog where I publish posts about technologies and in particular source code and projects in [.NET](https://www.puresourcecode.com/category/dotnet/). 

In the last few months, I created a lot of components for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/).

My name is Enrico Rossini and you can contact me via:
- [Personal Twitter](https://twitter.com/erossiniuk)
- [LinkedIn](https://www.linkedin.com/in/rossiniuk)
- [Facebook](https://www.facebook.com/puresourcecode)

## Blazor Components

| Component name | Forum | NuGet | Website | Description |
|---|---|---|---|---|
| [Autocomplete for Blazor](https://www.puresourcecode.com/dotnet/net-core/autocomplete-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/autocomplete-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Autocomplete) | | Simple and flexible autocomplete type-ahead functionality for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Browser Detect for Blazor](https://www.puresourcecode.com/dotnet/blazor/browser-detect-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/browser-detect-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.BrowserDetect) | [Demo](https://browserdetect.puresourcecode.com) | Browser detect for Blazor WebAssembly and Blazor Server |
| [ChartJs for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/) | [Forum](https://www.puresourcecode.com/forum/chart-js-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Chartjs) | [Demo](https://chartjs.puresourcecode.com/) | Add beautiful graphs based on ChartJs in your Blazor application |
| [Clippy for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/) | [Forum](https://www.puresourcecode.com/forum/clippy/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Clippy) | [Demo](https://clippy.puresourcecode.com/) | Do you miss Clippy? Here the implementation for Blazor |
| [CodeSnipper for Blazor](https://www.puresourcecode.com/dotnet/blazor/code-snippet-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/codesnippet-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.CodeSnippet) | | Add code snippet in your Blazor pages for 196 programming languages with 243 styles |
| [Copy To Clipboard](https://www.puresourcecode.com/dotnet/blazor/copy-to-clipboard-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/copytoclipboard/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.CopyToClipboard) | | Add a button to copy text in the clipboard | 
| [DataTable for Blazor](https://www.puresourcecode.com/dotnet/net-core/datatable-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/datatables/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.DataTable) | [Demo](https://datatable.puresourcecode.com/) | DataTable component for Blazor WebAssembly and Blazor Server |
| [Icons and flags for Blazor](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Icons) | | Library with a lot of SVG icons and SVG flags to use in your Razor pages |
| [Markdown editor for Blazor](https://www.puresourcecode.com/dotnet/blazor/markdown-editor-with-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/markdown-editor-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.MarkdownEditor) | [Demo](https://markdown.puresourcecode.com/) | This is a Markdown Editor for use in Blazor. It contains a live preview as well as an embeded help guide for users. |
| [Modal dialog for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ModalDialog) | | Simple Modal Dialog for Blazor WebAssembly |
| [Modal windows for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Modals) | | Modal Windows for Blazor WebAssembly |
| [Quill for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-a-blazor-component-for-quill/) | [Forum](https://www.puresourcecode.com/forum/forum/quill-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Quill) | | Quill Component is a custom reusable control that allows us to easily consume Quill and place multiple instances of it on a single page in our Blazor application |
| [ScrollTabs](https://www.puresourcecode.com/dotnet/blazor/scrolltabs-component-for-blazor/) | | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ScrollTabs) | | Tabs with nice scroll (no scrollbar) and responsive |
| [Segment for Blazor](https://www.puresourcecode.com/dotnet/blazor/segment-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/segments-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Segments) | | This is a Segment component for Blazor Web Assembly and Blazor Server |
| [Tabs for Blazor](https://www.puresourcecode.com/dotnet/blazor/tabs-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/tabs-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Tabs) | | This is a Tabs component for Blazor Web Assembly and Blazor Server |
| [Timeline for Blazor](https://www.puresourcecode.com/dotnet/blazor/timeline-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/timeline/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Timeline) | | This is a new responsive timeline  for Blazor Web Assembly and Blazor Server |
| [Toast for Blazor](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Toast) | | Toast notification for Blazor applications |
| [Tours for Blazor](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Tours) | | Guide your users in your Blazor applications |
| [WorldMap for Blazor]() | [Forum](https://www.puresourcecode.com/forum/worldmap-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.WorldMap) | [Demo](https://worldmap.puresourcecode.com/) | Show world maps with your data |

## C# libraries for .NET6

| Component name | Forum | NuGet | Description |
|---|---|---|---|
| [PSC.Evaluator](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Evaluator) | PSC.Evaluator is a mathematical expressions evaluator library written in C#. Allows to evaluate mathematical, boolean, string and datetime expressions. |
| [PSC.Extensions](https://www.puresourcecode.com/dotnet/net-core/a-lot-of-functions-for-net5/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Extensions) | A lot of functions for .NET5 in a NuGet package that you can download for free. We collected in this package functions for everyday work to help you with claim, strings, enums, date and time, expressions... |

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
