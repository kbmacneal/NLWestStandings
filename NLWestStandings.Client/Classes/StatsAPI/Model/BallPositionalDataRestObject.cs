using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BallPositionalDataRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets GenericSegments
        /// </summary>
        [DataMember(Name = "genericSegments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "genericSegments")]
        public List<SegmentRestObject> GenericSegments { get; set; }

        /// <summary>
        /// Gets or Sets PitchSegment
        /// </summary>
        [DataMember(Name = "pitchSegment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchSegment")]
        public PitchSegmentRestObject PitchSegment { get; set; }

        /// <summary>
        /// Gets or Sets HitSegment
        /// </summary>
        [DataMember(Name = "hitSegment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitSegment")]
        public HitSegmentRestObject HitSegment { get; set; }

        /// <summary>
        /// Gets or Sets Positions
        /// </summary>
        [DataMember(Name = "positions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "positions")]
        public List<BallPositionDataRestObject> Positions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BallPositionalDataRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  GenericSegments: ").Append(GenericSegments).Append("\n");
            sb.Append("  PitchSegment: ").Append(PitchSegment).Append("\n");
            sb.Append("  HitSegment: ").Append(HitSegment).Append("\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
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