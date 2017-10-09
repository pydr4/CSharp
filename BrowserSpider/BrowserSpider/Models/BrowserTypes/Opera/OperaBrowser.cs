using BrowserSpider.Models.Browser.History;
using System;

namespace BrowserSpider.Models.Browser
{
    class OperaBrowser : Browser
    {

        public OperaBrowser() {
            name = "Opera";
            history = new OperaBrowserHistory();            
        }
        
    }
}
