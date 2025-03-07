using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballGameLeadersRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets HitDistance
        /// </summary>
        [DataMember(Name = "hitDistance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitDistance")]
        public BaseballGameLeaderRestObject HitDistance { get; set; }

        /// <summary>
        /// Gets or Sets HitSpeed
        /// </summary>
        [DataMember(Name = "hitSpeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitSpeed")]
        public BaseballGameLeaderRestObject HitSpeed { get; set; }

        /// <summary>
        /// Gets or Sets PitchSpeed
        /// </summary>
        [DataMember(Name = "pitchSpeed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchSpeed")]
        public BaseballGameLeaderRestObject PitchSpeed { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballGameLeadersRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  HitDistance: ").Append(HitDistance).Append("\n");
            sb.Append("  HitSpeed: ").Append(HitSpeed).Append("\n");
            sb.Append("  PitchSpeed: ").Append(PitchSpeed).Append("\n");
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