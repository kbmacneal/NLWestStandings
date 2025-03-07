using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PitchFxDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets X0
        /// </summary>
        [DataMember(Name = "x0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "x0")]
        public CoordinatesRestObject X0 { get; set; }

        /// <summary>
        /// Gets or Sets V0
        /// </summary>
        [DataMember(Name = "v0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "v0")]
        public CoordinatesRestObject V0 { get; set; }

        /// <summary>
        /// Gets or Sets A0
        /// </summary>
        [DataMember(Name = "a0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "a0")]
        public CoordinatesRestObject A0 { get; set; }

        /// <summary>
        /// Gets or Sets PfxVert
        /// </summary>
        [DataMember(Name = "pfxVert", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pfxVert")]
        public double? PfxVert { get; set; }

        /// <summary>
        /// Gets or Sets PfxHorz
        /// </summary>
        [DataMember(Name = "pfxHorz", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pfxHorz")]
        public double? PfxHorz { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PitchFxDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  X0: ").Append(X0).Append("\n");
            sb.Append("  V0: ").Append(V0).Append("\n");
            sb.Append("  A0: ").Append(A0).Append("\n");
            sb.Append("  PfxVert: ").Append(PfxVert).Append("\n");
            sb.Append("  PfxHorz: ").Append(PfxHorz).Append("\n");
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