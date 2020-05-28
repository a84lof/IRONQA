namespace IRONQA.SEARCH.PAGES
{
    using IRONQA.FSBO.PAGES.FORSALEBYOWNER;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class Landing
    {
        private IWebDriver driver;
        public Landing(IWebDriver _driver) => driver = _driver;
        private IWebElement KeywordSearch => driver.FindElement(By.Name("keyword"));
        private IWebElement AdvancedSearch => driver.FindElement(By.Id("funnel-btn-advanced-search"));
        private IWebElement AppraiseEquipment => driver.FindElement(By.Id("funnel-btn-appraise-equipment"));
        private IWebElement CreateListing => driver.FindElement(By.Id("funnel-btn-create-listing"));
        private IWebElement CategoryLinks => driver.FindElement(By.CssSelector("#siteContainer > main > div > div > section.small-12.large-4.cell.left-section > div > div"));
        private IWebElement ManufacturerLinks => driver.FindElement(By.CssSelector("#siteContainer > main > div > div > section.small-12.large-4.cell.center-section > div"));

        public void ConfirmOnSearchPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL(TestDetails.SearchURL);
            Thread.Sleep(2000);
            Util.Log("Search Page Loaded.");
        }

        public Results EnterKeywordSearch(string keyword)
        {
            KeywordSearch.SendKeys(keyword);
            KeywordSearch.Submit();
            Util.Log("Search Submitted.");
            return new Results(driver);
        }

        public AdvancedSearch ClickAdvancedSearch()
        {
            AdvancedSearch.Click();
            Util.Log("Clicked Start Search Button.");
            return new AdvancedSearch(driver);
        }

        public Dashboard ClickCreateListing()
        {
            CreateListing.Click();
            Util.Log("Clicked Create Listing Button.");
            return new Dashboard(driver);
        }

        public Results ClickEquipmentCategory(string category)
        {// Use simple strings.. will not handle multiple words or strings with symbols like -
            string cat = category.ToString().ToLower();
            IWebElement element = driver.FindElement(By.XPath("//*[contains(@href,\""+ cat +"\")]"));
            element.Click();
            Util.Log("Clicked on Category: "+category+".");
            return new Results(driver);
        }

        public Results ClickManufacturer(string manufacturer)
        {
            string make = manufacturer.ToString().ToLower();
            IWebElement element = driver.FindElement(By.XPath("//*[contains(@*,\""+ make +"\")]"));
            element.Click();
            Util.Log("Clicked on Manufacturer: "+manufacturer+".");
            return new Results(driver);
        }

        public Results ClickEquipmentType(string equipType)
        {
            string type = equipType.ToString().ToLower();
            IWebElement element = driver.FindElement(By.XPath("//*[contains(@href,\"" + type + "\")]"));
            element.Click();
            Util.Log("Clicked on Type: "+equipType+".");
            return new Results(driver);
        }
    }
}
