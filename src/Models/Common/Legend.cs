namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Legend
    /// </summary>
    public class Legend
    {
        /// <summary>
        /// Gets or sets the align. <seealso cref="Common.Align"/>
        /// </summary>
        /// <value>
        /// The align.
        /// </value>
        [JsonIgnore]
        public Align? Align {
            get => _align;
            set
            {
                _align = value;
                AlignString = _align.Value;
            }
        }
        private Align? _align;

        /// <summary>
        /// Gets or sets the align string.
        /// </summary>
        /// <value>
        /// The align string.
        /// </value>
        [JsonPropertyName("align")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AlignString { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Legend"/> is display.
        /// </summary>
        /// <value>
        ///   <c>true</c> if display; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("display")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Display { get; set; } = true;

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [JsonIgnore]
        public LegendPosition Position {
            get => _legendPosition;
            set {
                _legendPosition = value;
                PositionString = value.Value;
            }
        }
        private LegendPosition _legendPosition;

        /// <summary>
        /// Gets or sets the position. <seealso cref="LegendPosition"/>
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [JsonPropertyName("position")]
        public string? PositionString { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Legend"/> is reverse.
        /// </summary>
        /// <value>
        ///   <c>true</c> if reverse; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("reverse")]
        public bool Reverse { get; set; } = false;
    }
}