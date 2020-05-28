namespace IRONQA.GUIDES.SCENARIOS.OTHEREQUIP
{
    using IRONQA.GUIDES.PAGES.APPRAISAL;
    using IRONQA.GUIDES.PAGES.DASHBOARD;
    using IRONQA.GUIDES.PAGES.SHARED;
    using IRONQA.SSO.PAGES;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class OtherEquip
    {
        private IWebDriver driver;
        public OtherEquip(IWebDriver _driver) => driver = _driver;

        public void OtherEquipmentSearch()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.CANProAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav =  new GuidesNav(driver);
            driver.Navigate().GoToUrl("https://betasecure.ironguides.com/otherequipment");
            OtherEquipment other = new OtherEquipment(driver);
            other.ConfirmOnOtherEquipment();
            other.EnterTMM("1770NT");
            other.SelectTMMSuggest("1770NT");
            other.ConfirmReportsDisplayed();
        }
    }
}