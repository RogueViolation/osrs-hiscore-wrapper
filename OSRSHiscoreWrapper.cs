using System.Net.Http;
using osrs_hiscore_wrapper.OSRSWrapper.DataAccess;

namespace osrs_hiscore_wrapper
{
    public class OSRSHiscoreWrapper
    {
        public readonly IDataAccess _dataAccess;
        public OSRSHiscoreWrapper()
        {
            _dataAccess = new DataAccess();
        }
        public string GetStats(string username, string mode)
        {
            return _dataAccess.GetOSRSStatStringData(username, mode);
        }
    }
}
