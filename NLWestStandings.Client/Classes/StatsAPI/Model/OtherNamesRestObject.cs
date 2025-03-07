using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class OtherNamesRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets FirstInitialLastName
        /// </summary>
        [DataMember(Name = "firstInitialLastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstInitialLastName")]
        public string FirstInitialLastName { get; set; }

        /// <summary>
        /// Gets or Sets LastNameFirstInitial
        /// </summary>
        [DataMember(Name = "lastNameFirstInitial", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastNameFirstInitial")]
        public string LastNameFirstInitial { get; set; }

        /// <summary>
        /// Gets or Sets LastFirstName
        /// </summary>
        [DataMember(Name = "lastFirstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastFirstName")]
        public string LastFirstName { get; set; }

        /// <summary>
        /// Gets or Sets PhoneticName
        /// </summary>
        [DataMember(Name = "phoneticName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "phoneticName")]
        public string PhoneticName { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OtherNamesRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  FirstInitialLastName: ").Append(FirstInitialLastName).Append("\n");
            sb.Append("  LastNameFirstInitial: ").Append(LastNameFirstInitial).Append("\n");
            sb.Append("  LastFirstName: ").Append(LastFirstName).Append("\n");
            sb.Append("  PhoneticName: ").Append(PhoneticName).Append("\n");
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