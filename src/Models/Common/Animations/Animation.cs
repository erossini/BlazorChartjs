namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public class Animation
    {
        /// <summary>
        /// Gets or sets the delay before starting the animations.
        /// </summary>
        /// <value>
        /// The delay.
        /// </value>
        [JsonPropertyName("delay")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Delay { get; set; }

        /// <summary>
        /// Gets or sets the number of milliseconds an animation takes.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        [JsonPropertyName("duration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Duration { get; set; }

        /// <summary>Gets or sets the easing function to use</summary>
        /// <value>
        ///   <para>
        /// Easing function to use. Choose one of the following options</para>
        ///   <list type="bullet">
        ///     <item>linear</item>
        ///     <item>easeInQuad</item>
        ///     <item>easeOutQuad</item>
        ///     <item>easeInOutQuad</item>
        ///     <item>easeInCubic</item>
        ///     <item>easeOutCubic</item>
        ///     <item>easeInOutCubic</item>
        ///     <item>easeInQuart</item>
        ///     <item>easeOutQuart</item>
        ///     <item>easeInOutQuart</item>
        ///     <item>easeInQuint</item>
        ///     <item>easeOutQuint</item>
        ///     <item>easeInOutQuint</item>
        ///     <item>easeInSine</item>
        ///     <item>easeOutSine</item>
        ///     <item>easeInOutSine</item>
        ///     <item>easeInExpo</item>
        ///     <item>easeOutExpo</item>
        ///     <item>easeInOutExpo</item>
        ///     <item>easeInCirc</item>
        ///     <item>easeOutCirc</item>
        ///     <item>easeInOutCirc</item>
        ///     <item>easeInElastic</item>
        ///     <item>easeOutElastic</item>
        ///     <item>easeInOutElastic</item>
        ///     <item>easeInBack</item>
        ///     <item>easeOutBack</item>
        ///     <item>easeInOutBack</item>
        ///     <item>easeInBounce</item>
        ///     <item>easeOutBounce</item>
        ///     <item>easeInOutBounce</item>
        ///   </list>
        /// </value>
        [JsonPropertyName("easing")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Easing { get; set; }

        /// <summary>
        /// Gets or sets the loop.
        /// </summary>
        /// <value>
        /// The loop.
        /// </value>
        [JsonPropertyName("loop")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Loop { get; set; }
    }
}