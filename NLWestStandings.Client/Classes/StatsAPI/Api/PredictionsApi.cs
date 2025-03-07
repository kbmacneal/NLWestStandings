using IO.Swagger.Client;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPredictionsApi
    {
        /// <summary>
        /// Get play-level predictions based on input scenarios This endpoint allows you to get play-level predictions based on input scenarios
        /// </summary>
        /// <param name="batterId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="pitcherId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="venueId">Unique Venue Identifier</param>
        /// <param name="batSide">Bat side of hitter</param>
        /// <param name="pitchHand">Handedness of pitcher</param>
        /// <param name="batterPosition">Position abbreviation. Format: SS, P, 1B, etc</param>
        /// <param name="pitcherPosition">Position abbreviation. Format: SS, P, 1B, etc</param>
        /// <returns>Object</returns>
        Object GetProps(int? batterId, int? pitcherId, int? venueId, string batSide, string pitchHand, string batterPosition, string pitcherPosition);

        /// <summary>
        /// Get play-level predictions based on input scenarios This endpoint allows you to get play-level predictions based on input scenarios
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <returns>Object</returns>
        Object GetPropsAdjust(int? gamePk);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PredictionsApi : IPredictionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PredictionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PredictionsApi(String basePath)
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
        /// Get play-level predictions based on input scenarios This endpoint allows you to get play-level predictions based on input scenarios
        /// </summary>
        /// <param name="batterId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="pitcherId">Unique Player Identifier. Format: 434538, 429665, etc</param>
        /// <param name="venueId">Unique Venue Identifier</param>
        /// <param name="batSide">Bat side of hitter</param>
        /// <param name="pitchHand">Handedness of pitcher</param>
        /// <param name="batterPosition">Position abbreviation. Format: SS, P, 1B, etc</param>
        /// <param name="pitcherPosition">Position abbreviation. Format: SS, P, 1B, etc</param>
        /// <returns>Object</returns>
        public Object GetProps(int? batterId, int? pitcherId, int? venueId, string batSide, string pitchHand, string batterPosition, string pitcherPosition)
        {
            var path = "/api/v1/props/play/predictions";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (batterId != null) queryParams.Add("batterId", ApiClient.ParameterToString(batterId)); // query parameter
            if (pitcherId != null) queryParams.Add("pitcherId", ApiClient.ParameterToString(pitcherId)); // query parameter
            if (venueId != null) queryParams.Add("venueId", ApiClient.ParameterToString(venueId)); // query parameter
            if (batSide != null) queryParams.Add("batSide", ApiClient.ParameterToString(batSide)); // query parameter
            if (pitchHand != null) queryParams.Add("pitchHand", ApiClient.ParameterToString(pitchHand)); // query parameter
            if (batterPosition != null) queryParams.Add("batterPosition", ApiClient.ParameterToString(batterPosition)); // query parameter
            if (pitcherPosition != null) queryParams.Add("pitcherPosition", ApiClient.ParameterToString(pitcherPosition)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetProps: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetProps: " + response.ErrorMessage, response.ErrorMessage);

            return (Object)ApiClient.Deserialize(response.Content, typeof(Object), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get play-level predictions based on input scenarios This endpoint allows you to get play-level predictions based on input scenarios
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <returns>Object</returns>
        public Object GetPropsAdjust(int? gamePk)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling GetPropsAdjust");

            var path = "/api/v1/props/play/predictions/adjust";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (gamePk != null) queryParams.Add("gamePk", ApiClient.ParameterToString(gamePk)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "bearerAuth" };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetPropsAdjust: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetPropsAdjust: " + response.ErrorMessage, response.ErrorMessage);

            return (Object)ApiClient.Deserialize(response.Content, typeof(Object), (IList<Parameter>)response.Headers);
        }
    }
}