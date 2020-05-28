namespace IRONQA.NETSUITE.PAGES.SHARED
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    
    public class Error
    {
        private IWebDriver driver;
        public Error(IWebDriver _driver) => driver = _driver;
        private IWebElement GoBack => driver.FindElement(By.Id("goback"));

        // Confirm on Error Page
        public void ConfirmErrorPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            try
            {
                Assert.IsTrue(driver.Url.Contains("nllogin.nl"));
                Util.Log("On Error Page");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "Assert Failed." + ex); }
        }

        // Click Go Back Button
        public NSLogin ClickGoBack()
        {
            GoBack.Click();
            return new NSLogin(driver);
        }
    }
}