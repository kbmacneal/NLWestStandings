using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class RuleSettingsRestObject
    {
        /// <summary>
        /// Gets or Sets PlaySettingId
        /// </summary>
        [DataMember(Name = "playSettingId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playSettingId")]
        public int? PlaySettingId { get; set; }

        /// <summary>
        /// Gets or Sets SettingId
        /// </summary>
        [DataMember(Name = "settingId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "settingId")]
        public int? SettingId { get; set; }

        /// <summary>
        /// Gets or Sets SettingName
        /// </summary>
        [DataMember(Name = "settingName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "settingName")]
        public string SettingName { get; set; }

        /// <summary>
        /// Gets or Sets SettingDisplayName
        /// </summary>
        [DataMember(Name = "settingDisplayName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "settingDisplayName")]
        public string SettingDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets SettingCategory
        /// </summary>
        [DataMember(Name = "settingCategory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "settingCategory")]
        public string SettingCategory { get; set; }

        /// <summary>
        /// Gets or Sets SettingCategoryCode
        /// </summary>
        [DataMember(Name = "settingCategoryCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "settingCategoryCode")]
        public string SettingCategoryCode { get; set; }

        /// <summary>
        /// Gets or Sets SettingDescription
        /// </summary>
        [DataMember(Name = "settingDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "settingDescription")]
        public string SettingDescription { get; set; }

        /// <summary>
        /// Gets or Sets SettingOptions
        /// </summary>
        [DataMember(Name = "settingOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "settingOptions")]
        public List<RuleSettingsOptionRestObject> SettingOptions { get; set; }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name = "valueType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "valueType")]
        public string ValueType { get; set; }

        /// <summary>
        /// Gets or Sets SettingValue
        /// </summary>
        [DataMember(Name = "settingValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "settingValue")]
        public Object SettingValue { get; set; }

        /// <summary>
        /// Gets or Sets SettingScope
        /// </summary>
        [DataMember(Name = "settingScope", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "settingScope")]
        public string SettingScope { get; set; }

        /// <summary>
        /// Gets or Sets PriorityOverride
        /// </summary>
        [DataMember(Name = "priorityOverride", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "priorityOverride")]
        public int? PriorityOverride { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Inherited
        /// </summary>
        [DataMember(Name = "inherited", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inherited")]
        public bool? Inherited { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>
        [DataMember(Name = "gameType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gameType")]
        public string GameType { get; set; }

        /// <summary>
        /// Gets or Sets AllGameTypeStatus
        /// </summary>
        [DataMember(Name = "allGameTypeStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "allGameTypeStatus")]
        public bool? AllGameTypeStatus { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleSettingsRestObject {\n");
            sb.Append("  PlaySettingId: ").Append(PlaySettingId).Append("\n");
            sb.Append("  SettingId: ").Append(SettingId).Append("\n");
            sb.Append("  SettingName: ").Append(SettingName).Append("\n");
            sb.Append("  SettingDisplayName: ").Append(SettingDisplayName).Append("\n");
            sb.Append("  SettingCategory: ").Append(SettingCategory).Append("\n");
            sb.Append("  SettingCategoryCode: ").Append(SettingCategoryCode).Append("\n");
            sb.Append("  SettingDescription: ").Append(SettingDescription).Append("\n");
            sb.Append("  SettingOptions: ").Append(SettingOptions).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  SettingValue: ").Append(SettingValue).Append("\n");
            sb.Append("  SettingScope: ").Append(SettingScope).Append("\n");
            sb.Append("  PriorityOverride: ").Append(PriorityOverride).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Inherited: ").Append(Inherited).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  AllGameTypeStatus: ").Append(AllGameTypeStatus).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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