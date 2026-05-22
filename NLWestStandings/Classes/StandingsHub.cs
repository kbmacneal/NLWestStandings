using Microsoft.AspNetCore.SignalR;
using MoreLinq;
using NLWestStandings.Client.Classes.Calendar;

namespace NLWestStandings.Classes
{
    public class StandingsHub(IServiceProvider services, ILogger<StandingsHub> logger) : Hub
    {
        public async Task SendMessage(string message)
        {
            logger.LogDebug("Broadcasting message to all clients. Length: {MessageLength}", message?.Length ?? 0);
            await Clients.All.SendAsync("broadcast", message).ConfigureAwait(false);
        }

        public Task<string> BroadcastNLToConnection(string connectionId)
        {
            using (var scope = services.CreateScope())
            {
                var standings = scope.ServiceProvider.GetRequiredService<StandingsService>();
                logger.LogDebug("NL standings requested by connection {ConnectionId}", connectionId);

                return Task.FromResult(System.Text.Json.JsonSerializer.Serialize(standings.NLStandings));
            }
        }

        public Task<string> BroadcastALToConnection(string connectionId)
        {
            using (var scope = services.CreateScope())
            {
                var standings = scope.ServiceProvider.GetRequiredService<StandingsService>();
                logger.LogDebug("AL standings requested by connection {ConnectionId}", connectionId);

                return Task.FromResult(System.Text.Json.JsonSerializer.Serialize(standings.ALStandings));
            }
        }

        //public async Task<string> GetLogos(string connectionId)
        //{
        //    using (var scope = services.CreateScope())
        //    {
        //        var standings = scope.ServiceProvider.GetRequiredService<StandingsService>();

        //        return System.Text.Json.JsonSerializer.Serialize(standings._logos);
        //    }
        //}

        public Task<string> GetCalendar(string connectionId, string teamid)
        {
            using (var scope = services.CreateScope())
            {
                var standings = scope.ServiceProvider.GetRequiredService<StandingsService>();

                var rtn = new List<Game>(); ;
                var dates = standings.calendar?.dates ?? [];

                foreach (var item in dates)
                {
                    foreach (var game in item.games)
                    {
                        if (game.teams.away.team.id == Int32.Parse(teamid) || game.teams.home.team.id == Int32.Parse(teamid))
                        {
                            rtn.Add(game);
                        }
                    }
                }

                logger.LogDebug("Calendar requested by connection {ConnectionId} for team {TeamId}. Returned {GameCount} games", connectionId, teamid, rtn.Count);
                return Task.FromResult(System.Text.Json.JsonSerializer.Serialize(rtn));
            }
        }

        public Task<string> GetTodayCalendar(string connectionId)
        {
            using (var scope = services.CreateScope())
            {
                var standings = scope.ServiceProvider.GetRequiredService<StandingsService>();

                var rtn = (standings.calendar?.dates ?? [])
                    .SelectMany(item => item.games
                        .Where(game => DateTime.SpecifyKind(game.gameDate, DateTimeKind.Utc).ToLocalTime().ToString("yyyy-MM-dd") == DateTime.Now.ToString("yyyy-MM-dd")))
                    .OrderBy(e => e.gameDate)
                    .ToList();

                logger.LogDebug("Today calendar requested by connection {ConnectionId}. Returned {GameCount} games", connectionId, rtn.Count);
                return Task.FromResult(System.Text.Json.JsonSerializer.Serialize(rtn));
            }
        }

        public override async Task OnConnectedAsync()
        {
            logger.LogInformation("Client connected to standings hub: {ConnectionId}", Context.ConnectionId);
            await base.OnConnectedAsync().ConfigureAwait(false);
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            if (exception is null)
            {
                logger.LogInformation("Client disconnected from standings hub: {ConnectionId}", Context.ConnectionId);
            }
            else
            {
                logger.LogWarning(exception, "Client disconnected from standings hub with error: {ConnectionId}", Context.ConnectionId);
            }

            await base.OnDisconnectedAsync(exception).ConfigureAwait(false);
        }
    }
}