﻿public enum PlayerTeam
{
    Neutral = 1,
    Terrorist = 2,
    CounterTerrorist = 3
}
public enum GlowRenderStyle_t
{
    GLOWRENDERSTYLE_DEFAULT = 0,
    GLOWRENDERSTYLE_RIMGLOW3D,
    GLOWRENDERSTYLE_EDGE_HIGHLIGHT,
    GLOWRENDERSTYLE_EDGE_HIGHLIGHT_PULSE,
};

public enum AimPoint
{
    Head,
    Chest,
    Body,
    Any
}

public enum PadStyle
{
    Center,
    Left,
    Right
}
public enum CvarAction
{
    Add,
    Remove,
    Update
}
public enum CONVAR_FLAGS
{
    //-----------------------------------------------------------------------------
    // ConVar flags
    //-----------------------------------------------------------------------------
    // The default, no flags at all
    FCVAR_NONE = 0,

    // Command to ConVars and ConCommands
    // ConVar Systems
    FCVAR_UNREGISTERED = (1 << 0),// If this is set, don't add to linked list, etc.
    FCVAR_DEVELOPMENTONLY = (1 << 1),   // Hidden in released products. Flag is removed automatically if ALLOW_DEVELOPMENT_CVARS is defined.
    FCVAR_GAMEDLL = (1 << 2),// defined by the game DLL
    FCVAR_CLIENTDLL = (1 << 3), // defined by the client DLL
    FCVAR_HIDDEN = (1 << 4),// Hidden. Doesn't appear in find or auto complete. Like DEVELOPMENTONLY, but can't be compiled out.

    // ConVar only
    FCVAR_PROTECTED = (1 << 5),  // It's a server cvar, but we don't send the data since it's a password, etc.  Sends 1 if it's not bland/zero, 0 otherwise as value
    FCVAR_SPONLY = (1 << 6),  // This cvar cannot be changed by clients connected to a multiplayer server.
    FCVAR_ARCHIVE = (1 << 7),   // set to cause it to be saved to vars.rc
    FCVAR_NOTIFY = (1 << 8),// notifies players when changed
    FCVAR_USERINFO = (1 << 9),  // changes the client's info string

    FCVAR_PRINTABLEONLY = (1 << 10), // This cvar's string cannot contain unprintable characters ( e.g., used for player name etc ).

    FCVAR_GAMEDLL_FOR_REMOTE_CLIENTS = (1 << 10),  // When on concommands this allows remote clients to execute this cmd on the server. 
                                                   // We are changing the default behavior of concommands to disallow execution by remote clients without
                                                   // this flag due to the number existing concommands that can lag or crash the server when clients abuse them.

    FCVAR_UNLOGGED = (1 << 11), // If this is a FCVAR_SERVER, don't log changes to the log file / console if we are creating a log
    FCVAR_NEVER_AS_STRING = (1 << 12), // never try to print that cvar

    // It's a ConVar that's shared between the client and the server.
    // At signon, the values of all such ConVars are sent from the server to the client (skipped for local
    //  client, of course )
    // If a change is requested it must come from the console (i.e., no remote client changes)
    // If a value is changed while a server is active, it's replicated to all connected clients
    FCVAR_REPLICATED = (1 << 13),   // server setting enforced on clients, TODO rename to FCAR_SERVER at some time
    FCVAR_CHEAT = (1 << 14), // Only useable in singleplayer / debug / multiplayer & sv_cheats
    FCVAR_SS = (1 << 15), // causes varnameN where N == 2 through max splitscreen slots for mod to be autogenerated
    FCVAR_DEMO = (1 << 16), // record this cvar when starting a demo file
    FCVAR_DONTRECORD = (1 << 17), // don't record these command in demofiles
    FCVAR_SS_ADDED = (1 << 18), // This is one of the "added" FCVAR_SS variables for the splitscreen players
    FCVAR_RELEASE = (1 << 19), // Cvars tagged with this are the only cvars avaliable to customers
    FCVAR_RELOAD_MATERIALS = (1 << 20),// If this cvar changes, it forces a material reload
    FCVAR_RELOAD_TEXTURES = (1 << 21),  // If this cvar changes, if forces a texture reload

    FCVAR_NOT_CONNECTED = (1 << 22),    // cvar cannot be changed by a client that is connected to a server
    FCVAR_MATERIAL_SYSTEM_THREAD = (1 << 23),   // Indicates this cvar is read from the material system thread
    FCVAR_ARCHIVE_GAMECONSOLE = (1 << 24), // cvar written to config.cfg on the Xbox

