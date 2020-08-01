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
        public HookInitialize() : base(BrowserType.Chrome)
        {
            initializeSettings();
            NavigateToSite();
        }

        [BeforeTestRun]
        public void TestInitialize()
        {
            initializeSettings();

        }

        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();

        }
    }
}
