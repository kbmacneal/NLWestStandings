using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class LandingDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Hang time of the ball's trajectory.
        /// </summary>
        /// <value>Hang time of the ball's trajectory.</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "time")]
        public double? Time { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "position")]
        public LandingPositionRestObject Position { get; set; }

        /// <summary>
        /// Straight-line distance to the landing point of the ball's trajectory. If the ball hits above z=0 this distance is projected down to z=0.
        /// </summary>
        /// <value>Straight-line distance to the landing point of the ball's trajectory. If the ball hits above z=0 this distance is projected down to z=0.</value>
        [DataMember(Name = "distance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "distance")]
        public double? Distance { get; set; }

        /// <summary>
        /// Additional distance attributed to the ball's spin.
        /// </summary>
        /// <value>Additional distance attributed to the ball's spin.</value>
        [DataMember(Name = "offsetSpin", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offsetSpin")]
        public double? OffsetSpin { get; set; }

        /// <summary>
        /// Landing position offset attributed to the wind's impact on the ball's trajectory.
        /// </summary>
        /// <value>Landing position offset attributed to the wind's impact on the ball's trajectory.</value>
        [DataMember(Name = "offsetWind", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offsetWind")]
        public double? OffsetWind { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LandingDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  OffsetSpin: ").Append(OffsetSpin).Append("\n");
            sb.Append("  OffsetWind: ").Append(OffsetWind).Append("\n");
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