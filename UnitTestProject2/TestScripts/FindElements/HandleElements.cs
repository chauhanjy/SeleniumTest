using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.ComponentHelper;
using UnitTestProject2.Settings;

namespace FindElements
{
    [TestClass]
    public class HandleElements
    {
        [TestMethod]
        public void GetElements()
        {
            NavigationnHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            IReadOnlyCollection<IWebElement> elements = ObjectRepository.Driver.FindElements(By.XPath("//input"));
            foreach(var ele in elements)
            {
                Console.WriteLine("ID : {0}", ele.GetAttribute("id"));
            }
        }
    }
}
