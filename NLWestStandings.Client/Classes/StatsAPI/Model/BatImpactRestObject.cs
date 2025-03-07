using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BatImpactRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// The angle of the bat's path, at impact, relative to horizontal. A negative value represents swinging downward, a positive value upward.
        /// </summary>
        /// <value>The angle of the bat's path, at impact, relative to horizontal. A negative value represents swinging downward, a positive value upward.</value>
        [DataMember(Name = "attackAngle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attackAngle")]
        public double? AttackAngle { get; set; }

        /// <summary>
        /// Gets or Sets Speed
        /// </summary>
        [DataMember(Name = "speed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "speed")]
        public BatImpactSpeedRestObject Speed { get; set; }

        /// <summary>
        /// Gets or Sets ContactPoint
        /// </summary>
        [DataMember(Name = "contactPoint", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contactPoint")]
        public ContactPointPositionRestObject ContactPoint { get; set; }

        /// <summary>
        /// Gets or Sets HeadPosition
        /// </summary>
        [DataMember(Name = "headPosition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "headPosition")]
        public HeadPositionRestObject HeadPosition { get; set; }

        /// <summary>
        /// Gets or Sets HandlePosition
        /// </summary>
        [DataMember(Name = "handlePosition", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "handlePosition")]
        public HandlePositionRestObject HandlePosition { get; set; }

        /// <summary>
        /// Gets or Sets Velocity
        /// </summary>
        [DataMember(Name = "velocity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "velocity")]
        public BatImpactVelocityRestObject Velocity { get; set; }

        /// <summary>
        /// TimeStamp when bat and ball either intersect in case of contact, or in cases where they don’t collide, timeStamp where ball is closest to any point along the bat.
        /// </summary>
        /// <value>TimeStamp when bat and ball either intersect in case of contact, or in cases where they don’t collide, timeStamp where ball is closest to any point along the bat.</value>
        [DataMember(Name = "timeStamp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeStamp")]
        public string TimeStamp { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatImpactRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  AttackAngle: ").Append(AttackAngle).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
            sb.Append("  ContactPoint: ").Append(ContactPoint).Append("\n");
            sb.Append("  HeadPosition: ").Append(HeadPosition).Append("\n");
            sb.Append("  HandlePosition: ").Append(HandlePosition).Append("\n");
            sb.Append("  Velocity: ").Append(Velocity).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
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