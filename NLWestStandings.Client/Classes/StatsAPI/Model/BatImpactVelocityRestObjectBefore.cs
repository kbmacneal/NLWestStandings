using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Velocity of the given point, right before impact.
    /// </summary>
    [DataContract]
    public class BatImpactVelocityRestObjectBefore
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Represents the horizontal dimension, negative toward third base, positive toward first base.
        /// </summary>
        /// <value>Represents the horizontal dimension, negative toward third base, positive toward first base.</value>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "x")]
        public double? X { get; set; }

        /// <summary>
        /// Represents the depth dimension, negative toward the backstop, positive toward pitcher’s mound.
        /// </summary>
        /// <value>Represents the depth dimension, negative toward the backstop, positive toward pitcher’s mound.</value>
        [DataMember(Name = "y", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "y")]
        public double? Y { get; set; }

        /// <summary>
        /// Represents the vertical dimension, from the ground upward.
        /// </summary>
        /// <value>Represents the vertical dimension, from the ground upward.</value>
        [DataMember(Name = "z", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "z")]
        public double? Z { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatImpactVelocityRestObjectBefore {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Z: ").Append(Z).Append("\n");
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