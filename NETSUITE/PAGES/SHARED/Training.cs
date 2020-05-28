namespace IRONQA.NETSUITE.PAGES.SHARED
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    public class Training
    {
        private IWebDriver driver;

        public Training(IWebDriver _driver) => driver = _driver;

        // Confirm On Training Page
        public void ConfirmOnTrainingPage()
        {
            try
            {
                Assert.IsTrue(driver.Url.Contains("https://system.na2.netsuite.com/core/media/media.nl?id=939487&c=936026&h=4190179d69f1fd7212dc&_xt=.pdf"));
                Util.Log("On Training Page");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "Assert Failed." + ex); }
        }
    }
}
