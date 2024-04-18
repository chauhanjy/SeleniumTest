using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.ComponentHelper;
using UnitTestProject2.Settings;

namespace TestScripts.DefaultWait
{
    [TestClass]
    public class HandleDefaultWait
    {
        [TestMethod]
        public void TestDefaultWait()
        {
            NavigationnHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(ObjectRepository.Driver.FindElement(By.XPath("//input[@id='expereinceDD']")));
            wait.PollingInterval = TimeSpan.FromMilliseconds(200);
            wait.Timeout = TimeSpan.FromSeconds(50);
            wait.IgnoreExceptionTypes(typeof(ElementNotVisibleException), typeof(NoSuchElementException));
            wait.Until(changeofvalue());

        }
        private Func<IWebElement, string> changeofvalue()
        {
            return ((x) =>
            {
                SelectElement select = new SelectElement(x);
                if (select.SelectedOption.Text.Equals("Fresher"))
                    return select.SelectedOption.Text;
                return null;

            });
        }
    }
}
