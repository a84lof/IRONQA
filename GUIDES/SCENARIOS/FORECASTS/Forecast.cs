namespace IRONQA.GUIDES.SCENARIOS.FORECASTS
{
    using IRONQA.GUIDES.PAGES.DASHBOARD;
    using IRONQA.GUIDES.PAGES.FORECAST;
    using IRONQA.GUIDES.PAGES.SHARED;
    using IRONQA.SSO.PAGES;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Forecast
    {
        private IWebDriver driver;
        public Forecast(IWebDriver _driver) => driver = _driver;

        public void ForecastSingleItemValuation_CANAdmin()
        {// Single Item Valuation for Canadian user
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.CANProAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickForecast();
            InventoryValuation inventory = guidesNav.ClickInventoryValuation();
            inventory.ConfirmOnInventoryValuationPage();
            inventory.ClickSelectNone();
            inventory.ClickCheckbox(1);
            inventory.ClickAdjustForecastPredictors();
            inventory.ClickIUnderstand();
            inventory.ClickCalculateIronForecast();
        }

        public void ForecastSingleItemValuation_CANUser()
        {// Single Item Valuation for Canadian user
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.CANProUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickForecast();
            InventoryValuation inventory = guidesNav.ClickInventoryValuation();
            inventory.ConfirmOnInventoryValuationPage();
            inventory.ClickSelectNone();
            inventory.ClickCheckbox(1);
            inventory.ClickAdjustForecastPredictors();
            inventory.ClickIUnderstand();
            inventory.ClickCalculateIronForecast();
        }

        public void ForecastSingleItemValuation_USAdmin()
        {// Single Item Valuation for US user
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickForecast();
            InventoryValuation inventory = guidesNav.ClickInventoryValuation();
            inventory.ConfirmOnInventoryValuationPage();
            inventory.ClickSelectNone();
            //inventory.FilterEquipmentTypes(InventoryValuation.EquipmentType.Combine);
            //inventory.SelectEquipment();
            inventory.ClickCheckbox(3); //3 for US, 1 for CAN
            inventory.ClickAdjustForecastPredictors();
            //inventory.SetOneMonthForecastTerm();
            inventory.ClickIUnderstand();
            inventory.ClickCalculateIronForecast();
        }

        public void ForecastSingleItemValuation_USUser()
        {// Single Item Valuation for US user
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickForecast();
            InventoryValuation inventory = guidesNav.ClickInventoryValuation();
            inventory.ConfirmOnInventoryValuationPage();
            inventory.ClickSelectNone();
            inventory.ClickCheckbox(3); //3 for US, 1 for CAN
            inventory.ClickAdjustForecastPredictors();
            inventory.ClickIUnderstand();
            inventory.ClickCalculateIronForecast();
        }
    }
}