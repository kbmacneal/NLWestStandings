﻿using Microsoft.AspNetCore.SignalR;
using MoreLinq;
using NLWestStandings.Client.Classes.Calendar;

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

        public async Task<string> GetCalendar(string connectionId, string teamid)
        {
            using (var scope = services.CreateScope())
            {
                var standings = scope.ServiceProvider.GetRequiredService<StandingsService>();

                var rtn = new List<Game>(); ;

                foreach (var item in standings.calendar.dates)
                {
                    foreach (var game in item.games)
                    {
                        if (game.teams.away.team.id == Int32.Parse(teamid) || game.teams.home.team.id == Int32.Parse(teamid))
                        {
                            rtn.Add(game);
                        }
                    }
                }

                return System.Text.Json.JsonSerializer.Serialize(rtn);
            }
        }

        public async Task<string> GetTodayCalendar(string connectionId)
        {
            using (var scope = services.CreateScope())
            {
                var standings = scope.ServiceProvider.GetRequiredService<StandingsService>();

                var rtn = new List<Game>(); ;

                foreach (var item in standings.calendar.dates)
                {
                    foreach (var game in item.games)
                    {
                        if (game.officialDate == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            rtn.Add(game);
                        }
                    }
                }

                return System.Text.Json.JsonSerializer.Serialize(rtn);
            }
        }
    }
}