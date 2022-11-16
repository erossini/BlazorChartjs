namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Class TextDirection.
    /// </summary>
    public class TextDirection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextDirection"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private TextDirection(string value)
        { Value = value; }

        /// <summary>
        /// Gets the left to right.
        /// </summary>
        /// <value>The LTR.</value>
        public static TextDirection LTR
        { get { return new TextDirection("ltr"); } }

        /// <summary>
        /// Gets the right to left.
        /// </summary>
        /// <value>The RTL.</value>
        public static TextDirection RTL
        { get { return new TextDirection("rtl"); } }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; private set; }
    }
}