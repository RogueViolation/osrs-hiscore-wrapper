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
    }
    public class OSRSLevel
    {
        private string StatName { get; set; }
        private string StatRank { get; set; }
        private string StatLevel { get; set; }
        private string StatExperience { get; set; }

        public OSRSLevel ToOSRSLevel(string skill, string[] items)
        {
            return new OSRSLevel
            {
                StatName = skill,
                StatRank = items[0],
                StatLevel = items[1],
                StatExperience = items[2]
            };
    }

    public class OSRSBoss
    {
        private string BossName { get; set; }
        private int BossKC { get; set; }
        private int BossRank { get; set; }
    }

    public class OSRSActivity
    {
        public string ActivityName { get; set; }
        public int ActivityKC { get; set; }
        public int ActivityRank { get; set; }
    }
}
