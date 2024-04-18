using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.ComponentHelper;
using UnitTestProject2.Settings;

namespace TestWebElements
{
    [TestClass]
    public class TestWebElements
    {
        [TestMethod]
        public void GetElements()
        {
            NavigationnHelper.NavigateToUrl(@"https://nw.tothenew.com/");
            try
            {
                ReadOnlyCollection<IWebElement> list = ObjectRepository.Driver.FindElements(By.TagName("div"));
                Console.WriteLine("Size : {0}", list.Count);
                Console.WriteLine("First element : {0}", list.ElementAt(0));
            }
            catch(NoSuchElementException e) 
            {
                throw e;
            }
        }
    }
}
