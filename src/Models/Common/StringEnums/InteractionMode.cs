namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Class InteractionMode.
    /// </summary>
    public class InteractionMode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionMode"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private InteractionMode(string value)
        { Value = value; }

        /// <summary>
        /// Gets the dataset.
        /// </summary>
        /// <value>The dataset.</value>
        public static InteractionMode Dataset
        { get { return new InteractionMode("dataset"); } }

        /// <summary>
        /// Gets the index.
        /// </summary>
        /// <value>The index.</value>
        public static InteractionMode Index
        { get { return new InteractionMode("index"); } }

        /// <summary>
        /// Gets the nearest.
        /// </summary>
        /// <value>The nearest.</value>
        public static InteractionMode Nearest
        { get { return new InteractionMode("nearest"); } }

        /// <summary>
        /// Gets the point.
        /// </summary>
        /// <value>The point.</value>
        public static InteractionMode Point
        { get { return new InteractionMode("point"); } }
        /// <summary>
        /// Gets the x.
        /// </summary>
        /// <value>The x.</value>
        public static InteractionMode X
        { get { return new InteractionMode("x"); } }

        /// <summary>
        /// Gets the y.
        /// </summary>
        /// <value>The y.</value>
        public static InteractionMode Y
        { get { return new InteractionMode("y"); } }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; private set; }
    }
}