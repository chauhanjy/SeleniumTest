using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2.ComponentHelper
{
    public class CheckboxHelper
    {
        private static IWebElement element;
        public void CheckedCheckBox(By locator)
        {
            element = GenericHelper.GetWebElement(locator);
            element.Click();
        }
        public static bool IsCheckboxChecked(By locator)
        {
            element = GenericHelper.GetWebElement(locator);
            string flag = element.GetAttribute("checked");
            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }
    }
}
