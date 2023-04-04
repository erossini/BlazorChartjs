namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Padding
    /// </summary>
    public class Padding
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Padding"/> class.
        /// </summary>
        public Padding() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Padding"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public Padding(int size)
        {
            Top = size;
            Left = size;
            Right = size;
            Bottom = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Padding" /> class.
        /// </summary>
        /// <param name="top">The top.</param>
        /// <param name="right">The right.</param>
        /// <param name="bottom">The bottom.</param>
        /// <param name="left">The left.</param>
        public Padding(int? top, int? right, int? bottom, int? left)
        {
            Top = top;
            Left = left;
            Bottom = bottom;
            Right = right;
        }

        /// <summary>
        /// Gets or sets the top.
        /// </summary>
        /// <value>
        /// The top.
        /// </value>
        [JsonPropertyName("top")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Top { get; set; }

        /// <summary>
        /// Gets or sets the left.
        /// </summary>
        /// <value>
        /// The left.
        /// </value>
        [JsonPropertyName("left")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Left { get; set; }

        /// <summary>
        /// Gets or sets the bottom.
        /// </summary>
        /// <value>
        /// The bottom.
        /// </value>
        [JsonPropertyName("bottom")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Bottom { get; set; }

        /// <summary>
        /// Gets or sets the right.
        /// </summary>
        /// <value>
        /// The right.
        /// </value>
        [JsonPropertyName("right")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Right { get; set; }
    }
}
