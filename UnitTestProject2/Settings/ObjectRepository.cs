using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.Interfaces;
using OpenQA.Selenium;

namespace UnitTestProject2.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }

        public static IWebDriver Driver { get; set; }
    }
}
