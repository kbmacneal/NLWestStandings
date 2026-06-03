# 01-fix-solution-build: Resolve .NET 10 build and test regressions

Investigate current compile failures introduced by the .NET 10 upgrade and apply a coordinated fix pass across impacted projects, with emphasis on shared contracts used by the Blazor WebAssembly client and server host. This includes reconciling framework/API changes, adjusting project/package usage where needed, and addressing warning debt in touched projects so the solution returns to a warning-free state for modified code.

The work covers all affected projects together (all-at-once) to avoid partial fixes that leave cross-project references broken. Validation must include full-solution build and relevant tests so runtime-critical upgrade issues are surfaced before task completion.

## Scope Inventory

- **Projects affected**: NLWestStandings.Client (confirmed compile failures in Razor components).
- **Distinct concerns**: MudBlazor API surface change in `Color` enum helper usage inside component styling helpers.
- **Change signals**: Full solution build fails with `CS1061` in `Pages/Calendar.razor` and `Pages/PostSeason.razor` because `Color.ToDescriptionString()` is no longer available.
- **Skill matches applied**: `building-projects` used for solution-level validation workflow; package/TFM management skills reviewed and not needed for current errors.

## Research Findings

- Build output shows identical failure pattern in two Blazor pages: `private string GetColor(Color color) => $"var(--mud-palette-{color.ToDescriptionString()})";`.
- The issue is source-level API usage, not a package resolution failure (MudBlazor package restores successfully).
- Fastest safe remediation is to replace removed helper usage with a compatible string mapping approach in both components, then re-run full build and warnings check.

**Done when**: Full solution builds successfully with zero errors; warnings are resolved in touched projects; affected tests pass; task progress details capture file-level changes and validation results.
