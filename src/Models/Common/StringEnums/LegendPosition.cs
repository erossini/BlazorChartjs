namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public class LegendPosition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegendPosition"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private LegendPosition(string value)
        { Value = value; }

        /// <summary>
        /// Bar
        /// </summary>
        /// <value>
        /// Bar
        /// </value>
        public static LegendPosition Bar
        { get { return new LegendPosition("bar"); } }

        /// <summary>
        /// Bottom
        /// </summary>
        /// <value>
        /// Bottom
        /// </value>
        public static LegendPosition Bottom
        { get { return new LegendPosition("bottom"); } }

        /// <summary>
        /// Chart area
        /// </summary>
        /// <value>
        /// Chart area
        /// </value>
        public static LegendPosition ChartArea
        { get { return new LegendPosition("chartArea"); } }

        /// <summary>
        /// Left
        /// </summary>
        /// <value>
        /// Left
        /// </value>
        public static LegendPosition Left
        { get { return new LegendPosition("left"); } }

        /// <summary>
        /// Right.
        /// </summary>
        /// <value>
        /// Right
        /// </value>
        public static LegendPosition Right
        { get { return new LegendPosition("right"); } }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; private set; }
    }
}