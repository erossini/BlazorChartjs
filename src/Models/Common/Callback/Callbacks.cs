namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Callbacks
    /// </summary>
    public sealed class Callbacks
    {
        // https://www.chartjs.org/docs/3.7.1/configuration/tooltip.html

        /// <summary>
        /// Gets a value indicating whether this instance has label.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has label; otherwise, <c>false</c>.
        /// </value>
        [JsonInclude]
        [JsonPropertyName("hasLabel")]
        public bool HasLabel => Label != null;

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        [JsonIgnore]
        public Func<CallbackGenericContext, string[]>? Label { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has custom title.
        /// </summary>
        /// <value><c>true</c> if this instance has custom title; otherwise, <c>false</c>.</value>
        [JsonInclude]
        [JsonPropertyName("hasCustomTitle")]
        public bool HasCustomTitle => Title != null;

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [JsonIgnore]
        public Func<CallbackGenericContext, string[]>? Title { get; set; }
    }
}