namespace IRONQA.GUIDES.PAGES.SHARED
{
    using IRONQA.GUIDES.PAGES.APPRAISAL;
    using IRONQA.GUIDES.PAGES.FORECAST;
    using IRONQA.GUIDES.PAGES.HELPCENTER;
    using IRONQA.GUIDES.PAGES.INVENTORY;
    using IRONQA.GUIDES.PAGES.DASHBOARD;
    using IRONQA.SSO.PAGES;
    using IRONQA.STORE.PAGES.MYACCOUNT;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class GuidesNav
    {
        private IWebDriver driver;
        public GuidesNav(IWebDriver _driver) => driver = _driver;
        private IWebElement Dashboard => driver.FindElement(By.CssSelector("#HomeNav > a"));
        private IWebElement StartAppraisal => driver.FindElement(By.CssSelector("#SRNav > a"));
        private IWebElement AgricultureEquipment => driver.FindElement(By.XPath("//*[@id='SRNav']/ul/li[1]"));
        private IWebElement OutdoorPowerEquipment => driver.FindElement(By.XPath("//*[@id='SRNav']/ul/li[2]"));
        private IWebElement IronSearchBuyersGuide => driver.FindElement(By.XPath("//*[@id='SRNav']/ul/li[3]/a"));
        private IWebElement OtherEquipmentAppraisal => driver.FindElement(By.XPath("//*[@id='SRNav']/ul/li[4]"));
        private IWebElement MyInventory => driver.FindElement(By.Id("InvNav"));
        private IWebElement IronForecast => driver.FindElement(By.CssSelector("#RVNav > a"));
        private IWebElement InventoryValuation => driver.FindElement(By.XPath("//*[@id='RVNav']/ul/li[1]"));
        private IWebElement EquipmentModels => driver.FindElement(By.CssSelector("#RVNav > ul > li:nth-child(2) > a"));
        private IWebElement UpcomingFeatures => driver.FindElement(By.CssSelector("#UFNav > a"));
        private IWebElement ProvideFeedback => driver.FindElement(By.CssSelector("#PFNav > a"));
        private IWebElement HelpMenu => driver.FindElement(By.CssSelector(".nav__account>ul>li>a"));
        private IWebElement HelpCenter => driver.FindElement(By.CssSelector(".nav__account>ul>li>ul>li>a"));
        private IWebElement AboutIronSolutions => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__account.top-bar-right > ul > li > ul > li:nth-child(2) > a"));
        private IWebElement EmailSupport => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__account.top-bar-right > ul > li > ul > li:nth-child(3) > a"));
        private IWebElement CallSupport => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__account.top-bar-right > ul > li > ul > li:nth-child(4) > a"));
        private IWebElement MyProfile => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__account.top-bar-right > ul > li > ul > li:nth-child(5) > a"));
        private IWebElement SignOut => driver.FindElement(By.CssSelector("#desktop-menu > div.__account.top-bar-right > ul > li > ul > li:nth-child(6)"));

        public DashboardNav ClickDashboard()
        {
            Dashboard.Click();
            Util.Log("Clicked Dashboard Header");
            return new DashboardNav(driver);
        }

        public MyEquipment ClickMyInventory()
        {
            MyInventory.Click();
            Util.Log("Clicked My Inventory");
            return new MyEquipment(driver);
        }

        public void ClickForecast()
        {
            IronForecast.Click();
            Thread.Sleep(1000);
            Util.Log("Clicked Iron Forecast");
        }

        public ProvideFeedback ClickProvideFeedback()
        {
            ProvideFeedback.Click();
            Util.Log("Clicked Provide Feedback");
            return new ProvideFeedback(driver);
        }

        public void ClickStartAppraisal()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","SRNav");
            StartAppraisal.Click();
            Util.Log("Clicked Start Appraisal.");
        }

        public Step1 ClickOutdoorPowerEquipment()
        {
            OutdoorPowerEquipment.Click();
            Util.Log("Clicked Outdoor Power Equipment.");
            return new Step1(driver);
        }

        public Step1 ClickAgricultureEquipment()
        {
            AgricultureEquipment.Click();
            Util.Log("Clicked Agriculture Equipment.");
            return new Step1(driver);
        }

        public Step1 ClickIronSearchBuyersGuide()
        {
            IronSearchBuyersGuide.Click();
            Util.Log("Clicked Iron Search Buyer Guide.");
            return new Step1(driver);
        }

        public OtherEquipment ClickOtherEquipmentAppraisal()
        {
            OtherEquipmentAppraisal.Click();
            Util.Log("Clicked Additional Models");
            return new OtherEquipment(driver);
        }

        public InventoryValuation ClickInventoryValuation()
        {
            InventoryValuation.Click();
            Thread.Sleep(20000); //varies
            Util.Log("Clicked Inventory Valuation");
            return new InventoryValuation(driver);
        }

        public EquipmentModels ClickEquipmentModels()
        {
            IronForecast.Click();
            EquipmentModels.Click();
            Util.Log("Clicked Used Equipment Models");
            return new EquipmentModels(driver);
        }
        public void ClickHelpMenu()
        {
            HelpMenu.Click();
            Thread.Sleep(2000);
            Util.Log("Clicked Help Menu.");
        }

        public Media ClickHelpCenter()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            HelpCenter.Click();
            Util.Log("Clicked Help Center");
            return new Media(driver);
        }

        public About ClickAboutIronSolutions()
        {
            AboutIronSolutions.Click();
            Util.Log("Clicked About Iron Solutions");
            return new About(driver);
        }

        public Media ClickEmailSupport()
        {
            EmailSupport.Click();
            Util.Log("Clicked Email Support");
            return new Media(driver);
        }

        public Overview ClickMyAccount()
        {
            MyProfile.Click();
            Util.Log("Clicked My Profile");
            return new Overview(driver);
        }

        public Logout ClickSignOut()
        {
            SignOut.Click();
            Util.Log("Clicked Sign Out");
            return new Logout(driver);
        }
    }
}
