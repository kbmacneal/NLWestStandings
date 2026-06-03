
## [2026-06-03 18:53] 01-fix-solution-build

Fixed post-.NET 10 build failures in the Blazor WebAssembly client by replacing deprecated `Color.ToDescriptionString()` calls in Calendar and PostSeason pages with enum-to-lowercase palette mapping (`color.ToString().ToLowerInvariant()`). Full solution build now succeeds with zero errors. No test projects were detected in the solution, so no test run was required for this task.

