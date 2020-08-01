using EAAutoFrameWork.Base;
using EAEmployeeTest.Model;
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
    internal sealed class EmployeeSteps : BaseStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

       
        [Then(@"I click On CreateNew Button in EmployeeList Page")]
        public void ThenIClickOnCreateNewButtonInEmployeeListPage()
        {
            CurrentPage= CurrentPage.As<EmployeeListPage>().btnCreateUserClick();

        }

        [Then(@"I fill Employee form")]
        public void ThenIFillEmployeeForm(Table table)
        {
            var data = table.CreateInstance<EmployeeModel>();
            CurrentPage.As<CreateEmployeePage>().fillEmployeeForm(data);

        }

        [Then(@"I click on Create")]
        public void ThenIClickOnCreate()
        {
            CurrentPage.As<CreateEmployeePage>().clickoncreateUser();
        }


    }
}
