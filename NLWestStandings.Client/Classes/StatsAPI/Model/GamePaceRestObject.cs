using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class GamePaceRestObject
    {
        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets Hydrations
        /// </summary>
        [DataMember(Name = "hydrations", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hydrations")]
        public List<string> Hydrations { get; set; }

        /// <summary>
        /// Gets or Sets HitsPer9Inn
        /// </summary>
        [DataMember(Name = "hitsPer9Inn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitsPer9Inn")]
        public double? HitsPer9Inn { get; set; }

        /// <summary>
        /// Gets or Sets RunsPer9Inn
        /// </summary>
        [DataMember(Name = "runsPer9Inn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runsPer9Inn")]
        public double? RunsPer9Inn { get; set; }

        /// <summary>
        /// Gets or Sets PitchesPer9Inn
        /// </summary>
        [DataMember(Name = "pitchesPer9Inn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchesPer9Inn")]
        public double? PitchesPer9Inn { get; set; }

        /// <summary>
        /// Gets or Sets PlateAppearancesPer9Inn
        /// </summary>
        [DataMember(Name = "plateAppearancesPer9Inn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "plateAppearancesPer9Inn")]
        public double? PlateAppearancesPer9Inn { get; set; }

        /// <summary>
        /// Gets or Sets HitsPerGame
        /// </summary>
        [DataMember(Name = "hitsPerGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitsPerGame")]
        public double? HitsPerGame { get; set; }

        /// <summary>
        /// Gets or Sets RunsPerGame
        /// </summary>
        [DataMember(Name = "runsPerGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runsPerGame")]
        public double? RunsPerGame { get; set; }

        /// <summary>
        /// Gets or Sets InningsPlayedPerGame
        /// </summary>
        [DataMember(Name = "inningsPlayedPerGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inningsPlayedPerGame")]
        public double? InningsPlayedPerGame { get; set; }

        /// <summary>
        /// Gets or Sets PitchesPerGame
        /// </summary>
        [DataMember(Name = "pitchesPerGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchesPerGame")]
        public double? PitchesPerGame { get; set; }

        /// <summary>
        /// Gets or Sets PitchersPerGame
        /// </summary>
        [DataMember(Name = "pitchersPerGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchersPerGame")]
        public double? PitchersPerGame { get; set; }

        /// <summary>
        /// Gets or Sets PlateAppearancesPerGame
        /// </summary>
        [DataMember(Name = "plateAppearancesPerGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "plateAppearancesPerGame")]
        public double? PlateAppearancesPerGame { get; set; }

        /// <summary>
        /// Gets or Sets TotalGameTime
        /// </summary>
        [DataMember(Name = "totalGameTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalGameTime")]
        public Duration TotalGameTime { get; set; }

        /// <summary>
        /// Gets or Sets TotalInningsPlayed
        /// </summary>
        [DataMember(Name = "totalInningsPlayed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalInningsPlayed")]
        public double? TotalInningsPlayed { get; set; }

        /// <summary>
        /// Gets or Sets TotalHits
        /// </summary>
        [DataMember(Name = "totalHits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalHits")]
        public int? TotalHits { get; set; }

        /// <summary>
        /// Gets or Sets TotalRuns
        /// </summary>
        [DataMember(Name = "totalRuns", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalRuns")]
        public int? TotalRuns { get; set; }

        /// <summary>
        /// Gets or Sets TotalPlateAppearances
        /// </summary>
        [DataMember(Name = "totalPlateAppearances", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalPlateAppearances")]
        public int? TotalPlateAppearances { get; set; }

        /// <summary>
        /// Gets or Sets TotalPitchers
        /// </summary>
        [DataMember(Name = "totalPitchers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalPitchers")]
        public int? TotalPitchers { get; set; }

        /// <summary>
        /// Gets or Sets TotalPitches
        /// </summary>
        [DataMember(Name = "totalPitches", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalPitches")]
        public int? TotalPitches { get; set; }

        /// <summary>
        /// Gets or Sets TotalGames
        /// </summary>
        [DataMember(Name = "totalGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalGames")]
        public int? TotalGames { get; set; }

        /// <summary>
        /// Gets or Sets Total7InnGames
        /// </summary>
        [DataMember(Name = "total7InnGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total7InnGames")]
        public int? Total7InnGames { get; set; }

        /// <summary>
        /// Gets or Sets Total9InnGames
        /// </summary>
        [DataMember(Name = "total9InnGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total9InnGames")]
        public int? Total9InnGames { get; set; }

        /// <summary>
        /// Gets or Sets TotalExtraInnGames
        /// </summary>
        [DataMember(Name = "totalExtraInnGames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalExtraInnGames")]
        public int? TotalExtraInnGames { get; set; }

        /// <summary>
        /// Gets or Sets TimePerGame
        /// </summary>
        [DataMember(Name = "timePerGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePerGame")]
        public Duration TimePerGame { get; set; }

        /// <summary>
        /// Gets or Sets TimePerPitch
        /// </summary>
        [DataMember(Name = "timePerPitch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePerPitch")]
        public Duration TimePerPitch { get; set; }

        /// <summary>
        /// Gets or Sets TimePerHit
        /// </summary>
        [DataMember(Name = "timePerHit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePerHit")]
        public Duration TimePerHit { get; set; }

        /// <summary>
        /// Gets or Sets TimePerRun
        /// </summary>
        [DataMember(Name = "timePerRun", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePerRun")]
        public Duration TimePerRun { get; set; }

        /// <summary>
        /// Gets or Sets TimePerPlateAppearance
        /// </summary>
        [DataMember(Name = "timePerPlateAppearance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePerPlateAppearance")]
        public Duration TimePerPlateAppearance { get; set; }

        /// <summary>
        /// Gets or Sets TimePer9Inn
        /// </summary>
        [DataMember(Name = "timePer9Inn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePer9Inn")]
        public Duration TimePer9Inn { get; set; }

        /// <summary>
        /// Gets or Sets TimePer77PlateAppearances
        /// </summary>
        [DataMember(Name = "timePer77PlateAppearances", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePer77PlateAppearances")]
        public Duration TimePer77PlateAppearances { get; set; }

        /// <summary>
        /// Gets or Sets TotalExtraInnTime
        /// </summary>
        [DataMember(Name = "totalExtraInnTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalExtraInnTime")]
        public Duration TotalExtraInnTime { get; set; }

        /// <summary>
        /// Gets or Sets TimePer7InnGame
        /// </summary>
        [DataMember(Name = "timePer7InnGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePer7InnGame")]
        public Duration TimePer7InnGame { get; set; }

        /// <summary>
        /// Gets or Sets TimePer7InnGameWithoutExtraInn
        /// </summary>
        [DataMember(Name = "timePer7InnGameWithoutExtraInn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePer7InnGameWithoutExtraInn")]
        public Duration TimePer7InnGameWithoutExtraInn { get; set; }

        /// <summary>
        /// Gets or Sets Total7InnGamesScheduled
        /// </summary>
        [DataMember(Name = "total7InnGamesScheduled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total7InnGamesScheduled")]
        public int? Total7InnGamesScheduled { get; set; }

        /// <summary>
        /// Gets or Sets Total7InnGamesCompletedEarly
        /// </summary>
        [DataMember(Name = "total7InnGamesCompletedEarly", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total7InnGamesCompletedEarly")]
        public int? Total7InnGamesCompletedEarly { get; set; }

        /// <summary>
        /// Gets or Sets Total7InnGamesWithoutExtraInn
        /// </summary>
        [DataMember(Name = "total7InnGamesWithoutExtraInn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total7InnGamesWithoutExtraInn")]
        public int? Total7InnGamesWithoutExtraInn { get; set; }

        /// <summary>
        /// Gets or Sets Total9InnGamesCompletedEarly
        /// </summary>
        [DataMember(Name = "total9InnGamesCompletedEarly", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total9InnGamesCompletedEarly")]
        public int? Total9InnGamesCompletedEarly { get; set; }

        /// <summary>
        /// Gets or Sets Total9InnGamesWithoutExtraInn
        /// </summary>
        [DataMember(Name = "total9InnGamesWithoutExtraInn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total9InnGamesWithoutExtraInn")]
        public int? Total9InnGamesWithoutExtraInn { get; set; }

        /// <summary>
        /// Gets or Sets Total9InnGamesScheduled
        /// </summary>
        [DataMember(Name = "total9InnGamesScheduled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total9InnGamesScheduled")]
        public int? Total9InnGamesScheduled { get; set; }

        /// <summary>
        /// Gets or Sets HitsPerRun
        /// </summary>
        [DataMember(Name = "hitsPerRun", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitsPerRun")]
        public double? HitsPerRun { get; set; }

        /// <summary>
        /// Gets or Sets PitchesPerPitcher
        /// </summary>
        [DataMember(Name = "pitchesPerPitcher", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchesPerPitcher")]
        public double? PitchesPerPitcher { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "team")]
        public BaseballTeamRestObject Team { get; set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name = "league", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "league")]
        public LeagueRestObject League { get; set; }

        /// <summary>
        /// Gets or Sets Sport
        /// </summary>
        [DataMember(Name = "sport", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sport")]
        public SportRestObject Sport { get; set; }

        /// <summary>
        /// Gets or Sets PrPortalCalculatedFields
        /// </summary>
        [DataMember(Name = "prPortalCalculatedFields", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "prPortalCalculatedFields")]
        public GamePacePRPortalRestObject PrPortalCalculatedFields { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GamePaceRestObject {\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  Hydrations: ").Append(Hydrations).Append("\n");
            sb.Append("  HitsPer9Inn: ").Append(HitsPer9Inn).Append("\n");
            sb.Append("  RunsPer9Inn: ").Append(RunsPer9Inn).Append("\n");
            sb.Append("  PitchesPer9Inn: ").Append(PitchesPer9Inn).Append("\n");
            sb.Append("  PlateAppearancesPer9Inn: ").Append(PlateAppearancesPer9Inn).Append("\n");
            sb.Append("  HitsPerGame: ").Append(HitsPerGame).Append("\n");
            sb.Append("  RunsPerGame: ").Append(RunsPerGame).Append("\n");
            sb.Append("  InningsPlayedPerGame: ").Append(InningsPlayedPerGame).Append("\n");
            sb.Append("  PitchesPerGame: ").Append(PitchesPerGame).Append("\n");
            sb.Append("  PitchersPerGame: ").Append(PitchersPerGame).Append("\n");
            sb.Append("  PlateAppearancesPerGame: ").Append(PlateAppearancesPerGame).Append("\n");
            sb.Append("  TotalGameTime: ").Append(TotalGameTime).Append("\n");
            sb.Append("  TotalInningsPlayed: ").Append(TotalInningsPlayed).Append("\n");
            sb.Append("  TotalHits: ").Append(TotalHits).Append("\n");
            sb.Append("  TotalRuns: ").Append(TotalRuns).Append("\n");
            sb.Append("  TotalPlateAppearances: ").Append(TotalPlateAppearances).Append("\n");
            sb.Append("  TotalPitchers: ").Append(TotalPitchers).Append("\n");
            sb.Append("  TotalPitches: ").Append(TotalPitches).Append("\n");
            sb.Append("  TotalGames: ").Append(TotalGames).Append("\n");
            sb.Append("  Total7InnGames: ").Append(Total7InnGames).Append("\n");
            sb.Append("  Total9InnGames: ").Append(Total9InnGames).Append("\n");
            sb.Append("  TotalExtraInnGames: ").Append(TotalExtraInnGames).Append("\n");
            sb.Append("  TimePerGame: ").Append(TimePerGame).Append("\n");
            sb.Append("  TimePerPitch: ").Append(TimePerPitch).Append("\n");
            sb.Append("  TimePerHit: ").Append(TimePerHit).Append("\n");
            sb.Append("  TimePerRun: ").Append(TimePerRun).Append("\n");
            sb.Append("  TimePerPlateAppearance: ").Append(TimePerPlateAppearance).Append("\n");
            sb.Append("  TimePer9Inn: ").Append(TimePer9Inn).Append("\n");
            sb.Append("  TimePer77PlateAppearances: ").Append(TimePer77PlateAppearances).Append("\n");
            sb.Append("  TotalExtraInnTime: ").Append(TotalExtraInnTime).Append("\n");
            sb.Append("  TimePer7InnGame: ").Append(TimePer7InnGame).Append("\n");
            sb.Append("  TimePer7InnGameWithoutExtraInn: ").Append(TimePer7InnGameWithoutExtraInn).Append("\n");
            sb.Append("  Total7InnGamesScheduled: ").Append(Total7InnGamesScheduled).Append("\n");
            sb.Append("  Total7InnGamesCompletedEarly: ").Append(Total7InnGamesCompletedEarly).Append("\n");
            sb.Append("  Total7InnGamesWithoutExtraInn: ").Append(Total7InnGamesWithoutExtraInn).Append("\n");
            sb.Append("  Total9InnGamesCompletedEarly: ").Append(Total9InnGamesCompletedEarly).Append("\n");
            sb.Append("  Total9InnGamesWithoutExtraInn: ").Append(Total9InnGamesWithoutExtraInn).Append("\n");
            sb.Append("  Total9InnGamesScheduled: ").Append(Total9InnGamesScheduled).Append("\n");
            sb.Append("  HitsPerRun: ").Append(HitsPerRun).Append("\n");
            sb.Append("  PitchesPerPitcher: ").Append(PitchesPerPitcher).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  Sport: ").Append(Sport).Append("\n");
            sb.Append("  PrPortalCalculatedFields: ").Append(PrPortalCalculatedFields).Append("\n");
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