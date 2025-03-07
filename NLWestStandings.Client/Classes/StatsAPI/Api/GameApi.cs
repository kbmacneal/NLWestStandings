using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGameApi
    {
        /// <summary>
        /// Get game boxscore. This endpoint allows you to pull a boxscore
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="inclusiveTimecode">True to include plays that happen before or at the specified timecode</param>
        /// <param name="numPlayers">Number of top player game scores to show. Default is 3.</param>
        /// <param name="noTies">If set to false, will show all players tied for the last spot in the game scores list.</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <returns>BaseballBoxscoreRestObject</returns>
        BaseballBoxscoreRestObject Boxscore(int? gamePk, string timecode, List<string> fields, bool? inclusiveTimecode, int? numPlayers, bool? noTies, bool? accent);

        /// <summary>
        /// Get game color feed. This API can return very large payloads.  It is STRONGLY recommended that clients ask for diffs and use \&quot;Accept-Encoding: gzip\&quot; header.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        string ColorFeed(int? gamePk, string timecode, List<string> fields);

        /// <summary>
        /// Retrieve all of the color timestamps for a game. This can be used for replaying games.  Endpoint returns all of the timecodes that can be used with diffs for /v1/game/{game_pk}/feed/color
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> ColorTimestamps(int? gamePk);

        /// <summary>
        /// Retrieve all content for a game.
        /// </summary>
        /// <param name="gamePk"></param>
        /// <param name="highlightLimit">Number of results to return</param>
        /// <returns>GameContentRestObject</returns>
        GameContentRestObject Content(int? gamePk, int? highlightLimit);

        /// <summary>
        /// View a game change log
        /// </summary>
        /// <param name="updatedSince">Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        ScheduleRestObject CurrentGameStats1(DateTime? updatedSince, int? sportId, List<int?> sportIds, GameTypeEnum gameType, List<GameTypeEnum> gameTypes, string season, List<int?> gamePks, int? limit, int? offset, List<string> fields);

        /// <summary>
        /// Get the context metrics for this game based on its current state
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>BaseballGameContextRestObject</returns>
        BaseballGameContextRestObject GetGameContextMetrics(int? gamePk, string timecode, List<string> fields);

        /// <summary>
        /// Get game info with metrics
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="inclusiveTimecode">True to include plays that happen before or at the specified timecode</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <returns>BaseballGameRestObject</returns>
        BaseballGameRestObject GetGameWithMetrics(int? gamePk, string timecode, bool? inclusiveTimecode, List<string> fields, bool? accent);

        /// <summary>
        /// Get the win probability for this game
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="inclusiveTimecode">True to include plays that happen before or at the specified timecode</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <returns>List&lt;BaseballPlayRestObject&gt;</returns>
        List<BaseballPlayRestObject> GetWinProbability(int? gamePk, string timecode, List<string> fields, bool? inclusiveTimecode, bool? accent);

        /// <summary>
        /// Get game linescore This endpoint allows you to pull the linescore for a game
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="inclusiveTimecode">True to include plays that happen before or at the specified timecode</param>
        /// <returns>BaseballLinescoreRestObject</returns>
        BaseballLinescoreRestObject Linescore(int? gamePk, string timecode, List<string> fields, bool? inclusiveTimecode);

        /// <summary>
        /// Get live game status diffPatch. This endpoint allows comparison of game files and shows any differences/discrepancies between the two&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Diff/Patch System:&lt;/b&gt; startTimecode and endTimecode can be used for getting diffs.&lt;br/&gt;Expected usage:  &lt;br/&gt; 1) Request full payload by not passing startTimecode or endTimecode.  This will return the most recent game state.&lt;br/&gt; 2) Find the latest timecode in this response.  &lt;br/&gt; 3) Wait X seconds&lt;br/&gt; 4) Use the timecode from 2 as the startTimecode.  This will give you a diff of everything that has happened since startTimecode.  &lt;br/&gt; 5) If no data is returned, wait X seconds and do the same request.  &lt;br/&gt; 6) If data is returned, get a new timeStamp from the response, and use that for the next call as startTimecode.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="startTimecode">Start time code will give you everything since that time. Format: MMDDYYYY_HHMMSS</param>
        /// <param name="endTimecode">End time code will give you a snapshot at that specific time. Format: MMDDYYYY_HHMMSS</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <returns>string</returns>
        string LiveGameDiffPatchV1(int? gamePk, string startTimecode, string endTimecode, bool? accent);

        /// <summary>
        /// Get live game status. This API can return very large payloads.  It is STRONGLY recommended that clients ask for diffs and use \&quot;Accept-Encoding: gzip\&quot; header.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="inclusiveTimecode">True to include plays that happen before or at the specified timecode</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <returns>BaseballGameRestObject</returns>
        BaseballGameRestObject LiveGameV1(int? gamePk, string timecode, List<string> fields, bool? inclusiveTimecode, bool? accent);

        /// <summary>
        /// Retrieve all of the play timestamps for a game. This can be used for replaying games.  Endpoint returns all of the timecodes that can be used with diffs for /v1/game/{game_pk}/feed/live
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <returns>string</returns>
        string LiveTimestampv11(int? gamePk);

        /// <summary>
        /// Get game play By Play This endpoint allows you to pull the play by play of a game
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="inclusiveTimecode">True to include plays that happen before or at the specified timecode</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <returns>BaseballPlayByPlayRestObject</returns>
        BaseballPlayByPlayRestObject PlayByPlay(int? gamePk, string timecode, List<string> fields, bool? inclusiveTimecode, bool? accent);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GameApi : IGameApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GameApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GameApi(String basePath)
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
        /// Get game boxscore. This endpoint allows you to pull a boxscore
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="inclusiveTimecode">True to include plays that happen before or at the specified timecode</param>
        /// <param name="numPlayers">Number of top player game scores to show. Default is 3.</param>
        /// <param name="noTies">If set to false, will show all players tied for the last spot in the game scores list.</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <returns>BaseballBoxscoreRestObject</returns>
        public BaseballBoxscoreRestObject Boxscore(int? gamePk, string timecode, List<string> fields, bool? inclusiveTimecode, int? numPlayers, bool? noTies, bool? accent)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling Boxscore");

            var path = "/api/v1/game/{game_pk}/boxscore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "game_pk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (inclusiveTimecode != null) queryParams.Add("inclusiveTimecode", ApiClient.ParameterToString(inclusiveTimecode)); // query parameter
            if (numPlayers != null) queryParams.Add("numPlayers", ApiClient.ParameterToString(numPlayers)); // query parameter
            if (noTies != null) queryParams.Add("noTies", ApiClient.ParameterToString(noTies)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Boxscore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Boxscore: " + response.ErrorMessage, response.ErrorMessage);

            return (BaseballBoxscoreRestObject)ApiClient.Deserialize(response.Content, typeof(BaseballBoxscoreRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get game color feed. This API can return very large payloads.  It is STRONGLY recommended that clients ask for diffs and use \&quot;Accept-Encoding: gzip\&quot; header.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        public string ColorFeed(int? gamePk, string timecode, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling ColorFeed");

            var path = "/api/v1/game/{game_pk}/feed/color";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "game_pk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ColorFeed: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ColorFeed: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Retrieve all of the color timestamps for a game. This can be used for replaying games.  Endpoint returns all of the timecodes that can be used with diffs for /v1/game/{game_pk}/feed/color
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> ColorTimestamps(int? gamePk)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling ColorTimestamps");

            var path = "/api/v1/game/{game_pk}/feed/color/timestamps";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "game_pk" + "}", ApiClient.ParameterToString(gamePk));

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
                throw new ApiException((int)response.StatusCode, "Error calling ColorTimestamps: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ColorTimestamps: " + response.ErrorMessage, response.ErrorMessage);

            return (List<string>)ApiClient.Deserialize(response.Content, typeof(List<string>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Retrieve all content for a game.
        /// </summary>
        /// <param name="gamePk"></param>
        /// <param name="highlightLimit">Number of results to return</param>
        /// <returns>GameContentRestObject</returns>
        public GameContentRestObject Content(int? gamePk, int? highlightLimit)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling Content");

            var path = "/api/v1/game/{game_pk}/content";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "game_pk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (highlightLimit != null) queryParams.Add("highlightLimit", ApiClient.ParameterToString(highlightLimit)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Content: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Content: " + response.ErrorMessage, response.ErrorMessage);

            return (GameContentRestObject)ApiClient.Deserialize(response.Content, typeof(GameContentRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View a game change log
        /// </summary>
        /// <param name="updatedSince">Format: YYYY-MM-DDTHH:MM:SSZ</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ScheduleRestObject</returns>
        public ScheduleRestObject CurrentGameStats1(DateTime? updatedSince, int? sportId, List<int?> sportIds, GameTypeEnum gameType, List<GameTypeEnum> gameTypes, string season, List<int?> gamePks, int? limit, int? offset, List<string> fields)
        {
            var path = "/api/v1/game/changes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (updatedSince != null) queryParams.Add("updatedSince", ApiClient.ParameterToString(updatedSince)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (gameTypes != null) queryParams.Add("gameTypes", ApiClient.ParameterToString(gameTypes)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (gamePks != null) queryParams.Add("gamePks", ApiClient.ParameterToString(gamePks)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CurrentGameStats1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CurrentGameStats1: " + response.ErrorMessage, response.ErrorMessage);

            return (ScheduleRestObject)ApiClient.Deserialize(response.Content, typeof(ScheduleRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get the context metrics for this game based on its current state
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>BaseballGameContextRestObject</returns>
        public BaseballGameContextRestObject GetGameContextMetrics(int? gamePk, string timecode, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling GetGameContextMetrics");

            var path = "/api/v1/game/{gamePk}/contextMetrics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetGameContextMetrics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetGameContextMetrics: " + response.ErrorMessage, response.ErrorMessage);

            return (BaseballGameContextRestObject)ApiClient.Deserialize(response.Content, typeof(BaseballGameContextRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get game info with metrics
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="inclusiveTimecode">True to include plays that happen before or at the specified timecode</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <returns>BaseballGameRestObject</returns>
        public BaseballGameRestObject GetGameWithMetrics(int? gamePk, string timecode, bool? inclusiveTimecode, List<string> fields, bool? accent)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling GetGameWithMetrics");

            var path = "/api/v1/game/{gamePk}/withMetrics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (inclusiveTimecode != null) queryParams.Add("inclusiveTimecode", ApiClient.ParameterToString(inclusiveTimecode)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetGameWithMetrics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetGameWithMetrics: " + response.ErrorMessage, response.ErrorMessage);

            return (BaseballGameRestObject)ApiClient.Deserialize(response.Content, typeof(BaseballGameRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get the win probability for this game
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="inclusiveTimecode">True to include plays that happen before or at the specified timecode</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <returns>List&lt;BaseballPlayRestObject&gt;</returns>
        public List<BaseballPlayRestObject> GetWinProbability(int? gamePk, string timecode, List<string> fields, bool? inclusiveTimecode, bool? accent)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling GetWinProbability");

            var path = "/api/v1/game/{gamePk}/winProbability";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (inclusiveTimecode != null) queryParams.Add("inclusiveTimecode", ApiClient.ParameterToString(inclusiveTimecode)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetWinProbability: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetWinProbability: " + response.ErrorMessage, response.ErrorMessage);

            return (List<BaseballPlayRestObject>)ApiClient.Deserialize(response.Content, typeof(List<BaseballPlayRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get game linescore This endpoint allows you to pull the linescore for a game
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="inclusiveTimecode">True to include plays that happen before or at the specified timecode</param>
        /// <returns>BaseballLinescoreRestObject</returns>
        public BaseballLinescoreRestObject Linescore(int? gamePk, string timecode, List<string> fields, bool? inclusiveTimecode)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling Linescore");

            var path = "/api/v1/game/{game_pk}/linescore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "game_pk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (inclusiveTimecode != null) queryParams.Add("inclusiveTimecode", ApiClient.ParameterToString(inclusiveTimecode)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Linescore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Linescore: " + response.ErrorMessage, response.ErrorMessage);

            return (BaseballLinescoreRestObject)ApiClient.Deserialize(response.Content, typeof(BaseballLinescoreRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get live game status diffPatch. This endpoint allows comparison of game files and shows any differences/discrepancies between the two&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Diff/Patch System:&lt;/b&gt; startTimecode and endTimecode can be used for getting diffs.&lt;br/&gt;Expected usage:  &lt;br/&gt; 1) Request full payload by not passing startTimecode or endTimecode.  This will return the most recent game state.&lt;br/&gt; 2) Find the latest timecode in this response.  &lt;br/&gt; 3) Wait X seconds&lt;br/&gt; 4) Use the timecode from 2 as the startTimecode.  This will give you a diff of everything that has happened since startTimecode.  &lt;br/&gt; 5) If no data is returned, wait X seconds and do the same request.  &lt;br/&gt; 6) If data is returned, get a new timeStamp from the response, and use that for the next call as startTimecode.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="startTimecode">Start time code will give you everything since that time. Format: MMDDYYYY_HHMMSS</param>
        /// <param name="endTimecode">End time code will give you a snapshot at that specific time. Format: MMDDYYYY_HHMMSS</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <returns>string</returns>
        public string LiveGameDiffPatchV1(int? gamePk, string startTimecode, string endTimecode, bool? accent)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling LiveGameDiffPatchV1");

            var path = "/api/v1.1/game/{game_pk}/feed/live/diffPatch";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "game_pk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (startTimecode != null) queryParams.Add("startTimecode", ApiClient.ParameterToString(startTimecode)); // query parameter
            if (endTimecode != null) queryParams.Add("endTimecode", ApiClient.ParameterToString(endTimecode)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling LiveGameDiffPatchV1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling LiveGameDiffPatchV1: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get live game status. This API can return very large payloads.  It is STRONGLY recommended that clients ask for diffs and use \&quot;Accept-Encoding: gzip\&quot; header.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="inclusiveTimecode">True to include plays that happen before or at the specified timecode</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <returns>BaseballGameRestObject</returns>
        public BaseballGameRestObject LiveGameV1(int? gamePk, string timecode, List<string> fields, bool? inclusiveTimecode, bool? accent)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling LiveGameV1");

            var path = "/api/v1.1/game/{game_pk}/feed/live";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "game_pk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (inclusiveTimecode != null) queryParams.Add("inclusiveTimecode", ApiClient.ParameterToString(inclusiveTimecode)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling LiveGameV1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling LiveGameV1: " + response.ErrorMessage, response.ErrorMessage);

            return (BaseballGameRestObject)ApiClient.Deserialize(response.Content, typeof(BaseballGameRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Retrieve all of the play timestamps for a game. This can be used for replaying games.  Endpoint returns all of the timecodes that can be used with diffs for /v1/game/{game_pk}/feed/live
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <returns>string</returns>
        public string LiveTimestampv11(int? gamePk)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling LiveTimestampv11");

            var path = "/api/v1.1/game/{game_pk}/feed/live/timestamps";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "game_pk" + "}", ApiClient.ParameterToString(gamePk));

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
                throw new ApiException((int)response.StatusCode, "Error calling LiveTimestampv11: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling LiveTimestampv11: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get game play By Play This endpoint allows you to pull the play by play of a game
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="timecode">Use this parameter to return a snapshot of the data at the specified time. Format: YYYYMMDD_HHMMSS</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="inclusiveTimecode">True to include plays that happen before or at the specified timecode</param>
        /// <param name="accent">Boolean value to specify wanting a person&#x27;s name with accents or without</param>
        /// <returns>BaseballPlayByPlayRestObject</returns>
        public BaseballPlayByPlayRestObject PlayByPlay(int? gamePk, string timecode, List<string> fields, bool? inclusiveTimecode, bool? accent)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling PlayByPlay");

            var path = "/api/v1/game/{game_pk}/playByPlay";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "game_pk" + "}", ApiClient.ParameterToString(gamePk));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (timecode != null) queryParams.Add("timecode", ApiClient.ParameterToString(timecode)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (inclusiveTimecode != null) queryParams.Add("inclusiveTimecode", ApiClient.ParameterToString(inclusiveTimecode)); // query parameter
            if (accent != null) queryParams.Add("accent", ApiClient.ParameterToString(accent)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling PlayByPlay: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling PlayByPlay: " + response.ErrorMessage, response.ErrorMessage);

            return (BaseballPlayByPlayRestObject)ApiClient.Deserialize(response.Content, typeof(BaseballPlayByPlayRestObject), (IList<Parameter>)response.Headers);
        }
    }
}