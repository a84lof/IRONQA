namespace IRONQA.STORE.PAGES.CHECKOUT
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;
    
    public class Billing
    {
        private IWebDriver driver;
        public Billing(IWebDriver _driver) => driver = _driver;
        private IWebElement CC => driver.FindElement(By.Id("ccnumber"));
        private IWebElement CardType => driver.FindElement(By.Id("paymentmethod"));
        private IWebElement ExpMonth => driver.FindElement(By.Id("expmonth"));
        private IWebElement ExpYear => driver.FindElement(By.Id("expyear"));
        private IWebElement SecurityCode => driver.FindElement(By.Id("ccsecuritycode"));
        private IWebElement NameOnCard => driver.FindElement(By.Id("ccname"));
        private IWebElement SaveCreditCard => driver.FindElement(By.Id("savecreditcard"));
        private IWebElement PurchaseOrder => driver.FindElement(By.Id("purchase-order-number"));
        private IWebElement ShippingAsBillingAddress => driver.FindElement(By.Name("same-as-address"));
        private IWebElement Continue => driver.FindElement(By.CssSelector("#wizard-content > div > div.order-wizard-step-content-wrapper > div > div > button.order-wizard-step-button-continue"));
        private IWebElement Back => driver.FindElement(By.CssSelector(".order-wizard-step-button-back"));
        private IWebElement BackToStore => driver.FindElement(By.CssSelector(".order-wizard-returntostore-module-button"));
        private IWebElement SecurityNumber => driver.FindElement(By.CssSelector("#ccsecuritycode"));
        private IWebElement PromoCode => driver.FindElement(By.XPath("//*[contains(@class,'order-wizard-promocodeform-expander-head')]/a"));
        private IWebElement PromoCodeInput => driver.FindElement(By.XPath("//*[contains(@class,'cart-promocode-form-summary-container-input')]/div/input"));
        private IWebElement Apply => driver.FindElement(By.CssSelector("#order-wizard-promocode > div > div > form > div.cart-promocode-form-summary-grid > div.cart-promocode-form-summary-promocode-container-button > button"));

        public void ConfirmBillingPage()
        {
            try
            {
                Thread.Sleep(10000); // this is silly
                Assert.IsTrue(driver.Url.Contains("#billing"));
                Util.Log("On Payment Page.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + ex); }
        }

        public void EnterPaymentInfo()
        {
            CC.SendKeys(Users.CreditCard);
            CC.SendKeys(Keys.Tab);
            Thread.Sleep(250);
            CardType.SendKeys(Users.CardType);
            SecurityCode.SendKeys(Users.SecurityCode);
            NameOnCard.SendKeys(Users.FullName);
            SaveCreditCard.Click();
            Util util = new Util(driver);
            util.ScrollToBottom();
            ShippingAsBillingAddress.Click();
            Util.Log("Payment Information Entered.");
        }

        public void EnterSecurityNumber(string number)
        {
            Thread.Sleep(500);
            SecurityNumber.SendKeys(number);
            Util.Log("Entered Security Number");
        }

        public void ClickPromoCode()
        {
            Thread.Sleep(500);
            PromoCode.Click();
            Util.Log("Clicked Promo Code.");
        }

        public void EnterPromoCode(string code)
        {
            Thread.Sleep(1500);
            PromoCodeInput.SendKeys(code);
            Util.Log("Entered Promo Code.");
        }

        public void ClickApply()
        {
            Thread.Sleep(1000);
            Apply.Click();
            Thread.Sleep(2500);
            Util.Log("Clicked Apply.");
        }

        public Review ClickContinue()
        {
            Thread.Sleep(1500);
            Util util = new Util(driver);
            util.ScrollToBottom();
            Thread.Sleep(250);
            Continue.Click();
            Util.Log("Clicked Continue Button.");
            return new Review(driver);
        }
    }
}

