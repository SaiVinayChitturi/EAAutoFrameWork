using EAAutoFrameWork.Config;
using EAAutoFrameWork.Helpers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Base
{
   public abstract class TestInitializeHook : Base
    {
        public readonly BrowserType Browser;
        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
        }
        public void initializeSettings()
        {
            //set settings
            ConfigReader.SetFrameWorkSettings();

            LogHelpers.createLogFile();
            openBrowser(Browser);
        }

        public virtual void NavigateToSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelpers.Write("Initialized Framework");
        }

        private void openBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver(@"D:\Automation Framework Design\BrowserDrivers");
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver(@"D:\Automation Framework Design\BrowserDrivers");
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                default:
                    break;
            }
        }

    }
}
