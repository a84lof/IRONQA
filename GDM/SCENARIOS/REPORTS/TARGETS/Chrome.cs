namespace IRONQA.GDM.SCENARIOS.REPORTS.TARGETS
{
    using IRONQA.GDM.SCENARIOS.REPORTS;
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
            TestDetails env = new TestDetails(driver);
            env.GetTestEnvironment();
            driver = env.GetTestBrowser(TestDetails.Browsers.Chrome);
            driver.Navigate().GoToUrl(TestDetails.GDMURL);
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
        [Category ("Report Edit")]
        public void EditSoldReport()
        {//Opens a SoldReport from the Report Grid and Adds a Manual Option
            Reporting test = new Reporting(driver);
            test.EditSoldReport();
        }

        [Test]
        [Category ("Report Entry")]
        public void EnterSoldReport_Combine()
        {//Uses Tab method to simulate actual entry procedure
            Reporting test = new Reporting(driver);
            test.EnterSoldReport_Combine();
        }

        [Test]
        [Category ("Report Entry")]
        public void EnterSoldReport_SkidSteerLoader()
        {//Uses Tab method to simulate actual entry procedure
            Reporting test = new Reporting(driver);
            test.EnterSoldReport_SkidSteerLoader();
        }

        [Test]
        [Category("Report Entry")]
        public void LoadEnteredSoldReport()
        {// Enter a sold report and then open it from the Save Success link.
            Reporting test = new Reporting(driver);
            test.LoadEnteredSoldReport();
        }

        [Test]
        [Category ("Report Duplicates")]
        public void ResolveDuplicates()
        {//Ensure resolve duplicates funcationlity is working.
            Reporting test = new Reporting(driver);
            test.ResolveDuplicates();
        }
    }
}
