namespace IRONQA.SEARCH.PAGES
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;

    public class Compare
    {
        private IWebDriver driver;
        public Compare(IWebDriver _driver) => driver = _driver;
        private IWebElement ListingsBreadcrumb => driver.FindElement(By.CssSelector("#bread-crumb > li:nth-child(3) > a"));
        private IWebElement AdvSearchBreadcrumb => driver.FindElement(By.CssSelector("#bread-crumb > li:nth-child(2) > a"));
        private IWebElement FirstViewListing => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(1) > div:nth-child(2) > a"));
        private IWebElement SecondViewListing => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(1) > div:nth-child(3) > a"));
        private IWebElement ThirdViewListing => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(1) > div:nth-child(4) > a"));
        private IWebElement FourthViewListing => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(1) > div:nth-child(5) > a"));
        private IWebElement FirstRemoveListing => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(2) > div:nth-child(2) > button > i"));
        private IWebElement SecondRemoveListing => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(2) > div:nth-child(3) > button > i"));
        private IWebElement ThirdRemoveListing => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(2) > div:nth-child(4) > button > i"));
        private IWebElement FourthRemoveListing => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(2) > div:nth-child(5) > button > i"));
        private IWebElement FirstPhoto => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(3) > div:nth-child(2) > img"));
        private IWebElement SecondPhoto => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(3) > div:nth-child(3) > img"));
        private IWebElement ThirdPhoto => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(3) > div:nth-child(4) > img"));
        private IWebElement FourthPhoto => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(3) > div:nth-child(5) > img"));
        private IWebElement FirstMake => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div.flex-row.make > div:nth-child(2)"));
        private IWebElement SecondMake => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div.flex-row.make > div:nth-child(3)"));
        private IWebElement ThirdMake => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div.flex-row.make > div:nth-child(4)"));
        private IWebElement FourthMake => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div.flex-row.make > div:nth-child(5)"));
        private IWebElement FirstType => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(5) > div:nth-child(2)"));
        private IWebElement SecondType => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(5) > div:nth-child(3)"));
        private IWebElement ThirdType => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(5) > div:nth-child(4)"));
        private IWebElement FourthType => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(5) > div:nth-child(5)"));
        private IWebElement FirstModel => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(6) > div:nth-child(2)"));
        private IWebElement SecondModel => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(6) > div:nth-child(3)"));
        private IWebElement ThirdModel => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(6) > div:nth-child(4)"));
        private IWebElement FourthModel => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(6) > div:nth-child(5)"));
        private IWebElement FirstYear => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(7) > div:nth-child(2)"));
        private IWebElement SecondYear => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(7) > div:nth-child(3)"));
        private IWebElement ThirdYear => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(7) > div:nth-child(4)"));
        private IWebElement FourthYear => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(7) > div:nth-child(5)"));
        private IWebElement FirstSerialNumber => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(8) > div:nth-child(2)"));
        private IWebElement SecondSerialNumber => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(8) > div:nth-child(3)"));
        private IWebElement ThirdSerialNumber => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(8) > div:nth-child(4)"));
        private IWebElement FourthSerialNumber => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(8) > div:nth-child(5)"));
        private IWebElement FirstLocation => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(9) > div:nth-child(2)"));
        private IWebElement SecondLocation => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(9) > div:nth-child(3)"));
        private IWebElement ThirdLocation => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(9) > div:nth-child(4)"));
        private IWebElement FourthLocation => driver.FindElement(By.CssSelector("#compare-equipment-react-root > main > div > div > div > div > div:nth-child(9) > div:nth-child(5)"));
        private IWebElement FirstPrice => driver.FindElement(By.XPath("//*[contains(@id,'-accordion')]/div/div[1]/div[2]"));
        private IWebElement SecondPrice => driver.FindElement(By.XPath("//*[contains(@id,'-accordion')]/div/div[1]/div[3]"));
        private IWebElement ThirdPrice => driver.FindElement(By.XPath("//*[contains(@id,'-accordion')]/div/div[1]/div[4]"));
        private IWebElement FourthPrice => driver.FindElement(By.XPath("//*[contains(@id,'-accordion')]/div/div[1]/div[5]"));
        private IWebElement FirstCondition => driver.FindElement(By.XPath("//*[contains(@id,'-accordion')]/div/div[2]/div[2]"));
        private IWebElement SecondCondition => driver.FindElement(By.XPath("//*[contains(@id,'-accordion')]/div/div[2]/div[3]"));
        private IWebElement ThirdCondition => driver.FindElement(By.XPath("//*[contains(@id,'-accordion')]/div/div[2]/div[4]"));
        private IWebElement FourthCondition => driver.FindElement(By.XPath("//*[contains(@id,'-accordion')]/div/div[2]/div[5]"));
        private IWebElement FirstUsage => driver.FindElement(By.XPath("//*[contains(@id,'-accordion')]/div/div[3]/div[2]"));
        private IWebElement SecondUsage => driver.FindElement(By.XPath("//*[contains(@id,'-accordion')]/div/div[3]/div[3]"));
        private IWebElement ThirdUsage => driver.FindElement(By.XPath("//*[contains(@id,'-accordion')]/div/div[3]/div[4]"));
        private IWebElement FourthUsage => driver.FindElement(By.XPath("//*[contains(@id,'-accordion')]/div/div[3]/div[5]"));
        private IWebElement PriceAndUsage => driver.FindElement(By.Id("fh3nn9-accordion-label"));
        private IWebElement SpecsAndOptions => driver.FindElement(By.Id("6gab2b-accordion-label"));
        private IWebElement FirstDetailsOptions => driver.FindElement(By.CssSelector("#\\36 gab2b-accordion > div > div:nth-child(2) > div:nth-child(2)"));
        private IWebElement SecondDetailsOptions => driver.FindElement(By.CssSelector("#\\36 gab2b-accordion > div > div:nth-child(2) > div:nth-child(3)"));
        private IWebElement ThirdDetailsOptions => driver.FindElement(By.CssSelector("#\\36 gab2b-accordion > div > div:nth-child(2) > div:nth-child(4)"));
        private IWebElement FourthDetailsOptions => driver.FindElement(By.CssSelector("#\\36 gab2b-accordion > div > div:nth-child(2) > div:nth-child(5)"));

        public void ConfirmOnComparePage()
        {
            Util util = new Util(driver);
            util.SwitchToNewTab();
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/listings/compare");
            Util.Log("On FSBO Landing Page.");
        }
    }
}
