using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.ComponentHelper;
using UnitTestProject2.Settings;

namespace TestScripts.Popups
{
    [TestClass]
    public class TestPopups
    {
        [TestMethod]
        public void TestPopup()
        {
            NavigationnHelper.NavigateToUrl("https://www.w3schools.com/js/js_popup.asp");
            ButtonHelper.ButtonClick(By.XPath("//div[@id='main']/descendant::a[position()=3]"));
            BrowserHelper.SwitchToWindow(1);
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ButtonClick(By.XPath("//button[contains(text(),'Try it')]"));
            var text = JavaScriptPopupHelper.GetAlertText();
            JavaScriptPopupHelper.AcceptAlert();
            ObjectRepository.Driver.SwitchTo().DefaultContent();

        }
    }
}
