namespace IRONQA.GUIDES.SCENARIOS.REPORTS.TARGETS
{
    using IRONQA.GUIDES.SCENARIOS.REPORTS;
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
            //Setup the browser
            TestDetails env = new TestDetails(driver);
            env.GetTestEnvironment();
            driver = env.GetTestBrowser(TestDetails.Browsers.Firefox);
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
        [Category("Reports")]
        public void InspectionWorksheets()
        {
            Reports test = new Reports(driver);
            test.InspectionWorksheets();
        }

        [Test]
        [Category("Reports")]
        public void MyIronReports()
        {
            Reports test = new Reports(driver);
            test.MyIronReporting();
        }

        [Test]
        [Category("Reports")]
        public void MyIronResources()
        {
            Reports test = new Reports(driver);
            test.MyIronResources();
        }
    }
}
