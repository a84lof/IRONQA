namespace IRONQA.FSBO.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using System;
    using OpenQA.Selenium;

    public class PurchaseAppraisals
    {
        private IWebDriver driver;
        public PurchaseAppraisals(IWebDriver _driver) => driver = _driver;
        private IWebElement ConfirmHeading => driver.FindElement(By.ClassName("heading"));

        public void ConfirmOnPurchaseAppraisalsPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForElement("Name","heading");
            Util.Log("On Appraisal Page.");
        }
    }
}
