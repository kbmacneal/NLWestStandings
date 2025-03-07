using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StatSearchStatRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [DataMember(Name = "abbreviation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or Sets SortStat
        /// </summary>
        [DataMember(Name = "sortStat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortStat")]
        public string SortStat { get; set; }

        /// <summary>
        /// Gets or Sets StatFields
        /// </summary>
        [DataMember(Name = "statFields", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statFields")]
        public StatFields StatFields { get; set; }

        /// <summary>
        /// Gets or Sets StatGroup
        /// </summary>
        [DataMember(Name = "statGroup", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statGroup")]
        public string StatGroup { get; set; }

        /// <summary>
        /// Gets or Sets FilterLevels
        /// </summary>
        [DataMember(Name = "filterLevels", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "filterLevels")]
        public FilterLevels FilterLevels { get; set; }

        /// <summary>
        /// Gets or Sets IsCounting
        /// </summary>
        [DataMember(Name = "isCounting", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isCounting")]
        public bool? IsCounting { get; set; }

        /// <summary>
        /// Gets or Sets IsInstanceStat
        /// </summary>
        [DataMember(Name = "isInstanceStat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isInstanceStat")]
        public bool? IsInstanceStat { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public string SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name = "units", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "units")]
        public string Units { get; set; }

        /// <summary>
        /// Gets or Sets Aggregation
        /// </summary>
        [DataMember(Name = "aggregation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "aggregation")]
        public string Aggregation { get; set; }

        /// <summary>
        /// Gets or Sets Decimals
        /// </summary>
        [DataMember(Name = "decimals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "decimals")]
        public int? Decimals { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatSearchStatRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  SortStat: ").Append(SortStat).Append("\n");
            sb.Append("  StatFields: ").Append(StatFields).Append("\n");
            sb.Append("  StatGroup: ").Append(StatGroup).Append("\n");
            sb.Append("  FilterLevels: ").Append(FilterLevels).Append("\n");
            sb.Append("  IsCounting: ").Append(IsCounting).Append("\n");
            sb.Append("  IsInstanceStat: ").Append(IsInstanceStat).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Aggregation: ").Append(Aggregation).Append("\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
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