using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PhotoRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets PhotoType
        /// </summary>
        [DataMember(Name = "photoType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "photoType")]
        public string PhotoType { get; set; }

        /// <summary>
        /// Gets or Sets DefaultRes
        /// </summary>
        [DataMember(Name = "defaultRes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "defaultRes")]
        public string DefaultRes { get; set; }

        /// <summary>
        /// Gets or Sets DoubleRes
        /// </summary>
        [DataMember(Name = "doubleRes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "doubleRes")]
        public string DoubleRes { get; set; }

        /// <summary>
        /// Gets or Sets TripleRes
        /// </summary>
        [DataMember(Name = "tripleRes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tripleRes")]
        public string TripleRes { get; set; }

        /// <summary>
        /// Gets or Sets LowRes
        /// </summary>
        [DataMember(Name = "lowRes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lowRes")]
        public string LowRes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhotoRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  PhotoType: ").Append(PhotoType).Append("\n");
            sb.Append("  DefaultRes: ").Append(DefaultRes).Append("\n");
            sb.Append("  DoubleRes: ").Append(DoubleRes).Append("\n");
            sb.Append("  TripleRes: ").Append(TripleRes).Append("\n");
            sb.Append("  LowRes: ").Append(LowRes).Append("\n");
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