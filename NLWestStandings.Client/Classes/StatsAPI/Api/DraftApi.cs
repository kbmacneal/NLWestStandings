using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDraftApi
    {
        /// <summary>
        /// View MLB Drafted Players
        /// </summary>
        /// <param name="year">Year the player was drafted. Format: 2000</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="sortBy">Sort the set of data by the specified field</param>
        /// <param name="drafted">Whether or not the players been drafted</param>
        /// <param name="round">Round in which a player was drafted</param>
        /// <param name="name">Filter players by the first letter of their name using using the specific character</param>
        /// <param name="school">Filter players by the first letter of their school using using the specific character</param>
        /// <param name="position">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="team">Unique Team Code. Format: tor, nya, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="state">State where the venue is located. Format: Ohio</param>
        /// <param name="country">Filter players by their home country</param>
        /// <param name="playerId">A unique identifier for a player</param>
        /// <param name="bisPlayerId">A unique identifier for a player in the EBIS system</param>
        /// <returns>BaseballDraftListRestObject</returns>
        BaseballDraftListRestObject DraftPicks(int? year, int? limit, int? offset, List<string> fields, SortOrderEnum order, string sortBy, bool? drafted, string round, string name, string school, BaseballPosition position, string team, int? teamId, string state, string country, int? playerId, int? bisPlayerId);

        /// <summary>
        /// View MLB Drafted Players
        /// </summary>
        /// <param name="year">Year the player was drafted. Format: 2000</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="sortBy">Sort the set of data by the specified field</param>
        /// <param name="drafted">Whether or not the players been drafted</param>
        /// <param name="round">Round in which a player was drafted</param>
        /// <param name="name">Filter players by the first letter of their name using using the specific character</param>
        /// <param name="school">Filter players by the first letter of their school using using the specific character</param>
        /// <param name="position">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="team">Unique Team Code. Format: tor, nya, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="state">State where the venue is located. Format: Ohio</param>
        /// <param name="country">Filter players by their home country</param>
        /// <param name="playerId">A unique identifier for a player</param>
        /// <param name="bisPlayerId">A unique identifier for a player in the EBIS system</param>
        /// <returns>BaseballDraftListRestObject</returns>
        BaseballDraftListRestObject DraftPicks1(int? year, int? limit, int? offset, List<string> fields, SortOrderEnum order, string sortBy, bool? drafted, string round, string name, string school, BaseballPosition position, string team, int? teamId, string state, string country, int? playerId, int? bisPlayerId);

        /// <summary>
        /// View MLB Draft Prospects
        /// </summary>
        /// <param name="year">Year the player was drafted. Format: 2000</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="sortBy">Sort the set of data by the specified field</param>
        /// <param name="drafted">Whether or not the players been drafted</param>
        /// <param name="round">Round in which a player was drafted</param>
        /// <param name="name">Filter players by the first letter of their name using using the specific character</param>
        /// <param name="school">Filter players by the first letter of their school using using the specific character</param>
        /// <param name="position">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="team">Unique Team Code. Format: tor, nya, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="state">State where the venue is located. Format: Ohio</param>
        /// <param name="country">Filter players by their home country</param>
        /// <param name="playerId">A unique identifier for a player</param>
        /// <param name="bisPlayerId">A unique identifier for a player in the EBIS system</param>
        /// <returns>ProspectListRestObject</returns>
        ProspectListRestObject DraftProspects(int? year, int? limit, int? offset, List<string> fields, SortOrderEnum order, string sortBy, bool? drafted, string round, string name, string school, BaseballPosition position, string team, int? teamId, string state, string country, int? playerId, int? bisPlayerId);

        /// <summary>
        /// View MLB Draft Prospects
        /// </summary>
        /// <param name="year">Year the player was drafted. Format: 2000</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="sortBy">Sort the set of data by the specified field</param>
        /// <param name="drafted">Whether or not the players been drafted</param>
        /// <param name="round">Round in which a player was drafted</param>
        /// <param name="name">Filter players by the first letter of their name using using the specific character</param>
        /// <param name="school">Filter players by the first letter of their school using using the specific character</param>
        /// <param name="position">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="team">Unique Team Code. Format: tor, nya, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="state">State where the venue is located. Format: Ohio</param>
        /// <param name="country">Filter players by their home country</param>
        /// <param name="playerId">A unique identifier for a player</param>
        /// <param name="bisPlayerId">A unique identifier for a player in the EBIS system</param>
        /// <returns>ProspectListRestObject</returns>
        ProspectListRestObject DraftProspects1(int? year, int? limit, int? offset, List<string> fields, SortOrderEnum order, string sortBy, bool? drafted, string round, string name, string school, BaseballPosition position, string team, int? teamId, string state, string country, int? playerId, int? bisPlayerId);

        /// <summary>
        /// Get the last drafted player and the next 5 teams up to pick
        /// </summary>
        /// <param name="year">Year the player was drafted. Format: 2000</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>BaseballDraftLatestRestObject</returns>
        BaseballDraftLatestRestObject LatestDraftPicks(int? year, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DraftApi : IDraftApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DraftApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DraftApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DraftApi(String basePath)
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
        /// View MLB Drafted Players
        /// </summary>
        /// <param name="year">Year the player was drafted. Format: 2000</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="sortBy">Sort the set of data by the specified field</param>
        /// <param name="drafted">Whether or not the players been drafted</param>
        /// <param name="round">Round in which a player was drafted</param>
        /// <param name="name">Filter players by the first letter of their name using using the specific character</param>
        /// <param name="school">Filter players by the first letter of their school using using the specific character</param>
        /// <param name="position">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="team">Unique Team Code. Format: tor, nya, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="state">State where the venue is located. Format: Ohio</param>
        /// <param name="country">Filter players by their home country</param>
        /// <param name="playerId">A unique identifier for a player</param>
        /// <param name="bisPlayerId">A unique identifier for a player in the EBIS system</param>
        /// <returns>BaseballDraftListRestObject</returns>
        public BaseballDraftListRestObject DraftPicks(int? year, int? limit, int? offset, List<string> fields, SortOrderEnum order, string sortBy, bool? drafted, string round, string name, string school, BaseballPosition position, string team, int? teamId, string state, string country, int? playerId, int? bisPlayerId)
        {
            // verify the required parameter 'year' is set
            if (year == null) throw new ApiException(400, "Missing required parameter 'year' when calling DraftPicks");

            var path = "/api/v1/draft";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "year" + "}", ApiClient.ParameterToString(year));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", ApiClient.ParameterToString(sortBy)); // query parameter
            if (drafted != null) queryParams.Add("drafted", ApiClient.ParameterToString(drafted)); // query parameter
            if (round != null) queryParams.Add("round", ApiClient.ParameterToString(round)); // query parameter
            if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
            if (school != null) queryParams.Add("school", ApiClient.ParameterToString(school)); // query parameter
            if (position != null) queryParams.Add("position", ApiClient.ParameterToString(position)); // query parameter
            if (team != null) queryParams.Add("team", ApiClient.ParameterToString(team)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
            if (country != null) queryParams.Add("country", ApiClient.ParameterToString(country)); // query parameter
            if (playerId != null) queryParams.Add("playerId", ApiClient.ParameterToString(playerId)); // query parameter
            if (bisPlayerId != null) queryParams.Add("bisPlayerId", ApiClient.ParameterToString(bisPlayerId)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DraftPicks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DraftPicks: " + response.ErrorMessage, response.ErrorMessage);

            return (BaseballDraftListRestObject)ApiClient.Deserialize(response.Content, typeof(BaseballDraftListRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View MLB Drafted Players
        /// </summary>
        /// <param name="year">Year the player was drafted. Format: 2000</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="sortBy">Sort the set of data by the specified field</param>
        /// <param name="drafted">Whether or not the players been drafted</param>
        /// <param name="round">Round in which a player was drafted</param>
        /// <param name="name">Filter players by the first letter of their name using using the specific character</param>
        /// <param name="school">Filter players by the first letter of their school using using the specific character</param>
        /// <param name="position">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="team">Unique Team Code. Format: tor, nya, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="state">State where the venue is located. Format: Ohio</param>
        /// <param name="country">Filter players by their home country</param>
        /// <param name="playerId">A unique identifier for a player</param>
        /// <param name="bisPlayerId">A unique identifier for a player in the EBIS system</param>
        /// <returns>BaseballDraftListRestObject</returns>
        public BaseballDraftListRestObject DraftPicks1(int? year, int? limit, int? offset, List<string> fields, SortOrderEnum order, string sortBy, bool? drafted, string round, string name, string school, BaseballPosition position, string team, int? teamId, string state, string country, int? playerId, int? bisPlayerId)
        {
            // verify the required parameter 'year' is set
            if (year == null) throw new ApiException(400, "Missing required parameter 'year' when calling DraftPicks1");

            var path = "/api/v1/draft/{year}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "year" + "}", ApiClient.ParameterToString(year));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", ApiClient.ParameterToString(sortBy)); // query parameter
            if (drafted != null) queryParams.Add("drafted", ApiClient.ParameterToString(drafted)); // query parameter
            if (round != null) queryParams.Add("round", ApiClient.ParameterToString(round)); // query parameter
            if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
            if (school != null) queryParams.Add("school", ApiClient.ParameterToString(school)); // query parameter
            if (position != null) queryParams.Add("position", ApiClient.ParameterToString(position)); // query parameter
            if (team != null) queryParams.Add("team", ApiClient.ParameterToString(team)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
            if (country != null) queryParams.Add("country", ApiClient.ParameterToString(country)); // query parameter
            if (playerId != null) queryParams.Add("playerId", ApiClient.ParameterToString(playerId)); // query parameter
            if (bisPlayerId != null) queryParams.Add("bisPlayerId", ApiClient.ParameterToString(bisPlayerId)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DraftPicks1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DraftPicks1: " + response.ErrorMessage, response.ErrorMessage);

            return (BaseballDraftListRestObject)ApiClient.Deserialize(response.Content, typeof(BaseballDraftListRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View MLB Draft Prospects
        /// </summary>
        /// <param name="year">Year the player was drafted. Format: 2000</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="sortBy">Sort the set of data by the specified field</param>
        /// <param name="drafted">Whether or not the players been drafted</param>
        /// <param name="round">Round in which a player was drafted</param>
        /// <param name="name">Filter players by the first letter of their name using using the specific character</param>
        /// <param name="school">Filter players by the first letter of their school using using the specific character</param>
        /// <param name="position">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="team">Unique Team Code. Format: tor, nya, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="state">State where the venue is located. Format: Ohio</param>
        /// <param name="country">Filter players by their home country</param>
        /// <param name="playerId">A unique identifier for a player</param>
        /// <param name="bisPlayerId">A unique identifier for a player in the EBIS system</param>
        /// <returns>ProspectListRestObject</returns>
        public ProspectListRestObject DraftProspects(int? year, int? limit, int? offset, List<string> fields, SortOrderEnum order, string sortBy, bool? drafted, string round, string name, string school, BaseballPosition position, string team, int? teamId, string state, string country, int? playerId, int? bisPlayerId)
        {
            // verify the required parameter 'year' is set
            if (year == null) throw new ApiException(400, "Missing required parameter 'year' when calling DraftProspects");

            var path = "/api/v1/draft/prospects";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "year" + "}", ApiClient.ParameterToString(year));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", ApiClient.ParameterToString(sortBy)); // query parameter
            if (drafted != null) queryParams.Add("drafted", ApiClient.ParameterToString(drafted)); // query parameter
            if (round != null) queryParams.Add("round", ApiClient.ParameterToString(round)); // query parameter
            if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
            if (school != null) queryParams.Add("school", ApiClient.ParameterToString(school)); // query parameter
            if (position != null) queryParams.Add("position", ApiClient.ParameterToString(position)); // query parameter
            if (team != null) queryParams.Add("team", ApiClient.ParameterToString(team)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
            if (country != null) queryParams.Add("country", ApiClient.ParameterToString(country)); // query parameter
            if (playerId != null) queryParams.Add("playerId", ApiClient.ParameterToString(playerId)); // query parameter
            if (bisPlayerId != null) queryParams.Add("bisPlayerId", ApiClient.ParameterToString(bisPlayerId)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DraftProspects: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DraftProspects: " + response.ErrorMessage, response.ErrorMessage);

            return (ProspectListRestObject)ApiClient.Deserialize(response.Content, typeof(ProspectListRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View MLB Draft Prospects
        /// </summary>
        /// <param name="year">Year the player was drafted. Format: 2000</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="offset">The pointer to start for a return set; used for pagination</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="order">The order of sorting, ascending or descending</param>
        /// <param name="sortBy">Sort the set of data by the specified field</param>
        /// <param name="drafted">Whether or not the players been drafted</param>
        /// <param name="round">Round in which a player was drafted</param>
        /// <param name="name">Filter players by the first letter of their name using using the specific character</param>
        /// <param name="school">Filter players by the first letter of their school using using the specific character</param>
        /// <param name="position">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="team">Unique Team Code. Format: tor, nya, etc</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="state">State where the venue is located. Format: Ohio</param>
        /// <param name="country">Filter players by their home country</param>
        /// <param name="playerId">A unique identifier for a player</param>
        /// <param name="bisPlayerId">A unique identifier for a player in the EBIS system</param>
        /// <returns>ProspectListRestObject</returns>
        public ProspectListRestObject DraftProspects1(int? year, int? limit, int? offset, List<string> fields, SortOrderEnum order, string sortBy, bool? drafted, string round, string name, string school, BaseballPosition position, string team, int? teamId, string state, string country, int? playerId, int? bisPlayerId)
        {
            // verify the required parameter 'year' is set
            if (year == null) throw new ApiException(400, "Missing required parameter 'year' when calling DraftProspects1");

            var path = "/api/v1/draft/prospects/{year}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "year" + "}", ApiClient.ParameterToString(year));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", ApiClient.ParameterToString(sortBy)); // query parameter
            if (drafted != null) queryParams.Add("drafted", ApiClient.ParameterToString(drafted)); // query parameter
            if (round != null) queryParams.Add("round", ApiClient.ParameterToString(round)); // query parameter
            if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
            if (school != null) queryParams.Add("school", ApiClient.ParameterToString(school)); // query parameter
            if (position != null) queryParams.Add("position", ApiClient.ParameterToString(position)); // query parameter
            if (team != null) queryParams.Add("team", ApiClient.ParameterToString(team)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
            if (country != null) queryParams.Add("country", ApiClient.ParameterToString(country)); // query parameter
            if (playerId != null) queryParams.Add("playerId", ApiClient.ParameterToString(playerId)); // query parameter
            if (bisPlayerId != null) queryParams.Add("bisPlayerId", ApiClient.ParameterToString(bisPlayerId)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DraftProspects1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DraftProspects1: " + response.ErrorMessage, response.ErrorMessage);

            return (ProspectListRestObject)ApiClient.Deserialize(response.Content, typeof(ProspectListRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get the last drafted player and the next 5 teams up to pick
        /// </summary>
        /// <param name="year">Year the player was drafted. Format: 2000</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>BaseballDraftLatestRestObject</returns>
        public BaseballDraftLatestRestObject LatestDraftPicks(int? year, List<string> fields)
        {
            // verify the required parameter 'year' is set
            if (year == null) throw new ApiException(400, "Missing required parameter 'year' when calling LatestDraftPicks");

            var path = "/api/v1/draft/{year}/latest";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "year" + "}", ApiClient.ParameterToString(year));

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
                throw new ApiException((int)response.StatusCode, "Error calling LatestDraftPicks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling LatestDraftPicks: " + response.ErrorMessage, response.ErrorMessage);

            return (BaseballDraftLatestRestObject)ApiClient.Deserialize(response.Content, typeof(BaseballDraftLatestRestObject), (IList<Parameter>)response.Headers);
        }
    }
}