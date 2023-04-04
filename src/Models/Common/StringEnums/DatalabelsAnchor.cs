namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Class DatalabelsAnchor.
    /// </summary>
    public class DatalabelsAnchor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatalabelsAnchor"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private DatalabelsAnchor(string value)
        { Value = value; }

        /// <summary>
        /// Start
        /// </summary>
        /// <value>
        /// Start
        /// </value>
        public static DatalabelsAnchor Start
        { get { return new DatalabelsAnchor("start"); } }

        /// <summary>
        /// Center
        /// </summary>
        /// <value>
        /// Center
        /// </value>
        public static DatalabelsAnchor Center
        { get { return new DatalabelsAnchor("center"); } }

        /// <summary>
        /// End
        /// </summary>
        /// <value>
        /// End
        /// </value>
        public static DatalabelsAnchor End
        { get { return new DatalabelsAnchor("end"); } }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; private set; }
    }
}