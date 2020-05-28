namespace IRONQA.GUIDES.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class Step4
    {
        private IWebDriver driver;
        public Step4(IWebDriver _driver) => driver = _driver;
        private IWebElement Specifications => driver.FindElement(By.CssSelector("#panel1d-label > h2 > i"));
        private IWebElement FloorPlanTable => driver.FindElement(By.CssSelector("#root > div > div.off-canvas-wrapper > div > div.off-canvas-content > main > div.main-inner-wrap > section.floor-plan"));
        private IWebElement AddProspects => driver.FindElement(By.Id("link--add-prospects"));
        private IWebElement SaveDownload => driver.FindElement(By.Id("link--save-and-download-appraisal"));
        private IWebElement StartNewAppraisal => driver.FindElement(By.Id("link--start-new"));

        public void ConfirmOnStep4()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/step4");
            Util.Log("On Step 4");
        }

        public void ClickSaveDownload()
        {
            SaveDownload.Click();
            Util.Log("Clicked Save/Download Appraisal Button.");
        }

        public Step5 ClickAddProspects()
        {
            Thread.Sleep(3000);
            Util util  = new Util(driver);
            util.ScrollTo(AddProspects);
            AddProspects.Click();
            Util.Log("Clicked Next Steps Prospects");
            return new Step5(driver);
        }
    }
}
