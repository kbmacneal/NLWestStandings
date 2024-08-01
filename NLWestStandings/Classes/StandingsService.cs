using Flurl.Http;
using Microsoft.AspNetCore.SignalR;
using NLWestStandings.Client.Classes;
using NLWestStandings.MLB;

namespace NLWestStandings.Classes
{
    public class StandingsService(IHubContext<StandingsHub> context, IServiceProvider services, ILogger<StandingsService> logger) : BackgroundService
    {
        public IEnumerable<Teamrecord>? _teams { get; set; } = null;
        public Logos? _logos { get; set; } = null;
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logos = await GetLogoLinks();

            using(var scope = services.CreateScope())
            {
                //var hub = scope.ServiceProvider.GetRequiredService<StandingsHub>();

                while (!stoppingToken.IsCancellationRequested)
                {
                    var t = await GetStandingsAsync();

                    _teams = t.records.First(e => e.division.id == 203).teamRecords;

                    await context.Clients.All.SendAsync("broadcast", System.Text.Json.JsonSerializer.Serialize(_teams), stoppingToken);

                    logger.LogInformation("Standings refreshed");

                    await Task.Delay(TimeSpan.FromHours(6), stoppingToken);
                }
            }
           
        }

        private async Task<Standing> GetStandingsAsync()
        {
            var standings = await "https://statsapi.mlb.com/api/v1/standings?leagueId=104"
                .GetJsonAsync<Standing>();

            return standings;///api/v1/teams/119
        }

        private async Task<Logos> GetLogoLinks()
        {
                var logos = await "https://site.api.espn.com/apis/site/v2/sports/baseball/mlb/teams"
                    .GetJsonAsync<Logos>();

                return logos;
        }
    }
}