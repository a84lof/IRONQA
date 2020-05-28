namespace IRONQA.FSBO.PAGES.FORSALEBYOWNER
{
    using System;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Step3
    {
        private IWebDriver driver;
        public Step3(IWebDriver _driver) => driver = _driver;
        private IWebElement Next => driver.FindElement(By.CssSelector("#Content_Content_btnContinue > div"));

        public void ConfirmOnStep3()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/preview");
            Util.Log("On Step 3.");
        }

        public Step4 ClickNext()
        {
            Next.Click();
            Util.Log("Clicked Next.");
            return new Step4(driver);
        }
    }
}