namespace IRONQA.NETSUITE.PAGES.SHARED
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    
    public class WhatsNew
    {
        private IWebDriver driver;

        public WhatsNew(IWebDriver _driver) => driver = _driver;

        // Confirm On What's New Page
        public void ConfirmOnWhatsNewPage()
        {
            try
            {
                Assert.IsTrue(driver.Url.Contains("https://system.na2.netsuite.com/core/media/media.nl?id=847554&c=936026&h=bd067fd0c2f9eb8dafc9&_xt=.pdf"));
                Util.Log("On What's New Page");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "Assert Failed." + ex); }
        }
    }
}