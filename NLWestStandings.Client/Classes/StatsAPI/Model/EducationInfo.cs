using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class EducationInfo
    {
        /// <summary>
        /// Gets or Sets Highschools
        /// </summary>
        [DataMember(Name = "highschools", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "highschools")]
        public List<School> Highschools { get; set; }

        /// <summary>
        /// Gets or Sets Colleges
        /// </summary>
        [DataMember(Name = "colleges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "colleges")]
        public List<School> Colleges { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EducationInfo {\n");
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