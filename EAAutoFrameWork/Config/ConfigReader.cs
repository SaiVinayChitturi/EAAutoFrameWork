using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using EAAutoFrameWork.ConfigElement;
using EAAutoFrameWork.Base;

namespace EAAutoFrameWork.Config
{
   public class ConfigReader
    {
        public static string InitializeTest()
        {
          return ConfigurationManager.AppSettings["AUT"].ToString();
        }

        //public static void SetFrameWorkSettings()
        //{
        //    XPathItem aut;
        //    XPathItem TestType;

        //    string strfilename = "D:\\Automation Framework Design\\EAAutoFramework\\EAAutoFrameWork\\EAEmployeeTest\\bin\\Debug\\config\\GlobalConfig.xml";
        //    Environment.CurrentDirectory.ToString() + "\\config\\GlobalConfig.xml";
        //    FileStream stream = new FileStream(strfilename, FileMode.Open);
        //    XPathDocument document = new XPathDocument(stream);
        //    XPathNavigator navigator = document.CreateNavigator();
        //    aut = navigator.SelectSingleNode("EAAutoFrameWork/RunSettings/AUT");
        //    TestType = navigator.SelectSingleNode("EAAutoFrameWork/RunSettings/TestType");


        //    Settings.AUT = aut.Value.ToString();
        //    Settings.TestType = TestType.Value.ToString();

        //}

        public static void SetFrameWorkSettings()
        {
            Settings.AUT = EATestConfiguration.EASettings.TestSettings["staging"].AUT;
            Settings.TestType= EATestConfiguration.EASettings.TestSettings["staging"].TestType;
            Settings.IsLog = EATestConfiguration.EASettings.TestSettings["staging"].IsLog;
            Settings.LogPath = EATestConfiguration.EASettings.TestSettings["staging"].LogPath;
            Settings.BrowserType=(BrowserType)Enum.Parse(typeof(BrowserType),EATestConfiguration.EASettings.TestSettings["staging"].Browser);
        }
    }
}
