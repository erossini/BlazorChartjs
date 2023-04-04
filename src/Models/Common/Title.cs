namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Title
    /// </summary>
    public class Title
    {
        /// <summary>
        /// Gets or sets the align.
        /// </summary>
        /// <value>
        /// The align.
        /// </value>
        [JsonIgnore]
        public Align? Align
        {
            get => _align;
            set
            {
                _align = value;
                AlignString = _align.Value;
            }
        }
        private Align? _align;

        /// <summary>Gets or sets the align of the title</summary>
        /// <value>
        ///   <para>
        /// The align of the title. It accepts those values:</para>
        ///   <list type="bullet">
        ///     <item>
        ///       start
        ///     </item>
        ///     <item>
        ///       center
        ///     </item>
        ///     <item>
        ///       end
        ///     </item>
        ///   </list>
        /// </value>
        [JsonPropertyName("align")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AlignString { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        [JsonPropertyName("color")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Color { get; set; }

        /// <summary>
        /// Gets or sets if the title is shown.
        /// </summary>
        /// <value>
        /// The display.
        /// </value>
        [JsonPropertyName("display")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Display { get; set; }

        /// <summary>
        /// Gets or sets the full size.
        /// </summary>
        /// <value>
        /// Marks that this box should take the full width/height of the canvas. 
        /// If false, the box is sized and placed above/beside the chart area.
        /// </value>
        [JsonPropertyName("fullSize")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? FullSize { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [JsonIgnore]
        public Position Position
        {
            get => _position;
            set
            {
                _position = value;
                PositionString = value.Value;
            }
        }
        private Position _position;

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position of the title. It accepts those values:
        ///   <list type="bullet">
        ///     <item>
        ///       top
        ///     </item>
        ///     <item>
        ///       left
        ///     </item>
        ///     <item>
        ///       bottom
        ///     </item>
        ///     <item>
        ///       right
        ///     </item>
        ///   </list>
        /// </value>
        [JsonPropertyName("position")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PositionString { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The Title text to display. If specified as an array, text is rendered on multiple lines
        /// </value>
        [JsonPropertyName("text")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the padding.
        /// </summary>
        /// <value>
        /// The padding to apply around the title. 
        /// </value>
        [JsonPropertyName("padding")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Padding? Padding { get; set; }

        /// <summary>
        /// Gets or sets the font.
        /// </summary>
        /// <value>
        /// The font.
        /// </value>
        [JsonPropertyName("font")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Font? Font { get; set; }
    }
}