    FCVAR_SERVER_CAN_EXECUTE = (1 << 28),// the server is allowed to execute this command on clients via ClientCommand/NET_StringCmd/CBaseClientState::ProcessStringCmd.
    FCVAR_SERVER_CANNOT_QUERY = (1 << 29),// If this is set, then the server is not allowed to query this cvar's value (via IServerPluginHelpers::StartQueryCvarValue).
    FCVAR_CLIENTCMD_CAN_EXECUTE = (1 << 30),    // IVEngineClient::ClientCmd is allowed to execute this command. 
                                                // Note: IVEngineClient::ClientCmd_Unrestricted can run any client command.

    FCVAR_ACCESSIBLE_FROM_THREADS = (1 << 25),  // used as a debugging tool necessary to check material system thread convars
                                                // #define FCVAR_AVAILABLE			(1<<26)
                                                // #define FCVAR_AVAILABLE			(1<<27)
                                                // #define FCVAR_AVAILABLE			(1<<31)

    FCVAR_MATERIAL_THREAD_MASK = (FCVAR_RELOAD_MATERIALS | FCVAR_RELOAD_TEXTURES | FCVAR_MATERIAL_SYSTEM_THREAD)
}

public enum Skyboxes
{
    cs_baggage_skybox_,
    cs_tibet,
    embassy,
    italy,
    jungle,
    nukeblank,
    office,
    sky_cs15_daylight01_hdr,
    sky_cs15_daylight02_hdr,
    sky_cs15_daylight03_hdr,
    sky_cs15_daylight04_hdr,
    sky_csgo_cloudy01,
    sky_csgo_night02,
    sky_csgo_night02b,
    sky_dust,
    sky_venice,
    vertigo,
    vietnam
}
public enum BeamType
{
    BEAM_POINTS = 0,
    BEAM_ENTPOINT,
    BEAM_ENTS,
    BEAM_HOSE,
    BEAM_SPLINE,
    BEAM_LASER,
};
public enum UpdateResult
{
    OK,
    NewState,
    LevelChanged,
    Pending,
    None
}
public enum ClientMode
{
    Continue,
    Return
}
public enum BeamClipStyle_t
{
    kNOCLIP = 0, // don't clip (default)
    kGEOCLIP = 1,
    kMODELCLIP = 2,

    kBEAMCLIPSTYLE_NUMBITS = 2, //< number of bits needed to represent this object
};
public enum Beam_Flags_h
{
    FBEAM_STARTENTITY = 0x00000001,
    FBEAM_ENDENTITY = 0x00000002,
    FBEAM_FADEIN = 0x00000004,
    FBEAM_FADEOUT = 0x00000008,
    FBEAM_SINENOISE = 0x00000010,
    FBEAM_SOLID = 0x00000020,
    FBEAM_SHADEIN = 0x00000040,
    FBEAM_SHADEOUT = 0x00000080,
    FBEAM_ONLYNOISEONCE = 0x00000100,       // Only calculate our noise once
    FBEAM_NOTILE = 0x00000200,
    FBEAM_USE_HITBOXES = 0x00000400,        // Attachment indices represent hitbox indices instead when this is set.
    FBEAM_STARTVISIBLE = 0x00000800,        // Has this client actually seen this beam's start entity yet?
    FBEAM_ENDVISIBLE = 0x00001000,      // Has this client actually seen this beam's end entity yet?
    FBEAM_ISACTIVE = 0x00002000,
    FBEAM_FOREVER = 0x00004000,
    FBEAM_HALOBEAM = 0x00008000,        // When drawing a beam with a halo, don't ignore the segments and endwidth
    FBEAM_REVERSED = 0x00010000,
};
public enum SignonState
{
    None = 0, // Menu
    Challenge = 1,
    Connected = 2, // Server welcome message?
    New = 3, // nfi when this is used
    PreSpawn = 4, // Selecting team
    Spawn = 5, // Spawn protected
    Full = 6, // Can move, shoot, etc.
    ChangingLevel = 7
}
public enum ModelScaleType_t
{
    HIERARCHICAL_MODEL_SCALE,
    NONHIERARCHICAL_MODEL_SCALE
};
public enum WeaponModelClassification_t
{
    WEAPON_MODEL_IS_UNCLASSIFIED = 0,
    WEAPON_MODEL_IS_VIEWMODEL,
    WEAPON_MODEL_IS_WORLDMODEL,
    WEAPON_MODEL_IS_DROPPEDMODEL,
    WEAPON_MODEL_IS_UNRECOGNIZED
};
public enum WeaponHoldsPlayerAnimCapability_t
{
    WEAPON_PLAYER_ANIMS_UNKNOWN = 0,
    WEAPON_PLAYER_ANIMS_AVAILABLE,
    WEAPON_PLAYER_ANIMS_NOT_AVAILABLE
};
public enum BONE
{
    Head = 8,
    Neck = 7,
    Chest = 6,
    Body = 5,
    LShoulder = 11,
    TRShoulder = 39,
    CTRShoulder = 41,
}
public enum ObserverMode
{
    OBS_MODE_NONE = 0,  // not in spectator mode
    OBS_MODE_DEATHCAM,  // special mode for death cam animation
    OBS_MODE_FREEZECAM, // zooms to a target, and freeze-frames on them
    OBS_MODE_FIXED,     // view from a fixed camera position
    OBS_MODE_IN_EYE,    // follow a player in first person view
    OBS_MODE_CHASE,     // follow a player in third person view
    OBS_MODE_ROAMING,   // free roaming
    NUM_OBSERVER_MODES,
}

