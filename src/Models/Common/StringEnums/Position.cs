namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public class Position
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private Position(string value) { Value = value; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; private set; }

        /// <summary>
        /// Top.
        /// </summary>
        /// <value>
        /// Top.
        /// </value>
        public static Position Top { get { return new Position("top"); } }

        /// <summary>
        /// Left.
        /// </summary>
        /// <value>
        /// Left.
        /// </value>
        public static Position Left { get { return new Position("left"); } }

        /// <summary>
        /// Bottom.
        /// </summary>
        /// <value>
        /// Bottom.
        /// </value>
        public static Position Bottom { get { return new Position("bottom"); } }

        /// <summary>
        /// Right.
        /// </summary>
        /// <value>
        /// Right.
        /// </value>
        public static Position Right { get { return new Position("right"); } }
    }
}
