using System;
using System.Collections.Generic;
using System.Text;

namespace osrs_hiscore_wrapper
{
    //public static class OSRSSkills
    //{
    //    public static string Attack => "attack";
    //    public static string Defence => "defence";
    //    public static string Strength => "strength";
    //    public static string Hitpoints => "hitpoints";
    //    public static string Ranged => "ranged";
    //    public static string Prayer => "prayer";
    //    public static string Magic => "magic";
    //    public static string Cooking => "cooking";
    //    public static string Woodcutting => "woodcutting";
    //    public static string Fletching => "fletching";
    //    public static string Fishing => "fishing";
    //    public static string Firemaking => "firemaking";
    //    public static string Crafting => "crafting";
    //    public static string Smithing => "smithing";
    //    public static string Mining => "mining";
    //    public static string Herblore => "herblore";
    //    public static string Agility => "agility";
    //    public static string Thieving => "thieving";
    //    public static string Slayer => "slayer";
    //    public static string Farming => "farming";
    //    public static string Runecraft => "runecraft";
    //    public static string Hunter => "hunter";
    //    public static string Construction => "construction";
    //}
    //public static class OSRSModes
    //{
    //    public static string HiscoreOldschool => "hiscore_oldschool";
    //    public static string HiscoreOldschoolIronman => "hiscore_oldschool_ironman";
    //    public static string HiscoreOldschoolUltimate => "hiscore_oldschool_ultimate";
    //    public static string HiscoreOldschoolHardcore_ironman => "hiscore_oldschool_hardcore_ironman";
    //    public static string HiscoreOldschoolDeadman => "hiscore_oldschool_deadman";
    //    public static string HiscoreOldschoolSeasonal => "hiscore_oldschool_seasonal";
    //    public static string HiscoreOldschoolTournament => "hiscore_oldschool_tournament";
    //}

    public static class OSRSModes
    {
        public static readonly Dictionary<string, string> Gamemodes = new Dictionary<string, string>
        {
            { "main", "hiscore_oldschool" },
            { "ironman", "hiscore_oldschool_ironman" },
            { "ultimate", "hiscore_oldschool_ultimate" },
            { "hardcore", "hiscore_oldschool_hardcore_ironman" },
            { "deadman", "hiscore_oldschool_deadman" },
            { "seasonal", "hiscore_oldschool_seasonal" },
            { "tournament", "hiscore_oldschool_tournament" }
        };
    }

    //public static class OSRSClueTypes
    //{
    //    public static string All => "all";
    //    public static string Beginner => "beginner";
    //    public static string Easy => "easy";
    //    public static string Medium => "medium";
    //    public static string Hard => "hard";
    //    public static string Elite => "elite";
    //    public static string Master => "master";
    //}

    //public static class OSRSBosses
    //{
    //     public static string AbyssalSire => "abyssalSire";  
    //     public static string AlchemicalHydra => "alchemicalHydra";  
    //     public static string Barrows => "barrows";  
    //     public static string Bryophyta => "bryophyta";  
    //     public static string Callisto => "callisto";  
    //     public static string Cerberus => "cerberus";  
    //     public static string ChambersOfXeric => "chambersOfXeric";  
    //     public static string ChambersOfXericChallengeMode => "chambersOfXericChallengeMode";  
    //     public static string ChaosElemental => "chaosElemental";  
    //     public static string ChaosFanatic => "chaosFanatic";  
    //     public static string CommanderZilyana => "commanderZilyana";  
    //     public static string CorporealBeast => "corporealBeast";  
    //     public static string CrazyArchaeologist => "crazyArchaeologist";  
    //     public static string DagannothPrime => "dagannothPrime";  
    //     public static string DagannothRex => "dagannothRex";  
    //     public static string DagannothSupreme => "dagannothSupreme";  
    //     public static string DerangedArchaeologist => "derangedArchaeologist";  
    //     public static string GeneralGraardor => "generalGraardor";  
    //     public static string GiantMole => "giantMole";  
    //     public static string GrotesqueGuardians => "grotesqueGuardians";  
    //     public static string Hespori => "hespori";  
    //     public static string KalphiteQueen => "kalphiteQueen";  
    //     public static string KingBlackDragon => "kingBlackDragon";  
    //     public static string Kraken => "kraken";  
    //     public static string KreeArra => "kreeArra";  
    //     public static string KrilTsutsaroth => "krilTsutsaroth";  
    //     public static string Mimic => "mimic";  
    //     public static string Nightmare => "nightmare";  
    //     public static string Obor => "obor";  
    //     public static string Sarachnis => "sarachnis";  
    //     public static string Scorpia => "scorpia";  
    //     public static string Skotizo => "skotizo";  
    //     public static string Tempoross => "tempoross";  
    //     public static string Gauntlet => "gauntlet";  
    //     public static string CorruptedGauntlet => "corruptedGauntlet";  
    //     public static string TheatreOfBlood => "theatreOfBlood";  
    //     public static string ThermonuclearSmokeDevil => "thermonuclearSmokeDevil";  
    //     public static string TzKalZuk => "tzKalZuk";  
    //     public static string TzTokJad => "tzTokJad";  
    //     public static string Venenatis => "venenatis";  
    //     public static string Vetion => "vetion";  
    //     public static string Vorkath => "vorkath";  
    //     public static string Wintertodt => "wintertodt";  
    //     public static string Zalcano => "zalcano";
    //    public static string Zulrah => "zulrah"; 
    //}

