namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Class DataLabels.
    /// </summary>
    public class DataLabels
    {
        /// <summary>Gets or sets the align.</summary>
        /// <value>
        ///   <para>The align option defines the position of the label relative to the anchor point position and orientation. Its value can be expressed either by a number representing the clockwise angle (in degree) or by one of the following string presets:</para>
        ///   <list type="bullet">
        ///     <item>'center' (default): the label is centered on the anchor point</item>
        ///     <item>'start': the label is positioned before the anchor point, following the same direction</item>
        ///     <item>'end': the label is positioned after the anchor point, following the same direction</item>
        ///     <item>'right': the label is positioned to the right of the anchor point (0°)</item>
        ///     <item>'bottom': the label is positioned to the bottom of the anchor point (90°)</item>
        ///     <item>'left': the label is positioned to the left of the anchor point (180°)</item>
        ///     <item>'top': the label is positioned to the top of the anchor point (270°)<br /></item>
        ///   </list>
        ///   <para>For more details see <a href="https://chartjs-plugin-datalabels.netlify.app/guide/positioning.html#alignment-and-offset">this link</a>.</para>
        /// </value>
        [JsonIgnore]
        public DatalabelsAlign? Align
        {
            get => _align;
            set
            {
                _align = value;
                AlignString = _align.Value;
            }
        }
        private DatalabelsAlign? _align;

        /// <summary>
        /// Gets or sets the align string.
        /// </summary>
        /// <value>The align string.</value>
        [JsonPropertyName("align")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AlignString { get; set; }

        /// <summary>
        /// Gets or sets the anchor.
        /// </summary>
        /// <value>The anchor.</value>
        [JsonIgnore]
        public DatalabelsAnchor? Anchor
        {
            get => _anchor;
            set
            {
                _anchor = value;
                AnchorString = _anchor.Value;
            }
        }
        private DatalabelsAnchor? _anchor;

        /// <summary>
        /// Gets or sets the align string.
        /// </summary>
        /// <value>The align string.</value>
        [JsonPropertyName("anchor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AnchorString { get; set; }

        /// <summary>
        /// Gets or sets the color of the background in HEX
        /// </summary>
        /// <value>The color of the background.</value>
        [JsonPropertyName("backgroundColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the border in HEX
        /// </summary>
        /// <value>The color of the border.</value>
        [JsonPropertyName("borderColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the border radius.
        /// </summary>
        /// <value>The border radius.</value>
        [JsonPropertyName("borderRadius")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int BorderRadius { get; set; }

        /// <summary>
        /// Gets or sets the width of the border.
        /// </summary>
        /// <value>The width of the border.</value>
        [JsonPropertyName("borderWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int BorderWidth { get; set; }

        /// <summary>Gets or sets a value indicating whether this <see cref="T:PSC.Blazor.Components.Chartjs.Models.Common.DataLabels" /> is clamp.</summary>
        /// <value>
        ///   <para>The clamp option, when <strong>true</strong>, enforces the anchor position to be calculated based on the visible geometry of the associated element.</para>
        ///   <para>For more details, see <a href="https://chartjs-plugin-datalabels.netlify.app/guide/positioning.html#clamping">this link</a>.</para>
        /// </value>
        [JsonPropertyName("clamp")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Clamp { get; set; } = false;

        /// <summary>
        /// When the clip option is true, the part of the label which is outside the chart area will be masked (see <a href="https://chartjs-plugin-datalabels.netlify.app/guide/positioning.html#clipping">CanvasRenderingContext2D.clip()</a>)
        /// </summary>
        /// <value><c>true</c> if clip; otherwise, <c>false</c>.</value>
        [JsonPropertyName("clip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Clip { get; set; } = false;

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>The color.</value>
        [JsonPropertyName("color")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Color { get; set; }

        /// <summary>
        /// Gets or sets the font.
        /// </summary>
        /// <value>The font.</value>
        [JsonPropertyName("font")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Font? Font { get; set; }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>
        ///   <para>The offset represents the distance (in pixels) to pull the label away from the anchor point. 
        ///   This option is not applicable when align is 'center'. Also note that if align is 'start', 
        ///   the label is moved in the opposite direction. The default value is 4.</para>
        /// </value>
        [JsonPropertyName("offset")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the opacity.
        /// </summary>
        /// <value>The opacity.</value>
        [JsonPropertyName("opacity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Opacity { get; set; }

        /// <summary>
        /// Gets or sets the padding.
        /// </summary>
        /// <value>The padding.</value>
        [JsonPropertyName("padding")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Padding? Padding { get; set; }

        /// <summary>
        /// Gets or sets the rotation.
        /// </summary>
        /// <value>The rotation.</value>
        [JsonPropertyName("rotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Rotation { get; set; }

        /// <summary>
        /// Gets or sets the text align.
        /// </summary>
        /// <value>The text align.</value>
        [JsonIgnore]
        public DatalabelsTextAlign? TextAlign
        {
            get => _textAlign;
            set
            {
                _textAlign = value;
                TextAlignString = _textAlign.Value;
            }
        }
        private DatalabelsTextAlign? _textAlign;

        /// <summary>
        /// Gets or sets the align string.
        /// </summary>
        /// <value>The align string.</value>
        [JsonPropertyName("textAlign")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TextAlignString { get; set; }

        /// <summary>
        /// Gets or sets the color of the text stroke.
        /// </summary>
        /// <value>The color of the text stroke.</value>
        [JsonPropertyName("textStrokeColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TextStrokeColor { get; set; }

        /// <summary>
        /// Gets or sets the width of the text stroke.
        /// </summary>
        /// <value>The width of the text stroke.</value>
        [JsonPropertyName("textStrokeWidth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int TextStrokeWidth { get; set; }

        /// <summary>
        /// Gets or sets the text shadow blur.
        /// </summary>
        /// <value>The text shadow blur.</value>
        [JsonPropertyName("textShadowBlur")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int textShadowBlur { get; set; }

        /// <summary>
        /// Gets or sets the color of the text shadow.
        /// </summary>
        /// <value>The color of the text shadow.</value>
        [JsonPropertyName("textShadowColor")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TextShadowColor { get; set; }
    }
}
