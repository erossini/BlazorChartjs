namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Axes Title
    /// </summary>
    public class AxesTitle
    {
        /// <summary>
        /// Gets or sets the align.
        /// </summary>
        /// <value>The align.</value>
        [JsonIgnore]
        public Align Align {
            get => _align;
            set
            {
                _align = value;
                AlignString = _align.Value;
            }
        }
        private Align _align;

        /// <summary>
        /// Gets or sets the align string.
        /// </summary>
        /// <value>The align string.</value>
        [JsonPropertyName("align")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string AlignString { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>The color.</value>
        [JsonPropertyName("color")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the font.
        /// </summary>
        /// <value>The font.</value>
        [JsonPropertyName("font")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Font Font { get; set; }

        /// <summary>
        /// Gets or sets the display.
        /// </summary>
        /// <value>
        /// The display.
        /// </value>
        [JsonPropertyName("display")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Display { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [JsonPropertyName("text")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Text { get; set; }
    }
}