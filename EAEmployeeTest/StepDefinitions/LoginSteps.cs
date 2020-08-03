using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using EAAutoFrameWork.Base;
using EAEmployeeTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EAEmployeeTest.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps : BaseStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
           
            NavigateToSite();
            CurrentPage = GetInstance<HomePage>();
        }

        //public virtual void NavigateToSite()
        //{
        //    DriverContext.Browser.GoToUrl(Settings.AUT);
        //    LogHelpers.Write("Initialized Framework");
        //}

        [Given(@"I see the application Opened")]
        public void GivenISeeTheApplicationOpened()
        {
            CurrentPage.As<HomePage>().CheckIfLoginExists();
        }


        [Given(@"I click On (.*)Link")]
        public void GivenIClickOnLink(string link)
        {
            if (link == "login")
                CurrentPage = CurrentPage.As<HomePage>().ClickLogin();
            else if (link == "EmployeeList")
                CurrentPage = CurrentPage.As<HomePage>().clickEmployeeList();
        }

        [Given(@"I Provide Valide credentials")]
        public void GivenIProvideValideCredentials(Table table)
        {
                    
            var data = table.CreateInstance<Credentails>();
        
            CurrentPage.As<LoginPage>().SpecFlowLogin(data.UserName, data.Password);
        }

        [Then(@"I click on Login")]
        public void ThenIClickOnLogin()
        {
            CurrentPage= CurrentPage.As<LoginPage>().ClickOnLogin();
        }

        [Then(@"User navigates to HomePage")]
        public void ThenUserNavigatesToHomePage()
        {
            if (CurrentPage.As<HomePage>().GetUserNameText().Contains("Admin"))
            {
                Console.WriteLine("Login Success");
            }
            else
            {
                Console.WriteLine("Login is not success");
            }
        }
        [Then(@"I click On EmployeeLink")]
        public void ThenIClickOnEmployeeLink()
        {
            CurrentPage = CurrentPage.As<HomePage>().clickEmployeeList();
            CurrentPage = GetInstance<EmployeeListPage>();
        }


        

    }



}
