namespace IRONQA.GUIDES.SCENARIOS.HELPCENTER.TARGETS
{
    using IRONQA.GUIDES.SCENARIOS.HELPCENTER;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    [TestFixture]
    class Edge
    {
        private IWebDriver driver;

        [SetUp]
        public void StartTest()
        {
            // Setup the browser
            TestDetails env = new TestDetails(driver);
            env.GetTestEnvironment();
            driver = env.GetTestBrowser(TestDetails.Browsers.Edge);
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
        [Category("Help")]
        public void HelpCenter()
        {
            Help test = new Help(driver);
            test.HelpCenter();
        }

        [Test]
        [Category("Help")]
        public void ProvideFeedback()
        {
            Help test = new Help(driver);
            test.ProvideFeedback();
        }
    }
}
