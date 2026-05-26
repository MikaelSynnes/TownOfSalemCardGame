namespace TownOfSalemCardGame.Shared;

/// <summary>
/// Central registry of every role in the game.
/// <see cref="ActiveRoles"/> contains roles that are selectable in sessions.
/// <see cref="AllRoles"/> contains every role including those not yet active,
/// which are kept here for completeness and the help page.
/// </summary>
public static class RoleDefinitions
{
    // ── Town ──────────────────────────────────────────────────────────────────

    public static readonly RoleInfo Townie = new()
    {
        Name = "Townie",
        Description = "An innocent citizen. Find and vote out the mafia.",
        Faction = "town",
        FullDescription =
            "The Townie is the backbone of the Town. They have no special night ability, but their voice " +
            "during the day is just as powerful as any investigative role. Work with your fellow Townies, " +
            "listen carefully, and use your vote wisely to remove evil players from the game. " +
            "Wins when all threats to the Town are eliminated."
    };

    public static readonly RoleInfo HatefulTownie = new()
    {
        Name = "Hateful Townie",
        Description = "An innocent citizen who must vote guilty on all executions or they lose their will to fight. Wins with the Town.",
        Faction = "town",
        FullDescription =
            "The Hateful Townie is a Town member driven by righteous anger. They must vote guilty " +
            "on at least one player who is executed during the game — if they fail to do so before the game ends, " +
            "they lose their will to fight and do not win, even if the Town prevails. " +
            "Choose your guilty votes carefully, but make sure you cast at least one."
    };

    public static readonly RoleInfo PeacefulTownie = new()
    {
        Name = "Peaceful Townie",
        Description = "An innocent citizen who cannot bring themselves to vote guilty. Must abstain from all execution votes. Wins with the Town.",
        Faction = "town",
        FullDescription =
            "The Peaceful Townie is a pacifist at heart. They cannot bring themselves to vote for an " +
            "execution — they must abstain from every guilty/innocent vote during the game. " +
            "Breaking this rule causes them to lose. They still win with the Town if all threats are removed."
    };

    public static readonly RoleInfo Sheriff = new()
    {
        Name = "Sheriff",
        Description = "Can investigate one player per night to determine if they are suspicious.",
        Faction = "town",
        FullDescription =
            "The Sheriff is the Town's first line of defence. Each night they may investigate one player " +
            "and receive a result of 'Suspicious' or 'Not Suspicious'. Mafia members, the Serial Killer, " +
            "and other threats return Suspicious — but the Godfather appears innocent. " +
            "Share your findings carefully; the Mafia will target you once your role is known."
    };

    public static readonly RoleInfo Doctor = new()
    {
        Name = "Doctor",
        Description = "Can heal one player each night, preventing them from dying.",
        Faction = "town",
        FullDescription =
            "The Doctor is the Town's guardian angel. Each night they choose one player to heal. " +
            "If that player is attacked, they survive the night instead of dying. " +
            "A Doctor may not heal themselves every night (self-heal is limited). " +
            "Coordinate with confirmed Town members to keep powerful roles alive as long as possible."
    };

    public static readonly RoleInfo Investigator = new()
    {
        Name = "Investigator",
        Description = "Can investigate one player per night and receive a clue about their role.",
        Faction = "town",
        FullDescription =
            "The Investigator digs deeper than the Sheriff. Each night they visit a player and receive " +
            "a list of possible roles that player might belong to. The list narrows the options but rarely " +
            "gives a definitive answer — cross-reference with other Town information to close in on the truth. " +
            "Be careful: Framers can make innocents look guilty."
    };

    public static readonly RoleInfo Escort = new()
    {
        Name = "Escort",
        Description = "Can distract one player each night, preventing them from using their ability.",
        Faction = "town",
        FullDescription =
            "The Escort uses their charms to keep dangerous players busy. Each night they visit " +
            "one player and roleblock them, preventing that player from using their night ability. " +
            "This is incredibly powerful against the Serial Killer, Mafia killers, and other threats. " +
            "However, visiting a Veteran on alert or a Serial Killer will get the Escort killed."
    };

