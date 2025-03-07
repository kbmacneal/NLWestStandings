using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class LocationRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name = "address1", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name = "address2", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets Address3
        /// </summary>
        [DataMember(Name = "address3", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address3")]
        public string Address3 { get; set; }

        /// <summary>
        /// Gets or Sets Address4
        /// </summary>
        [DataMember(Name = "address4", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address4")]
        public string Address4 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets StateAbbrev
        /// </summary>
        [DataMember(Name = "stateAbbrev", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stateAbbrev")]
        public string StateAbbrev { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets DefaultCoordinates
        /// </summary>
        [DataMember(Name = "defaultCoordinates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "defaultCoordinates")]
        public CoordinateRestObject DefaultCoordinates { get; set; }

        /// <summary>
        /// Gets or Sets Coordinates
        /// </summary>
        [DataMember(Name = "coordinates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "coordinates")]
        public List<CoordinateRestObject> Coordinates { get; set; }

        /// <summary>
        /// Gets or Sets AzimuthAngle
        /// </summary>
        [DataMember(Name = "azimuthAngle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "azimuthAngle")]
        public double? AzimuthAngle { get; set; }

        /// <summary>
        /// Gets or Sets Elevation
        /// </summary>
        [DataMember(Name = "elevation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "elevation")]
        public int? Elevation { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Address3: ").Append(Address3).Append("\n");
            sb.Append("  Address4: ").Append(Address4).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateAbbrev: ").Append(StateAbbrev).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  DefaultCoordinates: ").Append(DefaultCoordinates).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
            sb.Append("  AzimuthAngle: ").Append(AzimuthAngle).Append("\n");
            sb.Append("  Elevation: ").Append(Elevation).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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