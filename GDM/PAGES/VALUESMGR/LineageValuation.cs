namespace IRONQA.GDM.PAGES.VALUESMGR
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class LineageValuation
    {
        private IWebDriver driver;
        public LineageValuation(IWebDriver _driver) => driver = _driver;
        private IWebElement LoadingGear => driver.FindElement(By.CssSelector("#value-manager-body > div > div > div > div.loading > i"));
        private IWebElement LineageButton => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(2) > div > ul > li:nth-child(3) > a"));
        private IWebElement Region => driver.FindElement(By.XPath("//*[contains(@id,'react-select-region--value')]"));
        private IWebElement RegionInput => driver.FindElement(By.XPath("//*[contains(@id,'react-select-region--value')]/div[2]/input"));
        private IWebElement FilteredRegion => driver.FindElement(By.XPath("//*[contains(@id,'react-select-region--option-0')]"));
        private IWebElement SelectedFilters => driver.FindElement(By.CssSelector("#makes-and-models-checkboxes > div"));
        private IWebElement JDLineageCheckbox => driver.FindElement(By.Id("JD-checkbox"));
        private IWebElement AGCOLineageCheckbox => driver.FindElement(By.Id("AGGL-checkbox"));
        private IWebElement BaseLabel => driver.FindElement(By.CssSelector("#S650 > div.header-and-collapser > div > div"));
        private IWebElement GroupYearAdjust => driver.FindElement(By.ClassName("year-adjust-input"));
        private IWebElement DisabledGroupYearAdjust => driver.FindElement(By.XPath("//*[contains(@id, 'year-adjust') and contains(@input,disabled)]"));
        public static string BaseMSRP,BaseMSRPPercent,BaseNGV,BaseLGV,BasePCV,BaseDeltaLQ, BaseDeltaLY, BaseReportAverage, BaseReportDelta, BaseReportCount;
        public static string CompMSRP, CompMSRPPercent, CompNGV, CompLGV, CompPCV, CompDeltaLQ, CompDeltaLY, CompReportAverage, CompReportDelta, CompReportCount;
        
        public void ConfirmOnLineageValuationPage()
        {
            Thread.Sleep(3000);
            try
            {
                Assert.IsTrue(LineageButton.GetAttribute("class").Contains("active"));
                Util.Log("On Lineage Valuation Page");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmLineageDataDisplayed()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'scrollable-lineages')]");
            Util.Log("Lineage Data Displayed");
        }

        public void GetMSRP(bool isBase, string year, string model)
        {
            IWebElement MSRP;
            if(isBase)
            {
                MSRP = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[5]/div/div[3]/div[5]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Base-MSRP')]"));
                BaseMSRP = CleanValue(MSRP.Text);
                Util.Log("LV MSRP = "+BaseMSRP);
            }
            else
            {
                MSRP = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[10]/div/div[3]/div[2]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Comparable-MSRP')]"));
                CompMSRP = CleanValue(MSRP.Text);
                Util.Log("LV MSRP = "+CompMSRP);
            }
        }

        public void GetMSRPPercent(bool isBase, string year, string model)
        {
            IWebElement MSRPPercent;
            if(isBase)
            {
                MSRPPercent = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[5]/div/div[3]/div[5]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Base-MSRP%')]"));
                BaseMSRPPercent = CleanValue(MSRPPercent.Text);
                Util.Log("LV MSRP% = "+BaseMSRPPercent);
            }
            else
            {
                MSRPPercent = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[10]/div/div[3]/div[2]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Comparable-MSRP%')]"));
                CompMSRPPercent = CleanValue(MSRPPercent.Text);
                Util.Log("LV MSRP% = "+CompMSRPPercent);
            }
        }

        public void GetNewGuideValue(bool isBase, string year, string model)
        {
            IWebElement NGV;
            if(isBase)
            {
                NGV = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[5]/div/div[3]/div[5]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Base-NGV')]"));
                BaseNGV = CleanValue(NGV.Text);
                Util.Log("LV NGV = "+BaseNGV);
            }
            else
            {
                NGV = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[10]/div/div[3]/div[2]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Comparable-NGV')]"));
                CompNGV = CleanValue(NGV.Text);
                Util.Log("BVM NGV = "+CompNGV);
            }
        }

        public void GetLastGuideValue(bool isBase, string year, string model)
        {
            IWebElement LGV;
            if(isBase)
            {
                LGV = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[5]/div/div[3]/div[5]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Base-LGV')]"));
                BaseLGV = CleanValue(LGV.Text);
                Util.Log("LV LGV = "+BaseLGV);
            }
            else
            {
                LGV = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[10]/div/div[3]/div[2]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Comparable-LGV')]"));
                CompLGV = CleanValue(LGV.Text);
                Util.Log("LV LGV = "+CompLGV);
            }
        }

        public void GetPredictedCashValue(bool isBase, string year, string model)
        {
            IWebElement PCV;
            if(isBase)
            {
                PCV = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[5]/div/div[3]/div[5]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Base-PCV')]"));
                BasePCV = CleanValue(PCV.Text);
                Util.Log("LV PCV = "+BasePCV);
            }
            else
            {
                PCV = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[10]/div/div[3]/div[2]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Comparable-PCV')]"));
                CompPCV = CleanValue(PCV.Text);
                Util.Log("LV PCV = "+CompPCV);
            }
        }

        public void GetDeltaLastQuarter(bool isBase, string year, string model)
        {
            IWebElement DeltaLQ;
            if(isBase)
            {
                DeltaLQ = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[5]/div/div[3]/div[5]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Base-CHGLQ')]"));
                BaseDeltaLQ = CleanValue(DeltaLQ.Text);
                Util.Log("LV ∆%LQ = "+BaseDeltaLQ);
            }
            else
            {
                DeltaLQ = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[10]/div/div[3]/div[2]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Comparable-CHGLQ')]"));
                CompDeltaLQ = CleanValue(DeltaLQ.Text);
                Util.Log("LV ∆%LQ = "+CompDeltaLQ);
            }
        }

        public void GetDeltaLastYear(bool isBase, string year, string model)
        {
            IWebElement DeltaLY;
            if(isBase)
            {
                DeltaLY = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[5]/div/div[3]/div[5]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Base-CHGLY')]"));
                BaseDeltaLY = CleanValue(DeltaLY.Text);
                Util.Log("LV ∆%LY = "+BaseDeltaLY);
            }
            else
            {
                DeltaLY = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[10]/div/div[3]/div[2]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Comparable-CHGLY')]"));
                CompDeltaLY = CleanValue(DeltaLY.Text);
                Util.Log("LV ∆%LY = "+CompDeltaLY);
            }
        }

        public void GetReportAverage(bool isBase, string year, string model)
        {
            IWebElement ReportAvg;
            if(isBase)
            {
                ReportAvg = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[5]/div/div[3]/div[5]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Base-AVGPRICE')]"));
                BaseReportAverage = CleanValue(ReportAvg.Text);
                Util.Log("LV ReportAverage = "+BaseReportAverage);
            }
            else
            {
                ReportAvg = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[10]/div/div[3]/div[2]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Comparable-AVGPRICE')]"));
                CompReportAverage = CleanValue(ReportAvg.Text);
                Util.Log("LV ReportAverage = "+CompReportAverage);
            }
        }

        public void GetReportDelta(bool isBase, string year, string model)
        {
            IWebElement ReportDelta;
            if(isBase)
            {
                ReportDelta = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[5]/div/div[3]/div[5]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Base-RPTCHG')]"));
                BaseReportDelta = CleanValue(ReportDelta.Text);
                Util.Log("LV Report∆% = "+BaseReportDelta);
            }
            else
            {
                ReportDelta = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[10]/div/div[3]/div[2]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Comparable-RPTCHG')]"));
                CompReportDelta = CleanValue(ReportDelta.Text);
                Util.Log("LV Report∆% = "+CompReportDelta);
            }
        }

        public void GetReportCount(bool isBase, string year, string model)
        {
            IWebElement ReportCount;
            if(isBase)
            {
                ReportCount = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[5]/div/div[3]/div[5]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Base-RPTCNT')]"));
                BaseReportCount = CleanValue(ReportCount.Text);
                Util.Log("LV ReportCount = "+BaseReportCount);
            }
            else
            {
                ReportCount = driver.FindElement(By.XPath("//*[contains(@id,'"+model+"')]/div[10]/div/div[3]/div[2]/div/div[contains(@id,'"+year+"')]/div/div[contains(@class,'Comparable-RPTCNT')]"));
                CompReportCount = CleanValue(ReportCount.Text);
                Util.Log("LV ReportCount = "+CompReportCount);
            }
        }

        public string CleanValue(string value)
        {
            string val = value.Replace("$", string.Empty).Replace(",", string.Empty).Replace("%", string.Empty).Replace("C", string.Empty).TrimStart().TrimEnd();
            return val;
        }

        public void GetAllValues(bool isBase, string year, string model)
        {
            GetMSRP(isBase,year,model);
            GetMSRPPercent(isBase,year,model);
            GetNewGuideValue(isBase,year,model);
            GetLastGuideValue(isBase,year,model);
            GetPredictedCashValue(isBase,year,model);
            GetDeltaLastQuarter(isBase,year,model);
            GetDeltaLastYear(isBase,year,model);
            GetReportAverage(isBase,year,model);
            GetReportDelta(isBase,year,model);
            GetReportCount(isBase,year,model);
        }

        public void ConfirmGroupYearAdjustEditable(bool isEditable)
        {
            if(isEditable)
            {
                try
                {
                    Assert.IsTrue(GroupYearAdjust.Displayed);
                    Util.Log("Group Year Adjust Editable.");
                }
                catch (Exception ex) { Util.Log(Util.Fail() + "\r GYA IS Not Editable \n" + ex); }
            }
        }

        public void ToggleSelectedFilters()
        {
            Thread.Sleep(1500);
            SelectedFilters.Click();
            Util.Log("Toggled Filters.");
            Thread.Sleep(1000);
        }

        public void ToggleJDLineageCheckbox()
        {
            JDLineageCheckbox.Click();
            Util.Log("Toggled JD Lineage Checkbox");
            Thread.Sleep(500);
        }

        public void ToggleAGCOLineageCheckbox()
        {
            AGCOLineageCheckbox.Click();
            Thread.Sleep(2000); //Allow Lineages to Shift 
            Util.Log("Toggled AGCO Lineage Checkbox");
        }

        public void SelectRegion(string region)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'react-select-region--value')]");
            Region.Click();
            Thread.Sleep(250);
            RegionInput.SendKeys(region);
            Thread.Sleep(500);
            FilteredRegion.Click();
            Thread.Sleep(500);
            Util.Log("Selected Region "+region);
        }

        public void CompareBaseLineageToRGV()
        {// Catch and report any non-matching values - Lineage 3yo base model vs RGV Region D
            try { Assert.AreEqual(BaseMSRP, RegionalValuation.BaseMSRP); }
            catch (Exception ex) { Util.Log("\n LV MSRP != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseMSRPPercent, RegionalValuation.BaseMSRPPercent); }
            catch (Exception ex) { Util.Log("\n LV MSRPPercent != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseNGV, RegionalValuation.BaseNGV); }
            catch (Exception ex) { Util.Log("\n LV NGV != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseLGV, RegionalValuation.BaseLGV); }
            catch (Exception ex) { Util.Log("\n LV LVG != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseDeltaLQ, RegionalValuation.BaseDeltaLQ); }
            catch (Exception ex) { Util.Log("\n LV DeltaLQ != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseDeltaLY, RegionalValuation.BaseDeltaLY); }
            catch (Exception ex) { Util.Log("\n LV DeltaLY != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseReportAverage, RegionalValuation.BaseReportAverage); }
            catch (Exception ex) { Util.Log("\n LV ReportAverage != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseReportDelta, RegionalValuation.BaseReportDelta); }
            catch (Exception ex) { Util.Log("\n LV ReportDelta != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseReportCount, RegionalValuation.BaseReportCount); }
            catch (Exception ex) { Util.Log("\n Lv ReportCount != RV \n" + ex + "\n"); }
        }

        public void CompareCompLineageToRGV()
        {// Catch and report any non-matching values - Lineage 3yo base model vs RGV Region D
            try { Assert.AreEqual(CompMSRP, RegionalValuation.CompMSRP); }
            catch (Exception ex) { Util.Log("\n LV MSRP != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompMSRP, RegionalValuation.CompMSRPPercent); }
            catch (Exception ex) { Util.Log("\n LV MSRPPercent != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompNGV, RegionalValuation.CompNGV); }
            catch (Exception ex) { Util.Log("\n LV NGV != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompLGV, RegionalValuation.CompLGV); }
            catch (Exception ex) { Util.Log("\n LV LGV != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompDeltaLQ, RegionalValuation.CompDeltaLQ); }
            catch (Exception ex) { Util.Log("\n LV DeltaLQ != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompDeltaLY, RegionalValuation.CompDeltaLY); }
            catch (Exception ex) { Util.Log("\n LV DeltaLY != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompReportAverage, RegionalValuation.CompReportAverage); }
            catch (Exception ex) { Util.Log("\n LV ReportAverage != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompReportDelta, RegionalValuation.CompReportDelta); }
            catch (Exception ex) { Util.Log("\n LV ReportDelta != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompReportCount, RegionalValuation.CompReportCount); }
            catch (Exception ex) { Util.Log("\n LV ReportCount != RV \n" + ex + "\n"); }
        }
    }
}