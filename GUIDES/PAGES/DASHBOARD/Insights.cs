namespace IRONQA.GUIDES.PAGES.DASHBOARD
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    public class Insights
    {
        private IWebDriver driver;
        public Insights(IWebDriver _driver) => driver = _driver;
        private IWebElement ViewPendingInventory => driver.FindElement(By.XPath("//aside[contains(@class,'pending')]/div/a"));
        private IWebElement PendingInventoryCount => driver.FindElement(By.XPath("//aside[contains(@class,'pending')]/div/p/span"));
        private IWebElement ValuesOutOfDate => driver.FindElement(By.XPath("//aside[contains(@class,'out-of-date')]/div/a"));
        private IWebElement ViewOutOfDate => driver.FindElement(By.XPath("//aside[contains(@class,'out-of-date')]/div/a"));
        private IWebElement OutOfDateCount => driver.FindElement(By.XPath("//aside[contains(@class,'out-of-date')]/div/p/span"));
        private IWebElement ViewOldInventory => driver.FindElement(By.XPath("//aside[contains(@class,'old-inventory')]/div/a"));
        private IWebElement OldInventoryCount => driver.FindElement(By.XPath("//aside[contains(@class,'old-inventory')]/div/p/span"));
        private IWebElement ViewAgingInventory => driver.FindElement(By.XPath("//aside[contains(@class,'old-inventory')]/div/a"));
        private IWebElement AgingInventoryCount2_3 => driver.FindElement(By.XPath("//aside[contains(@class,'old-inventory')]/div/p[2]/span"));
        private IWebElement AgingInventoryCount3_6 => driver.FindElement(By.XPath("//aside[contains(@class,'old-inventory')]/div/p[1]/span"));
        private IWebElement ViewAllInsights => driver.FindElement(By.CssSelector("a.hollow:nth-child(1)"));

        public void ConfirmInsightsDisplayed()
        {
            Util util = new Util(driver);
            util.WaitForElement("CssSelector","a.hollow:nth-child(1)");
            Util.Log("Insights Tab Displayed.");
        }
    }
}