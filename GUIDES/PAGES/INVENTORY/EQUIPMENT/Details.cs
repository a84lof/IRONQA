namespace IRONQA.GUIDES.PAGES.INVENTORY.EQUIPMENT
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class Details
    {
        private IWebDriver driver;
        public Details(IWebDriver _driver) => driver = _driver;
        private IWebElement Type => driver.FindElement(By.Id("type__select"));
        private IWebElement Make => driver.FindElement(By.Id("make__select"));
        private IWebElement Model => driver.FindElement(By.Id("model__select"));
        private IWebElement Year => driver.FindElement(By.Id("year__select"));
        private IWebElement SerialNo => driver.FindElement(By.XPath("//*[contains(@class,'serial-number__label')]/../../div[2]/input"));
        private IWebElement StockNo => driver.FindElement(By.XPath("//*[contains(@class,'stock-number__label')]/../../div[2]/input"));
        private IWebElement Location => driver.FindElement(By.XPath("//*[contains(@class,'location__label')]/../../div[2]/div/div[contains(@id,'location__select')]"));
        private IWebElement Meters => driver.FindElement(By.XPath("//*[contains(@class,'meters__label')]/../../div[2]/input"));
        private IWebElement Warranty => driver.FindElement(By.XPath("//*[contains(@class,'warranty__label')]/../../div[2]/input"));
        private IWebElement WTYEndDate => driver.FindElement(By.XPath("//*[contains(@class,'warranty__date')]/../../div[2]/input"));
        private IWebElement Inspection => driver.FindElement(By.XPath("//*[contains(@class,'pdi__label')]/../../div[2]/input"));
        private IWebElement PreviousOwner => driver.FindElement(By.XPath("//*[contains(@class,'prev-owner__label')]/../../div[2]/input"));
        private IWebElement SellersComments => driver.FindElement(By.XPath("//*[contains(@class,'sellers-comments__label')]/../../div[2]/textarea"));
        private IWebElement PrivateNotes => driver.FindElement(By.XPath("//*[contains(@class,'private-notes__label')]/../../div[2]/textarea"));
        private IWebElement InterestBearing => driver.FindElement(By.Id("interest-bearing__select"));
        private IWebElement PaidInventory => driver.FindElement(By.Id("paid-inventory__select"));
        private IWebElement InventoryStatus => driver.FindElement(By.Id("inventory-status__select"));
        private IWebElement ListingType => driver.FindElement(By.Id("listing-type__select"));
        private IWebElement ListingStatus => driver.FindElement(By.Id("listing-status__select"));
        private IWebElement InvoiceDate => driver.FindElement(By.XPath("//*[contains(@class,'invoice-date__label')]/../../div[2]/input"));

        public EquipNav ConfirmOnDetailsPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//section[@id='details']/div/div/div[contains(@class,'prompt-modal') and not(contains(@class,'show'))]");
            Thread.Sleep(1000);
            Util.Log("On Details Page.");
            return new EquipNav(driver);
        }

        public void SelectType(string type)
        {
            Type.SendKeys(type);
            Util.Log("Entered Type: "+type);
        }

        public void SelectMake(string make)
        {
            Make.SendKeys(make);
            Util.Log("Entered Type: "+make);
        }

        public void SelectModel(string model)
        {
            Model.SendKeys(model);
            Util.Log("Entered Type: "+model);
        }

        public void SelectYear(string year)
        {
            Year.SendKeys(year);
            Util.Log("Entered Type: "+year);
        }

        public void EnterSerialNo(string serialNo)
        {
            SerialNo.SendKeys(serialNo);
            Util.Log("Entered Type: "+serialNo);
        }

        public void EnterStockNo(string stockNo)
        {
            StockNo.SendKeys(stockNo);
            Util.Log("Entered Type: "+stockNo);
        }

        public void SelectLocation(string location)
        {
            Location.SendKeys(location);
            Util.Log("Entered Type: "+location);
        }

        public void EnterMeters(string meters)
        {
            Meters.SendKeys(meters);
            Util.Log("Entered Type: "+meters);
        }
    }
}