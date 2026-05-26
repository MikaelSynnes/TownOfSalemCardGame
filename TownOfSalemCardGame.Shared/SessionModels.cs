namespace TownOfSalemCardGame.Shared;

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

// --- Town Roles ---
public class CitizenRole : RoleInfoBase
{
    public override string Name => "Townie";
    public override string Description => "An innocent citizen. Find and vote out the mafia.";
}

public class SheriffRole : RoleInfoBase
{
    public override string Name => "Sheriff";
    public override string Description => "Can investigate one player per night to determine if they are suspicious.";
}

public class DoctorRole : RoleInfoBase
{
    public override string Name => "Doctor";
    public override string Description => "Can heal one player each night, preventing them from dying.";
}

public class InvestigatorRole : RoleInfoBase
{
    public override string Name => "Investigator";
    public override string Description => "Can investigate one player per night and receive a clue about their role.";
}

public class EscortRole : RoleInfoBase
{
    public override string Name => "Escort";
    public override string Description => "Can distract one player each night, preventing them from using their ability.";
}

public class MayorRole : RoleInfoBase
{
    public override string Name => "Mayor";
    public override string Description => "Can reveal themselves to receive three votes during the day.";
}

public class BodyguardRole : RoleInfoBase
{
    public override string Name => "Bodyguard";
    public override string Description => "Can protect one player each night, killing any attacker who targets them.";
}

public class VigilanteRole : RoleInfoBase
{
    public override string Name => "Vigilante";
    public override string Description => "Can shoot and kill one player each night, but feels guilt for killing town members.";
}

public class VeteranRole : RoleInfoBase
{
    public override string Name => "Veteran";
    public override string Description => "Can go on alert at night, killing anyone who visits them.";
}

public class MediumRole : RoleInfoBase
{
    public override string Name => "Medium";
    public override string Description => "Can speak with the dead at night and relay messages to the living.";
}

public class RetributionistRole : RoleInfoBase
{
    public override string Name => "Retributionist";
    public override string Description => "Can resurrect one dead Town member to use their ability once.";
}

public class TransporterRole : RoleInfoBase
{
    public override string Name => "Transporter";
    public override string Description => "Can swap two players' positions at night, redirecting all actions between them.";
}

public class JailorRole : RoleInfoBase
{
    public override string Name => "Jailor";
    public override string Description => "Can jail a player at night, preventing all actions on or by them, and may execute them.";
}

public class TrackerRole : RoleInfoBase
{
    public override string Name => "Tracker";
    public override string Description => "Can track one player to see who they visited last night.";
}

public class LookoutRole : RoleInfoBase
{
    public override string Name => "Lookout";
    public override string Description => "Can watch a player to see who visited them last night.";
}

public class SpyRole : RoleInfoBase
{
    public override string Name => "Spy";
    public override string Description => "Can bug a player to hear all Mafia chat and see who visited them.";
}

public class CrusaderRole : RoleInfoBase
{
    public override string Name => "Crusader";
    public override string Description => "Can protect a player and attack one of their visitors each night.";
}

public class PsychicRole : RoleInfoBase
{
    public override string Name => "Psychic";
    public override string Description => "Receives visions at night revealing groups of innocent or evil players.";
}

public class TrapMasterRole : RoleInfoBase
{
    public override string Name => "Trap Master";
    public override string Description => "Can place a trap on a player that kills and reveals any evil visitor.";
}

public class CoronerRole : RoleInfoBase
{
    public override string Name => "Coroner";
    public override string Description => "Can examine a dead body at night to learn who visited them when they died.";
}

public class HatefulTownieRole : RoleInfoBase
{
    public override string Name => "Hateful Townie";
    public override string Description => "An innocent citizen who must vote guilty on at least one execution or they lose their will to fight. Wins with the Town.";
}

public class PeacefulTownieRole : RoleInfoBase
{
    public override string Name => "Peaceful Townie";
    public override string Description => "An innocent citizen who cannot bring themselves to vote guilty. Must abstain from all execution votes. Wins with the Town.";
}

// --- Mafia Roles ---
public class MafiaRole : RoleInfoBase
{
    public override string Name => "Mafia";
    public override string Description => "A member of the mafia. Eliminate citizens and avoid detection.";
}

public class GodfatherRole : RoleInfoBase
{
    public override string Name => "Godfather";
    public override string Description => "The leader of the Mafia. Appears innocent to investigations and orders the nightly kill.";
}

public class ConsigliereRole : RoleInfoBase
{
    public override string Name => "Consigliere";
    public override string Description => "Can investigate a player at night to learn their exact role.";
}

public class BlackmailerRole : RoleInfoBase
{
    public override string Name => "Blackmailer";
    public override string Description => "Can silence one player each night, preventing them from speaking during the day.";
}

