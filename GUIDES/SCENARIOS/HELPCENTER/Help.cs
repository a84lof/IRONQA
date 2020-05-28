namespace IRONQA.GUIDES.SCENARIOS.HELPCENTER
{
    using IRONQA.GUIDES.PAGES.DASHBOARD;
    using IRONQA.GUIDES.PAGES.HELPCENTER;
    using IRONQA.GUIDES.PAGES.SHARED;
    using IRONQA.SSO.PAGES;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Help
    {
        private IWebDriver driver;
        public Help(IWebDriver _driver) => driver = _driver;

        public void HelpCenter()
        {// Confirm Help Center Page ELements are Displayed
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickHelpMenu();
            Media media = guidesNav.ClickHelpCenter();
            media.ConfirmOnHelpCenterPage();
            media.ConfirmOGDownloadablePDFs();
            media.ConfirmOGVideosPresent();
            media.ClickIronForecastTab();
            media.ConfirmIRONDownloadablePDFs();
            media.ConfirmIRONVideosPresent();
        }

        public void ProvideFeedback()
        {// Confirm Feedback Page
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            ProvideFeedback provideFeedback = guidesNav.ClickProvideFeedback();
            provideFeedback.ConfirmOnProvideFeedbackPage();
            provideFeedback.AddComments("This is a comment.");
            provideFeedback.ClickCancel();
            dashNav.ConfirmDashboard();
        }
    }
}