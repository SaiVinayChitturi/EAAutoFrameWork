using System;
using EAAutoFrameWork.Base;
using EAAutoFrameWork.Config;
using EAAutoFrameWork.Helpers;
using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1 : HookInitialize
    {
      
        

       

        [TestMethod]
        public void TableOperation()
        {
            //LogHelpers.createLogFile();
            //ConfigReader.SetFrameWorkSettings();
            //string url = Settings.AUT;//ConfigReader.InitializeTest(); //"http://eaapp.somee.com/";
       
          
            //DriverContext.Browser.GoToUrl(url);
            LogHelpers.Write("Opened the Browser");
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().LoginLinkClick();
            string filepath = @"D:\Excel\Book1.xlsx";
            string[] credentials = ExcelHelpers.ExcelToData(filepath);
            CurrentPage.As<LoginPage>().checkiflogtextboxesexists();
            CurrentPage = CurrentPage.As<LoginPage>().Login(credentials);
            LogHelpers.Write("Logged In");
            var table = CurrentPage.As<EmployeeListPage>().tableread();
            HtmlTableHelper.ReadTable(table);
            HtmlTableHelper.PerformActionOnCell("5", "Name", "Karthik","Edit");

            
            //"Admin", "password"

        }

       

            
    }
}
