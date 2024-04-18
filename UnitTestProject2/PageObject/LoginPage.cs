using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2.Settings;

namespace UnitTestProject2.PageObject
{
    public class LoginPage
    {
        #region WebElement
        private By LoginButton = By.Id("login_Layer");
        private By UserName = By.XPath("//div[@class='login-layer']/descendant::input[position()=1]");
        private By Password = By.XPath("//div[@class='login-layer']/descendant::input[position()=2]");
        private By LoginSuccess = By.XPath("//div[@class='login-layer']/descendant::button[position()=1]"); ;
        #endregion

        #region Action
        public void Login()
        {
            ObjectRepository.Driver.FindElement(LoginButton).Click();
            ObjectRepository.Driver.FindElement(UserName).SendKeys(ObjectRepository.Config.GetUsername());
            ObjectRepository.Driver.FindElement(Password).SendKeys(ObjectRepository.Config.GetPassword()); 
            
        }
        #endregion

        #region Navigation
        public void NavigateToHome()
        {
            ObjectRepository.Driver.FindElement(LoginSuccess).Click();
        }
        #endregion

#
    }
}
