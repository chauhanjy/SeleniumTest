using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.ComponentHelper;
using UnitTestProject2.Settings;

namespace TestScripts.MultipleBrowser
{
    [TestClass]
    public class TestMultipleBrowser
    {
        public static void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        [TestMethod]
        public void TestMultipleBrowsers()
        {
            NavigationnHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            IWebElement element = ObjectRepository.Driver.FindElement(By.XPath("//div[@class='w3-example']//descendant::p/a[position()=1]"));
            ScrollToElement(ObjectRepository.Driver, element);
            ButtonHelper.ButtonClick(By.XPath("//a[contains(text(),'Try it Yourself »')]"));
            ReadOnlyCollection<string> window = ObjectRepository.Driver.WindowHandles;
            ObjectRepository.Driver.SwitchTo().Window(window[1]);
            ButtonHelper.ButtonClick(By.Id("//button[@id='runbtn']"));
        }

    }
}
