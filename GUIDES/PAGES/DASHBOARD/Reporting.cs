namespace IRONQA.GUIDES.PAGES.DASHBOARD
{
    using IRONQA.DEALERDASH.PAGES;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    public class Reporting
    {
        private IWebDriver driver;
        public Reporting(IWebDriver _driver) => driver = _driver;
        private IWebElement DealerReportingHandbookPDF => driver.FindElement(By.CssSelector("#sales-report > ul:nth-child(6) > li:nth-child(1) > div > a > span"));
        private IWebElement EquipmentTypeCodeListPDF => driver.FindElement(By.CssSelector("#sales-report > ul:nth-child(6) > li:nth-child(2) > div > a > span"));
        private IWebElement AgAndHarvestEquipPDF => driver.FindElement(By.CssSelector("#sales-report > ul:nth-child(8) > li:nth-child(1) > div > a.pdf-download > span"));
        private IWebElement AgAndHarvestEquipXLS => driver.FindElement(By.CssSelector("#sales-report > ul:nth-child(8) > li:nth-child(1) > div > a.xls-download > span"));
        private IWebElement AgAuctionSalesPDF => driver.FindElement(By.CssSelector("#sales-report > ul:nth-child(8) > li:nth-child(2) > div > a.pdf-download > span"));
        private IWebElement AgAuctionSalesXLS => driver.FindElement(By.CssSelector("#sales-report > ul:nth-child(8) > li:nth-child(2) > div > a.xls-download > span"));
        private IWebElement ConstructionIndEquipPDF => driver.FindElement(By.CssSelector("#sales-report > ul:nth-child(8) > li:nth-child(3) > div > a.pdf-download > span"));
        private IWebElement ConstructionIndEquipXLS => driver.FindElement(By.CssSelector("#sales-report > ul:nth-child(8) > li:nth-child(3) > div > a.xls-download > span"));
        private IWebElement OutdoorPowerEquipmentPDF => driver.FindElement(By.CssSelector("#sales-report > ul:nth-child(8) > li:nth-child(4) > div > a.pdf-download > span"));
        private IWebElement OutdoorPowerEquipmentXLS => driver.FindElement(By.CssSelector("#sales-report > ul:nth-child(8) > li:nth-child(4) > div > a.xls-download > span"));
        private IWebElement GeneralPurposePDF => driver.FindElement(By.CssSelector("#sales-report > ul:nth-child(8) > li:nth-child(5) > div > a.pdf-download > span"));
        private IWebElement GeneralPurposeXLS => driver.FindElement(By.CssSelector("#sales-report > ul:nth-child(8) > li:nth-child(5) > div > a.xls-download > span"));
        private IWebElement LoginToIronDealer => driver.FindElement(By.CssSelector("#sales-report > a"));

        public DealerDashboard ClickLoginToIronDealer()
        {
            LoginToIronDealer.Click();
            Util.Log("Clicked Login To IronDealer Button.");
            return new DealerDashboard(driver);
        }

        public void VerifyPrintableReportingPDFs()
        {
            try
            {
                Assert.IsTrue(DealerReportingHandbookPDF.Displayed);
                Assert.IsTrue(EquipmentTypeCodeListPDF.Displayed);
                Assert.IsTrue(AgAndHarvestEquipPDF.Displayed);
                Assert.IsTrue(AgAuctionSalesPDF.Displayed);
                Assert.IsTrue(ConstructionIndEquipPDF.Displayed);
                Assert.IsTrue(OutdoorPowerEquipmentPDF.Displayed);
                Assert.IsTrue(GeneralPurposePDF.Displayed);
                Util.Log("All Reporting Tab PDFs Verified");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }
    }
}