using Blazored.LocalStorage;
using Microsoft.AspNetCore.ResponseCompression;
using MudBlazor.Services;
using NLWestStandings.Classes;
using NLWestStandings.Client.Classes;
using NLWestStandings.Components;
using Serilog;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NLWestStandings
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            try
            {
                var builder = WebApplication.CreateBuilder(args);

                Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.Async(e => e.Console())
                    .CreateLogger();

                // Add services to the container.
                builder.Services.AddRazorComponents()
                    .AddInteractiveServerComponents()
                    .AddInteractiveWebAssemblyComponents();

                builder.Services.AddBlazoredLocalStorage();

                //builder.Services.AddSingleton<Logos>(System.Text.Json.JsonSerializer.Deserialize<Logos>(File.ReadAllText(System.IO.Path.Combine("wwwroot", "logos.json"))));

                builder.Services.AddMudServices(options =>
                {
                    options.PopoverOptions.ThrowOnDuplicateProvider = false;
                });

                builder.Services.AddSignalR(options =>
                {
                    options.EnableDetailedErrors = true;
                });

                builder.Services.AddResponseCompression(opts =>
                {
                    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                        ["application/octet-stream"]);
                });

                builder.Services.AddSingleton<StandingsService>();
                builder.Services.AddSingleton<IHostedService>(p => p.GetRequiredService<StandingsService>());

                builder.Services.AddSerilog();

                var app = builder.Build();

                app.UseSerilogRequestLogging();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseWebAssemblyDebugging();
                }
                else
                {
                    app.UseExceptionHandler("/Error");
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
                }

                app.UseResponseCompression();

                app.MapHub<StandingsHub>("/broadcaststandings");

                //app.UseHttpsRedirection();

                app.UseStaticFiles();
                app.UseAntiforgery();

                app.MapRazorComponents<App>()
                    .AddInteractiveServerRenderMode()
                    .AddInteractiveWebAssemblyRenderMode()
                    .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

                app.Run();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Something went wrong");
            }
            finally
            {
                await Log.CloseAndFlushAsync().ConfigureAwait(false);
            }
        }
    }
}