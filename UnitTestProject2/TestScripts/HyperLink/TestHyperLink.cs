using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.ComponentHelper;
using UnitTestProject2.Settings;

namespace TestHyperLink
{
    [TestClass]
    public class TestHyperLink
    {
        [TestMethod]
        public void ClickLink() 
        {
            NavigationnHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
           // ObjectRepository.Driver.FindElement(By.LinkText("Help")).Click();
            LinkHelper.ClickLink(By.LinkText("Forgot Password?"));
        }
    }
}
