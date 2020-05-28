namespace IRONQA.GUIDES.SCENARIOS.REPORTS
{
    using IRONQA.GUIDES.PAGES.APPRAISAL;
    using IRONQA.GUIDES.PAGES.DASHBOARD;
    using IRONQA.GUIDES.PAGES.SHARED;
    using IRONQA.SSO.PAGES;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Reports
    {
        private IWebDriver driver;
        public Reports(IWebDriver _driver) => driver = _driver;

        public void InspectionWorksheets()
        {// Download Blank Inspection Worksheets
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickAgricultureEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USAGRegion);
            step1.SelectType(TestDetails.AGType);
            step1.SelectMake(TestDetails.AGMake);
            step1.SelectModel(TestDetails.AGModel);
            step1.ClickYear(TestDetails.AGYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            AppraisalNav aNav = new AppraisalNav(driver);
            InspectionWorksheet worksheet = aNav.ClickInspectionWorksheet();
            worksheet.ConfirmOnInspectionWorksheetPage();
            worksheet.ConfirmBlankInspectionWorksheets();
            worksheet.ClickContinueAppraisal();
            step2.ConfirmOnStep2();
            // Go back to My Iron
            guidesNav.ClickDashboard();
            Util util = new Util(driver);
            util.DismissAlert();
            dashNav.ConfirmDashboard();
            dashNav.ClickMySavedAppraisals();
            SavedAppraisals saved = new SavedAppraisals(driver);
            saved.ConfirmAppraisalDisplayed("Model", TestDetails.AGModel);
        }

        public void MyIronReporting()
        {// Confirm Reporting Tab PDFs and XLS
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            Reporting reporting = dashNav.ClickReporting();
            reporting.VerifyPrintableReportingPDFs();
        }

        public void MyIronResources()
        {// Confirm Resources Tab PDFs
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USPlusUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            Resources resources = dashNav.ClickResources();
            resources.VerifyPrintableResourcesPDFs();
        }
    }
}