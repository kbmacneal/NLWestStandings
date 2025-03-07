using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SportRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Hydrations
        /// </summary>
        [DataMember(Name = "hydrations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydrations")]
        public List<string> Hydrations { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [DataMember(Name = "abbreviation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets DeviceProperties
        /// </summary>
        [DataMember(Name = "deviceProperties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deviceProperties")]
        public JsonNode DeviceProperties { get; set; }

        /// <summary>
        /// Gets or Sets IsAffiliated
        /// </summary>
        [DataMember(Name = "isAffiliated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isAffiliated")]
        public bool? IsAffiliated { get; set; }

        /// <summary>
        /// Gets or Sets RuleSettings
        /// </summary>
        [DataMember(Name = "ruleSettings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ruleSettings")]
        public List<RuleSettingsRestObject> RuleSettings { get; set; }

        /// <summary>
        /// Gets or Sets SeasonState
        /// </summary>
        [DataMember(Name = "seasonState", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonState")]
        public string SeasonState { get; set; }

        /// <summary>
        /// Gets or Sets SeasonDateInfo
        /// </summary>
        [DataMember(Name = "seasonDateInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonDateInfo")]
        public SeasonRestObject SeasonDateInfo { get; set; }

        /// <summary>
        /// Gets or Sets ActiveStatus
        /// </summary>
        [DataMember(Name = "activeStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "activeStatus")]
        public bool? ActiveStatus { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SportRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  DeviceProperties: ").Append(DeviceProperties).Append("\n");
            sb.Append("  IsAffiliated: ").Append(IsAffiliated).Append("\n");
            sb.Append("  RuleSettings: ").Append(RuleSettings).Append("\n");
            sb.Append("  SeasonState: ").Append(SeasonState).Append("\n");
            sb.Append("  SeasonDateInfo: ").Append(SeasonDateInfo).Append("\n");
            sb.Append("  ActiveStatus: ").Append(ActiveStatus).Append("\n");
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