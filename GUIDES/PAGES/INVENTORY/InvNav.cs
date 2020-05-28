namespace IRONQA.GUIDES.PAGES.INVENTORY
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class InvNav
    {
        private IWebDriver driver;
        public InvNav(IWebDriver _driver) => driver = _driver;
        private IWebElement MyEquipmentTab => driver.FindElement(By.XPath("//ul[@id='inventory-details-tabs']/li[1]/a"));
        private IWebElement EquipmentAppraisalTab => driver.FindElement(By.XPath("//ul[@id='inventory-details-tabs']/li[2]/a"));
        private IWebElement NonReadyEquipmentTab => driver.FindElement(By.XPath("//ul[@id='inventory-details-tabs']/li[3]/a"));
        private IWebElement ReportsTab => driver.FindElement(By.XPath("//ul[@id='inventory-details-tabs']/li[4]/a"));
        private IWebElement AddEquipmentTab => driver.FindElement(By.XPath("//ul[@id='inventory-details-tabs']/li[5]/a"));

        public void ConfirmInvNav()
        {
            Util util = new Util(driver);
            util.WaitForElement("CssSelector","#root > main > div:nth-child(1) > div > div > button");
            Util.Log("Inventory Nav Displayed.");
        }

        public MyEquipment ClickMyEquipment()
        {// also known as Inventory List
            MyEquipmentTab.Click();
            Util.Log("Clicked My Equipment Nav");
            return new MyEquipment(driver);
        }

        public EquipmentAppraisal ClickEquipmentAppraisal()
        {
            EquipmentAppraisalTab.Click();
            Util.Log("Clicked Equipment Appraisal Nav");
            return new EquipmentAppraisal(driver);
        }

        public NonReadyEquipment ClickNonReadyEquipment()
        {
            NonReadyEquipmentTab.Click();
            Util.Log("Clicked Non-Ready Equipment Nav.");
            return new NonReadyEquipment(driver);
        }

        public Reports ClickReports()
        {
            ReportsTab.Click();
            Util.Log("Clicked Reports.");
            return new Reports(driver);
        }

        public AddEquipment ClickAddEquipment()
        {
            AddEquipmentTab.Click();
            Util.Log("Clicked Add Equipment.");
            return new AddEquipment(driver);
        }
    }
}