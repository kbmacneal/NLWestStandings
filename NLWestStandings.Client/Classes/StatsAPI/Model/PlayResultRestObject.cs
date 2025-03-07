using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class PlayResultRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets PlayerSequence
        /// </summary>
        [DataMember(Name = "playerSequence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playerSequence")]
        public List<PlayerSequenceRestObject> PlayerSequence { get; set; }

        /// <summary>
        /// Gets or Sets EventSequence
        /// </summary>
        [DataMember(Name = "eventSequence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "eventSequence")]
        public List<EventSequenceRestObject> EventSequence { get; set; }

        /// <summary>
        /// Gets or Sets RunnerSequence
        /// </summary>
        [DataMember(Name = "runnerSequence", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runnerSequence")]
        public List<RunnerSequenceRestObject> RunnerSequence { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayResultRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  PlayerSequence: ").Append(PlayerSequence).Append("\n");
            sb.Append("  EventSequence: ").Append(EventSequence).Append("\n");
            sb.Append("  RunnerSequence: ").Append(RunnerSequence).Append("\n");
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