namespace IRONQA.GDM.PAGES.REPORTMGR
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    
    public class ResolveDuplicates
    {
        private IWebDriver driver;
        public ResolveDuplicates(IWebDriver _driver) => driver = _driver;
        private IWebElement NumberOfDuplicates => driver.FindElement(By.ClassName("possible-duplicates-count"));
        private IWebElement Skip => driver.FindElement(By.CssSelector("#duplicate-reports-manager-application > div > div.nav-bar > button > span"));
        private IWebElement LeftKeep => driver.FindElement(By.CssSelector("#duplicate-reports-manager-application > div > div.reports-container > div:nth-child(1) > div.resolution-btn-grp > button.button.toggle.small.keep"));
        private IWebElement LeftDiscard => driver.FindElement(By.CssSelector("#duplicate-reports-manager-application > div > div.reports-container > div:nth-child(1) > div.resolution-btn-grp > button.button.toggle.small.discard"));
        private IWebElement RightKeep => driver.FindElement(By.CssSelector("#duplicate-reports-manager-application > div > div.reports-container > div:nth-child(2) > div.resolution-btn-grp > button.button.toggle.small.keep"));
        private IWebElement RightDiscard => driver.FindElement(By.CssSelector("#duplicate-reports-manager-application > div > div.reports-container > div:nth-child(2) > div.resolution-btn-grp > button.button.toggle.small.discard"));

        public void ConfirmOnResolveDuplicatesPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/DuplicateReportsManager");
            Util.Log("On Resolve Duplicates Page.");
        }
    }
}