public enum WeaponClass
{
    OTHER,
    HEAVY,
    SMG,
    RIFLE,
    SNIPER,
    PISTOL,
    KNIFE
}
public enum ItemDefinitionIndex
{
    DEAGLE = 1,
    DUALBERETTAS = 2,
    FIVESEVEN = 3,
    GLOCK18 = 4,
    AK47 = 7,
    AUG = 8,
    AWP = 9,
    FAMAS = 10,
    G3SG1 = 11,
    GALILAR = 13,
    M249 = 14,
    M4A4 = 16,
    MAC10 = 17,
    P90 = 19,
    MP5SD = 23,
    UMP45 = 24,
    XM1014 = 25,
    PPBIZON = 26,
    MAG7 = 27,
    NEGEV = 28,
    SAWEDOFF = 29,
    TEC9 = 30,
    TASER = 31,
    P2000 = 32,
    MP7 = 33,
    MP9 = 34,
    NOVA = 35,
    P250 = 36,
    SCAR20 = 38,
    SG553 = 39,
    SSG08 = 40,
    KNIFE = 42,
    FLASHBANG = 43,
    HEGRENADE = 44,
    SMOKEGRENADE = 45,
    MOLOTOV = 46,
    DECOY = 47,
    INCGRENADE = 48,
    C4 = 49,
    KNIFE_T = 59,
    M4A1S = 60,
    BROKENM4A1S = 262204,
    USPS = 61,
    CZ75AUTO = 63,
    R8Revolver = 64,
    KNIFE_BAYONET = 500,
    KNIFE_FLIP = 505,
    KNIFE_GUT = 506,
    KNIFE_KARAMBIT = 507,
    KNIFE_M9_BAYONET = 508,
    KNIFE_TACTICAL = 509,
    KNIFE_FALCHION = 512,
    KNIFE_SURVIVAL_BOWIE = 514,
    KNIFE_BUTTERFLY = 515,
    KNIFE_PUSH = 516,
    KNIFE_SURVIVAL = 518,// 9
    KNIFE_URSUS = 519,   // 10
    KNIFE_GYPSY_JACKKNIFE = 520, // 11
    KNIFE_NOMAD = 521,
    KNIFE_STILETTO = 522,        // 12
    KNIFE_WIDOWMAKER = 523,
    KNIFE_SKELETON = 525// 13
}
public enum GamePhase
{
    GAMEPHASE_WARMUP_ROUND,
    GAMEPHASE_PLAYING_STANDARD,
    GAMEPHASE_PLAYING_FIRST_HALF,
    GAMEPHASE_PLAYING_SECOND_HALF,
    GAMEPHASE_HALFTIME,
    GAMEPHASE_MATCH_ENDED,
    GAMEPHASE_MAX
};

public enum e_RoundEndReason
{
    /*
	NOTE/WARNING: these enum values are stored in demo files,
	they are explicitly numbered for consistency and editing,
	do not renumber existing elements, always add new elements
	with different numeric values!
	*/
    Invalid_Round_End_Reason = -1,
    RoundEndReason_StillInProgress = 0,
    Target_Bombed = 1,
    VIP_Escaped = 2,
    VIP_Assassinated = 3,
    Terrorists_Escaped = 4,
    CTs_PreventEscape = 5,
    Escaping_Terrorists_Neutralized = 6,
    Bomb_Defused = 7,
    CTs_Win = 8,
    Terrorists_Win = 9,
    Round_Draw = 10,
    All_Hostages_Rescued = 11,
    Target_Saved = 12,
    Hostages_Not_Rescued = 13,
    Terrorists_Not_Escaped = 14,
    VIP_Not_Escaped = 15,
    Game_Commencing = 16,
    Terrorists_Surrender = 17,
    CTs_Surrender = 18,
    Terrorists_Planted = 19,
    CTs_ReachedHostage = 20,
    RoundEndReason_Count = 21,
};
public enum KNIFEINDEX
{
    KNIFE_BAYONET = 0,
    KNIFE_FLIP = 1,
    KNIFE_GUT = 2,
    KNIFE_KARAMBIT = 3,
    KNIFE_M9_BAYONET = 4,
    KNIFE_TACTICAL = 5,
    KNIFE_FALCHION = 6,
    KNIFE_SURVIVAL_BOWIE = 7,
    KNIFE_BUTTERFLY = 8,
    KNIFE_PUSH = 9,
    KNIFE_SURVIVAL = 10,// 9
    KNIFE_URSUS = 11,   // 10
    KNIFE_GYPSY_JACKKNIFE = 12, // 11
    KNIFE_NOMAD = 13,
    KNIFE_STILETTO = 14,        // 12
    KNIFE_WIDOWMAKER = 15,
    KNIFE_SKELETON = 16// 13
}

