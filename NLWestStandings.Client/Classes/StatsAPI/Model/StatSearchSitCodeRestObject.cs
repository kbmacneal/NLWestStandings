using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StatSearchSitCodeRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets SitCode
        /// </summary>
        [DataMember(Name = "sitCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sitCode")]
        public string SitCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets NavigationMenu
        /// </summary>
        [DataMember(Name = "navigationMenu", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "navigationMenu")]
        public string NavigationMenu { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Hitting
        /// </summary>
        [DataMember(Name = "hitting", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitting")]
        public bool? Hitting { get; set; }

        /// <summary>
        /// Gets or Sets Pitching
        /// </summary>
        [DataMember(Name = "pitching", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitching")]
        public bool? Pitching { get; set; }

        /// <summary>
        /// Gets or Sets Fielding
        /// </summary>
        [DataMember(Name = "fielding", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fielding")]
        public bool? Fielding { get; set; }

        /// <summary>
        /// Gets or Sets Catching
        /// </summary>
        [DataMember(Name = "catching", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "catching")]
        public bool? Catching { get; set; }

        /// <summary>
        /// Gets or Sets Running
        /// </summary>
        [DataMember(Name = "running", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "running")]
        public bool? Running { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatSearchSitCodeRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  SitCode: ").Append(SitCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  NavigationMenu: ").Append(NavigationMenu).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Hitting: ").Append(Hitting).Append("\n");
            sb.Append("  Pitching: ").Append(Pitching).Append("\n");
            sb.Append("  Fielding: ").Append(Fielding).Append("\n");
            sb.Append("  Catching: ").Append(Catching).Append("\n");
            sb.Append("  Running: ").Append(Running).Append("\n");
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