using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using NLWestStandings.Client.Classes;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//builder.Services.AddSingleton<Logos>(System.Text.Json.JsonSerializer.Deserialize<Logos>(File.ReadAllText(System.IO.Path.Combine("wwwroot", "logos.json"))));

builder.Services.AddMudServices(options =>
{
    options.PopoverOptions.ThrowOnDuplicateProvider = false;
});

await builder.Build().RunAsync();