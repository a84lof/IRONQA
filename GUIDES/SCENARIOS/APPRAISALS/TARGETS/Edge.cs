namespace IRONQA.GUIDES.SCENARIOS.APPRAISAL.TARGETS
{
    using IRONQA.GUIDES.SCENARIOS.APPRAISALS;
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
        }

        [Test]
        [Category("OtherAppraisals")]
        public void AddCustomOptionToAppraisal()
        {
            Appraisal test = new Appraisal(driver);
            test.AddCustomOptionsToAppraisal();
        }

        [Test]
        [Category("OtherAppraisals")]
        public void AddProspectToAppraisal()
        {
            Appraisal test = new Appraisal(driver);
            test.AddProspectToAppraisal();
        }

        [Test]
        [Category("AGAppraisals")]
        public void AGAppraisal_BasicAdmin()
        {
            Appraisal test = new Appraisal(driver);
            test.AGAppraisal_BasicAdmin();
        }

        [Test]
        [Category("AGAppraisals")]
        public void AGAppraisal_BasicUser()
        {
            Appraisal test = new Appraisal(driver);
            test.AGAppraisal_BasicUser();
        }

        [Test]
        [Category("AGAppraisals")]
        public void AGAppraisal_PlusAdmin()
        {
            Appraisal test = new Appraisal(driver);
            test.AGAppraisal_PlusAdmin();
        }

        [Test]
        [Category("AGAppraisals")]
        public void AGAppraisal_PlusUser()
        {
            Appraisal test = new Appraisal(driver);
            test.AGAppraisal_PlusUser();
        }

        [Test]
        [Category("AGAppraisals")]
        public void AGAppraisal_ProAdmin()
        {
            Appraisal test = new Appraisal(driver);
            test.AGAppraisal_ProAdmin();
        }

        [Test]
        [Category("AGAppraisals")]
        public void AGAppraisal_ProUser()
        {
            Appraisal test = new Appraisal(driver);
            test.AGAppraisal_ProUser();
        }

        [Test]
        [Category("AGAppraisals")]
        [Category("OPEAppraisals")]
        public void EditAppraisal_Plus()
        {
            Appraisal test = new Appraisal(driver);
            test.EditAppraisal_Plus();
        }

        [Test]
        [Category("AGAppraisals")]
        [Category("OPEAppraisals")]
        public void EditAppraisal_Pro()
        {
            Appraisal test = new Appraisal(driver);
            test.EditAppraisal_Pro();
        }

        [Test]
        [Category("OtherAppraisals")]
        public void ISBGAppraisal()
        {
            Appraisal test = new Appraisal(driver);
            test.ISBGAppraisal();
        }

        [Test]
        [Category("OPEAppraisals")]
        public void OPEAppraisal_BasicAdmin()
        {
            Appraisal test = new Appraisal(driver);
            test.OPEAppraisal_BasicAdmin();
        }

        [Test]
        [Category("OPEAppraisals")]
        public void OPEAppraisal_BasicUser()
        {
            Appraisal test = new Appraisal(driver);
            test.OPEAppraisal_BasicUser();
        }

        [Test]
        [Category("OPEAppraisals")]
        public void OPEAppraisal_PlusAdmin()
        {
            Appraisal test = new Appraisal(driver);
            test.OPEAppraisal_PlusAdmin();
        }

        [Test]
        [Category("OPEAppraisals")]
        public void OPEAppraisal_PlusUser()
        {
            Appraisal test = new Appraisal(driver);
            test.OPEAppraisal_PlusUser();
        }

        [Test]
        [Category("OPEAppraisals")]
        public void OPEAppraisal_ProAdmin()
        {
            Appraisal test = new Appraisal(driver);
            test.OPEAppraisal_ProAdmin();
        }

        [Test]
        [Category("OPEAppraisals")]
        public void OPEAppraisal_ProUser()
        {
            Appraisal test = new Appraisal(driver);
            test.OPEAppraisal_ProUser();
        }

        [Test]
        [Category("OtherAppraisals")]
        public void UpgradeAppraisal_BasicAdmin()
        {
            Appraisal test = new Appraisal(driver);
            test.UpgradeAppraisal_BasicAdmin();
        }

        [Test]
        [Category("OtherAppraisals")]
        public void UpgradeAppraisal_BasicUser()
        {
            Appraisal test = new Appraisal(driver);
            test.UpgradeAppraisal_BasicUser();
        }

        [Test]
        [Category("OtherAppraisals")]
        public void UpgradeAppraisal_PlusAdmin()
        {
            Appraisal test = new Appraisal(driver);
            test.UpgradeAppraisal_PlusAdmin();
        }

        [Test]
        [Category("OtherAppraisals")]
        public void UpgradeAppraisal_PlusUser()
        {
            Appraisal test = new Appraisal(driver);
            test.UpgradeAppraisal_PlusUser();
        }

        [Test]
        [Category("OtherAppraisals")]
        public void UpgradeAppraisal_ProAdmin()
        {
            Appraisal test = new Appraisal(driver);
            test.UpgradeAppraisal_ProAdmin();
        }

        [Test]
        [Category("OtherAppraisals")]
        public void UpgradeAppraisal_ProUser()
        {
            Appraisal test = new Appraisal(driver);
            test.UpgradeAppraisal_ProUser();
        }

        [Test]
        [Category("OtherAppraisals")]
        public void SubmitAppraisalToUSInventory()
        {
            Appraisal test = new Appraisal(driver);
            test.SubmitAppraisalToUSInventory();
        }

        [Test]
        [Category("OtherAppraisals")]
        public void SubmitAppraisalToCanadianInventory()
        {
            Appraisal test = new Appraisal(driver);
            test.SubmitAppraisalToCanadianInventory();
        }

        [Test]
        [Category("OtherAppraisals")]
        public void TradeGuideVariableUsage()
        {
            Appraisal test = new Appraisal(driver);
            test.TradeGuideVariableUsage();
        }
    }
}
