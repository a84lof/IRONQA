namespace IRONQA.GUIDES.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Export
    {
        private IWebDriver driver;
        public Export(IWebDriver _driver) => driver = _driver;
        private IWebElement ContinueAppraisal => driver.FindElement(By.CssSelector("#back--button > div > span"));
        private IWebElement ExportToEmail => driver.FindElement(By.CssSelector("#root > div > div.off-canvas-wrapper > div > div.off-canvas-content > main > div.main-inner-wrap > section.appraisal-export > button.button.button--export-appraisal"));
        private IWebElement DownloadPDF => driver.FindElement(By.CssSelector("#root > div > div.off-canvas-wrapper > div > div.off-canvas-content > main > div.main-inner-wrap > section.appraisal-export > a"));

        public void ConfirmOnExportPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("export");
            Util.Log("On Export Page");
        }

        public Step2 ClickContinueAppraisal()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#back--button > div > span");
            ContinueAppraisal.Click();
            Util.Log("Clicked Continue Appraisal");
            return new Step2(driver);
        }

        public void ClickExportToEmail()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#root > div > div.off-canvas-wrapper > div > div.off-canvas-content > main > div.main-inner-wrap > section.appraisal-export > button.button.button--export-appraisal");
            ExportToEmail.Click();
            Util.Log("Clicked Export To Email.");
        }

        public void ClickDownloadPDF()
        {
            DownloadPDF.Click();
            Util util = new Util(driver);
            util.CloseNewTab();
            Util.Log("Clicked Download PDF.");
        }
    }
}
