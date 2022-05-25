using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROBA
{
    public class BaseTest : IDisposable
    {
        protected IWebDriver driver;
        protected IWebElement element;
        protected bool disposed;

        public BaseTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        protected void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Dispose()
        {
            Dispose(true);

        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
                driver.Quit();
            }
            disposed = true;
        }
        ~BaseTest()
        {
            Dispose(false);
        }

    }
}
