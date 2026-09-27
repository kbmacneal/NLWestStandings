# NLWestStandings

A live MLB standings and schedule dashboard built with Blazor (server + WebAssembly) and .NET Aspire. Originally focused on the NL West, it now covers all MLB divisions with real-time standings, calendars, box scores, rosters, and postseason schedules.

Data is sourced from the public [MLB Stats API](https://statsapi.mlb.com).

## Features

- **Live standings** for every MLB division (NL/AL West, Central, East), refreshed server-side every 6 hours and pushed to connected clients over SignalR.
- **Game calendars** — season, today/yesterday/tomorrow, and postseason — with logo-driven matchup cells that link to box scores.
- **Game detail view** with live play-by-play, line score, and probable pitchers.
- **Team rosters and transactions.**
- **Postseason ranks** and schedule.
- **Light/dark theme** toggle, persisted per-browser via local storage.

## Architecture

This is a .NET Aspire solution with four projects:

| Project | Role |
|---|---|
| `NLWestStandings.AppHost` | .NET Aspire app host; orchestrates the server project locally and describes the deployment topology used by `azd`. |
| `NLWestStandings` | ASP.NET Core host: Razor Components entry point, SignalR hub (`StandingsHub`), and the `StandingsService` background worker that polls the MLB Stats API and broadcasts standings updates. |
| `NLWestStandings.Client` | Blazor WebAssembly project containing nearly all user-facing pages/components. Most pages run `InteractiveWebAssembly` and call the MLB Stats API directly; app chrome (nav drawer, dark-mode toggle) runs `InteractiveServer`. |
| `NLWestStandings.ServiceDefaults` | Shared Aspire building blocks (OpenTelemetry, health checks, service discovery, HTTP resilience). |

Standings flow: `StandingsService` (a `BackgroundService`) fetches NL/AL standings and the season calendar from the MLB Stats API, holds the latest results in memory, and pushes updates to all connected clients over the `/broadcaststandings` SignalR hub. Everything else (rosters, play-by-play, transactions, postseason schedules) is fetched directly from the MLB Stats API by client pages via a generated API client (`NLWestStandings.Client/Classes/StatsAPI.cs`, generated from `statsapi.nswag` — do not hand-edit).

For day-to-day conventions and more implementation detail, see [`.github/copilot-instructions.md`](.github/copilot-instructions.md).

## Getting Started

### Prerequisites

- .NET 10 SDK
- (Optional) Docker, for container-based runs
- (Optional) [Azure Developer CLI (`azd`)](https://learn.microsoft.com/azure/developer/azure-developer-cli/), for cloud deployment

### Run locally

Build the solution:

```powershell
dotnet build NLWestStandings.sln
```

Run with the Aspire app host (recommended — orchestrates the full topology):

```powershell
dotnet run --project NLWestStandings.AppHost
```

Or run the web app directly:

```powershell
dotnet run --project NLWestStandings/NLWestStandings.csproj
```

### Run with Docker

```powershell
docker-compose -f docker-compose.yaml up
```

Pre-built images are published to Docker Hub at [`kbmacneal/nlweststandings`](https://hub.docker.com/r/kbmacneal/nlweststandings):

```powershell
docker run -p 8089:8080 -p 8090:8081 kbmacneal/nlweststandings:latest
```

### Releasing a new Docker image

Pushing a tag matching `v*.*.*` (e.g. `v1.1.0`) triggers `.github/workflows/docker-release.yml`, which builds the image from `Dockerfile` and pushes `latest`, `<major>.<minor>`, and the full version tag to Docker Hub. The workflow requires the repository secrets `DOCKERHUB_USERNAME` and `DOCKERHUB_TOKEN`. You can also trigger it manually via `workflow_dispatch`.

## Deployment

This repo is set up for deployment to Azure Container Apps via the Azure Developer CLI:

```powershell
azd up
```

See [`azure.yaml`](azure.yaml) for the project configuration and [`next-steps.md`](next-steps.md) for the full provisioning/deployment walkthrough and troubleshooting steps.

## Contributing

There are currently no dedicated test projects. If you add one, wire it into solution-level build/test commands and update the documentation.

Two repo-defined Copilot agents (under `.github/agents/`) are available for UI-focused work in VS Code / Copilot Chat:

- **UI Audit ReadOnly** — read-only UX/accessibility review with no code changes.
- **UI Modernizer** — implements styling/UX changes in the Blazor client.

## License

See [`LICENSE.txt`](LICENSE.txt).