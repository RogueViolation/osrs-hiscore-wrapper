using System;
using System.Collections.Generic;
using System.Text;

namespace osrs_hiscore_wrapper
{
    public class OSRSLevel
    {
        private string StatName { get; set; }
        private int StatLevel { get; set; }
        private long StatRank { get; set; }
        private int StatExperience { get; set; }
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
