namespace IRONQA.GDM.SCENARIOS.VALUES.TARGETS
{
    using IRONQA.GDM.SCENARIOS.VALUES;
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
        [Category ("Compare Values")]
        public void BaseValuesComparison_USD()
        {//Compare Region F RGV, Lineage 3yo Base Model, BMV 3yo Base Model, and GV Prepublished values.
            ValuesComparison test = new ValuesComparison(driver);
            test.BaseValuesComparison_USD();
        }

        [Test]
        [Category ("Compare Values")]
        public void BaseValuesComparison_CAD()
        {//Compare Region F across RGV, Lineage 3yo Base Model, BMV 3yo Base Model, and GV PrePublished values.
            ValuesComparison test = new ValuesComparison(driver);
            test.BaseValuesComparison_CAD();
        }

        [Test]
        [Category ("Other")]
        public void BMV_EditBaseModel()
        {//Confirms Base Model Valuation Table Changes
            ValuesAdjust test = new ValuesAdjust(driver);
            test.BMV_EditBaseModel();
        }

        [Test]
        [Category ("Other")]
        public void BMV_EditComparableModel()
        {//Confirms Base Model Valuation Table Changes
            ValuesAdjust test = new ValuesAdjust(driver);
            test.BMV_EditComparableModel();
        }

        [Test]
        [Category ("Compare Values")]
        public void ComparableValuesComparison()
        {//Compare RGV Region D, Lineage 3yo Base Model, and BMV 3yo Base Model default values.
            ValuesComparison test = new ValuesComparison(driver);
            test.ComparableValuesComparison();
        }

        [Test]
        [Category ("Compare Values")]
        public void CompareLVToRV_RegionA()
        {//Compare Region specific data on LV to RV
            ValuesComparison test = new ValuesComparison(driver);
            test.CompareLVToRV_RegionA();
        }

        [Test]
        [Category ("Compare Values")]
        public void CompareLVToRV_RegionB()
        {//Compare Region specific data on LV to RV
            ValuesComparison test = new ValuesComparison(driver);
            test.CompareLVToRV_RegionB();
        }

        [Test]
        [Category ("Compare Values")]
        public void CompareLVToRV_RegionC()
        {//Compare Region specific data on LV to RV
            ValuesComparison test = new ValuesComparison(driver);
            test.CompareLVToRV_RegionC();
        }

        [Test]
        [Category ("Compare Values")]
        public void CompareLVToRV_RegionD()
        {//Compare Region specific data on LV to RV
            ValuesComparison test = new ValuesComparison(driver);
            test.CompareLVToRV_RegionD();
        }

        [Test]
        [Category ("Compare Values")]
        public void CompareLVToRV_RegionE()
        {//Compare Region specific data on LV to RV
            ValuesComparison test = new ValuesComparison(driver);
            test.CompareLVToRV_RegionE();
        }

        [Test]
        [Category ("Compare Values")]
        public void CompareLVToRV_RegionF()
        {//Compare Region specific data on LV to RV
            ValuesComparison test = new ValuesComparison(driver);
            test.CompareLVToRV_RegionF();
        }

        [Test]
        [Category ("Compare Values")]
        public void CompareLVToRV_RegionG()
        {//Compare Region specific data on LV to RV
            ValuesComparison test = new ValuesComparison(driver);
            test.CompareLVToRV_RegionG();
        }

        [Test]
        [Category ("Confirm AG Lineages")]
        public void ConfirmAGLineages_RegionA()
        {//Confirms values are displayed for all lineages, AG Region A 
            Staging test = new Staging(driver);
            test.ConfirmAGLineages_RegionA();
        }

        [Test]
        [Category ("Confirm AG Lineages")]
        public void ConfirmAGLineages_RegionB()
        {//Confirms values are displayed for all lineages, AG Region B
            Staging test = new Staging(driver);
            test.ConfirmAGLineages_RegionB();
        }

        [Test]
        [Category ("Confirm AG Lineages")]
        public void ConfirmAGLineages_RegionC()
        {//Confirms values are displayed for all lineages, AG Region C
            Staging test = new Staging(driver);
            test.ConfirmAGLineages_RegionC();
        }

        [Test]
        [Category ("Confirm AG Lineages")]
        public void ConfirmAGLineages_RegionD()
        {//Confirms values are displayed for all lineages, AG Region D
            Staging test = new Staging(driver);
            test.ConfirmAGLineages_RegionD();
        }

        [Test]
        [Category ("Confirm AG Lineages")]
        public void ConfirmAGLineages_RegionE()
        {//Confirms values are displayed for all lineages, AG Region E
            Staging test = new Staging(driver);
            test.ConfirmAGLineages_RegionE();
        }

        [Test]
        [Category ("Confirm AG Lineages")]
        public void ConfirmAGLineages_RegionF()
        {//Confirms values are displayed for all lineages, AG Region F
            Staging test = new Staging(driver);
            test.ConfirmAGLineages_RegionF();
        }

        [Test]
        [Category ("Confirm AG Lineages")]
        public void ConfirmAGLineages_RegionG()
        {//Confirms values are displayed for all lineages, AG Region G
            Staging test = new Staging(driver);
            test.ConfirmAGLineages_RegionG();
        }

        [Test]
        [Category ("Confirm CE Lineages")]
        public void ConfirmCELineages_RegionA()
        {//Confirms values are displayed for all lineages, CE Region A
            Staging test = new Staging(driver);
            test.ConfirmCELineages_RegionA();
        }

        [Test]
        [Category ("Confirm CE Lineages")]
        public void ConfirmCELineages_RegionB()
        {//Confirms values are displayed for all lineages, CE Region B
            Staging test = new Staging(driver);
            test.ConfirmCELineages_RegionB();
        }

        [Test]
        [Category ("Confirm CE Lineages")]
        public void ConfirmCELineages_RegionC()
        {//Confirms values are displayed for all lineages, CE Region C
            Staging test = new Staging(driver);
            test.ConfirmCELineages_RegionC();
        }

        [Test]
        [Category ("Confirm CE Lineages")]
        public void ConfirmCELineages_RegionD()
        {//Confirms values are displayed for all lineages, CE Region D
            Staging test = new Staging(driver);
            test.ConfirmCELineages_RegionD();
        }

        [Test]
        [Category ("Other")]
        public void PrepublishValuationGroup()
        {//Ensure prepublishing displayes calculated values on Guide Validation page.
            Staging test = new Staging(driver);
            test.PrepublishValuationGroup();
        }
    }
}
