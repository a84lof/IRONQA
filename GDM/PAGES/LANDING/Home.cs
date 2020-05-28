namespace IRONQA.GDM.PAGES.LANDING
{
    using IRONQA.GDM.PAGES.VALUESMGR;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Home
    {
        private IWebDriver driver;
        public Home(IWebDriver _driver) => driver = _driver;
        private IWebElement WelcomeHome => driver.FindElement(By.CssSelector("#welcome-page > h2"));
        private IWebElement ManagePublishProgress => driver.FindElement(By.CssSelector("#welcome-page > a"));

        public void ConfirmOnHomePage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForElement("Id","welcome-page");
            Util.Log("On GDM Home Page");
        }

        public PublishStatus ClickManagePublishProgress()
        {
            ManagePublishProgress.Click();
            Util.Log("Clicked Manage Guide Publishing Progress");
            return new PublishStatus(driver);
        }
    }
}