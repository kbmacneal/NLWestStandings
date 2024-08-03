using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using NLWestStandings.Client.Classes;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices(options =>
{
    options.PopoverOptions.ThrowOnDuplicateProvider = false;
});

await builder.Build().RunAsync();