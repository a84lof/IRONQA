namespace IRONQA.FSBO.PAGES.FORSALEBYOWNER
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;
    
    public class Step7
    {
        private IWebDriver driver;
        public Step7(IWebDriver _driver) => driver = _driver;
        private IWebElement ActivateLater => driver.FindElement(By.CssSelector("#Content_Content_activateLater"));

        public void ConfirmOnStep7()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("publish");
            Util.Log("On Step 7.");
        }

        public ManageListings ClickActivateLater()
        {
            ActivateLater.Click();
            Util.Log("Clicked Next.");
            return new ManageListings(driver);
        }
    }
}