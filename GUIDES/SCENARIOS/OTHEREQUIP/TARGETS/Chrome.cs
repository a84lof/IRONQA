namespace IRONQA.GUIDES.SCENARIOS.OTHEREQUIP.TARGETS
{
    using IRONQA.GUIDES.SCENARIOS.OTHEREQUIP;
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
        }

        [Test]
        [Category("OtherEquipment")]
        public void OtherEquipmentSearch()
        {
            OtherEquip test = new OtherEquip(driver);
            test.OtherEquipmentSearch();
        }
    }
}