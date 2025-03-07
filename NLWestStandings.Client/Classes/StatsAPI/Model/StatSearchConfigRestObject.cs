using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StatSearchConfigRestObject
    {
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parameters")]
        public List<StatSearchParamRestObject> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets GroupByTypes
        /// </summary>
        [DataMember(Name = "groupByTypes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groupByTypes")]
        public List<StatSearchGroupByRestObject> GroupByTypes { get; set; }

        /// <summary>
        /// Gets or Sets CompareOverTypes
        /// </summary>
        [DataMember(Name = "compareOverTypes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "compareOverTypes")]
        public List<StatSearchGroupByRestObject> CompareOverTypes { get; set; }

        /// <summary>
        /// Gets or Sets SituationCodes
        /// </summary>
        [DataMember(Name = "situationCodes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "situationCodes")]
        public List<StatSearchSitCodeRestObject> SituationCodes { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stats")]
        public List<StatSearchStatRestObject> Stats { get; set; }

        /// <summary>
        /// Gets or Sets Aggregations
        /// </summary>
        [DataMember(Name = "aggregations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "aggregations")]
        public List<AggregateSortTypeRestObject> Aggregations { get; set; }

        /// <summary>
        /// Gets or Sets FilterLevels
        /// </summary>
        [DataMember(Name = "filterLevels", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "filterLevels")]
        public List<FilterLevelEnumRestObject> FilterLevels { get; set; }

        /// <summary>
        /// Gets or Sets PersonFilters
        /// </summary>
        [DataMember(Name = "personFilters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "personFilters")]
        public List<StatSearchPersonFilterRestObject> PersonFilters { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatSearchConfigRestObject {\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  GroupByTypes: ").Append(GroupByTypes).Append("\n");
            sb.Append("  CompareOverTypes: ").Append(CompareOverTypes).Append("\n");
            sb.Append("  SituationCodes: ").Append(SituationCodes).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
            sb.Append("  FilterLevels: ").Append(FilterLevels).Append("\n");
            sb.Append("  PersonFilters: ").Append(PersonFilters).Append("\n");
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