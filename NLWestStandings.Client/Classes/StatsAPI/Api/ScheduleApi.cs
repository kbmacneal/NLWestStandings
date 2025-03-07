using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScheduleApi
    {
        /// <summary>
        /// Get postseason schedule This endpoint allows you to pull postseason schedules
        /// </summary>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="seriesNumber"></param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="sportId">Unique League Identifier</param>
        /// <param name="useLatestGames"></param>
        /// <param name="useFeaturedGame"></param>
        /// <param name="season"></param>
        /// <param name="publicFacing">Return public, non-public or all games. Format: Public Facing &#x3D; &#x27;Y&#x27;, Non-Public Facing &#x3D; &#x27;N&#x27;, All &#x3D; &#x27;A&#x27;</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        ScheduleRestObject PostseasonSchedule(List<GameTypeEnum> gameTypes, int? seriesNumber, int? teamId, int? sportId, bool? useLatestGames, bool? useFeaturedGame, string season, PublicFacingEnum publicFacing, List<string> fields);

        /// <summary>
        /// Get postseason series schedules This endpoint allows you to pull postseason schedules
        /// </summary>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="seriesNumber"></param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="sportId">Unique League Identifier</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="useLatestGames"></param>
        /// <param name="useFeaturedGame"></param>
        /// <param name="season"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>PostseasonScheduleRestObject</returns>
        PostseasonScheduleRestObject PostseasonScheduleSeries(List<GameTypeEnum> gameTypes, int? seriesNumber, int? teamId, int? sportId, DateTime? date, DateTime? startDate, DateTime? endDate, bool? useLatestGames, bool? useFeaturedGame, string season, List<string> fields);

        /// <summary>
        /// View schedule info based on scheduleType. View schedule info. This endpoint allows you to pull schedules
        /// </summary>
        /// <param name="usingPrivateEndpoint"></param>
        /// <param name="calendarTypes">Comma delimited list of type of calendar types</param>
        /// <param name="eventTypes">Comma delimited list of type of events. &lt;b&gt;Note: Don&#x27;t Use. This will be deprecated in favor of calendarTypes&lt;/b&gt;</param>
        /// <param name="scheduleEventTypes">Comma delimited list of type of event types</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="eventIds">A unique identifier for non-game event</param>
        /// <param name="venueIds">Unique Venue Identifier</param>
        /// <param name="performerIds">A unique identifier for non-team event performers</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="useLatestGames"></param>
        /// <param name="opponentId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="publicFacing">Return public, non-public or all games. Format: Public Facing &#x3D; &#x27;Y&#x27;, Non-Public Facing &#x3D; &#x27;N&#x27;, All &#x3D; &#x27;A&#x27;</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        ScheduleRestObject Schedule(bool? usingPrivateEndpoint, List<CalendarTypes> calendarTypes, List<CalendarTypes> eventTypes, List<ScheduleEventTypes> scheduleEventTypes, List<int?> teamId, List<int?> leagueId, List<int?> sportId, int? gamePk, List<int?> gamePks, List<int?> eventIds, List<int?> venueIds, List<int?> performerIds, List<GameTypeEnum> gameTypes, List<GameTypeEnum> gameType, List<string> season, List<string> seasons, DateTime? date, DateTime? startDate, DateTime? endDate, string timecode, bool? useLatestGames, List<int?> opponentId, PublicFacingEnum publicFacing, List<string> fields);

        /// <summary>
        /// View schedule info based on scheduleType. View schedule info. This endpoint allows you to pull schedules
        /// </summary>
        /// <param name="usingPrivateEndpoint"></param>
        /// <param name="calendarTypes">Comma delimited list of type of calendar types</param>
        /// <param name="eventTypes">Comma delimited list of type of events. &lt;b&gt;Note: Don&#x27;t Use. This will be deprecated in favor of calendarTypes&lt;/b&gt;</param>
        /// <param name="scheduleEventTypes">Comma delimited list of type of event types</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="eventIds">A unique identifier for non-game event</param>
        /// <param name="venueIds">Unique Venue Identifier</param>
        /// <param name="performerIds">A unique identifier for non-team event performers</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="useLatestGames"></param>
        /// <param name="opponentId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="publicFacing">Return public, non-public or all games. Format: Public Facing &#x3D; &#x27;Y&#x27;, Non-Public Facing &#x3D; &#x27;N&#x27;, All &#x3D; &#x27;A&#x27;</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        ScheduleRestObject Schedule1(bool? usingPrivateEndpoint, List<CalendarTypes> calendarTypes, List<CalendarTypes> eventTypes, List<ScheduleEventTypes> scheduleEventTypes, List<int?> teamId, List<int?> leagueId, List<int?> sportId, int? gamePk, List<int?> gamePks, List<int?> eventIds, List<int?> venueIds, List<int?> performerIds, List<GameTypeEnum> gameTypes, List<GameTypeEnum> gameType, List<string> season, List<string> seasons, DateTime? date, DateTime? startDate, DateTime? endDate, string timecode, bool? useLatestGames, List<int?> opponentId, PublicFacingEnum publicFacing, List<string> fields);

        /// <summary>
        /// Get tied game schedules This endpoint allows you to pull tie game schedules for the given season
        /// </summary>
        /// <param name="season">Season of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        ScheduleRestObject TieGames(string season, List<int?> sportId, List<GameTypeEnum> gameTypes, List<string> fields);

        /// <summary>
        /// Get tracking event schedules This endpoint allows you to pull schedules for tracking events
        /// </summary>
        /// <param name="calendarTypes">Comma delimited list of type of calendar types</param>
        /// <param name="eventTypes">Comma delimited list of type of events. &lt;b&gt;Note: Don&#x27;t Use. This will be deprecated in favor of calendarTypes&lt;/b&gt;</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="eventIds">A unique identifier for non-game event</param>
        /// <param name="venueIds">Unique Venue Identifier</param>
        /// <param name="performerIds">A unique identifier for non-team event performers</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="useLatestGames"></param>
        /// <param name="opponentId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="publicFacing">Return public, non-public or all games. Format: Public Facing &#x3D; &#x27;Y&#x27;, Non-Public Facing &#x3D; &#x27;N&#x27;, All &#x3D; &#x27;A&#x27;</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        ScheduleRestObject TrackingEventsSchedule(List<CalendarTypes> calendarTypes, List<CalendarTypes> eventTypes, List<int?> teamId, List<int?> leagueId, List<int?> sportId, int? gamePk, List<int?> gamePks, List<int?> eventIds, List<int?> venueIds, List<int?> performerIds, List<GameTypeEnum> gameTypes, List<GameTypeEnum> gameType, List<string> season, List<string> seasons, DateTime? date, DateTime? startDate, DateTime? endDate, string timecode, bool? useLatestGames, List<int?> opponentId, PublicFacingEnum publicFacing, List<string> fields);

        /// <summary>
        /// Get postseason TuneIn schedules This endpoint allows you to pull postseason schedules
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="sportId">Unique League Identifier</param>
        /// <param name="season">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        ScheduleRestObject TuneIn(int? teamId, int? sportId, string season, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ScheduleApi : IScheduleApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ScheduleApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScheduleApi(String basePath)
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
        /// Get postseason schedule This endpoint allows you to pull postseason schedules
        /// </summary>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="seriesNumber"></param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="sportId">Unique League Identifier</param>
        /// <param name="useLatestGames"></param>
        /// <param name="useFeaturedGame"></param>
        /// <param name="season"></param>
        /// <param name="publicFacing">Return public, non-public or all games. Format: Public Facing &#x3D; &#x27;Y&#x27;, Non-Public Facing &#x3D; &#x27;N&#x27;, All &#x3D; &#x27;A&#x27;</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        public ScheduleRestObject PostseasonSchedule(List<GameTypeEnum> gameTypes, int? seriesNumber, int? teamId, int? sportId, bool? useLatestGames, bool? useFeaturedGame, string season, PublicFacingEnum publicFacing, List<string> fields)
        {
            var path = "/api/v1/schedule/postseason";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (gameTypes != null) queryParams.Add("gameTypes", ApiClient.ParameterToString(gameTypes)); // query parameter
            if (seriesNumber != null) queryParams.Add("seriesNumber", ApiClient.ParameterToString(seriesNumber)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (useLatestGames != null) queryParams.Add("useLatestGames", ApiClient.ParameterToString(useLatestGames)); // query parameter
            if (useFeaturedGame != null) queryParams.Add("useFeaturedGame", ApiClient.ParameterToString(useFeaturedGame)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (publicFacing != null) queryParams.Add("publicFacing", ApiClient.ParameterToString(publicFacing)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PostseasonSchedule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PostseasonSchedule: " + response.ErrorMessage, response.ErrorMessage);

            return (ScheduleRestObject)ApiClient.Deserialize(response.Content, typeof(ScheduleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get postseason series schedules This endpoint allows you to pull postseason schedules
        /// </summary>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="seriesNumber"></param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="sportId">Unique League Identifier</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="useLatestGames"></param>
        /// <param name="useFeaturedGame"></param>
        /// <param name="season"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>PostseasonScheduleRestObject</returns>
        public PostseasonScheduleRestObject PostseasonScheduleSeries(List<GameTypeEnum> gameTypes, int? seriesNumber, int? teamId, int? sportId, DateTime? date, DateTime? startDate, DateTime? endDate, bool? useLatestGames, bool? useFeaturedGame, string season, List<string> fields)
        {
            var path = "/api/v1/schedule/postseason/series";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (gameTypes != null) queryParams.Add("gameTypes", ApiClient.ParameterToString(gameTypes)); // query parameter
            if (seriesNumber != null) queryParams.Add("seriesNumber", ApiClient.ParameterToString(seriesNumber)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (useLatestGames != null) queryParams.Add("useLatestGames", ApiClient.ParameterToString(useLatestGames)); // query parameter
            if (useFeaturedGame != null) queryParams.Add("useFeaturedGame", ApiClient.ParameterToString(useFeaturedGame)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PostseasonScheduleSeries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PostseasonScheduleSeries: " + response.ErrorMessage, response.ErrorMessage);

            return (PostseasonScheduleRestObject)ApiClient.Deserialize(response.Content, typeof(PostseasonScheduleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View schedule info based on scheduleType. View schedule info. This endpoint allows you to pull schedules
        /// </summary>
        /// <param name="usingPrivateEndpoint"></param>
        /// <param name="calendarTypes">Comma delimited list of type of calendar types</param>
        /// <param name="eventTypes">Comma delimited list of type of events. &lt;b&gt;Note: Don&#x27;t Use. This will be deprecated in favor of calendarTypes&lt;/b&gt;</param>
        /// <param name="scheduleEventTypes">Comma delimited list of type of event types</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="eventIds">A unique identifier for non-game event</param>
        /// <param name="venueIds">Unique Venue Identifier</param>
        /// <param name="performerIds">A unique identifier for non-team event performers</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="useLatestGames"></param>
        /// <param name="opponentId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="publicFacing">Return public, non-public or all games. Format: Public Facing &#x3D; &#x27;Y&#x27;, Non-Public Facing &#x3D; &#x27;N&#x27;, All &#x3D; &#x27;A&#x27;</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        public ScheduleRestObject Schedule(bool? usingPrivateEndpoint, List<CalendarTypes> calendarTypes, List<CalendarTypes> eventTypes, List<ScheduleEventTypes> scheduleEventTypes, List<int?> teamId, List<int?> leagueId, List<int?> sportId, int? gamePk, List<int?> gamePks, List<int?> eventIds, List<int?> venueIds, List<int?> performerIds, List<GameTypeEnum> gameTypes, List<GameTypeEnum> gameType, List<string> season, List<string> seasons, DateTime? date, DateTime? startDate, DateTime? endDate, string timecode, bool? useLatestGames, List<int?> opponentId, PublicFacingEnum publicFacing, List<string> fields)
        {
            // verify the required parameter 'usingPrivateEndpoint' is set
            if (usingPrivateEndpoint == null) throw new ApiException(400, "Missing required parameter 'usingPrivateEndpoint' when calling Schedule");

            var path = "/api/v1/schedule";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (calendarTypes != null) queryParams.Add("calendarTypes", ApiClient.ParameterToString(calendarTypes)); // query parameter
            if (eventTypes != null) queryParams.Add("eventTypes", ApiClient.ParameterToString(eventTypes)); // query parameter
            if (scheduleEventTypes != null) queryParams.Add("scheduleEventTypes", ApiClient.ParameterToString(scheduleEventTypes)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (gamePk != null) queryParams.Add("gamePk", ApiClient.ParameterToString(gamePk)); // query parameter
            if (gamePks != null) queryParams.Add("gamePks", ApiClient.ParameterToString(gamePks)); // query parameter
            if (eventIds != null) queryParams.Add("eventIds", ApiClient.ParameterToString(eventIds)); // query parameter
            if (venueIds != null) queryParams.Add("venueIds", ApiClient.ParameterToString(venueIds)); // query parameter
            if (performerIds != null) queryParams.Add("performerIds", ApiClient.ParameterToString(performerIds)); // query parameter
            if (gameTypes != null) queryParams.Add("gameTypes", ApiClient.ParameterToString(gameTypes)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (useLatestGames != null) queryParams.Add("useLatestGames", ApiClient.ParameterToString(useLatestGames)); // query parameter
            if (opponentId != null) queryParams.Add("opponentId", ApiClient.ParameterToString(opponentId)); // query parameter
            if (publicFacing != null) queryParams.Add("publicFacing", ApiClient.ParameterToString(publicFacing)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (usingPrivateEndpoint != null) queryParams.Add("usingPrivateEndpoint", ApiClient.ParameterToString(usingPrivateEndpoint)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Schedule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Schedule: " + response.ErrorMessage, response.ErrorMessage);

            return (ScheduleRestObject)ApiClient.Deserialize(response.Content, typeof(ScheduleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View schedule info based on scheduleType. View schedule info. This endpoint allows you to pull schedules
        /// </summary>
        /// <param name="usingPrivateEndpoint"></param>
        /// <param name="calendarTypes">Comma delimited list of type of calendar types</param>
        /// <param name="eventTypes">Comma delimited list of type of events. &lt;b&gt;Note: Don&#x27;t Use. This will be deprecated in favor of calendarTypes&lt;/b&gt;</param>
        /// <param name="scheduleEventTypes">Comma delimited list of type of event types</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="eventIds">A unique identifier for non-game event</param>
        /// <param name="venueIds">Unique Venue Identifier</param>
        /// <param name="performerIds">A unique identifier for non-team event performers</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="useLatestGames"></param>
        /// <param name="opponentId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="publicFacing">Return public, non-public or all games. Format: Public Facing &#x3D; &#x27;Y&#x27;, Non-Public Facing &#x3D; &#x27;N&#x27;, All &#x3D; &#x27;A&#x27;</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        public ScheduleRestObject Schedule1(bool? usingPrivateEndpoint, List<CalendarTypes> calendarTypes, List<CalendarTypes> eventTypes, List<ScheduleEventTypes> scheduleEventTypes, List<int?> teamId, List<int?> leagueId, List<int?> sportId, int? gamePk, List<int?> gamePks, List<int?> eventIds, List<int?> venueIds, List<int?> performerIds, List<GameTypeEnum> gameTypes, List<GameTypeEnum> gameType, List<string> season, List<string> seasons, DateTime? date, DateTime? startDate, DateTime? endDate, string timecode, bool? useLatestGames, List<int?> opponentId, PublicFacingEnum publicFacing, List<string> fields)
        {
            // verify the required parameter 'usingPrivateEndpoint' is set
            if (usingPrivateEndpoint == null) throw new ApiException(400, "Missing required parameter 'usingPrivateEndpoint' when calling Schedule1");

            var path = "/api/v1/schedule/{scheduleType}";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (calendarTypes != null) queryParams.Add("calendarTypes", ApiClient.ParameterToString(calendarTypes)); // query parameter
            if (eventTypes != null) queryParams.Add("eventTypes", ApiClient.ParameterToString(eventTypes)); // query parameter
            if (scheduleEventTypes != null) queryParams.Add("scheduleEventTypes", ApiClient.ParameterToString(scheduleEventTypes)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (gamePk != null) queryParams.Add("gamePk", ApiClient.ParameterToString(gamePk)); // query parameter
            if (gamePks != null) queryParams.Add("gamePks", ApiClient.ParameterToString(gamePks)); // query parameter
            if (eventIds != null) queryParams.Add("eventIds", ApiClient.ParameterToString(eventIds)); // query parameter
            if (venueIds != null) queryParams.Add("venueIds", ApiClient.ParameterToString(venueIds)); // query parameter
            if (performerIds != null) queryParams.Add("performerIds", ApiClient.ParameterToString(performerIds)); // query parameter
            if (gameTypes != null) queryParams.Add("gameTypes", ApiClient.ParameterToString(gameTypes)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (useLatestGames != null) queryParams.Add("useLatestGames", ApiClient.ParameterToString(useLatestGames)); // query parameter
            if (opponentId != null) queryParams.Add("opponentId", ApiClient.ParameterToString(opponentId)); // query parameter
            if (publicFacing != null) queryParams.Add("publicFacing", ApiClient.ParameterToString(publicFacing)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (usingPrivateEndpoint != null) queryParams.Add("usingPrivateEndpoint", ApiClient.ParameterToString(usingPrivateEndpoint)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Schedule1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Schedule1: " + response.ErrorMessage, response.ErrorMessage);

            return (ScheduleRestObject)ApiClient.Deserialize(response.Content, typeof(ScheduleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get tied game schedules This endpoint allows you to pull tie game schedules for the given season
        /// </summary>
        /// <param name="season">Season of play</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        public ScheduleRestObject TieGames(string season, List<int?> sportId, List<GameTypeEnum> gameTypes, List<string> fields)
        {
            // verify the required parameter 'season' is set
            if (season == null) throw new ApiException(400, "Missing required parameter 'season' when calling TieGames");

            var path = "/api/v1/schedule/games/tied";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (gameTypes != null) queryParams.Add("gameTypes", ApiClient.ParameterToString(gameTypes)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling TieGames: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling TieGames: " + response.ErrorMessage, response.ErrorMessage);

            return (ScheduleRestObject)ApiClient.Deserialize(response.Content, typeof(ScheduleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get tracking event schedules This endpoint allows you to pull schedules for tracking events
        /// </summary>
        /// <param name="calendarTypes">Comma delimited list of type of calendar types</param>
        /// <param name="eventTypes">Comma delimited list of type of events. &lt;b&gt;Note: Don&#x27;t Use. This will be deprecated in favor of calendarTypes&lt;/b&gt;</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="eventIds">A unique identifier for non-game event</param>
        /// <param name="venueIds">Unique Venue Identifier</param>
        /// <param name="performerIds">A unique identifier for non-team event performers</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="useLatestGames"></param>
        /// <param name="opponentId">A unique identifier for the opposing team. Must be used with Team ID</param>
        /// <param name="publicFacing">Return public, non-public or all games. Format: Public Facing &#x3D; &#x27;Y&#x27;, Non-Public Facing &#x3D; &#x27;N&#x27;, All &#x3D; &#x27;A&#x27;</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        public ScheduleRestObject TrackingEventsSchedule(List<CalendarTypes> calendarTypes, List<CalendarTypes> eventTypes, List<int?> teamId, List<int?> leagueId, List<int?> sportId, int? gamePk, List<int?> gamePks, List<int?> eventIds, List<int?> venueIds, List<int?> performerIds, List<GameTypeEnum> gameTypes, List<GameTypeEnum> gameType, List<string> season, List<string> seasons, DateTime? date, DateTime? startDate, DateTime? endDate, string timecode, bool? useLatestGames, List<int?> opponentId, PublicFacingEnum publicFacing, List<string> fields)
        {
            var path = "/api/v1/schedule/trackingEvents";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (calendarTypes != null) queryParams.Add("calendarTypes", ApiClient.ParameterToString(calendarTypes)); // query parameter
            if (eventTypes != null) queryParams.Add("eventTypes", ApiClient.ParameterToString(eventTypes)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (gamePk != null) queryParams.Add("gamePk", ApiClient.ParameterToString(gamePk)); // query parameter
            if (gamePks != null) queryParams.Add("gamePks", ApiClient.ParameterToString(gamePks)); // query parameter
            if (eventIds != null) queryParams.Add("eventIds", ApiClient.ParameterToString(eventIds)); // query parameter
            if (venueIds != null) queryParams.Add("venueIds", ApiClient.ParameterToString(venueIds)); // query parameter
            if (performerIds != null) queryParams.Add("performerIds", ApiClient.ParameterToString(performerIds)); // query parameter
            if (gameTypes != null) queryParams.Add("gameTypes", ApiClient.ParameterToString(gameTypes)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (useLatestGames != null) queryParams.Add("useLatestGames", ApiClient.ParameterToString(useLatestGames)); // query parameter
            if (opponentId != null) queryParams.Add("opponentId", ApiClient.ParameterToString(opponentId)); // query parameter
            if (publicFacing != null) queryParams.Add("publicFacing", ApiClient.ParameterToString(publicFacing)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling TrackingEventsSchedule: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling TrackingEventsSchedule: " + response.ErrorMessage, response.ErrorMessage);

            return (ScheduleRestObject)ApiClient.Deserialize(response.Content, typeof(ScheduleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get postseason TuneIn schedules This endpoint allows you to pull postseason schedules
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="sportId">Unique League Identifier</param>
        /// <param name="season">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        public ScheduleRestObject TuneIn(int? teamId, int? sportId, string season, List<string> fields)
        {
            var path = "/api/v1/schedule/postseason/tuneIn";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling TuneIn: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling TuneIn: " + response.ErrorMessage, response.ErrorMessage);

            return (ScheduleRestObject)ApiClient.Deserialize(response.Content, typeof(ScheduleRestObject), (IList<Parameter>)response.Headers);
        }
    }
}