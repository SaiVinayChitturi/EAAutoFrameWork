using EAAutoFrameWork.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Pages
{
   public class EmployeeListPage : BasePage
    {
        
        [FindsBy(How = How.LinkText, Using = "Create New")]
         IWebElement btnCreateUser { get; set; }

        [FindsBy(How = How.ClassName, Using = "table")]
         IWebElement tblEmployeeList { get; set; }

        public CreateEmployeePage btnCreateUserClick()
        {
            btnCreateUser.Click();
            return GetInstance<CreateEmployeePage>();
        }

        public IWebElement tableread()
        {
            return tblEmployeeList;
        }
    }
}
