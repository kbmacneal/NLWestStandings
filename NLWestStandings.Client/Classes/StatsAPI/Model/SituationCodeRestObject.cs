using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SituationCodeRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets NavigationMenu
        /// </summary>
        [DataMember(Name = "navigationMenu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "navigationMenu")]
        public string NavigationMenu { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public bool? Team { get; set; }

        /// <summary>
        /// Gets or Sets Batting
        /// </summary>
        [DataMember(Name = "batting", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batting")]
        public bool? Batting { get; set; }

        /// <summary>
        /// Gets or Sets Fielding
        /// </summary>
        [DataMember(Name = "fielding", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fielding")]
        public bool? Fielding { get; set; }

        /// <summary>
        /// Gets or Sets Pitching
        /// </summary>
        [DataMember(Name = "pitching", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitching")]
        public bool? Pitching { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SituationCodeRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  NavigationMenu: ").Append(NavigationMenu).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Batting: ").Append(Batting).Append("\n");
            sb.Append("  Fielding: ").Append(Fielding).Append("\n");
            sb.Append("  Pitching: ").Append(Pitching).Append("\n");
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