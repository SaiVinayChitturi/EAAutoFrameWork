using EAAutoFrameWork.Base;
using EAAutoFrameWork.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {
       
        [FindsBy(How=How.Id, Using = "loginLink")]
         IWebElement lnkLogin { get; set; }

        [FindsBy(How = How.Id, Using = "UserName")]
         IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
         IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn btn-default']")]
         IWebElement btnLogin { get; set; }

        [FindsBy(How = How.LinkText, Using = "Employee List")]
         IWebElement LnkEmployeeList { get; set; }

        public EmployeeListPage Login(string[] cred)
        {          
            txtUserName.SendKeys(cred[0]);
           string a= cred[1].ToLower();
            txtPassword.SendKeys(a);
            btnLogin.Submit();
            LnkEmployeeList.Click();

            return GetInstance<EmployeeListPage>();

        }

        public void SpecFlowLogin(string username, string password)
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);           

        }

        public void LoginIntoEAAuto(string[] cred)
        {
            txtUserName.SendKeys(cred[0]);
            string a = cred[1].ToLower();
            txtPassword.SendKeys(a);
            btnLogin.Submit();
        }

        public void LoginLinkClick()
        {
            lnkLogin.Click();
        }

        public HomePage ClickOnLogin()
        {
            btnLogin.Submit();
            return GetInstance<HomePage>();
        }

        public void checkiflogtextboxesexists()
        {
            txtUserName.AssertElementPresence();
        }
    }
}
