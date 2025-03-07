using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BatPositionRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Identifier for which part of the bat the positions/timeStamp represent. For now this will only be the “head” and the “handle”, but is subject to change in the future.
        /// </summary>
        /// <value>Identifier for which part of the bat the positions/timeStamp represent. For now this will only be the “head” and the “handle”, but is subject to change in the future.</value>
        [DataMember(Name = "positionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "positionId")]
        public string PositionId { get; set; }

        /// <summary>
        /// Locations of the head of the bat at the given timeStamps.
        /// </summary>
        /// <value>Locations of the head of the bat at the given timeStamps.</value>
        [DataMember(Name = "positions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "positions")]
        public List<PositionRestObject> Positions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatPositionRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
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