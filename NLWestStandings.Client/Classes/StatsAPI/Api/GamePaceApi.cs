using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGamePaceApi
    {
        /// <summary>
        /// View time of game info
        /// </summary>
        /// <param name="season">Season of play</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="venueIds">Comma delimited list of Unique venue identifiers</param>
        /// <param name="excludeVenueIds">Comma delimited list of Unique venue identifiers</param>
        /// <param name="excludeGamePks">Comma delimited list of unique primary keys</param>
        /// <param name="orgType">Organization level. Format: T(Team), L(League), S(Sport)</param>
        /// <param name="includeChildren">Determines weather to include results from an organization&#x27;s children (ex. a sport would also include results for the teams and leagues)</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>GamePaceWrapperRestObject</returns>
        GamePaceWrapperRestObject GamePace(string season, int? teamId, List<int?> teamIds, int? leagueId, List<int?> leagueIds, LeagueListsEnum leagueListId, int? sportId, List<int?> sportIds, GameTypeEnum gameType, DateTime? startDate, DateTime? endDate, List<int?> venueIds, List<int?> excludeVenueIds, List<int?> excludeGamePks, OrganizationType orgType, bool? includeChildren, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GamePaceApi : IGamePaceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamePaceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GamePaceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GamePaceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GamePaceApi(String basePath)
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
        /// View time of game info
        /// </summary>
        /// <param name="season">Season of play</param>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="venueIds">Comma delimited list of Unique venue identifiers</param>
        /// <param name="excludeVenueIds">Comma delimited list of Unique venue identifiers</param>
        /// <param name="excludeGamePks">Comma delimited list of unique primary keys</param>
        /// <param name="orgType">Organization level. Format: T(Team), L(League), S(Sport)</param>
        /// <param name="includeChildren">Determines weather to include results from an organization&#x27;s children (ex. a sport would also include results for the teams and leagues)</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>GamePaceWrapperRestObject</returns>
        public GamePaceWrapperRestObject GamePace(string season, int? teamId, List<int?> teamIds, int? leagueId, List<int?> leagueIds, LeagueListsEnum leagueListId, int? sportId, List<int?> sportIds, GameTypeEnum gameType, DateTime? startDate, DateTime? endDate, List<int?> venueIds, List<int?> excludeVenueIds, List<int?> excludeGamePks, OrganizationType orgType, bool? includeChildren, List<string> fields)
        {
            var path = "/api/v1/gamePace";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (teamIds != null) queryParams.Add("teamIds", ApiClient.ParameterToString(teamIds)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (leagueListId != null) queryParams.Add("leagueListId", ApiClient.ParameterToString(leagueListId)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (venueIds != null) queryParams.Add("venueIds", ApiClient.ParameterToString(venueIds)); // query parameter
            if (excludeVenueIds != null) queryParams.Add("excludeVenueIds", ApiClient.ParameterToString(excludeVenueIds)); // query parameter
            if (excludeGamePks != null) queryParams.Add("excludeGamePks", ApiClient.ParameterToString(excludeGamePks)); // query parameter
            if (orgType != null) queryParams.Add("orgType", ApiClient.ParameterToString(orgType)); // query parameter
            if (includeChildren != null) queryParams.Add("includeChildren", ApiClient.ParameterToString(includeChildren)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GamePace: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GamePace: " + response.ErrorMessage, response.ErrorMessage);

            return (GamePaceWrapperRestObject)ApiClient.Deserialize(response.Content, typeof(GamePaceWrapperRestObject), (IList<Parameter>)response.Headers);
        }
    }
}