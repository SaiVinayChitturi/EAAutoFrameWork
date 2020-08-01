using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Helpers
{
   public class LogHelpers
    {
       private static string currentdatesheet = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter _streamWriter;

        public static void createLogFile()
        {
            string directory = @"D:\Automation Framework Design\Logfiles\";

            if (Directory.Exists(directory))
            {
                _streamWriter = File.AppendText(directory + currentdatesheet + ".log");
            }
            else
            {
                Directory.CreateDirectory(directory);
                _streamWriter = File.AppendText(directory + currentdatesheet + ".log");
            }

        }

        public static void Write(string logMessage)
        {
            _streamWriter.Write("{0}{1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamWriter.WriteLine($"--{logMessage}");
            _streamWriter.Flush();

        }

    }
}
