using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMilestonesApi
    {
        /// <summary>
        /// View available achievementStatus options
        /// </summary>
        /// <returns>List&lt;MilestoneAchievementType&gt;</returns>
        List<MilestoneAchievementType> AchievementStatuses();

        /// <summary>
        /// View available milestoneDurations options
        /// </summary>
        /// <returns>List&lt;MilestoneDuration&gt;</returns>
        List<MilestoneDuration> MilestoneDurations();

        /// <summary>
        /// View available milestoneLookup options
        /// </summary>
        /// <returns>Dictionary&lt;string, List&lt;Object&gt;&gt;</returns>
        Dictionary<string, List<Object>> MilestoneLookups();

        /// <summary>
        /// View available milestone statistics options
        /// </summary>
        /// <returns>List&lt;MilestoneStatisticRestObject&gt;</returns>
        List<MilestoneStatisticRestObject> MilestoneStatistics();

        /// <summary>
        /// View available milestoneType options
        /// </summary>
        /// <returns>List&lt;MilestoneType&gt;</returns>
        List<MilestoneType> MilestoneTypes();

        /// <summary>
        /// View pending and achieved milestones.
        /// </summary>
        /// <param name="orgType">Organization level. Format: T(Team), L(League), S(Sport)</param>
        /// <param name="achievementStatuses">Comma delimited list of milestone achievement types</param>
        /// <param name="milestoneTypes">Comma delimited list of milestone types</param>
        /// <param name="isLastAchievement">Filters out milestones that have already been surpassed.</param>
        /// <param name="milestoneStatistics">Comma delimited list of milestone statistics</param>
        /// <param name="milestoneValues">Comma delimited list of milestone values</param>
        /// <param name="playerIds">A unique identifier for players</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="statGroup">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="venueIds">Comma delimited list of Unique venue identifiers</param>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="showFirsts">True to show play first milestones, like first HR, first Save, etc</param>
        /// <returns>MilestoneContainerRestObject</returns>
        MilestoneContainerRestObject Milestones(OrganizationType orgType, List<MilestoneAchievementType> achievementStatuses, List<MilestoneType> milestoneTypes, bool? isLastAchievement, List<Statistic> milestoneStatistics, List<int?> milestoneValues, List<int?> playerIds, List<int?> teamIds, List<int?> leagueIds, StatGroup statGroup, string season, List<string> seasons, List<int?> venueIds, List<int?> gamePks, int? limit, List<string> fields, bool? showFirsts);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MilestonesApi : IMilestonesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MilestonesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MilestonesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MilestonesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MilestonesApi(String basePath)
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
        /// View available achievementStatus options
        /// </summary>
        /// <returns>List&lt;MilestoneAchievementType&gt;</returns>
        public List<MilestoneAchievementType> AchievementStatuses()
        {
            var path = "/api/v1/achievementStatuses";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AchievementStatuses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AchievementStatuses: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MilestoneAchievementType>)ApiClient.Deserialize(response.Content, typeof(List<MilestoneAchievementType>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View available milestoneDurations options
        /// </summary>
        /// <returns>List&lt;MilestoneDuration&gt;</returns>
        public List<MilestoneDuration> MilestoneDurations()
        {
            var path = "/api/v1/milestoneDurations";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling MilestoneDurations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling MilestoneDurations: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MilestoneDuration>)ApiClient.Deserialize(response.Content, typeof(List<MilestoneDuration>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View available milestoneLookup options
        /// </summary>
        /// <returns>Dictionary&lt;string, List&lt;Object&gt;&gt;</returns>
        public Dictionary<string, List<Object>> MilestoneLookups()
        {
            var path = "/api/v1/milestoneLookups";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling MilestoneLookups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling MilestoneLookups: " + response.ErrorMessage, response.ErrorMessage);

            return (Dictionary<string, List<Object>>)ApiClient.Deserialize(response.Content, typeof(Dictionary<string, List<Object>>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View available milestone statistics options
        /// </summary>
        /// <returns>List&lt;MilestoneStatisticRestObject&gt;</returns>
        public List<MilestoneStatisticRestObject> MilestoneStatistics()
        {
            var path = "/api/v1/milestoneStatistics";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling MilestoneStatistics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling MilestoneStatistics: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MilestoneStatisticRestObject>)ApiClient.Deserialize(response.Content, typeof(List<MilestoneStatisticRestObject>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View available milestoneType options
        /// </summary>
        /// <returns>List&lt;MilestoneType&gt;</returns>
        public List<MilestoneType> MilestoneTypes()
        {
            var path = "/api/v1/milestoneTypes";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling MilestoneTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling MilestoneTypes: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MilestoneType>)ApiClient.Deserialize(response.Content, typeof(List<MilestoneType>), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// View pending and achieved milestones.
        /// </summary>
        /// <param name="orgType">Organization level. Format: T(Team), L(League), S(Sport)</param>
        /// <param name="achievementStatuses">Comma delimited list of milestone achievement types</param>
        /// <param name="milestoneTypes">Comma delimited list of milestone types</param>
        /// <param name="isLastAchievement">Filters out milestones that have already been surpassed.</param>
        /// <param name="milestoneStatistics">Comma delimited list of milestone statistics</param>
        /// <param name="milestoneValues">Comma delimited list of milestone values</param>
        /// <param name="playerIds">A unique identifier for players</param>
        /// <param name="teamIds">Comma delimited list of Unique Team identifiers</param>
        /// <param name="leagueIds">Comma delimited list of Unique league identifiers</param>
        /// <param name="statGroup">Category of statistic to return. Available types in /api/v1/statGroups</param>
        /// <param name="season">Season of play</param>
        /// <param name="seasons">Comma delimited list of Seasons of play</param>
        /// <param name="venueIds">Comma delimited list of Unique venue identifiers</param>
        /// <param name="gamePks">Comma delimited list of unique primary keys</param>
        /// <param name="limit">Number of results to return</param>
        /// <param name="fields">Comma delimited list of specific fields to be returned. Format: topLevelNode, childNode, attribute</param>
        /// <param name="showFirsts">True to show play first milestones, like first HR, first Save, etc</param>
        /// <returns>MilestoneContainerRestObject</returns>
        public MilestoneContainerRestObject Milestones(OrganizationType orgType, List<MilestoneAchievementType> achievementStatuses, List<MilestoneType> milestoneTypes, bool? isLastAchievement, List<Statistic> milestoneStatistics, List<int?> milestoneValues, List<int?> playerIds, List<int?> teamIds, List<int?> leagueIds, StatGroup statGroup, string season, List<string> seasons, List<int?> venueIds, List<int?> gamePks, int? limit, List<string> fields, bool? showFirsts)
        {
            var path = "/api/v1/milestones";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (orgType != null) queryParams.Add("orgType", ApiClient.ParameterToString(orgType)); // query parameter
            if (achievementStatuses != null) queryParams.Add("achievementStatuses", ApiClient.ParameterToString(achievementStatuses)); // query parameter
            if (milestoneTypes != null) queryParams.Add("milestoneTypes", ApiClient.ParameterToString(milestoneTypes)); // query parameter
            if (isLastAchievement != null) queryParams.Add("isLastAchievement", ApiClient.ParameterToString(isLastAchievement)); // query parameter
            if (milestoneStatistics != null) queryParams.Add("milestoneStatistics", ApiClient.ParameterToString(milestoneStatistics)); // query parameter
            if (milestoneValues != null) queryParams.Add("milestoneValues", ApiClient.ParameterToString(milestoneValues)); // query parameter
            if (playerIds != null) queryParams.Add("playerIds", ApiClient.ParameterToString(playerIds)); // query parameter
            if (teamIds != null) queryParams.Add("teamIds", ApiClient.ParameterToString(teamIds)); // query parameter
            if (leagueIds != null) queryParams.Add("leagueIds", ApiClient.ParameterToString(leagueIds)); // query parameter
            if (statGroup != null) queryParams.Add("statGroup", ApiClient.ParameterToString(statGroup)); // query parameter
            if (season != null) queryParams.Add("season", ApiClient.ParameterToString(season)); // query parameter
            if (seasons != null) queryParams.Add("seasons", ApiClient.ParameterToString(seasons)); // query parameter
            if (venueIds != null) queryParams.Add("venueIds", ApiClient.ParameterToString(venueIds)); // query parameter
            if (gamePks != null) queryParams.Add("gamePks", ApiClient.ParameterToString(gamePks)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
            if (showFirsts != null) queryParams.Add("showFirsts", ApiClient.ParameterToString(showFirsts)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponse<object> response = (RestResponse<object>)ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling Milestones: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling Milestones: " + response.ErrorMessage, response.ErrorMessage);

            return (MilestoneContainerRestObject)ApiClient.Deserialize(response.Content, typeof(MilestoneContainerRestObject), (IList<Parameter>)response.Headers);
        }
    }
}