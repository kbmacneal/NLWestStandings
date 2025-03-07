using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class RuleSettingsOptionRestObject
    {
        /// <summary>
        /// Gets or Sets SettingValueId
        /// </summary>
        [DataMember(Name = "settingValueId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "settingValueId")]
        public int? SettingValueId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ActiveBeginDate
        /// </summary>
        [DataMember(Name = "activeBeginDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "activeBeginDate")]
        public DateTime? ActiveBeginDate { get; set; }

        /// <summary>
        /// Gets or Sets ActiveEndDate
        /// </summary>
        [DataMember(Name = "activeEndDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "activeEndDate")]
        public DateTime? ActiveEndDate { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public Object Value { get; set; }

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
            sb.Append("class RuleSettingsOptionRestObject {\n");
            sb.Append("  SettingValueId: ").Append(SettingValueId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ActiveBeginDate: ").Append(ActiveBeginDate).Append("\n");
            sb.Append("  ActiveEndDate: ").Append(ActiveEndDate).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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