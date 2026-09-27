# Copilot Instructions for NLWestStandings

## Build & Run

- Restore/build solution: `dotnet build NLWestStandings.sln`
- Run with Aspire host (full topology — spins up the server app): `dotnet run --project NLWestStandings.AppHost`
- Run web app directly: `dotnet run --project NLWestStandings/NLWestStandings.csproj`
- Container run: `docker-compose -f docker-compose.yaml up`

There are no test projects in this repository. If you add one, wire it into solution-level build/test commands here.

If the app is already running when you rebuild, `dotnet build` will fail with `MSB3027`/`MSB3021` file-lock errors on `NLWestStandings.Client.dll` — stop the running process first.

## Architecture

This is a .NET Aspire-orchestrated Blazor app with **two render modes coexisting in one app**, which is the main thing to understand before editing pages:

- `NLWestStandings` (server project) hosts `NLWestStandings.Components.App`/`Routes`, maps Razor components with `.AddInteractiveServerRenderMode().AddInteractiveWebAssemblyRenderMode()`, and also hosts long-lived server-side pieces: `StandingsService` (a `BackgroundService`) and `StandingsHub` (a SignalR hub at `/broadcaststandings`).
- `NLWestStandings.Client` contains almost all user-facing pages/components. Each page opts into a render mode explicitly via `@rendermode` — most content pages use `@rendermode InteractiveWebAssembly` (they run entirely client-side and call the MLB Stats API directly via Flurl), while shell/chrome components (`Drawer.razor`, `NavMenu.razor`, `MudProviders.razor`) use `@rendermode InteractiveServer` and live in `NLWestStandings/Components/Pages`.
- `NLWestStandings.AppHost` is the .NET Aspire entry point (`builder.AddProject<Projects.NLWestStandings>(...)`) used both for local `dotnet run` orchestration and the `azd`/Azure Container Apps deploy path (see `azure.yaml`).
- `NLWestStandings.ServiceDefaults` provides shared Aspire wiring (OpenTelemetry, health checks, service discovery, HTTP resilience) via `AddServiceDefaults()`, called from `Program.cs`.

Data flow for standings: `StandingsService` polls the MLB Stats API (`statsapi.mlb.com`) every 6 hours in a loop, holds the latest NL/AL standings and season calendar in memory, and pushes updates to all connected clients over SignalR (`broadcastnl`/`broadcastal` events via `StandingsHub`). Client pages otherwise call the MLB Stats API directly for anything not covered by the hub (rosters, play-by-play, transactions, postseason schedule, etc.) using the generated `StatsAPI.Client`.

Dark mode: `Drawer.razor` (server-rendered, always present) owns `is_dark_mode`, persists it to `Blazored.LocalStorage` under key `CurrentMode`, and calls `nlwestTheme.setDarkMode` (in `wwwroot/theme-mode.js`) to toggle an `app-dark-mode` class on `<body>`. Team/theme logos must react to that CSS class rather than baking in a light/dark choice at data-fetch time — use the `<ThemeLogo>` component (renders both light and dark `<MudImage>` variants; CSS in `app.css` shows/hides based on `.app-dark-mode`/`.mud-theme-dark`), not `SVGLogo.GetLogo(...)` directly in `@code` blocks, since that couples logo selection to render timing and can desync from the live theme.

## Key Conventions

- Keep app startup changes in `NLWestStandings/Program.cs` cohesive: DI registration, middleware, hub mapping, and component render modes are all centralized there.
- `StandingsService` is the long-running background refresh loop — preserve cancellation-token-aware behavior (`stoppingToken`) and avoid adding blocking calls inside `ExecuteAsync`.
- SignalR updates flow through `/broadcaststandings` and hub methods in `NLWestStandings/Classes/StandingsHub.cs`; hub methods that read live state pull it from `StandingsService` via `services.CreateScope()`, not by caching state on the hub itself.
- Team logos: resolve via `SVGLogo.GetLogo(teamName, darkMode)` (matches on partial/alternate team names, e.g. "D-backs", "Athletics") — prefer the `<ThemeLogo TeamName="..." />` component in markup instead of calling `SVGLogo.GetLogo` directly, per the dark-mode note above.
- Treat `NLWestStandings.Client/Classes/StatsAPI.cs` and everything under `NLWestStandings.Client/Classes/StatsAPI/` as generated code — do not hand-edit unless explicitly required. The source is `NLWestStandings.Client/Classes/statsapi.nswag`; regenerate with `nswag run NLWestStandings.Client/Classes/statsapi.nswag` (if NSwag CLI is installed) and call out the regeneration in your change summary.
- Prefer existing packages/patterns already used in the codebase (MudBlazor, Flurl/Flurl.Http, SignalR, Serilog, Blazored.LocalStorage) before introducing new libraries.
- Do not commit `bin/` or `obj/` outputs.

## Deployment & Infra References

- Azure Developer CLI project config: `azure.yaml`
- Azure deployment workflow and troubleshooting: `next-steps.md`
- Local/container setup: `docker-compose.yaml`, `Dockerfile`

When working on deployment-related tasks, follow existing `azd`/Aspire wiring rather than inventing parallel scripts.

## MCP Servers

`.vscode/mcp.json` configures the Playwright MCP server for in-browser verification of Blazor pages (e.g. confirming dark-mode/logo state, clicking through nav) without a manual test pass. Prefer it over ad-hoc `curl`/`Invoke-WebRequest` checks for anything that depends on client-side rendering, SignalR pushes, or `localStorage`.

## Custom Agents

Two repo-defined custom agents exist under `.github/agents/` for UI work:
- **UI Audit ReadOnly** — read-only UX/accessibility review of Razor pages, no code edits.
- **UI Modernizer** — implements UI/styling changes in `NLWestStandings.Client` Razor pages and CSS; explicitly must not touch `@code` logic or `StatsAPI.cs` without approval.

## Agent Execution Checklist

- Confirm scope first: app host, server app, client app, or shared defaults.
- Edit only the minimal files needed for the request.
- Build the affected project (or solution for cross-project changes) — stop any running `dotnet run` process first to avoid file locks.
- If changing runtime behavior (hub/background service/startup/dark-mode theming), include a brief manual verification note (e.g. what you checked in-browser).
