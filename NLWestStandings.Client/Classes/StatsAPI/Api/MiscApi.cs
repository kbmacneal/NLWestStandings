using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMiscApi
    {
        /// <summary>
        /// List all stat fields
        /// </summary>
        /// <returns>List&lt;AggregateSortTypeRestObject&gt;</returns>
        List<AggregateSortTypeRestObject> AggregateSortEnum();

        /// <summary>
        /// List all baseball stats
        /// </summary>
        /// <returns>List&lt;BaseballStatsTypeRestObject&gt;</returns>
        List<BaseballStatsTypeRestObject> BaseballStats();

        /// <summary>
        /// View broadcast availability options
        /// </summary>
        /// <returns>List&lt;BroadcastAvailabilityRestObject&gt;</returns>
        List<BroadcastAvailabilityRestObject> BroadcastAvailabilityTypes();

        /// <summary>
        /// List all coaching video types
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> CoachingVideoTypes();

        /// <summary>
        /// List all possible event status types
        /// </summary>
        /// <returns>List&lt;IGameStatus&gt;</returns>
        List<IGameStatus> EventStatus();

        /// <summary>
        /// List all event types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        string EventTypes(List<string> fields);

        /// <summary>
        /// List fielder detail types
        /// </summary>
        /// <returns>List&lt;FielderDetailType&gt;</returns>
        List<FielderDetailType> FielderDetailTypes();

        /// <summary>
        /// View free game types
        /// </summary>
        /// <returns>List&lt;FreeGameTypeRestObject&gt;</returns>
        List<FreeGameTypeRestObject> FreeGameTypes();

        /// <summary>
        /// List all status types
        /// </summary>
        /// <returns>List&lt;RestObject&gt;</returns>
        List<RestObject> GameStatus();

        /// <summary>
        /// List all game types
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <returns>List&lt;GameTypeEnum&gt;</returns>
        List<GameTypeEnum> GameTypes(int? sportId, int? leagueId, string season);

        /// <summary>
        /// List all gameday types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        List<GeneralLookupRestObject> GamedayTypes(List<string> fields);

        /// <summary>
        /// View all lookup values
        /// </summary>
        /// <returns>Dictionary&lt;string, List&lt;Object&gt;&gt;</returns>
        Dictionary<string, List<Object>> GetLookupValues();

        /// <summary>
        /// List groupBy types
        /// </summary>
        /// <returns>List&lt;GroupByEnum&gt;</returns>
        List<GroupByEnum> GroupByTypes();

        /// <summary>
        /// List all hit trajectories
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        List<GeneralLookupRestObject> HitTrajectories(List<string> fields);

        /// <summary>
        /// List all job types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;JobTypeRestObject&gt;</returns>
        List<JobTypeRestObject> JobTypes(List<string> fields);

        /// <summary>
        /// List all support languages
        /// </summary>
        /// <returns>List&lt;Language&gt;</returns>
        List<Language> Languages();

        /// <summary>
        /// List all possible player league leader types
        /// </summary>
        /// <returns>List&lt;LeagueLeaderTypeRestObject&gt;</returns>
        List<LeagueLeaderTypeRestObject> LeagueLeaderTypes();

        /// <summary>
        /// List all logical event types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        List<GeneralLookupRestObject> LogicalEvents(List<string> fields);

        /// <summary>
        /// View media state options
        /// </summary>
        /// <returns>List&lt;MediaStateRestObject&gt;</returns>
        List<MediaStateRestObject> MediaStateTypes();

        /// <summary>
        /// List all possible metrics
        /// </summary>
        /// <returns>List&lt;RestObject&gt;</returns>
        List<RestObject> Metrics();

        /// <summary>
        /// List all mound visit types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        List<GeneralLookupRestObject> MoundVisitTypes(List<string> fields);

        /// <summary>
        /// List all possible performer types
        /// </summary>
        /// <returns>List&lt;PerformerType&gt;</returns>
        List<PerformerType> PerformerTypes();

        /// <summary>
        /// List all pitch codes
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;PitchCodeRestObject&gt;</returns>
        List<PitchCodeRestObject> PitchCodes(List<string> fields);

        /// <summary>
        /// List all pitch classification types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        List<GeneralLookupRestObject> PitchTypes(List<string> fields);

        /// <summary>
        /// List all possible platforms
        /// </summary>
        /// <returns>List&lt;Platform&gt;</returns>
        List<Platform> Platforms();

        /// <summary>
        /// List all player status codes
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        List<GeneralLookupRestObject> PlayerStatusCodes(List<string> fields);

        /// <summary>
        /// List all possible positions
        /// </summary>
        /// <returns>List&lt;BaseballPosition&gt;</returns>
        List<BaseballPosition> Positions();

        /// <summary>
        /// List all replay review reasons
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        List<GeneralLookupRestObject> ReviewReasons(List<string> fields);

        /// <summary>
        /// List all roof types
        /// </summary>
        /// <returns>List&lt;RoofTypeRestObject&gt;</returns>
        List<RoofTypeRestObject> RoofTypes();

        /// <summary>
        /// List all possible roster types
        /// </summary>
        /// <returns>List&lt;RosterType&gt;</returns>
        List<RosterType> RosterTypes();

        /// <summary>
        /// List all ruleSettings
        /// </summary>
        /// <returns>List&lt;RuleSettingsRestObject&gt;</returns>
        List<RuleSettingsRestObject> RuleSettings();

        /// <summary>
        /// List runner detail types
        /// </summary>
        /// <returns>List&lt;RunnerDetailType&gt;</returns>
        List<RunnerDetailType> RunnerDetailTypes();

        /// <summary>
        /// List all schedule event types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;ScheduleEventTypeRestObject&gt;</returns>
        List<ScheduleEventTypeRestObject> ScheduleEventTypes(List<string> fields);

        /// <summary>
        /// List all possible schedule types
        /// </summary>
        /// <returns>List&lt;ScheduleTypeEnum&gt;</returns>
        List<ScheduleTypeEnum> ScheduleTypes();

        /// <summary>
        /// List all situation codes
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="season">Season of play</param>
        /// <param name="statGroup">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <returns>List&lt;SituationCodeRestObject&gt;</returns>
        List<SituationCodeRestObject> SitCodes(List<string> fields, string season, StatGroup statGroup);

        /// <summary>
        /// List all sky options
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        List<GeneralLookupRestObject> Sky(List<string> fields);

        /// <summary>
        /// List all standings types
        /// </summary>
        /// <returns>List&lt;StandingsType&gt;</returns>
        List<StandingsType> StandingsTypes();

        /// <summary>
        /// List all stat fields
        /// </summary>
        /// <returns>List&lt;StatField&gt;</returns>
        List<StatField> StatFields();

        /// <summary>
        /// List all stat groups
        /// </summary>
        /// <returns>List&lt;StatGroup&gt;</returns>
        List<StatGroup> StatGroups();

        /// <summary>
        /// Stats Search Config Endpoint
        /// </summary>
        /// <param name="filterLevel">Categories of filters for stat search</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <returns>StatSearchConfigRestObject</returns>
        StatSearchConfigRestObject StatSearchConfig(FilterLevelEnum filterLevel, StatGroup group);

        /// <summary>
        /// List groupBy types
        /// </summary>
        /// <param name="filterLevel">Categories of filters for stat search</param>
        /// <returns>List&lt;GroupByEnum&gt;</returns>
        List<GroupByEnum> StatSearchGroupByTypes(FilterLevelEnum filterLevel);

        /// <summary>
        /// List stat search parameters
        /// </summary>
        /// <param name="filterLevel">Categories of filters for stat search</param>
        /// <returns>List&lt;StatSearchParamRestObject&gt;</returns>
        List<StatSearchParamRestObject> StatSearchParams(FilterLevelEnum filterLevel);

        /// <summary>
        /// List stat search stats
        /// </summary>
        /// <param name="filterLevel">Categories of filters for stat search</param>
        /// <returns>List&lt;StatSearchStatRestObject&gt;</returns>
        List<StatSearchStatRestObject> StatSearchStats(FilterLevelEnum filterLevel);

        /// <summary>
        /// List all stat types
        /// </summary>
        /// <returns>List&lt;StatType&gt;</returns>
        List<StatType> StatTypes();

        /// <summary>
        /// List all statcast position types
        /// </summary>
        /// <returns>List&lt;StatcastPositionRestObject&gt;</returns>
        List<StatcastPositionRestObject> StatcastPositionTypes();

        /// <summary>
        /// List the tracking software versions and notes
        /// </summary>
        /// <returns>List&lt;TrackingSoftwareVersionRestObject&gt;</returns>
        List<TrackingSoftwareVersionRestObject> TrackingSoftwareVersions();

        /// <summary>
        /// List all tracking system owners
        /// </summary>
        /// <returns>List&lt;TrackingSystemOwner&gt;</returns>
        List<TrackingSystemOwner> TrackingSystemOwners();

        /// <summary>
        /// List all tracking vendors
        /// </summary>
        /// <returns>List&lt;TrackingVendor&gt;</returns>
        List<TrackingVendor> TrackingVendors();

        /// <summary>
        /// List all tracking versions
        /// </summary>
        /// <returns>List&lt;TrackingVersion&gt;</returns>
        List<TrackingVersion> TrackingVersions();

        /// <summary>
        /// List all transaction types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        List<GeneralLookupRestObject> TransactionTypes(List<string> fields);

        /// <summary>
        /// Clear all status types
        /// </summary>
        /// <returns>string</returns>
        string UpdateGameStatuses();

        /// <summary>
        ///
        /// </summary>
        /// <returns>string</returns>
        string UpdateJobTypes();

        /// <summary>
        /// View video resolution options
        /// </summary>
        /// <returns>List&lt;VideoResolutionEnumRestObject&gt;</returns>
        List<VideoResolutionEnumRestObject> VideoResolutionTypes();

        /// <summary>
        /// View available violationType options
        /// </summary>
        /// <returns>List&lt;ViolationTypeRestObject&gt;</returns>
        List<ViolationTypeRestObject> ViolationTypes();

        /// <summary>
        /// List all weather trajectories
        /// </summary>
        /// <returns>List&lt;WeatherTrajectoryConfidenceTypeRestObject&gt;</returns>
        List<WeatherTrajectoryConfidenceTypeRestObject> WeatherTrajectoryConfidences();

        /// <summary>
        /// List all wind direction options
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        List<GeneralLookupRestObject> WindDirection(List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MiscApi : IMiscApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiscApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MiscApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MiscApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MiscApi(String basePath)
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
        /// List all stat fields
        /// </summary>
        /// <returns>List&lt;AggregateSortTypeRestObject&gt;</returns>
        public List<AggregateSortTypeRestObject> AggregateSortEnum()
        {
            var path = "/api/v1/sortModifiers";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AggregateSortEnum: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AggregateSortEnum: " + response.ErrorMessage, response.ErrorMessage);

            return (List<AggregateSortTypeRestObject>)ApiClient.Deserialize(response.Content, typeof(List<AggregateSortTypeRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all baseball stats
        /// </summary>
        /// <returns>List&lt;BaseballStatsTypeRestObject&gt;</returns>
        public List<BaseballStatsTypeRestObject> BaseballStats()
        {
            var path = "/api/v1/baseballStats";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling BaseballStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling BaseballStats: " + response.ErrorMessage, response.ErrorMessage);

            return (List<BaseballStatsTypeRestObject>)ApiClient.Deserialize(response.Content, typeof(List<BaseballStatsTypeRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View broadcast availability options
        /// </summary>
        /// <returns>List&lt;BroadcastAvailabilityRestObject&gt;</returns>
        public List<BroadcastAvailabilityRestObject> BroadcastAvailabilityTypes()
        {
            var path = "/api/v1/broadcastAvailability";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling BroadcastAvailabilityTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling BroadcastAvailabilityTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<BroadcastAvailabilityRestObject>)ApiClient.Deserialize(response.Content, typeof(List<BroadcastAvailabilityRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all coaching video types
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> CoachingVideoTypes()
        {
            var path = "/api/v1/coachingVideoTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CoachingVideoTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CoachingVideoTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<string>)ApiClient.Deserialize(response.Content, typeof(List<string>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all possible event status types
        /// </summary>
        /// <returns>List&lt;IGameStatus&gt;</returns>
        public List<IGameStatus> EventStatus()
        {
            var path = "/api/v1/eventStatus";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling EventStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling EventStatus: " + response.ErrorMessage, response.ErrorMessage);

            return (List<IGameStatus>)ApiClient.Deserialize(response.Content, typeof(List<IGameStatus>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all event types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        public string EventTypes(List<string> fields)
        {
            var path = "/api/v1/eventTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling EventTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling EventTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List fielder detail types
        /// </summary>
        /// <returns>List&lt;FielderDetailType&gt;</returns>
        public List<FielderDetailType> FielderDetailTypes()
        {
            var path = "/api/v1/fielderDetailTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling FielderDetailTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling FielderDetailTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<FielderDetailType>)ApiClient.Deserialize(response.Content, typeof(List<FielderDetailType>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View free game types
        /// </summary>
        /// <returns>List&lt;FreeGameTypeRestObject&gt;</returns>
        public List<FreeGameTypeRestObject> FreeGameTypes()
        {
            var path = "/api/v1/freeGameTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling FreeGameTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling FreeGameTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<FreeGameTypeRestObject>)ApiClient.Deserialize(response.Content, typeof(List<FreeGameTypeRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all status types
        /// </summary>
        /// <returns>List&lt;RestObject&gt;</returns>
        public List<RestObject> GameStatus()
        {
            var path = "/api/v1/gameStatus";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GameStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GameStatus: " + response.ErrorMessage, response.ErrorMessage);

            return (List<RestObject>)ApiClient.Deserialize(response.Content, typeof(List<RestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all game types
        /// </summary>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <returns>List&lt;GameTypeEnum&gt;</returns>
        public List<GameTypeEnum> GameTypes(int? sportId, int? leagueId, string season)
        {
            var path = "/api/v1/gameTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GameTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GameTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GameTypeEnum>)ApiClient.Deserialize(response.Content, typeof(List<GameTypeEnum>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all gameday types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        public List<GeneralLookupRestObject> GamedayTypes(List<string> fields)
        {
            var path = "/api/v1/gamedayTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GamedayTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GamedayTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GeneralLookupRestObject>)ApiClient.Deserialize(response.Content, typeof(List<GeneralLookupRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View all lookup values
        /// </summary>
        /// <returns>Dictionary&lt;string, List&lt;Object&gt;&gt;</returns>
        public Dictionary<string, List<Object>> GetLookupValues()
        {
            var path = "/api/v1/lookup/values/all";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetLookupValues: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetLookupValues: " + response.ErrorMessage, response.ErrorMessage);

            return (Dictionary<string, List<Object>>)ApiClient.Deserialize(response.Content, typeof(Dictionary<string, List<Object>>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List groupBy types
        /// </summary>
        /// <returns>List&lt;GroupByEnum&gt;</returns>
        public List<GroupByEnum> GroupByTypes()
        {
            var path = "/api/v1/groupByTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GroupByTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GroupByTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GroupByEnum>)ApiClient.Deserialize(response.Content, typeof(List<GroupByEnum>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all hit trajectories
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        public List<GeneralLookupRestObject> HitTrajectories(List<string> fields)
        {
            var path = "/api/v1/hitTrajectories";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling HitTrajectories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling HitTrajectories: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GeneralLookupRestObject>)ApiClient.Deserialize(response.Content, typeof(List<GeneralLookupRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all job types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;JobTypeRestObject&gt;</returns>
        public List<JobTypeRestObject> JobTypes(List<string> fields)
        {
            var path = "/api/v1/jobTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling JobTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling JobTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<JobTypeRestObject>)ApiClient.Deserialize(response.Content, typeof(List<JobTypeRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all support languages
        /// </summary>
        /// <returns>List&lt;Language&gt;</returns>
        public List<Language> Languages()
        {
            var path = "/api/v1/languages";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Languages: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Languages: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Language>)ApiClient.Deserialize(response.Content, typeof(List<Language>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all possible player league leader types
        /// </summary>
        /// <returns>List&lt;LeagueLeaderTypeRestObject&gt;</returns>
        public List<LeagueLeaderTypeRestObject> LeagueLeaderTypes()
        {
            var path = "/api/v1/leagueLeaderTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling LeagueLeaderTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling LeagueLeaderTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<LeagueLeaderTypeRestObject>)ApiClient.Deserialize(response.Content, typeof(List<LeagueLeaderTypeRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all logical event types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        public List<GeneralLookupRestObject> LogicalEvents(List<string> fields)
        {
            var path = "/api/v1/logicalEvents";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling LogicalEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling LogicalEvents: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GeneralLookupRestObject>)ApiClient.Deserialize(response.Content, typeof(List<GeneralLookupRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View media state options
        /// </summary>
        /// <returns>List&lt;MediaStateRestObject&gt;</returns>
        public List<MediaStateRestObject> MediaStateTypes()
        {
            var path = "/api/v1/mediaState";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling MediaStateTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling MediaStateTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MediaStateRestObject>)ApiClient.Deserialize(response.Content, typeof(List<MediaStateRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all possible metrics
        /// </summary>
        /// <returns>List&lt;RestObject&gt;</returns>
        public List<RestObject> Metrics()
        {
            var path = "/api/v1/metrics";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Metrics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Metrics: " + response.ErrorMessage, response.ErrorMessage);

            return (List<RestObject>)ApiClient.Deserialize(response.Content, typeof(List<RestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all mound visit types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        public List<GeneralLookupRestObject> MoundVisitTypes(List<string> fields)
        {
            var path = "/api/v1/moundVisitTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling MoundVisitTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling MoundVisitTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GeneralLookupRestObject>)ApiClient.Deserialize(response.Content, typeof(List<GeneralLookupRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all possible performer types
        /// </summary>
        /// <returns>List&lt;PerformerType&gt;</returns>
        public List<PerformerType> PerformerTypes()
        {
            var path = "/api/v1/performerTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PerformerTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PerformerTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PerformerType>)ApiClient.Deserialize(response.Content, typeof(List<PerformerType>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all pitch codes
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;PitchCodeRestObject&gt;</returns>
        public List<PitchCodeRestObject> PitchCodes(List<string> fields)
        {
            var path = "/api/v1/pitchCodes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PitchCodes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PitchCodes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PitchCodeRestObject>)ApiClient.Deserialize(response.Content, typeof(List<PitchCodeRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all pitch classification types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        public List<GeneralLookupRestObject> PitchTypes(List<string> fields)
        {
            var path = "/api/v1/pitchTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PitchTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PitchTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GeneralLookupRestObject>)ApiClient.Deserialize(response.Content, typeof(List<GeneralLookupRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all possible platforms
        /// </summary>
        /// <returns>List&lt;Platform&gt;</returns>
        public List<Platform> Platforms()
        {
            var path = "/api/v1/platforms";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Platforms: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Platforms: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Platform>)ApiClient.Deserialize(response.Content, typeof(List<Platform>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all player status codes
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        public List<GeneralLookupRestObject> PlayerStatusCodes(List<string> fields)
        {
            var path = "/api/v1/playerStatusCodes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PlayerStatusCodes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PlayerStatusCodes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GeneralLookupRestObject>)ApiClient.Deserialize(response.Content, typeof(List<GeneralLookupRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all possible positions
        /// </summary>
        /// <returns>List&lt;BaseballPosition&gt;</returns>
        public List<BaseballPosition> Positions()
        {
            var path = "/api/v1/positions";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Positions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Positions: " + response.ErrorMessage, response.ErrorMessage);

            return (List<BaseballPosition>)ApiClient.Deserialize(response.Content, typeof(List<BaseballPosition>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all replay review reasons
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        public List<GeneralLookupRestObject> ReviewReasons(List<string> fields)
        {
            var path = "/api/v1/reviewReasons";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ReviewReasons: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ReviewReasons: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GeneralLookupRestObject>)ApiClient.Deserialize(response.Content, typeof(List<GeneralLookupRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all roof types
        /// </summary>
        /// <returns>List&lt;RoofTypeRestObject&gt;</returns>
        public List<RoofTypeRestObject> RoofTypes()
        {
            var path = "/api/v1/roofTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling RoofTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling RoofTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<RoofTypeRestObject>)ApiClient.Deserialize(response.Content, typeof(List<RoofTypeRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all possible roster types
        /// </summary>
        /// <returns>List&lt;RosterType&gt;</returns>
        public List<RosterType> RosterTypes()
        {
            var path = "/api/v1/rosterTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling RosterTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling RosterTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<RosterType>)ApiClient.Deserialize(response.Content, typeof(List<RosterType>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all ruleSettings
        /// </summary>
        /// <returns>List&lt;RuleSettingsRestObject&gt;</returns>
        public List<RuleSettingsRestObject> RuleSettings()
        {
            var path = "/api/v1/ruleSettings";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling RuleSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling RuleSettings: " + response.ErrorMessage, response.ErrorMessage);

            return (List<RuleSettingsRestObject>)ApiClient.Deserialize(response.Content, typeof(List<RuleSettingsRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List runner detail types
        /// </summary>
        /// <returns>List&lt;RunnerDetailType&gt;</returns>
        public List<RunnerDetailType> RunnerDetailTypes()
        {
            var path = "/api/v1/runnerDetailTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling RunnerDetailTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling RunnerDetailTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<RunnerDetailType>)ApiClient.Deserialize(response.Content, typeof(List<RunnerDetailType>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all schedule event types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;ScheduleEventTypeRestObject&gt;</returns>
        public List<ScheduleEventTypeRestObject> ScheduleEventTypes(List<string> fields)
        {
            var path = "/api/v1/scheduleEventTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ScheduleEventTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ScheduleEventTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ScheduleEventTypeRestObject>)ApiClient.Deserialize(response.Content, typeof(List<ScheduleEventTypeRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all possible schedule types
        /// </summary>
        /// <returns>List&lt;ScheduleTypeEnum&gt;</returns>
        public List<ScheduleTypeEnum> ScheduleTypes()
        {
            var path = "/api/v1/scheduleTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ScheduleTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ScheduleTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ScheduleTypeEnum>)ApiClient.Deserialize(response.Content, typeof(List<ScheduleTypeEnum>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all situation codes
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="season">Season of play</param>
        /// <param name="statGroup">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <returns>List&lt;SituationCodeRestObject&gt;</returns>
        public List<SituationCodeRestObject> SitCodes(List<string> fields, string season, StatGroup statGroup)
        {
            var path = "/api/v1/situationCodes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (statGroup != null) queryParams.Add("statGroup", ApiClient.ParameterToString(statGroup)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling SitCodes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling SitCodes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SituationCodeRestObject>)ApiClient.Deserialize(response.Content, typeof(List<SituationCodeRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all sky options
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        public List<GeneralLookupRestObject> Sky(List<string> fields)
        {
            var path = "/api/v1/sky";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Sky: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Sky: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GeneralLookupRestObject>)ApiClient.Deserialize(response.Content, typeof(List<GeneralLookupRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all standings types
        /// </summary>
        /// <returns>List&lt;StandingsType&gt;</returns>
        public List<StandingsType> StandingsTypes()
        {
            var path = "/api/v1/standingsTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling StandingsTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling StandingsTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<StandingsType>)ApiClient.Deserialize(response.Content, typeof(List<StandingsType>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all stat fields
        /// </summary>
        /// <returns>List&lt;StatField&gt;</returns>
        public List<StatField> StatFields()
        {
            var path = "/api/v1/statFields";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling StatFields: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling StatFields: " + response.ErrorMessage, response.ErrorMessage);

            return (List<StatField>)ApiClient.Deserialize(response.Content, typeof(List<StatField>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all stat groups
        /// </summary>
        /// <returns>List&lt;StatGroup&gt;</returns>
        public List<StatGroup> StatGroups()
        {
            var path = "/api/v1/statGroups";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling StatGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling StatGroups: " + response.ErrorMessage, response.ErrorMessage);

            return (List<StatGroup>)ApiClient.Deserialize(response.Content, typeof(List<StatGroup>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Stats Search Config Endpoint
        /// </summary>
        /// <param name="filterLevel">Categories of filters for stat search</param>
        /// <param name="group">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <returns>StatSearchConfigRestObject</returns>
        public StatSearchConfigRestObject StatSearchConfig(FilterLevelEnum filterLevel, StatGroup group)
        {
            var path = "/api/v1/stats/search/config";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (filterLevel != null) queryParams.Add("filterLevel", ApiClient.ParameterToString(filterLevel)); // query parameter
            if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling StatSearchConfig: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling StatSearchConfig: " + response.ErrorMessage, response.ErrorMessage);

            return (StatSearchConfigRestObject)ApiClient.Deserialize(response.Content, typeof(StatSearchConfigRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List groupBy types
        /// </summary>
        /// <param name="filterLevel">Categories of filters for stat search</param>
        /// <returns>List&lt;GroupByEnum&gt;</returns>
        public List<GroupByEnum> StatSearchGroupByTypes(FilterLevelEnum filterLevel)
        {
            var path = "/api/v1/stats/search/groupByTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (filterLevel != null) queryParams.Add("filterLevel", ApiClient.ParameterToString(filterLevel)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling StatSearchGroupByTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling StatSearchGroupByTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GroupByEnum>)ApiClient.Deserialize(response.Content, typeof(List<GroupByEnum>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List stat search parameters
        /// </summary>
        /// <param name="filterLevel">Categories of filters for stat search</param>
        /// <returns>List&lt;StatSearchParamRestObject&gt;</returns>
        public List<StatSearchParamRestObject> StatSearchParams(FilterLevelEnum filterLevel)
        {
            var path = "/api/v1/stats/search/params";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (filterLevel != null) queryParams.Add("filterLevel", ApiClient.ParameterToString(filterLevel)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling StatSearchParams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling StatSearchParams: " + response.ErrorMessage, response.ErrorMessage);

            return (List<StatSearchParamRestObject>)ApiClient.Deserialize(response.Content, typeof(List<StatSearchParamRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List stat search stats
        /// </summary>
        /// <param name="filterLevel">Categories of filters for stat search</param>
        /// <returns>List&lt;StatSearchStatRestObject&gt;</returns>
        public List<StatSearchStatRestObject> StatSearchStats(FilterLevelEnum filterLevel)
        {
            var path = "/api/v1/stats/search/stats";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (filterLevel != null) queryParams.Add("filterLevel", ApiClient.ParameterToString(filterLevel)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling StatSearchStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling StatSearchStats: " + response.ErrorMessage, response.ErrorMessage);

            return (List<StatSearchStatRestObject>)ApiClient.Deserialize(response.Content, typeof(List<StatSearchStatRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all stat types
        /// </summary>
        /// <returns>List&lt;StatType&gt;</returns>
        public List<StatType> StatTypes()
        {
            var path = "/api/v1/statTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling StatTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling StatTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<StatType>)ApiClient.Deserialize(response.Content, typeof(List<StatType>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all statcast position types
        /// </summary>
        /// <returns>List&lt;StatcastPositionRestObject&gt;</returns>
        public List<StatcastPositionRestObject> StatcastPositionTypes()
        {
            var path = "/api/v1/statcastPositionTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling StatcastPositionTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling StatcastPositionTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<StatcastPositionRestObject>)ApiClient.Deserialize(response.Content, typeof(List<StatcastPositionRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List the tracking software versions and notes
        /// </summary>
        /// <returns>List&lt;TrackingSoftwareVersionRestObject&gt;</returns>
        public List<TrackingSoftwareVersionRestObject> TrackingSoftwareVersions()
        {
            var path = "/api/v1/trackingSoftwareVersions";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling TrackingSoftwareVersions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling TrackingSoftwareVersions: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TrackingSoftwareVersionRestObject>)ApiClient.Deserialize(response.Content, typeof(List<TrackingSoftwareVersionRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all tracking system owners
        /// </summary>
        /// <returns>List&lt;TrackingSystemOwner&gt;</returns>
        public List<TrackingSystemOwner> TrackingSystemOwners()
        {
            var path = "/api/v1/trackingSystemOwners";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling TrackingSystemOwners: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling TrackingSystemOwners: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TrackingSystemOwner>)ApiClient.Deserialize(response.Content, typeof(List<TrackingSystemOwner>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all tracking vendors
        /// </summary>
        /// <returns>List&lt;TrackingVendor&gt;</returns>
        public List<TrackingVendor> TrackingVendors()
        {
            var path = "/api/v1/trackingVendors";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling TrackingVendors: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling TrackingVendors: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TrackingVendor>)ApiClient.Deserialize(response.Content, typeof(List<TrackingVendor>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all tracking versions
        /// </summary>
        /// <returns>List&lt;TrackingVersion&gt;</returns>
        public List<TrackingVersion> TrackingVersions()
        {
            var path = "/api/v1/trackingVersions";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling TrackingVersions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling TrackingVersions: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TrackingVersion>)ApiClient.Deserialize(response.Content, typeof(List<TrackingVersion>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all transaction types
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        public List<GeneralLookupRestObject> TransactionTypes(List<string> fields)
        {
            var path = "/api/v1/transactionTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling TransactionTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling TransactionTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GeneralLookupRestObject>)ApiClient.Deserialize(response.Content, typeof(List<GeneralLookupRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Clear all status types
        /// </summary>
        /// <returns>string</returns>
        public string UpdateGameStatuses()
        {
            var path = "/api/v1/gameStatus";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateGameStatuses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateGameStatuses: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>string</returns>
        public string UpdateJobTypes()
        {
            var path = "/api/v1/jobTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateJobTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateJobTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View video resolution options
        /// </summary>
        /// <returns>List&lt;VideoResolutionEnumRestObject&gt;</returns>
        public List<VideoResolutionEnumRestObject> VideoResolutionTypes()
        {
            var path = "/api/v1/videoResolutionTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling VideoResolutionTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling VideoResolutionTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<VideoResolutionEnumRestObject>)ApiClient.Deserialize(response.Content, typeof(List<VideoResolutionEnumRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View available violationType options
        /// </summary>
        /// <returns>List&lt;ViolationTypeRestObject&gt;</returns>
        public List<ViolationTypeRestObject> ViolationTypes()
        {
            var path = "/api/v1/violationTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ViolationTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ViolationTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ViolationTypeRestObject>)ApiClient.Deserialize(response.Content, typeof(List<ViolationTypeRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all weather trajectories
        /// </summary>
        /// <returns>List&lt;WeatherTrajectoryConfidenceTypeRestObject&gt;</returns>
        public List<WeatherTrajectoryConfidenceTypeRestObject> WeatherTrajectoryConfidences()
        {
            var path = "/api/v1/weatherTrajectoryConfidences";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling WeatherTrajectoryConfidences: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling WeatherTrajectoryConfidences: " + response.ErrorMessage, response.ErrorMessage);

            return (List<WeatherTrajectoryConfidenceTypeRestObject>)ApiClient.Deserialize(response.Content, typeof(List<WeatherTrajectoryConfidenceTypeRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// List all wind direction options
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;GeneralLookupRestObject&gt;</returns>
        public List<GeneralLookupRestObject> WindDirection(List<string> fields)
        {
            var path = "/api/v1/windDirection";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling WindDirection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling WindDirection: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GeneralLookupRestObject>)ApiClient.Deserialize(response.Content, typeof(List<GeneralLookupRestObject>), (IList<Parameter>)response.Headers);
        }
    }
}