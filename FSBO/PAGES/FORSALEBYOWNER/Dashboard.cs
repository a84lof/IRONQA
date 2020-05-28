namespace IRONQA.FSBO.PAGES.FORSALEBYOWNER
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;

    public class Dashboard
    {
        private IWebDriver driver;
        public Dashboard(IWebDriver _driver) => driver = _driver;
        private IWebElement AddAListing => driver.FindElement(By.CssSelector("#main > div.content > div.package > table > tbody > tr:nth-child(1) > td:nth-child(1) > a > img"));

        public void ConfirmOnFSBODashboard()
        {
            Util util = new Util(driver);
            util.SwitchToNewTab();
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("fsbo/Classifieds");
            Util.Log("On FSBO Landing Page.");
        }

        public Step1 ClickAddAListing()
        {
            AddAListing.Click();
            Util.Log("Clicked Add A Listing.");
            return new Step1(driver);
        }
    }
}