# NewTestApp

This is a fullstack application built with .NET 9.0, featuring:
- **Backend:** ASP.NET Core Web API (`TownOfSalemCardGame.Api`)
- **Frontend:** Blazor WebAssembly (`TownOfSalemCardGame.Client`)
- **Shared Library:** For models and DTOs (`TownOfSalemCardGame.Shared`)

## Features
- Users can create or join a session with a username.
- Users can rejoin a session by entering the session code.

## Getting Started

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)

### Build and Run
1. Restore dependencies and build the solution:
   ```powershell
   dotnet restore
   dotnet build
   ```
2. Run the backend API:
   ```powershell
   dotnet run --project TownOfSalemCardGame.Api
   ```
3. Run the Blazor frontend:
   ```powershell
   dotnet run --project TownOfSalemCardGame.Client
   ```

## Project Structure
- `TownOfSalemCardGame.Api` - ASP.NET Core Web API backend
- `TownOfSalemCardGame.Client` - Blazor WebAssembly frontend
- `TownOfSalemCardGame.Shared` - Shared models and DTOs

---

## Next Steps
- Implement session and user management in the backend.
- Build UI for session creation/joining in the frontend.