    public static readonly RoleInfo Mayor = new()
    {
        Name = "Mayor",
        Description = "Can reveal themselves to receive three votes during the day.",
        Faction = "town",
        FullDescription =
            "The Mayor holds great political power. Once per game, during the day, the Mayor may " +
            "reveal their identity to the town. Upon revealing, their vote counts as three votes instead of one. " +
            "This makes them a prime target for the Mafia at night, so time your reveal carefully — " +
            "ideally when you have a Doctor ready to protect you."
    };

    public static readonly RoleInfo Bodyguard = new()
    {
        Name = "Bodyguard",
        Description = "Can protect one player each night, killing any attacker who targets them.",
        Faction = "town",
        FullDescription =
            "The Bodyguard takes a bullet for someone else. Each night they choose a player to guard. " +
            "If that player is attacked, the Bodyguard intercepts the attack, killing the attacker " +
            "(and dying themselves in the process — it is a mutual kill). " +
            "Protect key Town roles like the Sheriff or Mayor. A Bodyguard is worth two lives."
    };

    public static readonly RoleInfo Vigilante = new()
    {
        Name = "Vigilante",
        Description = "Can shoot and kill one player each game, but feels guilt for killing town members.",
        Faction = "town",
        FullDescription =
            "The Vigilante takes justice into their own hands.they may choose to shoot " +
            "and kill one player.+" +
        "Use your shots only when you are very confident your target is evil."

    };

    public static readonly RoleInfo Veteran = new()
    {
        Name = "Veteran",
        Description = "Can go on alert at night, killing anyone who visits them.",
        Faction = "town",
        FullDescription =
            "The Veteran is a battle-hardened survivor. They have a limited number of alerts. " +
            "On nights they go on alert, they kill every single player who visits their home — " +
            "friend or foe alike. This makes them dangerous to roleblock or heal on alert nights. " +
            "Use alerts strategically after baiting an announcement."
    };

    public static readonly RoleInfo Medium = new()
    {
        Name = "Medium",
        Description = "Can speak with the dead at night and relay messages to the living.",
        Faction = "town",
        FullDescription =
            "The Medium acts as a bridge between the living and the dead. Each night, dead players may " +
            "speak to the Medium, passing on vital information they gathered before dying. " +
            "The Medium can then relay these secrets to the Town during the day. " +
            "Dead players know the truth — the Medium's ability to channel their knowledge can be game-changing."
    };
    public static readonly RoleInfo TimeTraveler = new()
    {
        Name = "Time Traveler",
        Description = "Can undo the previous night's death once per game.",
        Faction = "town",
        FullDescription =
        "The Time Traveler possesses a unique one-shot ability: once per game, they can travel back " +
        "and undo the events of the previous night, bringing back all players who died that night. " +
        "This is an enormously powerful ability that can reverse a devastating Mafia attack or Serial " +
        "Killer rampage. The Time Traveler wins by surviving to the end of the game."
    };

    public static readonly RoleInfo Retributionist = new()
    {
        Name = "Retributionist",
        Description = "Can resurrect one dead Town member to use their ability once.",
        Faction = "town",
        FullDescription =
            "The Retributionist harnesses the power of the fallen. Once per game, they may choose " +
            "a dead Town member and temporarily use that player's ability for one night. " +
            "This effectively gives the Town a second chance with any role that has died — " +
            "a second Sheriff check, a Doctor heal, or a Vigilante shot can turn the game around."
    };

    public static readonly RoleInfo Transporter = new()
    {
        Name = "Transporter",
        Description = "Can swap two players' positions at night, redirecting all actions between them.",
        Faction = "town",
        FullDescription =
            "The Transporter swaps the locations of two players for the night. Every action targeting " +
            "either of those two players is redirected to the other. This means a kill aimed at one lands " +
            "on the other, and investigations come back with the wrong result. " +
            "A master Transporter can save lives and waste Mafia kills without the enemy knowing.",
        IsActive = false
    };

