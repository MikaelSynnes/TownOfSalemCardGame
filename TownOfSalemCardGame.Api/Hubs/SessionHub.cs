using Microsoft.AspNetCore.SignalR;

namespace TownOfSalemCardGame.Api.Hubs
{
    public class SessionHub : Hub
    {
        private readonly ILogger<SessionHub> _logger;
        public SessionHub(ILogger<SessionHub> logger)
        {
            _logger = logger;
        }

        public async Task SubscribeToSession(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            _logger.LogInformation($"Connection {Context.ConnectionId} joined group {groupName}");
        }

        public async Task SendUserJoined(string sessionId, string username)
        {
            await Clients.Group(sessionId).SendAsync("UserJoined", username);
        }

        public async Task SubscribeToSessionGroup(string sessionId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, sessionId);
        }

        public async Task SendAdminMessage(string sessionId, string message, string? targetPlayer)
        {
            if (string.IsNullOrWhiteSpace(targetPlayer))
            {
                // Broadcast to all players in the session group
                await Clients.Group(sessionId).SendAsync("AdminMessage", message, (string?)null);
            }
            else
            {
                // Send to individual player group
                await Clients.Group($"{sessionId}_{targetPlayer}").SendAsync("AdminMessage", message, targetPlayer);
            }
        }

        /// <summary>Pushes a player's updated state set to their personal group so their UI refreshes.</summary>
        public async Task BroadcastStateUpdate(string sessionId, string playerName, IEnumerable<string> states)
        {
            await Clients.Group($"{sessionId}_{playerName}").SendAsync("StateUpdated", states);
            _logger.LogInformation($"State update sent to {playerName} in session {sessionId}");
        }

        /// <summary>Tells every player in the session that night states have been reset.</summary>
        public async Task BroadcastResetNightStates(string sessionId, IEnumerable<string> clearedStates)
        {
            await Clients.Group(sessionId).SendAsync("NightStatesReset", clearedStates);
            _logger.LogInformation($"Night states reset broadcast sent for session {sessionId}");
        }
    }
}
