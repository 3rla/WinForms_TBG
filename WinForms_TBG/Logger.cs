using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LoggerMethod
{
    public static class Logger
    {
        public static string CreateLogFile()
        {
            string DateTimas = DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss");
            string logPath = @$"\Logai\{DateTimas}_log.txt ";
            string path = Directory.GetCurrentDirectory();
            string mainpath = path + logPath;
            using (StreamWriter writer = new StreamWriter(mainpath, true))
            {

            }
            return mainpath;
        }

        public static void Writelog(string message, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{DateTime.Now} : {message}");
            }
        }
    }
}
