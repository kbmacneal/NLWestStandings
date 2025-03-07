using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReviewsApi
    {
        /// <summary>
        /// Get review info
        /// </summary>
        /// <param name="sportId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Comma delimited list of Seasons of play</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatContainerRestObject</returns>
        StatContainerRestObject GetReviewInfo(int? sportId, string season, GameTypeEnum gameType, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReviewsApi : IReviewsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReviewsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReviewsApi(String basePath)
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
        /// Get review info
        /// </summary>
        /// <param name="sportId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="season">Comma delimited list of Seasons of play</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>StatContainerRestObject</returns>
        public StatContainerRestObject GetReviewInfo(int? sportId, string season, GameTypeEnum gameType, List<string> fields)
        {
            // verify the required parameter 'sportId' is set
            if (sportId == null) throw new ApiException(400, "Missing required parameter 'sportId' when calling GetReviewInfo");
            // verify the required parameter 'season' is set
            if (season == null) throw new ApiException(400, "Missing required parameter 'season' when calling GetReviewInfo");

            var path = "/api/v1/review";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (sportId != null) queryParams.Add("sportId", ApiClient.ParameterToString(sportId)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetReviewInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetReviewInfo: " + response.ErrorMessage, response.ErrorMessage);

            return (StatContainerRestObject)ApiClient.Deserialize(response.Content, typeof(StatContainerRestObject), (IList<Parameter>)response.Headers);
        }
    }
}