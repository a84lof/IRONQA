namespace IRONQA.FSBO.PAGES.FORSALEBYOWNER
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;

    public class Step2
    {
        private IWebDriver driver;
        public Step2(IWebDriver _driver) => driver = _driver;
        private IWebElement Next => driver.FindElement(By.CssSelector("#Content_Content_btnContinue > div"));

        public void ConfirmOnStep2()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("IW_NO=");
            Util.Log("On Step 2.");
        }

        public Step3 ClickNext()
        {
            Next.Click();
            Util.Log("Clicked Next.");
            return new Step3(driver);
        }
    }
}