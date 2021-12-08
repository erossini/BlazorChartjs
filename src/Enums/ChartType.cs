using PSC.Blazor.Components.Chartjs.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Enums
{
    /// <summary>
    /// Defines the chart types.
    /// </summary>
    public struct ChartType
    {
        /// <summary>
        /// The bar chart type.
        /// </summary>
        public const string Bar = "bar";

        /// <summary>
        /// The line chart type.
        /// </summary>
        public const string Line = "line";

        /// <summary>
        /// The pie chart type.
        /// </summary>
        public const string Pie = "pie";

        /// <summary>
        /// The doughnut chart type.
        /// </summary>
        public const string Doughnut = "doughnut";

        /// <summary>
        /// The radar chart type.
        /// </summary>
        public const string Radar = "radar";

        /// <summary>
        /// The bubble chart type.
        /// </summary>
        public const string Bubble = "bubble";

        /// <summary>
        /// The polar area chart type.
        /// </summary>
        public const string PolarArea = "polarArea";

        /// <summary>
        /// The scatter chart type.
        /// </summary>
        public const string Scatter = "scatter";
    }
}