    public static readonly RoleInfo Jailor = new()
    {
        Name = "Jailor",
        Description = "Can jail a player at night, preventing all actions on or by them, and may execute them.",
        Faction = "town",
        FullDescription =
            "The Jailor is one of the most powerful Town roles. Each night they may jail one player, " +
            "locking them in a cell — the jailed player cannot use their ability and cannot be targeted. " +
            "The Jailor may also choose to execute a jailed player, but killing a Town member ends the " +
            "Jailor's ability to execute for the rest of the game."
    };

    public static readonly RoleInfo Tracker = new()
    {
        Name = "Tracker",
        Description = "Can track one player to see who they visited last night.",
        Faction = "town",
        FullDescription =
            "The Tracker places a silent tail on a player. At the end of the night, the Tracker receives " +
            "the name(s) of everyone the tracked player visited. This is excellent for exposing " +
            "Mafia killers, Serial Killers, or any evil role that visits others. " +
            "Pair Tracker results with Sheriff checks for airtight confirmation.",
        IsActive = false
    };

    public static readonly RoleInfo Lookout = new()
    {
        Name = "Lookout",
        Description = "Can watch a player to see who visited them last night.",
        Faction = "town",
        FullDescription =
            "The Lookout stakes out a player's house. At the end of the night, they see the names of " +
            "everyone who visited that player. This is the inverse of the Tracker — instead of following " +
            "someone, you watch someone being visited. A great tool for protecting confirmed Town roles " +
            "and identifying their nightly visitors."
    };

    public static readonly RoleInfo Crusader = new()
    {
        Name = "Crusader",
        Description = "Can protect a player and attack one of their visitors each night.",
        Faction = "town",
        FullDescription =
            "The Crusader is an aggressive protector. Each night they choose a player to guard. " +
            "If anyone visits that player, the Crusader attacks one of those visitors — potentially " +
            "killing a Mafia member, Serial Killer, or other threat. " +
            "Unlike the Bodyguard, the Crusader survives the encounter.",
        IsActive = false
    };

    public static readonly RoleInfo Psychic = new()
    {
        Name = "Psychic",
        Description = "Receives visions at night revealing groups of innocent or evil players.",
        Faction = "town",
        FullDescription =
            "The Psychic receives cryptic visions each night. On odd nights, a vision reveals " +
            "three players — at least one of whom is evil. On even nights, a vision reveals two players " +
            "— both of whom are innocent. Over time, overlapping visions help narrow down who " +
            "the evildoers are without any active ability needed.",
        IsActive = false
    };

    public static readonly RoleInfo TrapMaster = new()
    {
        Name = "Trap Master",
        Description = "Can place a trap on a player that kills and reveals any evil visitor.",
        Faction = "town",
        FullDescription =
            "The Trap Master sets deadly snares. Each night they place a trap at a player's location. " +
            "If an evil player visits the trapped target, the trap springs — killing the visitor and " +
            "revealing their role and name to the Town the following day. " +
            "Traps take one night to arm, so plan one step ahead."
    };

    public static readonly RoleInfo Coroner = new()
    {
        Name = "Coroner",
        Description = "Can examine a dead body at night to learn who visited them when they died.",
        Faction = "town",
        FullDescription =
            "The Coroner examines the bodies of those who die each night. They can learn the names of " +
            "everyone who visited the deceased on the night they were killed. " +
            "This turns every Town death into an investigative opportunity — " +
            "the killer almost always visits their victim, and the Coroner will find their trail."
    };

    // ── Mafia ─────────────────────────────────────────────────────────────────

    public static readonly RoleInfo Mafia = new()
    {
        Name = "Mafia",
        Description = "A member of the mafia. Eliminate citizens and avoid detection.",
        Faction = "mafia",
        FullDescription =
            "A basic Mafia member. They know the identity of all other Mafia members and can communicate " +
            "with them at night. If no Mafia killing role is alive, the Mafia member may carry out the " +
            "nightly kill. Their primary goal is to survive and eliminate the Town until the Mafia " +
            "outnumbers or equals the remaining players."
    };

