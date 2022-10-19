using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Options
    /// </summary>
    public class Options : IOptions
    {
        /// <summary>
        /// Gets or sets the elements.
        /// </summary>
        /// <value>
        /// The elements.
        /// </value>
        [JsonPropertyName("elements")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Elements? Elements { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has on hover asynchronous.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has on hover asynchronous; otherwise, <c>false</c>.
        /// </value>
        [JsonInclude]
        [JsonPropertyName("hasOnHoverAsync")]
        public bool HasOnHoverAsync => OnHoverAsync != null;

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        [JsonIgnore]
        public string Height { get; set; }

        /// <summary>
        /// Gets or sets the index axis. <seealso cref="Axes"/>
        /// </summary>
        /// <value>
        /// X or Y
        /// </value>
        [JsonPropertyName("indexAxis")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string IndexAxis { get; set; } = Axes.Default;

        /// <summary>
        /// Gets or sets a value indicating whether [maintain aspect ratio].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [maintain aspect ratio]; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("maintainAspectRatio")]
        public bool MaintainAspectRatio { get; set; } = false;

        /// <summary>
        /// Gets or sets the on hover asynchronous.
        /// </summary>
        /// <value>
        /// The on hover asynchronous.
        /// </value>
        [JsonIgnore]
        public Func<HoverContext, ValueTask>? OnHoverAsync { get; set; }

        /// <summary>
        /// Gets or sets the plugins.
        /// </summary>
        /// <value>
        /// The plugins.
        /// </value>
        [JsonPropertyName("plugins")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Plugins Plugins { get; set; } = new Plugins();

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Options"/> is responsive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if responsive; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("responsive")]
        public bool Responsive { get; set; } = true;

        /// <summary>
        /// Gets or sets the scales.
        /// </summary>
        /// <value>
        /// The scales.
        /// </value>
        [JsonPropertyName("scales")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, Axis> Scales { get; set; }
    }
}