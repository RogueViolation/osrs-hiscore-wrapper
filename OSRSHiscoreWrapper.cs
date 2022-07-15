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
        //public readonly IConfigurationReader _configurationReader;
        public OSRSHiscoreWrapper()
        {
            _dataAccess = new DataAccess();
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
            for (int i = 0; i <= 23; i++)
            {
                stats.Levels.Add(new OSRSLevel().ToOSRSLevel(OSRSConst.OSRSSkills[i], parsedCsv[i]));
            }
            for (int i = 0; i <= 13; i++)
            {
                stats.Activities.Add(new OSRSActivity().ToOSRSActivity(OSRSConst.OSRSActivities[i], parsedCsv[i + 24]));
            }
            for (int i = 0; i <= 47; i++)
            {
                stats.Bosses.Add(new OSRSBoss().ToOSRSBoss(OSRSConst.OSRSBosses[i], parsedCsv[i + 24 + 13]));
            }

            return new OSRSStats();
        }
    }
    public static class WrapperHelpers
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T element in source)
            {
                action(element);
            }
        }
    }
}
