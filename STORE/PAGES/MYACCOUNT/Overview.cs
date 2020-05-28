namespace IRONQA.STORE.PAGES.MYACCOUNT
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    
    public class Overview
    {
        private IWebDriver driver;
        public Overview(IWebDriver _driver) => driver = _driver;
        private IWebElement OverviewButton => driver.FindElement(By.CssSelector("#side-nav > div > div:nth-child(1) > a"));

        public void ConfirmOnOverviewPage()
        {
            Util util = new Util(driver);
            util.SwitchToNewTab();
            util.WaitForElement("Id","side-nav");
            Assert.IsTrue(driver.Url.Contains("/my_account"));
            Util.Log("On Overview Page.");
        }
    }
}
