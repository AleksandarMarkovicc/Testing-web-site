using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace PROBA
{
    public class ProbaTest : BaseTest
    {
        [Fact(DisplayName = "Login with corect Username and password")]
        public void SuccessfullyLogin()
        {
            Navigate("https://www.saucedemo.com/");
            element = driver.FindElement(By.Id("user-name"));
            Assert.True(element.Displayed);
            element.SendKeys("standard_user");

            element = driver.FindElement(By.Id("password"));
            Assert.True(element.Displayed);
            element.SendKeys("secret_sauce");

            element = driver.FindElement(By.XPath("//input[@value='Login']"));
            Assert.True(element.Displayed);
            element.Click();
            Thread.Sleep(1000);

            element = driver.FindElement(By.ClassName("inventory_item"));
            Assert.True(element.Displayed);

            element = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            Assert.True(element.Displayed);
            element.Click();


            element = driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
            Assert.True(element.Displayed);
            element.Click();

            element = driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
            Assert.True(element.Displayed);
            element.Click();

            element = driver.FindElement(By.XPath("//a[@class]/span"));
            Assert.True(element.Displayed);

            element = driver.FindElement(By.Id("shopping_cart_container"));
            Assert.True(element.Displayed);
            element.Click();

        }
        //[Fact(DisplayName = "Checked 3 products_When success Login")]
        //public void CheckedProduct()
        //{
        //    Navigate("https://www.saucedemo.com/inventory.html");
        //    element = driver.FindElement(By.ClassName("inventory_item"));
        //    Assert.True(element.Displayed);
            


        //}


    }
}
