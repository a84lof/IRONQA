namespace IRONQA.STORE.PAGES.SHARED
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    
    public class Home
    {
        private IWebDriver driver;
        public Home(IWebDriver _driver) => driver = _driver;
        private IWebElement Title => driver.FindElement(By.CssSelector(""));
        
        public void ConfirmOnStoreHomePage()
        {
            try
            {
                Assert.IsTrue(driver.Url.Contains("store.ironsearch.com"));
            }
            catch (Exception ex) {Util.Log("\n " +ex+ "\n");}
        }
    }
}
