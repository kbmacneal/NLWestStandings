using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAnalyticsApi
    {
        /// <summary>
        /// Get context metrics for a specific gamePk. Returns a json file containing raw coordinate data and refined calculated metrics.&lt;br/&gt;&lt;br/&gt;This responses can be very large, so it is strongly recommended that you pass \&quot;Accept-Encoding: gzip\&quot; as a header to have the responses compressed.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="guid">Unique identifier for a play within a game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;CalculatedMetricRestObject&gt;</returns>
        List<CalculatedMetricRestObject> ContextMetrics(int? gamePk, string guid, List<string> fields);

        /// <summary>
        /// Get a json file containing raw coordinate data and refined calculated metrics. Returns a json file containing raw coordinate data and refined calculated metrics.&lt;br/&gt;&lt;br/&gt;This responses can be very large, so it is strongly recommended that you pass \&quot;Accept-Encoding: gzip\&quot; as a header to have the responses compressed.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="guid">Unique identifier for a play within a game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;CalculatedMetricRestObject&gt;</returns>
        List<CalculatedMetricRestObject> ContextMetricsWithAverages(int? gamePk, string guid, List<string> fields);

        /// <summary>
        /// Get a json file containing raw coordinate data and refined calculated metrics. Returns a json file containing raw coordinate data and refined calculated metrics.&lt;br/&gt;&lt;br/&gt;This responses can be very large, so it is strongly recommended that you pass \&quot;Accept-Encoding: gzip\&quot; as a header to have the responses compressed.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="guid">Unique identifier for a play within a game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;CalculatedMetricRestObject&gt;</returns>
        List<CalculatedMetricRestObject> ContextMetricsWithAveragesPost(int? gamePk, string guid, List<string> fields);

        /// <summary>
        /// Get the GUIDs (plays) for a specific game.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="gameModeId">Statcast game mode. Format: 0 &#x3D; Batting Practive, 1 &#x3D; Warmup 2 &#x3D; Live</param>
        /// <param name="isPitch">If there was a pitch</param>
        /// <param name="isHit">If there was a hit ball tracked</param>
        /// <param name="isPickoff">If there was a pickoff</param>
        /// <param name="hasUpdates">True if updated by an auditor</param>
        /// <param name="since">Returns all data that was created after the specified timestamp. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="updatedSince">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastPlayTime">Returns all data that was created after the specified timestamp. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastMetricsUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastAuditUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastVideoUpdatedTime">The last time SportyBot video was updated</param>
        /// <returns>List&lt;AnalyticsPlayMetadataRestObject&gt;</returns>
        List<AnalyticsPlayMetadataRestObject> GameGuids(int? gamePk, List<string> fields, int? gameModeId, bool? isPitch, bool? isHit, bool? isPickoff, bool? hasUpdates, DateTime? since, DateTime? updatedSince, DateTime? lastPlayTime, DateTime? lastUpdatedTime, DateTime? lastMetricsUpdatedTime, DateTime? lastAuditUpdatedTime, DateTime? lastVideoUpdatedTime);

        /// <summary>
        /// Get the GUIDs (plays) for a specific game.
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="gameModeId">Statcast game mode. Format: 0 &#x3D; Batting Practive, 1 &#x3D; Warmup 2 &#x3D; Live</param>
        /// <param name="isPitch">If there was a pitch</param>
        /// <param name="isHit">If there was a hit ball tracked</param>
        /// <param name="isPickoff">If there was a pickoff</param>
        /// <param name="isNonStatcast">If non statcast games need to be included</param>
        /// <param name="gamedayType">Indicates the level of Gameday (tracking, play-by-play, linescore, etc...)</param>
        /// <param name="hasUpdates">True if updated by an auditor</param>
        /// <param name="lastPlayTime">Returns all data that was created after the specified timestamp. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastMetricsUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastAuditUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastVideoUpdatedTime">The last time SportyBot video was updated</param>
        /// <param name="gameDate">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="trackingSystemOwner">Owner of the tracking system</param>
        /// <param name="season">Season of play</param>
        /// <param name="sortBy">Sort the set of data by the specified field</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <returns>AnalyticsPlayMetadataWrapperRestObject</returns>
        AnalyticsPlayMetadataWrapperRestObject GameGuidsFromPostgresRange(List<string> fields, int? gameModeId, bool? isPitch, bool? isHit, bool? isPickoff, bool? isNonStatcast, string gamedayType, bool? hasUpdates, DateTime? lastPlayTime, DateTime? lastUpdatedTime, DateTime? lastMetricsUpdatedTime, DateTime? lastAuditUpdatedTime, DateTime? lastVideoUpdatedTime, DateTime? gameDate, int? sportId, GameTypeEnum gameType, TrackingSystemOwner trackingSystemOwner, string season, string sortBy, int? limit, int? offset);

        /// <summary>
        /// Get all games by updated date.
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="gameModeId">Statcast game mode. Format: 0 &#x3D; Batting Practive, 1 &#x3D; Warmup 2 &#x3D; Live</param>
        /// <param name="isPitch">If there was a pitch</param>
        /// <param name="isHit">If there was a hit ball tracked</param>
        /// <param name="isPickoff">If there was a pickoff</param>
        /// <param name="isNonStatcast">If non statcast games need to be included</param>
        /// <param name="gamedayType">Indicates the level of Gameday (tracking, play-by-play, linescore, etc...)</param>
        /// <param name="hasUpdates">True if updated by an auditor</param>
        /// <param name="lastPlayTime">Returns all data that was created after the specified timestamp. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastVideoUpdatedTime">The last time SportyBot video was updated</param>
        /// <param name="lastUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastMetricsUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastAuditUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="gameDate">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="trackingSystemOwner">Owner of the tracking system</param>
        /// <param name="sortBy">Sort the set of data by the specified field</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="scheduleEventTypes">Comma delimited list of type of event types</param>
        /// <returns>AnalyticsGameMetadataWrapperRestObject</returns>
        AnalyticsGameMetadataWrapperRestObject GameGuidsFromPostgresRangeByGame(List<string> fields, int? gameModeId, bool? isPitch, bool? isHit, bool? isPickoff, bool? isNonStatcast, string gamedayType, bool? hasUpdates, DateTime? lastPlayTime, DateTime? lastVideoUpdatedTime, DateTime? lastUpdatedTime, DateTime? lastMetricsUpdatedTime, DateTime? lastAuditUpdatedTime, DateTime? gameDate, int? sportId, GameTypeEnum gameType, string season, TrackingSystemOwner trackingSystemOwner, string sortBy, int? limit, int? offset, List<ScheduleEventTypes> scheduleEventTypes);

        /// <summary>
        /// Get the last pitch for a list of games
        /// </summary>
        /// <param name="gamePks">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;AnalyticsPlayMetadataRestObject&gt;</returns>
        List<AnalyticsPlayMetadataRestObject> GameLastPitch(List<int?> gamePks, List<string> fields);

        /// <summary>
        /// Get if the play is a home run is each park for a specific play. Returns a json file containing raw coordinate data and refined calculated metrics.&lt;br/&gt;&lt;br/&gt;This responses can be very large, so it is strongly recommended that you pass \&quot;Accept-Encoding: gzip\&quot; as a header to have the responses compressed.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="guid">Unique identifier for a play within a game</param>
        /// <param name="isHomeRunParks"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>VenuesRestObject</returns>
        VenuesRestObject HomeRunBallparks(int? gamePk, string guid, bool? isHomeRunParks, List<string> fields);

        /// <summary>
        /// Get Statcast data for a specific play. Returns a json file containing raw coordinate data and refined calculated metrics.&lt;br/&gt;&lt;br/&gt;This responses can be very large, so it is strongly recommended that you pass \&quot;Accept-Encoding: gzip\&quot; as a header to have the responses compressed.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="guid">Unique identifier for a play within a game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>AnalyticsRestObject</returns>
        AnalyticsRestObject ParsedJsonFormattedAnalytics(int? gamePk, string guid, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AnalyticsApi : IAnalyticsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AnalyticsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AnalyticsApi(String basePath)
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
        /// Get context metrics for a specific gamePk. Returns a json file containing raw coordinate data and refined calculated metrics.&lt;br/&gt;&lt;br/&gt;This responses can be very large, so it is strongly recommended that you pass \&quot;Accept-Encoding: gzip\&quot; as a header to have the responses compressed.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="guid">Unique identifier for a play within a game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;CalculatedMetricRestObject&gt;</returns>
        public List<CalculatedMetricRestObject> ContextMetrics(int? gamePk, string guid, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling ContextMetrics");
            // verify the required parameter 'guid' is set
            if (guid == null) throw new ApiException(400, "Missing required parameter 'guid' when calling ContextMetrics");

            var path = "/api/v1/game/{gamePk}/{guid}/contextMetrics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));
            path = path.Replace("{" + "guid" + "}", ApiClient.ParameterToString(guid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ContextMetrics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ContextMetrics: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CalculatedMetricRestObject>)ApiClient.Deserialize(response.Content, typeof(List<CalculatedMetricRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get a json file containing raw coordinate data and refined calculated metrics. Returns a json file containing raw coordinate data and refined calculated metrics.&lt;br/&gt;&lt;br/&gt;This responses can be very large, so it is strongly recommended that you pass \&quot;Accept-Encoding: gzip\&quot; as a header to have the responses compressed.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="guid">Unique identifier for a play within a game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;CalculatedMetricRestObject&gt;</returns>
        public List<CalculatedMetricRestObject> ContextMetricsWithAverages(int? gamePk, string guid, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling ContextMetricsWithAverages");
            // verify the required parameter 'guid' is set
            if (guid == null) throw new ApiException(400, "Missing required parameter 'guid' when calling ContextMetricsWithAverages");

            var path = "/api/v1/game/{gamePk}/{guid}/contextMetricsAverages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));
            path = path.Replace("{" + "guid" + "}", ApiClient.ParameterToString(guid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ContextMetricsWithAverages: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ContextMetricsWithAverages: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CalculatedMetricRestObject>)ApiClient.Deserialize(response.Content, typeof(List<CalculatedMetricRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get a json file containing raw coordinate data and refined calculated metrics. Returns a json file containing raw coordinate data and refined calculated metrics.&lt;br/&gt;&lt;br/&gt;This responses can be very large, so it is strongly recommended that you pass \&quot;Accept-Encoding: gzip\&quot; as a header to have the responses compressed.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="guid">Unique identifier for a play within a game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;CalculatedMetricRestObject&gt;</returns>
        public List<CalculatedMetricRestObject> ContextMetricsWithAveragesPost(int? gamePk, string guid, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling ContextMetricsWithAveragesPost");
            // verify the required parameter 'guid' is set
            if (guid == null) throw new ApiException(400, "Missing required parameter 'guid' when calling ContextMetricsWithAveragesPost");

            var path = "/api/v1/game/{gamePk}/{guid}/contextMetricsAverages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));
            path = path.Replace("{" + "guid" + "}", ApiClient.ParameterToString(guid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ContextMetricsWithAveragesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ContextMetricsWithAveragesPost: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CalculatedMetricRestObject>)ApiClient.Deserialize(response.Content, typeof(List<CalculatedMetricRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get the GUIDs (plays) for a specific game.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="gameModeId">Statcast game mode. Format: 0 &#x3D; Batting Practive, 1 &#x3D; Warmup 2 &#x3D; Live</param>
        /// <param name="isPitch">If there was a pitch</param>
        /// <param name="isHit">If there was a hit ball tracked</param>
        /// <param name="isPickoff">If there was a pickoff</param>
        /// <param name="hasUpdates">True if updated by an auditor</param>
        /// <param name="since">Returns all data that was created after the specified timestamp. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="updatedSince">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastPlayTime">Returns all data that was created after the specified timestamp. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastMetricsUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastAuditUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastVideoUpdatedTime">The last time SportyBot video was updated</param>
        /// <returns>List&lt;AnalyticsPlayMetadataRestObject&gt;</returns>
        public List<AnalyticsPlayMetadataRestObject> GameGuids(int? gamePk, List<string> fields, int? gameModeId, bool? isPitch, bool? isHit, bool? isPickoff, bool? hasUpdates, DateTime? since, DateTime? updatedSince, DateTime? lastPlayTime, DateTime? lastUpdatedTime, DateTime? lastMetricsUpdatedTime, DateTime? lastAuditUpdatedTime, DateTime? lastVideoUpdatedTime)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling GameGuids");

            var path = "/api/v1/game/{gamePk}/guids";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (gameModeId != null) queryParams.Add("gameModeId", ApiClient.ParameterToString(gameModeId)); // query parameter
            if (isPitch != null) queryParams.Add("isPitch", ApiClient.ParameterToString(isPitch)); // query parameter
            if (isHit != null) queryParams.Add("isHit", ApiClient.ParameterToString(isHit)); // query parameter
            if (isPickoff != null) queryParams.Add("isPickoff", ApiClient.ParameterToString(isPickoff)); // query parameter
            if (hasUpdates != null) queryParams.Add("hasUpdates", ApiClient.ParameterToString(hasUpdates)); // query parameter
            if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
            if (updatedSince != null) queryParams.Add("updatedSince", ApiClient.ParameterToString(updatedSince)); // query parameter
            if (lastPlayTime != null) queryParams.Add("lastPlayTime", ApiClient.ParameterToString(lastPlayTime)); // query parameter
            if (lastUpdatedTime != null) queryParams.Add("lastUpdatedTime", ApiClient.ParameterToString(lastUpdatedTime)); // query parameter
            if (lastMetricsUpdatedTime != null) queryParams.Add("lastMetricsUpdatedTime", ApiClient.ParameterToString(lastMetricsUpdatedTime)); // query parameter
            if (lastAuditUpdatedTime != null) queryParams.Add("lastAuditUpdatedTime", ApiClient.ParameterToString(lastAuditUpdatedTime)); // query parameter
            if (lastVideoUpdatedTime != null) queryParams.Add("lastVideoUpdatedTime", ApiClient.ParameterToString(lastVideoUpdatedTime)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GameGuids: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GameGuids: " + response.ErrorMessage, response.ErrorMessage);

            return (List<AnalyticsPlayMetadataRestObject>)ApiClient.Deserialize(response.Content, typeof(List<AnalyticsPlayMetadataRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get the GUIDs (plays) for a specific game.
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="gameModeId">Statcast game mode. Format: 0 &#x3D; Batting Practive, 1 &#x3D; Warmup 2 &#x3D; Live</param>
        /// <param name="isPitch">If there was a pitch</param>
        /// <param name="isHit">If there was a hit ball tracked</param>
        /// <param name="isPickoff">If there was a pickoff</param>
        /// <param name="isNonStatcast">If non statcast games need to be included</param>
        /// <param name="gamedayType">Indicates the level of Gameday (tracking, play-by-play, linescore, etc...)</param>
        /// <param name="hasUpdates">True if updated by an auditor</param>
        /// <param name="lastPlayTime">Returns all data that was created after the specified timestamp. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastMetricsUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastAuditUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastVideoUpdatedTime">The last time SportyBot video was updated</param>
        /// <param name="gameDate">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="trackingSystemOwner">Owner of the tracking system</param>
        /// <param name="season">Season of play</param>
        /// <param name="sortBy">Sort the set of data by the specified field</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <returns>AnalyticsPlayMetadataWrapperRestObject</returns>
        public AnalyticsPlayMetadataWrapperRestObject GameGuidsFromPostgresRange(List<string> fields, int? gameModeId, bool? isPitch, bool? isHit, bool? isPickoff, bool? isNonStatcast, string gamedayType, bool? hasUpdates, DateTime? lastPlayTime, DateTime? lastUpdatedTime, DateTime? lastMetricsUpdatedTime, DateTime? lastAuditUpdatedTime, DateTime? lastVideoUpdatedTime, DateTime? gameDate, int? sportId, GameTypeEnum gameType, TrackingSystemOwner trackingSystemOwner, string season, string sortBy, int? limit, int? offset)
        {
            var path = "/api/v1/analytics/guids";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (gameModeId != null) queryParams.Add("gameModeId", ApiClient.ParameterToString(gameModeId)); // query parameter
            if (isPitch != null) queryParams.Add("isPitch", ApiClient.ParameterToString(isPitch)); // query parameter
            if (isHit != null) queryParams.Add("isHit", ApiClient.ParameterToString(isHit)); // query parameter
            if (isPickoff != null) queryParams.Add("isPickoff", ApiClient.ParameterToString(isPickoff)); // query parameter
            if (isNonStatcast != null) queryParams.Add("isNonStatcast", ApiClient.ParameterToString(isNonStatcast)); // query parameter
            if (gamedayType != null) queryParams.Add("gamedayType", ApiClient.ParameterToString(gamedayType)); // query parameter
            if (hasUpdates != null) queryParams.Add("hasUpdates", ApiClient.ParameterToString(hasUpdates)); // query parameter
            if (lastPlayTime != null) queryParams.Add("lastPlayTime", ApiClient.ParameterToString(lastPlayTime)); // query parameter
            if (lastUpdatedTime != null) queryParams.Add("lastUpdatedTime", ApiClient.ParameterToString(lastUpdatedTime)); // query parameter
            if (lastMetricsUpdatedTime != null) queryParams.Add("lastMetricsUpdatedTime", ApiClient.ParameterToString(lastMetricsUpdatedTime)); // query parameter
            if (lastAuditUpdatedTime != null) queryParams.Add("lastAuditUpdatedTime", ApiClient.ParameterToString(lastAuditUpdatedTime)); // query parameter
            if (lastVideoUpdatedTime != null) queryParams.Add("lastVideoUpdatedTime", ApiClient.ParameterToString(lastVideoUpdatedTime)); // query parameter
            if (gameDate != null) queryParams.Add("gameDate", ApiClient.ParameterToString(gameDate)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (trackingSystemOwner != null) queryParams.Add("trackingSystemOwner", ApiClient.ParameterToString(trackingSystemOwner)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", ApiClient.ParameterToString(sortBy)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GameGuidsFromPostgresRange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GameGuidsFromPostgresRange: " + response.ErrorMessage, response.ErrorMessage);

            return (AnalyticsPlayMetadataWrapperRestObject)ApiClient.Deserialize(response.Content, typeof(AnalyticsPlayMetadataWrapperRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get all games by updated date.
        /// </summary>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="gameModeId">Statcast game mode. Format: 0 &#x3D; Batting Practive, 1 &#x3D; Warmup 2 &#x3D; Live</param>
        /// <param name="isPitch">If there was a pitch</param>
        /// <param name="isHit">If there was a hit ball tracked</param>
        /// <param name="isPickoff">If there was a pickoff</param>
        /// <param name="isNonStatcast">If non statcast games need to be included</param>
        /// <param name="gamedayType">Indicates the level of Gameday (tracking, play-by-play, linescore, etc...)</param>
        /// <param name="hasUpdates">True if updated by an auditor</param>
        /// <param name="lastPlayTime">Returns all data that was created after the specified timestamp. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastVideoUpdatedTime">The last time SportyBot video was updated</param>
        /// <param name="lastUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastMetricsUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="lastAuditUpdatedTime">Return data updated since a specified date. Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="gameDate">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="trackingSystemOwner">Owner of the tracking system</param>
        /// <param name="sortBy">Sort the set of data by the specified field</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="scheduleEventTypes">Comma delimited list of type of event types</param>
        /// <returns>AnalyticsGameMetadataWrapperRestObject</returns>
        public AnalyticsGameMetadataWrapperRestObject GameGuidsFromPostgresRangeByGame(List<string> fields, int? gameModeId, bool? isPitch, bool? isHit, bool? isPickoff, bool? isNonStatcast, string gamedayType, bool? hasUpdates, DateTime? lastPlayTime, DateTime? lastVideoUpdatedTime, DateTime? lastUpdatedTime, DateTime? lastMetricsUpdatedTime, DateTime? lastAuditUpdatedTime, DateTime? gameDate, int? sportId, GameTypeEnum gameType, string season, TrackingSystemOwner trackingSystemOwner, string sortBy, int? limit, int? offset, List<ScheduleEventTypes> scheduleEventTypes)
        {
            var path = "/api/v1/analytics/game";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (gameModeId != null) queryParams.Add("gameModeId", ApiClient.ParameterToString(gameModeId)); // query parameter
            if (isPitch != null) queryParams.Add("isPitch", ApiClient.ParameterToString(isPitch)); // query parameter
            if (isHit != null) queryParams.Add("isHit", ApiClient.ParameterToString(isHit)); // query parameter
            if (isPickoff != null) queryParams.Add("isPickoff", ApiClient.ParameterToString(isPickoff)); // query parameter
            if (isNonStatcast != null) queryParams.Add("isNonStatcast", ApiClient.ParameterToString(isNonStatcast)); // query parameter
            if (gamedayType != null) queryParams.Add("gamedayType", ApiClient.ParameterToString(gamedayType)); // query parameter
            if (hasUpdates != null) queryParams.Add("hasUpdates", ApiClient.ParameterToString(hasUpdates)); // query parameter
            if (lastPlayTime != null) queryParams.Add("lastPlayTime", ApiClient.ParameterToString(lastPlayTime)); // query parameter
            if (lastVideoUpdatedTime != null) queryParams.Add("lastVideoUpdatedTime", ApiClient.ParameterToString(lastVideoUpdatedTime)); // query parameter
            if (lastUpdatedTime != null) queryParams.Add("lastUpdatedTime", ApiClient.ParameterToString(lastUpdatedTime)); // query parameter
            if (lastMetricsUpdatedTime != null) queryParams.Add("lastMetricsUpdatedTime", ApiClient.ParameterToString(lastMetricsUpdatedTime)); // query parameter
            if (lastAuditUpdatedTime != null) queryParams.Add("lastAuditUpdatedTime", ApiClient.ParameterToString(lastAuditUpdatedTime)); // query parameter
            if (gameDate != null) queryParams.Add("gameDate", ApiClient.ParameterToString(gameDate)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (trackingSystemOwner != null) queryParams.Add("trackingSystemOwner", ApiClient.ParameterToString(trackingSystemOwner)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", ApiClient.ParameterToString(sortBy)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (scheduleEventTypes != null) queryParams.Add("scheduleEventTypes", ApiClient.ParameterToString(scheduleEventTypes)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GameGuidsFromPostgresRangeByGame: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GameGuidsFromPostgresRangeByGame: " + response.ErrorMessage, response.ErrorMessage);

            return (AnalyticsGameMetadataWrapperRestObject)ApiClient.Deserialize(response.Content, typeof(AnalyticsGameMetadataWrapperRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get the last pitch for a list of games
        /// </summary>
        /// <param name="gamePks">Unique Primary Key Representing a Game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>List&lt;AnalyticsPlayMetadataRestObject&gt;</returns>
        public List<AnalyticsPlayMetadataRestObject> GameLastPitch(List<int?> gamePks, List<string> fields)
        {
            // verify the required parameter 'gamePks' is set
            if (gamePks == null) throw new ApiException(400, "Missing required parameter 'gamePks' when calling GameLastPitch");

            var path = "/api/v1/game/lastPitch";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (gamePks != null) queryParams.Add("gamePks", ApiClient.ParameterToString(gamePks)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GameLastPitch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GameLastPitch: " + response.ErrorMessage, response.ErrorMessage);

            return (List<AnalyticsPlayMetadataRestObject>)ApiClient.Deserialize(response.Content, typeof(List<AnalyticsPlayMetadataRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get if the play is a home run is each park for a specific play. Returns a json file containing raw coordinate data and refined calculated metrics.&lt;br/&gt;&lt;br/&gt;This responses can be very large, so it is strongly recommended that you pass \&quot;Accept-Encoding: gzip\&quot; as a header to have the responses compressed.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="guid">Unique identifier for a play within a game</param>
        /// <param name="isHomeRunParks"></param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>VenuesRestObject</returns>
        public VenuesRestObject HomeRunBallparks(int? gamePk, string guid, bool? isHomeRunParks, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling HomeRunBallparks");
            // verify the required parameter 'guid' is set
            if (guid == null) throw new ApiException(400, "Missing required parameter 'guid' when calling HomeRunBallparks");
            // verify the required parameter 'isHomeRunParks' is set
            if (isHomeRunParks == null) throw new ApiException(400, "Missing required parameter 'isHomeRunParks' when calling HomeRunBallparks");

            var path = "/api/v1/game/{gamePk}/{guid}/homeRunBallparks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));
            path = path.Replace("{" + "guid" + "}", ApiClient.ParameterToString(guid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (isHomeRunParks != null) queryParams.Add("isHomeRunParks", ApiClient.ParameterToString(isHomeRunParks)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunBallparks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling HomeRunBallparks: " + response.ErrorMessage, response.ErrorMessage);

            return (VenuesRestObject)ApiClient.Deserialize(response.Content, typeof(VenuesRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get Statcast data for a specific play. Returns a json file containing raw coordinate data and refined calculated metrics.&lt;br/&gt;&lt;br/&gt;This responses can be very large, so it is strongly recommended that you pass \&quot;Accept-Encoding: gzip\&quot; as a header to have the responses compressed.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="guid">Unique identifier for a play within a game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>AnalyticsRestObject</returns>
        public AnalyticsRestObject ParsedJsonFormattedAnalytics(int? gamePk, string guid, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling ParsedJsonFormattedAnalytics");
            // verify the required parameter 'guid' is set
            if (guid == null) throw new ApiException(400, "Missing required parameter 'guid' when calling ParsedJsonFormattedAnalytics");

            var path = "/api/v1/game/{gamePk}/{guid}/analytics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));
            path = path.Replace("{" + "guid" + "}", ApiClient.ParameterToString(guid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ParsedJsonFormattedAnalytics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ParsedJsonFormattedAnalytics: " + response.ErrorMessage, response.ErrorMessage);

            return (AnalyticsRestObject)ApiClient.Deserialize(response.Content, typeof(AnalyticsRestObject), (IList<Parameter>)response.Headers);
        }
    }
}