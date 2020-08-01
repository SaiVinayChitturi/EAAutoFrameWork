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
   internal class HomePage : BasePage
    {
        [FindsBy(How = How.LinkText, Using = "Login")]
        IWebElement LnkLogin { get; set; }

        [FindsBy(How = How.LinkText, Using = "Register")]
        IWebElement LnkRegister { get; set; }

        [FindsBy(How = How.LinkText, Using = "Employee List")]
        IWebElement LnkEmployeeList { get; set; }

        [FindsBy(How = How.LinkText, Using = "Log off")]
        IWebElement LnkLogOff { get; set; }

        [FindsBy(How = How.LinkText, Using = "Hello admin!")]
        IWebElement LnkUserName { get; set; }


        //internal string GetAboutText()
        //{
        //    return LnkAbout.GetLinkText();
        //}

        internal string GetUserNameText()
        {
            return LnkUserName.GetLinkText();
        }

        internal void CheckIfLoginExists()
        {
            LnkLogin.AssertElementPresence();
        }


        internal LoginPage ClickLogin()
        {
            LnkLogin.Click();
            return GetInstance<LoginPage>();
        }

        internal EmployeeListPage clickEmployeeList()
        {
            LnkEmployeeList.Click();
            return GetInstance<EmployeeListPage>();
        }

    }
}
