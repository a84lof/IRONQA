namespace IRONQA.GUIDES.PAGES.HELPCENTER
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    
    public class Media
    {
        private IWebDriver driver;
        public Media(IWebDriver _driver) => driver = _driver;
        private IWebElement OfficialGuideTab => driver.FindElement(By.Id("officialGuide-label"));
        private IWebElement IronForecastTab => driver.FindElement(By.Id("residualValue-label"));
        private IWebElement PdfOGBasicUserManual => driver.FindElement(By.CssSelector("#officialGuide > div:nth-child(1) > div > a:nth-child(2)"));
        private IWebElement PdfOGPlusOGUserManual => driver.FindElement(By.CssSelector("#officialGuide > div:nth-child(1) > div > a:nth-child(3)"));
        private IWebElement PdfSeparatorHoursFAQ => driver.FindElement(By.CssSelector("#officialGuide > div:nth-child(1) > div > a:nth-child(4)"));
        private IWebElement PdfBaseValueAdjustmentFAQ => driver.FindElement(By.CssSelector("#officialGuide > div:nth-child(1) > div > a:nth-child(5)"));
        private IWebElement VidOfficialGuide => driver.FindElement(By.CssSelector(".tabs-content>#officialGuide>.row>.small-12>video"));
        private IWebElement VidGuidesValues => driver.FindElement(By.CssSelector(".tabs-content>#officialGuide>.row:nth-child(3)>.small-12>video"));
        private IWebElement VidComparables => driver.FindElement(By.CssSelector(".tabs-content>#officialGuide>.row:nth-child(4)>.small-12>video"));
        private IWebElement VidGeneralPreferences => driver.FindElement(By.CssSelector(".tabs-content>#officialGuide>.row:nth-child(5)>.small-12>video"));
        private IWebElement VidFloorPlanRules => driver.FindElement(By.CssSelector(".tabs-content>#officialGuide>.row:nth-child(3)>.small-12:nth-child(2)>video"));
        private IWebElement VidCreatingTheAppraisal => driver.FindElement(By.CssSelector("#officialGuide > div:nth-child(2) > div.small-12.medium-4.medium-offset-1.end.columns > video"));
        private IWebElement VidFloorPlan => driver.FindElement(By.CssSelector("#officialGuide > div:nth-child(3) > div.small-12.medium-4.medium-offset-1.end.columns > video"));
        private IWebElement VidProspects => driver.FindElement(By.CssSelector(".tabs-content>#officialGuide>.row:nth-child(4)>.small-12:nth-child(2)>video"));
        private IWebElement VidCashAdjustmentRules => driver.FindElement(By.CssSelector(".tabs-content>#officialGuide>.row:nth-child(5)>.small-12:nth-child(2)>video"));
        private IWebElement PdfNavigatingIronForecast => driver.FindElement(By.CssSelector("#residualValue > div:nth-child(1) > div:nth-child(1) > a"));
        private IWebElement PdfPreparingMyInventory => driver.FindElement(By.CssSelector("#residualValue > div:nth-child(1) > div.medium-4.medium-offset-1.columns.end > a"));
        private IWebElement PdfPredictors => driver.FindElement(By.CssSelector("#residualValue > div:nth-child(2) > div:nth-child(1) > a"));
        private IWebElement PdfUsedEquipmentLookup => driver.FindElement(By.CssSelector("#residualValue > div:nth-child(2) > div.medium-4.medium-offset-1.columns.end > a"));
        private IWebElement PdfExporting => driver.FindElement(By.CssSelector("#residualValue > div:nth-child(3) > div:nth-child(1) > a"));
        private IWebElement PdfMyInventoryAnalysis => driver.FindElement(By.CssSelector("#residualValue > div:nth-child(3) > div.medium-4.medium-offset-1.columns.end > a"));
        private IWebElement VidNavigatingIronForecast => driver.FindElement(By.CssSelector("#residualValue > div:nth-child(1) > div:nth-child(1) > video"));
        private IWebElement VidPreparingMyInventory => driver.FindElement(By.CssSelector("#residualValue > div:nth-child(1) > div.medium-4.medium-offset-1.columns.end > video"));
        private IWebElement VidPredictors => driver.FindElement(By.CssSelector("#residualValue > div:nth-child(2) > div:nth-child(1) > video"));
        private IWebElement VidUsedEquipmentLookup => driver.FindElement(By.CssSelector("#residualValue > div:nth-child(2) > div.medium-4.medium-offset-1.columns.end > video"));
        private IWebElement VidExporting => driver.FindElement(By.CssSelector("#residualValue > div:nth-child(3) > div:nth-child(1) > video"));
        private IWebElement VidMyInventoryAnalysis => driver.FindElement(By.CssSelector("#residualValue > div:nth-child(3) > div.medium-4.medium-offset-1.columns.end > video"));

        public void ConfirmOnHelpCenterPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("help");
            Util.Log("On Help Center Page");
        }

        public void ClickOfficialGuideTab()
        {
            OfficialGuideTab.Click();
            Util.Log("Clicked Official Guide Tab");
        }

        public void ClickIronForecastTab()
        {
            IronForecastTab.Click();
            Util.Log("Clicked IronForecast Tab");
        }

        public void ConfirmOGDownloadablePDFs()
        {
            try
            {
                Assert.IsTrue(PdfOGBasicUserManual.Displayed);
                Assert.IsTrue(PdfOGPlusOGUserManual.Displayed);
                Assert.IsTrue(PdfSeparatorHoursFAQ.Displayed);
                Assert.IsTrue(PdfBaseValueAdjustmentFAQ.Displayed);
                Util.Log("OG PDFs Validated");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmOGVideosPresent()
        {
            try
            {
                Assert.IsTrue(VidOfficialGuide.Displayed);
                Assert.IsTrue(VidCreatingTheAppraisal.Displayed);
                Assert.IsTrue(VidGuidesValues.Displayed);
                Assert.IsTrue(VidFloorPlan.Displayed);
                Assert.IsTrue(VidComparables.Displayed);
                Assert.IsTrue(VidProspects.Displayed);
                Assert.IsTrue(VidGeneralPreferences.Displayed);
                Assert.IsTrue(VidCashAdjustmentRules.Displayed);
                Assert.IsTrue(VidFloorPlanRules.Displayed);
                Util.Log("OG Videos Present");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmIRONDownloadablePDFs()
        {
            try
            {
                Assert.IsTrue(PdfNavigatingIronForecast.Displayed);
                Assert.IsTrue(PdfPreparingMyInventory.Displayed);
                Assert.IsTrue(PdfPredictors.Displayed);
                Assert.IsTrue(PdfUsedEquipmentLookup.Displayed);
                Assert.IsTrue(PdfExporting.Displayed);
                Assert.IsTrue(PdfMyInventoryAnalysis.Displayed);
                Util.Log("IronForecast PDFs Validated");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmIRONVideosPresent()
        {
            try
            {
                Assert.IsTrue(VidNavigatingIronForecast.Displayed);
                Assert.IsTrue(VidPreparingMyInventory.Displayed);
                Assert.IsTrue(VidPredictors.Displayed);
                Assert.IsTrue(VidUsedEquipmentLookup.Displayed);
                Assert.IsTrue(VidExporting.Displayed);
                Assert.IsTrue(VidMyInventoryAnalysis.Displayed);
                Util.Log("Iron Forecast Videos Present");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }
    }
}
