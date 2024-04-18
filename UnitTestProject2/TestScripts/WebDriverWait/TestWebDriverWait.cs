using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.ComponentHelper;
using UnitTestProject2.Settings;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestWebDriverWait
{
    [TestClass]
    public class TestWebDriverWait
    {
        [TestMethod]
        public void TestWait()
        {
            
            // ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            NavigationnHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(50);
            TextBoxHelper.TypeInTextBox(By.ClassName("suggestor-input "), "testing");
        }

        [TestMethod]
        public void TestDynamicWait() 
        {
            NavigationnHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(50));
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            wait.Until(waitforSearchBox());
        }
        private Func<IWebDriver, bool> waitforSearchBox()
        {
            return ((x) =>
            {
                return x.FindElements(By.XPath("//body/div[@id='root']/div[7]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/input[1]")).Count == 1;
            });
        }

    }
}
