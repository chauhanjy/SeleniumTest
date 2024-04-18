using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.Settings;

namespace UnitTestProject2.ComponentHelper
{
    public class ButtonHelper
    {
        private static IWebElement element;

        public static void ButtonClick(By locator)
        {
            element = ObjectRepository.Driver.FindElement(locator);
            element.Click();
        }

    }
}
