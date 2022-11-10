namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public class Align
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Align"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private Align(string value)
        { Value = value; }

        /// <summary>
        /// Start
        /// </summary>
        /// <value>
        /// Start
        /// </value>
        public static Align Start
        { get { return new Align("start"); } }

        /// <summary>
        /// Center
        /// </summary>
        /// <value>
        /// Center
        /// </value>
        public static Align Center
        { get { return new Align("center"); } }

        /// <summary>
        /// End
        /// </summary>
        /// <value>
        /// End
        /// </value>
        public static Align End
        { get { return new Align("end"); } }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; private set; }
    }
}