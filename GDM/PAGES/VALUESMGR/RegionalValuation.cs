namespace IRONQA.GDM.PAGES.VALUESMGR
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class RegionalValuation
    {
        private IWebDriver driver;
        public RegionalValuation(IWebDriver _driver) => driver = _driver;
        private IWebElement RegionLabel => driver.FindElement(By.CssSelector("#baseproduct-region-table-usd > thead > tr > th:nth-child(1)"));
        private IWebElement LoadingGear => driver.FindElement(By.CssSelector("#value-manager-body > div > div > div > div.loading > i"));
        private IWebElement RegionalValuationButton => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(3) > div > ul > li:nth-child(4) > a"));
        private IWebElement BaseModelData => driver.FindElement(By.Id("base-model-wrapper"));
        private IWebElement ComparableModelData => driver.FindElement(By.Id("comparable-models-wrapper"));
        public static string BaseMSRP, BaseMSRPPercent, BaseNGV, BaseLGV, BaseDeltaLQ, BaseDeltaLY, BaseReportAverage, BaseReportDelta, BaseReportCount;
        public static string CompMSRP, CompMSRPPercent, CompNGV, CompLGV, CompDeltaLQ, CompDeltaLY, CompReportAverage, CompReportDelta, CompReportCount;
       
        public void ConfirmOnRegionalValuationPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            try
            {
                Assert.IsTrue(RegionLabel.Displayed);
                Util.Log("On Regional Valuation Page.");
            }
            catch (Exception ex) { Util.Log(ex.ToString()); }
        }

        public void ConfirmBaseModelDataDisplayed()
        {
            try
            {
                Assert.IsTrue(BaseModelData.Displayed);
                Util.Log("Base Model Data Displayed.");
            }
            catch (Exception ex) { Util.Log(ex.ToString()); }
        }

        public void ConfirmComparableModelDataDisplayed()
        {
            try
            {
                Assert.IsTrue(ComparableModelData.Displayed);
                Util.Log("Comparable Model Data Displayed.");
            }
            catch (Exception ex) { Util.Log(ex.ToString()); }
        }

        public void GetMSRP(bool isBase, string model, string region)
        {
            Thread.Sleep(1500);
            IWebElement MSRP;
            if(isBase)
            {
                MSRP = driver.FindElement(By.XPath("//*[contains(@id,'base-model-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'BASE-MSRP')]/div"));
                BaseMSRP = CleanValue(MSRP.Text);
                Util.Log("RV MSRP = "+BaseMSRP);
            }
            else
            {
                MSRP = driver.FindElement(By.XPath("//*[contains(@class,'table-models-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'COMPARABLE-MSRP')]/div"));
                CompMSRP = CleanValue(MSRP.Text);
                Util.Log("RV MSRP = "+CompMSRP);
            }
        }

        public void GetMSRPPercent(bool isBase, string model, string region)
        {
            IWebElement MSRPPercent;
            if(isBase)
            {
                MSRPPercent = driver.FindElement(By.XPath("//*[contains(@id,'base-model-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'BASE-MSRP-percent')]/div"));
                BaseMSRPPercent = CleanValue(MSRPPercent.Text);
                Util.Log("RV MSRP% = "+BaseMSRPPercent);
            }
            else
            {
                MSRPPercent = driver.FindElement(By.XPath("//*[contains(@class,'table-models-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'COMPARABLE-MSRP-percent')]/div"));
                CompMSRPPercent = CleanValue(MSRPPercent.Text);
                Util.Log("RV MSRP% = "+CompMSRPPercent);
            }
        }

        public void GetNewGuideValue(bool isBase, string model, string region)
        {
            IWebElement NGV;
            if(isBase)
            {
                NGV = driver.FindElement(By.XPath("//*[contains(@id,'base-model-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'BASE-NGV')]/div"));
                BaseNGV = CleanValue(NGV.Text);
                Util.Log("RV NGV = "+BaseNGV);
            }
            else
            {
                NGV = driver.FindElement(By.XPath("//*[contains(@class,'table-models-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'COMPARABLE-NGV')]/div"));
                CompNGV = CleanValue(NGV.Text);
                Util.Log("BVM NGV = "+CompNGV);
            }
        }

        public void GetLastGuideValue(bool isBase, string model, string region)
        {
            IWebElement LGV;
            if(isBase)
            {
                LGV = driver.FindElement(By.XPath("//*[contains(@id,'base-model-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'BASE-LGV')]/div"));
                BaseLGV = CleanValue(LGV.Text);
                Util.Log("RV LGV = "+BaseLGV);
            }
            else
            {
                LGV = driver.FindElement(By.XPath("//*[contains(@class,'table-models-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'COMPARABLE-LGV')]/div"));
                CompLGV = CleanValue(LGV.Text);
                Util.Log("RV LGV = "+CompLGV);
            }
        }

        public void GetDeltaLastQuarter(bool isBase, string model, string region)
        {
            IWebElement DeltaLQ;
            if(isBase)
            {
                DeltaLQ = driver.FindElement(By.XPath("//*[contains(@id,'base-model-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'BASE-delta-LQ')]/div"));
                BaseDeltaLQ = CleanValue(DeltaLQ.Text);
                Util.Log("RV ∆%LQ = "+BaseDeltaLQ);
            }
            else
            {
                DeltaLQ = driver.FindElement(By.XPath("//*[contains(@class,'table-models-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'COMPARABLE-delta-LQ')]/div"));
                CompDeltaLQ = CleanValue(DeltaLQ.Text);
                Util.Log("RV ∆%LQ = "+CompDeltaLQ);
            }
        }

        public void GetDeltaLastYear(bool isBase, string model, string region)
        {
            IWebElement DeltaLY;
            if(isBase)
            {
                DeltaLY = driver.FindElement(By.XPath("//*[contains(@id,'base-model-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'BASE-delta-LY')]/div"));
                BaseDeltaLY = CleanValue(DeltaLY.Text);
                Util.Log("RV ∆%LY = "+BaseDeltaLY);
            }
            else
            {
                DeltaLY = driver.FindElement(By.XPath("//*[contains(@class,'table-models-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'COMPARABLE-delta-LY')]/div"));
                CompDeltaLY = CleanValue(DeltaLY.Text);
                Util.Log("RV ∆%LY = "+CompDeltaLY);
            }
        }

        public void GetReportAverage(bool isBase, string model, string region)
        {
            IWebElement ReportAvg;
            if(isBase)
            {
                ReportAvg = driver.FindElement(By.XPath("//*[contains(@id,'base-model-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'BASE-sold-rpt-avg')]/div"));
                BaseReportAverage = CleanValue(ReportAvg.Text);
                Util.Log("RV ReportAverage = "+BaseReportAverage);
            }
            else
            {
                ReportAvg = driver.FindElement(By.XPath("//*[contains(@class,'table-models-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'COMPARABLE-sold-rpt-avg')]/div"));
                CompReportAverage = CleanValue(ReportAvg.Text);
                Util.Log("RV ReportAverage = "+CompReportAverage);
            }
        }

        public void GetReportDelta(bool isBase, string model, string region)
        {
            IWebElement ReportDelta;
            if(isBase)
            {
                ReportDelta = driver.FindElement(By.XPath("//*[contains(@id,'base-model-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'BASE-delta-rpt')]/div"));
                BaseReportDelta = CleanValue(ReportDelta.Text);
                Util.Log("RV Report∆% = "+BaseReportDelta);
            }
            else
            {
                ReportDelta = driver.FindElement(By.XPath("//*[contains(@class,'table-models-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'COMPARABLE-delta-rpt')]/div"));
                CompReportDelta = CleanValue(ReportDelta.Text);
                Util.Log("RV Report∆% = "+CompReportDelta);
            }
        }

        public void GetReportCount(bool isBase, string model, string region)
        {
            IWebElement ReportCount;
            if(isBase)
            {
                ReportCount = driver.FindElement(By.XPath("//*[contains(@id,'base-model-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'BASE-sold-rpt-cnt')]/div"));
                BaseReportCount = CleanValue(ReportCount.Text);
                Util.Log("RV ReportCount = "+BaseReportCount);
            }
            else
            {
                ReportCount = driver.FindElement(By.XPath("//*[contains(@class,'table-models-wrapper')]/h5[contains(text(),'"+model+"')]/../table/tbody/tr/td[contains(@class,'region-"+region+"')]/../td[contains(@class,'COMPARABLE-sold-rpt-cnt')]/div"));
                CompReportCount = CleanValue(ReportCount.Text);
                Util.Log("RV ReportCount = "+CompReportCount);
            }
        }

        public string CleanValue(string value)
        {
            string val = value.Replace("$", string.Empty).Replace(",", string.Empty).Replace("%", string.Empty).Replace("C", string.Empty).TrimStart().TrimEnd();
            return val;
        }

        public void GetAllValues(bool isBase, string model, string region)
        {
            GetMSRP(isBase,model,region);
            GetMSRPPercent(isBase,model,region);
            GetNewGuideValue(isBase,model,region);
            GetLastGuideValue(isBase,model,region);
            GetDeltaLastQuarter(isBase,model,region);
            GetDeltaLastYear(isBase,model,region);
            GetReportAverage(isBase,model,region);
            GetReportDelta(isBase,model,region);
            GetReportCount(isBase,model,region);
        }
    }
}