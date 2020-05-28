namespace IRONQA.FSBO.PAGES.FORSALEBYOWNER
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;
    
    public class Step6
    {
        private IWebDriver driver;
        public Step6(IWebDriver _driver) => driver = _driver;
        private IWebElement Next => driver.FindElement(By.CssSelector("#Content_Content_btnContinue > div"));

        public void ConfirmOnStep6()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("confirm");
            Util.Log("On Step 6.");
        }

        public Step7 ClickNext()
        {
            Next.Click();
            Util.Log("Clicked Next.");
            return new Step7(driver);
        }
    }
}