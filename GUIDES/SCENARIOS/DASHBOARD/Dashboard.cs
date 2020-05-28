namespace IRONQA.GUIDES.SCENARIOS.DASHBOARD
{
    using IRONQA.GUIDES.PAGES.DASHBOARD;
    using IRONQA.GUIDES.PAGES.HELPCENTER;
    using IRONQA.GUIDES.PAGES.SHARED;
    using IRONQA.SSO.PAGES;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Dashboard
    {
        private IWebDriver driver;
        public Dashboard(IWebDriver _driver) => driver = _driver;

        public void MyIronFilters()
        {// Combined check of all filters
            SSOLogin login = new SSOLogin(driver);
            SSOHome sso = login.SubmitValidCredentials(Users.USPlusAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            SavedAppraisals saved = dashNav.ClickMySavedAppraisals();
            // creator
            saved.FilterByCreator("PlusAdmin, U.");
            saved.ConfirmAppraisalDisplayed("Creator","Admin");
            saved.ClearCreatorsFilter();
            // customer
            saved.FilterByCustomer("N/A");
            saved.ConfirmAppraisalDisplayed("Customer","N/A");
            saved.ClearCustomersFilter();
            // model
            saved.FilterByModel("1734");
            saved.ConfirmAppraisalDisplayed("Model","1734");
            saved.ClearModelsFilter();
            // date
            saved.AppraisalSortBy("Date (Oldest first)");
            string Date1 = saved.GetAppraisalDate().ToString();
            saved.AppraisalSortBy("Date (Most recent first)");
            string Date2 = saved.GetAppraisalDate().ToString();
            saved.CompareDates(Date1, Date2);
        }

        public void MyIronNews()
        {// Confirm News Aricles
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            News news = new News(driver);
            news.ConfirmNews();
        }

        public void Insights()
        {// Confirm News Aricles
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            // News news = new News(driver);
            // news.ConfirmNews();
        }
    }
}