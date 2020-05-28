namespace IRONQA.GUIDES.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    
    public class AppraisalNav
    {
        private IWebDriver driver;
        public AppraisalNav(IWebDriver _driver) => driver = _driver;
        private IWebElement CustomerInfo => driver.FindElement(By.Id("nav--info"));
        private IWebElement SerialNumber => driver.FindElement(By.Id("nav--serial"));
        private IWebElement Photos => driver.FindElement(By.Id("nav--photos"));
        private IWebElement InspectionWorksheet => driver.FindElement(By.Id("nav--inspect"));
        private IWebElement Export => driver.FindElement(By.Id("nav--export"));

        public CustomerInfo ClickCustomerInfo()
        {
            CustomerInfo.Click();
            Util.Log("Clicked Customer Info.");
            return new CustomerInfo(driver);
        }

        public SerialNumber ClickSerialNumber()
        {
            SerialNumber.Click();
            Util.Log("Clicked Serial Number.");
            return new SerialNumber(driver);
        }

        public InspectionWorksheet ClickInspectionWorksheet()
        {
            InspectionWorksheet.Click();
            Util.Log("Clicked Inspection Worksheet.");
            return new InspectionWorksheet(driver);
        }
    }
}
