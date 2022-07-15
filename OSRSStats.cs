using System;
using System.Collections.Generic;
using System.Text;

namespace osrs_hiscore_wrapper
{
    public class OSRSStats
    {
        public List<OSRSLevel> Levels { get; set; }
        public List<OSRSActivity> Activities { get; set; }
        public List<OSRSBoss> Bosses { get; set; }

        public OSRSStats()
        {
            Levels = new List<OSRSLevel>();
            Activities = new List<OSRSActivity>();
            Bosses = new List<OSRSBoss>();
        }
    }
    public class OSRSLevel
    {
        private string StatName { get; set; }
        private string StatRank { get; set; }
        private string StatLevel { get; set; }
        private string StatExperience { get; set; }

        public OSRSLevel ToOSRSLevel(string skill, string items)
        {
            var skills = items.Split(',');
            return new OSRSLevel
            {
                StatName = skill,
                StatRank = skills[0],
                StatLevel = skills[1],
                StatExperience = skills[2]
            };
        }
    }

    public class OSRSBoss
    {
        private string BossName { get; set; }
        private string BossKC { get; set; }
        private string BossRank { get; set; }

        public OSRSBoss ToOSRSBoss(string name, string items)
        {
            var skills = items.Split(',');
            return new OSRSBoss
            {
                BossName = name,
                BossRank = skills[0],
                BossKC = skills[1]
            };
        }
    }

    public class OSRSActivity
    {
        public string ActivityName { get; set; }
        public string ActivityScore { get; set; }
        public string ActivityRank { get; set; }

        public OSRSActivity ToOSRSActivity(string skill, string items)
        {
            var skills = items.Split(',');
            return new OSRSActivity
            {
                ActivityName = skill,
                ActivityRank = skills[0],
                ActivityScore = skills[1]
            };
        }
    }
}