    public static readonly RoleInfo Godfather = new()
    {
        Name = "Godfather",
        Description = "The leader of the Mafia. Appears innocent to investigations and orders the nightly kill.",
        Faction = "mafia",
        FullDescription =
            "The Godfather is the head of the Mafia family. Each night, they choose who the Mafia will " +
            "kill, delegating the hit to a Mafioso or carrying it out personally. " +
            "The Godfather's most dangerous attribute: they appear completely innocent to Sheriff " +
            "investigations, making them nearly impossible to detect by conventional means."
    };

    public static readonly RoleInfo Consigliere = new()
    {
        Name = "Consigliere",
        Description = "Can investigate a player at night to learn their exact role.",
        Faction = "mafia",
        FullDescription =
            "The Consigliere is the Mafia's intelligence officer. Unlike the Sheriff who gets vague " +
            "'Suspicious/Not Suspicious' results, the Consigliere learns the exact role of the player they " +
            "investigate each night. This lets the Mafia prioritise killing powerful Town roles like " +
            "the Jailor or Vigilante before they become a problem.",
        IsActive = false
    };

    public static readonly RoleInfo Blackmailer = new()
    {
        Name = "Blackmailer",
        Description = "Can silence one player each night, preventing them from speaking during the day.",
        Faction = "mafia",
        FullDescription =
            "The Blackmailer holds secrets over a player's head. Each night they choose one player to " +
            "blackmail. The following day, that player cannot speak in Town chat — their words are " +
            "muted. This is devastating against confirmed Town members who might expose the Mafia. " +
            "The Blackmailer also sees all private messages of their target."
    };

    public static readonly RoleInfo Consort = new()
    {
        Name = "Consort",
        Description = "Can distract one player each night, preventing them from using their ability.",
        Faction = "mafia",
        FullDescription =
            "The Consort is the Mafia's version of the Escort. Each night they visit a player and " +
            "roleblock them, preventing them from using their ability for the night. " +
            "Roleblocking a Sheriff, Doctor, or Vigilante at the right moment can swing the game " +
            "in the Mafia's favour. Visiting a Veteran on alert will get the Consort killed."
    };

    public static readonly RoleInfo Framer = new()
    {
        Name = "Framer",
        Description = "Can frame a player at night, making them appear suspicious to investigators.",
        Faction = "mafia",
        FullDescription =
            "The Framer is a master manipulator. Each night they choose a player to frame. " +
            "That night, any Sheriff or Investigator who checks the framed player will receive " +
            "results indicating they are suspicious or have a Mafia-like role. " +
            "Use this to discredit confirmed Town members and sow distrust within the Town."
    };

    public static readonly RoleInfo Disguiser = new()
    {
        Name = "Disguiser",
        Description = "Can disguise themselves as a Town member, making investigators think they are that player.",
        Faction = "mafia",
        FullDescription =
            "The Disguiser steals identities. Each night they can disguise themselves as a Town player, " +
            "causing investigators and role-checkers to see the Town player's role instead of the " +
            "Disguiser's own role. If the disguised Town member dies, their body shows the Disguiser's " +
            "name — leaving the real Disguiser to continue living under a false identity.",
        IsActive = false
    };

    public static readonly RoleInfo Forger = new()
    {
        Name = "Forger",
        Description = "Can forge a player's last will at night, replacing their final message.",
        Faction = "mafia",
        FullDescription =
            "The Forger is a skilled con-artist. Each night they choose a player and write a fake " +
            "last will for them. If that player is killed, their forged last will is displayed to the Town " +
            "instead of the real one. This can completely discredit an investigative Town role's findings, " +
            "misdirecting the Town's lynch votes away from the Mafia.",
        IsActive = false
    };

