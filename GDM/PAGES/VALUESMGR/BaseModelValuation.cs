namespace IRONQA.GDM.PAGES.VALUESMGR
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class BaseModelValuation
    {
        private IWebDriver driver;
        public BaseModelValuation(IWebDriver _driver) => driver = _driver;
        private static string ThreeYearOldModel = "2016";
        private IWebElement Region => driver.FindElement(By.XPath("//*[contains(@id,'react-select-region--value')]"));
        private IWebElement RegionInput => driver.FindElement(By.XPath("//*[contains(@id,'react-select-region--value')]/div[2]/input"));
        private IWebElement FilteredRegion => driver.FindElement(By.XPath("//*[contains(@id,'react-select-region--option-0')]"));
        private IWebElement ActiveBMVButton => driver.FindElement(By.XPath("//*[contains(@id,'nav-link')and (contains(@id, 'active')]"));
        private IWebElement SortBy => driver.FindElement(By.CssSelector("#BaseModelValuation > div:nth-child(1) > div > div.toggle-wrapper > div > div:nth-child(2)"));
        private IWebElement SortByModel => driver.FindElement(By.CssSelector("#BaseModelValuation > div:nth-child(1) > div > div.toggle-wrapper > div > div:nth-child(1) > div:nth-child(2)"));
        private IWebElement SelectEquipmentMessage => driver.FindElement(By.CssSelector("#value-manager-body > div > div > p"));
        private IWebElement BaseModelTable => driver.FindElement(By.CssSelector("#base-model-wrapper > div"));
        private IWebElement Graph => driver.FindElement(By.XPath("//*[contains(@class,'recharts-surface')]"));
        private IWebElement BaseDeltaPercentAdjust => driver.FindElement(By.Id("delta-adj"));
        private IWebElement BaseGroupYearAdjust => driver.FindElement(By.XPath("//*[contains(@id,'" + ThreeYearOldModel + "') and (contains(@id,'-pya-input'))]"));
        private IWebElement BaseModelPercentAdjust => driver.FindElement(By.XPath("//*[contains(@id,'model-adj') and (contains(@id,'" + ThreeYearOldModel + "'))]"));
        private IWebElement DisabledBaseModelPercentAdjust => driver.FindElement(By.XPath("//*[contains(@id,'delta-adj') and contains(@input,disabled)]"));
        public static string BaseMSRP, BaseMSRPPercent, BaseNGV, BaseLGV, BasePCV, BaseDeltaLQ, BaseDeltaLY, BaseReportAverage, BaseReportDelta, BaseReportCount;
        public static string CompMSRP, CompMSRPPercent, CompNGV, CompLGV, CompPCV, CompDeltaLQ, CompDeltaLY, CompReportAverage, CompReportDelta, CompReportCount;

        public void ConfirmOnBaseModelValuationPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForElement("XPath","//*[contains(@class,'recharts-surface')]");
            Util.Log("On BMV Tab.");
        }

        public void SelectRegion(string region)
        {
            Region.Click();
            Thread.Sleep(1500);
            RegionInput.SendKeys(region);
            Thread.Sleep(1500);
            FilteredRegion.Click();
            Thread.Sleep(1500);
            Util.Log("Selected Region "+region);
        }

        public void GetMSRP(bool isBase, string year, string model)
        {
            IWebElement MSRP;
            if(isBase)
            {
                MSRP = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Base-MSRP')]/div"));
                BaseMSRP = CleanValue(MSRP.Text);
                Util.Log("BMV MSRP = "+BaseMSRP);
            }
            else
            {
                MSRP = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Comparable-MSRP')]/div"));
                CompMSRP = CleanValue(MSRP.Text);
                Util.Log("BMV MSRP = "+CompMSRP);
            }
        }

        public void GetMSRPPercent(bool isBase, string year, string model)
        {
            IWebElement MSRPPercent;
            if(isBase)
            {
                MSRPPercent = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Base-MSRP%')]/div"));
                BaseMSRPPercent = CleanValue(MSRPPercent.Text);
                Util.Log("BMV MSRP% = "+BaseMSRPPercent);
            }
            else
            {
                MSRPPercent = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Comparable-MSRP%')]/div"));
                CompMSRPPercent = CleanValue(MSRPPercent.Text);
                Util.Log("BMV MSRP% = "+CompMSRPPercent);
            }
        }

        public void GetNewGuideValue(bool isBase, string year, string model)
        {
            IWebElement NGV;
            if(isBase)
            {
                NGV = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Base-NGV')]/div"));
                BaseNGV = CleanValue(NGV.Text);
                Util.Log("BMV NGV = "+BaseNGV);
            }
            else
            {
                NGV = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Comparable-NGV')]/div"));
                CompNGV = CleanValue(NGV.Text);
                Util.Log("BVM NGV = "+CompNGV);
            }
        }

        public void GetLastGuideValue(bool isBase, string year, string model)
        {
            IWebElement LGV;
            if(isBase)
            {
                LGV = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Base-LGV')]/div"));
                BaseLGV = CleanValue(LGV.Text);
                Util.Log("BMV LGV = "+BaseLGV);
            }
            else
            {
                LGV = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Comparable-LGV')]/div"));
                CompLGV = CleanValue(LGV.Text);
                Util.Log("BMV LGV = "+CompLGV);
            }
        }

        public void GetPredictedCashValue(bool isBase, string year, string model)
        {
            IWebElement PCV;
            if(isBase)
            {
                PCV = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Base-PCV')]/div"));
                BasePCV = CleanValue(PCV.Text);
                Util.Log("BMV PCV = "+BasePCV);
            }
            else
            {
                PCV = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Comparable-PCV')]/div"));
                CompPCV = CleanValue(PCV.Text);
                Util.Log("BMV PCV = "+CompPCV);
            }
        }

        public void GetDeltaLastQuarter(bool isBase, string year, string model)
        {
            IWebElement DeltaLQ;
            if(isBase)
            {
                DeltaLQ = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Base-CHGLQ')]/div"));
                BaseDeltaLQ = CleanValue(DeltaLQ.Text);
                Util.Log("BMV ∆%LQ = "+BaseDeltaLQ);
            }
            else
            {
                DeltaLQ = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Comparable-CHGLQ')]/div"));
                CompDeltaLQ = CleanValue(DeltaLQ.Text);
                Util.Log("BMV ∆%LQ = "+CompDeltaLQ);
            }
        }

        public void GetDeltaLastYear(bool isBase, string year, string model)
        {
            IWebElement DeltaLY;
            if(isBase)
            {
                DeltaLY = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Base-CHGLY')]/div"));
                BaseDeltaLY = CleanValue(DeltaLY.Text);
                Util.Log("BMV ∆%LY = "+BaseDeltaLY);
            }
            else
            {
                DeltaLY = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Comparable-CHGLY')]/div"));
                CompDeltaLY = CleanValue(DeltaLY.Text);
                Util.Log("BMV ∆%LY = "+CompDeltaLY);
            }
        }

        public void GetReportAverage(bool isBase, string year, string model)
        {
            IWebElement ReportAvg;
            if(isBase)
            {
                ReportAvg = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Base-AVGPRICE')]/div"));
                BaseReportAverage = CleanValue(ReportAvg.Text);
                Util.Log("BMV ReportAverage = "+BaseReportAverage);
            }
            else
            {
                ReportAvg = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Comparable-AVGPRICE')]/div"));
                CompReportAverage = CleanValue(ReportAvg.Text);
                Util.Log("BMV ReportAverage = "+CompReportAverage);
            }
        }

        public void GetReportDelta(bool isBase, string year, string model)
        {
            IWebElement ReportDelta;
            if(isBase)
            {
                ReportDelta = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Base-RPTCHG')]/div"));
                BaseReportDelta = CleanValue(ReportDelta.Text);
                Util.Log("BMV Report∆% = "+BaseReportDelta);
            }
            else
            {
                ReportDelta = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Comparable-RPTCHG')]/div"));
                CompReportDelta = CleanValue(ReportDelta.Text);
                Util.Log("BMV Report∆% = "+CompReportDelta);
            }
        }

        public void GetReportCount(bool isBase, string year, string model)
        {
            IWebElement ReportCount;
            if(isBase)
            {
                ReportCount = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Base-SRC')]/div"));
                BaseReportCount = CleanValue(ReportCount.Text);
                Util.Log("BMV ReportCount = "+BaseReportCount);
            }
            else
            {
                ReportCount = driver.FindElement(By.XPath("//*[contains(@id,'"+year+"')]//*[text()='"+model+"']/../../td[contains(@class,'Comparable-SRC')]/div"));
                CompReportCount = CleanValue(ReportCount.Text);
                Util.Log("BMV ReportCount = "+CompReportCount);
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

        public void EditBaseModelPercent(string yearRow, string value)
        {
            // select Model % Adjust based on year row
            IWebElement e = driver.FindElement(By.XPath("//*[(contains(@id,'model-adj')) and (contains(@class,'model-adjust-input')) and (contains(@id," + yearRow + "))]"));
            e.Click();
            e.Click();
            e.SendKeys(Keys.Delete);
            e.SendKeys(value);
            e.SendKeys(Keys.Tab);
            Util.Log("Edited Base Model Value.");
        }

        public void EditComparableModelPercent(string yearRow, string value)
        {
            // select Model % Adjust based on year row
            IWebElement e = driver.FindElement(By.XPath("//*[(contains(@id,'model-adj')) and (contains(@class,'model-adjust-input')) and (contains(@id," + yearRow + "))]"));
            e.Click();
            e.Click();
            e.SendKeys(Keys.Delete);
            e.SendKeys(value);
            e.SendKeys(Keys.Tab);
            Util.Log("Edited Comparable Model Value.");
        }

        public void ConfirmBaseDeltaPercentAdjustEditable(bool isEditable)
        {
            if (isEditable)
            {
                try
                {
                    Assert.IsTrue(BaseDeltaPercentAdjust.Displayed);
                    Util.Log("Base∆%Adj Is Editable.");
                }
                catch (Exception ex) { Util.Log(Util.Fail(),"\n Base∆%Adj Is Not Editable." + ex + "\n"); }
            }
        }

        public void Compare_BaseBMV_To_Lineages()
        {// Catch and report any non-matching values - BMV 3yo base model vs Lineages 3yo base model.
            try { Assert.AreEqual(BaseMSRP, LineageValuation.BaseMSRP); }
            catch (Exception ex) { Util.Log("\n BVM MSRP != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseMSRPPercent, LineageValuation.BaseMSRPPercent); }
            catch (Exception ex) { Util.Log("\n BVM MSRPPercent != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseNGV, LineageValuation.BaseNGV); }
            catch (Exception ex) { Util.Log("\n BMV NGV d!= LV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseLGV, LineageValuation.BaseLGV); }
            catch (Exception ex) { Util.Log("\n BMV LGV != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(BasePCV, LineageValuation.BasePCV); }
            catch (Exception ex) { Util.Log("\n BMV PCV != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseDeltaLQ, LineageValuation.BaseDeltaLQ); }
            catch (Exception ex) { Util.Log("\n BMV ∆%LQ != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseDeltaLY, LineageValuation.BaseDeltaLY); }
            catch (Exception ex) { Util.Log("\n BMV ∆%LY != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseReportAverage, LineageValuation.BaseReportAverage); }
            catch (Exception ex) { Util.Log("\n BMV ReportAverage != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseReportDelta, LineageValuation.BaseReportDelta); }
            catch (Exception ex) { Util.Log("\n BMV ReportDelta != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseReportCount, LineageValuation.BaseReportCount); }
            catch (Exception ex) { Util.Log("\n BMV ReportCount != LV \n" + ex + "\n"); }
        }

        public void Compare_BaseBMV_To_RGV()
        {// Catch and report any non-matching values - BMV 3yo base model vs RGV Region D
            try { Assert.AreEqual(BaseMSRP, RegionalValuation.BaseMSRP); }
            catch (Exception ex) { Util.Log("\n BMV MSRP != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseMSRPPercent, RegionalValuation.BaseMSRPPercent); }
            catch (Exception ex) { Util.Log("\n BMV MSRPPercent != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseNGV, RegionalValuation.BaseNGV); }
            catch (Exception ex) { Util.Log("\n BMV NGV != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseLGV, RegionalValuation.BaseLGV); }
            catch (Exception ex) { Util.Log("\n BMV LGV != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseDeltaLQ, RegionalValuation.BaseDeltaLQ); }
            catch (Exception ex) { Util.Log("\n BMV DeltaLQ != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseDeltaLY, RegionalValuation.BaseDeltaLY); }
            catch (Exception ex) { Util.Log("\n BMV DeltaLY != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseReportAverage, RegionalValuation.BaseReportAverage); }
            catch (Exception ex) { Util.Log("\n BMV ReportAverage != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseReportDelta, RegionalValuation.BaseReportDelta); }
            catch (Exception ex) { Util.Log("\n BMV ReportDelta != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(BaseReportCount, RegionalValuation.BaseReportCount); }
            catch (Exception ex) { Util.Log("\n BMV ReportCount != RV \n" + ex + "\n"); }
        }

        public void Compare_CompBMV_To_Lineages()
        {// Catch and report any non-matching values - BMV 3yo base model vs Lineages 3yo base model.

            try { Assert.AreEqual(CompMSRP, LineageValuation.CompMSRP); }
            catch (Exception ex) { Util.Log("\n BMV MSRP != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompMSRPPercent, LineageValuation.CompMSRPPercent); }
            catch (Exception ex) { Util.Log("\n BMV MSRPPercent != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompNGV, LineageValuation.CompNGV); }
            catch (Exception ex) { Util.Log("\n BMV NGVValue != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompLGV, LineageValuation.CompLGV); }
            catch (Exception ex) { Util.Log("\n BMV LGVValue != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompDeltaLQ, LineageValuation.CompDeltaLQ); }
            catch (Exception ex) { Util.Log("\n BMV DeltaLQ != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompDeltaLY, LineageValuation.CompDeltaLY); }
            catch (Exception ex) { Util.Log("\n BMV DeltaLY != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompReportAverage, LineageValuation.CompReportAverage); }
            catch (Exception ex) { Util.Log("\n BMV ReportAverage != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompReportDelta, LineageValuation.CompReportDelta); }
            catch (Exception ex) { Util.Log("\n BMV ReportDelta != LV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompReportCount, LineageValuation.CompReportCount); }
            catch (Exception ex) { Util.Log("\n BMV ReportCount != LV \n" + ex + "\n"); }
        }

        public void Compare_CompBMV_To_RGV()
        {// Catch and report any non-matching values - BMV 3yo base model vs RGV Region D
            try { Assert.AreEqual(CompMSRP, RegionalValuation.CompMSRP); }
            catch (Exception ex) { Util.Log("\n BMV MSRP != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompMSRPPercent, RegionalValuation.CompMSRPPercent); }
            catch (Exception ex) { Util.Log("\n BMV MSRPPercent != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompNGV, RegionalValuation.CompNGV); }
            catch (Exception ex) { Util.Log("\n BMV NGV != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompLGV, RegionalValuation.CompLGV); }
            catch (Exception ex) { Util.Log("\n BMV LGV != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompDeltaLQ, RegionalValuation.CompDeltaLQ); }
            catch (Exception ex) { Util.Log("\n BMV DeltaLQ != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompDeltaLY, RegionalValuation.CompDeltaLY); }
            catch (Exception ex) { Util.Log("\n BMV DeltaLY != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompReportAverage, RegionalValuation.CompReportAverage); }
            catch (Exception ex) { Util.Log("\n BMV ReportAverage != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompReportDelta, RegionalValuation.CompReportDelta); }
            catch (Exception ex) { Util.Log("\n BMV ReportDelta != RV \n" + ex + "\n"); }

            try { Assert.AreEqual(CompReportDelta, RegionalValuation.CompReportCount); }
            catch (Exception ex) { Util.Log("\n BMV ReportCount != RV \n" + ex + "\n"); }
        }
    }
}