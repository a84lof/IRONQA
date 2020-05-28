namespace IRONQA.STORE.PAGES.CHECKOUT
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;
    
    public class Shipping
    {
        private IWebDriver driver;
        public Shipping(IWebDriver _driver) => driver = _driver;
        
        private IWebElement DeliveryMethod => driver.FindElement(By.Name("delivery-options"));
        private IWebElement Continue => driver.FindElement(By.CssSelector("#wizard-content > div > div.order-wizard-step-content-wrapper > div > div > button.order-wizard-step-button-continue"));
        private IWebElement ReturnToStore => driver.FindElement(By.CssSelector("#wizard-content > div > div.order-wizard-step-content-wrapper > div > div > button.order-wizard-returntostore-module-button"));
        private IWebElement SameAsBillingAddress => driver.FindElement(By.CssSelector("#wizard-step-content > article.OrderWizard\\.Module\\.Address\\.Shipping.module-rendered > div.order-wizard-address-module > div > label > input[type=checkbox]"));
        private IWebElement Edit => driver.FindElement(By.CssSelector("#wizard-step-content > article.OrderWizard\\2e Module\\2e Address\\2e Shipping.module-rendered > div.order-wizard-address-module > div > div > div > div > p > a.address-details-edit-address"));
        private IWebElement ChangeAddress => driver.FindElement(By.CssSelector("#wizard-step-content > article.OrderWizard\\2e Module\\2e Address\\2e Shipping.module-rendered > div.order-wizard-address-module > div > div > div > div > p > a.address-details-change-address"));
        private IWebElement FullName => driver.FindElement(By.Id("fullname"));
        private IWebElement Company => driver.FindElement(By.Id("company"));
        private IWebElement Address => driver.FindElement(By.Id("addr1"));
        private IWebElement Optional => driver.FindElement(By.Id("addr2"));
        private IWebElement City => driver.FindElement(By.Id("city"));
        private IWebElement Country => driver.FindElement(By.Id("country"));
        private IWebElement State => driver.FindElement(By.Id("state"));
        private IWebElement ZipCode => driver.FindElement(By.Id("zip"));
        private IWebElement PhoneNumber => driver.FindElement(By.Id("phone"));
        private IWebElement Residential => driver.FindElement(By.Id("isresidential"));

        public void ConfirmOnshippingPage()
        {
            try
            {
                Assert.IsTrue(driver.Url.Contains("address"));
                Util.Log("");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + ex); }
        }

        public void ConfirmDeliveryMethod()
        {
            try
            {
                Thread.Sleep(3000);
                Assert.IsTrue(DeliveryMethod.Displayed);
                Util.Log("Delivery Method Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + ex); }
        }

        public void ClickSameAsBilling()
        {
            SameAsBillingAddress.Click();
            Util.Log("Clicked Same As Billing Address.");
        }

        public void ClickChangeAddress()
        {
            ChangeAddress.Click();
            Util.Log("Clicked Change Address.");
        }

        public void ClickUSPS()
        {
            DeliveryMethod.Click();
            Util.Log("Clicked USPS");
        }

        public Billing ClickContinue()
        {
            Thread.Sleep(1500);
            Util util = new Util(driver);
            util.ScrollToBottom();
            Continue.Click();
            Util.Log("Clicked Continue Button.");
            return new Billing(driver);
        }
    }
}