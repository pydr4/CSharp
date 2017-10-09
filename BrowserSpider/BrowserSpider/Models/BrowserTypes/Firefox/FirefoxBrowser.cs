using BrowserSpider.Models.Browser.History;
using System;
using System.IO;
using System.Linq;

namespace BrowserSpider.Models.Browser
{
    class FirefoxBrowser : Browser
    {

        public FirefoxBrowser() {
            name = "Firefox";
            history = new FirefoxBrowserHistory();
        }

       
    }
}
