using NewTestApp.Shared;

namespace NewTestApp.Client.Shared
{
    public class SessionState
    {
        public List<PlayerRoleAssignment>? PlayerAssignments { get; set; }
    }

    public class PlayerRoleAssignment
    {
        public string? Player { get; set; }
        public RoleInfo? Role { get; set; }
        public HashSet<string> States { get; set; } = new();
    }
}
