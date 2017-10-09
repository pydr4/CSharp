using System;
using System.IO;
using System.Linq;

namespace BrowserSpider.Models.Browser.History
{
    class FirefoxBrowserHistory : BrowserHistory
    {
        public FirefoxBrowserHistory()
        {
            path = BrowserPath.FIREFOX;
            file_name = "places.sqlite";
            query = @"SELECT url as URL, title as Title, date(visit_date / 1000000,'unixepoch', 'localtime' ) AS Date, time(visit_date / 1000000,'unixepoch', 'localtime' ) AS Time FROM moz_historyvisits, moz_places WHERE moz_historyvisits.place_id=moz_places.id ORDER BY visit_date DESC limit 50;";
        }

    }
}
