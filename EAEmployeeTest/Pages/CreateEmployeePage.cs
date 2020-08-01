using EAAutoFrameWork.Base;
using EAEmployeeTest.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Pages
{
    public class CreateEmployeePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement InputName { get; set; }

        [FindsBy(How = How.Id, Using = "Salary")]
        private IWebElement InputSalary { get; set; }

        [FindsBy(How = How.Id, Using = "DurationWorked")]
        private IWebElement InputDuration{ get; set; }

        [FindsBy(How = How.Id, Using = "Grade")]
        private IWebElement InputGrade { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement InputEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@value='Create']")]
        private IWebElement Createbutton { get; set; }


        public void clickoncreateUser()
        {
            Createbutton.Click();
        }

        public void fillEmployeeForm(EmployeeModel employeeModel)
        {
            InputName.SendKeys(employeeModel.Name);
            InputDuration.SendKeys(employeeModel.Duration);
            InputEmail.SendKeys(employeeModel.Email);
            InputGrade.SendKeys(employeeModel.Grade);
            InputSalary.SendKeys(employeeModel.Salary);
        }
    }
}
