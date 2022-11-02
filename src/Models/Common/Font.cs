namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Font
    /// </summary>
    public class Font
    {
        /// <summary>
        /// Gets or sets the family.
        /// </summary>
        /// <value>
        /// Default font family for all text, follows CSS font-family options
        /// </value>
        [JsonPropertyName("family")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Family { get; set; }

        /// <summary>Gets or sets the height of the line.</summary>
        /// <value>Height of an individual line of text (see <a href="https://developer.mozilla.org/en-US/docs/Web/CSS/line-height" target="_blank">MDN</a>)</value>
        [JsonPropertyName("lineHeight")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? LineHeight { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
        /// </value>
        [JsonPropertyName("size")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        /// <value>
        /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title.
        /// Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
        /// </value>
        [JsonPropertyName("style")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Style { get; set; }

        /// <summary>Gets or sets the weight.</summary>
        /// <value>Default font weight (boldness) (see <a href="https://developer.mozilla.org/en-US/docs/Web/CSS/font-weight" target="_blank">MDN</a>)</value>
        [JsonPropertyName("weight")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Weight { get; set; }
    }
}