using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UnitTestProject2.Settings;

namespace UnitTestProject2.ComponentHelper
{
    public class ComboBoxHelper
    {
        private static SelectElement select;

        public static void SelectElement(By locator, int index)
        {
            select = new SelectElement(GenericHelper.GetWebElement(locator));
            select.SelectByIndex(index);
        }
        public static void SelectElement(By locator, string text)
        {
            select = new SelectElement(GenericHelper.GetWebElement(locator));
            select.SelectByText(text);
        }
        public static List<string> GetAllElements(By locator) 
        {
            select = new SelectElement(GenericHelper.GetWebElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }
        

     }

}
