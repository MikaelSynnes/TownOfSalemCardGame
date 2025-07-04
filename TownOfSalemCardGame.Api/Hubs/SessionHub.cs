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
    }
}
