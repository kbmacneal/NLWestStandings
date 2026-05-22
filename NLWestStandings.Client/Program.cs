using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using NLWestStandings.Client.Classes;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//builder.Services.AddSingleton<Logos>(System.Text.Json.JsonSerializer.Deserialize<Logos>(File.ReadAllText(System.IO.Path.Combine("wwwroot", "logos.json"))));

builder.Services.AddBlazoredLocalStorageAsSingleton();

builder.Services.AddMudServices(options =>
{
    options.PopoverOptions.ThrowOnDuplicateProvider = false;
});

builder.Services.AddSingleton(
                    typeof(StatsAPI.Client), o =>
                    {
                        var statsClient = new StatsAPI.Client(new HttpClient())
                        {
                            ReadResponseAsString = true
                        };

                        return statsClient;
                    });

builder.Services.AddMudPopoverService();

await builder.Build().RunAsync().ConfigureAwait(false);