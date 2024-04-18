using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.Settings;

namespace UnitTestProject2.ComponentHelper
{
    public class LinkHelper
    {
        public static IWebElement webElement;
        public static void ClickLink(By Locator)
        {
            webElement = GenericHelper.GetWebElement(Locator);
            webElement.Click();
        }
    }
}
