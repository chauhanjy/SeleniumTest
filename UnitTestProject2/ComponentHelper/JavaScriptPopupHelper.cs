using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.Settings;

namespace UnitTestProject2.ComponentHelper
{
    public class JavaScriptPopupHelper
    {
        public static bool IsPopupPresent()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Alert();
                return true;
            }
            catch(NoAlertPresentException)
            {
             return false;    
            }
        }
        public static string GetAlertText()
        {
            if (!IsPopupPresent())
                return "";
            return ObjectRepository.Driver.SwitchTo().Alert().Text;
        }
        public static void AcceptAlert()
        {
            if (!IsPopupPresent())
                return;
            ObjectRepository.Driver.SwitchTo().Alert().Accept();
        }
    }
}