    //public static class OSRSActivities
    //{
    //    public static string LeaguePoints => "leaguePoints";
    //    public static string HunterBH => "hunterBH";
    //    public static string RogueBH => "rogueBH";
    //    public static string AllClues => "allClues";
    //    public static string BeginnerClues => "beginnerClues";
    //    public static string EasyClues => "easyClues";
    //    public static string MediumClues => "mediumClues";
    //    public static string HardClues => "hardClues";
    //    public static string EliteClues => "eliteClues";
    //    public static string MasterClues => "masterClues";
    //    public static string LastManStanding => "lastManStanding";
    //    public static string SoulWarsZeal => "soulWarsZeal";
    //}
    public static class OSRSConst
    {
        public static readonly string[] OSRSSkills = 
        {
            "overall",
            "attack",
            "defence",
            "strength",
            "hitpoints",
            "ranged",
            "prayer",
            "magic",
            "cooking",
            "woodcutting",
            "fletching",
            "fishing",
            "firemaking",
            "crafting",
            "smithing",
            "mining",
            "herblore",
            "agility",
            "thieving",
            "slayer",
            "farming",
            "runecraft",
            "hunter",
            "construction"
        };

        public static readonly string[] OSRSActivities =
        {
            "leaguePoints",
            "hunterBH",
            "rogueBH",
            "allClues",
            "beginnerClues",
            "easyClues",
            "mediumClues",
            "hardClues",
            "eliteClues",
            "masterClues",
            "lastManStanding",
            "soulWarsZeal"
        };

        public static readonly string[] OSRSBosses =
        {
            "abyssalSire",
            "alchemicalHydra",
            "barrows",
            "bryophyta",
            "callisto",
            "cerberus",
            "chambersOfXeric",
            "chambersOfXericChallengeMode",
            "chaosElemental",
            "chaosFanatic",
            "commanderZilyana",
            "corporealBeast",
            "crazyArchaeologist",
            "dagannothPrime",
            "dagannothRex",
            "dagannothSupreme",
            "derangedArchaeologist",
            "generalGraardor",
            "giantMole",
            "grotesqueGuardians",
            "hespori",
            "kalphiteQueen",
            "kingBlackDragon",
            "kraken",
            "kreeArra",
            "krilTsutsaroth",
            "mimic",
            "nightmare",
            "obor",
            "sarachnis",
            "scorpia",
            "skotizo",
            "tempoross",
            "gauntlet",
            "corruptedGauntlet",
            "theatreOfBlood",
            "thermonuclearSmokeDevil",
            "tzKalZuk",
            "tzTokJad",
            "venenatis",
            "vetion",
            "vorkath",
            "wintertodt",
            "zalcano",
            "zulrah"
        };
    }
    public static class OSRSLinks
    {
        public static string BaseUrl => "https://secure.runescape.com/m=hiscore_oldschool";
        public static string StatsUrl(string gamemode) => $"/m={gamemode}/index_lite.ws";
        public static string UrlQuery(string username) => $"player={username}";
    }
}