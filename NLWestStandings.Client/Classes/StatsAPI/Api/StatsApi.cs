using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatsApi
    {
        /// <summary>
        /// View stats from search
        /// </summary>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="playIds">Comma delimited list of unique play identifiers</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="gameTypes">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="endDate">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="teamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="pitcherTeamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="batterTeamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="pitcherSportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="batterSportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="pitcherLeagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="batterLeagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="divisionIds">Comma delimited list of Unique League Identifiers</param>
        /// <param name="pitcherDivisionIds">Comma delimited list of Unique League Identifiers</param>
        /// <param name="batterDivisionIds">Comma delimited list of Unique League Identifiers</param>
        /// <param name="pitchersOnTeamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="battersOnTeamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="playerIds">A unique identifier for a player</param>
        /// <param name="playerPool">Return \&quot;ALL\&quot; or only \&quot;QUALIFIED\&quot; players based on plate appearances.</param>
        /// <param name="pitcherIds">A unique identifier for a player</param>
        /// <param name="batterIds">A unique identifier for a player</param>
        /// <param name="catcherIds">A unique identifier for a player</param>
        /// <param name="firstBasemanIds">A unique identifier for a player</param>
        /// <param name="secondBasemanIds">A unique identifier for a player</param>
        /// <param name="thirdBasemanIds">A unique identifier for a player</param>
        /// <param name="shortstopIds">A unique identifier for a player</param>
        /// <param name="leftFielderIds">A unique identifier for a player</param>
        /// <param name="centerFielderIds">A unique identifier for a player</param>
        /// <param name="rightFielderIds">A unique identifier for a player</param>
        /// <param name="runnerFirstIds">A unique identifier for a player</param>
        /// <param name="runnerSecondIds">A unique identifier for a player</param>
        /// <param name="runnerThirdIds">A unique identifier for a player</param>
        /// <param name="venueIds">Unique Venue Identifier</param>
        /// <param name="pitchHand">Handedness of pitcher</param>
        /// <param name="batSide">Bat side of hitter</param>
        /// <param name="pitchTypes">Classification of pitch (fastball, curveball, etc...)</param>
        /// <param name="pitchCodes">Result of the pitch (ball, called strike, etc...)</param>
        /// <param name="eventTypes">Type of event</param>
        /// <param name="positions">All of the details of a player&#x27;s position</param>
        /// <param name="primaryPositions">All of the details of a player&#x27;s position</param>
        /// <param name="minPitchSpeed">Minimum value to filter on</param>
        /// <param name="maxPitchSpeed">Maximum value to filter on</param>
        /// <param name="minSpinRate">Minimum value to filter on</param>
        /// <param name="maxSpinRate">Maximum value to filter on</param>
        /// <param name="minExtension">Minimum value to filter on</param>
        /// <param name="maxExtension">Maximum value to filter on</param>
        /// <param name="minExitVelocityAgainst">Minimum value to filter on</param>
        /// <param name="maxExitVelocityAgainst">Maximum value to filter on</param>
        /// <param name="minLaunchAngleAgainst">Minimum value to filter on</param>
        /// <param name="maxLaunchAngleAgainst">Maximum value to filter on</param>
        /// <param name="minExitVelocity">Minimum value to filter on</param>
        /// <param name="maxExitVelocity">Maximum value to filter on</param>
        /// <param name="minLaunchAngle">Minimum value to filter on</param>
        /// <param name="maxLaunchAngle">Maximum value to filter on</param>
        /// <param name="minHomeRunDistance">Minimum value to filter on</param>
        /// <param name="maxHomeRunDistance">Maximum value to filter on</param>
        /// <param name="minHitDistance">Minimum value to filter on</param>
        /// <param name="maxHitDistance">Maximum value to filter on</param>
        /// <param name="minHangTime">Minimum value to filter on</param>
        /// <param name="maxHangTime">Maximum value to filter on</param>
        /// <param name="minHitProbability">Minimum value to filter on</param>
        /// <param name="maxHitProbability">Maximum value to filter on</param>
        /// <param name="minCatchProbability">Minimum value to filter on</param>
        /// <param name="maxCatchProbability">Maximum value to filter on</param>
        /// <param name="minAttackAngle">Minimum value to filter on</param>
        /// <param name="maxAttackAngle">Maximum value to filter on</param>
        /// <param name="minBatSpeed">Minimum value to filter on</param>
        /// <param name="maxBatSpeed">Maximum value to filter on</param>
        /// <param name="minHomeRunXBallparks">Minimum value to filter on</param>
        /// <param name="maxHomeRunXBallparks">Maximum value to filter on</param>
        /// <param name="isBarrel">Whether or not a play resulted in a barreled ball</param>
        /// <param name="hitTrajectories">Trajectory of hit (line drive, fly ball, etc...)</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="groupBy">Group stats by PLAYER, TEAM, SEASON, VENUE, SPORT or STAT_GROUP</param>
        /// <param name="compareOver">Group stats by PLAYER, TEAM, SEASON, VENUE, SPORT or STAT_GROUP</param>
        /// <param name="sortStat">Baseball stat to sort splits by.</param>
        /// <param name="sortModifier">The prefix modifier for the sort stat.  avg, min, max. I.E minExitVelocity, maxLaunchAngle, avgHitDistance</param>
        /// <param name="sortOrder">The order of sorting, ascending or descending</param>
        /// <param name="percentile">Only return averages above this percentile. used for best effort plays</param>
        /// <param name="minOccurrences">Minimum occurrences to filter upon</param>
        /// <param name="minPlateAppearances">Minimum occurrences to filter upon</param>
        /// <param name="minInnings">Minimum occurrences to filter upon</param>
        /// <param name="qualifierRate">Minimum occurrences to filter upon</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="showTotals">Columns to return totals</param>
        /// <param name="includeNullMetrics">Show events with null metrics</param>
        /// <param name="statFields">Baseball stat fields to populate</param>
        /// <param name="atBatNumbers">The at bat number of a given game. Format: 1, 2, 3, etc</param>
        /// <param name="pitchNumbers">The pitch number of a given game. Format: 1, 2, 3, etc</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="debug"></param>
        /// <param name="activeStatus">Whether or not a player is active</param>
        /// <returns>StatContainerRestObject</returns>
        StatContainerRestObject BeastStats(List<StatGroup> group, List<int?> gamePks, List<string> playIds, List<string> seasons, List<GameTypeEnum> gameTypes, DateTime? date, DateTime? startDate, DateTime? endDate, List<int?> teamIds, List<int?> pitcherTeamIds, List<int?> batterTeamIds, List<int?> sportIds, List<int?> pitcherSportIds, List<int?> batterSportIds, List<int?> leagueIds, List<int?> pitcherLeagueIds, List<int?> batterLeagueIds, List<int?> divisionIds, List<int?> pitcherDivisionIds, List<int?> batterDivisionIds, List<int?> pitchersOnTeamIds, List<int?> battersOnTeamIds, List<int?> playerIds, PlayerPoolEnum playerPool, List<int?> pitcherIds, List<int?> batterIds, List<int?> catcherIds, List<int?> firstBasemanIds, List<int?> secondBasemanIds, List<int?> thirdBasemanIds, List<int?> shortstopIds, List<int?> leftFielderIds, List<int?> centerFielderIds, List<int?> rightFielderIds, List<int?> runnerFirstIds, List<int?> runnerSecondIds, List<int?> runnerThirdIds, List<int?> venueIds, string pitchHand, string batSide, List<PitchType> pitchTypes, List<PitchCode> pitchCodes, List<EventType> eventTypes, List<BaseballPosition> positions, List<BaseballPosition> primaryPositions, double? minPitchSpeed, double? maxPitchSpeed, double? minSpinRate, double? maxSpinRate, double? minExtension, double? maxExtension, double? minExitVelocityAgainst, double? maxExitVelocityAgainst, double? minLaunchAngleAgainst, double? maxLaunchAngleAgainst, double? minExitVelocity, double? maxExitVelocity, double? minLaunchAngle, double? maxLaunchAngle, double? minHomeRunDistance, double? maxHomeRunDistance, double? minHitDistance, double? maxHitDistance, double? minHangTime, double? maxHangTime, double? minHitProbability, double? maxHitProbability, double? minCatchProbability, double? maxCatchProbability, double? minAttackAngle, double? maxAttackAngle, double? minBatSpeed, double? maxBatSpeed, double? minHomeRunXBallparks, double? maxHomeRunXBallparks, bool? isBarrel, List<HitTrajectory> hitTrajectories, int? limit, int? offset, List<GroupByEnum> groupBy, List<GroupByEnum> compareOver, BaseballStatsEnum sortStat, AggregateSortTypeEnum sortModifier, SortOrderEnum sortOrder, int? percentile, int? minOccurrences, int? minPlateAppearances, int? minInnings, double? qualifierRate, List<string> sitCodes, bool? showTotals, bool? includeNullMetrics, List<StatField> statFields, List<int?> atBatNumbers, List<int?> pitchNumbers, List<string> fields, bool? debug, PlayerActiveStatusEnum activeStatus);

        /// <summary>
        /// Get outs above average for the current batter
        /// </summary>
        /// <param name="gamePk"></param>
        /// <param name="timecode"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatsRestObject</returns>
        StatsRestObject GetOutsAboveAverage(int? gamePk, string timecode, List<string> fields);

        /// <summary>
        /// Get the spray chart info for the current batter
        /// </summary>
        /// <param name="gamePk"></param>
        /// <param name="timecode"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatsRestObject</returns>
        StatsRestObject GetSprayChart(int? gamePk, string timecode, List<string> fields);

        /// <summary>
        /// Get the probability of a hit for the given hit data
        /// </summary>
        /// <param name="gamePk"></param>
        /// <param name="timecode"></param>
        /// <returns>List&lt;int?&gt;</returns>
        List<int?> GetStolenBaseProbability(int? gamePk, string timecode);

        /// <summary>
        /// View grouped stats
        /// </summary>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="metrics">Name of metric(s) for metric log stats.  Available metrics in /api/v1/metrics</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="batterTeamId">A unique identifier for the batter&#x27;s team</param>
        /// <param name="pitcherTeamId">A unique identifier for the pitcher&#x27;s team</param>
        /// <param name="batterId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="pitcherId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="combineSits">If true, gathers stats where all of the situational criteria are met. If false, returns stats where any of the situational criteria are met. Default: false</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="sortStat">Baseball stat to sort splits by.</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="playerPool">Return \&quot;ALL\&quot; or only \&quot;QUALIFIED\&quot; players based on plate appearances.</param>
        /// <param name="position">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="daysBack">Returns results from the last &#x27;X&#x27; days (Starting from yesterday).</param>
        /// <param name="gamesBack">Returns results from the last &#x27;X&#x27; games played.</param>
        /// <param name="excludeTradedPlayers">Excludes players who have since been traded from the input team</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="statFields">Baseball stat fields to populate</param>
        /// <param name="sortField">Baseball statField to sort on.  If no statField is given, sortField defaults to BASIC.  If 1 statField is given, that is the default sortField.</param>
        /// <returns>StatsRestObject</returns>
        StatsRestObject GroupedStats(List<StatType> stats, List<StatGroup> group, int? personId, int? teamId, List<int?> teamIds, GameTypeEnum gameType, string season, List<string> seasons, int? sportId, List<int?> sportIds, int? leagueId, List<int?> leagueIds, LeagueListsEnum leagueListId, List<MetricType> metrics, int? gamePk, List<int?> batterTeamId, List<int?> pitcherTeamId, int? batterId, int? pitcherId, List<string> sitCodes, bool? combineSits, int? opposingTeamId, List<string> fields, BaseballStatsEnum sortStat, SortOrderEnum order, PlayerPoolEnum playerPool, List<BaseballPosition> position, DateTime? startDate, DateTime? endDate, int? daysBack, int? gamesBack, bool? excludeTradedPlayers, int? offset, int? limit, List<StatField> statFields, StatField sortField);

        /// <summary>
        /// Get leaders for a statistic
        /// </summary>
        /// <param name="leaderCategories"></param>
        /// <param name="leaderGameTypes"></param>
        /// <param name="statGroup"></param>
        /// <param name="season"></param>
        /// <param name="expand"></param>
        /// <param name="sportId"></param>
        /// <param name="sportIds"></param>
        /// <param name="stats"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="teamId"></param>
        /// <param name="teamIds"></param>
        /// <param name="leagueId"></param>
        /// <param name="leagueIds"></param>
        /// <param name="leagueListId"></param>
        /// <param name="playerPool"></param>
        /// <param name="statType"></param>
        /// <param name="playerActive"></param>
        /// <param name="position"></param>
        /// <param name="sitCodes"></param>
        /// <param name="opposingTeamId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="daysBack"></param>
        /// <param name="gamesBack"></param>
        /// <param name="groupBy"></param>
        /// <param name="fields"></param>
        /// <returns>LeagueLeaderContainerRestObject</returns>
        LeagueLeaderContainerRestObject Leaders2(List<PersonLeadersEnum> leaderCategories, List<GameTypeEnum> leaderGameTypes, List<StatGroup> statGroup, string season, List<ExpandEnum> expand, int? sportId, List<int?> sportIds, List<StatType> stats, int? limit, int? offset, int? teamId, List<int?> teamIds, int? leagueId, List<int?> leagueIds, LeagueListsEnum leagueListId, PlayerPoolEnum playerPool, StatType statType, PlayerActiveStatusEnum playerActive, List<BaseballPosition> position, List<string> sitCodes, int? opposingTeamId, DateTime? startDate, DateTime? endDate, int? daysBack, int? gamesBack, GroupByEnum groupBy, List<string> fields);

        /// <summary>
        /// View metric stats
        /// </summary>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="metrics">Name of metric(s) for metric log stats.  Available metrics in /api/v1/metrics</param>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="personIds">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="batterId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="pitcherId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="opposingPlayerId">A unique identifier for the opposing team</param>
        /// <param name="position">All of the details of a player&#x27;s position</param>
        /// <param name="eventType">Type of event</param>
        /// <param name="pitchType">Classification of pitch (fastball, curveball, etc...)</param>
        /// <param name="hitTrajectory">Trajectory of hit (line drive, fly ball, etc...)</param>
        /// <param name="batSide">Bat side of hitter</param>
        /// <param name="pitchHand">Handedness of pitcher</param>
        /// <param name="venueId">All of the details of a venue</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="minValue">Minimum value to filter on</param>
        /// <param name="maxValue">Maximum value to filter on</param>
        /// <param name="percentile">Only return averages above this percentile. used for best effort plays</param>
        /// <param name="minOccurrences">Minimum occurrences to filter upon</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="batterTeamId">A unique identifier for the batter&#x27;s team</param>
        /// <param name="pitcherTeamId">A unique identifier for the pitcher&#x27;s team</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="debug"></param>
        /// <returns>StatsRestObject</returns>
        StatsRestObject MetricStats(List<StatType> stats, List<MetricType> metrics, int? personId, List<int?> personIds, int? batterId, int? pitcherId, int? teamId, List<StatGroup> group, string season, List<string> seasons, int? sportId, int? opposingTeamId, int? opposingPlayerId, List<BaseballPosition> position, List<EventType> eventType, List<string> pitchType, List<HitTrajectory> hitTrajectory, string batSide, string pitchHand, List<int?> venueId, int? gamePk, double? minValue, double? maxValue, int? percentile, int? minOccurrences, int? offset, int? limit, SortOrderEnum order, DateTime? date, DateTime? startDate, DateTime? endDate, GameTypeEnum gameType, List<int?> batterTeamId, List<int?> pitcherTeamId, List<string> fields, bool? debug);

        /// <summary>
        /// View stats
        /// </summary>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="metrics">Name of metric(s) for metric log stats.  Available metrics in /api/v1/metrics</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="batterTeamId">A unique identifier for the batter&#x27;s team</param>
        /// <param name="pitcherTeamId">A unique identifier for the pitcher&#x27;s team</param>
        /// <param name="batterId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="pitcherId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="combineSits">If true, gathers stats where all of the situational criteria are met. If false, returns stats where any of the situational criteria are met. Default: false</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="fields"></param>
        /// <param name="sortStat">Baseball stat to sort splits by.</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="playerPool">Return \&quot;ALL\&quot; or only \&quot;QUALIFIED\&quot; players based on plate appearances.</param>
        /// <param name="position">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="daysBack">Returns results from the last &#x27;X&#x27; days (Starting from yesterday).</param>
        /// <param name="gamesBack">Returns results from the last &#x27;X&#x27; games played.</param>
        /// <param name="excludeTradedPlayers">Excludes players who have since been traded from the input team</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="limit">Number of results to return</param>
        /// <returns>StatsRestObject</returns>
        StatsRestObject Stats2(List<StatType> stats, List<StatGroup> group, int? personId, int? teamId, List<int?> teamIds, GameTypeEnum gameType, string season, List<string> seasons, int? sportId, List<int?> sportIds, int? leagueId, List<int?> leagueIds, LeagueListsEnum leagueListId, List<MetricType> metrics, int? gamePk, List<int?> batterTeamId, List<int?> pitcherTeamId, int? batterId, int? pitcherId, List<string> sitCodes, bool? combineSits, int? opposingTeamId, List<string> fields, BaseballStatsEnum sortStat, SortOrderEnum order, PlayerPoolEnum playerPool, List<BaseballPosition> position, DateTime? startDate, DateTime? endDate, int? daysBack, int? gamesBack, bool? excludeTradedPlayers, int? offset, int? limit);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StatsApi : IStatsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StatsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// View stats from search
        /// </summary>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="playIds">Comma delimited list of unique play identifiers</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="gameTypes">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="endDate">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="teamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="pitcherTeamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="batterTeamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="pitcherSportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="batterSportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="pitcherLeagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="batterLeagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="divisionIds">Comma delimited list of Unique League Identifiers</param>
        /// <param name="pitcherDivisionIds">Comma delimited list of Unique League Identifiers</param>
        /// <param name="batterDivisionIds">Comma delimited list of Unique League Identifiers</param>
        /// <param name="pitchersOnTeamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="battersOnTeamIds">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="playerIds">A unique identifier for a player</param>
        /// <param name="playerPool">Return \&quot;ALL\&quot; or only \&quot;QUALIFIED\&quot; players based on plate appearances.</param>
        /// <param name="pitcherIds">A unique identifier for a player</param>
        /// <param name="batterIds">A unique identifier for a player</param>
        /// <param name="catcherIds">A unique identifier for a player</param>
        /// <param name="firstBasemanIds">A unique identifier for a player</param>
        /// <param name="secondBasemanIds">A unique identifier for a player</param>
        /// <param name="thirdBasemanIds">A unique identifier for a player</param>
        /// <param name="shortstopIds">A unique identifier for a player</param>
        /// <param name="leftFielderIds">A unique identifier for a player</param>
        /// <param name="centerFielderIds">A unique identifier for a player</param>
        /// <param name="rightFielderIds">A unique identifier for a player</param>
        /// <param name="runnerFirstIds">A unique identifier for a player</param>
        /// <param name="runnerSecondIds">A unique identifier for a player</param>
        /// <param name="runnerThirdIds">A unique identifier for a player</param>
        /// <param name="venueIds">Unique Venue Identifier</param>
        /// <param name="pitchHand">Handedness of pitcher</param>
        /// <param name="batSide">Bat side of hitter</param>
        /// <param name="pitchTypes">Classification of pitch (fastball, curveball, etc...)</param>
        /// <param name="pitchCodes">Result of the pitch (ball, called strike, etc...)</param>
        /// <param name="eventTypes">Type of event</param>
        /// <param name="positions">All of the details of a player&#x27;s position</param>
        /// <param name="primaryPositions">All of the details of a player&#x27;s position</param>
        /// <param name="minPitchSpeed">Minimum value to filter on</param>
        /// <param name="maxPitchSpeed">Maximum value to filter on</param>
        /// <param name="minSpinRate">Minimum value to filter on</param>
        /// <param name="maxSpinRate">Maximum value to filter on</param>
        /// <param name="minExtension">Minimum value to filter on</param>
        /// <param name="maxExtension">Maximum value to filter on</param>
        /// <param name="minExitVelocityAgainst">Minimum value to filter on</param>
        /// <param name="maxExitVelocityAgainst">Maximum value to filter on</param>
        /// <param name="minLaunchAngleAgainst">Minimum value to filter on</param>
        /// <param name="maxLaunchAngleAgainst">Maximum value to filter on</param>
        /// <param name="minExitVelocity">Minimum value to filter on</param>
        /// <param name="maxExitVelocity">Maximum value to filter on</param>
        /// <param name="minLaunchAngle">Minimum value to filter on</param>
        /// <param name="maxLaunchAngle">Maximum value to filter on</param>
        /// <param name="minHomeRunDistance">Minimum value to filter on</param>
        /// <param name="maxHomeRunDistance">Maximum value to filter on</param>
        /// <param name="minHitDistance">Minimum value to filter on</param>
        /// <param name="maxHitDistance">Maximum value to filter on</param>
        /// <param name="minHangTime">Minimum value to filter on</param>
        /// <param name="maxHangTime">Maximum value to filter on</param>
        /// <param name="minHitProbability">Minimum value to filter on</param>
        /// <param name="maxHitProbability">Maximum value to filter on</param>
        /// <param name="minCatchProbability">Minimum value to filter on</param>
        /// <param name="maxCatchProbability">Maximum value to filter on</param>
        /// <param name="minAttackAngle">Minimum value to filter on</param>
        /// <param name="maxAttackAngle">Maximum value to filter on</param>
        /// <param name="minBatSpeed">Minimum value to filter on</param>
        /// <param name="maxBatSpeed">Maximum value to filter on</param>
        /// <param name="minHomeRunXBallparks">Minimum value to filter on</param>
        /// <param name="maxHomeRunXBallparks">Maximum value to filter on</param>
        /// <param name="isBarrel">Whether or not a play resulted in a barreled ball</param>
        /// <param name="hitTrajectories">Trajectory of hit (line drive, fly ball, etc...)</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="groupBy">Group stats by PLAYER, TEAM, SEASON, VENUE, SPORT or STAT_GROUP</param>
        /// <param name="compareOver">Group stats by PLAYER, TEAM, SEASON, VENUE, SPORT or STAT_GROUP</param>
        /// <param name="sortStat">Baseball stat to sort splits by.</param>
        /// <param name="sortModifier">The prefix modifier for the sort stat.  avg, min, max. I.E minExitVelocity, maxLaunchAngle, avgHitDistance</param>
        /// <param name="sortOrder">The order of sorting, ascending or descending</param>
        /// <param name="percentile">Only return averages above this percentile. used for best effort plays</param>
        /// <param name="minOccurrences">Minimum occurrences to filter upon</param>
        /// <param name="minPlateAppearances">Minimum occurrences to filter upon</param>
        /// <param name="minInnings">Minimum occurrences to filter upon</param>
        /// <param name="qualifierRate">Minimum occurrences to filter upon</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="showTotals">Columns to return totals</param>
        /// <param name="includeNullMetrics">Show events with null metrics</param>
        /// <param name="statFields">Baseball stat fields to populate</param>
        /// <param name="atBatNumbers">The at bat number of a given game. Format: 1, 2, 3, etc</param>
        /// <param name="pitchNumbers">The pitch number of a given game. Format: 1, 2, 3, etc</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="debug"></param>
        /// <param name="activeStatus">Whether or not a player is active</param>
        /// <returns>StatContainerRestObject</returns>
        public StatContainerRestObject BeastStats(List<StatGroup> group, List<int?> gamePks, List<string> playIds, List<string> seasons, List<GameTypeEnum> gameTypes, DateTime? date, DateTime? startDate, DateTime? endDate, List<int?> teamIds, List<int?> pitcherTeamIds, List<int?> batterTeamIds, List<int?> sportIds, List<int?> pitcherSportIds, List<int?> batterSportIds, List<int?> leagueIds, List<int?> pitcherLeagueIds, List<int?> batterLeagueIds, List<int?> divisionIds, List<int?> pitcherDivisionIds, List<int?> batterDivisionIds, List<int?> pitchersOnTeamIds, List<int?> battersOnTeamIds, List<int?> playerIds, PlayerPoolEnum playerPool, List<int?> pitcherIds, List<int?> batterIds, List<int?> catcherIds, List<int?> firstBasemanIds, List<int?> secondBasemanIds, List<int?> thirdBasemanIds, List<int?> shortstopIds, List<int?> leftFielderIds, List<int?> centerFielderIds, List<int?> rightFielderIds, List<int?> runnerFirstIds, List<int?> runnerSecondIds, List<int?> runnerThirdIds, List<int?> venueIds, string pitchHand, string batSide, List<PitchType> pitchTypes, List<PitchCode> pitchCodes, List<EventType> eventTypes, List<BaseballPosition> positions, List<BaseballPosition> primaryPositions, double? minPitchSpeed, double? maxPitchSpeed, double? minSpinRate, double? maxSpinRate, double? minExtension, double? maxExtension, double? minExitVelocityAgainst, double? maxExitVelocityAgainst, double? minLaunchAngleAgainst, double? maxLaunchAngleAgainst, double? minExitVelocity, double? maxExitVelocity, double? minLaunchAngle, double? maxLaunchAngle, double? minHomeRunDistance, double? maxHomeRunDistance, double? minHitDistance, double? maxHitDistance, double? minHangTime, double? maxHangTime, double? minHitProbability, double? maxHitProbability, double? minCatchProbability, double? maxCatchProbability, double? minAttackAngle, double? maxAttackAngle, double? minBatSpeed, double? maxBatSpeed, double? minHomeRunXBallparks, double? maxHomeRunXBallparks, bool? isBarrel, List<HitTrajectory> hitTrajectories, int? limit, int? offset, List<GroupByEnum> groupBy, List<GroupByEnum> compareOver, BaseballStatsEnum sortStat, AggregateSortTypeEnum sortModifier, SortOrderEnum sortOrder, int? percentile, int? minOccurrences, int? minPlateAppearances, int? minInnings, double? qualifierRate, List<string> sitCodes, bool? showTotals, bool? includeNullMetrics, List<StatField> statFields, List<int?> atBatNumbers, List<int?> pitchNumbers, List<string> fields, bool? debug, PlayerActiveStatusEnum activeStatus)
        {
            // verify the required parameter 'group' is set
            if (group == null) throw new ApiException(400, "Missing required parameter 'group' when calling BeastStats");

            var path = "/api/v1/stats/search";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (gamePks != null) queryParams.Add("gamePks", ApiClient.ParameterToString(gamePks)); // query parameter
            if (playIds != null) queryParams.Add("playIds", ApiClient.ParameterToString(playIds)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (gameTypes != null) queryParams.Add("gameTypes", ApiClient.ParameterToString(gameTypes)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (teamIds != null) queryParams.Add("teamIds", ApiClient.ParameterToString(teamIds)); // query parameter
            if (pitcherTeamIds != null) queryParams.Add("pitcherTeamIds", ApiClient.ParameterToString(pitcherTeamIds)); // query parameter
            if (batterTeamIds != null) queryParams.Add("batterTeamIds", ApiClient.ParameterToString(batterTeamIds)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter
            if (pitcherSportIds != null) queryParams.Add("pitcherSportIds", ApiClient.ParameterToString(pitcherSportIds)); // query parameter
            if (batterSportIds != null) queryParams.Add("batterSportIds", ApiClient.ParameterToString(batterSportIds)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (pitcherLeagueIds != null) queryParams.Add("pitcherLeagueIds", ApiClient.ParameterToString(pitcherLeagueIds)); // query parameter
            if (batterLeagueIds != null) queryParams.Add("batterLeagueIds", ApiClient.ParameterToString(batterLeagueIds)); // query parameter
            if (divisionIds != null) queryParams.Add("divisionIds", ApiClient.ParameterToString(divisionIds)); // query parameter
            if (pitcherDivisionIds != null) queryParams.Add("pitcherDivisionIds", ApiClient.ParameterToString(pitcherDivisionIds)); // query parameter
            if (batterDivisionIds != null) queryParams.Add("batterDivisionIds", ApiClient.ParameterToString(batterDivisionIds)); // query parameter
            if (pitchersOnTeamIds != null) queryParams.Add("pitchersOnTeamIds", ApiClient.ParameterToString(pitchersOnTeamIds)); // query parameter
            if (battersOnTeamIds != null) queryParams.Add("battersOnTeamIds", ApiClient.ParameterToString(battersOnTeamIds)); // query parameter
            if (playerIds != null) queryParams.Add("playerIds", ApiClient.ParameterToString(playerIds)); // query parameter
            if (playerPool != null) queryParams.Add("playerPool", ApiClient.ParameterToString(playerPool)); // query parameter
            if (pitcherIds != null) queryParams.Add("pitcherIds", ApiClient.ParameterToString(pitcherIds)); // query parameter
            if (batterIds != null) queryParams.Add("batterIds", ApiClient.ParameterToString(batterIds)); // query parameter
            if (catcherIds != null) queryParams.Add("catcherIds", ApiClient.ParameterToString(catcherIds)); // query parameter
            if (firstBasemanIds != null) queryParams.Add("firstBasemanIds", ApiClient.ParameterToString(firstBasemanIds)); // query parameter
            if (secondBasemanIds != null) queryParams.Add("secondBasemanIds", ApiClient.ParameterToString(secondBasemanIds)); // query parameter
            if (thirdBasemanIds != null) queryParams.Add("thirdBasemanIds", ApiClient.ParameterToString(thirdBasemanIds)); // query parameter
            if (shortstopIds != null) queryParams.Add("shortstopIds", ApiClient.ParameterToString(shortstopIds)); // query parameter
            if (leftFielderIds != null) queryParams.Add("leftFielderIds", ApiClient.ParameterToString(leftFielderIds)); // query parameter
            if (centerFielderIds != null) queryParams.Add("centerFielderIds", ApiClient.ParameterToString(centerFielderIds)); // query parameter
            if (rightFielderIds != null) queryParams.Add("rightFielderIds", ApiClient.ParameterToString(rightFielderIds)); // query parameter
            if (runnerFirstIds != null) queryParams.Add("runnerFirstIds", ApiClient.ParameterToString(runnerFirstIds)); // query parameter
            if (runnerSecondIds != null) queryParams.Add("runnerSecondIds", ApiClient.ParameterToString(runnerSecondIds)); // query parameter
            if (runnerThirdIds != null) queryParams.Add("runnerThirdIds", ApiClient.ParameterToString(runnerThirdIds)); // query parameter
            if (venueIds != null) queryParams.Add("venueIds", ApiClient.ParameterToString(venueIds)); // query parameter
            if (pitchHand != null) queryParams.Add("pitchHand", ApiClient.ParameterToString(pitchHand)); // query parameter
            if (batSide != null) queryParams.Add("batSide", ApiClient.ParameterToString(batSide)); // query parameter
            if (pitchTypes != null) queryParams.Add("pitchTypes", ApiClient.ParameterToString(pitchTypes)); // query parameter
            if (pitchCodes != null) queryParams.Add("pitchCodes", ApiClient.ParameterToString(pitchCodes)); // query parameter
            if (eventTypes != null) queryParams.Add("eventTypes", ApiClient.ParameterToString(eventTypes)); // query parameter
            if (positions != null) queryParams.Add("positions", ApiClient.ParameterToString(positions)); // query parameter
            if (primaryPositions != null) queryParams.Add("primaryPositions", ApiClient.ParameterToString(primaryPositions)); // query parameter
            if (minPitchSpeed != null) queryParams.Add("minPitchSpeed", ApiClient.ParameterToString(minPitchSpeed)); // query parameter
            if (maxPitchSpeed != null) queryParams.Add("maxPitchSpeed", ApiClient.ParameterToString(maxPitchSpeed)); // query parameter
            if (minSpinRate != null) queryParams.Add("minSpinRate", ApiClient.ParameterToString(minSpinRate)); // query parameter
            if (maxSpinRate != null) queryParams.Add("maxSpinRate", ApiClient.ParameterToString(maxSpinRate)); // query parameter
            if (minExtension != null) queryParams.Add("minExtension", ApiClient.ParameterToString(minExtension)); // query parameter
            if (maxExtension != null) queryParams.Add("maxExtension", ApiClient.ParameterToString(maxExtension)); // query parameter
            if (minExitVelocityAgainst != null) queryParams.Add("minExitVelocityAgainst", ApiClient.ParameterToString(minExitVelocityAgainst)); // query parameter
            if (maxExitVelocityAgainst != null) queryParams.Add("maxExitVelocityAgainst", ApiClient.ParameterToString(maxExitVelocityAgainst)); // query parameter
            if (minLaunchAngleAgainst != null) queryParams.Add("minLaunchAngleAgainst", ApiClient.ParameterToString(minLaunchAngleAgainst)); // query parameter
            if (maxLaunchAngleAgainst != null) queryParams.Add("maxLaunchAngleAgainst", ApiClient.ParameterToString(maxLaunchAngleAgainst)); // query parameter
            if (minExitVelocity != null) queryParams.Add("minExitVelocity", ApiClient.ParameterToString(minExitVelocity)); // query parameter
            if (maxExitVelocity != null) queryParams.Add("maxExitVelocity", ApiClient.ParameterToString(maxExitVelocity)); // query parameter
            if (minLaunchAngle != null) queryParams.Add("minLaunchAngle", ApiClient.ParameterToString(minLaunchAngle)); // query parameter
            if (maxLaunchAngle != null) queryParams.Add("maxLaunchAngle", ApiClient.ParameterToString(maxLaunchAngle)); // query parameter
            if (minHomeRunDistance != null) queryParams.Add("minHomeRunDistance", ApiClient.ParameterToString(minHomeRunDistance)); // query parameter
            if (maxHomeRunDistance != null) queryParams.Add("maxHomeRunDistance", ApiClient.ParameterToString(maxHomeRunDistance)); // query parameter
            if (minHitDistance != null) queryParams.Add("minHitDistance", ApiClient.ParameterToString(minHitDistance)); // query parameter
            if (maxHitDistance != null) queryParams.Add("maxHitDistance", ApiClient.ParameterToString(maxHitDistance)); // query parameter
            if (minHangTime != null) queryParams.Add("minHangTime", ApiClient.ParameterToString(minHangTime)); // query parameter
            if (maxHangTime != null) queryParams.Add("maxHangTime", ApiClient.ParameterToString(maxHangTime)); // query parameter
            if (minHitProbability != null) queryParams.Add("minHitProbability", ApiClient.ParameterToString(minHitProbability)); // query parameter
            if (maxHitProbability != null) queryParams.Add("maxHitProbability", ApiClient.ParameterToString(maxHitProbability)); // query parameter
            if (minCatchProbability != null) queryParams.Add("minCatchProbability", ApiClient.ParameterToString(minCatchProbability)); // query parameter
            if (maxCatchProbability != null) queryParams.Add("maxCatchProbability", ApiClient.ParameterToString(maxCatchProbability)); // query parameter
            if (minAttackAngle != null) queryParams.Add("minAttackAngle", ApiClient.ParameterToString(minAttackAngle)); // query parameter
            if (maxAttackAngle != null) queryParams.Add("maxAttackAngle", ApiClient.ParameterToString(maxAttackAngle)); // query parameter
            if (minBatSpeed != null) queryParams.Add("minBatSpeed", ApiClient.ParameterToString(minBatSpeed)); // query parameter
            if (maxBatSpeed != null) queryParams.Add("maxBatSpeed", ApiClient.ParameterToString(maxBatSpeed)); // query parameter
            if (minHomeRunXBallparks != null) queryParams.Add("minHomeRunXBallparks", ApiClient.ParameterToString(minHomeRunXBallparks)); // query parameter
            if (maxHomeRunXBallparks != null) queryParams.Add("maxHomeRunXBallparks", ApiClient.ParameterToString(maxHomeRunXBallparks)); // query parameter
            if (isBarrel != null) queryParams.Add("isBarrel", ApiClient.ParameterToString(isBarrel)); // query parameter
            if (hitTrajectories != null) queryParams.Add("hitTrajectories", ApiClient.ParameterToString(hitTrajectories)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (groupBy != null) queryParams.Add("groupBy", ApiClient.ParameterToString(groupBy)); // query parameter
            if (compareOver != null) queryParams.Add("compareOver", ApiClient.ParameterToString(compareOver)); // query parameter
            if (sortStat != null) queryParams.Add("sortStat", ApiClient.ParameterToString(sortStat)); // query parameter
            if (sortModifier != null) queryParams.Add("sortModifier", ApiClient.ParameterToString(sortModifier)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", ApiClient.ParameterToString(sortOrder)); // query parameter
            if (percentile != null) queryParams.Add("percentile", ApiClient.ParameterToString(percentile)); // query parameter
            if (minOccurrences != null) queryParams.Add("minOccurrences", ApiClient.ParameterToString(minOccurrences)); // query parameter
            if (minPlateAppearances != null) queryParams.Add("minPlateAppearances", ApiClient.ParameterToString(minPlateAppearances)); // query parameter
            if (minInnings != null) queryParams.Add("minInnings", ApiClient.ParameterToString(minInnings)); // query parameter
            if (qualifierRate != null) queryParams.Add("qualifierRate", ApiClient.ParameterToString(qualifierRate)); // query parameter
            if (sitCodes != null) queryParams.Add("sitCodes", ApiClient.ParameterToString(sitCodes)); // query parameter
            if (showTotals != null) queryParams.Add("showTotals", ApiClient.ParameterToString(showTotals)); // query parameter
            if (includeNullMetrics != null) queryParams.Add("includeNullMetrics", ApiClient.ParameterToString(includeNullMetrics)); // query parameter
            if (statFields != null) queryParams.Add("statFields", ApiClient.ParameterToString(statFields)); // query parameter
            if (atBatNumbers != null) queryParams.Add("atBatNumbers", ApiClient.ParameterToString(atBatNumbers)); // query parameter
            if (pitchNumbers != null) queryParams.Add("pitchNumbers", ApiClient.ParameterToString(pitchNumbers)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (debug != null) queryParams.Add("debug", ApiClient.ParameterToString(debug)); // query parameter
            if (activeStatus != null) queryParams.Add("activeStatus", ApiClient.ParameterToString(activeStatus)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling BeastStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling BeastStats: " + response.ErrorMessage, response.ErrorMessage);

            return (StatContainerRestObject)ApiClient.Deserialize(response.Content, typeof(StatContainerRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get outs above average for the current batter
        /// </summary>
        /// <param name="gamePk"></param>
        /// <param name="timecode"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatsRestObject</returns>
        public StatsRestObject GetOutsAboveAverage(int? gamePk, string timecode, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling GetOutsAboveAverage");

            var path = "/api/v1/stats/analytics/outsAboveAverage";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (gamePk != null) queryParams.Add("gamePk", ApiClient.ParameterToString(gamePk)); // query parameter
            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetOutsAboveAverage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetOutsAboveAverage: " + response.ErrorMessage, response.ErrorMessage);

            return (StatsRestObject)ApiClient.Deserialize(response.Content, typeof(StatsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get the spray chart info for the current batter
        /// </summary>
        /// <param name="gamePk"></param>
        /// <param name="timecode"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatsRestObject</returns>
        public StatsRestObject GetSprayChart(int? gamePk, string timecode, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling GetSprayChart");

            var path = "/api/v1/stats/analytics/sprayChart";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (gamePk != null) queryParams.Add("gamePk", ApiClient.ParameterToString(gamePk)); // query parameter
            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetSprayChart: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetSprayChart: " + response.ErrorMessage, response.ErrorMessage);

            return (StatsRestObject)ApiClient.Deserialize(response.Content, typeof(StatsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get the probability of a hit for the given hit data
        /// </summary>
        /// <param name="gamePk"></param>
        /// <param name="timecode"></param>
        /// <returns>List&lt;int?&gt;</returns>
        public List<int?> GetStolenBaseProbability(int? gamePk, string timecode)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling GetStolenBaseProbability");

            var path = "/api/v1/stats/analytics/stolenBaseProbability";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (gamePk != null) queryParams.Add("gamePk", ApiClient.ParameterToString(gamePk)); // query parameter
            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetStolenBaseProbability: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetStolenBaseProbability: " + response.ErrorMessage, response.ErrorMessage);

            return (List<int?>)ApiClient.Deserialize(response.Content, typeof(List<int?>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View grouped stats
        /// </summary>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="metrics">Name of metric(s) for metric log stats.  Available metrics in /api/v1/metrics</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="batterTeamId">A unique identifier for the batter&#x27;s team</param>
        /// <param name="pitcherTeamId">A unique identifier for the pitcher&#x27;s team</param>
        /// <param name="batterId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="pitcherId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="combineSits">If true, gathers stats where all of the situational criteria are met. If false, returns stats where any of the situational criteria are met. Default: false</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="sortStat">Baseball stat to sort splits by.</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="playerPool">Return \&quot;ALL\&quot; or only \&quot;QUALIFIED\&quot; players based on plate appearances.</param>
        /// <param name="position">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="daysBack">Returns results from the last &#x27;X&#x27; days (Starting from yesterday).</param>
        /// <param name="gamesBack">Returns results from the last &#x27;X&#x27; games played.</param>
        /// <param name="excludeTradedPlayers">Excludes players who have since been traded from the input team</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="statFields">Baseball stat fields to populate</param>
        /// <param name="sortField">Baseball statField to sort on.  If no statField is given, sortField defaults to BASIC.  If 1 statField is given, that is the default sortField.</param>
        /// <returns>StatsRestObject</returns>
        public StatsRestObject GroupedStats(List<StatType> stats, List<StatGroup> group, int? personId, int? teamId, List<int?> teamIds, GameTypeEnum gameType, string season, List<string> seasons, int? sportId, List<int?> sportIds, int? leagueId, List<int?> leagueIds, LeagueListsEnum leagueListId, List<MetricType> metrics, int? gamePk, List<int?> batterTeamId, List<int?> pitcherTeamId, int? batterId, int? pitcherId, List<string> sitCodes, bool? combineSits, int? opposingTeamId, List<string> fields, BaseballStatsEnum sortStat, SortOrderEnum order, PlayerPoolEnum playerPool, List<BaseballPosition> position, DateTime? startDate, DateTime? endDate, int? daysBack, int? gamesBack, bool? excludeTradedPlayers, int? offset, int? limit, List<StatField> statFields, StatField sortField)
        {
            // verify the required parameter 'stats' is set
            if (stats == null) throw new ApiException(400, "Missing required parameter 'stats' when calling GroupedStats");
            // verify the required parameter 'group' is set
            if (group == null) throw new ApiException(400, "Missing required parameter 'group' when calling GroupedStats");

            var path = "/api/v1/stats/grouped";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (stats != null) queryParams.Add("stats", ApiClient.ParameterToString(stats)); // query parameter
            if (personId != null) queryParams.Add("personId", ApiClient.ParameterToString(personId)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (teamIds != null) queryParams.Add("teamIds", ApiClient.ParameterToString(teamIds)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (leagueListId != null) queryParams.Add("leagueListId", ApiClient.ParameterToString(leagueListId)); // query parameter
            if (metrics != null) queryParams.Add("metrics", ApiClient.ParameterToString(metrics)); // query parameter
            if (gamePk != null) queryParams.Add("gamePk", ApiClient.ParameterToString(gamePk)); // query parameter
            if (batterTeamId != null) queryParams.Add("batterTeamId", ApiClient.ParameterToString(batterTeamId)); // query parameter
            if (pitcherTeamId != null) queryParams.Add("pitcherTeamId", ApiClient.ParameterToString(pitcherTeamId)); // query parameter
            if (batterId != null) queryParams.Add("batterId", ApiClient.ParameterToString(batterId)); // query parameter
            if (pitcherId != null) queryParams.Add("pitcherId", ApiClient.ParameterToString(pitcherId)); // query parameter
            if (sitCodes != null) queryParams.Add("sitCodes", ApiClient.ParameterToString(sitCodes)); // query parameter
            if (combineSits != null) queryParams.Add("combineSits", ApiClient.ParameterToString(combineSits)); // query parameter
            if (opposingTeamId != null) queryParams.Add("opposingTeamId", ApiClient.ParameterToString(opposingTeamId)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (sortStat != null) queryParams.Add("sortStat", ApiClient.ParameterToString(sortStat)); // query parameter
            if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
            if (playerPool != null) queryParams.Add("playerPool", ApiClient.ParameterToString(playerPool)); // query parameter
            if (position != null) queryParams.Add("position", ApiClient.ParameterToString(position)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (daysBack != null) queryParams.Add("daysBack", ApiClient.ParameterToString(daysBack)); // query parameter
            if (gamesBack != null) queryParams.Add("gamesBack", ApiClient.ParameterToString(gamesBack)); // query parameter
            if (excludeTradedPlayers != null) queryParams.Add("excludeTradedPlayers", ApiClient.ParameterToString(excludeTradedPlayers)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (statFields != null) queryParams.Add("statFields", ApiClient.ParameterToString(statFields)); // query parameter
            if (sortField != null) queryParams.Add("sortField", ApiClient.ParameterToString(sortField)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GroupedStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GroupedStats: " + response.ErrorMessage, response.ErrorMessage);

            return (StatsRestObject)ApiClient.Deserialize(response.Content, typeof(StatsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get leaders for a statistic
        /// </summary>
        /// <param name="leaderCategories"></param>
        /// <param name="leaderGameTypes"></param>
        /// <param name="statGroup"></param>
        /// <param name="season"></param>
        /// <param name="expand"></param>
        /// <param name="sportId"></param>
        /// <param name="sportIds"></param>
        /// <param name="stats"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="teamId"></param>
        /// <param name="teamIds"></param>
        /// <param name="leagueId"></param>
        /// <param name="leagueIds"></param>
        /// <param name="leagueListId"></param>
        /// <param name="playerPool"></param>
        /// <param name="statType"></param>
        /// <param name="playerActive"></param>
        /// <param name="position"></param>
        /// <param name="sitCodes"></param>
        /// <param name="opposingTeamId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="daysBack"></param>
        /// <param name="gamesBack"></param>
        /// <param name="groupBy"></param>
        /// <param name="fields"></param>
        /// <returns>LeagueLeaderContainerRestObject</returns>
        public LeagueLeaderContainerRestObject Leaders2(List<PersonLeadersEnum> leaderCategories, List<GameTypeEnum> leaderGameTypes, List<StatGroup> statGroup, string season, List<ExpandEnum> expand, int? sportId, List<int?> sportIds, List<StatType> stats, int? limit, int? offset, int? teamId, List<int?> teamIds, int? leagueId, List<int?> leagueIds, LeagueListsEnum leagueListId, PlayerPoolEnum playerPool, StatType statType, PlayerActiveStatusEnum playerActive, List<BaseballPosition> position, List<string> sitCodes, int? opposingTeamId, DateTime? startDate, DateTime? endDate, int? daysBack, int? gamesBack, GroupByEnum groupBy, List<string> fields)
        {
            var path = "/api/v1/stats/leaders";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leaderCategories != null) queryParams.Add("leaderCategories", ApiClient.ParameterToString(leaderCategories)); // query parameter
            if (leaderGameTypes != null) queryParams.Add("leaderGameTypes", ApiClient.ParameterToString(leaderGameTypes)); // query parameter
            if (statGroup != null) queryParams.Add("statGroup", ApiClient.ParameterToString(statGroup)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (expand != null) queryParams.Add("expand", ApiClient.ParameterToString(expand)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter
            if (stats != null) queryParams.Add("stats", ApiClient.ParameterToString(stats)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (teamIds != null) queryParams.Add("teamIds", ApiClient.ParameterToString(teamIds)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (leagueListId != null) queryParams.Add("leagueListId", ApiClient.ParameterToString(leagueListId)); // query parameter
            if (playerPool != null) queryParams.Add("playerPool", ApiClient.ParameterToString(playerPool)); // query parameter
            if (statType != null) queryParams.Add("statType", ApiClient.ParameterToString(statType)); // query parameter
            if (playerActive != null) queryParams.Add("playerActive", ApiClient.ParameterToString(playerActive)); // query parameter
            if (position != null) queryParams.Add("position", ApiClient.ParameterToString(position)); // query parameter
            if (sitCodes != null) queryParams.Add("sitCodes", ApiClient.ParameterToString(sitCodes)); // query parameter
            if (opposingTeamId != null) queryParams.Add("opposingTeamId", ApiClient.ParameterToString(opposingTeamId)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (daysBack != null) queryParams.Add("daysBack", ApiClient.ParameterToString(daysBack)); // query parameter
            if (gamesBack != null) queryParams.Add("gamesBack", ApiClient.ParameterToString(gamesBack)); // query parameter
            if (groupBy != null) queryParams.Add("groupBy", ApiClient.ParameterToString(groupBy)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Leaders2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Leaders2: " + response.ErrorMessage, response.ErrorMessage);

            return (LeagueLeaderContainerRestObject)ApiClient.Deserialize(response.Content, typeof(LeagueLeaderContainerRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View metric stats
        /// </summary>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="metrics">Name of metric(s) for metric log stats.  Available metrics in /api/v1/metrics</param>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="personIds">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="batterId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="pitcherId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="opposingPlayerId">A unique identifier for the opposing team</param>
        /// <param name="position">All of the details of a player&#x27;s position</param>
        /// <param name="eventType">Type of event</param>
        /// <param name="pitchType">Classification of pitch (fastball, curveball, etc...)</param>
        /// <param name="hitTrajectory">Trajectory of hit (line drive, fly ball, etc...)</param>
        /// <param name="batSide">Bat side of hitter</param>
        /// <param name="pitchHand">Handedness of pitcher</param>
        /// <param name="venueId">All of the details of a venue</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="minValue">Minimum value to filter on</param>
        /// <param name="maxValue">Maximum value to filter on</param>
        /// <param name="percentile">Only return averages above this percentile. used for best effort plays</param>
        /// <param name="minOccurrences">Minimum occurrences to filter upon</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="batterTeamId">A unique identifier for the batter&#x27;s team</param>
        /// <param name="pitcherTeamId">A unique identifier for the pitcher&#x27;s team</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="debug"></param>
        /// <returns>StatsRestObject</returns>
        public StatsRestObject MetricStats(List<StatType> stats, List<MetricType> metrics, int? personId, List<int?> personIds, int? batterId, int? pitcherId, int? teamId, List<StatGroup> group, string season, List<string> seasons, int? sportId, int? opposingTeamId, int? opposingPlayerId, List<BaseballPosition> position, List<EventType> eventType, List<string> pitchType, List<HitTrajectory> hitTrajectory, string batSide, string pitchHand, List<int?> venueId, int? gamePk, double? minValue, double? maxValue, int? percentile, int? minOccurrences, int? offset, int? limit, SortOrderEnum order, DateTime? date, DateTime? startDate, DateTime? endDate, GameTypeEnum gameType, List<int?> batterTeamId, List<int?> pitcherTeamId, List<string> fields, bool? debug)
        {
            // verify the required parameter 'stats' is set
            if (stats == null) throw new ApiException(400, "Missing required parameter 'stats' when calling MetricStats");
            // verify the required parameter 'metrics' is set
            if (metrics == null) throw new ApiException(400, "Missing required parameter 'metrics' when calling MetricStats");

            var path = "/api/v1/stats/metrics";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (personId != null) queryParams.Add("personId", ApiClient.ParameterToString(personId)); // query parameter
            if (personIds != null) queryParams.Add("personIds", ApiClient.ParameterToString(personIds)); // query parameter
            if (batterId != null) queryParams.Add("batterId", ApiClient.ParameterToString(batterId)); // query parameter
            if (pitcherId != null) queryParams.Add("pitcherId", ApiClient.ParameterToString(pitcherId)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (stats != null) queryParams.Add("stats", ApiClient.ParameterToString(stats)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (opposingTeamId != null) queryParams.Add("opposingTeamId", ApiClient.ParameterToString(opposingTeamId)); // query parameter
            if (opposingPlayerId != null) queryParams.Add("opposingPlayerId", ApiClient.ParameterToString(opposingPlayerId)); // query parameter
            if (position != null) queryParams.Add("position", ApiClient.ParameterToString(position)); // query parameter
            if (eventType != null) queryParams.Add("eventType", ApiClient.ParameterToString(eventType)); // query parameter
            if (pitchType != null) queryParams.Add("pitchType", ApiClient.ParameterToString(pitchType)); // query parameter
            if (hitTrajectory != null) queryParams.Add("hitTrajectory", ApiClient.ParameterToString(hitTrajectory)); // query parameter
            if (batSide != null) queryParams.Add("batSide", ApiClient.ParameterToString(batSide)); // query parameter
            if (pitchHand != null) queryParams.Add("pitchHand", ApiClient.ParameterToString(pitchHand)); // query parameter
            if (venueId != null) queryParams.Add("venueId", ApiClient.ParameterToString(venueId)); // query parameter
            if (metrics != null) queryParams.Add("metrics", ApiClient.ParameterToString(metrics)); // query parameter
            if (gamePk != null) queryParams.Add("gamePk", ApiClient.ParameterToString(gamePk)); // query parameter
            if (minValue != null) queryParams.Add("minValue", ApiClient.ParameterToString(minValue)); // query parameter
            if (maxValue != null) queryParams.Add("maxValue", ApiClient.ParameterToString(maxValue)); // query parameter
            if (percentile != null) queryParams.Add("percentile", ApiClient.ParameterToString(percentile)); // query parameter
            if (minOccurrences != null) queryParams.Add("minOccurrences", ApiClient.ParameterToString(minOccurrences)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (batterTeamId != null) queryParams.Add("batterTeamId", ApiClient.ParameterToString(batterTeamId)); // query parameter
            if (pitcherTeamId != null) queryParams.Add("pitcherTeamId", ApiClient.ParameterToString(pitcherTeamId)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (debug != null) queryParams.Add("debug", ApiClient.ParameterToString(debug)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling MetricStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling MetricStats: " + response.ErrorMessage, response.ErrorMessage);

            return (StatsRestObject)ApiClient.Deserialize(response.Content, typeof(StatsRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View stats
        /// </summary>
        /// <param name="stats">Type of statistics. Format: Individual, Team, Career, etc. Available types in /api/v1/statTypes</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="personId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="metrics">Name of metric(s) for metric log stats.  Available metrics in /api/v1/metrics</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="batterTeamId">A unique identifier for the batter&#x27;s team</param>
        /// <param name="pitcherTeamId">A unique identifier for the pitcher&#x27;s team</param>
        /// <param name="batterId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="pitcherId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="sitCodes">Situation code for a given stat split.</param>
        /// <param name="combineSits">If true, gathers stats where all of the situational criteria are met. If false, returns stats where any of the situational criteria are met. Default: false</param>
        /// <param name="opposingTeamId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="fields"></param>
        /// <param name="sortStat">Baseball stat to sort splits by.</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="playerPool">Return \&quot;ALL\&quot; or only \&quot;QUALIFIED\&quot; players based on plate appearances.</param>
        /// <param name="position">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="daysBack">Returns results from the last &#x27;X&#x27; days (Starting from yesterday).</param>
        /// <param name="gamesBack">Returns results from the last &#x27;X&#x27; games played.</param>
        /// <param name="excludeTradedPlayers">Excludes players who have since been traded from the input team</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="limit">Number of results to return</param>
        /// <returns>StatsRestObject</returns>
        public StatsRestObject Stats2(List<StatType> stats, List<StatGroup> group, int? personId, int? teamId, List<int?> teamIds, GameTypeEnum gameType, string season, List<string> seasons, int? sportId, List<int?> sportIds, int? leagueId, List<int?> leagueIds, LeagueListsEnum leagueListId, List<MetricType> metrics, int? gamePk, List<int?> batterTeamId, List<int?> pitcherTeamId, int? batterId, int? pitcherId, List<string> sitCodes, bool? combineSits, int? opposingTeamId, List<string> fields, BaseballStatsEnum sortStat, SortOrderEnum order, PlayerPoolEnum playerPool, List<BaseballPosition> position, DateTime? startDate, DateTime? endDate, int? daysBack, int? gamesBack, bool? excludeTradedPlayers, int? offset, int? limit)
        {
            // verify the required parameter 'stats' is set
            if (stats == null) throw new ApiException(400, "Missing required parameter 'stats' when calling Stats2");
            // verify the required parameter 'group' is set
            if (group == null) throw new ApiException(400, "Missing required parameter 'group' when calling Stats2");

            var path = "/api/v1/stats";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (stats != null) queryParams.Add("stats", ApiClient.ParameterToString(stats)); // query parameter
            if (personId != null) queryParams.Add("personId", ApiClient.ParameterToString(personId)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (teamIds != null) queryParams.Add("teamIds", ApiClient.ParameterToString(teamIds)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (leagueListId != null) queryParams.Add("leagueListId", ApiClient.ParameterToString(leagueListId)); // query parameter
            if (metrics != null) queryParams.Add("metrics", ApiClient.ParameterToString(metrics)); // query parameter
            if (gamePk != null) queryParams.Add("gamePk", ApiClient.ParameterToString(gamePk)); // query parameter
            if (batterTeamId != null) queryParams.Add("batterTeamId", ApiClient.ParameterToString(batterTeamId)); // query parameter
            if (pitcherTeamId != null) queryParams.Add("pitcherTeamId", ApiClient.ParameterToString(pitcherTeamId)); // query parameter
            if (batterId != null) queryParams.Add("batterId", ApiClient.ParameterToString(batterId)); // query parameter
            if (pitcherId != null) queryParams.Add("pitcherId", ApiClient.ParameterToString(pitcherId)); // query parameter
            if (sitCodes != null) queryParams.Add("sitCodes", ApiClient.ParameterToString(sitCodes)); // query parameter
            if (combineSits != null) queryParams.Add("combineSits", ApiClient.ParameterToString(combineSits)); // query parameter
            if (opposingTeamId != null) queryParams.Add("opposingTeamId", ApiClient.ParameterToString(opposingTeamId)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (sortStat != null) queryParams.Add("sortStat", ApiClient.ParameterToString(sortStat)); // query parameter
            if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
            if (playerPool != null) queryParams.Add("playerPool", ApiClient.ParameterToString(playerPool)); // query parameter
            if (position != null) queryParams.Add("position", ApiClient.ParameterToString(position)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (daysBack != null) queryParams.Add("daysBack", ApiClient.ParameterToString(daysBack)); // query parameter
            if (gamesBack != null) queryParams.Add("gamesBack", ApiClient.ParameterToString(gamesBack)); // query parameter
            if (excludeTradedPlayers != null) queryParams.Add("excludeTradedPlayers", ApiClient.ParameterToString(excludeTradedPlayers)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Stats2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Stats2: " + response.ErrorMessage, response.ErrorMessage);

            return (StatsRestObject)ApiClient.Deserialize(response.Content, typeof(StatsRestObject), (IList<Parameter>)response.Headers);
        }
    }
}