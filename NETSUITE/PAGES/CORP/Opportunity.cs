namespace IRONQA.NETSUITE.PAGES.CORP
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    
    public class Opportunity
    {
        private IWebDriver driver;
        public Opportunity(IWebDriver _driver) => driver = _driver;
        private IWebElement Customer => driver.FindElement(By.Id("entity_display"));
        private IWebElement Save => driver.FindElement(By.Id("btn_multibutton_submitter"));
        private IWebElement Item => driver.FindElement(By.Id("inpt_item7"));
        private IWebElement EquipmentSource => driver.FindElement(By.Id("inpt_custcol78"));

        public void SelectCustomer(string cust)
        {
            string c = cust.ToUpper().Replace("-", string.Empty);
            Customer.SendKeys(c);
            Customer.SendKeys(Keys.Tab);
            Util.Log("Entered Customer.");
        }

        public void ClickSave()
        {
            Save.Click();
            Util.Log("Clicked Save.");
        }

        public enum Items { Quoted, Traded };
        public enum Equipment { Inventory, IronBuilder, ManualEntry, ProspectFor, QuoteFromQuote };
        public enum RentalRates { Daily, Weekly, Monthly };

        public void SelectItem(Items item)
        {
            var i = item.ToString();
            switch (i)
            {
                case "Quoted":
                    Item.SendKeys(i);
                    Util.Log("Selected " + i);
                    break;
                case "Traded":
                    Item.SendKeys(i);
                    Util.Log("Selected " + i);
                    break;
            }
        }

        public void SelectEquipmentSource(Equipment equip)
        {
            var e = equip.ToString();
            switch (e)
            {
                case "Inventory":
                    EquipmentSource.SendKeys(e);
                    Util.Log("Selected " + e);
                    break;
                case "IronBuilder":
                    EquipmentSource.SendKeys(e);
                    Util.Log("Selected " + e);
                    break;
                case "ManualEntry":
                    EquipmentSource.SendKeys(e);
                    Util.Log("Selected " + e);
                    break;
                case "ProspectFor":
                    EquipmentSource.SendKeys(e);
                    Util.Log("Selected " + e);
                    break;
                case "QuoteFromQuote":
                    EquipmentSource.SendKeys(e);
                    Util.Log("Selected " + e);
                    break;
            }
        }
    }
}
