using Blazored.LocalStorage;
using Microsoft.AspNetCore.ResponseCompression;
using MudBlazor.Services;
using NLWestStandings.Classes;
using NLWestStandings.Components;
using Serilog;
using Serilog.Context;

namespace NLWestStandings
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            try
            {
                var builder = WebApplication.CreateBuilder(args);
                builder.AddServiceDefaults();

                Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(builder.Configuration)
                    .Enrich.FromLogContext()
                    .CreateBootstrapLogger();

                builder.Host.UseSerilog((context, services, configuration) =>
                {
                    configuration
                        .ReadFrom.Configuration(context.Configuration)
                        .ReadFrom.Services(services)
                        .Enrich.FromLogContext()
                        .Enrich.WithProperty("Application", "NLWestStandings")
                        .Enrich.WithProperty("Environment", context.HostingEnvironment.EnvironmentName)
                        .Enrich.WithProperty("CorrelationId", "-");
                });

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

                builder.Services.AddMudPopoverService();

                builder.Services.AddSignalR(options =>
                {
                    options.EnableDetailedErrors = true;
                });

                builder.Services.AddResponseCompression(opts =>
                {
                    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                        ["application/octet-stream"]);
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

                builder.Services.AddSingleton<StandingsService>();
                builder.Services.AddSingleton<IHostedService>(p => p.GetRequiredService<StandingsService>());

                var app = builder.Build();

                app.MapDefaultEndpoints();

                app.Use(async (httpContext, next) =>
                {
                    const string CorrelationHeaderName = "X-Correlation-ID";

                    var correlationId = httpContext.Request.Headers.TryGetValue(CorrelationHeaderName, out var incomingCorrelation)
                        && !string.IsNullOrWhiteSpace(incomingCorrelation)
                        ? incomingCorrelation.ToString()
                        : Guid.NewGuid().ToString("n");

                    httpContext.TraceIdentifier = correlationId;
                    httpContext.Response.Headers[CorrelationHeaderName] = correlationId;

                    using (LogContext.PushProperty("CorrelationId", correlationId))
                    {
                        await next().ConfigureAwait(false);
                    }
                });

                app.UseSerilogRequestLogging(options =>
                {
                    options.EnrichDiagnosticContext = (diagnosticContext, httpContext) =>
                    {
                        diagnosticContext.Set("CorrelationId", httpContext.TraceIdentifier);
                        diagnosticContext.Set("RequestHost", httpContext.Request.Host.Value ?? string.Empty);
                        diagnosticContext.Set("RequestScheme", httpContext.Request.Scheme);
                        diagnosticContext.Set("UserAgent", httpContext.Request.Headers.UserAgent.ToString());
                        diagnosticContext.Set("RemoteIpAddress", httpContext.Connection.RemoteIpAddress?.ToString() ?? string.Empty);
                    };

                    options.GetLevel = (httpContext, elapsed, ex) =>
                    {
                        if (ex is not null || httpContext.Response.StatusCode >= 500)
                        {
                            return Serilog.Events.LogEventLevel.Error;
                        }

                        if (httpContext.Response.StatusCode >= 400)
                        {
                            return Serilog.Events.LogEventLevel.Warning;
                        }

                        return Serilog.Events.LogEventLevel.Information;
                    };
                });

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
                app.MapStaticAssets();

                app.MapGet("/", () => Results.Redirect("/standings", permanent: false));
                app.MapGet("/home", () => Results.Redirect("/standings", permanent: false));

                app.MapRazorComponents<App>()
                    .AddInteractiveServerRenderMode()
                    .AddInteractiveWebAssemblyRenderMode()
                    .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

                Log.Information("Starting web application");
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