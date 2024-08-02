using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs.Models.Common 
{
    /// <summary>
    /// Ticks
    /// </summary>
    public class Ticks 
    {
        /// <summary>
        /// Gets a value indicating whether this instance has callback.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has callback; otherwise, <c>false</c>.
        /// </value>
        [JsonInclude]
        [JsonPropertyName("hasCallback")]
        public bool HasCallback => Callback != null;
        /// <summary>
        /// Gets a value indicating whether this instance has callback.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has callback; otherwise, <c>false</c>.
        /// </value>
        [JsonInclude]
        [JsonPropertyName("hasAsyncCallback")]
        public bool HasAsyncCallback => CallbackAsync != null;
        /// <summary>
        /// Gets or sets the callback.
        /// </summary>
        /// <value>
        /// The call back.
        /// </value>
        [JsonIgnore]
        public Func<TicksCallbackContext, string[]>? Callback { get; set; }
        /// <summary>
        /// Gets or sets the callback.
        /// </summary>
        /// <value>
        /// The call back.
        /// </value>
        [JsonIgnore]
        public Func<TicksCallbackContext, Task<string[]>>? CallbackAsync { get; set; }

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
        /// Gets or sets the cross align.
        /// </summary>
        /// <value>
        /// The cross align
        /// </value>
        [JsonIgnore]
        public CrossAlign? CrossAlign 
        {
            get => _crossAlign;
            set 
            {
                _crossAlign = value;
                CrossAlignString = _crossAlign.Value;
            }
        }
        private CrossAlign? _crossAlign;

        /// <summary>
        /// Gets or sets the cross align.
        /// </summary>
        /// <value>
        /// The cross align.
        /// </value>
        [JsonPropertyName("crossAlign")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CrossAlignString { get; set; }

        [JsonPropertyName("font")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Font? Font { get; set; }

        /// <summary>
        /// Gets or sets the maximum rotation.
        /// </summary>
        /// <value>
        /// The maximum rotation.
        /// </value>
        [JsonPropertyName("maxRotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxRotation { get; set; }

        /// <summary>
        /// Gets or sets the Maximum number of ticks and gridlines to show.
        /// </summary>
        /// <value>The maximum ticks limit.</value>
        [JsonPropertyName("maxTicksLimit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxTicksLimit { get; set; }

        /// <summary>
        /// Gets or sets the minimum rotation.
        /// </summary>
        /// <value>
        /// The minimum rotation.
        /// </value>
        [JsonPropertyName("minRotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MinRotation { get; set; }

        ///<summary>
        /// Gets or sets the Auto skip.
        /// If true, automatically calculates how many labels can be shown and hides labels accordingly. 
        /// Labels will be rotated up to maxRotation before skipping any. Turn autoSkip off to show all labels no matter what.
        ///</summary>
        ///<value>
        /// The auto skip
        ///</value>
        [JsonPropertyName("autoSkip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoSkip { get; set; }

        /// <summary>
        /// Gets or sets the size of the step. 
        /// If set, the scale ticks will be enumerated by multiple of stepSize, having one tick per increment. 
        /// If not set, the ticks are labelled automatically using the nice numbers algorithm.
        /// </summary>
        /// <value>The size of the step.</value>
        [JsonPropertyName("stepSize")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? StepSize { get; set; }
    }
}
