using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class ApplicationRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets AndroidPackage
        /// </summary>
        [DataMember(Name = "androidPackage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "androidPackage")]
        public string AndroidPackage { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or Sets Intent
        /// </summary>
        [DataMember(Name = "intent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "intent")]
        public string Intent { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AndroidUrl
        /// </summary>
        [DataMember(Name = "androidUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "androidUrl")]
        public string AndroidUrl { get; set; }

        /// <summary>
        /// Gets or Sets IosUrl
        /// </summary>
        [DataMember(Name = "iosUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "iosUrl")]
        public string IosUrl { get; set; }

        /// <summary>
        /// Gets or Sets IosPackage
        /// </summary>
        [DataMember(Name = "iosPackage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "iosPackage")]
        public string IosPackage { get; set; }

        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name = "primary", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "primary")]
        public bool? Primary { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  AndroidPackage: ").Append(AndroidPackage).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AndroidUrl: ").Append(AndroidUrl).Append("\n");
            sb.Append("  IosUrl: ").Append(IosUrl).Append("\n");
            sb.Append("  IosPackage: ").Append(IosPackage).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
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