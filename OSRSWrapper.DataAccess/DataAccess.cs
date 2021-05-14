using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace osrs_hiscore_wrapper.OSRSWrapper.DataAccess
{
    public class DataAccess: IDataAccess
    {
        public readonly HttpClient _client;

        public DataAccess()
        {
            _client = new HttpClient();
        }

        public string GetOSRSStatStringData(string username, string gamemode)
        {
            var uri = BuildUri(username, gamemode);
            var result = _client.GetAsync(uri.ToString()).GetAwaiter().GetResult();
            var statsString = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            return statsString;
        }

        private Uri BuildUri(string username, string mode)
        {
            var uri = new UriBuilder();
            uri.Scheme = "https";
            uri.Host = "secure.runescape.com";
            uri.Path = OSRSLinks.StatsUrl(OSRSModes.Gamemodes[mode]);
            uri.Query = OSRSLinks.UrlQuery(username);

            return uri.Uri;
        }
    }
}
