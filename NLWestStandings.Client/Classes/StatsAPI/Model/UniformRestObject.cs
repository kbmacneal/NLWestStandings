using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class UniformRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets UniformAssetId
        /// </summary>
        [DataMember(Name = "uniformAssetId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uniformAssetId")]
        public int? UniformAssetId { get; set; }

        /// <summary>
        /// Gets or Sets UniformAssetCode
        /// </summary>
        [DataMember(Name = "uniformAssetCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uniformAssetCode")]
        public string UniformAssetCode { get; set; }

        /// <summary>
        /// Gets or Sets UniformAssetText
        /// </summary>
        [DataMember(Name = "uniformAssetText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uniformAssetText")]
        public string UniformAssetText { get; set; }

        /// <summary>
        /// Gets or Sets UniformAssetType
        /// </summary>
        [DataMember(Name = "uniformAssetType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uniformAssetType")]
        public UniformAssetTypeRestObject UniformAssetType { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets StartSeason
        /// </summary>
        [DataMember(Name = "startSeason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startSeason")]
        public string StartSeason { get; set; }

        /// <summary>
        /// Gets or Sets EndSeason
        /// </summary>
        [DataMember(Name = "endSeason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endSeason")]
        public string EndSeason { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UniformRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  UniformAssetId: ").Append(UniformAssetId).Append("\n");
            sb.Append("  UniformAssetCode: ").Append(UniformAssetCode).Append("\n");
            sb.Append("  UniformAssetText: ").Append(UniformAssetText).Append("\n");
            sb.Append("  UniformAssetType: ").Append(UniformAssetType).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  StartSeason: ").Append(StartSeason).Append("\n");
            sb.Append("  EndSeason: ").Append(EndSeason).Append("\n");
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