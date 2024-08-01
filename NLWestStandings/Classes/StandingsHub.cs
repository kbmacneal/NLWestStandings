using Microsoft.AspNetCore.SignalR;
using NLWestStandings.MLB;

namespace NLWestStandings.Classes
{
    public class StandingsHub(IServiceProvider services) : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("broadcast", message);
        }

        public async Task<string> BroadcastToConnection(string connectionId)
        {
            using (var scope = services.CreateScope())
            {
                var standings = scope.ServiceProvider.GetRequiredService<StandingsService>();

                return System.Text.Json.JsonSerializer.Serialize(standings._teams);
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
    }
}   