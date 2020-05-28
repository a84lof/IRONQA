namespace IRONQA.GUIDES.PAGES.INVENTORY
{
    using IRONQA.GUIDES.PAGES.INVENTORY.EQUIPMENT;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class EquipmentAppraisal
    {
        private IWebDriver driver;
        public EquipmentAppraisal(IWebDriver _driver) => driver = _driver;
        private IWebElement KeywordFilter => driver.FindElement(By.XPath("//*[contains(@class,'inventory__search')]/input"));
        private IWebElement TypeFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Type')]/../div/div/div/div/div/div/div/input"));
        private IWebElement MakeFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Model')]/../div/div/div/div/div/div/div/input"));
        private IWebElement YearFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Year')]/../div/div/div/div/div/div/div/input"));
        private IWebElement AgeFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Age')]/../div/div/div/div/div/div/div/input"));
        private IWebElement LocationFilter => driver.FindElement(By.Id("dropdown__inventory-location-filter"));
        private IWebElement SelectAll => driver.FindElement(By.CssSelector("#equipment-list-appraisal > aside > button.button.hollow.small.button--select-all"));
        private IWebElement UnselectAll => driver.FindElement(By.CssSelector("#equipment-list-appraisal > aside > button.button.hollow.small.button--unselect"));
        private IWebElement AppraiseUpdateSelected => driver.FindElement(By.CssSelector("#equipment-list-appraisal > aside > button.button.medium.button--appraise-update"));
        private IWebElement Download => driver.FindElement(By.CssSelector("#equipment-list-appraisal > div:nth-child(2) > section > div.grid-cell.grid-cell-14.grid-cell--button-wrapper > button"));
        private IWebElement FleetCredits => driver.FindElement(By.XPath("//*[@id='equipment-list-appraisal']/aside/p[3]/text()[2]"));
        private IWebElement ItemsAvailable => driver.FindElement(By.CssSelector("#equipment-list-appraisal > aside > p:nth-child(2) > span"));

        public InvNav ConfirmOnEquipmentAppraisalTab()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//div[@id='root']/div/main/div[3]/div[contains(@class,'prompt-modal') and not(contains(@class,'show'))]");
            Thread.Sleep(1000);
            Util.Log("On Equipment Appraisal Tab.");
            return new InvNav(driver);
        }

        public void FilterOnKeyword(string keyword)
        {
            KeywordFilter.SendKeys(keyword);
            Util.Log("Searched: "+keyword);
        }

        public void FilterType(string type)
        {
            TypeFilter.SendKeys(type);
            Util.Log("Filtered by Type: "+type);
        }

        public void FilterMake(string make)
        {
            MakeFilter.SendKeys(make);
            Util.Log("Filtered by Make: "+make);
        }

        public void FilterYear(string year)
        {
            YearFilter.SendKeys(year);
            Util.Log("Filtered by Year: "+year);
        }

        public void FilterAge(string age)
        {
            AgeFilter.SendKeys(age);
            Util.Log("Filtered by Age: "+age);
        }

        public void FilterLocation(string location)
        {
            LocationFilter.SendKeys(location);
            Util.Log("Filtered by Location: "+location);
        }

        public void ClickSelectAll()
        {
            SelectAll.Click();
            Util.Log("Clicked Select All.");
        }

        public void ClickUnselectAll()
        {
            UnselectAll.Click();
            Util.Log("Clicked Select None.");
        }

        public void ClickAppraiseUpdateSelected()
        {
            AppraiseUpdateSelected.Click();
            Util.Log("Clicked Appraise/Update Selected.");
        }

        public void ClickDownload()
        {
            Download.Click();
            Util.Log("Clicked Download.");
        }

        public Details EditEquipment(string type, string make, string model, string year)
        {
            IWebElement EditEyeball = driver.FindElement(By.XPath("//*[contains(@class,'value') and text()='"+type+"']/../../div[contains(@class,'make')]/span[contains(text(),'"+make+"')]/../../div[contains(@class,'model')]/span[contains(text(),'"+year+"')]/../../div[contains(@class,'model')]/span[contains(text(),'"+year+"')]/../../../../div/a"));
            EditEyeball.Click();
            Util.Log("Clicked Edit Eyeball.");
            return new Details(driver);
        }

        public string GetFleetCreditsAvailable()
        {
            string CreditsAvailable = FleetCredits.Text;
            Util.Log("Fleet Credits Available: "+CreditsAvailable);
            return CreditsAvailable;
        }

        public string GetItemsAvailable()
        {
            string items = ItemsAvailable.Text;
            Util.Log("Items Available: "+items);
            return items;
        }

        public void SelectEquipment(string type, string make, string model, string year)
        {
            IWebElement Checkbox = driver.FindElement(By.XPath("//*[contains(@class,'make')]/span[contains(text(),'"+make+"')]/../../div[contains(@class,'type')]/span[contains(text(),'"+type+"')]/../../div[contains(@class,'model')]/span[contains(text(),'"+model+"')]/../../../../../div[2]/div/div/input"));
            Checkbox.Click();
            Util.Log("Clicked Equipment Checkbox.");
        }
    }
}