using System.Net.Http;
using System;
using osrs_hiscore_wrapper.OSRSWrapper.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace osrs_hiscore_wrapper
{
    public class OSRSHiscoreWrapper
    {
        public readonly IDataAccess _dataAccess;
        public readonly int _skillCount = 24;
        public readonly int _activityCount = 14;
        public OSRSStats _stats;
        public OSRSHiscoreWrapper()
        {
            _dataAccess = new DataAccess();
            _stats = new OSRSStats();
        }
        public string GetStats(string username, string mode)
        {
            return _dataAccess.GetOSRSStatStringData(username, mode);
        }

        public OSRSStats ParseStats(string csv)
        {
            var stats = new OSRSStats();
            var parsedCsv = csv.Split('\n').ToList();
            parsedCsv.RemoveAt(parsedCsv.Count - 1);
            AddHiscoreItemsToList(OSRSConst.OSRSSkills, parsedCsv.Take(_skillCount).ToList());
            AddHiscoreItemsToList(OSRSConst.OSRSActivities, parsedCsv.Skip(_skillCount).Take(_activityCount).ToList());
            AddHiscoreItemsToList(OSRSConst.OSRSBosses, parsedCsv.Skip(_skillCount + _activityCount).ToList());
            var bossCsv = parsedCsv.Skip(_skillCount + _activityCount);
            return _stats;
        }

        public void AddHiscoreItemsToList(string[] section, IList<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                _stats.Stats.Add(section[i], new OSRSStat().ToOSRSStat(items[i]));
            }
        }
    }
}
