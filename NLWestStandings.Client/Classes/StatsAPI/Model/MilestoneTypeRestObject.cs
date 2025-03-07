using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class MilestoneTypeRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneTypeId
        /// </summary>
        [DataMember(Name = "milestoneTypeId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneTypeId")]
        public int? MilestoneTypeId { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneTypeCode
        /// </summary>
        [DataMember(Name = "milestoneTypeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneTypeCode")]
        public string MilestoneTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneTypeText
        /// </summary>
        [DataMember(Name = "milestoneTypeText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "milestoneTypeText")]
        public string MilestoneTypeText { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MilestoneTypeRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  MilestoneTypeId: ").Append(MilestoneTypeId).Append("\n");
            sb.Append("  MilestoneTypeCode: ").Append(MilestoneTypeCode).Append("\n");
            sb.Append("  MilestoneTypeText: ").Append(MilestoneTypeText).Append("\n");
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