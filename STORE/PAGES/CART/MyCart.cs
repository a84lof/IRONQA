namespace IRONQA.STORE.PAGES.CART
{
    using IRONQA.STORE.PAGES.CHECKOUT;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class MyCart
    {
        private IWebDriver driver;
        public MyCart(IWebDriver _driver) => driver = _driver;
        private IWebElement ProceedToCheckout => driver.FindElement(By.Id("btn-proceed-checkout"));
        private IWebElement CartTotal => driver.FindElement(By.CssSelector("#Cart\\2e Detailed\\2e View > div > div.cart-detailed-body > section.cart-detailed-right > div > div > div.cart-summary-container > div.cart-summary-subtotal > p > span.cart-summary-amount-subtotal"));
        private IWebElement Quantity => driver.FindElement(By.XPath("//*[contains(@class,'cart-item-summary-quantity-value')]"));

        public void ConfirmOnCartPage()
        {
            try
            {
                Thread.Sleep(3000);
                Assert.IsTrue(driver.Url.Contains("/cart"));
                Util.Log("On Cart Page.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + ex); }
        }

        public Shipping ClickProceedToCheckout()
        {
            ProceedToCheckout.Click();
            Util.Log("Clicked Proceed to Checkout Button.");
            return new Shipping(driver);
        }

        public void CheckCartTotal()
        {
            float price;
            string total = CartTotal.Text.Replace("$", string.Empty);
            float.TryParse(total, out price);
            Util.Log("Cart Balance: $" + price);
        }

        public void AdjustQuantity(string quantity)
        {// eStore Quantity is cumulative, need to adjust every time.
            Thread.Sleep(1000);
            Quantity.Click();
            Quantity.Click();
            Quantity.SendKeys(Keys.Delete);
            Quantity.SendKeys(Keys.Delete);
            Quantity.SendKeys(quantity);
        }
    }
}
