namespace IRONQA.GUIDES.PAGES.INVENTORY
{
    using IRONQA.GUIDES.PAGES.INVENTORY.EQUIPMENT;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class NonReadyEquipment
    {
        private IWebDriver driver;
        public NonReadyEquipment(IWebDriver _driver) => driver = _driver;
        private IWebElement element => driver.FindElement(By.CssSelector("#inventory-details-tabs > li:nth-child(1) > a"));
        private IWebElement KeywordFilter => driver.FindElement(By.XPath("//*[contains(@class,'inventory__search')]/input"));
        private IWebElement TypeFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Type')]/../div/div/div/div/div/div/div/input"));
        private IWebElement MakeFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Model')]/../div/div/div/div/div/div/div/input"));
        private IWebElement YearFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Year')]/../div/div/div/div/div/div/div/input"));
        private IWebElement AgeFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Age')]/../div/div/div/div/div/div/div/input"));
        private IWebElement LocationFilter => driver.FindElement(By.Id("dropdown__inventory-location-filter"));

        public void ConfirmOnNonReadyEquipmentTab()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//div[@id='root']/div/main/div[3]/div[contains(@class,'prompt-modal') and not(contains(@class,'show'))]");
            Thread.Sleep(1000);
            Util.Log("On Non-Ready Equipment Tab");
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

        public Details EditEquipment(string type, string make, string model)
        {
            IWebElement EditEyeball = driver.FindElement(By.XPath("//*[contains(@class,'value') and text()='"+type+"']/../../div[contains(@class,'make')]/span[contains(text(),'"+make+"')]/../../div[contains(@class,'model')]/span[contains(text(),'"+model+"')]/../../../../div/a"));
            EditEyeball.Click();
            Util.Log("Clicked Edit Eyeball.");
            return new Details(driver);
        }
    }
}