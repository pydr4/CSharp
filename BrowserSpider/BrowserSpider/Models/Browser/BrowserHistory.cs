using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BrowserSpider.Models.Browser.History
{
    class BrowserHistory
    {
        protected String path { get; set; }
        protected String query { get; set; }
        protected String file_name { get; set; }

        public DataTable GetDataTable() 
        {
            using (SQLiteConnection cn = new SQLiteConnection("Data Source=" + path + file_name + ";Version=3;New=False;Compress=True;"))
            {
                try
                {
                    cn.Open();
                    SQLiteDataAdapter sd = new SQLiteDataAdapter(query, cn);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    return dt;
                }
                catch
                {
                    throw new Exception("History File Does Not Exist");
                }
            }
        }
    }
}
