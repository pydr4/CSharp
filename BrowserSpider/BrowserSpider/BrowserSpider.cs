using BrowserSpider.Models;
using BrowserSpider.Models.Browser;
using System;
using System.Windows.Forms;

namespace BrowserSpider
{
    public partial class browserSpiderFrm : Form
    {
        public browserSpiderFrm()
        {
            InitializeComponent();
        }

        private void browserSpiderFrm_Load(object sender, EventArgs e)
        {
            //Get Firefox Browser History
            Browser firefox = new FirefoxBrowser();
            fireFoxDataGrid.DataSource = firefox.GetBrowserHistoryDataTable();

            //Get Chrome Browser History
            Browser chrome = new ChromeBrowser();
            chromeDataGrid.DataSource = chrome.GetBrowserHistoryDataTable();

            //get Opera Browser History
            Browser opera = new OperaBrowser();
            operaDataGrid.DataSource = opera.GetBrowserHistoryDataTable();
        }

        private void chromeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
