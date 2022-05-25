using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PROBA.POMS
{
    public class HomePage
    {
        private IWebDriver driver { get; }
        public IWebElement AddBackpack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement AddTShirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement AddJacket => driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
        public IWebElement Shop => driver.FindElement(By.Id("shopping_cart_container"));
        public IWebElement Counter => driver.FindElement(By.XPath("//a[@class]/span"));
        

        public HomePage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public bool DispleyedAddBackpack() => AddBackpack.Displayed;
        public bool DisplayedAddTShirt() => AddTShirt.Displayed;
        public bool DisplayedAddJacket() => AddJacket.Displayed;
        public bool DisplayedShop() => Shop.Displayed;
        public bool DisplayedCounter() => Counter.Displayed;
        

        public void ClickBackpack() => AddBackpack.Click();
        public void ClickTshirt() => AddTShirt.Click();
        public void ClickJacket() => AddJacket.Click();
        public void ClickShop() => Shop.Click();

      

    }
}
