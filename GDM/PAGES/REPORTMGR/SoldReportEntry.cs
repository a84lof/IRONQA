namespace IRONQA.GDM.PAGES.REPORTMGR
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;
    using System.Threading;
    
    public class SoldReportEntry
    {
        private IWebDriver driver;
        public SoldReportEntry(IWebDriver _driver) => driver = _driver;
        private IWebElement TransactionType => driver.FindElement(By.Id("transactionTypeSelector"));
        private IWebElement ReportSource => driver.FindElement(By.Id("ReportSourceSelector"));
        private IWebElement ReportDate => driver.FindElement(By.Id("ReportDateSelector"));
        private IWebElement Dealership => driver.FindElement(By.Id("dealerList"));
        private IWebElement ReportIndustry => driver.FindElement(By.Id("reportIndustrySelector"));
        private IWebElement Type => driver.FindElement(By.Id("typeList"));
        private IWebElement Make => driver.FindElement(By.Id("makeList"));
        private IWebElement Model => driver.FindElement(By.Id("modelList"));
        private IWebElement DealerReportedYear => driver.FindElement(By.Id("DealerReportedYearSelector"));
        private IWebElement EditorReportedYear => driver.FindElement(By.Id("ProductYearSelector"));
        private IWebElement SerialNumber => driver.FindElement(By.Id("SerialNumberSelector"));
        private IWebElement OptionDescription => driver.FindElement(By.Id("OptionPrintDescriptionSelector"));
        private IWebElement Metric => driver.FindElement(By.CssSelector("#productYearDiv > div:nth-child(10) > label > div > div:nth-child(1) > input[type='radio']"));
        private IWebElement USStandard => driver.FindElement(By.CssSelector("#productYearDiv > div:nth-child(10) > label > div > div:nth-child(2) > input[type='radio']"));
        private IWebElement EngHours => driver.FindElement(By.Id("meterValues-HOURS"));
        private IWebElement EngPower => driver.FindElement(By.Id("sizeValues-HP/ENG"));
        private IWebElement BucketWidthInInches => driver.FindElement(By.Id("sizeValues-BUIN"));
        private IWebElement BucketCapCuFt => driver.FindElement(By.Id("sizeValues-CAPCF"));
        private IWebElement RatedOperatingLoad => driver.FindElement(By.Id("sizeValues-ROL"));
        private IWebElement HydraulicFlowRate => driver.FindElement(By.Id("sizeValues-CAPGPM"));
        private IWebElement PTOPower => driver.FindElement(By.Id("sizeValues-HP/PTO"));
        private IWebElement DBRPower => driver.FindElement(By.Id("sizeValues-HP/DBR"));
        private IWebElement SeparatorHours => driver.FindElement(By.Id("meterValues-Sephr"));
        private IWebElement AcreMeter => driver.FindElement(By.Id("meterValues-ACRES"));
        private IWebElement ChopperHours => driver.FindElement(By.Id("meterValues-CHPHR"));
        private IWebElement EngineHP => driver.FindElement(By.Id("sizeValues-HP/ENG"));
        private IWebElement Bushels => driver.FindElement(By.Id("sizeValues-BUSHEL"));
        private IWebElement DataEntryNotes => driver.FindElement(By.Id("DataEntryNotesSelector"));
        private IWebElement CashPrice => driver.FindElement(By.Id("CashPriceSelector"));
        private IWebElement AdvertisedPrice => driver.FindElement(By.Id("AdvertisedPriceSelector"));
        private IWebElement Currency => driver.FindElement(By.CssSelector("#equipmentValueDiv > div.report-column-wrapper > div.values-wrapper > div:nth-child(6) > div:nth-child(2) > label > span.k-widget.k-dropdown.k-header > span > span.k-input"));
        private IWebElement ConditionArrow => driver.FindElement(By.CssSelector("#equipmentValueDiv > div.report-column-wrapper > div.conditionReconditioningWrapper > div > div:nth-child(1) > label > span.k-widget.k-dropdown.k-header.Clearable > span > span.k-input"));
        private IWebElement Condition => driver.FindElement(By.CssSelector("#ConditionSelector-list>div:nth-child(2)>ul>li:nth-child(9)"));
        private IWebElement Reconditioning => driver.FindElement(By.Id("ReconditionSelector"));
        private IWebElement ManuallyEnteredOptions => driver.FindElement(By.CssSelector("#panelCustomOptions-label > div > div"));
        private IWebElement ManualOptionDescription => driver.FindElement(By.Id("customOptionsAddDesc"));
        private IWebElement ManualOptionValue => driver.FindElement(By.Id("customOptionsAddValue"));
        private IWebElement Add => driver.FindElement(By.Id("customOptionsAdd"));
        private IWebElement GrabLatestData => driver.FindElement(By.Id("clearLocalData"));
        private IWebElement Save => driver.FindElement(By.Id("saveSoldReportData"));
        private IWebElement Clear => driver.FindElement(By.Id("clearSoldReport"));
        private IWebElement TradeGuideOptions => driver.FindElement(By.CssSelector("#panelGuideOptions-label > div > div > span"));
        private IWebElement LoadingErrorAlerts => driver.FindElement(By.CssSelector("#notification-error > button"));

        public void ConfirmOnReportEntryPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'hover-gear')and(contains(@style,'display: none;'))]"); 
            util.WaitForURL("/ReportEntry/SoldReport/Create");
            Util.Log("On Report Entry Page.");
        }

        public void ConfirmOnReportEditPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'hover-gear')and(contains(@style,'display: none;'))]");
            util.WaitForURL("/Edit?reportId=");
            Util.Log("On Edit Reports Page.");
        }

        public void DismissLoadingErrors()
        {
            try
            {
                LoadingErrorAlerts.Click();
                Thread.Sleep(1200);
                Util.Log("Dismissed Loding Error(s).");
            }
            catch (Exception ex) { Util.Log("No Loading Errors." + "\r\n" + ex); }
        }

        public void RefreshPage()
        {
            driver.Navigate().Refresh();
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'hover-gear')and(contains(@style,'display: none;'))]");
            Util.Log("Refreshed The Page.");
        }

        public void EnterReportSource(string source)
        {
            ReportSource.SendKeys(source);
            ReportSource.SendKeys(Keys.Tab);
            Util.Log("Selected a report source");
        }

        public void EnterDealership(string dealership)
        {
            Dealership.SendKeys(dealership);
            Dealership.SendKeys(Keys.Tab);
            Util.Log("Entered Dealership");
        }

        public void EnterReportIndustry(string industry)
        {
            ReportIndustry.SendKeys(industry);
            ReportIndustry.SendKeys(Keys.Tab);
            Util.Log("Selected Ag Equipment");
        }

        public void EnterType(string type)
        {
            Type.Click();
            Type.SendKeys(type);
            Type.SendKeys(Keys.Tab);
            Util.Log("Entered a Type");
        }

        public void EnterMake(string make)
        {
            Make.SendKeys(make);
            Make.SendKeys(Keys.Tab);
            Util.Log("Entered Make");
        }

        public void EnterModel(string model)
        {
            Model.SendKeys(model);
            Model.SendKeys(Keys.Tab);
            Util.Log("Entered Model.");
        }

        public void EnterDealerReportedYear(string year)
        {
            DealerReportedYear.SendKeys(year);
            DealerReportedYear.SendKeys(Keys.Tab);
            Util.Log("Entered Dealer Reported Year.");
        }

        public void EnterEditorEstimatedYear(string year)
        {   Thread.Sleep(250);
            IWebElement element = driver.FindElement(By.XPath("//ul[@id='ProductYearSelector_listbox']//div/span[contains(text(),'"+year+"')]/../.."));
            element.Click();
            DealerReportedYear.SendKeys(Keys.Tab);
            Util.Log("Entered Dealer Reported Year.");
        }

        public void EnterSerialNumber(string serial)
        {
            SerialNumber.SendKeys(serial);
            SerialNumber.SendKeys(Keys.Tab);
            Util.Log("Entered a Serial Number");
        }

        public void EnterSeparatorHours(string hours)
        {
            SeparatorHours.SendKeys(hours);
            SeparatorHours.SendKeys(Keys.Tab);
            Util.Log("Entered Separator Hours.");
        }

        public void EnterAcreMeter(string acres)
        {
            AcreMeter.SendKeys(acres);
            AcreMeter.SendKeys(Keys.Tab);
            Util.Log("Entered Acre Meters.");
        }

        public void EnterChopperHours(string hours)
        {
            ChopperHours.SendKeys(hours);
            ChopperHours.SendKeys(Keys.Tab);
            Util.Log("Entered Chopper Hours.");
        }

        public void EnterDataEntryNotes(string text)
        {
            DataEntryNotes.SendKeys(text);
            Util.Log("Entered Data Entry Notes.");
        }

        public void EnterEngineHours(string hrs)
        {
            EngHours.Click();
            EngHours.SendKeys(hrs);
            EngHours.SendKeys(Keys.Tab);
            Util.Log("Entered Engine Hours");
        }

        public void EnterEngineHP(string horsepower)
        {
            EngPower.SendKeys(Util.GetRandomNumber(4));
            EngPower.SendKeys(Keys.Tab);
            Util.Log("Entered Engine power");
        }

        public void EnterBucketWidthInInches(string text)
        {
            BucketWidthInInches.SendKeys(text);
            BucketWidthInInches.SendKeys(Keys.Tab);
        }

        public void EnterBushels(string bushels)
        {
            Bushels.SendKeys(bushels);
            Bushels.SendKeys(Keys.Tab);
            Util.Log("Entered Bushels.");
        }

        public void EnterPTOPower(string power)
        {
            PTOPower.SendKeys(power);
            PTOPower.SendKeys(Keys.Tab);
            Util.Log("Entered PTO power");
        }

        public void EnterDBRPower(string power)
        {
            DBRPower.SendKeys(power);
            DBRPower.SendKeys(Keys.Tab);
            Util.Log("Entered DBR Power");
        }

        public void EnterCashPrice(string price)
        {
            CashPrice.SendKeys(price);
            CashPrice.SendKeys(Keys.Tab);
            Util.Log("Entered Cash Price");
        }
       
        public void EnterAdvertisedPrice(string price)
        {
            AdvertisedPrice.SendKeys(price);
            AdvertisedPrice.SendKeys(Keys.Tab);
            Util.Log("Entered Advertised Price");
        }

        public void EnterCurrency(string currency)
        {
            Currency.Click();
            Currency.SendKeys(currency);
            Currency.SendKeys(Keys.Tab);
            Util.Log("Entered Currency.");
        }

        public void EnterCondition(string number)
        {
            Condition.Click();
            Condition.SendKeys(number);
            Condition.SendKeys(Keys.Tab);
            Util.Log("Selected a Condition");
        }

        public void EnterReconditioningCost(string value)
        {
            Reconditioning.Click();
            Reconditioning.SendKeys(value);
            Reconditioning.SendKeys(Keys.Tab);
            Util.Log("Entered Reconditioning amount");
        }

        public void SaveSoldReport()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","saveSoldReportData");
            Save.Click();
            Util.Log("Clicked Save");
        }

        public void ConfirmSaveSuccess()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@class,'notification-message')]");
            Util.Log("Report Saved Successfully.");
        }

        public void FollowReportSavedLink()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='notification-area']/div/div/p/a"));
            element.Click();
            Util.Log("Clicked Saved Report Link.");
        }

        public void ConfirmEditSuccess()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@class,'notification-message')]");
            Util.Log("Report Edited Successfully.");
        }
        

        public void ExpandManualOptions()
        {
            ManuallyEnteredOptions.Click();
            Util.Log("Expanded Manual Options.");
        }

        public void EnterManualOptionDescription(string description)
        {
            ManualOptionDescription.SendKeys(description);
            ManualOptionDescription.SendKeys(Keys.Tab);
            Util.Log("Entered Manual Option Description.");
        }

        public void EnterManualOptionValue(string value)
        {
            ManualOptionValue.SendKeys(value);
            ManualOptionValue.SendKeys(Keys.Tab);
            Util.Log("Entered Manual Option Value.");
        }
        
        public void SubmitManuallyEnteredOption()
        {
            Add.Click();
            Util.Log("Added Manually Entered Option.");
        }

        
    }
}