namespace IRONQA.GDM.PAGES.VALUESMGR
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class VMNav
    {
        private IWebDriver driver;
        public VMNav(IWebDriver _driver) => driver = _driver;
        private IWebElement EquipmentType => driver.FindElement(By.XPath("//*[contains(@id,'react-select-equipment-type--value')]/div"));
        private IWebElement EquipmentTypeInput => driver.FindElement(By.XPath("//*[contains(@class,'Select-input')]/input [(contains(@aria-activedescendant,'react-select-equipment-type'))]"));
        private IWebElement ValuationGroup => driver.FindElement(By.XPath("//*[contains(@id,'react-select-valuation-group--value')]"));
        private IWebElement ValuationGroupInput => driver.FindElement(By.XPath("//*[contains(@class,'Select-input')]/input [(contains(@aria-activedescendant,'react-select-valuation-group'))]"));
        private IWebElement ValuationGroupSettings => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(1) > div > div:nth-child(5) > div > div.tooltip-wrapper > em"));
        private IWebElement SettingsX => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(1) > div > div:nth-child(5) > div > div.prompt-modal > em"));
        private IWebElement SelectedValuationGroup => driver.FindElement(By.CssSelector("#valuation-group-settings > h6"));
        private IWebElement SelectedGroupStatus => driver.FindElement(By.CssSelector("#valuation-group-settings > div > select"));
        private IWebElement ResetAllValues => driver.FindElement(By.CssSelector("#valuation-group-settings > button"));
        private IWebElement ExceptionsButton => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(2) > div > ul > li:nth-child(1) > a"));
        private IWebElement BaseModelValuation => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(2) > div > ul > li:nth-child(2) > a"));
        private IWebElement LineageValuation => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(2) > div > ul > li:nth-child(3) > a"));
        private IWebElement RegionalValuation => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(2) > div > ul > li:nth-child(4) > a"));
        private IWebElement GuideValidation => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(2) > div > ul > li:nth-child(5) > a"));
        private IWebElement GuideIndustry => driver.FindElement(By.XPath("//*[contains(@id,'react-select-guide-industry--value')]"));
        private IWebElement GuidesIndustryInput => driver.FindElement(By.XPath("//*[contains(@class,'Select-input')]/input [(contains(@aria-activedescendant,'react-select-guide-industry'))]"));
        private IWebElement GuideIssue => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(1) > div > div:nth-child(3) > div > div > div > span"));
        private IWebElement GuideIssueInput => driver.FindElement(By.XPath("//*[contains(@class,'Select-input')]/input [(contains(@aria-activedescendant,'react-select-guide-issue'))]"));
        private IWebElement SettingsSlider => driver.FindElement(By.CssSelector("#ValueManager > div:nth-child(1) > div > div:nth-child(3) > div > div.tooltip-wrapper > i"));
        private IWebElement EditingRules => driver.FindElement(By.CssSelector("#valuation-group-settings > div.toggle-wrapper > div > div > div:nth-child(2) > div"));

        public void ConfirmValuesManager()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            try
            {
                Assert.IsTrue(driver.Url.Contains("/GuidesValueCalculator/GuidesValue"));
                Util.Log("On Values Manager Page.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public enum GuideIndustries { Agricultural, Construction, Outdoor, BuyersGuide};

        public void SelectGuideIndustry(GuideIndustries industry)
        {
            string i = industry.ToString();
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'react-select-guide-industry--value')]");
            GuidesIndustryInput.SendKeys(i);
            GuidesIndustryInput.SendKeys(Keys.Tab);
            Util.Log("Selected Guide Industry: " + industry);
        }

        public void SelectGuideIssue(string seasonYear)
        {
            Thread.Sleep(1500);
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'react-select-guide-issue--value')]/div[2]");
            GuideIssue.Click();
            Thread.Sleep(250);
            GuideIssueInput.SendKeys(seasonYear);
            Thread.Sleep(500);
            GuideIssueInput.SendKeys(Keys.Tab);
            Util.Log("Selected Guide Issue: " + seasonYear);
        }

        public enum EquipmentTypes { Round, Square, Combine, Cotton, Forage, Header, Mower, Skid, Sprayer, Track, Tractor, Windrower, Dozer, Excavator, Backhoe, Wheel };

        public enum ValuationGroups { Class1, Class2, Class3, Class4, Class5, SQUARE, BIGSQUARE, PULLTYPE, SELFPROPEL, Class6, Class7, Class8, Class9, Class10, Picker, Stripper, SP1, SP2, SP3, SP4, SP5, Corn, Flex, Pickup, RICE, Rigid, FlexDraper, RigidDraper, Disc, DiscMulti, SICKLE, HICAP, LOCAP, FOURWD, RowCropMd, RowCropSm, TRACK4wd, TRACKRowCrop, Compact0_24, Compact25Plus, RowCropLg0_209, RowCropLg210Plus, Utility0_59, Utility60_79, Utility80Plus };
        
        public void SelectEquipmentType(EquipmentTypes equipmentType)
        {
            string type = equipmentType.ToString();
            Thread.Sleep(1500); //must wait for 
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'react-select-equipment-type--value')]/div");
            EquipmentType.Click();
            Thread.Sleep(500);
            EquipmentTypeInput.SendKeys(type);
            Thread.Sleep(500);
            EquipmentTypeInput.SendKeys(Keys.Tab);
            Util.Log("Selected Equipment Type: " + type);
        }

        public void SelectValuationGroup(string group)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'react-select-valuation-group--value')]");
            ValuationGroup.Click();
            Thread.Sleep(500);
            ValuationGroupInput.SendKeys(group);
            Thread.Sleep(500);
            ValuationGroupInput.SendKeys(Keys.Tab);
            Util.Log("Selected Valuation Group: " + group);
        }

        public void ConfirmLineage(EquipmentTypes type, string region) 
        {//Cycle through all Valuation Groups for the passed in Equipment Type
            string t = type.ToString();
            VMNav nav = new VMNav(driver);
            LineageValuation lv;

            switch (t)
            {//Open each Valuation Group and confirm lineage data is displayed
                case "Round":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("Class 1");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 2");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 3");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 4");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 5");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Square":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("SQUARE");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("BIG SQUARE");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Combine":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("PULLTYPE");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SELFPROPEL");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 10");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 4");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 5");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 6");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 7");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 8");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 9");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Cotton":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("Picker");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Stripper");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Forage":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("PULLTYPE");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SP1");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SP2");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SP3");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SP4");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SP5");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Header":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("Corn");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Flex");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Pickup");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("RICE");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Rigid");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Flex Draper");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Rigid Draper");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Mower":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("Disc");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("DiscMulti");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SICKLE");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Skid":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("Class 1");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 2");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 3");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 4");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 5");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Sprayer":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("HICAP");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("LOCAP");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Track":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("Class 2");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 3");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 4");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 5");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Tractor":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("4WD");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("RowCropMd");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("RowCropSm");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("TRACK4wd");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("TRACKRowCrop");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Compact 0");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Compact 25");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("RowCropLg 0");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("RowCropLg 210");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Utility 0");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Utility 60");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Utility 80");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Windrower":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("PULLTYPE");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SELFPROPEL");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SP1");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SP2");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SP3");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SP4");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("SP5");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Dozer":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("Class 1");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 2");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 3");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 4");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 5");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Excavator":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("Class 1");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 2");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 3");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 4");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 5");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 6");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Backhoe":
                    nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("Class 1");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 2");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("Class 3");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
                case "Wheel":
                nav.SelectEquipmentType(type);
                    nav.SelectValuationGroup("WLClass1A");
                    lv = nav.ClickLineageValuation();
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass1B");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass1C");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass1D");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass2A");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass2B");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass2C");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass2D");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass3A");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass3B");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass3C");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass3D");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass4");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass5A");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    nav.SelectValuationGroup("WLClass5B");
                    lv.SelectRegion(region);
                    lv.ConfirmLineageDataDisplayed();
                    break;
            }
        }

        public void ClickValuationGroupSettings()
        {
            ValuationGroupSettings.Click();
            Util.Log("Clicked Valuation Group Settings Button.");
        }

        public void CloseValuationGroupSettings()
        {
            SettingsX.Click();
            Util.Log("Valuation Group Settings Window Closed.");
        }

        public enum GroupStatus { NotStarted, OnHold, Complete, Approved };

        public void ToggleEditingRules()
        {
            Thread.Sleep(500);
            EditingRules.Click();
            Util.Log("Toggled Editing Rules.");
        }

        public Exceptions ClickExceptions()
        {
            ExceptionsButton.Click();
            Util.Log("Clicked Exceptions.");
            return new Exceptions(driver);
        }

        public BaseModelValuation ClickBaseModelValuation()
        {
            BaseModelValuation.Click();
            Util.Log("Clicked Base Model Valuation");
            return new BaseModelValuation(driver);
        }

        public LineageValuation ClickLineageValuation()
        {
            Thread.Sleep(500);
            LineageValuation.Click();
            Util.Log("Clicked Lineage Valuation");
            return new LineageValuation(driver);
        }

        public RegionalValuation ClickRegionalValuation()
        {
            Thread.Sleep(250);
            RegionalValuation.Click();
            Util.Log("Clicked Regional Valuation");
            return new RegionalValuation(driver);
        }

        public GuideValidation ClickGuideValidation()
        {
            GuideValidation.Click();
            Util.Log("Clicked Regional Validation");
            return new GuideValidation(driver);
        }
    }
}