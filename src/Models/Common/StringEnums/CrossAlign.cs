namespace PSC.Blazor.Components.Chartjs.Models
{
    /// <summary>
    /// Point Style
    /// </summary>
    public class CrossAlign
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossAlign"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private CrossAlign(string value) { Value = value; }

        /// <summary>
        /// Near
        /// </summary>
        /// <value>
        /// Near
        /// </value>
        public static CrossAlign Near { get { return new CrossAlign("near"); } }

        /// <summary>
        /// Center
        /// </summary>
        /// <value>
        /// Center
        /// </value>
        public static CrossAlign Center { get { return new CrossAlign("center"); } }

        /// <summary>
        /// Far
        /// </summary>
        /// <value>
        /// Far
        /// </value>
        public static CrossAlign Far { get { return new CrossAlign("far"); } }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; private set; }
    }
}