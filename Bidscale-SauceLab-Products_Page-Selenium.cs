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
    public class BidscaleSaucelabProductsPage
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.saucedemo.com/inventory.html";
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
        public void BidscaleSaucelabProductsPageTest()
        {
            // Label: Test
                        driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");
 Assert.assertEquals(“Products”, product.Title);
Assert.IsTrue(GenericHelper.IsElementPresent (By.Name(“Add to Cart”)));           

// Label: Click on Sort dropdown
            driver.FindElement(By.CssSelector("select.product_sort_container")).Click();
            
// Label: Select A-Z

SelectElement(driver.FindElement(By.CssSelector("select.product_sort_container"))).SelectByText("Name (A to Z)");
                        driver.FindElement(By.CssSelector("select.product_sort_container")).Click();
// Label: Select Z-A
            
SelectElement(driver.FindElement(By.CssSelector("select.product_sort_container"))).SelectByText("Name (Z to A)");
            driver.FindElement(By.CssSelector("select.product_sort_container")).Click();
                        
// Label: Select Low to High

SelectElement(driver.FindElement(By.CssSelector("select.product_sort_container"))).SelectByText("Price (low to high)");

            driver.FindElement(By.CssSelector("select.product_sort_container")).Click();

// Label: Select High to Low
            
SelectElement(driver.FindElement(By.CssSelector("select.product_sort_container"))).SelectByText("Price (high to low)");

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

