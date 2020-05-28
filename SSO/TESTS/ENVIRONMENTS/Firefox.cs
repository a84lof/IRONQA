namespace IRONQA.SSO.TESTS.ENVIRONMENTS
{
    using IRONQA.SSO.TESTS.SCENARIOS;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    [TestFixture]
    class Firefox
    {
        private IWebDriver driver;

        [SetUp]
        public void StartTest()
        {
            TestDetails env = new TestDetails(driver);
            env.GetTestEnvironment();
            driver = env.GetTestBrowser(TestDetails.Browsers.Firefox);
            driver.Navigate().GoToUrl(TestDetails.SSOURL);
            // Start the test log
            // Start the test log
            Util.Log("\n"+DateTime.Now.ToString());
            Util.Log("Opened Browser & Navigated to URL");
            Util.Log("Opened Browser & Navigated to URL");
        }

        [TearDown]
        public void EndTest()
        {
            Util util = new Util(driver);
            util.CloseDriver();
        }

        [Test]
        public void MyAccount_USBasicAdmin()
        {// Confirm Account Page Elements Are Displayed
            Tests test = new Tests(driver);
            test.MyAccount_USBasicAdmin();
        }

        [Test]
        public void MyAccount_USBasicUser()
        {// Confirm Account Page Elements Are Displayed
            Tests test = new Tests(driver);
            test.MyAccount_USBasicUser();
        }

        [Test]
        public void PasswordError()
        {// Confirm Password Error Displayed
            Tests test = new Tests(driver);
            test.PasswordError();
        }

        [Test]
        public void ResetPassword()
        {// Confirm Reset Password Page Elements Are Displayed
            Tests test = new Tests(driver);
            test.PasswordReset();
        }

        [Test]
        public void Register()
        {
            Tests test = new Tests(driver);
            test.Register();
        }

        [Test]
        public void ConfirmGuidesPath()
        {
            Tests test = new Tests(driver);
            test.ConfirmGuidesPath();
        }

        [Test]
        public void ConfirmSearchListingsPath()
        {
            Tests test = new Tests(driver);
            test.ConfirmSearchListingsPath();
        }

        [Test]
        public void ConfirmAppraiserPath()
        {
            Tests test = new Tests(driver);
            test.ConfirmAppraiserPath();
        }

        [Test]
        public void ConfirmIncompleteAppraisalPath()
        {
            Tests test = new Tests(driver);
            test.ConfirmIncompleteAppraisalPath();
        }

        // [Test]
        // public void ConfirmDealerDashboardPath()
        // {
        //     Tests test = new Tests(driver);
        //     test.ConfirmDealerDashboardPath();
        // }

        [Test]
        public void ConfirmSerialNumberHandbookPath()
        {
            Tests test = new Tests(driver);
            test.ConfirmSerialNumberHandbookPath();
        }

        [Test]
        public void ConfirmTractorBuyersGuidePath()
        {
            Tests test = new Tests(driver);
            test.ConfirmTractorBuyersGuidePath();
        }

        [Test]
        public void ConfirmOutdoorPowerEquipmentGuidePath()
        {
            Tests test = new Tests(driver);
            test.ConfirmOutdoorPowerEquipmentGuidePath();
        }

        [Test]
        public void ConfirmFarmEquipmentBuyersGuidePath()
        {
            Tests test = new Tests(driver);
            test.ConfirmFarmEquipmentBuyersGuidesPath();
        }
    }
}
