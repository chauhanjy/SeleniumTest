using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.ComponentHelper;
using UnitTestProject2.Settings;

namespace TestTextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox()
        {
            NavigationnHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            //ButtonHelper.ButtonClick(By.Id("login_Layer"));
            String javascript = "document.getElementById('login_Layer').style.border='2px solid red'";
            IJavaScriptExecutor executor = (IJavaScriptExecutor)ObjectRepository.Driver;
            executor.ExecuteScript(javascript);
            Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            screen.SaveAsFile("Screen.png");
            //TextBoxHelper.TypeInTextBox(By.XPath("//body/div[@id='root']/div[4]/div[2]/div[1]/div[1]/div[2]/div[1]/form[1]/div[2]/input[1]"), ObjectRepository.Config.GetUsername());
           // TextBoxHelper.TypeInTextBox(By.XPath("//body/div[@id='root']/div[4]/div[2]/div[1]/div[1]/div[2]/div[1]/form[1]/div[3]/input[1]"), ObjectRepository.Config.GetPassword());
           // ButtonHelper.ButtonClick(By.XPath("//body/div[@id='root']/div[4]/div[2]/div[1]/div[1]/div[2]/div[1]/form[1]/div[6]/button[1]"));
            

        }

    }
}
