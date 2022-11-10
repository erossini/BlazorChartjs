namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Point Style
    /// </summary>
    public class PointStyle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PointStyle"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private PointStyle(string value)
        { Value = value; }

        /// <summary>
        /// The circle.
        /// </summary>
        /// <value>
        /// The circle.
        /// </value>
        public static PointStyle Circle
        { get { return new PointStyle("circle"); } }

        /// <summary>
        /// The cross.
        /// </summary>
        /// <value>
        /// The cross.
        /// </value>
        public static PointStyle Cross
        { get { return new PointStyle("cross"); } }

        /// <summary>
        /// The cross rot.
        /// </summary>
        /// <value>
        /// The cross rot.
        /// </value>
        public static PointStyle CrossRot
        { get { return new PointStyle("crossRot"); } }

        /// <summary>
        /// The dash.
        /// </summary>
        /// <value>
        /// The dash.
        /// </value>
        public static PointStyle Dash
        { get { return new PointStyle("dash"); } }

        /// <summary>
        /// The line.
        /// </summary>
        /// <value>
        /// The line.
        /// </value>
        public static PointStyle Line
        { get { return new PointStyle("line"); } }

        /// <summary>
        /// The rectangle.
        /// </summary>
        /// <value>
        /// The rectangle.
        /// </value>
        public static PointStyle Rectangle
        { get { return new PointStyle("rect"); } }

        /// <summary>
        /// The rectangle rot.
        /// </summary>
        /// <value>
        /// The rectangle rot.
        /// </value>
        public static PointStyle RectangleRot
        { get { return new PointStyle("rectRot"); } }

        /// <summary>
        /// The rectangle rounded.
        /// </summary>
        /// <value>
        /// The rectangle rounded.
        /// </value>
        public static PointStyle RectangleRounded
        { get { return new PointStyle("rectRounded"); } }

        /// <summary>
        /// The star.
        /// </summary>
        /// <value>
        /// The star.
        /// </value>
        public static PointStyle Star
        { get { return new PointStyle("star"); } }

        /// <summary>
        /// The triangle.
        /// </summary>
        /// <value>
        /// The triangle.
        /// </value>
        public static PointStyle Triangle
        { get { return new PointStyle("triangle"); } }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; private set; }
    }
}