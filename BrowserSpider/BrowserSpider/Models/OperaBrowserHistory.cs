﻿using System;

namespace BrowserSpider.Models
{
    class OperaBrowserHistory : BrowserHistory
    {
        public OperaBrowserHistory()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Opera Software\Opera Stable\History";
            query = @"SELECT url as URL, title as Title, date(last_visit_time / 1000000 + (strftime('%s', '1601-01-01')), 'unixepoch') as Date, time(last_visit_time / 1000000, 'unixepoch', 'localtime') as Time
                      FROM urls ORDER BY last_visit_time DESC limit 50";
            name = "Opera";
        }
    }
}
