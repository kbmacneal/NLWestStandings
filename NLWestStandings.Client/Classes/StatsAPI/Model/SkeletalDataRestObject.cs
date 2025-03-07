using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SkeletalDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Frames
        /// </summary>
        [DataMember(Name = "frames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "frames")]
        public List<FrameRestObject> Frames { get; set; }

        /// <summary>
        /// Gets or Sets JointMetaData
        /// </summary>
        [DataMember(Name = "jointMetaData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "jointMetaData")]
        public Dictionary<string, string> JointMetaData { get; set; }

        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name = "system", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "system")]
        public SystemRestObject System { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkeletalDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Frames: ").Append(Frames).Append("\n");
            sb.Append("  JointMetaData: ").Append(JointMetaData).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
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