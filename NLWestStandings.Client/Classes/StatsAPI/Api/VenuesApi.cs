using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVenuesApi
    {
        /// <summary>
        /// View venue info This endpoint allows you to pull venues
        /// </summary>
        /// <param name="venueId">Unique Venue Identifier</param>
        /// <param name="venueIds">Comma delimited list of Unique venue identifiers</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="active">Whether or not a player is active</param>
        /// <param name="includeEvents"></param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <returns>VenuesRestObject</returns>
        VenuesRestObject Venues(int? venueId, List<int?> venueIds, int? leagueId, List<int?> leagueIds, GameTypeEnum gameType, List<GameTypeEnum> gameTypes, string season, List<string> seasons, List<string> fields, bool? active, bool? includeEvents, int? sportId, List<int?> sportIds);

        /// <summary>
        /// View venue info This endpoint allows you to pull venues
        /// </summary>
        /// <param name="venueId">Unique Venue Identifier</param>
        /// <param name="venueIds">Comma delimited list of Unique venue identifiers</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="active">Whether or not a player is active</param>
        /// <param name="includeEvents"></param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <returns>VenuesRestObject</returns>
        VenuesRestObject Venues1(int? venueId, List<int?> venueIds, int? leagueId, List<int?> leagueIds, GameTypeEnum gameType, List<GameTypeEnum> gameTypes, string season, List<string> seasons, List<string> fields, bool? active, bool? includeEvents, int? sportId, List<int?> sportIds);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VenuesApi : IVenuesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VenuesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VenuesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VenuesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VenuesApi(String basePath)
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
        /// View venue info This endpoint allows you to pull venues
        /// </summary>
        /// <param name="venueId">Unique Venue Identifier</param>
        /// <param name="venueIds">Comma delimited list of Unique venue identifiers</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="active">Whether or not a player is active</param>
        /// <param name="includeEvents"></param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <returns>VenuesRestObject</returns>
        public VenuesRestObject Venues(int? venueId, List<int?> venueIds, int? leagueId, List<int?> leagueIds, GameTypeEnum gameType, List<GameTypeEnum> gameTypes, string season, List<string> seasons, List<string> fields, bool? active, bool? includeEvents, int? sportId, List<int?> sportIds)
        {
            // verify the required parameter 'venueId' is set
            if (venueId == null) throw new ApiException(400, "Missing required parameter 'venueId' when calling Venues");

            var path = "/api/v1/venues";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "venueId" + "}", ApiClient.ParameterToString(venueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (venueIds != null) queryParams.Add("venueIds", ApiClient.ParameterToString(venueIds)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (gameTypes != null) queryParams.Add("gameTypes", ApiClient.ParameterToString(gameTypes)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (active != null) queryParams.Add("active", ApiClient.ParameterToString(active)); // query parameter
            if (includeEvents != null) queryParams.Add("includeEvents", ApiClient.ParameterToString(includeEvents)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Venues: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Venues: " + response.ErrorMessage, response.ErrorMessage);

            return (VenuesRestObject)ApiClient.Deserialize(response.Content, typeof(VenuesRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View venue info This endpoint allows you to pull venues
        /// </summary>
        /// <param name="venueId">Unique Venue Identifier</param>
        /// <param name="venueIds">Comma delimited list of Unique venue identifiers</param>
        /// <param name="leagueId">Unique League Identifier</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="gameTypes">Comma delimited list of type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="active">Whether or not a player is active</param>
        /// <param name="includeEvents"></param>
        /// <param name="sportId">Top level organization of a sport</param>
        /// <param name="sportIds">Comma delimited list of top level organizations of a sport</param>
        /// <returns>VenuesRestObject</returns>
        public VenuesRestObject Venues1(int? venueId, List<int?> venueIds, int? leagueId, List<int?> leagueIds, GameTypeEnum gameType, List<GameTypeEnum> gameTypes, string season, List<string> seasons, List<string> fields, bool? active, bool? includeEvents, int? sportId, List<int?> sportIds)
        {
            // verify the required parameter 'venueId' is set
            if (venueId == null) throw new ApiException(400, "Missing required parameter 'venueId' when calling Venues1");

            var path = "/api/v1/venues/{venueId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "venueId" + "}", ApiClient.ParameterToString(venueId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (venueIds != null) queryParams.Add("venueIds", ApiClient.ParameterToString(venueIds)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (gameTypes != null) queryParams.Add("gameTypes", ApiClient.ParameterToString(gameTypes)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (active != null) queryParams.Add("active", ApiClient.ParameterToString(active)); // query parameter
            if (includeEvents != null) queryParams.Add("includeEvents", ApiClient.ParameterToString(includeEvents)); // query parameter
            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (sportIds != null) queryParams.Add("sportIds", ApiClient.ParameterToString(sportIds)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Venues1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Venues1: " + response.ErrorMessage, response.ErrorMessage);

            return (VenuesRestObject)ApiClient.Deserialize(response.Content, typeof(VenuesRestObject), (IList<Parameter>)response.Headers);
        }
    }
}