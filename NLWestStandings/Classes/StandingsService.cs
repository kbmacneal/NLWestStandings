using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.SignalR;
using NLWestStandings.Client.Classes;
using NLWestStandings.Client.Classes.Divisions;
using NLWestStandings.MLB;

namespace NLWestStandings.Classes
{
    public class StandingsService(IHubContext<StandingsHub> context, IServiceProvider services, ILogger<StandingsService> logger) : BackgroundService
    {
        public IEnumerable<Teamrecord[]>? NLStandings { get; set; } = null;
        public IEnumerable<Teamrecord[]>? ALStandings { get; set; } = null;
        public Logos? _logos { get; set; } = null;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logos = await GetLogoLinks();

            using (var scope = services.CreateScope())
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    var nl = await GetNLStandingsAsync();
                    var al = await GetALStandingsAsync();

                    foreach (var item in nl.records)
                    {
                        var division_id = item.division.id;

                        foreach (var item2 in item.teamRecords)
                        {
                            item2.division_name = (await "https://statsapi.mlb.com/api/v1/divisions/"
                            .AppendPathSegment(division_id.ToString())
                            .GetJsonAsync<DivisionCall>())
                            .divisions.First().name;

                            var t = "";
                        }
                    }

                    foreach (var item in al.records)
                    {
                        var division_id = item.division.id;

                        foreach (var item2 in item.teamRecords)
                        {
                            item2.division_name = (await "https://statsapi.mlb.com/api/v1/divisions/"
                                .AppendPathSegment(division_id.ToString())
                                .GetJsonAsync<DivisionCall>())
                                .divisions.First().name;
                        }
                    }

                    NLStandings = nl.records.Select(e => e.teamRecords);

                    ALStandings = al.records.Select(e => e.teamRecords);

                    await context.Clients.All.SendAsync("broadcastnl", System.Text.Json.JsonSerializer.Serialize(NLStandings), stoppingToken);

                    await context.Clients.All.SendAsync("broadcastal", System.Text.Json.JsonSerializer.Serialize(ALStandings), stoppingToken);

                    logger.LogInformation("Standings refreshed");

                    await Task.Delay(TimeSpan.FromHours(6), stoppingToken);
                }
            }
        }

        private static async Task<Standing> GetNLStandingsAsync()
        {
            var standings = await "https://statsapi.mlb.com/api/v1/standings?leagueId=104"
                .GetJsonAsync<Standing>();

            return standings;
        }

        private static async Task<Standing> GetALStandingsAsync()
        {
            var standings = await "https://statsapi.mlb.com/api/v1/standings?leagueId=103"
                .GetJsonAsync<Standing>();

            return standings;
        }

        private async Task<Logos> GetLogoLinks()
        {
            var logos = await "https://site.api.espn.com/apis/site/v2/sports/baseball/mlb/teams"
                .GetJsonAsync<Logos>();

            return logos;
        }
    }
}