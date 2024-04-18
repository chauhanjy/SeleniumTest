using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.ComponentHelper;
using UnitTestProject2.Settings;

namespace TestScripts.BrowserActions
{
    [TestClass]
    public class TestBrowserActions
    {
        [TestMethod]
        public void TestActions()
        {
            NavigationnHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            BrowserHelper.MaximizeBrowser();
            ButtonHelper.ButtonClick(By.Id("//a[@id='login_Layer']"));
            BrowserHelper.BackBrowser();
            BrowserHelper.ForwardBrowser();
            BrowserHelper.RefreshBrowser();
            
        }
    }
}
