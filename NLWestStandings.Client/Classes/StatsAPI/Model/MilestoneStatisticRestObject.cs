using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class MilestoneStatisticRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets StatisticId
        /// </summary>
        [DataMember(Name = "statisticId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statisticId")]
        public int? StatisticId { get; set; }

        /// <summary>
        /// Gets or Sets StatisticText
        /// </summary>
        [DataMember(Name = "statisticText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statisticText")]
        public string StatisticText { get; set; }

        /// <summary>
        /// Gets or Sets StatisticDesc
        /// </summary>
        [DataMember(Name = "statisticDesc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statisticDesc")]
        public string StatisticDesc { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets IsStatcastStatus
        /// </summary>
        [DataMember(Name = "isStatcastStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isStatcastStatus")]
        public bool? IsStatcastStatus { get; set; }

        /// <summary>
        /// Gets or Sets IsStandardStatus
        /// </summary>
        [DataMember(Name = "isStandardStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isStandardStatus")]
        public bool? IsStandardStatus { get; set; }

        /// <summary>
        /// Gets or Sets StatAbbr
        /// </summary>
        [DataMember(Name = "statAbbr", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statAbbr")]
        public string StatAbbr { get; set; }

        /// <summary>
        /// Gets or Sets StatEnum
        /// </summary>
        [DataMember(Name = "statEnum", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statEnum")]
        public BaseballStatsTypeRestObject StatEnum { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MilestoneStatisticRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  StatisticId: ").Append(StatisticId).Append("\n");
            sb.Append("  StatisticText: ").Append(StatisticText).Append("\n");
            sb.Append("  StatisticDesc: ").Append(StatisticDesc).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  IsStatcastStatus: ").Append(IsStatcastStatus).Append("\n");
            sb.Append("  IsStandardStatus: ").Append(IsStandardStatus).Append("\n");
            sb.Append("  StatAbbr: ").Append(StatAbbr).Append("\n");
            sb.Append("  StatEnum: ").Append(StatEnum).Append("\n");
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