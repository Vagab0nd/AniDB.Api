# Copilot instructions for AniDB.Api

This file gives actionable repository-specific instructions for Copilot sessions (build/test/lint commands, architecture overview, and repository conventions).

---

## Build, test, and lint (runnable commands)
- Restore: `dotnet restore` (run from repo root)
- Build: `dotnet build --no-restore` (solution: `AniDb.Api.sln`)
- Test (full suite):
  - `dotnet test --no-build --verbosity normal`
  - CI runs tests with credentials supplied via secrets; tests expect runsettings in `AniDb.Api.Http.Test\settings.runsettings`.
- Run a single test (project-level):
  - Example (pass credentials if needed):
    `dotnet test AniDb.Api.Http.Test\AniDb.Api.Http.Test.csproj --no-build --settings AniDb.Api.Http.Test\settings.runsettings -- TestRunParameters.Parameter(name="Username",value="MY_USER") TestRunParameters.Parameter(name="Password",value="MY_PASS") --filter FullyQualifiedName~Namespace.ClassName.MethodName`
  - Or filter by display name / trait: `--filter "DisplayName~SomeName"` or `--filter "FullyQualifiedName~MethodName"`.

Notes:
- Directory.Build.props configures `TargetFrameworks` to `net8.0`, `Nullable` and `ImplicitUsings` enabled.
- There is no separate linter binary; repository uses .editorconfig and MSBuild analyzers. Builds treat warnings as errors (`TreatWarningsAsErrors=true`).

---

## High-level architecture
- Root solution: `AniDb.Api.sln`.
- Meta package `AniDb.Api` is a packaging project that references two functional libraries:
  - `AniDb.Api.Http` — HTTP wrapper for AniDB (depends on `AniDb.Api.Core`, uses Flurl.Http and Flurl.Http.Xml).
  - `AniDb.Api.Udp` — UDP wrapper (references `AniDb.Api.Core`).
- `AniDb.Api.Core` — shared DTOs, contracts and core utilities used by both HTTP and UDP implementations.
- Packaging: each project is configured to generate NuGet packages on build (`GeneratePackageOnBuild=true`) and includes README and logo for the package.
- Tests:
  - `AniDb.Api.Http.Test` contains integration/unit tests using MSTest + Microsoft.NET.Test.Sdk. It embeds test resources (e.g., `Resources\anime-titles.xml.gz`). Tests rely on runsettings parameters for AniDB credentials and/or project user-secrets (UserSecretsId present).

Operational constraints to respect (from README):
- Heavy local caching is expected. Do not flood AniDB; avoid requesting more than one page every two seconds.

---

## Key repository conventions and patterns
- Target framework and SDK settings are centralized in `Directory.Build.props` (net8.0, Nullable enabled, implicit usings). Avoid duplicating these settings across projects.
- Treat warnings as errors: CI and local builds enforce `TreatWarningsAsErrors=true`. Fix analyzer warnings rather than bypassing them.
- Editor rules: `.editorconfig` encodes naming and style rules used by IDE and analyzers (e.g., interfaces begin with `I`, using directives outside namespace, namespace-folder matching). Copilot should follow these when generating code.
- InternalsVisibleTo: test projects expect internal types to be visible (`InternalsVisibleTo` used in csproj files). Use the existing pattern for testability rather than changing visibility.
- Packaging metadata (version, authors, product) is set in Directory.Build.props (Version currently configured there). Releases are pushed to NuGet in the GitHub Actions workflow when a `release/*` branch is built.
- Test credentials: CI injects `ANI_USERNAME` and `ANI_PASS` as secrets in the workflow. Locally tests use `AniDb.Api.Http.Test\settings.runsettings` and/or user secrets (UserSecretsId) — mirror CI behavior when running integration tests locally.
- Embedded resources: tests and some components rely on embedded resource files (`Resources\*.txt`, `anime-titles.xml.gz`) — preserve those paths when editing tests.

---

## CI / Release notes for Copilot
- GitHub Actions workflow: `.github/workflows/build.yml` sets up .NET 8.0, restores, builds, runs tests (passes AniDB credentials), and pushes packages on `release/*` branches.
- When suggesting changes around packaging or versioning, update `Directory.Build.props` (not individual csproj files) unless a project requires override.

---

## Docs & contributing
- Primary docs: `README.md` (root) and package/project READMEs under each project folder.
- Follow `CONTRIBUTING.md` and `CODE_OF_CONDUCT.md` for contribution expectations.

---

If this file already exists in future sessions, prefer suggesting small, targeted updates (e.g., add new build/test commands or CI changes) instead of replacing the whole file.

---

Last updated: 2026-06-30
