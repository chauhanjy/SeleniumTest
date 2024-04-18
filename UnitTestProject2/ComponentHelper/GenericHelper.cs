using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.Settings;

namespace UnitTestProject2.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IsElementPresent(By Locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(Locator).Count() == 1;
            }
            catch 
            { 
                return false; 
            }
        }
        public static IWebElement GetWebElement(By Locator)
        {
            if (IsElementPresent(Locator))
                return ObjectRepository.Driver.FindElement(Locator);
            else throw new NoSuchElementException("Element not found " + Locator.ToString());
        }
        public static void TakeScreenshot(string filename = "Screen")
        {
            Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            if(filename.Equals("Screen"))
            {
                string name = filename + DateTime.Now.ToString("yyyyy-MM-dd-mm-ss") + ".jpeg";
                screen.SaveAsFile(filename);
                return;
            }
            screen.SaveAsFile(filename);
        }
        public static bool WebElementWait(By locator, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            bool flag = wait.Until(waitForWebElement(locator));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeout());
            return flag;
        }
        public static IWebElement WebElementWaitInPage(By locator, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            IWebElement element = wait.Until(waitForWebElementInPage(locator));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeout());
            return element;
        }
        private static Func<IWebDriver, bool> waitForWebElement(By locator)
        {
            return ((x) =>
            {
                if(x.FindElements(locator).Count == 1)
                return true;
                return false;
            });
        }
        private static Func<IWebDriver, IWebElement> waitForWebElementInPage(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return x.FindElement(locator);
                return null;

            });
        }

    }
}
