using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EAEmployeeTest
{
    [Binding]
   public class Hooks
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private static ExtentKlovReporter KlovReporter;

        private readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }



 
        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlreporter = new ExtentHtmlReporter(@"D:\Automation Framework Design\EAAutoFramework\EAAutoFrameWork\HtmlReport\ExtentReport.html");
            htmlreporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            KlovReporter = new ExtentKlovReporter();
            KlovReporter.InitMongoDbConnection("localhost",27017);
            KlovReporter.ProjectName = "EA Automation projectName";
            KlovReporter.ReportName = "Vinay gadu";
            extent.AttachReporter(htmlreporter);
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            //FeatureContext.Current.FeatureInfo.Title = "";
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            //scenario= featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterStep]
        public static void InsertReportingSteps()
        {
            var stepName = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {
                if (stepName == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepName == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepName == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
            }

            if (ScenarioContext.Current.TestError != null)
            {
                if (stepName == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepName == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepName == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
            }


        }


        [BeforeScenario]
        public static void BeforeScenario()
        {
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }
    }
}
