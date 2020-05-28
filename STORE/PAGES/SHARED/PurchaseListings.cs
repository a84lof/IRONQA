namespace IRONQA.STORE.PAGES.SHARED
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    public class PurchaseListings
    {
        private IWebDriver driver;
        public PurchaseListings(IWebDriver _driver) => driver = _driver;

        public void ConfirmPurchaseListingsPage()
        {
            try
            {
                Assert.IsTrue(driver.Url.Contains("FSBO"));
                Util.Log("On Purchase Listings Page");
            }
            catch (Exception ex) { Util.Log("\n" + ex + "\n"); };
        }
    }
}
