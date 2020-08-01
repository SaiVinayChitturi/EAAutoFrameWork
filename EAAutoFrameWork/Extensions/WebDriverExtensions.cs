using EAAutoFrameWork.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Extensions
{
    public static class WebDriverExtensions
    {
        public static void WaitForPageLoaded(this IWebDriver driver)
        {
            driver.WaitForCondition(dri =>
            {

                string state = dri.ExecuteJs("return document.readystate").ToString();
                return state == "complete";

            },10);

        }

        public static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeout)
        {
            Func<T, bool> execute = (arg) =>
            {
                try
                {
                    return condition(arg);
                }
                catch (Exception e)
                {
                    return false;
                }
            };
            var stopwatch = Stopwatch.StartNew();
            while(stopwatch.ElapsedMilliseconds< timeout)
            {
                if (execute(obj))
                {
                    break;
                }
            }
        }

        internal static object ExecuteJs(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor)DriverContext.Driver).ExecuteScript(script);
        }
    }
}
