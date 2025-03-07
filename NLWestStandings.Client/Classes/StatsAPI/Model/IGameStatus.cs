using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class IGameStatus
    {
        /// <summary>
        /// Gets or Sets StartTimeTBD
        /// </summary>
        [DataMember(Name = "startTimeTBD", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startTimeTBD")]
        public bool? StartTimeTBD { get; set; }

        /// <summary>
        /// Gets or Sets DetailedState
        /// </summary>
        [DataMember(Name = "detailedState", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "detailedState")]
        public string DetailedState { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets AbstractGameState
        /// </summary>
        [DataMember(Name = "abstractGameState", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "abstractGameState")]
        public string AbstractGameState { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IGameStatus {\n");
            sb.Append("  StartTimeTBD: ").Append(StartTimeTBD).Append("\n");
            sb.Append("  DetailedState: ").Append(DetailedState).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  AbstractGameState: ").Append(AbstractGameState).Append("\n");
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