using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballDraftProspect
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

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
        /// Gets or Sets DraftPlayerId
        /// </summary>
        [DataMember(Name = "draftPlayerId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "draftPlayerId")]
        public int? DraftPlayerId { get; set; }

        /// <summary>
        /// Gets or Sets PickRound
        /// </summary>
        [DataMember(Name = "pickRound", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pickRound")]
        public string PickRound { get; set; }

        /// <summary>
        /// Gets or Sets PickRoundLabel
        /// </summary>
        [DataMember(Name = "pickRoundLabel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pickRoundLabel")]
        public string PickRoundLabel { get; set; }

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
        /// Gets or Sets EnglishBlurb
        /// </summary>
        [DataMember(Name = "englishBlurb", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "englishBlurb")]
        public string EnglishBlurb { get; set; }

        /// <summary>
        /// Gets or Sets SpanishBlurb
        /// </summary>
        [DataMember(Name = "spanishBlurb", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spanishBlurb")]
        public string SpanishBlurb { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// Gets or Sets PickedTeamCode
        /// </summary>
        [DataMember(Name = "pickedTeamCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pickedTeamCode")]
        public string PickedTeamCode { get; set; }

        /// <summary>
        /// Gets or Sets Home
        /// </summary>
        [DataMember(Name = "home", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "home")]
        public Location Home { get; set; }

        /// <summary>
        /// Gets or Sets ScoutingReport
        /// </summary>
        [DataMember(Name = "scoutingReport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scoutingReport")]
        public string ScoutingReport { get; set; }

        /// <summary>
        /// Gets or Sets PhotoFlag
        /// </summary>
        [DataMember(Name = "photoFlag", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "photoFlag")]
        public bool? PhotoFlag { get; set; }

        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [DataMember(Name = "school", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "school")]
        public School School { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name = "comments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets HeadshotLink
        /// </summary>
        [DataMember(Name = "headshotLink", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "headshotLink")]
        public string HeadshotLink { get; set; }

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
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "person")]
        public BaseballPerson Person { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets DraftType
        /// </summary>
        [DataMember(Name = "draftType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "draftType")]
        public DraftTypeEnum DraftType { get; set; }

        /// <summary>
        /// Gets or Sets DraftStatus
        /// </summary>
        [DataMember(Name = "draftStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "draftStatus")]
        public DraftStatusEnum DraftStatus { get; set; }

        /// <summary>
        /// Gets or Sets WasPassed
        /// </summary>
        [DataMember(Name = "wasPassed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wasPassed")]
        public bool? WasPassed { get; set; }

        /// <summary>
        /// Gets or Sets WasLastPick
        /// </summary>
        [DataMember(Name = "wasLastPick", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wasLastPick")]
        public bool? WasLastPick { get; set; }

        /// <summary>
        /// Gets or Sets WasSelected
        /// </summary>
        [DataMember(Name = "wasSelected", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wasSelected")]
        public bool? WasSelected { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "year")]
        public string Year { get; set; }

        /// <summary>
        /// Gets or Sets UserPrivileges
        /// </summary>
        [DataMember(Name = "userPrivileges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "userPrivileges")]
        public List<Privilege> UserPrivileges { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseballDraftProspect {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  BisPlayerId: ").Append(BisPlayerId).Append("\n");
            sb.Append("  BisSchoolId: ").Append(BisSchoolId).Append("\n");
            sb.Append("  DraftPlayerId: ").Append(DraftPlayerId).Append("\n");
            sb.Append("  PickRound: ").Append(PickRound).Append("\n");
            sb.Append("  PickRoundLabel: ").Append(PickRoundLabel).Append("\n");
            sb.Append("  PickNumber: ").Append(PickNumber).Append("\n");
            sb.Append("  DisplayPickNumber: ").Append(DisplayPickNumber).Append("\n");
            sb.Append("  RoundPickNumber: ").Append(RoundPickNumber).Append("\n");
            sb.Append("  EnglishBlurb: ").Append(EnglishBlurb).Append("\n");
            sb.Append("  SpanishBlurb: ").Append(SpanishBlurb).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  PickedTeamCode: ").Append(PickedTeamCode).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  ScoutingReport: ").Append(ScoutingReport).Append("\n");
            sb.Append("  PhotoFlag: ").Append(PhotoFlag).Append("\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  HeadshotLink: ").Append(HeadshotLink).Append("\n");
            sb.Append("  PickValue: ").Append(PickValue).Append("\n");
            sb.Append("  SigningBonus: ").Append(SigningBonus).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  DraftType: ").Append(DraftType).Append("\n");
            sb.Append("  DraftStatus: ").Append(DraftStatus).Append("\n");
            sb.Append("  WasPassed: ").Append(WasPassed).Append("\n");
            sb.Append("  WasLastPick: ").Append(WasLastPick).Append("\n");
            sb.Append("  WasSelected: ").Append(WasSelected).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  UserPrivileges: ").Append(UserPrivileges).Append("\n");
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