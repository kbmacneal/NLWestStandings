using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class TrackingSoftwareVersionRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets TrackingSoftwareComponentId
        /// </summary>
        [DataMember(Name = "trackingSoftwareComponentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trackingSoftwareComponentId")]
        public int? TrackingSoftwareComponentId { get; set; }

        /// <summary>
        /// Gets or Sets TrackingSoftwareComponentText
        /// </summary>
        [DataMember(Name = "trackingSoftwareComponentText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trackingSoftwareComponentText")]
        public string TrackingSoftwareComponentText { get; set; }

        /// <summary>
        /// Gets or Sets TrackingSoftwareComponentDesc
        /// </summary>
        [DataMember(Name = "trackingSoftwareComponentDesc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trackingSoftwareComponentDesc")]
        public string TrackingSoftwareComponentDesc { get; set; }

        /// <summary>
        /// Gets or Sets TrackingSoftwareComponentCode
        /// </summary>
        [DataMember(Name = "trackingSoftwareComponentCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trackingSoftwareComponentCode")]
        public string TrackingSoftwareComponentCode { get; set; }

        /// <summary>
        /// Gets or Sets TrackingVendorId
        /// </summary>
        [DataMember(Name = "trackingVendorId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trackingVendorId")]
        public int? TrackingVendorId { get; set; }

        /// <summary>
        /// Gets or Sets TrackingVersionSoftwareNoteId
        /// </summary>
        [DataMember(Name = "trackingVersionSoftwareNoteId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trackingVersionSoftwareNoteId")]
        public int? TrackingVersionSoftwareNoteId { get; set; }

        /// <summary>
        /// Gets or Sets TrackingSoftwareComponentVersionText
        /// </summary>
        [DataMember(Name = "trackingSoftwareComponentVersionText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trackingSoftwareComponentVersionText")]
        public string TrackingSoftwareComponentVersionText { get; set; }

        /// <summary>
        /// Gets or Sets TrackingVersionSoftwareNote
        /// </summary>
        [DataMember(Name = "trackingVersionSoftwareNote", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "trackingVersionSoftwareNote")]
        public string TrackingVersionSoftwareNote { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingSoftwareVersionRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  TrackingSoftwareComponentId: ").Append(TrackingSoftwareComponentId).Append("\n");
            sb.Append("  TrackingSoftwareComponentText: ").Append(TrackingSoftwareComponentText).Append("\n");
            sb.Append("  TrackingSoftwareComponentDesc: ").Append(TrackingSoftwareComponentDesc).Append("\n");
            sb.Append("  TrackingSoftwareComponentCode: ").Append(TrackingSoftwareComponentCode).Append("\n");
            sb.Append("  TrackingVendorId: ").Append(TrackingVendorId).Append("\n");
            sb.Append("  TrackingVersionSoftwareNoteId: ").Append(TrackingVersionSoftwareNoteId).Append("\n");
            sb.Append("  TrackingSoftwareComponentVersionText: ").Append(TrackingSoftwareComponentVersionText).Append("\n");
            sb.Append("  TrackingVersionSoftwareNote: ").Append(TrackingVersionSoftwareNote).Append("\n");
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