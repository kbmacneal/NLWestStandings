using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballDraftProspectRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets BisPlayerId
        /// </summary>
        [DataMember(Name = "bisPlayerId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bisPlayerId")]
        public int? BisPlayerId { get; set; }

        /// <summary>
        /// Gets or Sets BisSchoolId
        /// </summary>
        [DataMember(Name = "bisSchoolId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bisSchoolId")]
        public int? BisSchoolId { get; set; }

        /// <summary>
        /// Gets or Sets PickRound
        /// </summary>
        [DataMember(Name = "pickRound", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pickRound")]
        public string PickRound { get; set; }

        /// <summary>
        /// Gets or Sets PickNumber
        /// </summary>
        [DataMember(Name = "pickNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pickNumber")]
        public int? PickNumber { get; set; }

        /// <summary>
        /// Gets or Sets DisplayPickNumber
        /// </summary>
        [DataMember(Name = "displayPickNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayPickNumber")]
        public int? DisplayPickNumber { get; set; }

        /// <summary>
        /// Gets or Sets RoundPickNumber
        /// </summary>
        [DataMember(Name = "roundPickNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "roundPickNumber")]
        public int? RoundPickNumber { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// Gets or Sets PickValue
        /// </summary>
        [DataMember(Name = "pickValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pickValue")]
        public string PickValue { get; set; }

        /// <summary>
        /// Gets or Sets SigningBonus
        /// </summary>
        [DataMember(Name = "signingBonus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "signingBonus")]
        public string SigningBonus { get; set; }

        /// <summary>
        /// Gets or Sets Home
        /// </summary>
        [DataMember(Name = "home", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "home")]
        public LocationRestObject Home { get; set; }

        /// <summary>
        /// Gets or Sets ScoutingReport
        /// </summary>
        [DataMember(Name = "scoutingReport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scoutingReport")]
        public string ScoutingReport { get; set; }

        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [DataMember(Name = "school", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "school")]
        public SchoolRestObject School { get; set; }

        /// <summary>
        /// Gets or Sets Blurb
        /// </summary>
        [DataMember(Name = "blurb", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "blurb")]
        public string Blurb { get; set; }

        /// <summary>
        /// Gets or Sets HeadshotLink
        /// </summary>
        [DataMember(Name = "headshotLink", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "headshotLink")]
        public string HeadshotLink { get; set; }

        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "person")]
        public BaseballPersonRestObject Person { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Gets or Sets DraftType
        /// </summary>
        [DataMember(Name = "draftType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "draftType")]
        public DraftTypeEnumRestObject DraftType { get; set; }

        /// <summary>
        /// Gets or Sets IsDrafted
        /// </summary>
        [DataMember(Name = "isDrafted", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isDrafted")]
        public bool? IsDrafted { get; set; }

        /// <summary>
        /// Gets or Sets IsPass
        /// </summary>
        [DataMember(Name = "isPass", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPass")]
        public bool? IsPass { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "year")]
        public string Year { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballDraftProspectRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  BisPlayerId: ").Append(BisPlayerId).Append("\n");
            sb.Append("  BisSchoolId: ").Append(BisSchoolId).Append("\n");
            sb.Append("  PickRound: ").Append(PickRound).Append("\n");
            sb.Append("  PickNumber: ").Append(PickNumber).Append("\n");
            sb.Append("  DisplayPickNumber: ").Append(DisplayPickNumber).Append("\n");
            sb.Append("  RoundPickNumber: ").Append(RoundPickNumber).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  PickValue: ").Append(PickValue).Append("\n");
            sb.Append("  SigningBonus: ").Append(SigningBonus).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  ScoutingReport: ").Append(ScoutingReport).Append("\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  Blurb: ").Append(Blurb).Append("\n");
            sb.Append("  HeadshotLink: ").Append(HeadshotLink).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  DraftType: ").Append(DraftType).Append("\n");
            sb.Append("  IsDrafted: ").Append(IsDrafted).Append("\n");
            sb.Append("  IsPass: ").Append(IsPass).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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