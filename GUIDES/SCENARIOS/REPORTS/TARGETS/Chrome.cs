namespace IRONQA.GUIDES.SCENARIOS.REPORTS.TARGETS
{
    using IRONQA.GUIDES.SCENARIOS.REPORTS;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    [TestFixture]
    class Chrome
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
            Util.Log("End Of Test.");
        }

        [Test]
        [Category("Reporting")]
        public void InspectionWorksheets()
        {
            Reports test = new Reports(driver);
            test.InspectionWorksheets();
        }

        [Test]
        [Category("Reporting")]
        public void MyIronReporting()
        {
            Reports test = new Reports(driver);
            test.MyIronReporting();
        }

        [Test]
        [Category("Reporting")]
        public void MyIronResources()
        {
            Reports test = new Reports(driver);
            test.MyIronResources();
        }
    }
}
