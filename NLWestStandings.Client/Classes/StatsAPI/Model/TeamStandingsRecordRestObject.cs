using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class TeamStandingsRecordRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name = "division", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "division")]
        public Division Division { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name = "conference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conference")]
        public Conference Conference { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "league")]
        public League League { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets Streak
        /// </summary>
        [DataMember(Name = "streak", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streak")]
        public StreakRestObject Streak { get; set; }

        /// <summary>
        /// Gets or Sets ClinchIndicator
        /// </summary>
        [DataMember(Name = "clinchIndicator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "clinchIndicator")]
        public string ClinchIndicator { get; set; }

        /// <summary>
        /// Gets or Sets DivisionRank
        /// </summary>
        [DataMember(Name = "divisionRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "divisionRank")]
        public string DivisionRank { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceRank
        /// </summary>
        [DataMember(Name = "conferenceRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conferenceRank")]
        public string ConferenceRank { get; set; }

        /// <summary>
        /// Gets or Sets LeagueRank
        /// </summary>
        [DataMember(Name = "leagueRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leagueRank")]
        public string LeagueRank { get; set; }

        /// <summary>
        /// Gets or Sets SpringLeagueRank
        /// </summary>
        [DataMember(Name = "springLeagueRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "springLeagueRank")]
        public string SpringLeagueRank { get; set; }

        /// <summary>
        /// Gets or Sets WildCardRank
        /// </summary>
        [DataMember(Name = "wildCardRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wildCardRank")]
        public string WildCardRank { get; set; }

        /// <summary>
        /// Gets or Sets SportRank
        /// </summary>
        [DataMember(Name = "sportRank", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sportRank")]
        public string SportRank { get; set; }

        /// <summary>
        /// Gets or Sets GamesPlayed
        /// </summary>
        [DataMember(Name = "gamesPlayed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesPlayed")]
        public int? GamesPlayed { get; set; }

        /// <summary>
        /// Gets or Sets GamesBack
        /// </summary>
        [DataMember(Name = "gamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesBack")]
        public string GamesBack { get; set; }

        /// <summary>
        /// Gets or Sets WildCardGamesBack
        /// </summary>
        [DataMember(Name = "wildCardGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wildCardGamesBack")]
        public string WildCardGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets LeagueGamesBack
        /// </summary>
        [DataMember(Name = "leagueGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leagueGamesBack")]
        public string LeagueGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets SpringLeagueGamesBack
        /// </summary>
        [DataMember(Name = "springLeagueGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "springLeagueGamesBack")]
        public string SpringLeagueGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets SportGamesBack
        /// </summary>
        [DataMember(Name = "sportGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sportGamesBack")]
        public string SportGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets DivisionGamesBack
        /// </summary>
        [DataMember(Name = "divisionGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "divisionGamesBack")]
        public string DivisionGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceGamesBack
        /// </summary>
        [DataMember(Name = "conferenceGamesBack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "conferenceGamesBack")]
        public string ConferenceGamesBack { get; set; }

        /// <summary>
        /// Gets or Sets LeagueRecord
        /// </summary>
        [DataMember(Name = "leagueRecord", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "leagueRecord")]
        public WinLossRecordRestObject LeagueRecord { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastUpdated")]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name = "records", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "records")]
        public Dictionary<string, List<WinLossRecordRestObject>> Records { get; set; }

        /// <summary>
        /// Gets or Sets Probabilites
        /// </summary>
        [DataMember(Name = "probabilites", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "probabilites")]
        public StandingsOdds Probabilites { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name = "points", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "points")]
        public int? Points { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamStandingsRecordRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Streak: ").Append(Streak).Append("\n");
            sb.Append("  ClinchIndicator: ").Append(ClinchIndicator).Append("\n");
            sb.Append("  DivisionRank: ").Append(DivisionRank).Append("\n");
            sb.Append("  ConferenceRank: ").Append(ConferenceRank).Append("\n");
            sb.Append("  LeagueRank: ").Append(LeagueRank).Append("\n");
            sb.Append("  SpringLeagueRank: ").Append(SpringLeagueRank).Append("\n");
            sb.Append("  WildCardRank: ").Append(WildCardRank).Append("\n");
            sb.Append("  SportRank: ").Append(SportRank).Append("\n");
            sb.Append("  GamesPlayed: ").Append(GamesPlayed).Append("\n");
            sb.Append("  GamesBack: ").Append(GamesBack).Append("\n");
            sb.Append("  WildCardGamesBack: ").Append(WildCardGamesBack).Append("\n");
            sb.Append("  LeagueGamesBack: ").Append(LeagueGamesBack).Append("\n");
            sb.Append("  SpringLeagueGamesBack: ").Append(SpringLeagueGamesBack).Append("\n");
            sb.Append("  SportGamesBack: ").Append(SportGamesBack).Append("\n");
            sb.Append("  DivisionGamesBack: ").Append(DivisionGamesBack).Append("\n");
            sb.Append("  ConferenceGamesBack: ").Append(ConferenceGamesBack).Append("\n");
            sb.Append("  LeagueRecord: ").Append(LeagueRecord).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  Probabilites: ").Append(Probabilites).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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