    public static readonly RoleInfo Janitor = new()
    {
        Name = "Janitor",
        Description = "Can clean a dead body at night, hiding the victim's role and last will from the town.",
        Faction = "mafia",
        FullDescription =
            "The Janitor cleans up the Mafia's messes. Each night they choose a player to 'clean'. " +
            "If that player is killed that night, their role and last will are completely hidden from " +
            "the Town — nobody sees what role they were. The Janitor alone privately learns the " +
            "cleaned player's role. This protects the Mafia by keeping the Town in the dark."
    };

    public static readonly RoleInfo Hypnotist = new()
    {
        Name = "Hypnotist",
        Description = "Can give a player a false feedback message at night to mislead them.",
        Faction = "mafia",
        FullDescription =
            "The Hypnotist plants false memories. Each night they choose a player and feed them a " +
            "fabricated feedback message — for example, telling a Sheriff they found someone innocent, " +
            "or telling a Doctor their patient was attacked. These false messages can make Town " +
            "investigative roles doubt their own correct findings, causing chaos.",
        IsActive = false
    };

    public static readonly RoleInfo Ambusher = new()
    {
        Name = "Ambusher",
        Description = "Can ambush a player's house, killing one of their visitors and revealing the ambush.",
        Faction = "mafia",
        FullDescription =
            "The Ambusher hides outside a chosen player's house. When another player visits the target, " +
            "the Ambusher kills one of those visitors and the ambush is revealed to the Town. " +
            "This is used offensively to kill Town roles that are likely to visit a known player, " +
            "but the public reveal means the Mafia is exposed as having an Ambusher."
    };

    // ── Neutral ───────────────────────────────────────────────────────────────

    public static readonly RoleInfo SerialKiller = new()
    {
        Name = "Serial Killer",
        Description = "A lone killer who eliminates one player each night. Wins alone.",
        Faction = "neutral",
        FullDescription =
            "The Serial Killer is a one-person army. Each night they choose a player to kill — and unlike " +
            "the Mafia, they have no allies to trust or betray them. They are immune to being roleblocked " +
            "(and will kill anyone who tries). They must eliminate all other factions to win. " +
            "Playing as the SK requires careful deception and often pretending to be a Town role."
    };

    public static readonly RoleInfo Arsonist = new()
    {
        Name = "Arsonist",
        Description = "Can douse players in gasoline and ignite them all at once. Wins alone.",
        Faction = "neutral",
        FullDescription =
            "The Arsonist plays a long, patient game. Each night they can douse a player in gasoline — " +
            "an action that doesn't kill immediately and leaves no obvious trace. " +
            "When they choose to ignite, every single doused player dies simultaneously. " +
            "They must eliminate all other factions to win. Perfect timing on the ignite is everything."
    };

    public static readonly RoleInfo Witch = new()
    {
        Name = "Witch",
        Description = "Can control a player each night, forcing them to target another.",
        Faction = "neutral",
        FullDescription =
            "The Witch is a chaotic neutral force. Each night they choose two players: a caster and a " +
            "target. The caster is forced to use their ability on the target instead of their chosen " +
            "person. This can redirect a Mafia kill onto another Mafia member, force a Doctor to heal " +
            "the Witch's enemy, or make a Vigilante shoot a Townie. " +
            "The Witch wins if they survive to the end of the game."
    };

    public static readonly RoleInfo Jester = new()
    {
        Name = "Jester",
        Description = "Wins by getting lynched by the town during the day.",
        Faction = "neutral",
        FullDescription =
            "The Jester's only goal is to be executed by the Town. They have no night ability whatsoever. " +
            "During the day, they must be suspicious enough that Town players vote to hang them. " +
            "If the Jester is successfully lynched, they win the game — and each player who voted " +
            "guilty gets haunted: the Jester's ghost kills one of them in the following night."
    };

    public static readonly RoleInfo Executioner = new()
    {
        Name = "Executioner",
        Description = "Has a target and wins by getting that specific player lynched by the town.",
        Faction = "neutral",
        FullDescription =
            "The Executioner is assigned a specific Town member as their target at the start of the game. " +
            "They win by manipulating the Town into voting to execute that person. " +
            "They have no night ability, but they do know their target's name from day one. " +
            "If their target dies at night, the Executioner becomes a Jester instead."
    };

