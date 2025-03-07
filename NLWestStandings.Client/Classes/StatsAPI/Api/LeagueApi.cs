using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILeagueApi
    {
        /// <summary>
        /// View al star ballot info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        string AllStarBallot(int? leagueId, List<int?> leagueIds, string season, List<string> fields);

        /// <summary>
        /// View al star ballot info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        string AllStarBallot1(int? leagueId, List<int?> leagueIds, string season, List<string> fields);

        /// <summary>
        /// View al star ballot info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        string AllStarBallot2(int? leagueId, List<int?> leagueIds, string season, List<string> fields);

        /// <summary>
        /// View al star ballot info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        string AllStarBallot3(int? leagueId, List<int?> leagueIds, string season, List<string> fields);

        /// <summary>
        /// View all star final vote info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        string AllStarFinalVote(int? leagueId, string season, List<string> fields);

        /// <summary>
        /// View all star final vote info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        string AllStarFinalVote1(int? leagueId, string season, List<string> fields);

        /// <summary>
        /// View all star write ins info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        string AllStarWriteIns(int? leagueId, string season, List<string> fields);

        /// <summary>
        /// View all star write ins info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        string AllStarWriteIns1(int? leagueId, string season, List<string> fields);

        /// <summary>
        /// View league info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="activeStatus">Flag for fetching leagues that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <returns>string</returns>
        string League(int? leagueId, List<int?> leagueIds, string season, List<string> seasons, List<string> fields, int? sportId, LeagueActiveStatusEnum activeStatus);

        /// <summary>
        /// View league info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="activeStatus">Flag for fetching leagues that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <returns>string</returns>
        string League1(int? leagueId, List<int?> leagueIds, string season, List<string> seasons, List<string> fields, int? sportId, LeagueActiveStatusEnum activeStatus);

        /// <summary>
        /// View league info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="activeStatus">Flag for fetching leagues that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <returns>string</returns>
        string League2(int? leagueId, List<int?> leagueIds, string season, List<string> seasons, List<string> fields, int? sportId, LeagueActiveStatusEnum activeStatus);

        /// <summary>
        /// View league info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="activeStatus">Flag for fetching leagues that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <returns>string</returns>
        string League3(int? leagueId, List<int?> leagueIds, string season, List<string> seasons, List<string> fields, int? sportId, LeagueActiveStatusEnum activeStatus);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LeagueApi : ILeagueApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeagueApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LeagueApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LeagueApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LeagueApi(String basePath)
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
        /// View al star ballot info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        public string AllStarBallot(int? leagueId, List<int?> leagueIds, string season, List<string> fields)
        {
            // verify the required parameter 'leagueId' is set
            if (leagueId == null) throw new ApiException(400, "Missing required parameter 'leagueId' when calling AllStarBallot");

            var path = "/api/v1/league/allStarBallot";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "leagueId" + "}", ApiClient.ParameterToString(leagueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarBallot: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarBallot: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View al star ballot info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        public string AllStarBallot1(int? leagueId, List<int?> leagueIds, string season, List<string> fields)
        {
            // verify the required parameter 'leagueId' is set
            if (leagueId == null) throw new ApiException(400, "Missing required parameter 'leagueId' when calling AllStarBallot1");

            var path = "/api/v1/league/{leagueId}/allStarBallot";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "leagueId" + "}", ApiClient.ParameterToString(leagueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarBallot1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarBallot1: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View al star ballot info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        public string AllStarBallot2(int? leagueId, List<int?> leagueIds, string season, List<string> fields)
        {
            // verify the required parameter 'leagueId' is set
            if (leagueId == null) throw new ApiException(400, "Missing required parameter 'leagueId' when calling AllStarBallot2");

            var path = "/api/v1/leagues/allStarBallot";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "leagueId" + "}", ApiClient.ParameterToString(leagueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarBallot2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarBallot2: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View al star ballot info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        public string AllStarBallot3(int? leagueId, List<int?> leagueIds, string season, List<string> fields)
        {
            // verify the required parameter 'leagueId' is set
            if (leagueId == null) throw new ApiException(400, "Missing required parameter 'leagueId' when calling AllStarBallot3");

            var path = "/api/v1/leagues/{leagueId}/allStarBallot";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "leagueId" + "}", ApiClient.ParameterToString(leagueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarBallot3: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarBallot3: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View all star final vote info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        public string AllStarFinalVote(int? leagueId, string season, List<string> fields)
        {
            // verify the required parameter 'leagueId' is set
            if (leagueId == null) throw new ApiException(400, "Missing required parameter 'leagueId' when calling AllStarFinalVote");

            var path = "/api/v1/league/{leagueId}/allStarFinalVote";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "leagueId" + "}", ApiClient.ParameterToString(leagueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarFinalVote: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarFinalVote: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View all star final vote info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        public string AllStarFinalVote1(int? leagueId, string season, List<string> fields)
        {
            // verify the required parameter 'leagueId' is set
            if (leagueId == null) throw new ApiException(400, "Missing required parameter 'leagueId' when calling AllStarFinalVote1");

            var path = "/api/v1/leagues/{leagueId}/allStarFinalVote";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "leagueId" + "}", ApiClient.ParameterToString(leagueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarFinalVote1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarFinalVote1: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View all star write ins info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        public string AllStarWriteIns(int? leagueId, string season, List<string> fields)
        {
            // verify the required parameter 'leagueId' is set
            if (leagueId == null) throw new ApiException(400, "Missing required parameter 'leagueId' when calling AllStarWriteIns");

            var path = "/api/v1/league/{leagueId}/allStarWriteIns";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "leagueId" + "}", ApiClient.ParameterToString(leagueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarWriteIns: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarWriteIns: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View all star write ins info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>string</returns>
        public string AllStarWriteIns1(int? leagueId, string season, List<string> fields)
        {
            // verify the required parameter 'leagueId' is set
            if (leagueId == null) throw new ApiException(400, "Missing required parameter 'leagueId' when calling AllStarWriteIns1");

            var path = "/api/v1/leagues/{leagueId}/allStarWriteIns";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "leagueId" + "}", ApiClient.ParameterToString(leagueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarWriteIns1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AllStarWriteIns1: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View league info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="activeStatus">Flag for fetching leagues that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <returns>string</returns>
        public string League(int? leagueId, List<int?> leagueIds, string season, List<string> seasons, List<string> fields, int? sportId, LeagueActiveStatusEnum activeStatus)
        {
            // verify the required parameter 'leagueId' is set
            if (leagueId == null) throw new ApiException(400, "Missing required parameter 'leagueId' when calling League");

            var path = "/api/v1/league";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "leagueId" + "}", ApiClient.ParameterToString(leagueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (activeStatus != null) queryParams.Add("activeStatus", ApiClient.ParameterToString(activeStatus)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling League: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling League: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View league info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="activeStatus">Flag for fetching leagues that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <returns>string</returns>
        public string League1(int? leagueId, List<int?> leagueIds, string season, List<string> seasons, List<string> fields, int? sportId, LeagueActiveStatusEnum activeStatus)
        {
            // verify the required parameter 'leagueId' is set
            if (leagueId == null) throw new ApiException(400, "Missing required parameter 'leagueId' when calling League1");

            var path = "/api/v1/league/{leagueId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "leagueId" + "}", ApiClient.ParameterToString(leagueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (activeStatus != null) queryParams.Add("activeStatus", ApiClient.ParameterToString(activeStatus)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling League1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling League1: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View league info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="activeStatus">Flag for fetching leagues that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <returns>string</returns>
        public string League2(int? leagueId, List<int?> leagueIds, string season, List<string> seasons, List<string> fields, int? sportId, LeagueActiveStatusEnum activeStatus)
        {
            // verify the required parameter 'leagueId' is set
            if (leagueId == null) throw new ApiException(400, "Missing required parameter 'leagueId' when calling League2");

            var path = "/api/v1/leagues";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "leagueId" + "}", ApiClient.ParameterToString(leagueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (activeStatus != null) queryParams.Add("activeStatus", ApiClient.ParameterToString(activeStatus)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling League2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling League2: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View league info
        /// </summary>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="activeStatus">Flag for fetching leagues that are currently active (Y), inactive (N), pending (P), or all teams (B)</param>
        /// <returns>string</returns>
        public string League3(int? leagueId, List<int?> leagueIds, string season, List<string> seasons, List<string> fields, int? sportId, LeagueActiveStatusEnum activeStatus)
        {
            // verify the required parameter 'leagueId' is set
            if (leagueId == null) throw new ApiException(400, "Missing required parameter 'leagueId' when calling League3");

            var path = "/api/v1/leagues/{leagueId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "leagueId" + "}", ApiClient.ParameterToString(leagueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (activeStatus != null) queryParams.Add("activeStatus", ApiClient.ParameterToString(activeStatus)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling League3: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling League3: " + response.ErrorMessage, response.ErrorMessage);

            return (string)ApiClient.Deserialize(response.Content, typeof(string), (IList<Parameter>)response.Headers);
        }
    }
}