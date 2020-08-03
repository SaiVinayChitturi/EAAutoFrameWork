using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using EAAutoFrameWork.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EAEmployeeTest
{
    [Binding]
   public class HookInitialize : TestInitializeHook
    {

        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private static ExtentKlovReporter KlovReporter;

        private readonly IObjectContainer _objectContainer;


        public HookInitialize() : base(BrowserType.Chrome)
        {
            initializeSettings();
            NavigateToSite();
        }

        //[BeforeTestRun]
        //public void TestInitialize()
        //{          
        //     initializeSettings();

        //}

        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();

        }




    }
}
