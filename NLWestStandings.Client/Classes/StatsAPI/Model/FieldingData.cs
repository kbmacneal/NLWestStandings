using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace IO.Swagger.Model
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class FieldingData
    {
        /// <summary>
        /// Gets or Sets RequestingUserRole
        /// </summary>
        [DataMember(Name = "requestingUserRole", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requestingUserRole")]
        public Role RequestingUserRole { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "summary")]
        public Dictionary<string, string> Summary { get; set; }

        /// <summary>
        /// Gets or Sets CatchersInterference
        /// </summary>
        [DataMember(Name = "catchersInterference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "catchersInterference")]
        public int? CatchersInterference { get; set; }

        /// <summary>
        /// Gets or Sets Average
        /// </summary>
        [DataMember(Name = "average", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "average")]
        public string Average { get; set; }

        /// <summary>
        /// Gets or Sets OnBasePercentage
        /// </summary>
        [DataMember(Name = "onBasePercentage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "onBasePercentage")]
        public string OnBasePercentage { get; set; }

        /// <summary>
        /// Gets or Sets OnBasePlusSlugging
        /// </summary>
        [DataMember(Name = "onBasePlusSlugging", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "onBasePlusSlugging")]
        public string OnBasePlusSlugging { get; set; }

        /// <summary>
        /// Gets or Sets StolenBases
        /// </summary>
        [DataMember(Name = "stolenBases", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stolenBases")]
        public int? StolenBases { get; set; }

        /// <summary>
        /// Gets or Sets CaughtStealing
        /// </summary>
        [DataMember(Name = "caughtStealing", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "caughtStealing")]
        public int? CaughtStealing { get; set; }

        /// <summary>
        /// Gets or Sets Slugging
        /// </summary>
        [DataMember(Name = "slugging", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "slugging")]
        public string Slugging { get; set; }

        /// <summary>
        /// Gets or Sets Outs
        /// </summary>
        [DataMember(Name = "outs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outs")]
        public int? Outs { get; set; }

        /// <summary>
        /// Gets or Sets Gidp
        /// </summary>
        [DataMember(Name = "gidp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gidp")]
        public int? Gidp { get; set; }

        /// <summary>
        /// Gets or Sets Gitp
        /// </summary>
        [DataMember(Name = "gitp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gitp")]
        public int? Gitp { get; set; }

        /// <summary>
        /// Gets or Sets HomeRuns
        /// </summary>
        [DataMember(Name = "homeRuns", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeRuns")]
        public int? HomeRuns { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfPitches
        /// </summary>
        [DataMember(Name = "numberOfPitches", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numberOfPitches")]
        public int? NumberOfPitches { get; set; }

        /// <summary>
        /// Gets or Sets TotalBases
        /// </summary>
        [DataMember(Name = "totalBases", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalBases")]
        public int? TotalBases { get; set; }

        /// <summary>
        /// Gets or Sets GidpOpportunites
        /// </summary>
        [DataMember(Name = "gidpOpportunites", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gidpOpportunites")]
        public int? GidpOpportunites { get; set; }

        /// <summary>
        /// Gets or Sets Walks
        /// </summary>
        [DataMember(Name = "walks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "walks")]
        public int? Walks { get; set; }

        /// <summary>
        /// Gets or Sets HitByPitch
        /// </summary>
        [DataMember(Name = "hitByPitch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hitByPitch")]
        public int? HitByPitch { get; set; }

        /// <summary>
        /// Gets or Sets Strikeouts
        /// </summary>
        [DataMember(Name = "strikeouts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "strikeouts")]
        public int? Strikeouts { get; set; }

        /// <summary>
        /// Gets or Sets AirOuts
        /// </summary>
        [DataMember(Name = "airOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "airOuts")]
        public int? AirOuts { get; set; }

        /// <summary>
        /// Gets or Sets GoAo
        /// </summary>
        [DataMember(Name = "goAo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "goAo")]
        public string GoAo { get; set; }

        /// <summary>
        /// Gets or Sets PitchesPerPlateAppearance
        /// </summary>
        [DataMember(Name = "pitchesPerPlateAppearance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchesPerPlateAppearance")]
        public double? PitchesPerPlateAppearance { get; set; }

        /// <summary>
        /// Gets or Sets IntentionalWalks
        /// </summary>
        [DataMember(Name = "intentionalWalks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "intentionalWalks")]
        public int? IntentionalWalks { get; set; }

        /// <summary>
        /// Gets or Sets GroundOuts
        /// </summary>
        [DataMember(Name = "groundOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groundOuts")]
        public int? GroundOuts { get; set; }

        /// <summary>
        /// Gets or Sets FlyOuts
        /// </summary>
        [DataMember(Name = "flyOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flyOuts")]
        public int? FlyOuts { get; set; }

        /// <summary>
        /// Gets or Sets Games
        /// </summary>
        [DataMember(Name = "games", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "games")]
        public int? Games { get; set; }

        /// <summary>
        /// Gets or Sets GamesStarted
        /// </summary>
        [DataMember(Name = "gamesStarted", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesStarted")]
        public int? GamesStarted { get; set; }

        /// <summary>
        /// Gets or Sets Doubles
        /// </summary>
        [DataMember(Name = "doubles", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "doubles")]
        public int? Doubles { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name = "hits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hits")]
        public int? Hits { get; set; }

        /// <summary>
        /// Gets or Sets Triples
        /// </summary>
        [DataMember(Name = "triples", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "triples")]
        public int? Triples { get; set; }

        /// <summary>
        /// Gets or Sets Singles
        /// </summary>
        [DataMember(Name = "singles", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "singles")]
        public int? Singles { get; set; }

        /// <summary>
        /// Gets or Sets Runs
        /// </summary>
        [DataMember(Name = "runs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "runs")]
        public int? Runs { get; set; }

        /// <summary>
        /// Gets or Sets AtBats
        /// </summary>
        [DataMember(Name = "atBats", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "atBats")]
        public int? AtBats { get; set; }

        /// <summary>
        /// Gets or Sets Pickoffs
        /// </summary>
        [DataMember(Name = "pickoffs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pickoffs")]
        public int? Pickoffs { get; set; }

        /// <summary>
        /// Gets or Sets StolenBasePercentage
        /// </summary>
        [DataMember(Name = "stolenBasePercentage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stolenBasePercentage")]
        public string StolenBasePercentage { get; set; }

        /// <summary>
        /// Gets or Sets WildPitches
        /// </summary>
        [DataMember(Name = "wildPitches", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "wildPitches")]
        public int? WildPitches { get; set; }

        /// <summary>
        /// Gets or Sets SacFlies
        /// </summary>
        [DataMember(Name = "sacFlies", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sacFlies")]
        public int? SacFlies { get; set; }

        /// <summary>
        /// Gets or Sets SacBunts
        /// </summary>
        [DataMember(Name = "sacBunts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sacBunts")]
        public int? SacBunts { get; set; }

        /// <summary>
        /// Gets or Sets Putouts
        /// </summary>
        [DataMember(Name = "putouts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "putouts")]
        public int? Putouts { get; set; }

        /// <summary>
        /// Gets or Sets Assists
        /// </summary>
        [DataMember(Name = "assists", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "assists")]
        public int? Assists { get; set; }

        /// <summary>
        /// Gets or Sets Chances
        /// </summary>
        [DataMember(Name = "chances", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "chances")]
        public int? Chances { get; set; }

        /// <summary>
        /// Gets or Sets Streak
        /// </summary>
        [DataMember(Name = "streak", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streak")]
        public int? Streak { get; set; }

        /// <summary>
        /// Gets or Sets BattingOrder
        /// </summary>
        [DataMember(Name = "battingOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "battingOrder")]
        public string BattingOrder { get; set; }

        /// <summary>
        /// Gets or Sets TotalSwings
        /// </summary>
        [DataMember(Name = "totalSwings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalSwings")]
        public int? TotalSwings { get; set; }

        /// <summary>
        /// Gets or Sets SwingsAndMisses
        /// </summary>
        [DataMember(Name = "swingsAndMisses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "swingsAndMisses")]
        public int? SwingsAndMisses { get; set; }

        /// <summary>
        /// Gets or Sets BallsInPlay
        /// </summary>
        [DataMember(Name = "ballsInPlay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ballsInPlay")]
        public int? BallsInPlay { get; set; }

        /// <summary>
        /// Gets or Sets PopOuts
        /// </summary>
        [DataMember(Name = "popOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "popOuts")]
        public int? PopOuts { get; set; }

        /// <summary>
        /// Gets or Sets LineOuts
        /// </summary>
        [DataMember(Name = "lineOuts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lineOuts")]
        public int? LineOuts { get; set; }

        /// <summary>
        /// Gets or Sets FlyHits
        /// </summary>
        [DataMember(Name = "flyHits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "flyHits")]
        public int? FlyHits { get; set; }

        /// <summary>
        /// Gets or Sets PopHits
        /// </summary>
        [DataMember(Name = "popHits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "popHits")]
        public int? PopHits { get; set; }

        /// <summary>
        /// Gets or Sets LineHits
        /// </summary>
        [DataMember(Name = "lineHits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lineHits")]
        public int? LineHits { get; set; }

        /// <summary>
        /// Gets or Sets GroundHits
        /// </summary>
        [DataMember(Name = "groundHits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groundHits")]
        public int? GroundHits { get; set; }

        /// <summary>
        /// Gets or Sets GamesPlayedOnBothTeams
        /// </summary>
        [DataMember(Name = "gamesPlayedOnBothTeams", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gamesPlayedOnBothTeams")]
        public int? GamesPlayedOnBothTeams { get; set; }

        /// <summary>
        /// Gets or Sets OutfieldAssists
        /// </summary>
        [DataMember(Name = "outfieldAssists", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outfieldAssists")]
        public int? OutfieldAssists { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errors")]
        public int? Errors { get; set; }

        /// <summary>
        /// Gets or Sets FieldingPercentage
        /// </summary>
        [DataMember(Name = "fieldingPercentage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fieldingPercentage")]
        public string FieldingPercentage { get; set; }

        /// <summary>
        /// Gets or Sets RangeFactorPerGame
        /// </summary>
        [DataMember(Name = "rangeFactorPerGame", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rangeFactorPerGame")]
        public string RangeFactorPerGame { get; set; }

        /// <summary>
        /// Gets or Sets RangeFactorPer9Inn
        /// </summary>
        [DataMember(Name = "rangeFactorPer9Inn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rangeFactorPer9Inn")]
        public string RangeFactorPer9Inn { get; set; }

        /// <summary>
        /// Gets or Sets Innings
        /// </summary>
        [DataMember(Name = "innings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "innings")]
        public string Innings { get; set; }

        /// <summary>
        /// Gets or Sets PassedBall
        /// </summary>
        [DataMember(Name = "passedBall", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "passedBall")]
        public int? PassedBall { get; set; }

        /// <summary>
        /// Gets or Sets DoublePlays
        /// </summary>
        [DataMember(Name = "doublePlays", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "doublePlays")]
        public int? DoublePlays { get; set; }

        /// <summary>
        /// Gets or Sets TriplePlays
        /// </summary>
        [DataMember(Name = "triplePlays", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "triplePlays")]
        public int? TriplePlays { get; set; }

        /// <summary>
        /// Gets or Sets CatcherERA
        /// </summary>
        [DataMember(Name = "catcherERA", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "catcherERA")]
        public string CatcherERA { get; set; }

        /// <summary>
        /// Gets or Sets ThrowingErrors
        /// </summary>
        [DataMember(Name = "throwingErrors", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "throwingErrors")]
        public int? ThrowingErrors { get; set; }

        /// <summary>
        /// Gets or Sets Uzr
        /// </summary>
        [DataMember(Name = "uzr", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uzr")]
        public double? Uzr { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "position")]
        public BaseballPosition Position { get; set; }

        /// <summary>
        /// Gets or Sets PlateAppearances
        /// </summary>
        [DataMember(Name = "plateAppearances", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "plateAppearances")]
        public int? PlateAppearances { get; set; }

        /// <summary>
        /// Gets or Sets PitchesPerPlateAppearanceStr
        /// </summary>
        [DataMember(Name = "pitchesPerPlateAppearanceStr", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pitchesPerPlateAppearanceStr")]
        public string PitchesPerPlateAppearanceStr { get; set; }

        /// <summary>
        /// Gets or Sets StolenBasePercentageOrNull
        /// </summary>
        [DataMember(Name = "stolenBasePercentageOrNull", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stolenBasePercentageOrNull")]
        public string StolenBasePercentageOrNull { get; set; }

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
            sb.Append("class FieldingData {\n");
            sb.Append("  RequestingUserRole: ").Append(RequestingUserRole).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  CatchersInterference: ").Append(CatchersInterference).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
            sb.Append("  OnBasePercentage: ").Append(OnBasePercentage).Append("\n");
            sb.Append("  OnBasePlusSlugging: ").Append(OnBasePlusSlugging).Append("\n");
            sb.Append("  StolenBases: ").Append(StolenBases).Append("\n");
            sb.Append("  CaughtStealing: ").Append(CaughtStealing).Append("\n");
            sb.Append("  Slugging: ").Append(Slugging).Append("\n");
            sb.Append("  Outs: ").Append(Outs).Append("\n");
            sb.Append("  Gidp: ").Append(Gidp).Append("\n");
            sb.Append("  Gitp: ").Append(Gitp).Append("\n");
            sb.Append("  HomeRuns: ").Append(HomeRuns).Append("\n");
            sb.Append("  NumberOfPitches: ").Append(NumberOfPitches).Append("\n");
            sb.Append("  TotalBases: ").Append(TotalBases).Append("\n");
            sb.Append("  GidpOpportunites: ").Append(GidpOpportunites).Append("\n");
            sb.Append("  Walks: ").Append(Walks).Append("\n");
            sb.Append("  HitByPitch: ").Append(HitByPitch).Append("\n");
            sb.Append("  Strikeouts: ").Append(Strikeouts).Append("\n");
            sb.Append("  AirOuts: ").Append(AirOuts).Append("\n");
            sb.Append("  GoAo: ").Append(GoAo).Append("\n");
            sb.Append("  PitchesPerPlateAppearance: ").Append(PitchesPerPlateAppearance).Append("\n");
            sb.Append("  IntentionalWalks: ").Append(IntentionalWalks).Append("\n");
            sb.Append("  GroundOuts: ").Append(GroundOuts).Append("\n");
            sb.Append("  FlyOuts: ").Append(FlyOuts).Append("\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
            sb.Append("  GamesStarted: ").Append(GamesStarted).Append("\n");
            sb.Append("  Doubles: ").Append(Doubles).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  Triples: ").Append(Triples).Append("\n");
            sb.Append("  Singles: ").Append(Singles).Append("\n");
            sb.Append("  Runs: ").Append(Runs).Append("\n");
            sb.Append("  AtBats: ").Append(AtBats).Append("\n");
            sb.Append("  Pickoffs: ").Append(Pickoffs).Append("\n");
            sb.Append("  StolenBasePercentage: ").Append(StolenBasePercentage).Append("\n");
            sb.Append("  WildPitches: ").Append(WildPitches).Append("\n");
            sb.Append("  SacFlies: ").Append(SacFlies).Append("\n");
            sb.Append("  SacBunts: ").Append(SacBunts).Append("\n");
            sb.Append("  Putouts: ").Append(Putouts).Append("\n");
            sb.Append("  Assists: ").Append(Assists).Append("\n");
            sb.Append("  Chances: ").Append(Chances).Append("\n");
            sb.Append("  Streak: ").Append(Streak).Append("\n");
            sb.Append("  BattingOrder: ").Append(BattingOrder).Append("\n");
            sb.Append("  TotalSwings: ").Append(TotalSwings).Append("\n");
            sb.Append("  SwingsAndMisses: ").Append(SwingsAndMisses).Append("\n");
            sb.Append("  BallsInPlay: ").Append(BallsInPlay).Append("\n");
            sb.Append("  PopOuts: ").Append(PopOuts).Append("\n");
            sb.Append("  LineOuts: ").Append(LineOuts).Append("\n");
            sb.Append("  FlyHits: ").Append(FlyHits).Append("\n");
            sb.Append("  PopHits: ").Append(PopHits).Append("\n");
            sb.Append("  LineHits: ").Append(LineHits).Append("\n");
            sb.Append("  GroundHits: ").Append(GroundHits).Append("\n");
            sb.Append("  GamesPlayedOnBothTeams: ").Append(GamesPlayedOnBothTeams).Append("\n");
            sb.Append("  OutfieldAssists: ").Append(OutfieldAssists).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  FieldingPercentage: ").Append(FieldingPercentage).Append("\n");
            sb.Append("  RangeFactorPerGame: ").Append(RangeFactorPerGame).Append("\n");
            sb.Append("  RangeFactorPer9Inn: ").Append(RangeFactorPer9Inn).Append("\n");
            sb.Append("  Innings: ").Append(Innings).Append("\n");
            sb.Append("  PassedBall: ").Append(PassedBall).Append("\n");
            sb.Append("  DoublePlays: ").Append(DoublePlays).Append("\n");
            sb.Append("  TriplePlays: ").Append(TriplePlays).Append("\n");
            sb.Append("  CatcherERA: ").Append(CatcherERA).Append("\n");
            sb.Append("  ThrowingErrors: ").Append(ThrowingErrors).Append("\n");
            sb.Append("  Uzr: ").Append(Uzr).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  PlateAppearances: ").Append(PlateAppearances).Append("\n");
            sb.Append("  PitchesPerPlateAppearanceStr: ").Append(PitchesPerPlateAppearanceStr).Append("\n");
            sb.Append("  StolenBasePercentageOrNull: ").Append(StolenBasePercentageOrNull).Append("\n");
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