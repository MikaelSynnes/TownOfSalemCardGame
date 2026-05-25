namespace TownOfSalemCardGame.Client.Components;

/// <summary>
/// Provides inline SVG artwork for every Town of Salem role card.
/// Each SVG is 200×140, designed for the card art panel.
/// </summary>
public static class RoleCardArt
{
    public static string Get(string? roleName) => roleName switch
    {
        // ── Town ──────────────────────────────────────────────────────────────
        "Townie" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- house -->
              <polygon points="100,20 50,65 150,65" fill="#4caf50" opacity=".8"/>
              <rect x="65" y="65" width="70" height="55" fill="#2e5c2e"/>
              <rect x="86" y="85" width="28" height="35" fill="#1a3a1a"/>
              <!-- window -->
              <rect x="72" y="72" width="18" height="16" fill="#a0f0a0" opacity=".5"/>
              <rect x="110" y="72" width="18" height="16" fill="#a0f0a0" opacity=".5"/>
              <!-- stars -->
              <circle cx="30" cy="25" r="2" fill="#e8d9a0"/>
              <circle cx="170" cy="30" r="1.5" fill="#e8d9a0"/>
              <circle cx="55" cy="15" r="1" fill="#e8d9a0"/>
              <circle cx="145" cy="12" r="1.5" fill="#e8d9a0"/>
            </svg>
            """,

        "Sheriff" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- badge star -->
              <polygon points="100,20 108,42 132,42 113,55 120,78 100,65 80,78 87,55 68,42 92,42"
                       fill="#c9a84c" stroke="#e8c96d" stroke-width="1.5"/>
              <circle cx="100" cy="50" r="12" fill="#8b6914"/>
              <text x="100" y="54" text-anchor="middle" font-size="9" fill="#e8d9a0" font-family="serif">SHERIFF</text>
              <!-- magnifier -->
              <circle cx="65" cy="105" r="18" fill="none" stroke="#4caf50" stroke-width="3"/>
              <line x1="78" y1="118" x2="90" y2="130" stroke="#4caf50" stroke-width="4" stroke-linecap="round"/>
            </svg>
            """,

        "Doctor" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- cross -->
              <rect x="85" y="30" width="30" height="80" rx="4" fill="#4caf50" opacity=".85"/>
              <rect x="60" y="55" width="80" height="30" rx="4" fill="#4caf50" opacity=".85"/>
              <rect x="88" y="33" width="24" height="74" rx="3" fill="#a0f0a0" opacity=".35"/>
              <!-- bag handle -->
              <path d="M75,40 Q100,20 125,40" fill="none" stroke="#e8d9a0" stroke-width="3"/>
            </svg>
            """,

        "Investigator" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <circle cx="90" cy="70" r="35" fill="none" stroke="#4caf50" stroke-width="4"/>
              <circle cx="90" cy="70" r="25" fill="none" stroke="#4caf50" stroke-width="1.5" stroke-dasharray="4 3"/>
              <line x1="118" y1="98" x2="145" y2="125" stroke="#4caf50" stroke-width="6" stroke-linecap="round"/>
              <!-- fingerprint arcs -->
              <path d="M82,62 Q90,54 98,62" fill="none" stroke="#a0f0a0" stroke-width="1.5"/>
              <path d="M79,68 Q90,58 101,68" fill="none" stroke="#a0f0a0" stroke-width="1.5"/>
              <path d="M77,74 Q90,63 103,74" fill="none" stroke="#a0f0a0" stroke-width="1.5"/>
            </svg>
            """,

        "Escort" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- silhouette dancing figure -->
              <circle cx="100" cy="38" r="14" fill="#4caf50" opacity=".8"/>
              <path d="M100,52 Q85,75 80,100" fill="none" stroke="#4caf50" stroke-width="4" stroke-linecap="round"/>
              <path d="M100,52 Q115,75 120,100" fill="none" stroke="#4caf50" stroke-width="4" stroke-linecap="round"/>
              <path d="M87,72 Q75,80 65,72" fill="none" stroke="#4caf50" stroke-width="3.5" stroke-linecap="round"/>
              <path d="M113,72 Q125,80 135,72" fill="none" stroke="#4caf50" stroke-width="3.5" stroke-linecap="round"/>
              <!-- hearts -->
              <text x="40" y="45" font-size="16" fill="#c0392b" opacity=".7">♥</text>
              <text x="148" y="52" font-size="12" fill="#c0392b" opacity=".5">♥</text>
            </svg>
            """,

        "Mayor" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- pillars -->
              <rect x="55" y="55" width="14" height="60" fill="#4caf50" opacity=".7"/>
              <rect x="93" y="45" width="14" height="70" fill="#4caf50" opacity=".9"/>
              <rect x="131" y="55" width="14" height="60" fill="#4caf50" opacity=".7"/>
              <rect x="45" y="110" width="110" height="10" rx="2" fill="#2e5c2e"/>
              <!-- roof -->
              <polygon points="100,15 45,55 155,55" fill="#c9a84c" opacity=".85"/>
              <!-- gavel -->
              <rect x="115" y="75" width="35" height="12" rx="4" fill="#8b6914" transform="rotate(-30 115 75)"/>
              <line x1="118" y1="82" x2="95" y2="110" stroke="#8b6914" stroke-width="4" stroke-linecap="round"/>
            </svg>
            """,

        "Bodyguard" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- shield -->
              <path d="M100,20 L145,40 L145,85 Q145,115 100,130 Q55,115 55,85 L55,40 Z"
                    fill="#2e5c2e" stroke="#4caf50" stroke-width="2.5"/>
              <path d="M100,35 L130,50 L130,82 Q130,103 100,115 Q70,103 70,82 L70,50 Z"
                    fill="#3a7a3a" opacity=".5"/>
              <!-- cross on shield -->
              <rect x="94" y="48" width="12" height="44" rx="3" fill="#4caf50"/>
              <rect x="76" y="66" width="48" height="12" rx="3" fill="#4caf50"/>
            </svg>
            """,

        "Vigilante" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- revolver outline -->
              <rect x="55" y="60" width="75" height="22" rx="5" fill="#3a7a3a"/>
              <rect x="120" y="52" width="30" height="14" rx="3" fill="#3a7a3a"/>
              <rect x="88" y="82" width="22" height="30" rx="4" fill="#2e5c2e"/>
              <circle cx="67" cy="71" r="10" fill="none" stroke="#4caf50" stroke-width="2.5"/>
              <circle cx="67" cy="71" r="4" fill="#4caf50"/>
              <!-- muzzle flash -->
              <polygon points="150,59 162,45 158,62 172,52 160,68" fill="#c9a84c" opacity=".8"/>
            </svg>
            """,

        "Veteran" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- crossed swords -->
              <line x1="55" y1="25" x2="145" y2="115" stroke="#4caf50" stroke-width="6" stroke-linecap="round"/>
              <line x1="145" y1="25" x2="55" y2="115" stroke="#4caf50" stroke-width="6" stroke-linecap="round"/>
              <!-- hilts -->
              <rect x="45" y="20" width="20" height="8" rx="2" fill="#c9a84c" transform="rotate(45 55 24)"/>
              <rect x="135" y="20" width="20" height="8" rx="2" fill="#c9a84c" transform="rotate(-45 145 24)"/>
              <!-- alert star burst -->
              <circle cx="100" cy="70" r="8" fill="#c9a84c" opacity=".9"/>
            </svg>
            """,

        "Medium" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- crystal ball -->
              <circle cx="100" cy="80" r="40" fill="#0d2a3a" stroke="#4caf50" stroke-width="2"/>
              <circle cx="100" cy="80" r="40" fill="url(#crystalGrad)" opacity=".7"/>
              <defs>
                <radialGradient id="crystalGrad" cx="40%" cy="35%">
                  <stop offset="0%" stop-color="#a0f0f0" stop-opacity=".6"/>
                  <stop offset="100%" stop-color="#0d2a3a" stop-opacity="0"/>
                </radialGradient>
              </defs>
              <!-- wispy ghost -->
              <path d="M88,68 Q85,52 100,48 Q115,52 112,68 L112,82 Q107,90 100,82 Q93,90 88,82 Z"
                    fill="#a0f0e0" opacity=".45"/>
              <ellipse cx="97" cy="64" rx="3" ry="4" fill="#1a1a4e" opacity=".8"/>
              <ellipse cx="103" cy="64" rx="3" ry="4" fill="#1a1a4e" opacity=".8"/>
              <!-- stand -->
              <rect x="80" y="118" width="40" height="8" rx="4" fill="#2e5c2e"/>
              <rect x="92" y="110" width="16" height="12" fill="#2e5c2e"/>
            </svg>
            """,

        "Retributionist" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- sun rays -->
              <circle cx="100" cy="65" r="28" fill="#c9a84c" opacity=".7"/>
              <circle cx="100" cy="65" r="18" fill="#e8c96d" opacity=".9"/>
              <line x1="100" y1="20" x2="100" y2="32" stroke="#c9a84c" stroke-width="3"/>
              <line x1="100" y1="98" x2="100" y2="110" stroke="#c9a84c" stroke-width="3"/>
              <line x1="55" y1="65" x2="67" y2="65" stroke="#c9a84c" stroke-width="3"/>
              <line x1="133" y1="65" x2="145" y2="65" stroke="#c9a84c" stroke-width="3"/>
              <line x1="68" y1="33" x2="76" y2="41" stroke="#c9a84c" stroke-width="3"/>
              <line x1="124" y1="89" x2="132" y2="97" stroke="#c9a84c" stroke-width="3"/>
              <line x1="132" y1="33" x2="124" y2="41" stroke="#c9a84c" stroke-width="3"/>
              <line x1="68" y1="97" x2="76" y2="89" stroke="#c9a84c" stroke-width="3"/>
              <!-- rising figure -->
              <path d="M92,55 Q100,40 108,55" fill="none" stroke="#fff" stroke-width="2" opacity=".7"/>
            </svg>
            """,

        "Transporter" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- two arrows cycling -->
              <path d="M50,60 Q100,30 150,60" fill="none" stroke="#4caf50" stroke-width="4"
                    marker-end="url(#arrowG)"/>
              <path d="M150,80 Q100,110 50,80" fill="none" stroke="#4caf50" stroke-width="4"
                    marker-end="url(#arrowG2)"/>
              <defs>
                <marker id="arrowG" markerWidth="8" markerHeight="8" refX="6" refY="3" orient="auto">
                  <path d="M0,0 L0,6 L8,3 z" fill="#4caf50"/>
                </marker>
                <marker id="arrowG2" markerWidth="8" markerHeight="8" refX="6" refY="3" orient="auto">
                  <path d="M0,0 L0,6 L8,3 z" fill="#4caf50"/>
                </marker>
              </defs>
              <circle cx="50" cy="70" r="12" fill="#2e5c2e" stroke="#4caf50" stroke-width="2"/>
              <circle cx="150" cy="70" r="12" fill="#2e5c2e" stroke="#4caf50" stroke-width="2"/>
            </svg>
            """,

        "Jailor" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- bars -->
              <rect x="55" y="25" width="90" height="95" rx="4" fill="none" stroke="#4caf50" stroke-width="3"/>
              <line x1="80"  y1="25" x2="80"  y2="120" stroke="#4caf50" stroke-width="2.5"/>
              <line x1="100" y1="25" x2="100" y2="120" stroke="#4caf50" stroke-width="2.5"/>
              <line x1="120" y1="25" x2="120" y2="120" stroke="#4caf50" stroke-width="2.5"/>
              <!-- padlock -->
              <rect x="82" y="70" width="36" height="28" rx="5" fill="#2e5c2e" stroke="#c9a84c" stroke-width="2"/>
              <path d="M88,70 Q88,55 100,55 Q112,55 112,70" fill="none" stroke="#c9a84c" stroke-width="3"/>
              <circle cx="100" cy="82" r="5" fill="#c9a84c"/>
            </svg>
            """,

        "Tracker" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- footprints path -->
              <ellipse cx="70" cy="110" rx="7" ry="12" fill="#4caf50" opacity=".7" transform="rotate(-15 70 110)"/>
              <ellipse cx="85" cy="95" rx="7" ry="12" fill="#4caf50" opacity=".7" transform="rotate(15 85 95)"/>
              <ellipse cx="100" cy="80" rx="7" ry="12" fill="#4caf50" opacity=".85" transform="rotate(-10 100 80)"/>
              <ellipse cx="115" cy="65" rx="7" ry="12" fill="#4caf50" opacity=".85" transform="rotate(10 115 65)"/>
              <ellipse cx="130" cy="50" rx="7" ry="12" fill="#4caf50" opacity=".9" transform="rotate(-15 130 50)"/>
              <!-- eye -->
              <ellipse cx="145" cy="32" rx="18" ry="10" fill="#2e5c2e" stroke="#4caf50" stroke-width="1.5"/>
              <circle cx="145" cy="32" r="6" fill="#4caf50"/>
              <circle cx="145" cy="32" r="3" fill="#1a2e1a"/>
            </svg>
            """,

        "Lookout" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- large eye -->
              <ellipse cx="100" cy="60" rx="55" ry="32" fill="#1a3a1a" stroke="#4caf50" stroke-width="2.5"/>
              <circle cx="100" cy="60" r="20" fill="#4caf50" opacity=".8"/>
              <circle cx="100" cy="60" r="11" fill="#1a1a1a"/>
              <circle cx="106" cy="55" r="4" fill="#fff" opacity=".7"/>
              <!-- lashes -->
              <line x1="100" y1="28" x2="100" y2="18" stroke="#4caf50" stroke-width="2"/>
              <line x1="78"  y1="35" x2="72"  y2="26" stroke="#4caf50" stroke-width="2"/>
              <line x1="122" y1="35" x2="128" y2="26" stroke="#4caf50" stroke-width="2"/>
              <!-- house below being watched -->
              <polygon points="100,110 70,130 130,130" fill="#2e5c2e" opacity=".6"/>
              <rect x="80" y="130" width="40" height="5" fill="#2e5c2e" opacity=".6"/>
            </svg>
            """,

        "Spy" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- hat + trench coat figure -->
              <ellipse cx="100" cy="38" rx="22" ry="14" fill="#2e5c2e"/>
              <rect x="78" y="34" width="44" height="6" fill="#4caf50"/>
              <circle cx="100" cy="52" r="13" fill="#3a7a3a"/>
              <path d="M87,65 L72,118 L128,118 L113,65 Z" fill="#2e5c2e"/>
              <!-- bug device -->
              <circle cx="155" cy="85" r="10" fill="none" stroke="#c9a84c" stroke-width="2"/>
              <line x1="155" y1="75" x2="155" y2="65" stroke="#c9a84c" stroke-width="1.5"/>
              <line x1="148" y1="78" x2="140" y2="70" stroke="#c9a84c" stroke-width="1.5"/>
              <line x1="162" y1="78" x2="170" y2="70" stroke="#c9a84c" stroke-width="1.5"/>
            </svg>
            """,

        "Crusader" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- cross -->
              <rect x="90" y="15" width="20" height="90" rx="4" fill="#e8d9a0"/>
              <rect x="60" y="45" width="80" height="20" rx="4" fill="#e8d9a0"/>
              <!-- shield overlay -->
              <path d="M100,80 L125,93 L125,115 Q125,130 100,138 Q75,130 75,115 L75,93 Z"
                    fill="#2e5c2e" stroke="#4caf50" stroke-width="1.5" opacity=".85"/>
            </svg>
            """,

        "Psychic" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- moon -->
              <path d="M120,30 Q85,55 85,85 Q85,115 120,130 Q60,125 60,80 Q60,35 120,30Z"
                    fill="#3a4a7a"/>
              <circle cx="115" cy="28" r="26" fill="#1a2e1a"/>
              <!-- stars -->
              <text x="135" y="55" font-size="14" fill="#c9a84c">★</text>
              <text x="148" y="80" font-size="10" fill="#c9a84c">★</text>
              <text x="130" y="95" font-size="8" fill="#e8d9a0">★</text>
              <!-- third eye -->
              <ellipse cx="86" cy="82" rx="12" ry="8" fill="#9c27b0" opacity=".7"/>
              <circle cx="86" cy="82" r="4" fill="#ce93d8"/>
            </svg>
            """,

        "Trap Master" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- bear trap -->
              <path d="M60,90 Q60,55 100,50 Q140,55 140,90" fill="none" stroke="#4caf50" stroke-width="4"/>
              <path d="M60,90 Q70,120 100,115 Q130,120 140,90" fill="none" stroke="#4caf50" stroke-width="4"/>
              <!-- teeth -->
              <polyline points="65,88 72,78 79,88 86,78 93,88 100,78 107,88 114,78 121,88 128,78 135,88"
                        fill="none" stroke="#4caf50" stroke-width="2.5"/>
              <!-- spring -->
              <line x1="100" y1="115" x2="100" y2="135" stroke="#c9a84c" stroke-width="3"/>
              <ellipse cx="100" cy="135" rx="15" ry="5" fill="#2e5c2e" stroke="#4caf50" stroke-width="1.5"/>
            </svg>
            """,

        "Coroner" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a2e1a"/>
              <!-- stretcher / body outline -->
              <rect x="45" y="75" width="110" height="40" rx="5" fill="#2e5c2e" stroke="#4caf50" stroke-width="2"/>
              <ellipse cx="100" cy="75" rx="20" ry="22" fill="#2e5c2e" stroke="#4caf50" stroke-width="1.5"/>
              <!-- clipboard -->
              <rect x="75" y="25" width="50" height="65" rx="3" fill="#3a7a3a" stroke="#4caf50" stroke-width="1.5"/>
              <rect x="88" y="20" width="24" height="10" rx="4" fill="#2e5c2e" stroke="#4caf50" stroke-width="1.5"/>
              <line x1="83" y1="42" x2="117" y2="42" stroke="#a0f0a0" stroke-width="1.5"/>
              <line x1="83" y1="52" x2="117" y2="52" stroke="#a0f0a0" stroke-width="1.5"/>
              <line x1="83" y1="62" x2="105" y2="62" stroke="#a0f0a0" stroke-width="1.5"/>
            </svg>
            """,

        // ── Mafia ─────────────────────────────────────────────────────────────
        "Mafia" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#0d0d2a"/>
              <!-- silhouette with fedora -->
              <ellipse cx="100" cy="45" rx="22" ry="18" fill="#1a1a4e"/>
              <ellipse cx="100" cy="34" rx="28" ry="10" fill="#3949ab"/>
              <rect x="72" y="28" width="56" height="8" fill="#3949ab"/>
              <path d="M87,63 L75,120 L125,120 L113,63 Z" fill="#1a1a4e"/>
              <!-- rose -->
              <circle cx="130" cy="75" r="10" fill="#8b1a1a" opacity=".8"/>
              <path d="M130,85 L126,110" stroke="#2e5c2e" stroke-width="2.5"/>
            </svg>
            """,

        "Godfather" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#0d0d2a"/>
              <!-- throne silhouette -->
              <rect x="65" y="30" width="70" height="90" rx="4" fill="#1a1a4e" stroke="#3949ab" stroke-width="2"/>
              <rect x="55" y="28" width="90" height="12" rx="4" fill="#3949ab"/>
              <rect x="55" y="108" width="20" height="15" rx="3" fill="#3949ab"/>
              <rect x="125" y="108" width="20" height="15" rx="3" fill="#3949ab"/>
              <!-- crown -->
              <polygon points="78,28 85,10 100,22 115,10 122,28" fill="#c9a84c"/>
              <circle cx="100" cy="22" r="4" fill="#e8c96d"/>
              <!-- rose -->
              <circle cx="100" cy="72" r="14" fill="#8b1a1a" opacity=".7"/>
              <path d="M100,86 L100,102" stroke="#2e5c2e" stroke-width="2.5"/>
            </svg>
            """,

        "Consigliere" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#0d0d2a"/>
              <!-- eye + dossier -->
              <rect x="55" y="50" width="90" height="65" rx="4" fill="#1a1a4e" stroke="#3949ab" stroke-width="1.5"/>
              <line x1="65" y1="68" x2="135" y2="68" stroke="#3949ab" stroke-width="1.5"/>
              <line x1="65" y1="80" x2="135" y2="80" stroke="#3949ab" stroke-width="1.5"/>
              <line x1="65" y1="92" x2="110" y2="92" stroke="#3949ab" stroke-width="1.5"/>
              <!-- eye above -->
              <ellipse cx="100" cy="35" rx="30" ry="16" fill="#0d0d2a" stroke="#3949ab" stroke-width="2"/>
              <circle cx="100" cy="35" r="9" fill="#3949ab"/>
              <circle cx="100" cy="35" r="4" fill="#0d0d2a"/>
              <circle cx="103" cy="32" r="2" fill="#a0a8f0" opacity=".7"/>
            </svg>
            """,

        "Blackmailer" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#0d0d2a"/>
              <!-- silenced mouth -->
              <ellipse cx="100" cy="80" rx="45" ry="30" fill="#1a1a4e" stroke="#3949ab" stroke-width="2"/>
              <path d="M65,80 Q100,100 135,80" fill="none" stroke="#a0a8f0" stroke-width="3"/>
              <!-- stitches -->
              <line x1="82" y1="75" x2="82" y2="85" stroke="#c0392b" stroke-width="2"/>
              <line x1="95" y1="73" x2="95" y2="87" stroke="#c0392b" stroke-width="2"/>
              <line x1="108" y1="73" x2="108" y2="87" stroke="#c0392b" stroke-width="2"/>
              <line x1="121" y1="75" x2="121" y2="85" stroke="#c0392b" stroke-width="2"/>
              <!-- letter -->
              <rect x="55" y="20" width="50" height="38" rx="3" fill="#1a1a4e" stroke="#c9a84c" stroke-width="1.5"/>
              <path d="M55,20 L80,38 L105,20" fill="none" stroke="#c9a84c" stroke-width="1.5"/>
            </svg>
            """,

        "Consort" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#0d0d2a"/>
              <!-- elegant silhouette -->
              <circle cx="100" cy="38" r="15" fill="#3949ab" opacity=".85"/>
              <path d="M100,53 Q82,78 78,108" fill="none" stroke="#3949ab" stroke-width="4" stroke-linecap="round"/>
              <path d="M100,53 Q118,78 122,108" fill="none" stroke="#3949ab" stroke-width="4" stroke-linecap="round"/>
              <path d="M86,74 Q70,82 58,74" fill="none" stroke="#3949ab" stroke-width="3.5" stroke-linecap="round"/>
              <path d="M114,74 Q130,82 142,74" fill="none" stroke="#3949ab" stroke-width="3.5" stroke-linecap="round"/>
              <text x="40" y="45" font-size="16" fill="#8b1a1a" opacity=".8">♥</text>
              <text x="148" y="52" font-size="12" fill="#8b1a1a" opacity=".6">♥</text>
            </svg>
            """,

        "Framer" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#0d0d2a"/>
              <!-- picture frame -->
              <rect x="40" y="20" width="120" height="100" rx="5" fill="none" stroke="#3949ab" stroke-width="6"/>
              <rect x="52" y="32" width="96" height="76" rx="3" fill="none" stroke="#3949ab" stroke-width="2"/>
              <!-- false portrait inside -->
              <ellipse cx="100" cy="60" rx="18" ry="20" fill="#1a1a4e" stroke="#c9a84c" stroke-width="1"/>
              <rect x="72" y="78" width="56" height="22" rx="4" fill="#1a1a4e"/>
              <!-- fingerprint smudge -->
              <circle cx="155" cy="25" r="8" fill="none" stroke="#c0392b" stroke-width="1.5" stroke-dasharray="2 2"/>
            </svg>
            """,

        "Disguiser" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#0d0d2a"/>
              <!-- theater mask duo -->
              <path d="M55,45 Q55,20 80,20 Q105,20 105,45 Q105,70 80,78 Q55,70 55,45Z"
                    fill="#2e2e6e" stroke="#3949ab" stroke-width="2"/>
              <path d="M95,55 Q95,30 120,30 Q145,30 145,55 Q145,80 120,88 Q95,80 95,55Z"
                    fill="#1a1a4e" stroke="#3949ab" stroke-width="2"/>
              <!-- smiling mouth -->
              <path d="M65,52 Q80,62 95,52" fill="none" stroke="#a0a8f0" stroke-width="2"/>
              <!-- sad mouth -->
              <path d="M105,65 Q120,55 135,65" fill="none" stroke="#a0a8f0" stroke-width="2"/>
            </svg>
            """,

        "Forger" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#0d0d2a"/>
              <!-- parchment scroll -->
              <rect x="50" y="30" width="100" height="80" rx="6" fill="#2e2818" stroke="#c9a84c" stroke-width="1.5"/>
              <ellipse cx="50"  cy="70" rx="12" ry="40" fill="#3a3020" stroke="#c9a84c" stroke-width="1"/>
              <ellipse cx="150" cy="70" rx="12" ry="40" fill="#3a3020" stroke="#c9a84c" stroke-width="1"/>
              <line x1="65" y1="52" x2="135" y2="52" stroke="#c9a84c" stroke-width="1" opacity=".4"/>
              <line x1="65" y1="62" x2="135" y2="62" stroke="#c9a84c" stroke-width="1" opacity=".4"/>
              <line x1="65" y1="72" x2="120" y2="72" stroke="#c9a84c" stroke-width="1" opacity=".4"/>
              <!-- quill -->
              <path d="M130,40 Q155,20 165,10 Q155,35 140,50 Z" fill="#a0a8f0" opacity=".8"/>
              <line x1="140" y1="50" x2="100" y2="90" stroke="#a0a8f0" stroke-width="1.5"/>
            </svg>
            """,

        "Janitor" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#0d0d2a"/>
              <!-- broom -->
              <line x1="60" y1="20" x2="140" y2="120" stroke="#8b6914" stroke-width="5" stroke-linecap="round"/>
              <ellipse cx="148" cy="126" rx="25" ry="10" fill="#3a3020" stroke="#c9a84c" stroke-width="1.5" transform="rotate(-45 148 126)"/>
              <!-- sparkle clean marks -->
              <text x="40" y="80" font-size="16" fill="#3949ab" opacity=".8">✦</text>
              <text x="130" y="50" font-size="12" fill="#3949ab" opacity=".6">✦</text>
              <text x="75" y="115" font-size="10" fill="#3949ab" opacity=".5">✦</text>
            </svg>
            """,

        "Hypnotist" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#0d0d2a"/>
              <!-- spiral -->
              <path d="M100,70 m0,-40 a40,40 0 1,1 -0.1,0 Z" fill="none" stroke="#3949ab" stroke-width="2" stroke-dasharray="5 3"/>
              <path d="M100,70 m0,-28 a28,28 0 1,1 -0.1,0 Z" fill="none" stroke="#3949ab" stroke-width="2"/>
              <path d="M100,70 m0,-18 a18,18 0 1,1 -0.1,0 Z" fill="none" stroke="#3949ab" stroke-width="2"/>
              <path d="M100,70 m0,-10 a10,10 0 1,1 -0.1,0 Z" fill="none" stroke="#3949ab" stroke-width="2"/>
              <circle cx="100" cy="70" r="4" fill="#3949ab"/>
              <!-- pendulum -->
              <line x1="100" y1="10" x2="100" y2="32" stroke="#c9a84c" stroke-width="2"/>
              <circle cx="100" cy="36" r="6" fill="#c9a84c"/>
            </svg>
            """,

        "Ambusher" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#0d0d2a"/>
              <!-- crouched figure behind cover -->
              <rect x="55" y="85" width="60" height="30" rx="4" fill="#1a1a4e" stroke="#3949ab" stroke-width="1.5"/>
              <circle cx="80" cy="78" r="13" fill="#1a1a4e" stroke="#3949ab" stroke-width="1.5"/>
              <!-- knife raised -->
              <line x1="90" y1="70" x2="110" y2="30" stroke="#a0a8f0" stroke-width="4" stroke-linecap="round"/>
              <polygon points="110,30 118,22 118,35 106,28" fill="#a0a8f0"/>
              <!-- exclamation marks -->
              <text x="140" y="60" font-size="24" fill="#c9a84c" opacity=".7">!</text>
              <text x="155" y="55" font-size="16" fill="#c9a84c" opacity=".5">!</text>
            </svg>
            """,

        // ── Neutral ───────────────────────────────────────────────────────────
        "Serial Killer" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a0a0a"/>
              <!-- creepy mask -->
              <ellipse cx="100" cy="65" rx="42" ry="50" fill="#2a1a1a" stroke="#8b1a1a" stroke-width="2"/>
              <ellipse cx="82" cy="55" rx="10" ry="14" fill="#1a0a0a"/>
              <ellipse cx="118" cy="55" rx="10" ry="14" fill="#1a0a0a"/>
              <circle cx="82" cy="55" r="4" fill="#c0392b"/>
              <circle cx="118" cy="55" r="4" fill="#c0392b"/>
              <path d="M72,85 Q100,75 128,85" fill="none" stroke="#8b1a1a" stroke-width="3"/>
              <!-- knife -->
              <line x1="148" y1="20" x2="170" y2="120" stroke="#a0a8f0" stroke-width="3" stroke-linecap="round"/>
              <rect x="143" y="15" width="14" height="10" rx="2" fill="#8b6914"/>
            </svg>
            """,

        "Arsonist" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a0a00"/>
              <!-- flame -->
              <path d="M100,125 Q60,100 65,65 Q70,40 85,30 Q80,55 95,50 Q88,35 105,15 Q118,40 115,55 Q130,45 125,65 Q135,55 140,75 Q145,100 100,125Z"
                    fill="#c0392b"/>
              <path d="M100,125 Q72,108 74,80 Q78,60 88,52 Q85,68 97,63 Q93,52 105,35 Q114,55 112,66 Q122,59 118,78 Q124,68 126,85 Q130,104 100,125Z"
                    fill="#e67e22"/>
              <path d="M100,125 Q82,112 83,90 Q86,74 95,65 Q93,78 100,75 Q100,62 107,55 Q112,70 110,80 Q116,73 114,88 Q116,100 100,125Z"
                    fill="#f1c40f"/>
              <!-- gas can -->
              <rect x="40" y="85" width="30" height="40" rx="4" fill="#3a3020" stroke="#c9a84c" stroke-width="1.5"/>
              <rect x="50" y="78" width="12" height="10" rx="2" fill="#3a3020" stroke="#c9a84c" stroke-width="1.5"/>
            </svg>
            """,

        "Witch" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#120018"/>
              <!-- witch hat -->
              <polygon points="100,10 65,65 135,65" fill="#3d1a6e"/>
              <ellipse cx="100" cy="65" rx="45" ry="12" fill="#4a2080"/>
              <!-- cauldron -->
              <ellipse cx="100" cy="115" rx="38" ry="15" fill="#1a0a2e" stroke="#9c27b0" stroke-width="2"/>
              <path d="M62,100 Q62,115 100,120 Q138,115 138,100 L135,88 Q130,100 100,103 Q70,100 65,88 Z"
                    fill="#1a0a2e" stroke="#9c27b0" stroke-width="2"/>
              <!-- bubbles -->
              <circle cx="88"  cy="95" r="5" fill="#9c27b0" opacity=".6"/>
              <circle cx="108" cy="90" r="7" fill="#9c27b0" opacity=".5"/>
              <circle cx="100" cy="82" r="4" fill="#ce93d8" opacity=".5"/>
            </svg>
            """,

        "Jester" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#2a1a00"/>
              <!-- jester hat -->
              <path d="M70,65 Q55,30 75,15 Q85,45 100,40 Q115,45 125,15 Q145,30 130,65 Z" fill="#c9a84c"/>
              <circle cx="75" cy="15" r="8" fill="#8b1a1a"/>
              <circle cx="125" cy="15" r="8" fill="#1a1a8b"/>
              <circle cx="100" cy="40" r="7" fill="#2e5c2e"/>
              <!-- face -->
              <ellipse cx="100" cy="80" rx="30" ry="28" fill="#e8d9a0"/>
              <ellipse cx="88" cy="75" rx="5" ry="6" fill="#2a1a00"/>
              <ellipse cx="112" cy="75" rx="5" ry="6" fill="#2a1a00"/>
              <path d="M82,90 Q100,106 118,90" fill="none" stroke="#2a1a00" stroke-width="3"/>
            </svg>
            """,

        "Executioner" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a0a0a"/>
              <!-- scales of justice -->
              <line x1="100" y1="20" x2="100" y2="110" stroke="#c9a84c" stroke-width="3"/>
              <line x1="55" y1="48" x2="145" y2="48" stroke="#c9a84c" stroke-width="3"/>
              <!-- pan left (heavier) -->
              <path d="M40,48 Q55,65 70,48" fill="none" stroke="#c9a84c" stroke-width="2"/>
              <ellipse cx="55" cy="70" rx="20" ry="10" fill="#2e2818" stroke="#c9a84c" stroke-width="1.5"/>
              <!-- pan right (lighter / tipped) -->
              <path d="M130,48 Q145,58 160,48" fill="none" stroke="#c9a84c" stroke-width="2"/>
              <ellipse cx="145" cy="60" rx="20" ry="10" fill="#2e2818" stroke="#c9a84c" stroke-width="1.5"/>
              <!-- noose below -->
              <path d="M95,110 Q100,130 105,110" fill="none" stroke="#8b6914" stroke-width="3"/>
            </svg>
            """,

        "Amnesiac" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a1a0a"/>
              <!-- question mark figure -->
              <circle cx="100" cy="50" r="30" fill="none" stroke="#c9a84c" stroke-width="3" stroke-dasharray="6 4"/>
              <text x="88" y="62" font-size="36" fill="#c9a84c" font-family="serif" font-weight="bold">?</text>
              <!-- memory fragments (broken pieces) -->
              <polygon points="40,100 55,90 60,108" fill="#c9a84c" opacity=".4"/>
              <polygon points="65,115 80,100 85,120" fill="#c9a84c" opacity=".35"/>
              <polygon points="150,95 165,105 148,115" fill="#c9a84c" opacity=".3"/>
            </svg>
            """,

        "Guardian Angel" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a1a1a"/>
              <!-- halo -->
              <ellipse cx="100" cy="30" rx="28" ry="10" fill="none" stroke="#c9a84c" stroke-width="3"/>
              <!-- wings -->
              <path d="M100,60 Q55,35 35,55 Q50,75 100,80Z" fill="#d4c9b0" opacity=".7"/>
              <path d="M100,60 Q145,35 165,55 Q150,75 100,80Z" fill="#d4c9b0" opacity=".7"/>
              <!-- body -->
              <circle cx="100" cy="52" r="16" fill="#e8d9a0"/>
              <path d="M88,68 L80,115 L120,115 L112,68 Z" fill="#d4c9b0" opacity=".8"/>
            </svg>
            """,

        "Survivor" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a1a0a"/>
              <!-- vest / bullet-proof -->
              <path d="M70,40 L70,110 L130,110 L130,40 L115,30 L100,40 L85,30 Z"
                    fill="#3a3020" stroke="#c9a84c" stroke-width="2"/>
              <!-- star burst survival -->
              <circle cx="100" cy="75" r="20" fill="#2e2818" stroke="#c9a84c" stroke-width="2"/>
              <text x="88" y="82" font-size="18" fill="#c9a84c">★</text>
              <!-- health cross small -->
              <rect x="93" y="42" width="14" height="4" rx="2" fill="#4caf50"/>
              <rect x="98" y="37" width="4" height="14" rx="2" fill="#4caf50"/>
            </svg>
            """,

        "Pirate" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a1000"/>
              <!-- skull and crossbones -->
              <circle cx="100" cy="52" r="28" fill="#2e2818" stroke="#c9a84c" stroke-width="2"/>
              <ellipse cx="91" cy="46" rx="8" ry="10" fill="#1a1000"/>
              <ellipse cx="109" cy="46" rx="8" ry="10" fill="#1a1000"/>
              <rect x="92" y="72" width="16" height="20" rx="2" fill="#2e2818" stroke="#c9a84c" stroke-width="1.5"/>
              <!-- crossed bones -->
              <line x1="55" y1="95" x2="145" y2="135" stroke="#c9a84c" stroke-width="5" stroke-linecap="round"/>
              <line x1="145" y1="95" x2="55" y2="135" stroke="#c9a84c" stroke-width="5" stroke-linecap="round"/>
              <circle cx="55"  cy="95" r="7" fill="#c9a84c"/>
              <circle cx="145" cy="95" r="7" fill="#c9a84c"/>
              <circle cx="55"  cy="135" r="7" fill="#c9a84c"/>
              <circle cx="145" cy="135" r="7" fill="#c9a84c"/>
            </svg>
            """,

        "Plaguebearer" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#0a1a0a"/>
              <!-- plague doctor mask -->
              <ellipse cx="100" cy="65" rx="35" ry="42" fill="#1a2e1a" stroke="#4caf50" stroke-width="2"/>
              <!-- beak -->
              <polygon points="100,70 75,95 125,95" fill="#2e5c2e" stroke="#4caf50" stroke-width="1.5"/>
              <ellipse cx="86" cy="55" rx="9" ry="11" fill="#0a1a0a" stroke="#4caf50" stroke-width="1.5"/>
              <ellipse cx="114" cy="55" rx="9" ry="11" fill="#0a1a0a" stroke="#4caf50" stroke-width="1.5"/>
              <!-- virus particles -->
              <circle cx="40" cy="35" r="8" fill="none" stroke="#4caf50" stroke-width="1.5"/>
              <line x1="40" y1="27" x2="40" y2="22" stroke="#4caf50" stroke-width="1.5"/>
              <line x1="48" y1="35" x2="53" y2="35" stroke="#4caf50" stroke-width="1.5"/>
              <line x1="32" y1="35" x2="27" y2="35" stroke="#4caf50" stroke-width="1.5"/>
              <circle cx="160" cy="110" r="6" fill="none" stroke="#4caf50" stroke-width="1.5"/>
              <line x1="160" y1="104" x2="160" y2="100" stroke="#4caf50" stroke-width="1.5"/>
              <line x1="166" y1="110" x2="170" y2="110" stroke="#4caf50" stroke-width="1.5"/>
            </svg>
            """,

        // ── Coven ─────────────────────────────────────────────────────────────
        "Coven Leader" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#120018"/>
              <!-- Necronomicon book -->
              <rect x="55" y="35" width="90" height="75" rx="6" fill="#1a0a2e" stroke="#9c27b0" stroke-width="2.5"/>
              <rect x="58" y="38" width="84" height="69" rx="4" fill="#200a3e"/>
              <!-- eye on cover -->
              <ellipse cx="100" cy="72" rx="22" ry="14" fill="#120018" stroke="#9c27b0" stroke-width="2"/>
              <circle cx="100" cy="72" r="8" fill="#9c27b0"/>
              <circle cx="100" cy="72" r="4" fill="#120018"/>
              <circle cx="103" cy="69" r="2" fill="#ce93d8" opacity=".8"/>
              <!-- runes -->
              <text x="62" y="52" font-size="8" fill="#9c27b0" opacity=".7">ᚠ ᚢ ᚦ ᚨ ᚱ</text>
              <text x="62" y="108" font-size="8" fill="#9c27b0" opacity=".7">ᚲ ᚷ ᚹ ᚺ ᚾ</text>
            </svg>
            """,

        "Medusa" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#120018"/>
              <!-- snake hair head -->
              <circle cx="100" cy="75" r="32" fill="#1a0a2e" stroke="#9c27b0" stroke-width="2"/>
              <!-- snakes -->
              <path d="M80,43 Q72,25 65,20 Q72,28 78,43" fill="none" stroke="#4caf50" stroke-width="3" stroke-linecap="round"/>
              <path d="M95,40 Q93,20 88,12 Q95,22 98,40" fill="none" stroke="#4caf50" stroke-width="3" stroke-linecap="round"/>
              <path d="M110,42 Q115,22 122,16 Q116,26 112,42" fill="none" stroke="#4caf50" stroke-width="3" stroke-linecap="round"/>
              <path d="M120,48 Q132,30 138,26 Q130,34 122,50" fill="none" stroke="#4caf50" stroke-width="3" stroke-linecap="round"/>
              <!-- eyes -->
              <ellipse cx="88" cy="72" rx="9" ry="11" fill="#0a1a0a"/>
              <ellipse cx="112" cy="72" rx="9" ry="11" fill="#0a1a0a"/>
              <circle cx="88" cy="72" r="5" fill="#9c27b0"/>
              <circle cx="112" cy="72" r="5" fill="#9c27b0"/>
              <circle cx="88" cy="70" r="2" fill="#fff" opacity=".5"/>
              <circle cx="112" cy="70" r="2" fill="#fff" opacity=".5"/>
            </svg>
            """,

        "Necromancer" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#120018"/>
              <!-- rising skeleton hand -->
              <rect x="65" y="100" width="70" height="20" rx="4" fill="#1a0a2e" stroke="#9c27b0" stroke-width="1.5"/>
              <line x1="80"  y1="100" x2="75"  y2="45" stroke="#d4c9b0" stroke-width="6" stroke-linecap="round"/>
              <line x1="95"  y1="100" x2="92"  y2="38" stroke="#d4c9b0" stroke-width="6" stroke-linecap="round"/>
              <line x1="105" y1="100" x2="108" y2="38" stroke="#d4c9b0" stroke-width="6" stroke-linecap="round"/>
              <line x1="120" y1="100" x2="125" y2="45" stroke="#d4c9b0" stroke-width="6" stroke-linecap="round"/>
              <!-- glow -->
              <circle cx="100" cy="55" r="22" fill="#9c27b0" opacity=".2"/>
              <circle cx="100" cy="55" r="12" fill="#9c27b0" opacity=".3"/>
            </svg>
            """,

        "Hex Master" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#120018"/>
              <!-- hexagram star -->
              <polygon points="100,18 116,46 148,46 124,66 134,96 100,78 66,96 76,66 52,46 84,46"
                       fill="#3d1a6e" stroke="#9c27b0" stroke-width="2"/>
              <polygon points="100,30 110,50 132,50 116,62 122,84 100,70 78,84 84,62 68,50 90,50"
                       fill="none" stroke="#ce93d8" stroke-width="1.5" opacity=".5"/>
              <!-- hex symbols at tips -->
              <circle cx="100" cy="18" r="4" fill="#9c27b0"/>
              <circle cx="148" cy="46" r="4" fill="#9c27b0"/>
              <circle cx="134" cy="96" r="4" fill="#9c27b0"/>
              <circle cx="66"  cy="96" r="4" fill="#9c27b0"/>
              <circle cx="52"  cy="46" r="4" fill="#9c27b0"/>
              <circle cx="116" cy="46" r="3" fill="#ce93d8"/>
            </svg>
            """,

        "Potion Master" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#120018"/>
              <!-- three potions -->
              <!-- red -->
              <rect x="45" y="65" width="28" height="45" rx="8" fill="#8b1a1a" stroke="#c0392b" stroke-width="2"/>
              <rect x="51" y="55" width="16" height="14" rx="3" fill="#3a0a0a" stroke="#c0392b" stroke-width="1.5"/>
              <ellipse cx="59" cy="55" rx="8" ry="3" fill="#c0392b" opacity=".7"/>
              <!-- green -->
              <rect x="86" y="58" width="28" height="52" rx="8" fill="#1a4e1a" stroke="#4caf50" stroke-width="2"/>
              <rect x="92" y="48" width="16" height="14" rx="3" fill="#0a1a0a" stroke="#4caf50" stroke-width="1.5"/>
              <ellipse cx="100" cy="48" rx="8" ry="3" fill="#4caf50" opacity=".7"/>
              <!-- purple -->
              <rect x="127" y="65" width="28" height="45" rx="8" fill="#3d1a6e" stroke="#9c27b0" stroke-width="2"/>
              <rect x="133" y="55" width="16" height="14" rx="3" fill="#120018" stroke="#9c27b0" stroke-width="1.5"/>
              <ellipse cx="141" cy="55" rx="8" ry="3" fill="#9c27b0" opacity=".7"/>
            </svg>
            """,

        "Poisoner" => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#120018"/>
              <!-- skull on vial -->
              <rect x="70" y="55" width="60" height="75" rx="10" fill="#1a0a2e" stroke="#9c27b0" stroke-width="2"/>
              <rect x="82" y="44" width="36" height="18" rx="5" fill="#0a0018" stroke="#9c27b0" stroke-width="1.5"/>
              <circle cx="100" cy="85" r="22" fill="#2a1a3e" stroke="#ce93d8" stroke-width="1.5"/>
              <ellipse cx="91" cy="80" rx="7" ry="9" fill="#120018"/>
              <ellipse cx="109" cy="80" rx="7" ry="9" fill="#120018"/>
              <circle cx="91"  cy="80" r="3" fill="#9c27b0"/>
              <circle cx="109" cy="80" r="3" fill="#9c27b0"/>
              <rect x="93" y="95" width="14" height="10" rx="2" fill="#2a1a3e" stroke="#ce93d8" stroke-width="1"/>
              <!-- drip -->
              <circle cx="100" cy="44" r="6" fill="#9c27b0" opacity=".6"/>
              <path d="M100,38 Q105,25 100,18 Q95,25 100,38Z" fill="#9c27b0" opacity=".6"/>
            </svg>
            """,

        _ => """
            <svg viewBox="0 0 200 140" xmlns="http://www.w3.org/2000/svg">
              <rect width="200" height="140" fill="#1a1612"/>
              <!-- generic card back pattern -->
              <rect x="20" y="15" width="160" height="110" rx="6" fill="none" stroke="#4a3c2a" stroke-width="1.5"/>
              <text x="100" y="80" text-anchor="middle" font-size="48" fill="#4a3c2a">🂠</text>
              <text x="100" y="108" text-anchor="middle" font-size="11" fill="#7a6e5a" font-family="serif">Unknown Role</text>
            </svg>
            """
    };
}
