namespace IRONQA.GUIDES.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Photos
    {
        private IWebDriver driver;
        public Photos(IWebDriver _driver) => driver = _driver;
        private IWebElement ContinueAppraisal => driver.FindElement(By.CssSelector("#back--button > div > span"));
        private IWebElement UploadPhotos => driver.FindElement(By.CssSelector("#upload--wrapper > div > span"));

        public void ConfirmOnPhotosPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("photos");
            Util.Log("On Photos Page");
        }

        public Step2 ClickContinueAppraisal()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector", "#back--button > div > span");
            ContinueAppraisal.Click();
            Util.Log("Clicked Continue Appraisal");
            return new Step2(driver);
        }

        public void ClickUploadPhotos()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector", "#upload--wrapper > div > span");
            UploadPhotos.Click();
            Util.Log("Clicked Upload Photos.");
        }
    }
}
