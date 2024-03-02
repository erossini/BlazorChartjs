namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public class ScaleLimits
    {
        private int? _min = null;
        private int? _max = null;

        /// <summary>
        /// Minimum allowed value for scale.min. 
        /// </summary>
        /// <value>
        /// The min.
        /// </value>
        [JsonPropertyName("min")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Min {
            get
            {
                if(_min == null)
                {
                    return "original";
                }
                return _min.ToString();
            }
            set
            {
                if(value == null)
                {
                    _min = null;
                } else
                {
                    try
                    {
                        _min = Convert.ToInt32(value);
                    }
                    catch { }
                }
            }
        }

        /// <summary>
        /// Maximum allowed value for scale.max. 
        /// </summary>
        /// <value>
        /// The max.
        /// </value>
        [JsonPropertyName("max")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Max
        {
            get
            {
                if (_min == null)
                {
                    return "original";
                }
                return _max.ToString();
            }
            set
            {
                if (value == null)
                {
                    _max = null;
                }
                else
                {
                    try
                    {
                        _max = Convert.ToInt32(value);
                    }
                    catch { }
                }
            }
        }

        /// <summary>
        /// Minimum allowed range (max - min). This defines the max zoom level. 
        /// </summary>
        /// <value>
        /// The minRange.
        /// </value>
        [JsonPropertyName("minRange")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? MinRange { get; set; }
    }
}
