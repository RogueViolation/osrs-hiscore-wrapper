using System;
using System.Collections.Generic;
using System.Text;

namespace osrs_hiscore_wrapper
{
    public class OSRSStats
    {
        public Dictionary<string,OSRSStat> Stats { get; set; }

        public OSRSStats()
        {
            Stats = new Dictionary<string, OSRSStat>();
        }
    }
    public class OSRSStat
    {
        private string StatRank { get; set; }
        private string StatLevel { get; set; }
        private string StatExperience { get; set; }

        public OSRSStat ToOSRSStat(string statItems)
        {
            var skills = statItems.Split(',');
            if (skills.Length == 2)
            {
                return new OSRSStat
                {
                    StatRank = skills[0],
                    StatLevel = skills[1],
                    StatExperience = "-"
                };
            }
            else
            {
                return new OSRSStat
                {
                    StatRank = skills[0],
                    StatLevel = skills[1],
                    StatExperience = skills[2]
                };
            }
        }
    }
}
