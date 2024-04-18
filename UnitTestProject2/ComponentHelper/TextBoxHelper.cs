using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2.ComponentHelper
{
    public class TextBoxHelper
    {
        private static IWebElement element;
        public static void TypeInTextBox(By locator, string text)
        {
            element = GenericHelper.GetWebElement(locator);
            element.SendKeys(text);

        }
        public static void ClearTextBox(By locator)
        {
            element = GenericHelper.GetWebElement(locator);
            element.Clear();
        }
    }
}
