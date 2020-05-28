namespace IRONQA.GUIDES.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class Step2
    {
        private IWebDriver driver;
        public Step2(IWebDriver _driver) => driver = _driver;
        private IWebElement PriceTable => driver.FindElement(By.XPath("//*[contains(@class,'price-table') and contains(@class, 'iron-guides')]"));
        private string WholesaleText => driver.FindElement(By.Id("value--wholesale")).Text;
        private string WholesaleAdjustedTotal => driver.FindElement(By.Id("value--wholesale-tot")).Text;
        private string TradeRoughText => driver.FindElement(By.Id("value--traderough")).Text;
        private string TradeRoughAdjustedTotal => driver.FindElement(By.Id("value--traderough-tot")).Text;
        private string TradePremiumText => driver.FindElement(By.Id("value--premium")).Text;
        private string TradePremiumAdjustedTotal => driver.FindElement(By.Id("value--premium-tot")).Text;
        private string ResaleCashText => driver.FindElement(By.Id("value--resale")).Text;
        private string ResaleCashAdjustedTotal => driver.FindElement(By.Id("value--resale-tot")).Text;
        private string AdvertisedText => driver.FindElement(By.Id("value--advertised")).Text;
        private string AdvertisedAdjustedTotal => driver.FindElement(By.Id("value--advertised")).Text;
        private IWebElement AppraiserTable => driver.FindElement(By.XPath("//*[contains(@class,'price-table') and contains(@class, 'iron-appraiser')]"));
        private string AppraiserTradeText => driver.FindElement(By.XPath("//*[contains(@class,'total-value-trade')]")).Text;
        private string AppraiserBuyText => driver.FindElement(By.XPath("//*[contains(@class,'total-value-buy')]")).Text;
        private IWebElement AppraisalTable => driver.FindElement(By.XPath("//*[contains(@class,'appraisal-worksheet')]"));
        private IWebElement SelectedOptions => driver.FindElement(By.Id("panel2d-label"));
        private IWebElement FirstOption => driver.FindElement(By.Id("option--check-0"));
        private IWebElement MyOptions => driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div/div[2]/main/div/div/div[2]/div[4]/section[4]/ul/li/a"));
        private IWebElement CustomOptionInput => driver.FindElement(By.Id("custom--option-new"));
        private IWebElement AddOption => driver.FindElement(By.Id("custom--option-button-add"));
        private IWebElement CustomOptionValue => driver.FindElement(By.Id("custom--option-value-1"));
        private IWebElement CashSellingPrice => driver.FindElement(By.Id("cash--expect-adj-value-input"));
        private IWebElement DealershipMargin => driver.FindElement(By.Id("cash--dealer-marg-percent-input"));
        private IWebElement Reconditioning => driver.FindElement(By.Id("cash--recond-value-input"));
        private IWebElement DeliveryAllowance => driver.FindElement(By.Id("cash--delivery-input"));
        private IWebElement OtherReserve => driver.FindElement(By.Id("cash--other-value-input"));
        private IWebElement MarketForecast => driver.FindElement(By.XPath("//div[@id='typeahead__forecast--term-select']//input"));
        private IWebElement IronResaleCashForecast => driver.FindElement(By.Id("forecast--iron-cash-selling"));
        private IWebElement IronWholesaleForecast => driver.FindElement(By.Id("forecast--iron-wholesale"));
        private IWebElement ForecastMargin => driver.FindElement(By.Id("forecast--forecast-margin-value"));
        private IWebElement MyNetTradeIn => driver.FindElement(By.Id("forecast--iron-net-tradein"));
        private IWebElement CheckComparables => driver.FindElement(By.Id("link--check-comp"));
        private IWebElement SaveDownload => driver.FindElement(By.ClassName("link--save-and-download-appraisal"));
        private IWebElement BaseValueLabel => driver.FindElement(By.Id("base--title"));
        private IWebElement VariableUsageText => driver.FindElement(By.XPath("//div[@id='usage--adjust']//p[contains(text(),'Variable')]"));
        private IWebElement CustomAdjustmentCheckbox => driver.FindElement(By.Id("has-custom-adjustment"));
        private IWebElement CustomUsageInput => driver.FindElement(By.Id("usage--adjust-user-per-unit"));
        private IWebElement UsageAdjustTotal => driver.FindElement(By.Id("usage--adjust-total"));
        private IWebElement UserEnteredUsage => driver.FindElement(By.Id("usage--adjust-avg-unit"));
        private IWebElement UserEnteredUsageInput => driver.FindElement(By.Id("usage--adjust-user-units"));
        private IWebElement CopyToInventory => driver.FindElement(By.Id("button--copy-to-my-equipment"));

        public void ConfirmOnStep2()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'reveal') and not(contains(@style,'display: block; top: -100px'))]");
            Util.Log("On Step 2");
        }

        public void ConfirmIronBaseValues()
        {
            try
            {
                Assert.IsTrue(PriceTable.Displayed);           //Util.Log("PriceTable Displayed");
                Assert.IsTrue(WholesaleText.Length>0);         //Util.Log("BaseWholesaleValue Displayed");
                Assert.IsTrue(TradeRoughText.Length>0);        //Util.Log("BaseTradeRoughValue Displayed");
                Assert.IsTrue(TradePremiumText.Length>0);      //Util.Log("BaseTradePremiumValue Displayed");
                Assert.IsTrue(ResaleCashText.Length>0);        //Util.Log("BaseResaleCashValue Displayed");
                Assert.IsTrue(AdvertisedText.Length>0);        //Util.Log("BaseAdvertisedValue Displayed");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
            Util.Log("Confirmed Iron Base Values Table.");
        }

        public void ConfirmAdjustedTotals()
        {
            try
            {
                Assert.IsTrue(PriceTable.Displayed);                    //Util.Log("PriceTable Displayed");
                Assert.IsTrue(WholesaleAdjustedTotal.Length>0);         //Util.Log("BaseWholesaleTotal Displayed");
                Assert.IsTrue(TradeRoughAdjustedTotal.Length>0);        //Util.Log("BaseTradeRoughTotal Displayed");
                Assert.IsTrue(TradePremiumAdjustedTotal.Length>0);      //Util.Log("BaseTradePremiumTotal Displayed");
                Assert.IsTrue(ResaleCashAdjustedTotal.Length>0);        //Util.Log("BaseResaleCashTotal Displayed");
                Assert.IsTrue(AdvertisedAdjustedTotal.Length>0);        //Util.Log("BaseAdvertisedTotal Displayed");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmIronAppraiserValues()
        {
            try
            {
                Assert.IsTrue(AppraiserTable.Displayed);
                Assert.IsTrue(AppraiserTradeText.Length>0);
                Assert.IsTrue(AppraiserBuyText.Length>0);
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
            Util.Log("Confirmed Iron Appraiser Values Table.");
        }

        public Step3 ClickCheckComparables()
        {
            CheckComparables.Click();
            Util.Log("Clicked Check Comparables.");
            return new Step3(driver);
        }

        public void ClickSaveDownload()
        {
            SaveDownload.Click();
            Util.Log("Clicked Save Download Button.");
        }

        public void ToggleSelectedOptions()
        {
            Util util = new Util(driver);
            util.ScrollTo(BaseValueLabel);
            Thread.Sleep(500);
            SelectedOptions.Click();
            Util.Log("Toggled Selected Options");
        }

        public void SelectOption()
        {// select the first option
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[@id='option--check-0']");
            IWebElement e = driver.FindElement(By.XPath("//*[@id='option--check-0']"));
            e.Click();
            Util.Log("Selected Option.");
        }

        public void ToggleMyOptions()
        {
            Util util = new Util(driver);
            util.ScrollTo(BaseValueLabel);
            Thread.Sleep(1000);
            MyOptions.Click();
            Util.Log("Toggled My Options.");
        }

        public void EnterNewCustomOption(string option)
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","custom--option-new");
            CustomOptionInput.SendKeys(option);
            Thread.Sleep(1000);
            Util.Log("Entered Option: "+option);
        }

        public void ClickAddOption()
        {
            AddOption.Click();
            Thread.Sleep(1000);
            Util.Log("Clicked Add Option Button.");
        }

        public void EnterCustomOptionValue(string value)
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("Id","custom--option-value-1");
            CustomOptionValue.SendKeys(value);
            Util.Log("Entered Option Value.");
        }

        public void EnterCashSellingPriceAdj(string value)
        {
            CashSellingPrice.SendKeys(value);
            Util.Log("Entered Cash Selling Price.");
        }

        public void EnterDealershipMargin(string value)
        {
            DealershipMargin.SendKeys(value);
            Util.Log("Entered Dealership Margin.");
        }

        public void EnterReconditioning(string value)
        {
            Reconditioning.SendKeys(value);
            Util.Log("Entered Reconditioning.");
        }

        public void EnterDeliveryAllowance(string value)
        {
            DeliveryAllowance.SendKeys(value);
            Util.Log("Entered Delivery Allowance.");
        }

        public void EnterOtherReserve(string value)
        {
            OtherReserve.SendKeys(value);
            Util.Log("Entered Other Reserve");
        }

        public void ClickMarketForecast()
        {// Expand the Market Forecast Dropdown
            MarketForecast.Click();
            Util.Log("Expanded Market Forecast.");
        }

        public void SelectMarketForecast(string number)
        {// Select a Forecast Term
            ClickMarketForecast();
            MarketForecast.SendKeys(number);
            MarketForecast.SendKeys(Keys.Tab);
            Util.Log("Selected Market Forecast.");
        }

        public void ConfirmMarketForecast()
        {
            SelectMarketForecast("4");
            Util.Log("Iron ResaleCashForecast:" + IronResaleCashForecast.Text);
            Util.Log("Iron Wholesale Forecast:" + IronWholesaleForecast.Text);
            Util.Log("Confirmed Market Forecast.");
        }

        public void ClickCopyToInventory()
        {// Send Appraised equipment to Inventory for Approval
            CopyToInventory.Click();
            Util.Log("Clicked Copy To Inventory.");
        }

        public void ConfirmVariableUsage()
        {// Confirm Variable Usage-Dependant Rate is displayed by default
            Assert.IsTrue(VariableUsageText.Displayed);
            Util.Log("Variable Usage Displayed by Default.");
        }

        public void ClickCustomAdjustmentCheckbox()
        {// select the checkbox for entering custom adjustments
            CustomAdjustmentCheckbox.Click();
            Util.Log("Clicked Custom Adjustment Checkbox.");
        }

        public void EnterCustomAdjustment(string number)
        {// Provide a custom per hour adjustment
            Thread.Sleep(1000);
            // Clear contents of input
            int count = 4;
            for (int i=0; i<count; i++)
            {
                CustomUsageInput.SendKeys(Keys.Backspace);
            }
            CustomUsageInput.SendKeys(number);
            Thread.Sleep(1000);
            CustomUsageInput.SendKeys(Keys.Tab);
            Util.Log("Entered Custom Adjustment");
        }

        public void AdjustUserEnteredUsage(int number)
        {// Increase or Decrease User Entered Usage by a certain amount
            // Get intial value
            int usage = Int32.Parse(UserEnteredUsage.Text);
            // Add number to intial value
            string newVal = (usage+number).ToString();
            // Clear contents of input
            int count = UserEnteredUsage.Text.Length;
            for (int i=0; i<count; i++)
            {
                UserEnteredUsageInput.SendKeys(Keys.Backspace);
            }
            // Provide new usage to input
            UserEnteredUsageInput.SendKeys(newVal);
            UserEnteredUsageInput.SendKeys(Keys.Tab);
        }

        public void ConfirmCustomAdjustCalculation()
        {// Ensure Custom Adjustment is calculating properly
            AdjustUserEnteredUsage(1);
            ClickCustomAdjustmentCheckbox();
            EnterCustomAdjustment("42");
            Thread.Sleep(5000);
            string total = UsageAdjustTotal.Text;
            Assert.IsTrue(total.Equals("42"));
            Util.Log("Confirmed Custom Adjustment Calculation");
        }
    }
}