using System;
using System.Collections.Generic;
using System.Text;

namespace osrs_hiscore_wrapper
{
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
            "pvpArena",
            "soulWarsZeal",
            "riftsClosed"
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
            "nex",
            "nightmare",
            "phosaniNightmare",
            "obor",
            "sarachnis",
            "scorpia",
            "skotizo",
            "tempoross",
            "gauntlet",
            "corruptedGauntlet",
            "theatreOfBlood",
            "theatreOfBloodHard",
            "thermonuclearSmokeDevil",
            //"tombsOfAmascut",
            //"tombsOfAmascutExpertMode",
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