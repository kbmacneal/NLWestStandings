using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUniformsApi
    {
        /// <summary>
        /// View Game Uniform info This endpoint allows you to pull team uniform data for a game
        /// </summary>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>UniformsGamesRestObject</returns>
        UniformsGamesRestObject UniformsByGame(List<int?> gamePks, List<string> fields);

        /// <summary>
        /// View Team Uniform info This endpoint allows you to pull team uniform data for a season
        /// </summary>
        /// <param name="teamIds"></param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>UniformsTeamsRestObject</returns>
        UniformsTeamsRestObject UniformsByTeam(List<int?> teamIds, string season, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UniformsApi : IUniformsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniformsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UniformsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniformsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UniformsApi(String basePath)
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
        /// View Game Uniform info This endpoint allows you to pull team uniform data for a game
        /// </summary>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>UniformsGamesRestObject</returns>
        public UniformsGamesRestObject UniformsByGame(List<int?> gamePks, List<string> fields)
        {
            // verify the required parameter 'gamePks' is set
            if (gamePks == null) throw new ApiException(400, "Missing required parameter 'gamePks' when calling UniformsByGame");

            var path = "/api/v1/uniforms/game";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (gamePks != null) queryParams.Add("gamePks", ApiClient.ParameterToString(gamePks)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UniformsByGame: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UniformsByGame: " + response.ErrorMessage, response.ErrorMessage);

            return (UniformsGamesRestObject)ApiClient.Deserialize(response.Content, typeof(UniformsGamesRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View Team Uniform info This endpoint allows you to pull team uniform data for a season
        /// </summary>
        /// <param name="teamIds"></param>
        /// <param name="season">Season of play</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>UniformsTeamsRestObject</returns>
        public UniformsTeamsRestObject UniformsByTeam(List<int?> teamIds, string season, List<string> fields)
        {
            // verify the required parameter 'teamIds' is set
            if (teamIds == null) throw new ApiException(400, "Missing required parameter 'teamIds' when calling UniformsByTeam");

            var path = "/api/v1/uniforms/team";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (teamIds != null) queryParams.Add("teamIds", ApiClient.ParameterToString(teamIds)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UniformsByTeam: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UniformsByTeam: " + response.ErrorMessage, response.ErrorMessage);

            return (UniformsTeamsRestObject)ApiClient.Deserialize(response.Content, typeof(UniformsTeamsRestObject), (IList<Parameter>)response.Headers);
        }
    }
}