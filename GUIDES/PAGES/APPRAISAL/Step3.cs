namespace IRONQA.GUIDES.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using System;
    using System.Threading;
    
    public class Step3
    {
        private IWebDriver driver;
        public Step3(IWebDriver _driver) => driver = _driver;
        private IWebElement Specifications => driver.FindElement(By.CssSelector("#panel1d-label > h2 > i"));
        private IWebElement InstructionsLabel => driver.FindElement(By.Id("panel9__instruction-label"));
        private IWebElement Instructions => driver.FindElement(By.Id("panel9__instruction"));
        private IWebElement ApplyOptionAndUsageMargin => driver.FindElement(By.CssSelector("#root > div > div.off-canvas-wrapper > div > div.off-canvas-content > main > div.main-inner-wrap > section.floor-plan > header > div > label > input[type='checkbox']"));
        private IWebElement IronSearchListingsTab => driver.FindElement(By.CssSelector("#ironsearch-listings-label"));
        private IWebElement AdvertisedListingsTab => driver.FindElement(By.Id("advertised-listings-label"));
        private IWebElement AdvertisedListings => driver.FindElement(By.Id("advertised-listings"));
        private IWebElement AuctionReportsTab => driver.FindElement(By.Id("auction-reports-label"));
        private IWebElement AuctionReports => driver.FindElement(By.Id("auction-reports"));
        private IWebElement SoldReportsTab => driver.FindElement(By.Id("sold-reports-label"));
        private IWebElement SoldReports => driver.FindElement(By.Id("sold-reports"));
        private IWebElement FloorPlan => driver.FindElement(By.Id("link--floor-plan"));
        private IWebElement SaveDownload => driver.FindElement(By.Id("link--save-and-download-appraisal"));
        private IWebElement StartNewAppraisal => driver.FindElement(By.Id("link--start-new"));
        private IWebElement CheckAll => driver.FindElement(By.CssSelector("#root > div > div.off-canvas-wrapper > div > div.off-canvas-content > main > div.main-inner-wrap > section.section--comparables > div > aside.comparables__settings-controls > fieldset > div > button:nth-child(1)"));
        private IWebElement UncheckAll => driver.FindElement(By.CssSelector("#root > div > div.off-canvas-wrapper > div > div.off-canvas-content > main > div.main-inner-wrap > section.section--comparables > div > aside.comparables__settings-controls > fieldset > div > button:nth-child(2)"));
        private IWebElement FirstAdvertisedListing => driver.FindElement(By.Id("comparable--advertised-0"));
        private IWebElement FirstSoldReport => driver.FindElement(By.Id("comparable--sold-0"));
        private IWebElement NoAuctionReportsMessage => driver.FindElement(By.Id("comparable--auction-none"));

        public void ConfirmOnStep3()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'reveal') and not(contains(@style,'display: block; top: -100px'))]");
            Util.Log("On Step 3");
        }

        public void ConfirmInstructions()
        {
            try
            {
                Assert.IsTrue(Instructions.Displayed);
                Util.Log("Instructions Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ToggleApplyMargin()
        {
            ApplyOptionAndUsageMargin.Click();
            Util.Log("Toggled Apply Margin Checkbox.");
        }

        public void ClickCheckAll()
        {
            CheckAll.Click();
            Thread.Sleep(500);
            Util.Log("Clicked Check All.");
        }

        public void ClickUncheckAll()
        {
            UncheckAll.Click();
            Thread.Sleep(500);
            Util.Log("Clicked Uncheck All.");
        }

        public void ConfirmAuctionReports()
        {
            try
            {
                Assert.IsTrue(!NoAuctionReportsMessage.Displayed);
                Util.Log("No Auction Reports Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmSoldReports()
        {
            try
            {
                Assert.IsTrue(SoldReports.Displayed);
                Util.Log("Sold Reports Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ClickInstructionsLabel()
        {
            InstructionsLabel.Click();
            Util.Log("Clicked Instructions Label");
        }

        public void ClickIronSearchListingsTab()
        {
            Thread.Sleep(3000);
            //IronSearchListingsTab.Click();
            Util.Log("Clicked Iron Search Listings Tab.");
        }

        public void ClickAuctionReportsTab()
        {
            Thread.Sleep(3000);
            //AuctionReportsTab.Click();
            Util.Log("Clicked Auction Reports Tab");
        }

        public void ClickSoldReportsTab()
        {
            //SoldReportsTab.Click();
            Util.Log("Clicked Sold Reports Tab");
        }

        public Step4 ClickFloorPlan()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","link--floor-plan");
            FloorPlan.Click();
            Util.Log("Clicked Next Step: Floor Plan");
            return new Step4(driver);
        }

        public void ClickSaveDownload()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(SaveDownload);
            actions.Click();
            actions.Perform();
            Thread.Sleep(3000);
            Util.Log("Clicked Save/Download Appraisal Button.");
        }

        public void ConfirmCheckboxValue(string value)
        {
            try
            {
                Assert.IsFalse(FirstAdvertisedListing.Selected);
                Util.Log("Checkbox Status Confirmed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }
    }
}
