namespace IRONQA.GUIDES.PAGES.HELPCENTER
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class About
    {
        private IWebDriver driver;
        public About(IWebDriver _driver) => driver = _driver;
        private IWebElement IronGuides => driver.FindElement(By.CssSelector("#home-products > div > div:nth-child(2) > div > div:nth-child(1) > div:nth-child(1) > div > div > a.box-link"));

        public void ConfirmOnAboutIronSolutionsPage()
        {// Confirm On About Iron Solutions Page
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("ironsolutions.com");
            Util.Log("On About Page");
        }
    }
}
