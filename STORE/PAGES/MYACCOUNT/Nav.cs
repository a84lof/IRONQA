namespace IRONQA.STORE.PAGES.MYACCOUNT
{
    using IRONQA.STORE.PAGES.CHECKOUT;
    using IRONQA.STORE.PAGES.MYACCOUNT.PURCHASEHISTORY;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    
    class MyAccountNav
    {
        private IWebDriver driver;
        public MyAccountNav(IWebDriver _driver) => driver = _driver;
        private IWebElement Overview => driver.FindElement(By.CssSelector("#side-nav > div > div:nth-child(1)"));
        private IWebElement Purchases => driver.FindElement(By.CssSelector("#side-nav > div > div:nth-child(2)"));
        private IWebElement Billing => driver.FindElement(By.CssSelector("#side-nav > div > div:nth-child(3)"));
        private IWebElement Settings => driver.FindElement(By.CssSelector("#side-nav > div > div:nth-child(4)"));
        private IWebElement Cases => driver.FindElement(By.CssSelector("#side-nav > div > div:nth-child(5)"));

        public void ConfirmMyAccountNav()
        {
            try
            {
                Assert.IsTrue(driver.Url.Contains("my_account"));
                Util.Log("");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + ex); }
        }

        public Overview ClickOverview()
        {
            Overview.Click();
            Util.Log("Clicked Overview.");
            return new Overview(driver);
        }

        public Purchases ClickPurchases()
        {
            Purchases.Click();
            Util.Log("Clicked Purchases.");
            return new Purchases(driver);
        }

        public Billing ClickBilling()
        {
            Billing.Click();
            Util.Log("Clicked Billing.");
            return new Billing(driver);
        }

        public Settings ClickSettings()
        {
            Settings.Click();
            Util.Log("Clicked Settings.");
            return new Settings(driver);
        }

        public Cases ClickCases()
        {
            Cases.Click();
            Util.Log("Clicked Cases.");
            return new Cases(driver);
        }
    }
}
