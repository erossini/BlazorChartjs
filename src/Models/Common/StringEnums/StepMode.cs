using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Common.StringEnums
{
    /// <summary>
    /// Class StepMode.
    /// </summary>
    public class StepMode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepMode"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private StepMode(string value) { Value = value; }

        /// <summary>
        /// Gets the false (default).
        /// </summary>
        /// <value>
        /// The false.
        /// </value>
        public static StepMode False { get { return new StepMode("false"); } }

        /// <summary>
        /// Stepped line in default mode (Before).
        /// </summary>
        /// <value>
        /// true.
        /// </value>
        public static StepMode True { get { return new StepMode("true"); } }

        /// <summary>
        /// Line rises before the point.
        /// </summary>
        /// <value>
        /// before.
        /// </value>
        public static StepMode Before { get { return new StepMode("before"); } }

        /// <summary>
        /// Line rises after point.
        /// </summary>
        /// <value>
        /// after.
        /// </value>
        public static StepMode After { get { return new StepMode("after"); } }

        /// <summary>
        /// Line rises before and falls after the point.
        /// </summary>
        /// <value>
        /// middle.
        /// </value>
        public static StepMode Middle { get { return new StepMode("middle"); } }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; private set; }
    }
}