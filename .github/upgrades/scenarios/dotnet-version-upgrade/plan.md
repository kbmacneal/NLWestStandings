# .NET Version Upgrade Plan

## Overview

**Target**: Resolve remaining .NET 10 build errors and restore a clean build/test state for the full NLWestStandings solution.
**Scope**: 4 SDK-style projects (Blazor WebAssembly client, ASP.NET Core host, Aspire AppHost, and ServiceDefaults).

### Selected Strategy
**All-At-Once** — All projects upgraded simultaneously in a single operation.
**Rationale**: The solution is already on net10.0 across all projects with no assessment-reported package/API blockers; remaining work is a coordinated, cross-solution compile-fix pass.

## Tasks

### 01-fix-solution-build: Resolve .NET 10 build and test regressions

Investigate current compile failures introduced by the .NET 10 upgrade and apply a coordinated fix pass across impacted projects, with emphasis on shared contracts used by the Blazor WebAssembly client and server host. This includes reconciling framework/API changes, adjusting project/package usage where needed, and addressing warning debt in touched projects so the solution returns to a warning-free state for modified code.

The work covers all affected projects together (all-at-once) to avoid partial fixes that leave cross-project references broken. Validation must include full-solution build and relevant tests so runtime-critical upgrade issues are surfaced before task completion.

**Done when**: Full solution builds successfully with zero errors; warnings are resolved in touched projects; affected tests pass; task progress details capture file-level changes and validation results.
