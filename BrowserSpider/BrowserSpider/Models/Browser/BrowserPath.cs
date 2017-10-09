using System;
using System.IO;
using System.Linq;

namespace BrowserSpider.Models.Browser
{
    class BrowserPath
    {
        private BrowserPath() { }

        public static readonly String CHROME  = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\";
        public static readonly String FIREFOX = ReadFirefoxProfile() + "\\";
        public static readonly String OPERA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Opera Software\Opera Stable\";

        private static string ReadFirefoxProfile()
        {
            string mozillaDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla");

            if (Directory.Exists(mozillaDir))
            {
                string firefoxDir = Path.Combine(mozillaDir, "firefox");

                if (Directory.Exists(firefoxDir))
                {
                    string prof_file = Path.Combine(firefoxDir, "profiles.ini");

                    if (File.Exists(prof_file))
                    {
                        StreamReader rdr = new StreamReader(prof_file);

                        string[] lines = rdr.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.None);

                        string location = lines.First(x => x.Contains("Path=")).Split(new string[] { "=" }, StringSplitOptions.None)[1];

                        return Path.Combine(firefoxDir, location);
                    }
                }
            }
            return "";
        }

    }
}
