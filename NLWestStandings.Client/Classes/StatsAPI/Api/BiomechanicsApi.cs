using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBiomechanicsApi
    {
        /// <summary>
        /// View Biomechanical data by playId and gameId filtered by player positionId This endpoint allows you to pull biomechanical tracking data by gameId and playId filtered by player positionId
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="playId">Unique play identifier</param>
        /// <param name="positionId">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>SkeletalDataWrapperRestObject</returns>
        SkeletalDataWrapperRestObject Biomechanical(int? gamePk, string playId, int? positionId, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BiomechanicsApi : IBiomechanicsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BiomechanicsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BiomechanicsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BiomechanicsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BiomechanicsApi(String basePath)
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
        /// View Biomechanical data by playId and gameId filtered by player positionId This endpoint allows you to pull biomechanical tracking data by gameId and playId filtered by player positionId
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="playId">Unique play identifier</param>
        /// <param name="positionId">Position number. Format: 1, 2, 3, etc</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>SkeletalDataWrapperRestObject</returns>
        public SkeletalDataWrapperRestObject Biomechanical(int? gamePk, string playId, int? positionId, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling Biomechanical");
            // verify the required parameter 'playId' is set
            if (playId == null) throw new ApiException(400, "Missing required parameter 'playId' when calling Biomechanical");
            // verify the required parameter 'positionId' is set
            if (positionId == null) throw new ApiException(400, "Missing required parameter 'positionId' when calling Biomechanical");

            var path = "/api/v1/game/{gamePk}/{playId}/analytics/biomechanics/{positionId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));
            path = path.Replace("{" + "playId" + "}", ApiClient.ParameterToString(playId));
            path = path.Replace("{" + "positionId" + "}", ApiClient.ParameterToString(positionId));

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
                throw new ApiException((int)response.StatusCode, "Error calling Biomechanical: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Biomechanical: " + response.ErrorMessage, response.ErrorMessage);

            return (SkeletalDataWrapperRestObject)ApiClient.Deserialize(response.Content, typeof(SkeletalDataWrapperRestObject), (IList<Parameter>)response.Headers);
        }
    }
}