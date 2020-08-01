using EAAutoFrameWork.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Extensions
{
    public static class WebElementExtensions
    {
        public static void selectDropDownList(this IWebElement element, string value)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByText(value);
        }

        public static IList<IWebElement> GetAllSelectedOptions(this IWebElement element)
        {
            SelectElement ddl = new SelectElement(element);
            return ddl.AllSelectedOptions;
        }

        public static string GetFirstSelectedDropDown(this IWebElement element)
        {
            SelectElement ddl = new SelectElement(element);
            return  ddl.AllSelectedOptions.First().ToString();
        }

        public static string GetLinkText(this IWebElement element)
        {
            return element.Text;
        }

        public static void AssertElementPresence(this IWebElement element)
        {
            if (!(element.Displayed))
            {
                throw new Exception(string.Format("Element Not Present exception"));
            }
        }


        public static void Hover(this IWebElement element)
        {
            Actions actions = new Actions(DriverContext.Driver);
            actions.MoveToElement(element).Perform();
        }

        public static bool isElementPresent(this IWebElement element)
        {
            bool result=false;
            try
            {
                if (element.Displayed)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
           return result;
        }
    }
}
