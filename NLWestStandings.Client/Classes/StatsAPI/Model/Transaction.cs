using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Transaction
    {
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
        public BaseballPerson Person { get; set; }

        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>
        [DataMember(Name = "typeId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "typeId")]
        public string TypeId { get; set; }

        /// <summary>
        /// Gets or Sets TypeCode
        /// </summary>
        [DataMember(Name = "typeCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "typeCode")]
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or Sets FromTeam
        /// </summary>
        [DataMember(Name = "fromTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fromTeam")]
        public BaseballTeam FromTeam { get; set; }

        /// <summary>
        /// Gets or Sets ToTeam
        /// </summary>
        [DataMember(Name = "toTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "toTeam")]
        public BaseballTeam ToTeam { get; set; }

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
        /// Gets or Sets DescriptionMap
        /// </summary>
        [DataMember(Name = "descriptionMap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "descriptionMap")]
        public Dictionary<string, string> DescriptionMap { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  TypeCode: ").Append(TypeCode).Append("\n");
            sb.Append("  FromTeam: ").Append(FromTeam).Append("\n");
            sb.Append("  ToTeam: ").Append(ToTeam).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  ResolutionDate: ").Append(ResolutionDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsConditional: ").Append(IsConditional).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DescriptionMap: ").Append(DescriptionMap).Append("\n");
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