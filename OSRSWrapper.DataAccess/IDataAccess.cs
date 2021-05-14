using System;
using System.Collections.Generic;
using System.Text;

namespace osrs_hiscore_wrapper.OSRSWrapper.DataAccess
{
    public interface IDataAccess
    {
        string GetOSRSStatStringData(string username, string gamemode);
    }
}
