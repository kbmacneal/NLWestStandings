using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class BaseballRosterEntry
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "person")]
        public BaseballPerson Person { get; set; }

        /// <summary>
        /// Gets or Sets JerseyNumber
        /// </summary>
        [DataMember(Name = "jerseyNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "jerseyNumber")]
        public string JerseyNumber { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "position")]
        public BaseballPosition Position { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stats")]
        public BaseballStats Stats { get; set; }

        /// <summary>
        /// Gets or Sets SeasonStats
        /// </summary>
        [DataMember(Name = "seasonStats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "seasonStats")]
        public BaseballStats SeasonStats { get; set; }

        /// <summary>
        /// Gets or Sets Captain
        /// </summary>
        [DataMember(Name = "captain", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "captain")]
        public bool? Captain { get; set; }

        /// <summary>
        /// Gets or Sets AlternateCaptain
        /// </summary>
        [DataMember(Name = "alternateCaptain", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "alternateCaptain")]
        public bool? AlternateCaptain { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public DynamicLookupEnum Status { get; set; }

        /// <summary>
        /// Gets or Sets Job
        /// </summary>
        [DataMember(Name = "job", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "job")]
        public string Job { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ParentTeamId
        /// </summary>
        [DataMember(Name = "parentTeamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parentTeamId")]
        public int? ParentTeamId { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsActiveFortyMan
        /// </summary>
        [DataMember(Name = "isActiveFortyMan", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isActiveFortyMan")]
        public bool? IsActiveFortyMan { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets StatusDate
        /// </summary>
        [DataMember(Name = "statusDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statusDate")]
        public DateTime? StatusDate { get; set; }

        /// <summary>
        /// Gets or Sets AllPositions
        /// </summary>
        [DataMember(Name = "allPositions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "allPositions")]
        public List<BaseballPosition> AllPositions { get; set; }

        /// <summary>
        /// Gets or Sets BattingOrder
        /// </summary>
        [DataMember(Name = "battingOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "battingOrder")]
        public string BattingOrder { get; set; }

        /// <summary>
        /// Gets or Sets PitchingOrder
        /// </summary>
        [DataMember(Name = "pitchingOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchingOrder")]
        public int? PitchingOrder { get; set; }

        /// <summary>
        /// Gets or Sets IsCurrentBatter
        /// </summary>
        [DataMember(Name = "isCurrentBatter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isCurrentBatter")]
        public bool? IsCurrentBatter { get; set; }

        /// <summary>
        /// Gets or Sets IsCurrentPitcher
        /// </summary>
        [DataMember(Name = "isCurrentPitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isCurrentPitcher")]
        public bool? IsCurrentPitcher { get; set; }

        /// <summary>
        /// Gets or Sets IsOnBench
        /// </summary>
        [DataMember(Name = "isOnBench", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isOnBench")]
        public bool? IsOnBench { get; set; }

        /// <summary>
        /// Gets or Sets IsSubstitute
        /// </summary>
        [DataMember(Name = "isSubstitute", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isSubstitute")]
        public bool? IsSubstitute { get; set; }

        /// <summary>
        /// Gets or Sets ClassId
        /// </summary>
        [DataMember(Name = "classId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "classId")]
        public int? ClassId { get; set; }

        /// <summary>
        /// Gets or Sets SportId
        /// </summary>
        [DataMember(Name = "sportId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sportId")]
        public int? SportId { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets QualifiedForGamePitched
        /// </summary>
        [DataMember(Name = "qualifiedForGamePitched", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "qualifiedForGamePitched")]
        public bool? QualifiedForGamePitched { get; set; }

        /// <summary>
        /// Gets or Sets StatContainer
        /// </summary>
        [DataMember(Name = "statContainer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statContainer")]
        public List<StatContainer> StatContainer { get; set; }

        /// <summary>
        /// Gets or Sets HydratedRosterEntriesTeam
        /// </summary>
        [DataMember(Name = "hydratedRosterEntriesTeam", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydratedRosterEntriesTeam")]
        public Dictionary<string, Object> HydratedRosterEntriesTeam { get; set; }

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
            sb.Append("class BaseballRosterEntry {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  JerseyNumber: ").Append(JerseyNumber).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  SeasonStats: ").Append(SeasonStats).Append("\n");
            sb.Append("  Captain: ").Append(Captain).Append("\n");
            sb.Append("  AlternateCaptain: ").Append(AlternateCaptain).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ParentTeamId: ").Append(ParentTeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsActiveFortyMan: ").Append(IsActiveFortyMan).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StatusDate: ").Append(StatusDate).Append("\n");
            sb.Append("  AllPositions: ").Append(AllPositions).Append("\n");
            sb.Append("  BattingOrder: ").Append(BattingOrder).Append("\n");
            sb.Append("  PitchingOrder: ").Append(PitchingOrder).Append("\n");
            sb.Append("  IsCurrentBatter: ").Append(IsCurrentBatter).Append("\n");
            sb.Append("  IsCurrentPitcher: ").Append(IsCurrentPitcher).Append("\n");
            sb.Append("  IsOnBench: ").Append(IsOnBench).Append("\n");
            sb.Append("  IsSubstitute: ").Append(IsSubstitute).Append("\n");
            sb.Append("  ClassId: ").Append(ClassId).Append("\n");
            sb.Append("  SportId: ").Append(SportId).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  QualifiedForGamePitched: ").Append(QualifiedForGamePitched).Append("\n");
            sb.Append("  StatContainer: ").Append(StatContainer).Append("\n");
            sb.Append("  HydratedRosterEntriesTeam: ").Append(HydratedRosterEntriesTeam).Append("\n");
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