using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BatSweetSpotRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Distance from the sweetSpot to the impact point along the bat. Negative is towards the handle of the bat, positive towards the head.
        /// </summary>
        /// <value>Distance from the sweetSpot to the impact point along the bat. Negative is towards the handle of the bat, positive towards the head.</value>
        [DataMember(Name = "axialOffset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "axialOffset")]
        public double? AxialOffset { get; set; }

        /// <summary>
        /// Distance along the bat from the sweetSpot towards the head. Will be constant for all swings.
        /// </summary>
        /// <value>Distance along the bat from the sweetSpot towards the head. Will be constant for all swings.</value>
        [DataMember(Name = "distanceFromHead", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "distanceFromHead")]
        public double? DistanceFromHead { get; set; }

        /// <summary>
        /// The speed of the sweetSpot right before contact.
        /// </summary>
        /// <value>The speed of the sweetSpot right before contact.</value>
        [DataMember(Name = "speedBeforeImpact", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "speedBeforeImpact")]
        public double? SpeedBeforeImpact { get; set; }

        /// <summary>
        /// Distance from the sweetSpot to the impact point perpendicular to the bat. Negative is below the center of the bat, positive is above.
        /// </summary>
        /// <value>Distance from the sweetSpot to the impact point perpendicular to the bat. Negative is below the center of the bat, positive is above.</value>
        [DataMember(Name = "radialOffset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "radialOffset")]
        public double? RadialOffset { get; set; }

        /// <summary>
        /// Gets or Sets Velocity
        /// </summary>
        [DataMember(Name = "velocity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "velocity")]
        public BatImpactVelocityRestObject Velocity { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatSweetSpotRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  AxialOffset: ").Append(AxialOffset).Append("\n");
            sb.Append("  DistanceFromHead: ").Append(DistanceFromHead).Append("\n");
            sb.Append("  SpeedBeforeImpact: ").Append(SpeedBeforeImpact).Append("\n");
            sb.Append("  RadialOffset: ").Append(RadialOffset).Append("\n");
            sb.Append("  Velocity: ").Append(Velocity).Append("\n");
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