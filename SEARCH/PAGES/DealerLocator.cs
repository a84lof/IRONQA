namespace IRONQA.SEARCH.PAGES
{
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;
    
    public class DealerLocator
    {
        private IWebDriver driver;
        public DealerLocator(IWebDriver _driver) => driver = _driver;
        private IWebElement LocationSearch => driver.FindElement(By.CssSelector("#react-select-3--value > div.Select-placeholder"));
        private IWebElement LocationInput => driver.FindElement(By.CssSelector("#react-select-3--value > div.Select-input > input"));
        private IWebElement Zip => driver.FindElement(By.Id("react-select-2--value-item"));
        private IWebElement Update => driver.FindElement(By.CssSelector("#dealer-listings-react-root > main > div > div > aside.right-side > div > div > div > input"));
        private IWebElement Radius => driver.FindElement(By.Id("SearchRadius"));
        private IWebElement Listings => driver.FindElement(By.CssSelector("#dealer-listings-react-root > main > div > div > aside.right-side > ul > li:nth-child(1)"));
        private IWebElement Distance => driver.FindElement(By.CssSelector("#dealer-listings-react-root > main > div > div > aside.right-side > ul > li:nth-child(1) > p.distance"));
        private IWebElement Address => driver.FindElement(By.CssSelector("#dealer-listings-react-root > main > div > div > aside.right-side > ul > li:nth-child(1) > p.address"));
        private IWebElement Directions => driver.FindElement(By.CssSelector("#dealer-listings-react-root > main > div > div > aside.right-side > ul > li:nth-child(1) > a.directions"));
        private IWebElement Phone => driver.FindElement(By.CssSelector("#dealer-listings-react-root > main > div > div > aside.right-side > ul > li:nth-child(1) > a.phone-number"));
        private IWebElement Email => driver.FindElement(By.CssSelector("#dealer-listings-react-root > main > div > div > aside.right-side > ul > li:nth-child(1) > a.email"));
        private IWebElement Website => driver.FindElement(By.CssSelector("#dealer-listings-react-root > main > div > div > aside.right-side > ul > li:nth-child(1) > a.website"));
        private IWebElement ViewAllLocations => driver.FindElement(By.CssSelector("#dealer-listings-react-root > main > div > div > aside.right-side > ul > li:nth-child(1) > a:nth-child(8)"));
        private IWebElement ViewIronSearchListings => driver.FindElement(By.CssSelector("#dealer-listings-react-root > main > div > div > aside.right-side > ul > li:nth-child(1) > a:nth-child(9)"));

        public void ConfirmOnDealerLocatorPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("dealership/locate");
            Util.Log("On Dealer Locator Page.");
        }

        public void VerifyInitialObjectsDisplayed()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            ConfirmLocationSearch();
        }

        public void ConfirmLocationSearch()
        {
            try
            {
                Assert.IsTrue(LocationInput.Displayed);
                Util.Log(TestDetails.Pass + " Location Search Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void VerifyRemainingObjectsDisplayed()
        {// Confirm Remaining Objects
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            ConfirmListings();
            ConfirmDistance();
            ConfirmAddress();
            ConfirmDirections();
            ConfirmPhone();
            ConfirmEmail();
            ConfirmWebsite();
            ConfirmViewAllLocations();
            ConfirmViewIronSearchListings();
            Util.Log("Remaining Objects Confirmed");
        }

        public void ConfirmListings()
        {
            try
            {
                Assert.IsTrue(Listings.Displayed);
                Util.Log(TestDetails.Pass + " Listings Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmDistance()
        {
            try
            {
                Assert.IsTrue(Distance.Displayed);
                Util.Log(TestDetails.Pass + " Distance Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmAddress()
        {
            try
            {
                Assert.IsTrue(Address.Displayed);
                Util.Log(TestDetails.Pass + " Address Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmDirections()
        {
            try
            {
                Assert.IsTrue(Directions.Displayed);
                Util.Log(TestDetails.Pass + " Directions Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmPhone()
        {
            try
            {
                Assert.IsTrue(Phone.Displayed);
                Util.Log(TestDetails.Pass + " Phone Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmEmail()
        {
            try
            {
                Assert.IsTrue(Email.Displayed);
                Util.Log(TestDetails.Pass + " Email Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmWebsite()
        {
            try
            {
                Assert.IsTrue(Website.Displayed);
                Util.Log(TestDetails.Pass + " Website Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmViewAllLocations()
        {
            try
            {
                Assert.IsTrue(ViewAllLocations.Displayed);
                Util.Log(TestDetails.Pass + " View All Locations Button Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmViewIronSearchListings()
        {
            try
            {
                Assert.IsTrue(ViewIronSearchListings.Displayed);
                Util.Log(TestDetails.Pass + " View Iron Search Listings Button Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void EnterInitialLocation(string location)
        {// Enter Initial Location
            Thread.Sleep(2000);
            LocationInput.SendKeys(location);
            Thread.Sleep(1000);
            LocationInput.SendKeys(Keys.Enter);
            Util.Log("Entered Location");
        }
    }
}
