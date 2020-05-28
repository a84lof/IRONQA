namespace IRONQA.NETSUITE.TESTS.ENVIRONMENTS
{
    using System;
    using IRONQA.NETSUITE.TESTS.SCENARIOS;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;

    [TestFixture]
    public class Chrome
    {
        private IWebDriver driver;

        [SetUp]
        public void StartTest()
        {
            TestDetails env = new TestDetails(driver);
            env.GetTestEnvironment();
            driver = env.GetTestBrowser(TestDetails.Browsers.Chrome);
            driver.Navigate().GoToUrl(TestDetails.NSURL);
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
        public void Login()
        {
            HQ test = new HQ(driver);
            test.Login();
        }
    }
}