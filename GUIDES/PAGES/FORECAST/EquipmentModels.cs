namespace IRONQA.GUIDES.PAGES.FORECAST
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Globalization;
    using System.Threading;
    
    public class EquipmentModels
    {
        private IWebDriver driver;
        public EquipmentModels(IWebDriver _driver) => driver = _driver;
        private IWebElement Year => driver.FindElement(By.CssSelector("#content > div.page--rv--used.page--rv-used-equipment > div.rv-select-container > div.top-spacer.bottom-spacer > div:nth-child(2) > div:nth-child(1) > div > span > span > input"));
        private IWebElement Type => driver.FindElement(By.CssSelector("#content > div.page--rv--used.page--rv-used-equipment > div.rv-select-container > div.top-spacer.bottom-spacer > div:nth-child(2) > div:nth-child(2) > div > span > span > input"));
        private IWebElement Make => driver.FindElement(By.CssSelector("#content > div.page--rv--used.page--rv-used-equipment > div.rv-select-container > div.top-spacer.bottom-spacer > div:nth-child(2) > div:nth-child(3) > div > span > span > input"));
        private IWebElement Model => driver.FindElement(By.CssSelector("#content > div.page--rv--used.page--rv-used-equipment > div.rv-select-container > div.top-spacer.bottom-spacer > div:nth-child(2) > div:nth-child(4) > div > span > span > input"));
        private IWebElement Add => driver.FindElement(By.Id("btnAddModel"));
        private IWebElement Export => driver.FindElement(By.CssSelector("#content > div.page--rv--used.page--rv-used-equipment > div.rv-select-container > div.row > div > button"));
        private IWebElement ClearAll => driver.FindElement(By.CssSelector("#master-row > span:nth-child(12) > button"));
        private IWebElement CalculateIronForecast => driver.FindElement(By.CssSelector("#model-residual-row-85621 > div.row.center-block.model-residual-calculate > div > button.button.success.calculatevalue"));
        private IWebElement ResetPredictors => driver.FindElement(By.CssSelector("#model-residual-row-85621 > div.row.center-block.model-residual-calculate > div > button.button.reset-predictors"));
        private IWebElement ForecastSlider => driver.FindElement(By.CssSelector("#residual-predictors-85542 > div:nth-child(1) > div.slider-item.ui-slider.ui-slider-horizontal.ui-widget.ui-widget-content.ui-corner-all > span"));
        private IWebElement SetTerm => driver.FindElement(By.CssSelector("#residual-predictors-85621 > div:nth-child(1) > div.slider-button.text-center > button"));
        private IWebElement UsedSupplySlider => driver.FindElement(By.CssSelector("#residual-predictors-85621 > div:nth-child(4) > div.slider-item.ui-slider.ui-slider-horizontal.ui-widget.ui-widget-content.ui-corner-all > span:nth-child(1)"));
        private IWebElement MilkSlider => driver.FindElement(By.CssSelector("#residual-predictors-85621 > div:nth-child(7) > div.slider-item.ui-slider.ui-slider-horizontal.ui-widget.ui-widget-content.ui-corner-all > span:nth-child(1)"));
        private IWebElement VolatilitySlider => driver.FindElement(By.CssSelector("#residual-predictors-85621 > div:nth-child(5) > div.slider-item.ui-slider.ui-slider-horizontal.ui-widget.ui-widget-content.ui-corner-all > span"));
        private IWebElement EngineHoursSlider => driver.FindElement(By.CssSelector("#residual-predictors-85621 > div:nth-child(3) > div.slider-item.ui-slider.ui-slider-horizontal.ui-widget.ui-widget-content.ui-corner-all > span:nth-child(1)"));
        private IWebElement BeefSlider => driver.FindElement(By.CssSelector("#residual-predictors-85621 > div:nth-child(6) > div.slider-item.ui-slider.ui-slider-horizontal.ui-widget.ui-widget-content.ui-corner-all > span:nth-child(1)"));
        private IWebElement LocalMarketAdjustmentSlider => driver.FindElement(By.CssSelector("#residual-predictors-85621 > div:nth-child(7) > div.slider-item.ui-slider.ui-slider-horizontal.ui-widget.ui-widget-content.ui-corner-all > span:nth-child(1)"));
        private string Volatility = "#impacts-table > tbody > tr:nth-child(3) > td:nth-child(8)";

        public void ConfirmOnEquipmentModelsPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("ironforecast");
            Util.Log("On Equipment Models Page");
        }

        public void SelectAYear(string year)
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#content > div.page--rv--used.page--rv-used-equipment > div.rv-select-container > div.top-spacer.bottom-spacer > div:nth-child(2) > div:nth-child(1) > div > span > span > input");
            Year.SendKeys(year);
            Year.SendKeys(Keys.Enter);
            Util.Log("Year " + year + " Selected");
        }

        public void SelectAType(string type)
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#content > div.page--rv--used.page--rv-used-equipment > div.rv-select-container > div.top-spacer.bottom-spacer > div:nth-child(2) > div:nth-child(2) > div > span > span > input");
            Type.Click();
            Thread.Sleep(300);
            Type.SendKeys(type);
            Type.SendKeys(Keys.Enter);
            Util.Log("Type " + type + " Selected");
        }

        public void SelectAMake(string make)
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#content > div.page--rv--used.page--rv-used-equipment > div.rv-select-container > div.top-spacer.bottom-spacer > div:nth-child(2) > div:nth-child(3) > div > span > span > input");
            Make.SendKeys(make);
            Make.SendKeys(Keys.Enter);
            Util.Log("Make " + make + " Selected");
        }

        public void SelectAModel(string model)
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#content > div.page--rv--used.page--rv-used-equipment > div.rv-select-container > div.top-spacer.bottom-spacer > div:nth-child(2) > div:nth-child(4) > div > span > span > input");
            Model.SendKeys(model);
            Model.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            Util.Log("Model " + model + " Selected");
        }

        public void ClickAdd()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("Id","btnAddModel");
            Add.Click();
            Thread.Sleep(2000);
            Util.Log("Clicked Add Button");
        }

        public void ConfirmUsedModels()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForClickableElement("CssSelector","#master-row > span:nth-child(12) > button");
            try
            {
                Assert.IsTrue(ClearAll.Displayed);
                Util.Log("Used Models Confirmed");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmModelsCleared()
        {
            try
            {
                Assert.IsFalse(ClearAll.Displayed);
                Util.Log("Used Models Confirmed");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ClickClearAll()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#master-row > span:nth-child(12) > button");
            ClearAll.Click();
            Util.Log("Clicked Clear All.");
        }

        // Increase/Decrease slider by the specified increment
        public void SetSlider(IWebElement slider, int increment, string action)
        {
            for (int i = 0; i <= increment; i++)
            {
                if (action == "increase") { slider.SendKeys(Keys.Right); }
                else { slider.SendKeys(Keys.Left); }
            }
            if (SetTerm.Enabled) ClickSetTerm();
            Util.Log("Set Value for " + slider);
        }

        // Return current table value for the specified column
        public int GetTableValue(IWebElement column)
        {
            return int.Parse(column.Text, NumberStyles.Currency);
        }

        // Check if table value changes after moving slider
        public void ConfirmValueChange(IWebElement slider, string columnSelector, int increment, string action)
        {
            IWebElement column = driver.FindElement(By.CssSelector(columnSelector));
            int initial = GetTableValue(column);
            // Set slider by the specified amount with the specified action ("increase" or "decrease")
            SetSlider(slider, increment, action);
            ClickCalculateIronForecast();
            IWebElement updatedColumn = driver.FindElement(By.CssSelector(columnSelector));
            int final = GetTableValue(updatedColumn);
            // Check if the corresponding table value changed
            try
            {
                Assert.IsTrue(initial != final);
                Util.Log("Confirmed table change for " + slider);
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }

        }

        public void ClickSetTerm()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#residual-predictors-85621 > div:nth-child(1) > div.slider-button.text-center > button");
            SetTerm.Click();
            Util.Log("Clicked Set Term.");
        }

        public void ClickCalculateIronForecast()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#model-residual-row-85621 > div.row.center-block.model-residual-calculate > div > button.button.success.calculatevalue");
            CalculateIronForecast.Click();
            Thread.Sleep(1000);
            Util.Log("Clicked Calculate IronForecast.");
        }

        public void ClickResetPredictors()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#model-residual-row-85621 > div.row.center-block.model-residual-calculate > div > button.button.reset-predictors");
            ResetPredictors.Click();
            Util.Log("Clicked Reset Predictors.");
        }

        public void ConfirmResetPredictors()
        {
            IWebElement column = driver.FindElement(By.CssSelector(Volatility));
            int initial = GetTableValue(column);
            ClickResetPredictors();
            IWebElement updatedColumn = driver.FindElement(By.CssSelector(Volatility));
            int final = GetTableValue(updatedColumn);

            try
            {
                Assert.IsTrue(initial != final);
                Util.Log("Confirmed Reset Predictors.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }
    }
}
