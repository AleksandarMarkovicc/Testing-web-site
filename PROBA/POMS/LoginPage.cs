using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROBA.POMS
{
    public class LoginPage
    {
        private IWebDriver driver { get; }
        public LoginPage(IWebDriver _driver)
        {
            driver = _driver;
        }
        public IWebElement UserName => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.XPath("//input[@value = 'Login']"));

        public void Login (string userName, string paSSword)
        {
            UserName.SendKeys(userName);
            Password.SendKeys(paSSword);
            LoginButton.Click();
        }

    }
}
