namespace IRONQA.FSBO.PAGES.FORSALEBYOWNER
{
    using IRONQA.FSBO.PAGES.APPRAISAL;
    using IRONQA.SSO.PAGES;
    using IRONQA.STORE.PAGES.MYACCOUNT;
    using IRONQA.STORE.PAGES.SHARED;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    public class FSBONav
    {
        private IWebDriver driver;
        public FSBONav(IWebDriver _driver) => driver = _driver;
        private IWebElement FSBODashboard => driver.FindElement(By.CssSelector("#main > div.search-tabs > ul > li:nth-child(1) > a"));
        private IWebElement AddNewListing => driver.FindElement(By.CssSelector("#main > div.search-tabs > ul > li:nth-child(2) > a"));
        private IWebElement ManageListings => driver.FindElement(By.CssSelector("#main > div.search-tabs > ul > li:nth-child(3) > a"));
        private IWebElement BuyListings => driver.FindElement(By.CssSelector("#main > div.search-tabs > ul > li:nth-child(4) > a"));
        private IWebElement ModifyAccount => driver.FindElement(By.CssSelector("#main > div.search-tabs > ul > li:nth-child(5) > a"));
        private IWebElement BuyGuides => driver.FindElement(By.CssSelector("#main > div.search-tabs > ul > li:nth-child(6) > a"));
        private IWebElement LogOut => driver.FindElement(By.Id("Content_LogoutLink"));
        private IWebElement IronAppraiser => driver.FindElement(By.Id("Content_A1"));

        public void ConfirmFSBONav()
        {
            try
            {
                Assert.IsTrue(FSBODashboard.Displayed);
                Util.Log("FSBO Dashboard Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public Dashboard ClickFSBODashboard()
        {
            FSBODashboard.Click();
            Util.Log("Clicked FSBO Dashboard Button.");
            return new Dashboard(driver);
        }

        public ManageListings ClickManageListings()
        {
            ManageListings.Click();
            Util.Log("Clicked Manage Listings Button.");
            return new ManageListings(driver);
        }

        public PurchaseListings ClickBuyListings()
        {
            BuyListings.Click();
            Util.Log("Clicked Buy Listings Button.");
            return new PurchaseListings(driver);
        }

        public Overview ClickModifyAccoint()
        {
            ModifyAccount.Click();
            Util.Log("Clicked Modify Account Button.");
            return new Overview(driver);
        }

        public AppraisalLanding ClickBuyGuides()
        {
            BuyGuides.Click();
            Util.Log("Clicked Buy Guides Button.");
            return new AppraisalLanding(driver);
        }

        public SSOLogin ClickLogOut()
        {
            LogOut.Click();
            Util.Log("Clicked Log Out Button.");
            return new SSOLogin(driver);
        }

        public AppraisalLanding ClickIronAppraiser()
        {
            IronAppraiser.Click();
            Util.Log("Clicked Iron Appraiser Button.");
            return new AppraisalLanding(driver);
        }
    }
}
