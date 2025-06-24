# Changelog

## v0.1.0 (2025-06-24)

### Initial Project Setup
- Scaffolded a fullstack .NET solution with:
  - Web API backend (`NewTestApp.Api`)
  - Blazor WebAssembly frontend (`NewTestApp.Client`)
  - Shared class library (`NewTestApp.Shared`)
- Added VS Code tasks for build, run-api, and run-client.
- Added Copilot workspace instructions and README.

### Session Management Features
- Implemented session creation and joining APIs in the backend:
  - `/api/session/create` for creating a session with a manager username.
  - `/api/session/join` for joining a session with a session code and username.
  - `/api/session/{sessionId}` for retrieving session details.
- Used in-memory storage for sessions and generated 6-character session codes.
- Shared session models in `NewTestApp.Shared`.

### Real-Time Updates with SignalR
- Added SignalR hub (`SessionHub`) to backend for real-time session updates.
- Backend notifies all session subscribers with the full session object when a user joins.
- Blazor client (CreateSession page) subscribes to SignalR and updates the participant list in real time by replacing the Session object.

### Blazor Client UI
- Created `CreateSession.razor` and `JoinSession.razor` pages with forms and API calls.
- `CreateSession` page shows real-time participant list and session code after creation.
- Navigation and routing updated:
  - `CreateSession` is now the default/landing page.
  - Legacy pages (`SessionManager`, `Counter`) removed from navigation and content.

### Fixes and Improvements
- Fixed issues with Blazor component namespaces and ensured all required `@using` directives are present.
- Fixed issues with sessionId quotes and ensured correct API usage.
- Cleaned up legacy pages and ensured all navigation and routing is correct.
- Updated SignalR handler in `CreateSession.razor` to replace the entire Session object on user join, ensuring the participant list is always in sync.

---

For future releases, see this file for a summary of all changes.
