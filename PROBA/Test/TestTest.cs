using OpenQA.Selenium;
using PROBA.POMS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace PROBA.Test
{
    public class TestTest : BaseTest
    {
        private readonly HomePage homepage;
        private readonly LoginPage loginpage;
        private readonly ShopPage shoppage;
        public TestTest()
        {
            homepage = new HomePage(driver);
            loginpage = new LoginPage(driver);
            shoppage = new ShopPage(driver);
        }
        [Fact(DisplayName = "Login user")]
        public void CorrectUserShouldSuccessfullLogin()
        {
            Navigate("https://www.saucedemo.com/");
            loginpage.Login("standard_user", "secret_sauce");
            Assert.True(homepage.DisplayedAddJacket());
        }
        [Theory]
        [InlineData("locked_out_user", "secret_sauce")]
        [InlineData("aca_aca", "marko_marko")]
        public void InvalidUserRegister(string userName, string paSSword)
        {
            Navigate("https://www.saucedemo.com/");
            loginpage.Login(userName, paSSword);
            Assert.Throws<NoSuchElementException>(() => homepage.DisplayedAddJacket());
        }

        [Fact(DisplayName = "Checked 3 products")]
        public void CheckedProducts_WhenSuccessfullLogin()
        {
            CorrectUserShouldSuccessfullLogin();
            homepage.ClickJacket();
            homepage.ClickBackpack();
            homepage.ClickTshirt();
            
            //Assert.True(homepage.DisplayedCounter());
            Assert.Equal("3", homepage.Counter.Text);
        }
        [Fact(DisplayName ="When checked 3 products click on shop")]
        public void ClickOnShopButton_WhenCheckedProducts()
        {
            CheckedProducts_WhenSuccessfullLogin();
            homepage.ClickShop();
            Assert.True(shoppage.BackToShopDisplayed());
        } 
        [Fact(DisplayName ="Check couter when remove products")]
        public void CheckedCouner()
        {
            ClickOnShopButton_WhenCheckedProducts();
            shoppage.ClickRemoveBackpack();
            shoppage.ClickRemoveJacket();
            shoppage.ClickRemoveTShirt();
            shoppage.ClickBackToShop();
            Assert.True(homepage.DisplayedAddJacket());
            Assert.Throws<NoSuchElementException>(() => homepage.DisplayedCounter());
            
        }

    }
}
