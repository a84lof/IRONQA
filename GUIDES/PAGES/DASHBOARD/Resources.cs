namespace IRONQA.GUIDES.PAGES.DASHBOARD
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    public class Resources
    {
        private IWebDriver driver;
        public Resources(IWebDriver _driver) => driver = _driver;
        private IWebElement PowerUnitInspectionPDF => driver.FindElement(By.CssSelector("#forms-resources > ul:nth-child(3) > li:nth-child(1) > div > a > span"));
        private IWebElement ImplementInspectionPDF => driver.FindElement(By.CssSelector("#forms-resources > ul:nth-child(3) > li:nth-child(2) > div > a > span"));
        private IWebElement RentalRates => driver.FindElement(By.CssSelector("#forms-resources > ul:nth-child(6)"));
        private IWebElement USRentalRatesPDF => driver.FindElement(By.CssSelector("#forms-resources > ul:nth-child(6) > li:nth-child(1) > div > a > span"));
        private IWebElement CanadaRentalRatesPDF => driver.FindElement(By.CssSelector("#forms-resources > ul:nth-child(6) > li:nth-child(2) > div > a > span"));

        public void VerifyPrintableResourcesPDFs()
        {
            try
            {
                Assert.IsTrue(PowerUnitInspectionPDF.Displayed);
                Assert.IsTrue(ImplementInspectionPDF.Displayed);
                Assert.IsTrue(USRentalRatesPDF.Displayed);
                Assert.IsTrue(CanadaRentalRatesPDF.Displayed);
                Util.Log("All Resources Tab PDFs Verified");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }
    }
}