using BrowserSpider.Models.Browser.History;
using System;
using System.Data;
using System.Windows.Forms;

namespace BrowserSpider.Models.Browser
{
    class Browser
    {
        protected String name { get; set; }
        protected BrowserHistory history { get; set; }
        

        public DataTable GetBrowserHistoryDataTable() {
            try{
                return history.GetDataTable();
            }catch {
                MessageBox.Show("Failed to retrieve " + name + " browser history. Please ensure history file exists.");
            }

            return null;
        }




    }
}
