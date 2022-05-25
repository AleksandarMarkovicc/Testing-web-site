using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROBA.POMS
{
    public class ShopPage
    {
        private IWebDriver driver { get; }
        public ShopPage(IWebDriver _driver)
        {
            driver = _driver;
        }
        public IWebElement RemoveBackpack => driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public bool RemoveBackpackDisplayed() => RemoveBackpack.Displayed;
       
        public IWebElement RemoveJacket => driver.FindElement(By.Id("remove-sauce-labs-fleece-jacket"));
        public bool RemoveJacketDisplayed() => RemoveJacket.Displayed;

        public IWebElement RemoveTShirt => driver.FindElement(By.Id("remove-sauce-labs-bolt-t-shirt"));
        public bool RemoveTShirtDisplayed() => RemoveTShirt.Displayed;

        public IWebElement CheckOut => driver.FindElement(By.Id("checkout"));
        public bool CheckOutDisplayed() => CheckOut.Displayed;
        
        public IWebElement BackToShop => driver.FindElement(By.Id("continue-shopping"));
        public bool BackToShopDisplayed() => BackToShop.Displayed;

        public void ClickRemoveJacket() => RemoveJacket.Click();
        public void ClickRemoveBackpack() => RemoveBackpack.Click();
        public void ClickRemoveTShirt() => RemoveTShirt.Click();

        public void ClickBackToShop() => BackToShop.Click();


    }
}
