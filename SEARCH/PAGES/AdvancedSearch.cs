namespace IRONQA.SEARCH.PAGES
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    public class AdvancedSearch
    {
        private IWebDriver driver;
        public AdvancedSearch(IWebDriver _driver) => driver = _driver;
        private IWebElement ActiveUsedTab => driver.FindElement(By.XPath("//*[contains(@id,'used-tab')and(contains(@class,'is-active'))]"));
        private IWebElement ActiveNewTab => driver.FindElement(By.XPath("//*[contains(@id,'new-tab')and(contains(@class,'is-active'))]"));
        private IWebElement ActiveAllTab => driver.FindElement(By.XPath("//*[contains(@id,'all-tab')and(contains(@class,'is-active'))]"));
        private IWebElement UsedTab => driver.FindElement(By.Id("used-tab"));
        private IWebElement NewTab => driver.FindElement(By.Id("new-tabl"));
        private IWebElement AllTab => driver.FindElement(By.Id("all-tab"));
        private IWebElement ManufacturerTab => driver.FindElement(By.Id("panel1-label"));
        private IWebElement EquipmentTypesTab => driver.FindElement(By.Id("panel2-label"));
        private IWebElement CategoriesTab => driver.FindElement(By.Id("panel3-label"));
        private IWebElement Search => driver.FindElement(By.CssSelector("#react-select-2--value > div.Select-input > input"));
        private IWebElement PopularManufacturers => driver.FindElement(By.Id("step-one-manufacturer-list"));
        private IWebElement Bourgault => driver.FindElement(By.Id("equipment-manufacturer-BO"));
        private IWebElement Case => driver.FindElement(By.Id("equipment-manufacturer-CA-li"));
        private IWebElement CaseIH => driver.FindElement(By.Id("equipment-manufacturer-CIH-li"));
        private IWebElement Caterpillar => driver.FindElement(By.Id("equipment-manufacturer-CT-li"));
        private IWebElement Claas => driver.FindElement(By.Id("equipment-manufacturer-CL-li"));
        private IWebElement Gleaner => driver.FindElement(By.Id("equipment-manufacturer-GLEAN-li"));
        private IWebElement JohnDeere => driver.FindElement(By.Id("equipment-manufacturer-JD-li"));
        private IWebElement Kubota => driver.FindElement(By.Id("equipment-manufacturer-KU-li"));
        private IWebElement MacDon => driver.FindElement(By.Id("equipment-manufacturer-MB-li"));
        private IWebElement MasseyFerguson => driver.FindElement(By.Id("equipment-manufacturer-MF-li"));
        private IWebElement MiscMake => driver.FindElement(By.Id("equipment-manufacturer-XX-li"));
        private IWebElement NewHolland => driver.FindElement(By.Id("equipment-manufacturer-NH-li"));
        private IWebElement PopularEquipmentTypes => driver.FindElement(By.Id("step-one-equipment-type-list"));
        private IWebElement BalerRound => driver.FindElement(By.Id("equipment-type-RB-li"));
        private IWebElement Combine => driver.FindElement(By.Id("equipment-type-CO-li"));
        private IWebElement Dozer => driver.FindElement(By.Id("equipment-type-DZ-li"));
        private IWebElement Excavator => driver.FindElement(By.Id("equipment-type-EX-li"));
        private IWebElement HeaderCombine => driver.FindElement(By.Id("equipment-type-CH-li"));
        private IWebElement HeaderCornHead => driver.FindElement(By.Id("equipment-type-CHCH-li"));
        private IWebElement MiscType => driver.FindElement(By.Id("equipment-type-XX-li"));
        private IWebElement SkidSteerLoader => driver.FindElement(By.Id("equipment-type-SS-li"));
        private IWebElement Tractor => driver.FindElement(By.Id("equipment-type-TR-li"));
        private IWebElement TractorLoaderBackhoe => driver.FindElement(By.Id("equipment-type-TB-li"));
        private IWebElement WheelLoader => driver.FindElement(By.Id("equipment-type-WL-li"));
        private IWebElement Windrower => driver.FindElement(By.Id("equipment-type-WR-li"));
        private IWebElement PopularCategories => driver.FindElement(By.Id("step-one-category-list"));
        private IWebElement Attachments => driver.FindElement(By.Id("equipment-category-ATTAC-li"));
        private IWebElement Construction => driver.FindElement(By.Id("equipment-category-CONST-li"));
        private IWebElement CropCare => driver.FindElement(By.Id("equipment-category-CROP-li"));
        private IWebElement Farmstead => driver.FindElement(By.Id("equipment-category-FARMS-li"));
        private IWebElement Groundskeeping => driver.FindElement(By.Id("equipment-category-GROUN-li"));
        private IWebElement Harvesting => driver.FindElement(By.Id("equipment-category-HARVE-li"));
        private IWebElement HayAndForage => driver.FindElement(By.Id("equipment-category-HAYF-li"));
        private IWebElement MaterialHandling => driver.FindElement(By.Id("equipment-category-MATH-li"));
        private IWebElement MiscCategory => driver.FindElement(By.Id("equipment-category-MISC-li"));
        private IWebElement Seeding => driver.FindElement(By.Id("equipment-category-SEEDI-li"));
        private IWebElement Tillage => driver.FindElement(By.Id("equipment-category-TILLA-li"));
        private IWebElement Tractors => driver.FindElement(By.Id("equipment-category-TRACT-li"));
        private IWebElement Vehicles => driver.FindElement(By.Id("equipment-category-VEHIC-li"));
        private IWebElement EquipmentTypeValue => driver.FindElement(By.CssSelector("#react-select-4--value > div.Select-placeholder"));
        private IWebElement EquipmentTypeInput => driver.FindElement(By.CssSelector("#react-select-4--value > div.Select-input > input"));
        private IWebElement Manufacturer => driver.FindElement(By.XPath("//*[contains(@id,'step-two-manufacturer-type')]/div/div/div/span/div[2]"));
        private IWebElement ModelNumberValue => driver.FindElement(By.XPath("//*[contains(@id,'step-two-model-type')]/div/div/div/span/div"));
        private IWebElement ModelNumberInput => driver.FindElement(By.XPath("//*[contains(@id,'step-two-model-type')]/div/div/div/span/div[2]"));
        private IWebElement ZipPostalCityState => driver.FindElement(By.XPath("//*[contains(@id,'step-two-location-type')]/div/div/span/div/span[contains(@id,'react-select')]"));
        private IWebElement Go => driver.FindElement(By.Id("step-two-go-button"));

        public void ConfirmOnAdvancedSearchPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/equipment/search");
            Util.Log("On Advanced Search Page");
        }

        public void ConfirmOnNewTab()
        {
            try{
                Assert.IsTrue(ActiveNewTab.Displayed);
                Util.Log("New Tab Active.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmOnUsedTab()
        {
            try{
                Assert.IsTrue(ActiveUsedTab.Displayed);
                Util.Log("New Tab Active.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmOnAllTab()
        {
            try{
                Assert.IsTrue(ActiveAllTab.Displayed);
                Util.Log("New Tab Active.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ClickUsedTab()
        {
            UsedTab.Click();
            Util.Log("Clicked Used Tab");
        }

        public void ClickNewTab()
        {
            NewTab.Click();
            Util.Log("Clicked New Tab");
        }

        public void ClickAllTab()
        {
            AllTab.Click();
            Util.Log("All Tab Clicked");
        }

        public void ClickManufacturersTab()
        {
            ManufacturerTab.Click();
            Util.Log("Clicked Manufacturers Tab");
        }

        public void ClickEquipmentTypesTab()
        {
            EquipmentTypesTab.Click();
            Util.Log("Clicked Equipment Types Tab");
        }

        public void ClickCategoriesTab()
        {
            CategoriesTab.Click();
            Util.Log("Clicked Categories Tab");
        }

        public Results ClickGo()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Go.Click();
            Util.Log("Clicked Go Button");
            return new Results(driver);
        }
    }
}
