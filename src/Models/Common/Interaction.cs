namespace PSC.Blazor.Components.Chartjs.Models.Common 
{
    /// <summary>
    /// Class Interaction.
    /// </summary>
    public class Interaction 
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Interaction"/> is intersect.
        /// If true, the interaction mode only applies when the mouse position intersects an item on the chart.
        /// </summary>
        /// <value><c>null</c> if intersect contains no value, <c>true</c> if intersect has a value; otherwise, <c>false</c>.</value>
        [JsonPropertyName("intersect")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Intersect { get; set; }

        /// <summary>
        /// Gets or sets a value indicating if include invisible data.
        /// </summary>
        /// <value><c>null</c> if include invisible contains no value, <c>true</c> if include invisible data has to be included; otherwise, <c>false</c>.</value>
        [JsonPropertyName("includeInvisible")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IncludeInvisible { get; set; }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>The mode.</value>
        [JsonIgnore]
        public InteractionMode? Mode 
        {
            get => _mode;
            set {
                _mode = value;
                ModeString = _mode.Value;
            }
        }
        /// <summary>
        /// The mode
        /// </summary>
        private InteractionMode? _mode;

        /// <summary>
        /// Gets or sets the mode string.
        /// </summary>
        /// <value>The mode string.</value>
        [JsonPropertyName("mode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ModeString { get; set; }


        /// <summary>
        /// Gets or sets the axis.
        /// </summary>
        /// <value>The axis.</value>
        [JsonIgnore]
        public AxisInteractions? Axis 
        {
            get => _axis;
            set {
                _axis = value;
                AxisString = _axis.Value;
            }
        }
        /// <summary>
        /// The axis
        /// </summary>
        private AxisInteractions? _axis;

        /// <summary>
        /// Gets or sets the axis string.
        /// </summary>
        /// <value>The axis string.</value>
        [JsonPropertyName("axis")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AxisString { get; set; }
    }
}
