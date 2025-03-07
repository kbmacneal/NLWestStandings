using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class TrackingVersionRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "owner")]
        public TrackingSystemOwner Owner { get; set; }

        /// <summary>
        /// Gets or Sets PitchVendor
        /// </summary>
        [DataMember(Name = "pitchVendor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchVendor")]
        public TrackingVendorVersionContainer PitchVendor { get; set; }

        /// <summary>
        /// Gets or Sets HitVendor
        /// </summary>
        [DataMember(Name = "hitVendor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitVendor")]
        public TrackingVendorVersionContainer HitVendor { get; set; }

        /// <summary>
        /// Gets or Sets PlayerVendor
        /// </summary>
        [DataMember(Name = "playerVendor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "playerVendor")]
        public TrackingVendorVersionContainer PlayerVendor { get; set; }

        /// <summary>
        /// Gets or Sets SkeletalVendor
        /// </summary>
        [DataMember(Name = "skeletalVendor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "skeletalVendor")]
        public TrackingVendorVersionContainer SkeletalVendor { get; set; }

        /// <summary>
        /// Gets or Sets BatVendor
        /// </summary>
        [DataMember(Name = "batVendor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "batVendor")]
        public TrackingVendorVersionContainer BatVendor { get; set; }

        /// <summary>
        /// Gets or Sets BiomechanicsVendor
        /// </summary>
        [DataMember(Name = "biomechanicsVendor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "biomechanicsVendor")]
        public TrackingVendorVersionContainer BiomechanicsVendor { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingVersionRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  PitchVendor: ").Append(PitchVendor).Append("\n");
            sb.Append("  HitVendor: ").Append(HitVendor).Append("\n");
            sb.Append("  PlayerVendor: ").Append(PlayerVendor).Append("\n");
            sb.Append("  SkeletalVendor: ").Append(SkeletalVendor).Append("\n");
            sb.Append("  BatVendor: ").Append(BatVendor).Append("\n");
            sb.Append("  BiomechanicsVendor: ").Append(BiomechanicsVendor).Append("\n");
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