namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Class CubicInterpolationMode.
    /// </summary>
    public class CubicInterpolationMode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CubicInterpolationMode"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private CubicInterpolationMode(string value) { Value = value; }

        /// <summary>
        /// Gets the defaut.
        /// </summary>
        /// <value>The defaut.</value>
        public static CubicInterpolationMode Default { get { return new CubicInterpolationMode("default"); } }

        /// <summary>
        /// Gets the monotone.
        /// </summary>
        /// <value>The monotone.</value>
        public static CubicInterpolationMode Monotone { get { return new CubicInterpolationMode("monotone"); } }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; private set; }
    }
}
