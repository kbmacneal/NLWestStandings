using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class WindSpeedRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Mean wind speed calculated at a right angle (transverse) to the trajectory of the ball in the horizontal direction.
        /// </summary>
        /// <value>Mean wind speed calculated at a right angle (transverse) to the trajectory of the ball in the horizontal direction.</value>
        [DataMember(Name = "side", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "side")]
        public double? Side { get; set; }

        /// <summary>
        /// Mean wind speed calculated along the trajectory of the ball. A tail wind is positive and a headwind is negative.
        /// </summary>
        /// <value>Mean wind speed calculated along the trajectory of the ball. A tail wind is positive and a headwind is negative.</value>
        [DataMember(Name = "tail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tail")]
        public double? Tail { get; set; }

        /// <summary>
        /// Mean wind speed component affecting the pitch trajectory in the vertical (z) direction.
        /// </summary>
        /// <value>Mean wind speed component affecting the pitch trajectory in the vertical (z) direction.</value>
        [DataMember(Name = "vertical", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vertical")]
        public double? Vertical { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindSpeedRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Tail: ").Append(Tail).Append("\n");
            sb.Append("  Vertical: ").Append(Vertical).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}