    public static readonly RoleInfo Amnesiac = new()
    {
        Name = "Amnesiac",
        Description = "Has forgotten their role and can remember a dead player's role to become it.",
        Faction = "neutral",
        FullDescription =
            "The Amnesiac has lost all memory of who they are. They start with no faction and no ability. " +
            "Each night they may visit a dead player's grave and 'remember' their role, " +
            "fully becoming that role — including faction allegiance. " +
            "Choose wisely: remembering a Mafia role makes you Mafia; remembering Town makes you Town.",
        IsActive = false
    };

    public static readonly RoleInfo GuardianAngel = new()
    {
        Name = "Guardian Angel",
        Description = "Has a target they protect. Wins if their target survives to the end of the game.",
        Faction = "neutral",
        FullDescription =
            "The Guardian Angel is assigned a random player as their ward. Their only goal is to keep " +
            "that player alive until the game ends. Each night they may use a powerful protect on their " +
            "ward (with limited uses), preventing all attacks. " +
            "The Guardian Angel wins regardless of which faction wins, as long as their ward is still alive."
    };

    public static readonly RoleInfo Survivor = new()
    {
        Name = "Survivor",
        Description = "Cannot be killed during the night, but wins by simply surviving to the end of the game.",
        Faction = "neutral",
        FullDescription =
            "The Survivor has only one goal: stay alive. They have no night ability, but they do have " +
            "a limited number of bulletproof vests they can wear at night, making them temporarily " +
            "immune to attacks. They win alongside any faction as long as they are alive when the game ends. " +
            "Never draw attention to yourself — the best Survivor is invisible."
    };

    public static readonly RoleInfo Hunter = new()
    {
        Name = "Hunter",
        Description = "If killed at night, immediately shoots one of their attackers. Wins by surviving to the end",
        Faction = "neutral",
        FullDescription =
            "The Hunter is a passive but deadly neutral. They have no active night ability — " +
            "but if any player kills them at night, the Hunter automatically fires back, killing " +
            "one of their attackers (chosen at random if multiple). " +
            "This makes killing the Hunter a risky gamble for both the Mafia and Serial Killer. " +
            "The Hunter wins by surviving to the end."
    };


    public static readonly RoleInfo Poisoner = new()
    {
        Name = "Poisoner",
        Description = "Can poison one player each night. Poisoned players die the following night unless cured. Wins if everyone is dead",
        Faction = "neutral",
        FullDescription =
            "The Poisoner is a slow but relentless killer. Each night they choose a player to poison. " +
            "The poison takes effect the following night, killing the victim unless a Chemist cures them. " +
            "The Town may not immediately know who is poisoned or by whom, giving the Poisoner time " +
            "to strike multiple targets before being discovered. Wins by surviving to the end."
    };

    public static readonly RoleInfo Chemist = new()
    {
        Name = "Chemist",
        Description = "Can cure one poisoned player each night, preventing their death from poison.",
        Faction = "town",
        FullDescription =
            "The Chemist is the only counter to the Poisoner. Each night they visit a player and " +
            "administer an antidote, saving them from poison if they were poisoned. " +
            "The Chemist does not know who the Poisoner is — they must make educated guesses about " +
            "who might be targeted. The Chemist wins by surviving to the end of the game."
    };

    public static readonly RoleInfo Fool = new()
    {
        Name = "Fool",
        Description = "Appears suspicious to everyone but is actually harmless townie.",
        Faction = "town",
        FullDescription =
            "The Fool is entirely harmless despite seeming dangerous. They appear suspicious to Sheriffs " +
            "and Investigators, and their role may appear as a threatening role to investigators — " +
            "but they have no night ability and are not aligned with any evil faction. " +
            "The Fool wins simply by surviving. Their presence creates confusion and paranoia in the Town."
    };

    // ── Coven ─────────────────────────────────────────────────────────────────

