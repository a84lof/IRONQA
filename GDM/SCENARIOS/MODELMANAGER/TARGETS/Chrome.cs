namespace IRONQA.GDM.SCENARIOS.MODELMANAGER.TARGETS
{
    using IRONQA.GDM.SCENARIOS.MODELMANAGER;
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
            driver.Navigate().GoToUrl(TestDetails.ModelManagerURL);
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
        public void OpenModelFromSideRail()
        {
            ModelManager test = new ModelManager(driver);
            test.OpenModelFromSideRail();
        }

        [Test]
        public void OpenModelFromHeaders()
        {
            ModelManager test = new ModelManager(driver);
            test.OpenModelFromHeaders();
        }

        [Test]
        public void AddNewModelYear()
        {
            ModelManager test = new ModelManager(driver);
            test.AddNewModelYear();
        }

        [Test]
        public void DeleteModelYear()
        {
            ModelManager test = new ModelManager(driver);
            test.DeleteModelYear();
        }

        [Test]
        public void AddOption()
        {
            ModelManager test = new ModelManager(driver);
            test.AddOption();
        }

        [Test]
        public void EditOptionOEMCode()
        {
            ModelManager test = new ModelManager(driver);
            test.EditOptionOEMCode();
        }

        [Test]
        public void EditOptionDescription()
        {
            ModelManager test = new ModelManager(driver);
            test.EditOptionDescription();
        }

        [Test]
        public void DeleteOption()
        {
            ModelManager test = new ModelManager(driver);
            test.DeleteOption();
        }

        [Test]
        public void EnterNewPriceNotesUS()
        {
            ModelManager test = new ModelManager(driver);
            test.EnterNewPriceNotesUS();
        }

        [Test]
        public void EnterNewPriceNotesCA()
        {
            ModelManager test = new ModelManager(driver);
            test.EnterNewPriceNotesCA();
        }

        [Test]
        public void EnterStdSpecNotes()
        {
            ModelManager test = new ModelManager(driver);
            test.EnterStdSpecNotes();
        }

        [Test]
        public void ClearNotes()
        {
            ModelManager test = new ModelManager(driver);
            test.ClearNotes();
        }
    }
}