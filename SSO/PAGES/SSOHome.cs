namespace IRONQA.SSO.PAGES
{
    using IRONQA.FSBO.PAGES.APPRAISAL;
    using IRONQA.GUIDES.PAGES.DASHBOARD;
    using IRONQA.FSBO.PAGES.FORSALEBYOWNER;
    using IRONQA.SEARCH.PAGES;
    using IRONQA.STORE.PAGES.MYACCOUNT;
    using IRONQA.STORE.PAGES.SHARED;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class SSOHome
    {
        private IWebDriver driver;
        public SSOHome(IWebDriver _driver) => driver = _driver;
        private IWebElement IronGuides => driver.FindElement(By.XPath("//*[contains(@href,'/Sites/SingleSignOn?provider=IronGuides')]"));
        private IWebElement MyAccount => driver.FindElement(By.XPath("//*[contains(text(),'My Account')]"));
        private IWebElement IronAppraiser => driver.FindElement(By.XPath("//*[contains(@href,'FsboAppraiser') and (contains(text(),'IronAppraiser'))]"));
        private IWebElement ViewMyIncompleteAppraisals => driver.FindElement(By.XPath("//*[contains(@href,'incompleteappraisals')]"));
        private IWebElement ForSaleByOwner => driver.FindElement(By.XPath("//*[contains(text(),'For Sale by Owner')]"));
        private IWebElement ManageInventory => driver.FindElement(By.XPath("//*[contains(text(),'Manage Inventory')]"));
        private IWebElement ViewMyLstings => driver.FindElement(By.XPath("//*[contains(text(),'View My Listings')]"));
        private IWebElement PurchaseBuyersGuideForTractors => driver.FindElement(By.XPath("//*[contains(@href,'ironsearch-buyers-guide_3')]"));
        private IWebElement PurchaseOutdoorPowerEquipmentGuide => driver.FindElement(By.XPath("//*[contains(@href,'Outdoor-Power-Equipment')]"));
        private IWebElement PurchaseBuyersGuideForFarmEquipment => driver.FindElement(By.XPath("//*[contains(@href,'ironsearch-buyers-guide_5')]"));
        private IWebElement PurchaseSerialNumberHandbook => driver.FindElement(By.XPath("//*[contains(@href,'serial_number_handbook')]"));
        private IWebElement Logout => driver.FindElement(By.XPath("//*[contains(@href,'/Logout')]"));

        public void ConfirmOnSSOHomePage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForElement("XPath","//*[contains(text(),'My Iron Solutions Home')]");
            Util.Log("On SSO Home Page.");
        }

        public DashboardNav ClickIronGuides()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(IronGuides);
            Util.Log("Clicked IronGuides.");
            return new DashboardNav(driver);
        }

        public Overview ClickMyAccount()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(MyAccount);
            Util.Log("Clicked eStore MyAccount.");
            return new Overview(driver);
        }

        public IncompleteAppraisals ClickViewMyIncompleteAppraisals()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(ViewMyIncompleteAppraisals);
            Util.Log("Clicked View My Incomplete Appraisals.");
            return new IncompleteAppraisals(driver);
        }

        public Results ClickViewMyListings()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(ViewMyLstings);
            Util.Log("Clicked View My Listings.");
            return new Results(driver);
        }

        public PurchaseGuides ClickPurchaseSerialNumberHandbook()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(PurchaseSerialNumberHandbook);
            Util.Log("Clicked Purchase Serial Number Handbook.");
            return new PurchaseGuides(driver); //need to build this
        }

        public PurchaseGuides ClickPurchaseBuyersGuideForTractors()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(PurchaseBuyersGuideForTractors);
            Util.Log("Clicked Purchase Buyers Guide For Tractors.");
            return new PurchaseGuides(driver);
        }

        public PurchaseGuides ClickPurchaseOutdoorPowerEquipmentGuide()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(PurchaseOutdoorPowerEquipmentGuide);
            Util.Log("Clicked Purchase Outdoor Power Equipment Guide.");
            return new PurchaseGuides(driver);
        }

        public AppraisalLanding ClickIronAppraiser()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(IronAppraiser);
            Util.Log("Clicked Appraise My Equipment.");
            return new AppraisalLanding(driver);
        }

        public Dashboard ClickForSaleByOwner()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(ForSaleByOwner);
            Util.Log("Clicked List My Equipment For Sale.");
            return new Dashboard(driver);
        }

        public PurchaseGuides ClickPurchaseBuyersGuideForFarmEquipment()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(PurchaseBuyersGuideForFarmEquipment);
            Util.Log("Clicked Purchase Buyers Guide For Farm Equipment.");
            return new PurchaseGuides(driver);
        }

        // public DealerDashboardLogin ClickManageInventory()
        // {
        //     Shared util = new Shared(driver);
        //     util.ClickToNewTab(ManageInventory);
        //     Util.Log("Clicked Manage Inventory.");
        //     return new DealerDashboardLogin(driver);
        // }

        public Logout ClickLogout()
        {
            Thread.Sleep(2000);
            Logout.Click();
            Util.Log("Clicked Logout.");
            return new Logout(driver);
        }
    }
}