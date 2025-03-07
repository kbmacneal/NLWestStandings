using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class FieldZoneRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets FieldZone
        /// </summary>
        [DataMember(Name = "fieldZone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fieldZone")]
        public FieldZoneTypeRestObject FieldZone { get; set; }

        /// <summary>
        /// Gets or Sets Calm
        /// </summary>
        [DataMember(Name = "calm", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "calm")]
        public CalmDeviation Calm { get; set; }

        /// <summary>
        /// Gets or Sets Indoor
        /// </summary>
        [DataMember(Name = "indoor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "indoor")]
        public IndoorDeviation Indoor { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldZoneRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  FieldZone: ").Append(FieldZone).Append("\n");
            sb.Append("  Calm: ").Append(Calm).Append("\n");
            sb.Append("  Indoor: ").Append(Indoor).Append("\n");
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