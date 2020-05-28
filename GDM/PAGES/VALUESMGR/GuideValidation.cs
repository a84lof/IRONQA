namespace IRONQA.GDM.PAGES.VALUESMGR
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class GuideValidation
    {
        private IWebDriver driver;
        public GuideValidation(IWebDriver _driver) => driver = _driver;
        private IWebElement GuideValidationButton => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(2) > div > ul > li:nth-child(5) > a"));
        private IWebElement ManufacturerInput => driver.FindElement(By.XPath("//*[contains(@id,'react-select-4--value')]/div[2]/input"));
        private IWebElement Manufacturer => driver.FindElement(By.XPath("//*[contains(@id,'react-select-4--value')]"));
        private IWebElement FilteredManufacturer => driver.FindElement(By.XPath("//*[contains(@id,'react-select-4--option-0')]"));
        private IWebElement ModelInput => driver.FindElement(By.XPath("//*[contains(@id,'react-select-5--value')]/div[2]/input"));
        private IWebElement Model => driver.FindElement(By.XPath("//*[contains(@id,'react-select-5--value')]"));
        private IWebElement FilteredModel => driver.FindElement(By.XPath("//*[contains(@id,'react-select-5--option-0')]"));
        public static string AverageWholeSale;
        public static string TradeRough;
        public static string TradePremium;
        public static string ResaleCash;
        public static string LQDelta;
        public static string RetailAdvertised;
        public static string ReportDelta;
        public static string ReportAverage;
        public static string ReportCount;
        public static string NationalReportAverage;
        public static string NationalReportDelta;
        public static string NationalReportAverageDelta;
        public static string NationalReportCount;
        public static string ExchangeRate;
        public static string AverageMeterUsage;
        public static string AverageReconditioning;
        public static string MeterValue;

        public void ConfirmOnGuideValidationPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Thread.Sleep(5000);
            try
            {
                var rvb = GuideValidationButton.GetAttribute("class");
                Assert.IsTrue(rvb.Contains("active"));
                Util.Log("On Guide Validation Page.");
            }
            catch (Exception ex) { Util.Log(ex.ToString()); }
        }

        public void SelectManufacturer(string make)
        {
            Manufacturer.Click();
            Thread.Sleep(1500);
            ManufacturerInput.SendKeys(make);
            Thread.Sleep(1500);
            FilteredManufacturer.Click();
            Thread.Sleep(1500);
            Util.Log("Selected Manufacturer: " + make);
        }

        public void SelectModel(string model)
        {
            Model.Click();
            Thread.Sleep(1500);
            ModelInput.SendKeys(model);
            Thread.Sleep(1500);
            FilteredModel.Click();
            Thread.Sleep(1500);
            Util.Log("Selected Model: " + model);
        }

        public void GetAveragegWholesale(string region, string type, string makeCode, string year)
        {
            IWebElement AvgWholesale = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'Region-" + region + "')]/td[6]"));
            AverageWholeSale = CleanValue(AvgWholesale.Text);
            Util.Log("GV AvgWholesale = " + AverageWholeSale);
        }

        public void GetTradeRough(string region, string type, string makeCode, string year)
        {
            IWebElement Rough = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'Region-" + region + "')]/td[7]"));
            TradeRough = CleanValue(Rough.Text);
            Util.Log("GV TradeRough = " + TradeRough);
        }

        public void GetTradePremium(string region, string type, string makeCode, string year)
        {
            IWebElement Premium = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'Region-" + region + "')]/td[8]"));
            TradePremium = CleanValue(Premium.Text);
            Util.Log("GV TradePremium = " + TradePremium);
        }

        public void GetResaleCash(string region, string type, string makeCode, string year)
        {
            IWebElement Cash = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'Region-" + region + "')]/td[9]"));
            ResaleCash = CleanValue(Cash.Text);
            Util.Log("GV ResaleCash = " + ResaleCash);
        }

        public void GetLQDelta(string region, string type, string makeCode, string year)
        {
            type.ToString();
            IWebElement LQD = driver.FindElement(By.XPath("//*[contains(@class,'Type-" + type + "')and contains(@class,'MakeCode-" + makeCode + "')and contains(@class,'Year-" + year + "')and contains(@class,'Region-" + region + "')]/td[10]"));
            LQDelta = CleanValue(LQD.Text);
            Util.Log("GV LQDelta% = " + LQDelta);
        }

        public void GetRetailAdvertised(string region, string type, string makeCode, string year)
        {
            IWebElement Advertised = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'Region-" + region + "')]/td[11]"));
            RetailAdvertised = CleanValue(Advertised.Text);
            Util.Log("GV RetailAdvertised = " + RetailAdvertised);
        }

        public void GetReportDelta(string region, string type, string makeCode, string year)
        {
            IWebElement RptDelta = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'Year-" + year + "')and contains(@class,'Region-" + region + "')]/td[12]"));
            ReportDelta = CleanValue(RptDelta.Text);
            Util.Log("GV Report∆% = " + ReportDelta);
        }

        public void GetReportAverage(string region, string type, string makeCode, string year)
        {
            IWebElement ReportAvg = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'Year-" + year + "')and contains(@class,'Region-" + region + "')]/td[13]"));
            ReportAverage = CleanValue(ReportAvg.Text);
            if (ReportAverage == "0")
            {
                ReportAverage = "N/A";
            }
            Util.Log("GV ReportAverage = " + ReportAverage);
        }

        public void GetReportCount(string region, string type, string makeCode, string year)
        {
            IWebElement ReportCnt = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'Year-" + year + "')and contains(@class,'Region-" + region + "')]/td[14]"));
            ReportCount = CleanValue(ReportCnt.Text);
            Util.Log("GV ReportCount = " + ReportCount);
        }

        public void GetNationalReportAverage(string region, string type, string makeCode, string year)
        {
            IWebElement NatRptAvg = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'Region-" + region + "')]/td[15]"));
            NationalReportAverage = CleanValue(NatRptAvg.Text);
            Util.Log("GV NationalReportAverage = " + NationalReportAverage);
        }

        public void GetNationalReportDelta(string region, string type, string makeCode, string year)
        {
            IWebElement NatRptDelta = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'Region-" + region + "')]/td[16]"));
            NationalReportDelta = CleanValue(NatRptDelta.Text);
            Util.Log("GV NationalReportDelta% = " + NationalReportDelta);
        }

        public void GetNationalReportAverageDelta(string region, string type, string makeCode, string year)
        {
            IWebElement NatRptAvgDelta = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'Region-" + region + "')]/td[17]"));
            NationalReportAverageDelta = CleanValue(NatRptAvgDelta.Text);
            Util.Log("GV NationalReportAverageDelta% = " + NationalReportAverageDelta);
        }

        public void GetNationalReportCount(string region, string type, string makeCode, string year)
        {
            IWebElement NatRptCount = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'Region-" + region + "')]/td[18]"));
            NationalReportCount = CleanValue(NatRptCount.Text);
            Util.Log("GV NationalReportCount = " + NationalReportCount);
        }

        public void GetExchangeRate(string region, string type, string makeCode, string year)
        {
            IWebElement ExRate = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'Region-" + region + "')]/td[19]"));
            ExchangeRate = CleanValue(ExRate.Text);
            Util.Log("GV ExchangeRate = " + ExchangeRate);
        }

        public void GetAverageMeterUsage(string region, string type, string makeCode, string year)
        {
            IWebElement AvgMeterUsage = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'Region-" + region + "')]/td[20]"));
            AverageMeterUsage = CleanValue(AvgMeterUsage.Text);
            Util.Log("GV AverageMeterUsage = " + AverageMeterUsage);
        }

        public void GetAverageReconditioning(string region, string type, string makeCode, string year)
        {
            IWebElement AvgReconditioning = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'Region-" + region + "')]/td[21]"));
            AverageReconditioning = CleanValue(AvgReconditioning.Text);
            Util.Log("GV AverageReconditioning = " + AverageReconditioning);
        }

        public void GetMeterValue(string region, string type, string makeCode, string year)
        {
            IWebElement MeterVal = driver.FindElement(By.XPath("//*[contains(@class,'" + type + "')and contains(@class,'" + makeCode + "')and contains(@class,'" + year + "')and contains(@class,'" + region + "')]/td[22]"));
            MeterValue = CleanValue(MeterVal.Text);
            Util.Log("GV MeterValue = " + MeterValue);
        }

        public string CleanValue(string value)
        {
            string val = value.Replace("$", string.Empty).Replace(",", string.Empty).Replace("%", string.Empty).Replace("C", string.Empty).TrimStart().TrimEnd();
            return val;
        }

        public void GetAllValues(string region, string type, string makeCode, string year)
        {
            GetResaleCash(region, type, makeCode, year);
            GetLQDelta(region, type, makeCode, year);
            GetReportAverage(region, type, makeCode, year);
            GetReportDelta(region, type, makeCode, year);
            GetReportCount(region, type, makeCode, year);
        }

        public void ComparePrepublishedGVtoLineages()
        {// rounds to nearest $10
            try { Assert.IsTrue(Int32.Parse(ResaleCash) - Int32.Parse(LineageValuation.BaseNGV) <= 10); }
            catch (Exception ex) { Util.Log("\n GV ResaleCash != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(LQDelta, LineageValuation.BaseDeltaLQ); }
            catch (Exception ex) { Util.Log("\n GV ∆%LQ != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(ReportAverage, LineageValuation.BaseReportAverage); }
            catch (Exception ex) { Util.Log("\n GV ReportAverage != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(ReportDelta, LineageValuation.BaseReportDelta); }
            catch (Exception ex) { Util.Log("\n GV ReportDelta != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(ReportCount, LineageValuation.BaseReportCount); }
            catch (Exception ex) { Util.Log("\n GV ReportCount != LV \n" + ex + "\n"); }
        }

        public void ConfirmPrepublishedValues()
        {
            try
            {
                //First row of data
                IWebElement data = driver.FindElement(By.XPath("//*[contains(@class,'k-master-row')]"));
                Util.Log("Prepublished Values Displayed.");
            }
            catch (Exception ex) { Util.Log("\n" + ex + "\n"); }
        }
    }
}