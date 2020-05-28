namespace IRONQA.GUIDES.SCENARIOS.FORECASTS.TARGETS
{
    using IRONQA.GUIDES.SCENARIOS.FORECASTS;
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
        [Category("Forecast")]
        public void ForecastSingleItemValuation_CANAdmin()
        {
            Forecast test = new Forecast(driver);
            test.ForecastSingleItemValuation_CANAdmin();
        }

        [Test]
        [Category("Forecast")]
        public void ForecastSingleItemValuation_CANUser()
        {
            Forecast test = new Forecast(driver);
            test.ForecastSingleItemValuation_CANUser();
        }

        [Test]
        [Category("Forecast")]
        public void ForecastSingleItemValuation_USAdmin()
        {
            Forecast test = new Forecast(driver);
            test.ForecastSingleItemValuation_USAdmin();
        }

        [Test]
        [Category("Forecast")]
        public void ForecastSingleItemValuation_USUser()
        {
            Forecast test = new Forecast(driver);
            test.ForecastSingleItemValuation_USUser();
        }
    }
}