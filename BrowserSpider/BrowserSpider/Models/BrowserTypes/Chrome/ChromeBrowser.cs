using BrowserSpider.Models.Browser.History;
using System;

namespace BrowserSpider.Models.Browser
{
    class ChromeBrowser : Browser
    {

        public ChromeBrowser() {
            name = "Chrome";
            history = new ChromeBrowserHistory();
        } 
    }
}
