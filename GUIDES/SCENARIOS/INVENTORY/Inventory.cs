namespace IRONQA.GUIDES.SCENARIOS.INVENTORY
{
    using IRONQA.GUIDES.PAGES.DASHBOARD;
    using IRONQA.GUIDES.PAGES.INVENTORY;
    using IRONQA.GUIDES.PAGES.INVENTORY.EQUIPMENT;
    using IRONQA.GUIDES.PAGES.SHARED;
    using IRONQA.SSO.PAGES;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Inventory
    {
        private IWebDriver driver;
        public Inventory(IWebDriver _driver) => driver = _driver;

        public void ConfirmEquipmentTabs_MultiLocAdmin()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.ProInvAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            MyEquipment equipment = guidesNav.ClickMyInventory();
            InvNav iNav = equipment.ConfirmOnMyEquipmentTab();
            EquipmentAppraisal equipAppraise = iNav.ClickEquipmentAppraisal();
            equipAppraise.ConfirmOnEquipmentAppraisalTab();
            NonReadyEquipment nonEquip = iNav.ClickNonReadyEquipment();
            nonEquip.ConfirmOnNonReadyEquipmentTab();
            Reports reports = iNav.ClickReports();
            reports.ConfirmOnReportsTab();
            AddEquipment addEquip = iNav.ClickAddEquipment();
            addEquip.ConfirmOnAddEquipmentTab();
        }

        public void ConfirmEquipmentTabs_SingleLocAdmin()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.PlusInvAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            MyEquipment equipment = guidesNav.ClickMyInventory();
            InvNav iNav = equipment.ConfirmOnMyEquipmentTab();
            EquipmentAppraisal equipAppraise = iNav.ClickEquipmentAppraisal();
            equipAppraise.ConfirmOnEquipmentAppraisalTab();
            NonReadyEquipment nonEquip = iNav.ClickNonReadyEquipment();
            nonEquip.ConfirmOnNonReadyEquipmentTab();
            Reports reports = iNav.ClickReports();
            reports.ConfirmOnReportsTab();
            AddEquipment addEquip = iNav.ClickAddEquipment();
            addEquip.ConfirmOnAddEquipmentTab();
        }

        public void EditEquipment()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.ProInvAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            MyEquipment equipment = guidesNav.ClickMyInventory();
            equipment.ConfirmOnMyEquipmentTab();
            equipment.FilterType("Combine");
            equipment.FilterMake("John Deere");
            equipment.FilterModel("7720");
            EquipNav eNav = equipment.SelectEquipment("Combine","John Deere","7720","1980");
            eNav.ConfirmEquipmentNav();
            Details details = eNav.ClickEditEquipment();
            details.ConfirmOnDetailsPage();
            details.EnterSerialNo("QA TEST.");
            eNav.ClickDoneEditing();
        }

        public void ConfirmStandardSpecs()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.ProInvAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            MyEquipment equipment = guidesNav.ClickMyInventory();
            equipment.ConfirmOnMyEquipmentTab();
            equipment.FilterType("Combine");
            equipment.FilterMake("John Deere");
            equipment.FilterModel("7720");
            EquipNav eNav = equipment.SelectEquipment("Combine","John Deere","7720","1980");
            eNav.ConfirmEquipmentNav();
            Details details = eNav.ClickEditEquipment();
            details.ConfirmOnDetailsPage();
            FeaturesOptions fOptions = eNav.ClickFeaturesOptions();
            fOptions.ExpandStandardSpecs();
            fOptions.ConfirmStandardSpecsList();
        }

        public void MarkEquipmentSold()
        {// This will mark a piece of equipment sold and remove it from inventory
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.ProInvAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            MyEquipment equipment = guidesNav.ClickMyInventory();
            equipment.ConfirmOnMyEquipmentTab();
            equipment.FilterType("Combine");
            equipment.FilterMake("John Deere");
            equipment.FilterModel("S670");
            MarkSold sold = equipment.ClickMarkSold("Combine","John Deere","S670","2015");
            sold.EnterStockNumber(Util.GetRandomString(9));
            sold.SelectSaleType(MarkSold.SaleType.Retail);
            sold.EnterNetCashSellingPrice(Util.GetRandomNumber(5));
            sold.EnterSerialNumber(Util.GetRandomString(12));
            sold.EnterAskingPrice(/* uses price set in EnterNetCashSellingPrice */);
            sold.EnterWorkOrder(Util.GetRandomNumber(3));
            sold.EnterSepHours(Util.GetRandomNumber(3));
            sold.EnterEngHours(Util.GetRandomNumber(4));
            sold.ClickMarkSold(); 
            sold.ConfirmSuccess();
        }
    }
}