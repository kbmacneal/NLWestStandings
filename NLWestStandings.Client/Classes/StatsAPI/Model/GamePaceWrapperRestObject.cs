using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GamePaceWrapperRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "teams")]
        public List<GamePaceRestObject> Teams { get; set; }

        /// <summary>
        /// Gets or Sets Leagues
        /// </summary>
        [DataMember(Name = "leagues", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leagues")]
        public List<GamePaceRestObject> Leagues { get; set; }

        /// <summary>
        /// Gets or Sets Sports
        /// </summary>
        [DataMember(Name = "sports", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sports")]
        public List<GamePaceRestObject> Sports { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GamePaceWrapperRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  Leagues: ").Append(Leagues).Append("\n");
            sb.Append("  Sports: ").Append(Sports).Append("\n");
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