public class ConsortRole : RoleInfoBase
{
    public override string Name => "Consort";
    public override string Description => "Can distract one player each night, preventing them from using their ability.";
}

public class FramerRole : RoleInfoBase
{
    public override string Name => "Framer";
    public override string Description => "Can frame a player at night, making them appear suspicious to investigators.";
}

public class DisguiserRole : RoleInfoBase
{
    public override string Name => "Disguiser";
    public override string Description => "Can disguise themselves as a Town member, making investigators think they are that player.";
}

public class ForgerRole : RoleInfoBase
{
    public override string Name => "Forger";
    public override string Description => "Can forge a player's last will at night, replacing their final message.";
}

public class JanitorRole : RoleInfoBase
{
    public override string Name => "Janitor";
    public override string Description => "Can clean a dead body at night, hiding the victim's role and last will from the town.";
}

public class HypnotistRole : RoleInfoBase
{
    public override string Name => "Hypnotist";
    public override string Description => "Can give a player a false feedback message at night to mislead them.";
}

public class AmbusherRole : RoleInfoBase
{
    public override string Name => "Ambusher";
    public override string Description => "Can ambush a player's house, killing one of their visitors and revealing the ambush.";
}

// --- Neutral Roles ---
public class SerialKillerRole : RoleInfoBase
{
    public override string Name => "Serial Killer";
    public override string Description => "A lone killer who eliminates one player each night. Wins alone.";
}

public class ArsonistRole : RoleInfoBase
{
    public override string Name => "Arsonist";
    public override string Description => "Can douse players in gasoline and ignite them all at once. Wins alone.";
}

public class WitchRole : RoleInfoBase
{
    public override string Name => "Witch";
    public override string Description => "Can control a player each night, forcing them to target another.";
}

public class JesterRole : RoleInfoBase
{
    public override string Name => "Jester";
    public override string Description => "Wins by getting lynched by the town during the day.";
}

public class ExecutionerRole : RoleInfoBase
{
    public override string Name => "Executioner";
    public override string Description => "Has a target and wins by getting that specific player lynched by the town.";
}

public class AmnesiacRole : RoleInfoBase
{
    public override string Name => "Amnesiac";
    public override string Description => "Has forgotten their role and can remember a dead player's role to become it.";
}

public class GuardianAngelRole : RoleInfoBase
{
    public override string Name => "Guardian Angel";
    public override string Description => "Has a target they protect. Wins if their target survives to the end of the game.";
}

public class PirateRole : RoleInfoBase
{
    public override string Name => "Pirate";
    public override string Description => "Plunders players to steal their items and wins by successfully plundering twice.";
}

public class PlaguebearerRole : RoleInfoBase
{
    public override string Name => "Plaguebearer";
    public override string Description => "Infects all players and becomes Pestilence, a nearly unstoppable killing force.";
}

public class SurvivorRole : RoleInfoBase
{
    public override string Name => "Survivor";
    public override string Description => "Has no special ability, but wins by simply surviving to the end of the game.";
}

// --- Coven Roles ---
public class CovenLeaderRole : RoleInfoBase
{
    public override string Name => "Coven Leader";
    public override string Description => "The leader of the Coven. Can control a player and, with the Necronomicon, kill them.";
}

public class MedusaRole : RoleInfoBase
{
    public override string Name => "Medusa";
    public override string Description => "Can stone gaze all visitors to her house, killing them. With Necronomicon, can petrify from afar.";
}

public class NecromancerRole : RoleInfoBase
{
    public override string Name => "Necromancer";
    public override string Description => "Can use the ability of a dead player to target someone each night.";
}

public class HexMasterRole : RoleInfoBase
{
    public override string Name => "Hex Master";
    public override string Description => "Can hex all players; when all living players are hexed, they all die simultaneously.";
}

public class PotionMasterRole : RoleInfoBase
{
    public override string Name => "Potion Master";
    public override string Description => "Has three potions: heal, reveal role, and kill. Can use one per night.";
}

public class PoisonerRole : RoleInfoBase
{
    public override string Name => "Poisoner";
    public override string Description => "Can poison a player, causing them to die the following night unless healed.";
}

// Keep RoleInfo for request payloads
public class RoleInfo
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Count { get; set; }

    /// <summary>In-depth description shown on the help/cards page.</summary>
    public string FullDescription { get; set; } = string.Empty;

    /// <summary>Faction identifier: "town", "mafia", "neutral", or "coven".</summary>
    public string Faction { get; set; } = "neutral";

    /// <summary>Whether this role is currently selectable in a session.</summary>
    public bool IsActive { get; set; } = true;
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
    public bool HasNecronomicon { get; set; } = false;
}