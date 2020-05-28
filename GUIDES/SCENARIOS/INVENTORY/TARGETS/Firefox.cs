namespace IRONQA.GUIDES.SCENARIOS.INVENTORY.TARGETS
{
    using IRONQA.GUIDES.SCENARIOS.INVENTORY;
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
        [Category("Inventory")]
        public void ConfirmEquipmentTabs_MultiLocAdmin()
        {
            Inventory test = new Inventory(driver);
            test.ConfirmEquipmentTabs_MultiLocAdmin();
        }

        [Test]
        [Category("Inventory")]
        public void ConfirmEquipmentTabs_SingleLocAdmin()
        {
            Inventory test = new Inventory(driver);
            test.ConfirmEquipmentTabs_SingleLocAdmin();
        }

        [Test] 
        [Category("Inventory")]
        public void ConfirmStandardSpecs()
        {
            Inventory test = new Inventory(driver);
            test.ConfirmStandardSpecs();
        }

        [Test]
        [Category("Inventory")]
        public void EditEquipment()
        {
            Inventory test = new Inventory(driver);
            test.EditEquipment();
        }
    }
}
