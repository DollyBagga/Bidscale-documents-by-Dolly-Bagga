using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class BidscaleSaucedemoScriptShoppingCart
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void BidscaleSaucedemoScriptShoppingCartTest()
        {
// Label: Testing saucelab Shopping Cart
                        driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");
            
// Label: Click on the Shopping Cart          driver.FindElement(By.CssSelector("span.shopping_cart_badge")).Click();
Assert.AreEqual(“Your Cart”, ShoppingCart.Title);
Assert.IsTrue(driver.IsElementPresent(By.Id(“Continue Shopping”)));
            
// Label: Click on the “Continue Shopping” button
   driver.FindElement(By.Id("continue-shopping")).Click();
            

// Label: Again click on the Shopping Cart Icon
            driver.FindElement(By.LinkText("3")).Click();
Assert.IsTrue(driver.IsElementPresent(By.Id(“Checkout”)));
            
// Label: Click on the Checkout button              driver.FindElement(By.CssSelector("div.cart_footer")).Click();
            driver.FindElement(By.Id("checkout")).Click();
Assert.AreEqual(“Checkout:Your Information”, ShoppingCart.Title);
		
// Label: Enter Your Information
            driver.FindElement(By.Id("first-name")).Click();
            driver.FindElement(By.Id("first-name")).Clear();
            driver.FindElement(By.Id("first-name")).SendKeys("Standard");
            driver.FindElement(By.Id("last-name")).Click();
            driver.FindElement(By.Id("last-name")).Clear();
            driver.FindElement(By.Id("last-name")).SendKeys("User");
            driver.FindElement(By.Id("postal-code")).Click();
            driver.FindElement(By.Id("postal-code")).Clear();
            driver.FindElement(By.Id("postal-code")).SendKeys("20169");
            driver.FindElement(By.CssSelector("form")).Click();
Assert.IsTrue(driver.IsElementPresent(By.Id(“Cancel”)));

            
// Label: Click Cancel
            driver.FindElement(By.Id("cancel")).Click();
Assert.AreEqual(“Your Cart”, ShoppingCart.Title);

            
// Label: Click Checkout Again on Your Cart
            driver.FindElement(By.Id("checkout")).Click();
   Assert.AreEqual(“Checkout:Your Information”, ShoppingCart.Title);            
// Label: Enter Your Information
            driver.FindElement(By.Id("first-name")).Click();
            driver.FindElement(By.Id("first-name")).Clear();
            driver.FindElement(By.Id("first-name")).SendKeys("standard");
            driver.FindElement(By.Id("last-name")).Click();
            driver.FindElement(By.Id("last-name")).Clear();
            driver.FindElement(By.Id("last-name")).SendKeys("user");
            driver.FindElement(By.Id("postal-code")).Click();
            driver.FindElement(By.Id("postal-code")).Click();
            driver.FindElement(By.Id("postal-code")).Clear();
            driver.FindElement(By.Id("postal-code")).SendKeys("20169");
            driver.FindElement(By.CssSelector("form")).Click();
            
// Label: Click on Continue button
            driver.FindElement(By.Id("continue")).Click();
Assert.AreEqual(“Checkout:Overview”, ShoppingCart.Title);
            
// Label: Click on Finish
            driver.FindElement(By.Id("finish")).Click();
Assert.AreEqual(“Checkout:Complete”, ShoppingCart.Title);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}

