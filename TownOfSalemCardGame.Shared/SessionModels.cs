using System;
using System.Collections.Generic;

namespace TownOfSalemCardGame.Shared
{
    public class Session
    {
        public string SessionId { get; set; } = string.Empty;
        public string ManagerUsername { get; set; } = string.Empty;
        public List<string> Participants { get; set; } = new();
        public bool IsStarted { get; set; } = false; // Indicates if the session has started
        public List<PlayerRoleAssignment> Assignments { get; set; } = new(); // Persist assignments
    }

    public class SessionRequest
    {
        public string Username { get; set; } = string.Empty;
    }

    public class JoinSessionRequest
    {
        public string SessionId { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
    }

    public abstract class RoleInfoBase
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
    }

    public class MafiaRole : RoleInfoBase
    {
        public override string Name => "Mafia";
        public override string Description => "A member of the mafia. Eliminate citizens and avoid detection.";
    }

    public class CitizenRole : RoleInfoBase
    {
        public override string Name => "Citizen";
        public override string Description => "An innocent citizen. Find and vote out the mafia.";
    }

    public class SheriffRole : RoleInfoBase
    {
        public override string Name => "Sheriff";
        public override string Description => "Can investigate one player per night to determine their role.";
    }

    // Keep RoleInfo for request payloads
    public class RoleInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Count { get; set; }
    }

    public class StartGameRequest
    {
        public string SessionId { get; set; } = string.Empty;
        public List<RoleInfo> Roles { get; set; } = new();
    }

    public class PlayerRoleAssignment
    {
        public string? Player { get; set; }
        public RoleInfo? Role { get; set; }
        public HashSet<string> States { get; set; } = new();
    }
}
