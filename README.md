# ChartJs component for Blazor
This library is a wrap around [Chart.js](https://www.chartjs.org/) for using it with [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/). The component was built with [NET6](https://puresourcecode.com/tag/net6/) until the version [6.0.44](https://www.nuget.org/packages/PSC.Blazor.Components.Chartjs/). The version [7.0](https://www.nuget.org/packages/PSC.Blazor.Components.Chartjs/7.0.0) is for [NET7](https://puresourcecode.com/tag/net7/).
The version [8.x](https://www.nuget.org/packages/PSC.Blazor.Components.Chartjs/8.0.4) is for [NET8](https://puresourcecode.com/tag/net8).

## Links
* [Demo website](https://chartjs.puresourcecode.com/)
* Source code on [GitHub](https://github.com/erossini/BlazorChartjs)
* [Support forum](https://www.puresourcecode.com/forum/chart-js-for-blazor/)
* [NuGet](https://www.nuget.org/packages/PSC.Blazor.Components.Chartjs/) package

## Articles
* [ChartJs component for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/)
* [Labels and OnClickChart for ChartJs](https://www.puresourcecode.com/dotnet/blazor/labels-and-onclickchart-for-chartjs/)

## Installation
First, you have to add the component from [NuGet](https://www.nuget.org/packages/PSC.Blazor.Components.Chartjs/). Then, open your `index.html` or `_Host` and add at the end of the page the following scripts:

```
<script src="_content/PSC.Blazor.Components.Chartjs/lib/Chart.js/chart.js"></script>
<script src="_content/PSC.Blazor.Components.Chartjs/Chart.js" type="module"></script>
```

The first script is the Chart.js library version 3.7.1 because I'm using this version to create the components. You can use other sources for it but maybe you can face issues in other versions.

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
On your page you can create a new chart by adding this code

```
<Chart Config="_config1" @ref="_chart1"></Chart>
```

In the code section you have to define the variables:

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

## Add new values

When a graph is created, it means that the configuration is already defined and the datasets are passed to the chart engine. Without recreating the graph, it is possible to add a new value to a specific dataset and/or add a completely new dataset to the graph.

On your page, create a new chart by adding this code

```
<Chart Config="_config1" @ref="_chart1"></Chart>
```

In the code section you have to define the variables:

```csharp
private LineChartConfig _config1;
private Chart _chart1;
```

_chart1_ is the reference to the `Chart` component and from it, you can access all the functions and properties the component has to offer.

### Add a new value

In an existing graph, it is possible to add a single new value to a specific dataset calling `AddData` function that is available on the chart.

Now, the function `AddData` allows to add a new value in a specific existing dataset. The definition of `AddData` is the following

```csharp
AddData(List<string> labels, int datasetIndex, List<decimal?> data)
```

For example, using __chart1_, the following code adds a new label `Test1` to the list of labels, and for the dataset _0_ adds a random number.

```csharp
_chart1.AddData(new List<string?>() { "Test1" }, 0, new List<decimal?>() { rd.Next(0, 200) });
```

The result is visible in the following screenshot.

![chart-addnewdata](https://user-images.githubusercontent.com/9497415/229902251-8a2adf61-b37c-4fdc-a869-ca8eb1a7cd81.gif)

### Add a new dataset

It is also possible to add a completely new dataset to the graph. For that, there is the function `AddDataset`. This function requires a new dataset of the same format as the others already existing in the chart.

For example, this code adds a new dataset using `LineDataset` using some of the properties this dataset has.

```csharp
private void AddNewDataset()
{
    Random rd = new Random();
    List<decimal?> addDS = new List<decimal?>();
    for (int i = 0; i < 8; i++)
    {
        addDS.Add(rd.Next(i, 200));
    }

    var color = String.Format("#{0:X6}", rd.Next(0x1000000));

    _chart1.AddDataset<LineDataset>(new LineDataset()
        {
            Label = $"Dataset {DateTime.Now}",
            Data = addDS,
            BorderColor = color,
            Fill = false
        });
}
```

The result of this code is the following screenshot.

![chart-addnewdataset](https://user-images.githubusercontent.com/9497415/229904537-22805b25-747f-4020-9eed-51533183324c.gif)

## Callbacks

The component has a few callbacks (more in development) to customize your chart. The callbacks are ready to use are:

- Tooltip
  * Labels
  * Titles

### How to use it

In the configuration of the chart in your Blazor page, you can add your custom code for each callback. 
For an example, see the following code.

```csharp
protected override async Task OnInitializedAsync()
{
    _config1 = new BarChartConfig()
        {
            Options = new Options()
            {
                Responsive = true,
                MaintainAspectRatio = false,
                Plugins = new Plugins()
                {
                    Legend = new Legend()
                    {
                        Align = Align.Center,
                        Display = true,
                        Position = LegendPosition.Right
                    },
                    Tooltip = new Tooltip()
                    {
                        Callbacks = new Callbacks()
                        {
                            Label = (ctx) =>
                            {
                                return new[] { 
                                    $"DataIndex: {ctx.DataIndex}\nDatasetIndex: {ctx.DatasetIndex}" };
                            },
                            Title = (ctx) =>
                            {
                                return new[] { $"This is the value {ctx.Value}" };
                            }
                        }
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

For more info, please see my posts on [PureSourceCode.com](https://www.puresourcecode.com/dotnet/blazor/custom-javascript-function-in-blazor/).

## Add labels to the chart

I added the `chartjs-plugin-datalabels` plugin in the component. This plugin shows the labels for each point in each graph. For more details about this plugin, visit its [website](https://chartjs-plugin-datalabels.netlify.app/).

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

## OnClickAsync

When a user click on a point on the chart with a value, it is possible to add in the chart configuration a specific function to receive the data for that point ad in particular the index of the dataset, the index of the value in the dataset and the value.

```
<Chart Config="_config1" @ref="_chart1" Height="400px"></Chart>
```

In the configuration, under `Options`, there is `OnClickAsync`. Here, specified the function that has to receive the values (in this case `clickAsync`).

```csharp
_config1 = new LineChartConfig()
    {
        Options = new Options()
        {
            OnClickAsync = clickAsync,
            ...
        }
    }
```

The function `clickAsync` receives as a parameter a `CallbackGenericContext` that contains the 3 values: `DatasetIndex` and `DataIndex` as int and the `Value` as decimal.

In the following example, the function changes the string `ClickString` using `values`.

```csharp
public ValueTask clickAsync(CallbackGenericContext value)
{
    ClickString = $"Dataset index: {value.DatasetIndex} - " +
                    $"Value index: {value.DataIndex} - " + 
                    $"Value: {value.Value}";
    StateHasChanged();

    return ValueTask.CompletedTask;
}
```

With this code, if the user clicks on a point, the function writes the values on the page.

![image](https://user-images.githubusercontent.com/9497415/225041631-805cf3c6-4b3f-4475-b57e-2a1962472c35.png)

## OnHoverAsync

This function returns the position of the cursor on the chart. Define a new chart as usual.

```
<Chart Config="_config1" @ref="_chart1" Height="400px"></Chart>
```

In the configuration, under `Options`, there is `OnHoverAsync`. This provides the position of the cursor on the chart.

```csharp
_config1 = new LineChartConfig()
    {
        Options = new Options()
        {
            OnHoverAsync = hoverAsync,
            ...
        }
    }
```

The function `hoverAsync` receives as parameter a `HoverContext` that contains the 2 values: `DataX` and `DataY` as decimal.

In the following example, the function changes the string `HoverString` using `values`.

```csharp
private ValueTask hoverAsync(HoverContext ctx)
{
    HoverString = $"X: {ctx.DataX} - Y: {ctx.DataY}";
    StateHasChanged();

    return ValueTask.CompletedTask;
}
```

With this code, if the user moves the mouse on the chart, the function writes the values in the page.

![chart-hover](https://user-images.githubusercontent.com/9497415/229874627-e720d5dc-bae2-4cfa-8dcc-55ddc58ef4f9.gif)

## Contribution

- [macias](https://github.com/macias) for adding the crosshair line to the components
- [Heitor Eleutério de Rezende](https://github.com/heitoreleuterio) for the migration to NET7 and adding:
    - Legend Labels Filtering
    - Support to Ticks' AutoSkip and Font properties
    - Tooltip Callback Label problem fixed.
    - Ticks callback

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
| --- | --- | --- | --- | --- |
| AnchorLink | [Forum](https://puresourcecode.com/forum/anchorlink/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.AnchorLink) |     | An anchor link is a web link that allows users to leapfrog to a specific point on a website page. It saves them the need to scroll and skim read and makes navigation easier. This component is for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Autocomplete for Blazor](https://www.puresourcecode.com/dotnet/net-core/autocomplete-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/autocomplete-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Autocomplete) |     | Simple and flexible autocomplete type-ahead functionality for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Browser Detect for Blazor](https://www.puresourcecode.com/dotnet/blazor/browser-detect-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/browser-detect-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.BrowserDetect) | [Demo](https://browserdetect.puresourcecode.com) | Browser detect for Blazor WebAssembly and Blazor Server |
| [ChartJs for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/) | [Forum](https://www.puresourcecode.com/forum/chart-js-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Chartjs) | [Demo](https://chartjs.puresourcecode.com/) | Add beautiful graphs based on ChartJs in your Blazor application |
| [Clippy for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/) | [Forum](https://www.puresourcecode.com/forum/clippy/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Clippy) | [Demo](https://clippy.puresourcecode.com/) | Do you miss Clippy? Here the implementation for Blazor |
| [CodeSnipper for Blazor](https://www.puresourcecode.com/dotnet/blazor/code-snippet-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/codesnippet-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.CodeSnippet) |     | Add code snippet in your Blazor pages for 196 programming languages with 243 styles |
| [Copy To Clipboard](https://www.puresourcecode.com/dotnet/blazor/copy-to-clipboard-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/copytoclipboard/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.CopyToClipboard) |     | Add a button to copy text in the clipboard |
| [DataTable for Blazor](https://www.puresourcecode.com/dotnet/net-core/datatable-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/datatables/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.DataTable) | [Demo](https://datatable.puresourcecode.com/) | DataTable component for Blazor WebAssembly and Blazor Server |
| Google Tag Manager | \[Forum\]() | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.GoogleTagManager) | [Demo](https://datatable.puresourcecode.com/) | Adds Google Tag Manager to the application and manages communication with GTM JavaScript (data layer). |
| [Icons and flags for Blazor](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Icons) |     | Library with a lot of SVG icons and SVG flags to use in your Razor pages |
| ImageSelect for Blazor | [Forum](https://puresourcecode.com/forum/imageselect/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ImageSelect) |     | This is a Blazor component to display a dropdown list with images based on ms-Dropdown by Marghoob Suleman. This component is built with NET7 for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Markdown editor for Blazor](https://www.puresourcecode.com/dotnet/blazor/markdown-editor-with-blazor/) | [Forum](https://puresourcecode.com/forum/markdowneditor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.MarkdownEditor) | [Demo](https://markdown.puresourcecode.com/) | This is a Markdown Editor for use in Blazor. It contains a live preview as well as an embeded help guide for users. |
| [Modal dialog for Blazor](https://puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://puresourcecode.com/forum/modaldialog/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ModalDialog) |     | Simple Modal Dialog for Blazor WebAssembly |
| [Modal windows for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://puresourcecode.com/forum/modaldialog/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Modals) |     | Modal Windows for Blazor WebAssembly |
| [Quill for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-a-blazor-component-for-quill/) | [Forum](https://puresourcecode.com/forum/blazor-components/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Quill) |     | Quill Component is a custom reusable control that allows us to easily consume Quill and place multiple instances of it on a single page in our Blazor application |
| [ScrollTabs](https://www.puresourcecode.com/dotnet/blazor/scrolltabs-component-for-blazor/) |     | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ScrollTabs) |     | Tabs with nice scroll (no scrollbar) and responsive |
| [Segment for Blazor](https://www.puresourcecode.com/dotnet/blazor/segment-control-for-blazor/) | [Forum](https://puresourcecode.com/forum/segments/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Segments) |     | This is a Segment component for Blazor Web Assembly and Blazor Server |
| [Tabs for Blazor](https://www.puresourcecode.com/dotnet/blazor/tabs-control-for-blazor/) | [Forum](https://puresourcecode.com/forum/tabs/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Tabs) |     | This is a Tabs component for Blazor Web Assembly and Blazor Server |
| [Timeline for Blazor](https://www.puresourcecode.com/dotnet/blazor/timeline-component-for-blazor/) | [Forum](https://puresourcecode.com/forum/timeline/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Timeline) |     | This is a new responsive timeline for Blazor Web Assembly and Blazor Server |
| [Toast for Blazor](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://puresourcecode.com/forum/blazor-components/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Toast) |     | Toast notification for Blazor applications |
| [Tours for Blazor](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://puresourcecode.com/forum/blazor-components/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Tours) |     | Guide your users in your Blazor applications |
| TreeView for Blazor | [Forum](https://puresourcecode.com/forum/treeview/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.TreeView) |     | This component is a native Blazor TreeView component for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/). The component is built with .NET7. |
| [WorldMap for Blazor](https://puresourcecode.com/dotnet/blazor/world-map-component-for-blazor) | [Forum](https://puresourcecode.com/forum/worldmap/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.WorldMap) | [Demo](https://worldmap.puresourcecode.com/) | Show world maps with your data |

## C# libraries for .NET6

| Component name | Forum | NuGet | Description |
|---|---|---|---|
| [PSC.Evaluator](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Evaluator) | PSC.Evaluator is a mathematical expressions evaluator library written in C#. Allows to evaluate mathematical, boolean, string and datetime expressions. |
| [PSC.Extensions](https://www.puresourcecode.com/dotnet/net-core/a-lot-of-functions-for-net5/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Extensions) | A lot of functions for .NET5 in a NuGet package that you can download for free. We collected in this package functions for everyday work to help you with claim, strings, enums, date and time, expressions... |

## More examples and documentation

### Blazor
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
*   [ChartJs component for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/)
*   [Labels and OnClickChart for ChartJs](https://www.puresourcecode.com/dotnet/blazor/labels-and-onclickchart-for-chartjs/)

### Blazor & NET8
* [Custom User Management with NET8 and Blazor (1st part)](https://puresourcecode.com/dotnet/blazor/custom-user-management-with-net8-and-blazor/)
* [NET8, Blazor and Custom User Management (2nd part)](https://puresourcecode.com/dotnet/blazor/net8-blazor-and-custom-user-management/)

--- 

[<img src="https://api.gitsponsors.com/api/badge/img?id=436196115" height="20">](https://api.gitsponsors.com/api/badge/link?p=hKwXXB5S8D5W56dYwJn+LlT+6h62Dhf5B0CSkGu2KUMSG+AyG3ACGNa3LPaUVzVF)
