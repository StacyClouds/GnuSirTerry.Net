# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this is

A minimal ASP.NET Core middleware NuGet package (`StacyClouds.GnuSirTerry.Net`) that adds the `X-Clacks-Overhead: GNU Terry Pratchett` HTTP response header to every request. The library targets `netstandard2.1`; tests run against net9.0, net10.0, and net11.0.

## Commands

```bash
# Build
dotnet build

# Run all tests (all target frameworks)
dotnet test

# Run tests for a specific framework
dotnet test StacyClouds.GnuSirTerry.Net.Tests/StacyClouds.GnuSirTerry.Net.Tests.csproj --framework net11.0

# Run a specific test
dotnet test --filter "FullyQualifiedName~InvokeAsync_AddsXClacksOverheadHeader"

# Pack the NuGet package
dotnet pack StacyClouds.GnuSirTerry.Net/StacyClouds.GnuSirTerry.Net.csproj --configuration Release -p:Version=<version>
```

## Architecture

The solution has two projects:

- `StacyClouds.GnuSirTerry.Net/` — the library. One file: `GnuSirTerryMiddleware.cs`, which contains the middleware class and the `UseGnuSirTerryMiddleware()` extension method for `IApplicationBuilder`.
- `StacyClouds.GnuSirTerry.Net.Tests/` — xunit tests using NSubstitute (mocking) and Shouldly (assertions).

## CI / Publishing

- **CI** (`.github/workflows/ci.yml`): runs `dotnet test` across net9.0, net10.0, and net11.0 on every PR and push to `main`.
- **Publish** (`.github/workflows/publish.yml`): manual `workflow_dispatch` that calculates the next version from git tags (patch/minor/major bump), packs, and pushes to NuGet using GitHub OIDC. Triggered from the GitHub Actions UI — not via CLI.
