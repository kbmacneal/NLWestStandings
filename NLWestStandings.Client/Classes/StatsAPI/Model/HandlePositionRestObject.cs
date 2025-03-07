using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Location of the handle of the bat during impact. The distance from head to handle is currently fixed at 32.677 inches.
    /// </summary>
    [DataContract]
    public class HandlePositionRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Location in the horizontal dimension, negative toward third base, positive toward first base.
        /// </summary>
        /// <value>Location in the horizontal dimension, negative toward third base, positive toward first base.</value>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "x")]
        public double? X { get; set; }

        /// <summary>
        /// Location in the depth dimension, negative toward the backstop, positive toward pitcher’s mound.
        /// </summary>
        /// <value>Location in the depth dimension, negative toward the backstop, positive toward pitcher’s mound.</value>
        [DataMember(Name = "y", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "y")]
        public double? Y { get; set; }

        /// <summary>
        /// Location in the vertical dimension, from the ground upward.
        /// </summary>
        /// <value>Location in the vertical dimension, from the ground upward.</value>
        [DataMember(Name = "z", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "z")]
        public double? Z { get; set; }

        /// <summary>
        /// Gets or Sets TimeStamp
        /// </summary>
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
            sb.Append("class HandlePositionRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Z: ").Append(Z).Append("\n");
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