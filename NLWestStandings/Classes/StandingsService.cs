using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.SignalR;
using NLWestStandings.Client.Classes.Calendar;
using NLWestStandings.Client.Classes.Divisions;
using NLWestStandings.MLB;

namespace NLWestStandings.Classes
{
    public class StandingsService(IHubContext<StandingsHub> context, IServiceProvider services, ILogger<StandingsService> logger) : BackgroundService
    {
        public IEnumerable<Teamrecord[]>? NLStandings { get; set; } = null;
        public IEnumerable<Teamrecord[]>? ALStandings { get; set; } = null;
        public TeamCalendar? calendar { get; set; } = null;
        //public Logos? _logos { get; set; } = null;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //_logos = await GetLogoLinks();

            calendar = await GetCalendar().ConfigureAwait(false);

            using (var scope = services.CreateScope())
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    var nl = await GetNLStandingsAsync().ConfigureAwait(false);
                    var al = await GetALStandingsAsync().ConfigureAwait(false);

                    foreach (var item in nl.records)
                    {
                        var division_id = item.division.id;

                        foreach (var item2 in item.teamRecords)
                        {
                            item2.division_name = (await "https://statsapi.mlb.com/api/v1/divisions/"
                            .AppendPathSegment(division_id.ToString())
                            .GetJsonAsync<DivisionCall>(cancellationToken: stoppingToken).ConfigureAwait(false))
                            .divisions.First().name;
                        }
                    }

                    foreach (var item in al.records)
                    {
                        var division_id = item.division.id;

                        foreach (var item2 in item.teamRecords)
                        {
                            item2.division_name = (await "https://statsapi.mlb.com/api/v1/divisions/"
                                .AppendPathSegment(division_id.ToString())
                                .GetJsonAsync<DivisionCall>(cancellationToken: stoppingToken).ConfigureAwait(false))
                                .divisions.First().name;
                        }
                    }

                    NLStandings = nl.records.Select(e => e.teamRecords);

                    ALStandings = al.records.Select(e => e.teamRecords);

                    await context.Clients.All.SendAsync("broadcastnl", System.Text.Json.JsonSerializer.Serialize(NLStandings), stoppingToken).ConfigureAwait(false);

                    await context.Clients.All.SendAsync("broadcastal", System.Text.Json.JsonSerializer.Serialize(ALStandings), stoppingToken).ConfigureAwait(false);

                    logger.LogInformation("Standings refreshed");

                    await Task.Delay(TimeSpan.FromHours(6), stoppingToken).ConfigureAwait(false);
                }
            }
        }

        private static async Task<Standing> GetNLStandingsAsync()
        {
            var standings = await "https://statsapi.mlb.com/api/v1/standings?leagueId=104"
                .GetJsonAsync<Standing>().ConfigureAwait(false);

            return standings;
        }

        private static async Task<Standing> GetALStandingsAsync()
        {
            var standings = await "https://statsapi.mlb.com/api/v1/standings?leagueId=103"
                .GetJsonAsync<Standing>().ConfigureAwait(false);

            return standings;
        }

        //private async Task<Logos> GetLogoLinks()
        //{
        //    //var logos = await "https://site.api.espn.com/apis/site/v2/sports/baseball/mlb/teams"
        //    //.GetJsonAsync<Logos>();

        //    var logos = System.Text.Json.JsonSerializer.Deserialize<Logos>(File.ReadAllText(System.IO.Path.Combine(AppContext.BaseDirectory, "wwwroot", "logos.json")));

        //    return logos;
        //}

        private async Task<TeamCalendar> GetCalendar()
        {
            var beginning_of_month = new DateOnly(DateTime.Now.Year, 1, 1);
            var end_of_month = new DateOnly(DateTime.Now.Year, 12, 1);

            var calendar = await $"https://statsapi.mlb.com/api/v1/schedule?sportId=1&startDate={beginning_of_month}&endDate={end_of_month}"
                .GetJsonAsync<TeamCalendar>().ConfigureAwait(false);

            return calendar;
        }
    }
}