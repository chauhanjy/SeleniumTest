using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.ComponentHelper;
using UnitTestProject2.Settings;

namespace TestPageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        
        [TestMethod]
        public void OpenPage()
        {
            NavigationnHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }
    }
}

