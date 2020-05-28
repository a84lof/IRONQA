namespace IRONQA.GDM.SCENARIOS.ROLES.TARGETS
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
        [Category ("RolesMatrix")]
        public void EditSoldReport_Admin()
        {//Opens a SoldReport from the Report Grid and Adds a Manual Option
            RolesMatrix test = new RolesMatrix(driver);
            test.EditSoldReport_Admin();
        }

        [Test]
        [Category ("RolesMatrix")]
        public void EditSoldReport_Editor()
        {//Opens a SoldReport from the Report Grid and Adds a Manual Option
            RolesMatrix test = new RolesMatrix(driver);
            test.EditSoldReport_Editor();
        }

        [Test]
        [Category ("RolesMatrix")]
        public void EditSoldReport_Entry()
        {//Opens a SoldReport from the Report Grid and Adds a Manual Option
            RolesMatrix test = new RolesMatrix(driver);
            test.EditSoldReport_Entry();
        }

        [Test]
        [Category ("RolesMatrix")]
        public void EnterSoldReport_Admin()
        {//Uses Tab method to simulate actual entry procedure
            RolesMatrix test = new RolesMatrix(driver);
            test.EnterSoldReport_Admin();
        }

        [Test]
        [Category ("RolesMatrix")]
        public void EnterSoldReport_Editor()
        {//Uses Tab method to simulate actual entry procedure
            RolesMatrix test = new RolesMatrix(driver);
            test.EnterSoldReport_Editor();
        }

        [Test]
        [Category ("RolesMatrix")]
        public void EnterSoldReport_Entry()
        {//Uses Tab method to simulate actual entry procedure
            RolesMatrix test = new RolesMatrix(driver);
            test.EnterSoldReport_Entry();
        }

        [Test]
        [Category ("RolesMatrix")]
        public void ResolveDuplicates_Admin()
        {//Ensure resolve duplicates funcationlity is working.
            RolesMatrix test = new RolesMatrix(driver);
            test.ResolveDuplicates_Admin();
        }

        [Test]
        [Category ("RolesMatrix")]
        public void Calculate_ValuesManager_Admin()
        {//Ensures all pages are visible and editable
            RolesMatrix test = new RolesMatrix(driver);
            test.Calculate_ValuesManager_Admin();
        }

        [Test]
        [Category ("RolesMatrix")]
        public void Calculate_ValuesManager_Editor()
        {//Ensures all pages are visible and editable
            RolesMatrix test = new RolesMatrix(driver);
            test.Calculate_ValuesManager_Editor();
        }

        [Test]
        [Category ("RolesMatrix")]
        public void ViewAllPages()
        {//Confirms all pages are displayed in the app.
            RolesMatrix test = new RolesMatrix(driver);
            test.ViewAllPages();
        }
    }
}
