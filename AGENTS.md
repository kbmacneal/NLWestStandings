# AGENTS.md

Agent guidance for this repository. Keep changes small, verify locally, and prefer linking to existing docs over repeating them.

## Quick Start

- Restore/build solution: `dotnet build NLWestStandings.sln`
- Run with Aspire host (recommended for full app topology): `dotnet run --project NLWestStandings.AppHost`
- Run web app directly: `dotnet run --project NLWestStandings/NLWestStandings.csproj`
- Container run: `docker-compose -f docker-compose.yaml up`

There are currently no dedicated test projects in this repository. If you add tests, wire them into solution-level commands.

## Project Map

- `NLWestStandings`: ASP.NET Core host app, SignalR hub, background standings refresh service, and Razor component host.
- `NLWestStandings.Client`: Blazor WebAssembly client pages and API data models.
- `NLWestStandings.AppHost`: .NET Aspire app host used by Azure Developer CLI (`azd`) deployment flow.
- `NLWestStandings.ServiceDefaults`: shared Aspire defaults (OpenTelemetry, health checks, service discovery, HTTP resilience).

## High-Value Conventions

- Keep app startup changes in `NLWestStandings/Program.cs` cohesive: DI registration, middleware, hub mapping, and component render modes are centralized there.
- `StandingsService` is the long-running background refresh loop. Preserve cancellation-token-aware behavior and avoid adding blocking calls.
- SignalR updates flow through `/broadcaststandings` and hub methods in `NLWestStandings/Classes/StandingsHub.cs`.
- Prefer existing packages/patterns already used in the codebase (MudBlazor, Flurl, SignalR, Serilog) before introducing new libraries.

## Generated Code And Unsafe Edit Areas

- Treat `NLWestStandings.Client/Classes/StatsAPI.cs` as generated code. Do not hand-edit unless the task explicitly requires it.
- Source for API client generation is `NLWestStandings.Client/Classes/statsapi.nswag`.
- Regenerate client only when needed and call out the regeneration in your change summary.

Typical regeneration command (if NSwag CLI is installed):
- `nswag run NLWestStandings.Client/Classes/statsapi.nswag`

## Deployment And Infra References

- Azure Developer CLI project config: [azure.yaml](azure.yaml)
- Azure deployment workflow and troubleshooting: [next-steps.md](next-steps.md)
- Local/container setup: [docker-compose.yaml](docker-compose.yaml), [Dockerfile](Dockerfile)

When working on deployment-related tasks, follow existing `azd`/Aspire wiring rather than inventing parallel scripts.

## Agent Execution Checklist

- Confirm scope first: app host, server app, client app, or shared defaults.
- Edit only the minimal files needed for the request.
- Build the affected project (or solution for cross-project changes).
- If changing runtime behavior (hub/background service/startup), include a brief manual verification note.
- Do not commit `bin/` or `obj/` outputs.
