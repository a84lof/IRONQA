namespace IRONQA.GUIDES.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    
    public class InspectionWorksheet
    {
        private IWebDriver driver;
        public InspectionWorksheet(IWebDriver _driver) => driver = _driver;
        private IWebElement ContinueAppraisal => driver.FindElement(By.CssSelector("#back--button > div > span"));
        private IWebElement UploadInspection => driver.FindElement(By.CssSelector("#upload--wrapper > div > span"));
        private IWebElement TractorWorksheet => driver.FindElement(By.CssSelector("#root > div > div.off-canvas-wrapper > div > div.off-canvas-content > main > div.main-inner-wrap > section:nth-child(3) > section:nth-child(2) > aside.download-inspection-worksheet > div > a.button.secondary.tractor-download"));
        private IWebElement CombineWorksheet => driver.FindElement(By.CssSelector("#root > div > div.off-canvas-wrapper > div > div.off-canvas-content > main > div.main-inner-wrap > section:nth-child(3) > section:nth-child(2) > aside.download-inspection-worksheet > div > a.button.secondary.combine-download"));

        public void ConfirmOnInspectionWorksheetPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("inspection");
            Util.Log("On Inspection Worksheet Page");
        }

        public Step2 ClickContinueAppraisal()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#back--button > div > span");
            ContinueAppraisal.Click();
            Util.Log("Clicked Continue Appraisal");
            return new Step2(driver);
        }

        public void ClickUploadInspection()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#upload--wrapper > div > span");
            UploadInspection.Click();
            Util.Log("Clicked Upload Inspection.");
        }

        public void ConfirmBlankInspectionWorksheets()
        {
            TractorWorksheet.Click();
            Util util = new Util(driver);
            util.CloseNewTab();
            CombineWorksheet.Click();
            util.CloseNewTab();
            Util.Log("Confirmed Blank Inspection Worksheets.");
        }
    }
}
