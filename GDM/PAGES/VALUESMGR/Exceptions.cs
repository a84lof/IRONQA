namespace IRONQA.GDM.PAGES.VALUESMGR
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    
    public class Exceptions
    {
        private IWebDriver driver;
        public Exceptions(IWebDriver _driver) => driver = _driver;
        private IWebElement ExceptionsButton => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(3) > div > ul > li:nth-child(1) > a"));
        private IWebElement ShowIgnored => driver.FindElement(By.CssSelector("#ExceptionsManager > div.exceptions-controls > div:nth-child(2) > div > div:nth-child(2)"));
        private IWebElement ExceptionCount => driver.FindElement(By.CssSelector("#ExceptionsManager > div.exceptions-controls > div.floating-control > p"));

        public void ConfirmOnExceptionsPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            try
            {
                var e = ExceptionsButton.GetAttribute("class");
                Assert.IsTrue(e.Contains("active"));
                Util.Log("On Exceptions Page");
            }
            catch (Exception ex) { Util.Log(ex.ToString()); }
        }

        public void ToggleShowIgnored()
        {
            ShowIgnored.Click();
            Util.Log("Toggled Showing Ignored Exceptions.");
        }
    }
}