    public static readonly RoleInfo CovenLeader = new()
    {
        Name = "Coven Leader",
        Description = "The leader of the Coven. Can control a player and, with the Necronomicon, kill them.",
        Faction = "coven",
        FullDescription =
            "The Coven Leader heads the dark Coven faction. Each night they can control a player, " +
            "forcing them to target another player with their ability. When the Coven Leader holds " +
            "the Necronomicon (a powerful artifact passed between Coven members), they can additionally " +
            "kill the controlled player. They are immune to night attacks from non-Coven sources.",
        IsActive = false
    };

    public static readonly RoleInfo Medusa = new()
    {
        Name = "Medusa",
        Description = "Can stone gaze all visitors to her house, killing them. With Necronomicon, can petrify from afar.",
        Faction = "coven",
        FullDescription =
            "Medusa turns visitors to stone. Without the Necronomicon, any player who visits Medusa " +
            "at night is killed — she stays home and waits for victims to come to her. " +
            "With the Necronomicon, she can reach out and stone gaze players at any location, " +
            "killing them remotely. Any investigator who visits Medusa sees only their own reflection.",
        IsActive = false
    };

    public static readonly RoleInfo Necromancer = new()
    {
        Name = "Necromancer",
        Description = "Can use the ability of a dead player to target someone each night.",
        Faction = "coven",
        FullDescription =
            "The Necromancer raises the dead for one last task. Each night they can choose a dead " +
            "player and use that player's ability on a living target. A dead Sheriff can be made to " +
            "investigate someone, a dead Vigilante can be made to shoot, or a dead Escort can roleblock. " +
            "With the Necronomicon, the chosen dead player's ability is enhanced.",
        IsActive = false
    };

    public static readonly RoleInfo HexMaster = new()
    {
        Name = "Hex Master",
        Description = "Can hex all players; when all living players are hexed, they all die simultaneously.",
        Faction = "coven",
        FullDescription =
            "The Hex Master places a creeping curse on the Town. Each night they hex one player. " +
            "When every single living player has been hexed, they all die at the same time — " +
            "a devastating mass kill that can instantly end the game. The Town has no way of " +
            "knowing who is hexed, creating growing dread as the game progresses.",
        IsActive = false
    };

    public static readonly RoleInfo PotionMaster = new()
    {
        Name = "Potion Master",
        Description = "Has three potions: heal, reveal role, and kill. Can use one per night.",
        Faction = "coven",
        FullDescription =
            "The Potion Master is a versatile Coven member with three distinct potions. " +
            "The Healing Potion saves a player from death that night. The Reveal Potion exposes a " +
            "player's exact role to the Coven. The Killing Potion attacks and kills a player. " +
            "Each potion can only be used once — choosing when to use each one is the challenge.",
        IsActive = false
    };

    // ────────────────────────────────────────────────────────────────────────
    // Aggregated collections
    // ────────────────────────────────────────────────────────────────────────

    /// <summary>All roles, including inactive / future ones (for the help page).</summary>
    public static readonly IReadOnlyList<RoleInfo> AllRoles = new List<RoleInfo>
    {
        // Town
        Townie, HatefulTownie, PeacefulTownie, Sheriff, Doctor, Investigator,
        Escort, Mayor, Bodyguard, Vigilante, Veteran, Medium, Retributionist,
        Transporter, Jailor, Tracker, Lookout, Crusader, Psychic, TrapMaster, Coroner,
        TimeTraveler,Chemist, Fool,
        // Mafia
        Mafia, Godfather, Consigliere, Blackmailer, Consort, Framer,
        Disguiser, Forger, Janitor, Hypnotist, Ambusher,
        // Neutral
        SerialKiller, Arsonist, Witch, Jester, Executioner, Amnesiac,
        GuardianAngel, Survivor, Hunter, Poisoner,
        // Coven
        CovenLeader, Medusa, Necromancer, HexMaster, PotionMaster
    };

    /// <summary>Only roles that are currently selectable in a session.</summary>
    public static readonly IReadOnlyList<RoleInfo> ActiveRoles =
        AllRoles.Where(r => r.IsActive).ToList();
}
