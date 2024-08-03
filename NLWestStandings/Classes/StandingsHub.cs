using Microsoft.AspNetCore.SignalR;

namespace NLWestStandings.Classes
{
    public class StandingsHub(IServiceProvider services, ILogger<StandingsHub> logger) : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("broadcast", message);
        }

        public async Task<string> BroadcastNLToConnection(string connectionId)
        {
            using (var scope = services.CreateScope())
            {
                var standings = scope.ServiceProvider.GetRequiredService<StandingsService>();

                return System.Text.Json.JsonSerializer.Serialize(standings.NLStandings);
            }
        }

        public async Task<string> BroadcastALToConnection(string connectionId)
        {
            using (var scope = services.CreateScope())
            {
                var standings = scope.ServiceProvider.GetRequiredService<StandingsService>();

                return System.Text.Json.JsonSerializer.Serialize(standings.ALStandings);
            }
        }

        public async Task<string> GetLogos(string connectionId)
        {
            using (var scope = services.CreateScope())
            {
                var standings = scope.ServiceProvider.GetRequiredService<StandingsService>();

                return System.Text.Json.JsonSerializer.Serialize(standings._logos);
            }
        }

        public async Task<string> GetCalendar(string connectionId)
        {
            using (var scope = services.CreateScope())
            {
                var standings = scope.ServiceProvider.GetRequiredService<StandingsService>();

                return System.Text.Json.JsonSerializer.Serialize(standings.calendar);
            }
        }
    }
}