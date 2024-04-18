using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.Settings;

namespace UnitTestProject2.ComponentHelper
{
    public class BrowserHelper
    {
        public static void MaximizeBrowser()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }
        public static void BackBrowser()
        {
            ObjectRepository.Driver.Navigate().Back();
        }
        public static void ForwardBrowser()
        {
            ObjectRepository.Driver.Navigate().Forward();
        }
        public static void RefreshBrowser()
        {
            ObjectRepository.Driver.Navigate().Refresh();
        }
        public static void SwitchToWindow(int index = 0)
        {
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;
            if(windows.Count < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window index" + index);
            }
            ObjectRepository.Driver.SwitchTo().Window(windows[index]);
            MaximizeBrowser();
        }
        public static void SwitchToParent()
        {
            var windowids = ObjectRepository.Driver.WindowHandles;
            for(int i = windowids.Count;i>0; i--)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.SwitchTo().Window(windowids[i]);
            }
            ObjectRepository.Driver.SwitchTo().Window(windowids[0]);    
        }
        public static void SwitchToFrame(By locator)
        {
            IReadOnlyCollection<IWebElement> frames = ObjectRepository.Driver.FindElements(locator);
            ObjectRepository.Driver.SwitchTo().DefaultContent();
            if(frames.Count < 0)
            {
                throw new NoSuchFrameException("Invalid frame");
            }
        }
    }
}
