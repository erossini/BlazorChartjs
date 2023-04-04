namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Class DatalabelsAlign.
    /// </summary>
    public class DatalabelsAlign
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatalabelsAlign"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private DatalabelsAlign(string value)
        { Value = value; }

        /// <summary>
        /// Gets the bottom.
        /// </summary>
        /// <value>The bottom.</value>
        public static DatalabelsAlign Bottom
        { get { return new DatalabelsAlign("bottom"); } }

        /// <summary>
        /// Center
        /// </summary>
        /// <value>
        /// Center
        /// </value>
        public static DatalabelsAlign Center
        { get { return new DatalabelsAlign("center"); } }

        /// <summary>
        /// End
        /// </summary>
        /// <value>
        /// End
        /// </value>
        public static DatalabelsAlign End
        { get { return new DatalabelsAlign("end"); } }

        /// <summary>
        /// Gets the left.
        /// </summary>
        /// <value>The left.</value>
        public static DatalabelsAlign Left
        { get { return new DatalabelsAlign("left"); } }

        /// <summary>
        /// Gets the right.
        /// </summary>
        /// <value>The right.</value>
        public static DatalabelsAlign Right
        { get { return new DatalabelsAlign("right"); } }

        /// <summary>
        /// Start
        /// </summary>
        /// <value>
        /// Start
        /// </value>
        public static DatalabelsAlign Start
        { get { return new DatalabelsAlign("start"); } }

        /// <summary>
        /// Gets the top.
        /// </summary>
        /// <value>The top.</value>
        public static DatalabelsAlign Top
        { get { return new DatalabelsAlign("top"); } }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; private set; }
    }
}