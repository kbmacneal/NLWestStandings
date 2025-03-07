using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class MilestoneDuration
    {
        /// <summary>
        /// Gets or Sets MilestoneDurationId
        /// </summary>
        [DataMember(Name = "milestoneDurationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneDurationId")]
        public int? MilestoneDurationId { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneDurationCode
        /// </summary>
        [DataMember(Name = "milestoneDurationCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneDurationCode")]
        public string MilestoneDurationCode { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneDurationText
        /// </summary>
        [DataMember(Name = "milestoneDurationText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneDurationText")]
        public string MilestoneDurationText { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MilestoneDuration {\n");
            sb.Append("  MilestoneDurationId: ").Append(MilestoneDurationId).Append("\n");
            sb.Append("  MilestoneDurationCode: ").Append(MilestoneDurationCode).Append("\n");
            sb.Append("  MilestoneDurationText: ").Append(MilestoneDurationText).Append("\n");
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