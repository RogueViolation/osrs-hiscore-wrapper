using HtmlAgilityPack;
using System;

namespace osrs_hiscore_wrapper
{
    public class OSRSHiscoreWrapper
    {
        public OSRSHiscoreWrapper()
        {

        }
        public string GetStats(string username, string mode)
        {
            var scraper = new HtmlWeb();
            var uri = BuildUri(username, mode);
            var html = scraper.Load(uri.ToString());

            return html.Text;
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