public enum WeaponType
{
    Pistol, MachinePistol, AssaultRifle, ZoomRifle, MachineGun, Sniper, AutoSniper, Shotgun, Grenade, Melee, Special, Unknown
}

public enum PlayerState
{
    Jump = 0, Stand = 1, Crouch = 7
}
public enum FL_TYPE
{
    FL_ONGROUND = (1 << 0), // At rest / on the ground
    FL_DUCKING = (1 << 1),  // Player flag -- Player is fully crouched
    FL_WATERJUMP = (1 << 2),    // player jumping out of water
    FL_ONTRAIN = (1 << 3),// Player is _controlling_ a train, so movement commands should be ignored on client during prediction.
    FL_INRAIN = (1 << 4),   // Indicates the entity is standing in rain
    FL_FROZEN = (1 << 5),// Player is frozen for 3rd person camera
    FL_ATCONTROLS = (1 << 6),// Player can't move, but keeps key inputs for controlling another entity
    FL_CLIENT = (1 << 7),   // Is a player
    FL_FAKECLIENT = (1 << 8),   // Fake client, simulated server side; don't send network messages to them
    FL_INWATER = (1 << 9)   // In water
}
public enum VisibleCheck
{
    SlowTrace,
    RayTrace,
    None
}
public enum RadarStyle
{
    Circular,
    Box
}
public enum VirtualKeys
: ushort
{
    LeftButton = 0x01,
    RightButton = 0x02,
    Cancel = 0x03,
    MiddleButton = 0x04,
    ExtraButton1 = 0x05,
    ExtraButton2 = 0x06,
    Back = 0x08,
    Tab = 0x09,
    Clear = 0x0C,
    Return = 0x0D,
    Shift = 0x10,
    Control = 0x11,
    /// <summary></summary>
    Menu = 0x12,
    /// <summary></summary>
    Pause = 0x13,
    /// <summary></summary>
    CapsLock = 0x14,
    /// <summary></summary>
    Kana = 0x15,
    /// <summary></summary>
    Hangeul = 0x15,
    /// <summary></summary>
    Hangul = 0x15,
    /// <summary></summary>
    Junja = 0x17,
    /// <summary></summary>
    Final = 0x18,
    /// <summary></summary>
    Hanja = 0x19,
    /// <summary></summary>
    Kanji = 0x19,
    /// <summary></summary>
    Escape = 0x1B,
    /// <summary></summary>
    Convert = 0x1C,
    /// <summary></summary>
    NonConvert = 0x1D,
    /// <summary></summary>
    Accept = 0x1E,
    /// <summary></summary>
    ModeChange = 0x1F,
    /// <summary></summary>
    Space = 0x20,
    /// <summary></summary>
    Prior = 0x21,
    /// <summary></summary>
    Next = 0x22,
    /// <summary></summary>
    End = 0x23,
    /// <summary></summary>
    Home = 0x24,
    /// <summary></summary>
    Left = 0x25,
    /// <summary></summary>
    Up = 0x26,
    /// <summary></summary>
    Right = 0x27,
    /// <summary></summary>
    Down = 0x28,
    /// <summary></summary>
    Select = 0x29,
    /// <summary></summary>
    Print = 0x2A,
    /// <summary></summary>
    Execute = 0x2B,
    /// <summary></summary>
    Snapshot = 0x2C,
    /// <summary></summary>
    Insert = 0x2D,
    /// <summary></summary>
    Delete = 0x2E,
    /// <summary></summary>
    Help = 0x2F,
    /// <summary></summary>
    N0 = 0x30,
    /// <summary></summary>
    N1 = 0x31,
    /// <summary></summary>
    N2 = 0x32,
    /// <summary></summary>
    N3 = 0x33,
    /// <summary></summary>
    N4 = 0x34,
    /// <summary></summary>
    N5 = 0x35,
    /// <summary></summary>
    N6 = 0x36,
    /// <summary></summary>
    N7 = 0x37,
    /// <summary></summary>
    N8 = 0x38,
    /// <summary></summary>
    N9 = 0x39,
    /// <summary></summary>
    A = 0x41,
    /// <summary></summary>
    B = 0x42,
    /// <summary></summary>
    C = 0x43,
    /// <summary></summary>
    D = 0x44,
    /// <summary></summary>
    E = 0x45,
    /// <summary></summary>
    F = 0x46,
    /// <summary></summary>
    G = 0x47,
    /// <summary></summary>
    H = 0x48,
    /// <summary></summary>
    I = 0x49,
    /// <summary></summary>
    J = 0x4A,
    /// <summary></summary>
    K = 0x4B,
    /// <summary></summary>
    L = 0x4C,
    /// <summary></summary>
    M = 0x4D,
    /// <summary></summary>
    N = 0x4E,
    /// <summary></summary>
    O = 0x4F,
    /// <summary></summary>
    P = 0x50,
    /// <summary></summary>
    Q = 0x51,
    /// <summary></summary>
    R = 0x52,
    /// <summary></summary>
    S = 0x53,
    /// <summary></summary>
    T = 0x54,
    /// <summary></summary>
    U = 0x55,
    /// <summary></summary>
    V = 0x56,
    /// <summary></summary>
    W = 0x57,
    /// <summary></summary>
    X = 0x58,
    /// <summary></summary>
    Y = 0x59,
    /// <summary></summary>
    Z = 0x5A,
    /// <summary></summary>
    LeftWindows = 0x5B,
    /// <summary></summary>
    RightWindows = 0x5C,
    /// <summary></summary>
    Application = 0x5D,
    /// <summary></summary>
    Sleep = 0x5F,
    /// <summary></summary>
    Numpad0 = 0x60,
    /// <summary></summary>
    Numpad1 = 0x61,
    /// <summary></summary>
    Numpad2 = 0x62,
    /// <summary></summary>
    Numpad3 = 0x63,
    /// <summary></summary>
    Numpad4 = 0x64,
    /// <summary></summary>
    Numpad5 = 0x65,
    /// <summary></summary>
    Numpad6 = 0x66,
    /// <summary></summary>
    Numpad7 = 0x67,
    /// <summary></summary>
    Numpad8 = 0x68,
    /// <summary></summary>
    Numpad9 = 0x69,
    /// <summary></summary>
    Multiply = 0x6A,
    /// <summary></summary>
    Add = 0x6B,
    /// <summary></summary>
    Separator = 0x6C,
    /// <summary></summary>
    Subtract = 0x6D,
    /// <summary></summary>
    Decimal = 0x6E,
    /// <summary></summary>
    Divide = 0x6F,
    /// <summary></summary>
    F1 = 0x70,
    /// <summary></summary>
    F2 = 0x71,
    /// <summary></summary>
    F3 = 0x72,
    /// <summary></summary>
    F4 = 0x73,
    /// <summary></summary>
    F5 = 0x74,
    /// <summary></summary>
    F6 = 0x75,
    /// <summary></summary>
    F7 = 0x76,
    /// <summary></summary>
    F8 = 0x77,
    /// <summary></summary>
    F9 = 0x78,
    /// <summary></summary>
    F10 = 0x79,
    /// <summary></summary>
    F11 = 0x7A,
    /// <summary></summary>
    F12 = 0x7B,
    /// <summary></summary>
    F13 = 0x7C,
    /// <summary></summary>
    F14 = 0x7D,
    /// <summary></summary>
    F15 = 0x7E,
    /// <summary></summary>
    F16 = 0x7F,
    /// <summary></summary>
    F17 = 0x80,
    /// <summary></summary>
    F18 = 0x81,
    /// <summary></summary>
    F19 = 0x82,
    /// <summary></summary>
    F20 = 0x83,
    /// <summary></summary>
    F21 = 0x84,
    /// <summary></summary>
    F22 = 0x85,
    /// <summary></summary>
    F23 = 0x86,
    /// <summary></summary>
    F24 = 0x87,
    /// <summary></summary>
    NumLock = 0x90,
    /// <summary></summary>
    ScrollLock = 0x91,
    /// <summary></summary>
    NEC_Equal = 0x92,
    /// <summary></summary>
    Fujitsu_Jisho = 0x92,
    /// <summary></summary>
    Fujitsu_Masshou = 0x93,
    /// <summary></summary>
    Fujitsu_Touroku = 0x94,
    /// <summary></summary>
    Fujitsu_Loya = 0x95,
    /// <summary></summary>
    Fujitsu_Roya = 0x96,
    /// <summary></summary>
    LeftShift = 0xA0,
    /// <summary></summary>
    RightShift = 0xA1,
    /// <summary></summary>
    LeftControl = 0xA2,
    /// <summary></summary>
    RightControl = 0xA3,
    /// <summary></summary>
    LeftMenu = 0xA4,
    /// <summary></summary>
    RightMenu = 0xA5,
    /// <summary></summary>
    BrowserBack = 0xA6,
    /// <summary></summary>
    BrowserForward = 0xA7,
    /// <summary></summary>
    BrowserRefresh = 0xA8,
    /// <summary></summary>
    BrowserStop = 0xA9,
    /// <summary></summary>
    BrowserSearch = 0xAA,
    /// <summary></summary>
    BrowserFavorites = 0xAB,
    /// <summary></summary>
    BrowserHome = 0xAC,
    /// <summary></summary>
    VolumeMute = 0xAD,
    /// <summary></summary>
    VolumeDown = 0xAE,
    /// <summary></summary>
    VolumeUp = 0xAF,
    /// <summary></summary>
    MediaNextTrack = 0xB0,
    /// <summary></summary>
    MediaPrevTrack = 0xB1,
    /// <summary></summary>
    MediaStop = 0xB2,
    /// <summary></summary>
    MediaPlayPause = 0xB3,
    /// <summary></summary>
    LaunchMail = 0xB4,
    /// <summary></summary>
    LaunchMediaSelect = 0xB5,
    /// <summary></summary>
    LaunchApplication1 = 0xB6,
    /// <summary></summary>
    LaunchApplication2 = 0xB7,
    /// <summary></summary>
    OEM1 = 0xBA,
    /// <summary></summary>
    OEMPlus = 0xBB,
    /// <summary></summary>
    OEMComma = 0xBC,
    /// <summary></summary>
    OEMMinus = 0xBD,
    /// <summary></summary>
    OEMPeriod = 0xBE,
    /// <summary></summary>
    OEM2 = 0xBF,
    /// <summary></summary>
    OEM3 = 0xC0,
    /// <summary></summary>
    OEM4 = 0xDB,
    /// <summary></summary>
    OEM5 = 0xDC,
    /// <summary></summary>
    OEM6 = 0xDD,
    /// <summary></summary>
    OEM7 = 0xDE,
    /// <summary></summary>
    OEM8 = 0xDF,
    /// <summary></summary>
    OEMAX = 0xE1,
    /// <summary></summary>
    OEM102 = 0xE2,
    /// <summary></summary>
    ICOHelp = 0xE3,
    /// <summary></summary>
    ICO00 = 0xE4,
    /// <summary></summary>
    ProcessKey = 0xE5,
    /// <summary></summary>
    ICOClear = 0xE6,
    /// <summary></summary>
    Packet = 0xE7,
    /// <summary></summary>
    OEMReset = 0xE9,
    /// <summary></summary>
    OEMJump = 0xEA,
    /// <summary></summary>
    OEMPA1 = 0xEB,
    /// <summary></summary>
    OEMPA2 = 0xEC,
    /// <summary></summary>
    OEMPA3 = 0xED,
    /// <summary></summary>
    OEMWSCtrl = 0xEE,
    /// <summary></summary>
    OEMCUSel = 0xEF,
    /// <summary></summary>
    OEMATTN = 0xF0,
    /// <summary></summary>
    OEMFinish = 0xF1,
    /// <summary></summary>
    OEMCopy = 0xF2,
    /// <summary></summary>
    OEMAuto = 0xF3,
    /// <summary></summary>
    OEMENLW = 0xF4,
    /// <summary></summary>
    OEMBackTab = 0xF5,
    /// <summary></summary>
    ATTN = 0xF6,
    /// <summary></summary>
    CRSel = 0xF7,
    /// <summary></summary>
    EXSel = 0xF8,
    /// <summary></summary>
    EREOF = 0xF9,
    /// <summary></summary>
    Play = 0xFA,
    /// <summary></summary>
    Zoom = 0xFB,
    /// <summary></summary>
    Noname = 0xFC,
    /// <summary></summary>
    PA1 = 0xFD,
    /// <summary></summary>
    OEMClear = 0xFE
}
public enum BoneSelector
{
    Head = (1 << 0),
    Neck = (1 << 1),
    Chest = (1 << 2),
    Stomach = (1 << 3)
};
public enum HitboxList
{
    HITBOX_HEAD = 0,
    HITBOX_NECK,
    HITBOX_LOWER_NECK,
    HITBOX_PELVIS,
    HITBOX_BODY,
    HITBOX_THORAX,
    HITBOX_CHEST,
    HITBOX_UPPER_CHEST,
    HITBOX_R_THIGH,
    HITBOX_L_THIGH,
    HITBOX_R_CALF,
    HITBOX_L_CALF,
    HITBOX_R_FOOT,
    HITBOX_L_FOOT,
    HITBOX_R_HAND,
    HITBOX_L_HAND,
    HITBOX_R_UPPER_ARM,
    HITBOX_R_FOREARM,
    HITBOX_L_UPPER_ARM,
    HITBOX_L_FOREARM,
    HITBOX_MAX
};
public enum ClientClass
{
    CAI_BaseNPC = 0,
    CAK47 = 1,
    CBaseAnimating = 2,
    CBaseAnimatingOverlay = 3,
    CBaseAttributableItem = 4,
    CBaseButton = 5,
    CBaseCombatCharacter = 6,
    CBaseCombatWeapon = 7,
    CBaseCSGrenade = 8,
    CBaseCSGrenadeProjectile = 9,
    CBaseDoor = 10,
    CBaseEntity = 11,
    CBaseFlex = 12,
    CBaseGrenade = 13,
    CBaseParticleEntity = 14,
    CBasePlayer = 15,
    CBasePropDoor = 16,
    CBaseTeamObjectiveResource = 17,
    CBaseTempEntity = 18,
    CBaseToggle = 19,
    CBaseTrigger = 20,
    CBaseViewModel = 21,
    CBaseVPhysicsTrigger = 22,
    CBaseWeaponWorldModel = 23,
    CBeam = 24,
    CBeamSpotlight = 25,
    CBoneFollower = 26,
    CBRC4Target = 27,
    CBreachCharge = 28,
    CBreachChargeProjectile = 29,
    CBreakableProp = 30,
    CBreakableSurface = 31,
    CBumpMine = 32,
    CBumpMineProjectile = 33,
    CC4 = 34,
    CCascadeLight = 35,
    CChicken = 36,
    CColorCorrection = 37,
    CColorCorrectionVolume = 38,
    CCSGameRulesProxy = 39,
    CCSPlayer = 40,
    CCSPlayerResource = 41,
    CCSRagdoll = 42,
    CCSTeam = 43,
    CDangerZone = 44,
    CDangerZoneController = 45,
    CDEagle = 46,
    CDecoyGrenade = 47,
    CDecoyProjectile = 48,
    CDrone = 49,
    CDronegun = 50,
    CDynamicLight = 51,
    CDynamicProp = 52,
    CEconEntity = 53,
    CEconWearable = 54,
    CEmbers = 55,
    CEntityDissolve = 56,
    CEntityFlame = 57,
    CEntityFreezing = 58,
    CEntityParticleTrail = 59,
    CEnvAmbientLight = 60,
    CEnvDetailController = 61,
    CEnvDOFController = 62,
    CEnvGasCanister = 63,
    CEnvParticleScript = 64,
    CEnvProjectedTexture = 65,
    CEnvQuadraticBeam = 66,
    CEnvScreenEffect = 67,
    CEnvScreenOverlay = 68,
    CEnvTonemapController = 69,
    CEnvWind = 70,
    CFEPlayerDecal = 71,
    CFireCrackerBlast = 72,
    CFireSmoke = 73,
    CFireTrail = 74,
    CFish = 75,
    CFists = 76,
    CFlashbang = 77,
    CFogController = 78,
    CFootstepControl = 79,
    CFunc_Dust = 80,
    CFunc_LOD = 81,
    CFuncAreaPortalWindow = 82,
    CFuncBrush = 83,
    CFuncConveyor = 84,
    CFuncLadder = 85,
    CFuncMonitor = 86,
    CFuncMoveLinear = 87,
    CFuncOccluder = 88,
    CFuncReflectiveGlass = 89,
    CFuncRotating = 90,
    CFuncSmokeVolume = 91,
    CFuncTrackTrain = 92,
    CGameRulesProxy = 93,
    CGrassBurn = 94,
    CHandleTest = 95,
    CHEGrenade = 96,
    CHostage = 97,
    CHostageCarriableProp = 98,
    CIncendiaryGrenade = 99,
    CInferno = 100,
    CInfoLadderDismount = 101,
    CInfoMapRegion = 102,
    CInfoOverlayAccessor = 103,
    CItem_Healthshot = 104,
    CItemCash = 105,
    CItemDogtags = 106,
    CKnife = 107,
    CKnifeGG = 108,
    CLightGlow = 109,
    CMapVetoPickController = 110,
    CMaterialModifyControl = 111,
    CMelee = 112,
    CMolotovGrenade = 113,
    CMolotovProjectile = 114,
    CMovieDisplay = 115,
    CParadropChopper = 116,
    CParticleFire = 117,
    CParticlePerformanceMonitor = 118,
    CParticleSystem = 119,
    CPhysBox = 120,
    CPhysBoxMultiplayer = 121,
    CPhysicsProp = 122,
    CPhysicsPropMultiplayer = 123,
    CPhysMagnet = 124,
    CPhysPropAmmoBox = 125,
    CPhysPropLootCrate = 126,
    CPhysPropRadarJammer = 127,
    CPhysPropWeaponUpgrade = 128,
    CPlantedC4 = 129,
    CPlasma = 130,
    CPlayerPing = 131,
    CPlayerResource = 132,
    CPointCamera = 133,
    CPointCommentaryNode = 134,
    CPointWorldText = 135,
    CPoseController = 136,
    CPostProcessController = 137,
    CPrecipitation = 138,
    CPrecipitationBlocker = 139,
    CPredictedViewModel = 140,
    CProp_Hallucination = 141,
    CPropCounter = 142,
    CPropDoorRotating = 143,
    CPropJeep = 144,
    CPropVehicleDriveable = 145,
    CRagdollManager = 146,
    CRagdollProp = 147,
    CRagdollPropAttached = 148,
    CRopeKeyframe = 149,
    CSCAR17 = 150,
    CSceneEntity = 151,
    CSensorGrenade = 152,
    CSensorGrenadeProjectile = 153,
    CShadowControl = 154,
    CSlideshowDisplay = 155,
    CSmokeGrenade = 156,
    CSmokeGrenadeProjectile = 157,
    CSmokeStack = 158,
    CSnowball = 159,
    CSnowballPile = 160,
    CSnowballProjectile = 161,
    CSpatialEntity = 162,
    CSpotlightEnd = 163,
    CSprite = 164,
    CSpriteOriented = 165,
    CSpriteTrail = 166,
    CStatueProp = 167,
    CSteamJet = 168,
    CSun = 169,
    CSunlightShadowControl = 170,
    CSurvivalSpawnChopper = 171,
    CTablet = 172,
    CTeam = 173,
    CTeamplayRoundBasedRulesProxy = 174,
    CTEArmorRicochet = 175,
    CTEBaseBeam = 176,
    CTEBeamEntPoint = 177,
    CTEBeamEnts = 178,
    CTEBeamFollow = 179,
    CTEBeamLaser = 180,
    CTEBeamPoints = 181,
    CTEBeamRing = 182,
    CTEBeamRingPoint = 183,
    CTEBeamSpline = 184,
    CTEBloodSprite = 185,
    CTEBloodStream = 186,
    CTEBreakModel = 187,
    CTEBSPDecal = 188,
    CTEBubbles = 189,
    CTEBubbleTrail = 190,
    CTEClientProjectile = 191,
    CTEDecal = 192,
    CTEDust = 193,
    CTEDynamicLight = 194,
    CTEEffectDispatch = 195,
    CTEEnergySplash = 196,
    CTEExplosion = 197,
    CTEFireBullets = 198,
    CTEFizz = 199,
    CTEFootprintDecal = 200,
    CTEFoundryHelpers = 201,
    CTEGaussExplosion = 202,
    CTEGlowSprite = 203,
    CTEImpact = 204,
    CTEKillPlayerAttachments = 205,
    CTELargeFunnel = 206,
    CTEMetalSparks = 207,
    CTEMuzzleFlash = 208,
    CTEParticleSystem = 209,
    CTEPhysicsProp = 210,
    CTEPlantBomb = 211,
    CTEPlayerAnimEvent = 212,
    CTEPlayerDecal = 213,
    CTEProjectedDecal = 214,
    CTERadioIcon = 215,
    CTEShatterSurface = 216,
    CTEShowLine = 217,
    CTesla = 218,
    CTESmoke = 219,
    CTESparks = 220,
    CTESprite = 221,
    CTESpriteSpray = 222,
    CTest_ProxyToggle_Networkable = 223,
    CTestTraceline = 224,
    CTEWorldDecal = 225,
    CTriggerPlayerMovement = 226,
    CTriggerSoundOperator = 227,
    CVGuiScreen = 228,
    CVoteController = 229,
    CWaterBullet = 230,
    CWaterLODControl = 231,
    CWeaponAug = 232,
    CWeaponAWP = 233,
    CWeaponBaseItem = 234,
    CWeaponBizon = 235,
    CWeaponCSBase = 236,
    CWeaponCSBaseGun = 237,
    CWeaponCycler = 238,
    CWeaponElite = 239,
    CWeaponFamas = 240,
    CWeaponFiveSeven = 241,
    CWeaponG3SG1 = 242,
    CWeaponGalil = 243,
    CWeaponGalilAR = 244,
    CWeaponGlock = 245,
    CWeaponHKP2000 = 246,
    CWeaponM249 = 247,
    CWeaponM3 = 248,
    CWeaponM4A1 = 249,
    CWeaponMAC10 = 250,
    CWeaponMag7 = 251,
    CWeaponMP5Navy = 252,
    CWeaponMP7 = 253,
    CWeaponMP9 = 254,
    CWeaponNegev = 255,
    CWeaponNOVA = 256,
    CWeaponP228 = 257,
    CWeaponP250 = 258,
    CWeaponP90 = 259,
    CWeaponSawedoff = 260,
    CWeaponSCAR20 = 261,
    CWeaponScout = 262,
    CWeaponSG550 = 263,
    CWeaponSG552 = 264,
    CWeaponSG556 = 265,
    CWeaponShield = 266,
    CWeaponSSG08 = 267,
    CWeaponTaser = 268,
    CWeaponTec9 = 269,
    CWeaponTMP = 270,
    CWeaponUMP45 = 271,
    CWeaponUSP = 272,
    CWeaponXM1014 = 273,
    CWeaponZoneRepulsor = 274,
    CWorld = 275,
    CWorldVguiText = 276,
    DustTrail = 277,
    MovieExplosion = 278,
    ParticleSmokeGrenade = 279,
    RocketTrail = 280,
    SmokeTrail = 281,
    SporeExplosion = 282,
    SporeTrail = 283
}