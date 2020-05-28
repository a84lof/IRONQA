namespace IRONQA.GUIDES.PAGES.DASHBOARD
{
    using IRONQA.GUIDES.PAGES.SHARED;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using System.Threading;

    public class DashboardNav
    {
        private IWebDriver driver;
        public DashboardNav(IWebDriver _driver) => driver = _driver;
        //private IWebElement HelpOK => driver.FindElement(By.CssSelector("body > div.joyride-tip-guide.custom > div > a.joyride-next-tip"));
        //private IWebElement HelpClose => driver.FindElement(By.CssSelector("body > div.joyride-tip-guide.custom > div > a.joyride-close-tip"));
        //private IWebElement BodyMyIron => driver.FindElement(By.CssSelector("#content > main > div"));
        private IWebElement News => driver.FindElement(By.Id("news-label"));
        private IWebElement MySavedAppraisals => driver.FindElement(By.CssSelector("#my-saved-appraisals-label"));
        private IWebElement Resources => driver.FindElement(By.Id("forms-resources-label"));
        private IWebElement Reporting => driver.FindElement(By.Id("sales-report-label"));
        private IWebElement Insights => driver.FindElement(By.Id("insights-label"));

        // public GuidesNav DismissHelpPopup()
        // {
        //     Util util = new Util(driver);

        //     if (TestDetails.GetParent.Contains("IE")) /*|| TestDetails.GetParent.Contains("Edge"))*/
        //     {
        //         driver.Manage().Cookies.DeleteCookieNamed("HelpCenterCallout");
        //         driver.Navigate().Refresh();
        //         util.ExecuteScript(Scripts.WaitForPage);
        //     }
            
        //     util.WaitForElement("CssSelector", "body > div.joyride-tip-guide.custom > div > a.joyride-next-tip", 45);

        //     try
        //     {
        //         Actions actions = new Actions(driver);
        //         actions.MoveToElement(HelpOK);
        //         actions.Click(HelpOK);
        //         Thread.Sleep(500);
        //         actions.MoveToElement(BodyMyIron); //frame shift
        //         actions.Build().Perform();
        //         Util.Log("Help Dialogue Closed.");
        //     }
        //     catch (NoSuchElementException) { Util.Log("Help Button Not Found."); }
        //     return new GuidesNav(driver);
        // }

        public void ConfirmDashboard()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForElement("id", "newsNotificationBubbleDesktop");
            Thread.Sleep(5000);
            Util.Log("On Dashboard");
        }

        public void ClickNews()
        {
            News.Click();
            Util.Log("Clicked News Tab.");
        }

        public SavedAppraisals ClickMySavedAppraisals()
        {
            Util util = new Util(driver);
            util.WaitForElement("CssSelector","#my-saved-appraisals-label");
            MySavedAppraisals.Click();
            Util.Log("Clicked My Saved Appraisals Tab.");
            return new SavedAppraisals(driver);
        }

        public Resources ClickResources()
        {
            Resources.Click();
            Util.Log("Clicked Resources Tab.");
            return new Resources(driver);
        }

        public Reporting ClickReporting()
        {
            Reporting.Click();
            Util.Log("Clicked Reporting Tab.");
            return new Reporting(driver);
        }

        public void ClickInsights()
        {
            Insights.Click();
            Util.Log("Clicked Insights Tab.");
        }
    }
}