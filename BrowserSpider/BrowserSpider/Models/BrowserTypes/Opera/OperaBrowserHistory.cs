using System;

namespace BrowserSpider.Models.Browser.History
{
    class OperaBrowserHistory : BrowserHistory
    {
        public OperaBrowserHistory()
        {
            path = BrowserPath.OPERA;
            file_name = "History";
            query = @"SELECT url as URL, title as Title, date(last_visit_time / 1000000 + (strftime('%s', '1601-01-01')), 'unixepoch') as Date, time(last_visit_time / 1000000, 'unixepoch', 'localtime') as Time
                      FROM urls ORDER BY last_visit_time DESC limit 50";
        }
    }
}
