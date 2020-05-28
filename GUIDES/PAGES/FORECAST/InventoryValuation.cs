namespace IRONQA.GUIDES.PAGES.FORECAST
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class InventoryValuation
    {
        private IWebDriver driver;
        public InventoryValuation(IWebDriver _driver) => driver = _driver;
        private IWebElement AdjustPredictors => driver.FindElement(By.XPath("//*[contains(@class,'calculate')]"));
        private IWebElement SelectAll => driver.FindElement(By.CssSelector("#createForecast > div.select-checkbox-wrapper > a:nth-child(1)"));
        private IWebElement SelectNone => driver.FindElement(By.XPath("//*[@id='createForecast']/div[7]/a[2]"));
        private IWebElement FirstCheckbox => driver.FindElement(By.XPath("//div[contains(@id,'InventoryGrid')]/div/table/tbody/tr[2]/td/a/span/i"));
        private IWebElement Checkbox3 => driver.FindElement(By.XPath("//*[@id='InventoryGrid']/div[2]/table/tbody/tr[3]/td[9]/a/span/i"));
        private IWebElement AvailableItem_1 => driver.FindElement(By.CssSelector("#InventoryGrid > div.k-grid-content > table > tbody > tr:nth-child(2) > td:nth-child(9) > a > span > i"));
        private IWebElement LocalMarketSlider => driver.FindElement(By.XPath("//*[contsins(@id,'sliders')]"));
        private IWebElement IUnderstand => driver.FindElement(By.Id("confirm"));
        private IWebElement CalculateIronForecast => driver.FindElement(By.Id("btnCalculateResidualValues"));
        private IWebElement ResetPredictors => driver.FindElement(By.CssSelector("#confirmation > div.row.button-row > span > button.button.reset-predictors"));
        private IWebElement DownloadReport => driver.FindElement(By.CssSelector("#exportOnly > div:nth-child(2) > div > button"));
        private IWebElement ResetInventory => driver.FindElement(By.CssSelector("#content > div.row.page--rv--inventory > div.tabs-content > div.results.treelist > a"));
        private IWebElement GroupInventoryByType => driver.FindElement(By.CssSelector("#resultsInfo > div:nth-child(3) > span > button.group-type.button.secondary.bootstrap-nav-pill.bootstrap-active"));
        private IWebElement GroupInventoryByMake => driver.FindElement(By.CssSelector("#resultsInfo > div:nth-child(3) > span > button.group-make.button.secondary.bootstrap-nav-pill"));
        private IWebElement Export => driver.FindElement(By.CssSelector("#resultsInfo > div:nth-child(3) > span > button.button.export"));
        private IWebElement WaitLoading => driver.FindElement(By.Id("loadingReveal"));
        private IWebElement Combine => driver.FindElement(By.XPath("//*[contains(@type,'checkbox') and contains(@value,'Combine')]"));
        private IWebElement CompactTrackLoader => driver.FindElement(By.XPath("//*[contains(@type,'checkbox') and contains(@value,'Compact')]"));
        private IWebElement CottonPicker => driver.FindElement(By.XPath("//*[contains(@type,'checkbox') and contains(@value,'Cotton')]"));
        private IWebElement ForageHarvester => driver.FindElement(By.XPath("//*[contains(@type,'checkbox') and contains(@value,'Forage')]"));
        private IWebElement SkidSteerLoader => driver.FindElement(By.XPath("//*[contains(@type,'checkbox') and contains(@value,'Skid')]"));
        private IWebElement Sprayer => driver.FindElement(By.XPath("//*[contains(@type,'checkbox') and contains(@value,'Sprayer')]"));
        private IWebElement Tractor => driver.FindElement(By.XPath("//*[contains(@type,'checkbox') and contains(@value,'Tractor')]"));
        private IWebElement Windrower => driver.FindElement(By.XPath("//*[contains(@type,'checkbox') and contains(@value,'Windrower')]"));
        private IWebElement TypeFilter => driver.FindElement(By.XPath("//*[contains(@id,'Type')]/a"));
        private IWebElement ForecastTerm => driver.FindElement(By.CssSelector("#forecastSlider > div:nth-child(1)"));
        private IWebElement AvailableItemCount => driver.FindElement(By.Id("numItemsSelectedSpan"));
        private IWebElement TypeHeader => driver.FindElement(By.XPath("//*[contains(@id,'Type')]"));

        public void ConfirmOnInventoryValuationPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("ironforecast/inventory");
            Util.Log("On Inventory Valuation Page");
        }

        public void ClickAdjustForecastPredictors()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("XPath","//*[contains(@class,'calculate')]");
            AdjustPredictors.Click();
            Util.Log("Clicked Adjst Forecast Predictors Button");
        }

        public void ClickSelectAll()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("XPath","#createForecast > div.select-checkbox-wrapper > a:nth-child(1)");
            SelectAll.Click();
            Util.Log("Clicked Select All Link");
        }

        public void ClickSelectNone()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("XPath","//*[@id='InventoryGrid']/div[2]/table/tbody/tr[2]/td[9]/a");
            SelectNone.Click();
            Thread.Sleep(3000);
            AvailableItemCount.Click();
            Util.Log("Clicked Select None");
        }

        public void ClickCheckbox(int row)
        {// Click Any Inventory Checkbox
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            IWebElement Checkbox;
            if (row == 1) 
            {//Canadian user only has 1 piece of equipment which has different identifier than if multiple are displayed.
                Checkbox = driver.FindElement(By.XPath("//*[@id='InventoryGrid']/div[2]/table/tbody/tr[2]/td[9]/a"));
            }
            else
            {
                Checkbox = driver.FindElement(By.XPath("//*[@id='InventoryGrid']/div[2]/table/tbody/tr[" + row + "]/td[9]/a"));
                util.WaitForClickableElement("XPath","//*[@id='InventoryGrid']/div[2]/table/tbody/tr[" + row + "]/td[9]/a");
            }
            Checkbox.Click();
            Util.Log("Clicked Inventory Checkbox: #" + row);
        }

        public IWebDriver ScrollToIUnderstand()
        {
            /* The IUnderstand checkbox is at the bottom of a div. 
            When scrolled to, it moves just out of view behind the header. 
            This scrolls into view so Selenium can click it. */

            IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
            js.ExecuteScript(@"
                var objDiv = document.getElementById('confirm').scrollHeight += 20;
                window.scrollTo(0, objDiv);
                ");
            Util.Log("Scrolled To I Understand.");
            return driver;
        }

        public void ClickIUnderstand()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("Id","confirm");
            ScrollToIUnderstand();
            IUnderstand.Click();
            Util.Log("Clicked I Understand Checkbox");
        }

        public void ClickCalculateIronForecast()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("Id","btnCalculateResidualValues");
            CalculateIronForecast.Click();
            Util.Log("Clicked Calculate IronForecast Button");
        }

        public void ClickResetPredictors()
        {
            ResetPredictors.Click();
            Util.Log("Clicked Reset Predictors Button");
        }

        public void ClickDownloadReport()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.ScrollTo(DownloadReport);
            DownloadReport.Click();
            Util.Log("Clicked Download Report Button");
        }

        public void ClickResetInventory()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            ResetInventory.Click();
            Util.Log("Clicked Reset Inventory Button");
        }

        public void ClickGroupInventoryByType()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            GroupInventoryByType.Click();
            Util.Log("Clicked Group Inventory By Type Button");
        }

        public void ClickGroupInventoryByMake()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            GroupInventoryByMake.Click();
            Util.Log("Clicked Group Inventory By Make Button");
        }

        public void ClickExport()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#resultsInfo > div:nth-child(3) > span > button.button.export");
            Export.Click();
            Util.Log("Clicked Export Button");
        }

        public enum EquipmentType {Combine, Track, Cotton, Forage, Skid, Sprayer, Tractor, Windrower};

        public void ExpandTypeFilter()
        {   
            TypeHeader.SendKeys(Keys.Tab);
            TypeFilter.Click();
            Thread.Sleep(5000);
            Util.Log("Expanded Equipment Filters.");
        }

        public void FilterEquipmentTypes(EquipmentType type)
        {
            ExpandTypeFilter();
            IWebElement FilterCheckbox = driver.FindElement(By.XPath("//*[contains(@type,'checkbox') and contains(@value,'"+type.ToString()+"')]")); 
            FilterCheckbox.Click();
            Thread.Sleep(5000);
            Util.Log("Filtered Equipment for "+type);
        }

        public void SelectEquipment()
        {
            FirstCheckbox.Click();
            Util.Log("Selected the first piece of equipment.");
        }

        public void SetOneMonthForecastTerm()
        {
            ForecastTerm.SendKeys(Keys.ArrowLeft);
            ForecastTerm.SendKeys(Keys.ArrowLeft);
            ForecastTerm.SendKeys(Keys.ArrowLeft);
            ForecastTerm.SendKeys(Keys.ArrowLeft);
            ForecastTerm.SendKeys(Keys.ArrowLeft);
            ForecastTerm.SendKeys(Keys.ArrowLeft);
            ForecastTerm.SendKeys(Keys.ArrowLeft);
        }
    }
}
