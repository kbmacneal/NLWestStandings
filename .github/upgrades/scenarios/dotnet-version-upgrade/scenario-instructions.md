# .NET Version Upgrade

## Preferences
- **Flow Mode**: Automatic
- **Target Framework**: net10.0

## Source Control
- **Source Branch**: master
- **Working Branch**: dotnet-version-upgrade-net10-fix
- **Commit Strategy**: Single Commit at End

## Upgrade Options
**Source**: .github/upgrades/scenarios/dotnet-version-upgrade/upgrade-options.md

### Strategy
- Upgrade Strategy: All-at-Once

## Strategy
**Selected**: All-At-Once
**Rationale**: 4 projects, all SDK-style and already on net10.0, with no package/API compatibility blockers; remaining work is a coordinated build-fix pass.

### Execution Constraints
- Apply project and package/code fixes in one coordinated pass across the solution (no dependency-tier phasing).
- Validate by building the full solution after fixes; do not leave partial unresolved compile errors.
- Run tests after the build is clean and resolve any test regressions before completion.
- Treat warnings in touched projects as required fixes before task completion.
