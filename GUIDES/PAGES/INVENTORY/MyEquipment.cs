namespace IRONQA.GUIDES.PAGES.INVENTORY
{
    using IRONQA.GUIDES.PAGES.INVENTORY.EQUIPMENT;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class MyEquipment //aka Inventory List
    {
        private IWebDriver driver;
        public MyEquipment(IWebDriver _driver) => driver = _driver;
        private IWebElement KeywordFilter => driver.FindElement(By.XPath("//*[contains(@class,'inventory__search')]/input"));
        private IWebElement TypeFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Type')]/../div/div/div/div/div/div/div/input"));
        private IWebElement MakeFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Make')]/../div/div/div/div/div/div/div/input"));
        private IWebElement ModelFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Model')]/../div/div/div/div/div/div/div/input"));
        private IWebElement YearFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Year')]/../div/div/div/div/div/div/div/input"));
        private IWebElement AgeFilter => driver.FindElement(By.XPath("//*[contains(@class,'filter')]/label[contains(text(),'Age')]/../div/div/div/div/div/div/div/input"));
        private IWebElement LocationFilter => driver.FindElement(By.Id("dropdown__inventory-location-filter"));

        public InvNav ConfirmOnMyEquipmentTab()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//div[@id='root']/div/main/div[3]/div[contains(@class,'prompt-modal') and not(contains(@class,'show'))]");
            Thread.Sleep(1000);
            Util.Log("On Inventory Page.");
            return new InvNav(driver);
        }

        public void FilterOnKeyword(string keyword)
        {
            KeywordFilter.SendKeys(keyword);
            KeywordFilter.SendKeys(Keys.Enter);
            Thread.Sleep(1500);
            Util.Log("Searched: "+keyword);
        }

        public void FilterType(string type)
        {
            TypeFilter.SendKeys(type);
            TypeFilter.SendKeys(Keys.Enter);
            Thread.Sleep(1500);
            Util.Log("Filtered by Type: "+type);
        }

        public void FilterMake(string make)
        {
            MakeFilter.SendKeys(make);
            MakeFilter.SendKeys(Keys.Enter);
            Thread.Sleep(1500);
            Util.Log("Filtered by Make: "+make);
        }

        public void FilterModel(string model)
        {
            ModelFilter.SendKeys(model);
            ModelFilter.SendKeys(Keys.Enter);
            Thread.Sleep(1500);
            Util.Log("Filtered by Model: "+model);
        }

        public void FilterYear(string year)
        {
            YearFilter.SendKeys(year);
            YearFilter.SendKeys(Keys.Enter);
            Thread.Sleep(1500);
            Util.Log("Filtered by Year: "+year);
        }

        public void FilterAge(string age)
        {
            AgeFilter.SendKeys(age);
            AgeFilter.SendKeys(Keys.Enter);
            Thread.Sleep(1500);
            Util.Log("Filtered by Age: "+age);
        }

        public void FilterLocation(string location)
        {
            LocationFilter.SendKeys(location);
            LocationFilter.SendKeys(Keys.Enter);
            Thread.Sleep(1500);
            Util.Log("Filtered by Location: "+location);
        }

        public EquipNav SelectEquipment(string type, string make, string model, string year)
        {
            // Edit Button
            IWebElement Edit = driver.FindElement(By.XPath("//*[contains(@class,'type')]/span[contains(text(),'"+type+"')]/../../div[contains(@class,'make')]/span[contains(text(),'"+make+"')]/../../div[contains(@class,'model')]/span[contains(text(),'"+model+"')]/../../div[contains(@class,'year')]/span[contains(text(),'"+year+"')]/../../../../div[2]/button/i"));
            Edit.Click();
            Util.Log("Selected Equipment");
            return new EquipNav(driver);
        }

        public MarkSold ClickMarkSold(string type, string make, string model, string year)
        {
            // $ Button
            Thread.Sleep(500);
            IWebElement Edit = driver.FindElement(By.XPath("//*[contains(@class,'type')]/span[contains(text(),'"+type+"')]/../../div[contains(@class,'make')]/span[contains(text(),'"+make+"')]/../../div[contains(@class,'model')]/span[contains(text(),'"+model+"')]/../../div[contains(@class,'year')]/span[contains(text(),'"+year+"')]/../../../../div[3]/button/i"));
            Edit.Click();
            Util.Log("Selected Equipment");
            return new MarkSold(driver);
        }
    }
}