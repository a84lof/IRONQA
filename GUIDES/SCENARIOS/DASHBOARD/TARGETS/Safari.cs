namespace IRONQA.GUIDES.SCENARIOS.DASHBOARD.TARGETS
{
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    [TestFixture]
    class Safari
    {
        private IWebDriver driver;

        [SetUp]
        public void StartTest()
        {
            // Setup the browser
            TestDetails env = new TestDetails(driver);
            env.GetTestEnvironment();
            driver = env.GetTestBrowser(TestDetails.Browsers.Chrome);
            driver.Navigate().GoToUrl(TestDetails.SSOURL);
            // Start the test log
            Util.Log("\n"+DateTime.Now.ToString());
            Util.Log("Opened Browser & Navigated to URL");
        }

        [TearDown]
        public void EndTest()
        {
            Util util = new Util(driver);
            util.CloseDriver();
        }

        [Test]
        [Category("Dashboard")]
        public void MyIronFilters()
        {
            Dashboard test = new Dashboard(driver);
            test.MyIronFilters();
        }

        [Test]
        [Category("Dashboard")]
        public void MyIronNews()
        {
            Dashboard test = new Dashboard(driver);
            test.MyIronNews();
        }
    }
}