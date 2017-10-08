using BrowserSpider.Models;
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
            FirefoxBrowserHistory firefox = new FirefoxBrowserHistory();
            fireFoxDataGrid.DataSource = firefox.GetDataTable();

            //Get Chrome Browser History
            ChromeBrowserHistory chrome = new ChromeBrowserHistory();
            chromeDataGrid.DataSource = chrome.GetDataTable();

            //get Opera Browser History
            OperaBrowserHistory opera = new OperaBrowserHistory();
            operaDataGrid.DataSource = opera.GetDataTable();
        }
    }
}
