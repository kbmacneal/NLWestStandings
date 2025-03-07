using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class TransactionRestObject
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
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "person")]
        public BaseballPersonRestObject Person { get; set; }

        /// <summary>
        /// Gets or Sets FromTeam
        /// </summary>
        [DataMember(Name = "fromTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fromTeam")]
        public BaseballTeamRestObject FromTeam { get; set; }

        /// <summary>
        /// Gets or Sets ToTeam
        /// </summary>
        [DataMember(Name = "toTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "toTeam")]
        public BaseballTeamRestObject ToTeam { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveDate
        /// </summary>
        [DataMember(Name = "effectiveDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "effectiveDate")]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Gets or Sets ResolutionDate
        /// </summary>
        [DataMember(Name = "resolutionDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resolutionDate")]
        public DateTime? ResolutionDate { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets TypeCode
        /// </summary>
        [DataMember(Name = "typeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "typeCode")]
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or Sets TypeDesc
        /// </summary>
        [DataMember(Name = "typeDesc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "typeDesc")]
        public string TypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets IsConditional
        /// </summary>
        [DataMember(Name = "isConditional", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isConditional")]
        public bool? IsConditional { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  FromTeam: ").Append(FromTeam).Append("\n");
            sb.Append("  ToTeam: ").Append(ToTeam).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  ResolutionDate: ").Append(ResolutionDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeCode: ").Append(TypeCode).Append("\n");
            sb.Append("  TypeDesc: ").Append(TypeDesc).Append("\n");
            sb.Append("  IsConditional: ").Append(IsConditional).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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