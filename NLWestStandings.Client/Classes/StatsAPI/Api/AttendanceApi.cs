using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAttendanceApi
    {
        /// <summary>
        /// Get team attendance
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="leagueId">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Comma delimited list of Seasons of play</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>AttendanceRestObject</returns>
        AttendanceRestObject GetTeamAttendance(List<int?> teamId, List<int?> leagueId, List<string> season, LeagueListsEnum leagueListId, List<GameTypeEnum> gameType, DateTime? date, DateTime? startDate, DateTime? endDate, List<string> fields);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttendanceApi : IAttendanceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendanceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AttendanceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttendanceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttendanceApi(String basePath)
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
        /// Get team attendance
        /// </summary>
        /// <param name="teamId">Unique Team Identifier. Format: 141, 147, etc</param>
        /// <param name="leagueId">Comma delimited list of Unique league identifiers</param>
        /// <param name="season">Comma delimited list of Seasons of play</param>
        /// <param name="leagueListId">Unique League List Identifier</param>
        /// <param name="gameType">Type of Game. Available types in /api/v1/gameTypes</param>
        /// <param name="date">Date of Game. Format: YYYY-MM-DD</param>
        /// <param name="startDate">Start date for range of data (must be used with end date). Format: MM/DD/YYYY</param>
        /// <param name="endDate">End date for range of data (must be used with start date). Format: MM/DD/YYYY</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <returns>AttendanceRestObject</returns>
        public AttendanceRestObject GetTeamAttendance(List<int?> teamId, List<int?> leagueId, List<string> season, LeagueListsEnum leagueListId, List<GameTypeEnum> gameType, DateTime? date, DateTime? startDate, DateTime? endDate, List<string> fields)
        {
            var path = "/api/v1/attendance";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (teamId != null) queryParams.Add("teamId", ApiClient.ParameterToString(teamId)); // query parameter
            if (leagueId != null) queryParams.Add("leagueId", ApiClient.ParameterToString(leagueId)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (leagueListId != null) queryParams.Add("leagueListId", ApiClient.ParameterToString(leagueListId)); // query parameter
            if (gameType != null) queryParams.Add("gameType", ApiClient.ParameterToString(gameType)); // query parameter
            if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
            if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetTeamAttendance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetTeamAttendance: " + response.ErrorMessage, response.ErrorMessage);

            return (AttendanceRestObject)ApiClient.Deserialize(response.Content, typeof(AttendanceRestObject), (IList<Parameter>)response.Headers);
        }
    }
}