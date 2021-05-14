using System.Net.Http;
using System;

namespace osrs_hiscore_wrapper
{
    public class OSRSHiscoreWrapper
    {
        public readonly HttpClient _client;
        public OSRSHiscoreWrapper()
        {
            _client = new HttpClient();
        }
        public string GetStats(string username, string mode)
        {
            var uri = BuildUri(username, mode);
            var result = _client.GetAsync(uri.ToString()).GetAwaiter().GetResult();
            var statsString = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            return statsString;
        }

        public Uri BuildUri(string username, string mode)
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
