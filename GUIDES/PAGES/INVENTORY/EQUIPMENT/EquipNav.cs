namespace IRONQA.GUIDES.PAGES.INVENTORY.EQUIPMENT
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class EquipNav
    {
        private IWebDriver driver;
        public EquipNav(IWebDriver _driver) => driver = _driver;
        private IWebElement EditEquipment => driver.FindElement(By.XPath("//div[@id='root']/main/div/div/div/button[text()='Edit Equipment']"));
        private IWebElement DoneEditing => driver.FindElement(By.XPath("//div[@id='root']/main/div/div/div/button[text()='Done Editing']"));
        private IWebElement ReturnToInventoryList => driver.FindElement(By.CssSelector("#root > main > div:nth-child(1) > div > div > a"));
        private IWebElement Details => driver.FindElement(By.XPath("//*[contains(@data-tabs-target,'details')]"));
        private IWebElement FeaturesOptions => driver.FindElement(By.XPath("//*[contains(@data-tabs-target,'features-options')]"));
        private IWebElement Photos => driver.FindElement(By.XPath("//*[contains(@data-tabs-target,'photos')]"));
        private IWebElement Appraisal => driver.FindElement(By.XPath("//*[contains(@data-tabs-target,'pricing-appraisal')]"));
        private IWebElement Preview => driver.FindElement(By.XPath("//*[contains(@data-tabs-target,'ironsearch-preview')]"));

        public void ConfirmEquipmentNav()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//section[@id='details']/div/div/div[contains(@class,'prompt-modal') and not(contains(@class,'show'))]");
            Thread.Sleep(1000);
            Util.Log("Equipment Nav Displayed.");
        }

        public Details ClickEditEquipment()
        {
            EditEquipment.Click();
            Util.Log("Clicked Edit Equipment");
            return new Details(driver);
        }

        public void ClickDoneEditing()
        {
            DoneEditing.Click();
            Util.Log("Clicked Done Editing.");
        }

        public MyEquipment ClickReturnToInventoryList()
        {
            ReturnToInventoryList.Click();
            Util.Log("Clicked Return to Inventory List.");
            return new MyEquipment(driver);
        }

        public Details ClickDetailsTab()
        {
            Details.Click();
            Util.Log("Clicked Details");
            return new Details(driver);
        }

        public FeaturesOptions ClickFeaturesOptions()
        {
            FeaturesOptions.Click();
            Util.Log("Clicked Features & Options");
            return new FeaturesOptions(driver);
        }

        public Photos ClickPhotos()
        {
            Photos.Click();
            Util.Log("Clicked Photos");
            return new Photos(driver);
        }

        public PricingAppraisal ClickAppraisal()
        {
            Appraisal.Click();
            Util.Log("Clicked Appraisal");
            return new PricingAppraisal(driver);
        }
    }
}