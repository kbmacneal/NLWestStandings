using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class EducationRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Highschools
        /// </summary>
        [DataMember(Name = "highschools", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "highschools")]
        public List<SchoolRestObject> Highschools { get; set; }

        /// <summary>
        /// Gets or Sets Colleges
        /// </summary>
        [DataMember(Name = "colleges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "colleges")]
        public List<SchoolRestObject> Colleges { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EducationRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Highschools: ").Append(Highschools).Append("\n");
            sb.Append("  Colleges: ").Append(Colleges).Append("\n");
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