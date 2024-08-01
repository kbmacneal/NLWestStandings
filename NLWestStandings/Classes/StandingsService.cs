using Flurl.Http;
using Microsoft.AspNetCore.SignalR;

namespace NLWestStandings.Classes
{
    public class StandingsService(IHubContext<StandingsHub> context, IServiceProvider services) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using(var scope = services.CreateScope())
            {
                //var hub = scope.ServiceProvider.GetRequiredService<StandingsHub>();

                while (!stoppingToken.IsCancellationRequested)
                {
                    var t = await GetStandingsAsync();

                    var nlwest = t.records.First(e => e.division.id == 203).teamRecords;

                    await context.Clients.All.SendAsync("broadcast", System.Text.Json.JsonSerializer.Serialize(nlwest), stoppingToken);

                    Console.WriteLine("broadcasted");

                    await Task.Delay(TimeSpan.FromSeconds(20), stoppingToken);
                }
            }
           
        }

        private async Task<Standing> GetStandingsAsync()
        {
            var standings = await "https://statsapi.mlb.com/api/v1/standings?leagueId=104"
                .GetJsonAsync<Standing>();

            return standings;
        }
    }
}