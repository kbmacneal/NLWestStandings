using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class StatSearchPersonFilterRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PersonStatGroup
        /// </summary>
        [DataMember(Name = "personStatGroup", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "personStatGroup")]
        public List<PersonStatGroupRestObject> PersonStatGroup { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryFilterLevel
        /// </summary>
        [DataMember(Name = "primaryFilterLevel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "primaryFilterLevel")]
        public string PrimaryFilterLevel { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryFilterLevel
        /// </summary>
        [DataMember(Name = "secondaryFilterLevel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "secondaryFilterLevel")]
        public string SecondaryFilterLevel { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatSearchPersonFilterRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PersonStatGroup: ").Append(PersonStatGroup).Append("\n");
            sb.Append("  PrimaryFilterLevel: ").Append(PrimaryFilterLevel).Append("\n");
            sb.Append("  SecondaryFilterLevel: ").Append(SecondaryFilterLevel).Append("\n");
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