using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWeatherApi
    {
        /// <summary>
        /// Get basic weather for a venue. Returns a json file containing basic weather for a specific venue.
        /// </summary>
        /// <param name="venueId">Unique Venue Identifier</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>BasicWeatherWrapperRestObject</returns>
        BasicWeatherWrapperRestObject WeatherBasic(int? venueId, List<string> fields);

        /// <summary>
        /// Get the raw field weather data. Returns a json file containing weather for the current play.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="playId">Unique identifier for a play within a game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>PlayWeatherWrapperRestObject</returns>
        PlayWeatherWrapperRestObject WeatherDataBasedOnPlay(int? gamePk, string playId, List<string> fields);

        /// <summary>
        /// Get the weather forecast for a game. Returns a json file containing the weather forecast for a specific game.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="roofType">Venue roof type</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ForecastWeatherWrapperRestObject</returns>
        ForecastWeatherWrapperRestObject WeatherForecast(int? gamePk, RoofType roofType, List<string> fields);

        /// <summary>
        /// Get full weather for a venue. Returns a json file containing full weather for a specific venue.
        /// </summary>
        /// <param name="venueId">Unique Venue Identifier</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>FullWeatherWrapperRestObject</returns>
        FullWeatherWrapperRestObject WeatherFull(int? venueId, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WeatherApi : IWeatherApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WeatherApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WeatherApi(String basePath)
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
        /// Get basic weather for a venue. Returns a json file containing basic weather for a specific venue.
        /// </summary>
        /// <param name="venueId">Unique Venue Identifier</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>BasicWeatherWrapperRestObject</returns>
        public BasicWeatherWrapperRestObject WeatherBasic(int? venueId, List<string> fields)
        {
            // verify the required parameter 'venueId' is set
            if (venueId == null) throw new ApiException(400, "Missing required parameter 'venueId' when calling WeatherBasic");

            var path = "/api/v1/weather/venues/{venueId}/basic";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "venueId" + "}", ApiClient.ParameterToString(venueId));

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
                throw new ApiException((int)response.StatusCode, "Error calling WeatherBasic: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling WeatherBasic: " + response.ErrorMessage, response.ErrorMessage);

            return (BasicWeatherWrapperRestObject)ApiClient.Deserialize(response.Content, typeof(BasicWeatherWrapperRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get the raw field weather data. Returns a json file containing weather for the current play.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="playId">Unique identifier for a play within a game</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>PlayWeatherWrapperRestObject</returns>
        public PlayWeatherWrapperRestObject WeatherDataBasedOnPlay(int? gamePk, string playId, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling WeatherDataBasedOnPlay");
            // verify the required parameter 'playId' is set
            if (playId == null) throw new ApiException(400, "Missing required parameter 'playId' when calling WeatherDataBasedOnPlay");

            var path = "/api/v1/weather/game/{gamePk}/{playId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));
            path = path.Replace("{" + "playId" + "}", ApiClient.ParameterToString(playId));

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
                throw new ApiException((int)response.StatusCode, "Error calling WeatherDataBasedOnPlay: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling WeatherDataBasedOnPlay: " + response.ErrorMessage, response.ErrorMessage);

            return (PlayWeatherWrapperRestObject)ApiClient.Deserialize(response.Content, typeof(PlayWeatherWrapperRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get the weather forecast for a game. Returns a json file containing the weather forecast for a specific game.
        /// </summary>
        /// <param name="gamePk">Unique Primary Key Representing a Game</param>
        /// <param name="roofType">Venue roof type</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>ForecastWeatherWrapperRestObject</returns>
        public ForecastWeatherWrapperRestObject WeatherForecast(int? gamePk, RoofType roofType, List<string> fields)
        {
            // verify the required parameter 'gamePk' is set
            if (gamePk == null) throw new ApiException(400, "Missing required parameter 'gamePk' when calling WeatherForecast");
            // verify the required parameter 'roofType' is set
            if (roofType == null) throw new ApiException(400, "Missing required parameter 'roofType' when calling WeatherForecast");

            var path = "/api/v1/weather/game/{gamePk}/forecast/{roofType}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gamePk" + "}", ApiClient.ParameterToString(gamePk));
            path = path.Replace("{" + "roofType" + "}", ApiClient.ParameterToString(roofType));

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
                throw new ApiException((int)response.StatusCode, "Error calling WeatherForecast: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling WeatherForecast: " + response.ErrorMessage, response.ErrorMessage);

            return (ForecastWeatherWrapperRestObject)ApiClient.Deserialize(response.Content, typeof(ForecastWeatherWrapperRestObject), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Get full weather for a venue. Returns a json file containing full weather for a specific venue.
        /// </summary>
        /// <param name="venueId">Unique Venue Identifier</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>FullWeatherWrapperRestObject</returns>
        public FullWeatherWrapperRestObject WeatherFull(int? venueId, List<string> fields)
        {
            // verify the required parameter 'venueId' is set
            if (venueId == null) throw new ApiException(400, "Missing required parameter 'venueId' when calling WeatherFull");

            var path = "/api/v1/weather/venues/{venueId}/full";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "venueId" + "}", ApiClient.ParameterToString(venueId));

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
                throw new ApiException((int)response.StatusCode, "Error calling WeatherFull: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling WeatherFull: " + response.ErrorMessage, response.ErrorMessage);

            return (FullWeatherWrapperRestObject)ApiClient.Deserialize(response.Content, typeof(FullWeatherWrapperRestObject), (IList<Parameter>)response.Headers);
        }
    }
}