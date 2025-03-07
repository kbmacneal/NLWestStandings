using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class SeamOrientationRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Xx
        /// </summary>
        [DataMember(Name = "xx", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xx")]
        public double? Xx { get; set; }

        /// <summary>
        /// Gets or Sets Xy
        /// </summary>
        [DataMember(Name = "xy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xy")]
        public double? Xy { get; set; }

        /// <summary>
        /// Gets or Sets Xz
        /// </summary>
        [DataMember(Name = "xz", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "xz")]
        public double? Xz { get; set; }

        /// <summary>
        /// Gets or Sets Yx
        /// </summary>
        [DataMember(Name = "yx", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "yx")]
        public double? Yx { get; set; }

        /// <summary>
        /// Gets or Sets Yy
        /// </summary>
        [DataMember(Name = "yy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "yy")]
        public double? Yy { get; set; }

        /// <summary>
        /// Gets or Sets Yz
        /// </summary>
        [DataMember(Name = "yz", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "yz")]
        public double? Yz { get; set; }

        /// <summary>
        /// Gets or Sets Zx
        /// </summary>
        [DataMember(Name = "zx", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zx")]
        public double? Zx { get; set; }

        /// <summary>
        /// Gets or Sets Zy
        /// </summary>
        [DataMember(Name = "zy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zy")]
        public double? Zy { get; set; }

        /// <summary>
        /// Gets or Sets Zz
        /// </summary>
        [DataMember(Name = "zz", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "zz")]
        public double? Zz { get; set; }

        /// <summary>
        /// Gets or Sets FrameRate
        /// </summary>
        [DataMember(Name = "frameRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "frameRate")]
        public int? FrameRate { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "time")]
        public double? Time { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SeamOrientationRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Xx: ").Append(Xx).Append("\n");
            sb.Append("  Xy: ").Append(Xy).Append("\n");
            sb.Append("  Xz: ").Append(Xz).Append("\n");
            sb.Append("  Yx: ").Append(Yx).Append("\n");
            sb.Append("  Yy: ").Append(Yy).Append("\n");
            sb.Append("  Yz: ").Append(Yz).Append("\n");
            sb.Append("  Zx: ").Append(Zx).Append("\n");
            sb.Append("  Zy: ").Append(Zy).Append("\n");
            sb.Append("  Zz: ").Append(Zz).Append("\n");
            sb.Append("  FrameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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