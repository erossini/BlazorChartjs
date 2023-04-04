namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Class AxisInteractions.
    /// </summary>
    public class AxisInteractions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossAlign"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private AxisInteractions(string value)
        { Value = value; }

        /// <summary>
        /// Gets the r.
        /// </summary>
        /// <value>The r.</value>
        public static AxisInteractions R
        { get { return new AxisInteractions("r"); } }

        /// <summary>
        /// X
        /// </summary>
        /// <value>
        /// X
        /// </value>
        public static AxisInteractions X
        { get { return new AxisInteractions("x"); } }

        /// <summary>
        /// Gets the xy.
        /// </summary>
        /// <value>The xy.</value>
        public static AxisInteractions XY
        { get { return new AxisInteractions("xy"); } }

        /// <summary>
        /// Gets the y.
        /// </summary>
        /// <value>The y.</value>
        public static AxisInteractions Y
        { get { return new AxisInteractions("y"); } }
        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; private set; }
    }
}