namespace IRONQA.SSO.TESTS.SCENARIOS
{
    using IRONQA.FSBO.PAGES.APPRAISAL;
    using IRONQA.GUIDES.PAGES.DASHBOARD;
    using IRONQA.FSBO.PAGES.FORSALEBYOWNER;
    using IRONQA.SEARCH.PAGES;
    using IRONQA.SSO.PAGES;
    using IRONQA.STORE.PAGES.MYACCOUNT;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Tests
    {
        private IWebDriver driver;
        public Tests(IWebDriver _driver) => driver = _driver;

        public void ConfirmGuidesPath()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav myIron = sso.ClickIronGuides();
            myIron.ConfirmDashboard();
        }

        public void ConfirmAppraiserPath()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            AppraisalLanding appraisal = sso.ClickIronAppraiser();
            appraisal.ConfirmOnAppraiserPage();
        }

        public void ConfirmIncompleteAppraisalPath()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.FSBOUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            IncompleteAppraisals incomplete = sso.ClickViewMyIncompleteAppraisals();
            incomplete.ConfirmOnIncompleteAppraisalsPage();
        }

        // public void ConfirmDealerDashboardPath()
        // {
        //     Login login = new Login(driver);
        //     login.ConfirmOnLoginPage();
        //     Home sso = login.SubmitValidCredentials(Users.USBasicAdmin, Users.TestPassword);
        //     sso.ConfirmOnSSOHomePage();
        //     DealerDashboardLogin dashboard = sso.ClickManageInventory();
        //     dashboard.ConfirmOnDealerDashboardLoginPage();
        // }

        public void ConfirmForSaleByOwnerPath()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            Dashboard fsbo = sso.ClickForSaleByOwner();
            fsbo.ConfirmOnFSBODashboard();
        }

        public void ConfirmSearchListingsPath()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            Results results = sso.ClickViewMyListings();
            results.ConfirmResultsDisplayed();
        }

        public void ConfirmSerialNumberHandbookPath() //Blocked By IG-1202
        {
            // Login login = new Login(driver);
            // login.ConfirmOnLoginPage();
            // Home sso = login.SubmitValidCredentials(Users.USBasicUser, Users.IGPassword);
            // sso.ConfirmOnSSOHomePage();
            // PurchaseGuides guides = sso.ClickPurchaseSerialNumberHandbook();
            // guides.ConfirmOnSerialNumberHandbookPage();
        }

        public void ConfirmTractorBuyersGuidePath() //Blocked By IG-1202
        {
            // Login login = new Login(driver);
            // login.ConfirmOnLoginPage();
            // Home sso = login.SubmitValidCredentials(Users.USBasicUser, Users.IGPassword);
            // sso.ConfirmOnSSOHomePage();
            // PurchaseGuides guides = sso.ClickPurchaseBuyersGuideForTractors();
            // guides.ConfirmOnTractorGuidePage();
        }

        public void ConfirmOutdoorPowerEquipmentGuidePath() //Blocked By IG-1202
        {
            // Login login = new Login(driver);
            // login.ConfirmOnLoginPage();
            // Home sso = login.SubmitValidCredentials(Users.USBasicUser, Users.IGPassword);
            // sso.ConfirmOnSSOHomePage();
            // PurchaseGuides guides = sso.ClickPurchaseOutdoorPowerEquipmentGuide();
            // guides.ConfirmOnOPEGuidePage();
        }

        public void ConfirmFarmEquipmentBuyersGuidesPath() //Blocked By IG-1202
        {
            // Login login = new Login(driver);
            // login.ConfirmOnLoginPage();
            // Home sso = login.SubmitValidCredentials(Users.USBasicUser, Users.IGPassword);
            // sso.ConfirmOnSSOHomePage();
            // PurchaseGuides guides = sso.ClickPurchaseBuyersGuideForFarmEquipment();
            // guides.ConfirmOnFarmEquipmentGuidePage();
        }

        public void MyAccount_USBasicUser() // Blocked By IG-1202
        {// Confirm Profile Page
            // Login login = new Login(driver);
            // login.ConfirmOnLoginPage();
            // Home sso = login.SubmitValidCredentials(Users.USBasicUser, Users.IGPassword);
            // sso.ConfirmOnSSOHomePage();
            // Overview overview = sso.ClickMyAccount(); ;
            // overview.ConfirmOnOverviewPage();
        }

        public void MyAccount_USBasicAdmin() // Blocked By IG-1202
        {// Confirm Profile Page
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            Overview overview = sso.ClickMyAccount(); ;
            overview.ConfirmOnOverviewPage();
        }

        public void PasswordError()
        {// Confirm Password Error Displayed
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicUser, "User.Password"); //fail on purpose
            login.ConfirmPasswordError();
        }

        public void PasswordReset()
        {// Reset Password
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            PasswordReset reset = login.ClickForgotMyPassword();
            reset.ConfirmOnPasswordResetPage();
            reset.EnterEmail("Test@test.com");
            reset.ClickRecoverPassword();
            reset.ConfirmSuccessMessage();
        }

        public void Register()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            Registration registration = login.ClickRegister();
            registration.ConfirmOnRegistrationPage();
            registration.GetRandomEmail();
            registration.EnterEmail(Registration.RandomEmail);
            registration.EnterEmailAgain(Registration.RandomEmail);
            registration.EnterFirstName(Users.FirstName);
            registration.EnterLastName(Users.LastName);
            registration.EnterPhoneNumber(Users.PhoneNumber);
            registration.SelectCountry("CA");
            registration.ClickRegister();
            registration.ConfirmRegistrationSuccess();
        }
    }
}