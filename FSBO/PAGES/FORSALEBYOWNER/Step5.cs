namespace IRONQA.FSBO.PAGES.FORSALEBYOWNER
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;

    public class Step5
    {
        private IWebDriver driver;
        public Step5(IWebDriver _driver) => driver = _driver;
        private IWebElement Next => driver.FindElement(By.CssSelector("#Content_Content_btnContinue > div"));

        public void ConfirmOnStep5()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("appraisal");
            Util.Log("On Step 5.");
        }

        public Step6 ClickNext()
        {
            Next.Click();
            Util.Log("Clicked Next.");
            return new Step6(driver);
        }
    }
}