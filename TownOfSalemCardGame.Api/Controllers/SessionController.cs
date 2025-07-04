using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TownOfSalemCardGame.Shared;
using TownOfSalemCardGame.Api.Hubs;
using System.Collections.Concurrent;

namespace TownOfSalemCardGame.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionController : ControllerBase
    {
        private readonly ConcurrentDictionary<string, Session> _sessions;
        private readonly IHubContext<SessionHub> _hubContext;
        private readonly ILogger<SessionController> _logger;

        public SessionController(ConcurrentDictionary<string, Session> sessions, IHubContext<SessionHub> hubContext,
            ILogger<SessionController> logger)
        {
            _sessions = sessions;
            _hubContext = hubContext;
            _logger = logger;
        }

        [HttpPost("create")]
        public IActionResult CreateSession([FromBody] SessionRequest req)
        {
            var sessionId = GenerateSessionId();
            var session = new Session
            {
                SessionId = sessionId,
                ManagerUsername = req.Username,
                Participants = new List<string>()
            };
#if DEBUG
            // Add 7 dummy participants for debug/testing
            for (int i = 1; i <= 7; i++)
            {
                session.Participants.Add($"DummyPlayer{i}");
            }
#endif
            _sessions[sessionId] = session;
            return Ok(sessionId);
        }

        [HttpPost("start")]
        public async Task<IActionResult> StartGame([FromBody] StartGameRequest req)
        {
            if (_sessions.TryGetValue(req.SessionId, out var session))
            {
                session.IsStarted = true;
                var allPlayers = new List<string>(session.Participants); // Manager is NOT included
                var roles = new List<RoleInfo>();
                foreach (var role in req.Roles)
                {
                    roles.AddRange(Enumerable.Repeat(role, role.Count));
                }

                if (roles.Count != allPlayers.Count)
                {
                    return BadRequest($"Role count ({roles.Count}) does not match player count ({allPlayers.Count})");
                }

                var rng = new Random();
                roles = roles.OrderBy(_ => rng.Next()).ToList();
                var assignments = new List<PlayerRoleAssignment>();
                for (int i = 0; i < allPlayers.Count; i++)
                {
                    string player = allPlayers[i];
                    var role = roles[i];
                    string group = $"{req.SessionId}_{player}";

                    await _hubContext.Clients.Group(group)
                        .SendAsync("ReceiveRole", new { role.Name, role.Description });
                    assignments.Add(new PlayerRoleAssignment {
                        Player = player,
                        Role = new RoleInfo { Name = role.Name, Description = role.Description }
                    });
                    _logger.LogInformation($"Assigned role {role.Name} to {player} in session {req.SessionId}");
                }

                // Store assignments in session for restoration
                session.Assignments = assignments;

                // Send all assignments to the manager only
                await _hubContext.Clients.Group(req.SessionId).SendAsync("ReceiveAllRoles", assignments);
                return Ok();
            }

            return NotFound();
        }

        [HttpPost("join")]
        public async Task<IActionResult> JoinSession([FromBody] JoinSessionRequest req)
        {
            if (_sessions.TryGetValue(req.SessionId, out var session))
            {
                string role = session.ManagerUsername == req.Username ? "manager" : "participant";
                if (!session.Participants.Contains(req.Username) && role != "manager")
                {
                    session.Participants.Add(req.Username);
                    _logger.LogInformation(
                        $"Sending SignalR UserJoined for session {req.SessionId}, user {req.Username}");
                    await _hubContext.Clients.Group(req.SessionId).SendAsync("UserJoined", session);
                }

                return Ok(session);
            }

            return NotFound();
        }

        [HttpPost("rejoin")]
        public IActionResult RejoinSession([FromBody] JoinSessionRequest req)
        {
            if (_sessions.TryGetValue(req.SessionId, out var session))
            {
                // Allow rejoin if username is manager or already in participants
                if (session.ManagerUsername == req.Username || session.Participants.Contains(req.Username))
                {
                    return Ok(session);
                }
                return BadRequest("User not found in session");
            }
            return NotFound();
        }

        [HttpGet("{sessionId}")]
        public IActionResult GetSession(string sessionId)
        {
            if (_sessions.TryGetValue(sessionId, out var session))
                return Ok(session);
            return NotFound();
        }

        [HttpGet("assignments/{sessionId}")]
        public IActionResult GetAssignments(string sessionId)
        {
            if (_sessions.TryGetValue(sessionId, out var session))
            {
                _logger.LogInformation($"Returning {session.Assignments?.Count ?? 0} assignments for session {sessionId}");
                return Ok(session.Assignments ?? new List<PlayerRoleAssignment>());
            }
            return NotFound();
        }

        private static string GenerateSessionId()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}