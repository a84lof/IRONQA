namespace IRONQA.STORE.PAGES.CHECKOUT
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;
    
    public class Review
    {
        private IWebDriver driver;
        public Review(IWebDriver _driver) => driver = _driver;
        private IWebElement PlaceOrder => driver.FindElement(By.CssSelector("button.order-wizard-submitbutton-module-button:nth-child(1)"));

        // Confirm Review Page
        public void ConfirmReviewPage()
        {
            try
            {
                Thread.Sleep(7000);
                Assert.IsTrue(driver.Url.Contains("#review"));
                Util.Log("On Review Page.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + ex); }
        }

        public Confirmation ClickPlaceOrder()
        {
            PlaceOrder.Click();
            Util.Log("Clicked Place Order Button.");

            Util util = new Util(driver);
            util.WaitForElementNotDisplayed("XPath", "//*[contains(@class, 'order-wizard-submitbutton-container')]"); //was a 2min wait
            return new Confirmation(driver);
        }
    }
}
