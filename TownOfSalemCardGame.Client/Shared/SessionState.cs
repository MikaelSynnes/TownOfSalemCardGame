using TownOfSalemCardGame.Shared;

namespace TownOfSalemCardGame.Client.Shared
{
    public class SessionState
    {
        public List<TownOfSalemCardGame.Shared.PlayerRoleAssignment>? PlayerAssignments { get; set; }
        public string? Username { get; set; }
        public bool IsManager { get; set; }
    }
}
