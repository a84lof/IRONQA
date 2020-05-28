namespace IRONQA.SEARCH.TESTS.ENVIRONMENTS
{
    using IRONQA.SEARCH.TESTS.SCENARIOS;
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
            TestDetails env = new TestDetails(driver);
            env.GetTestEnvironment();
            driver = env.GetTestBrowser(TestDetails.Browsers.Firefox);
            driver.Navigate().GoToUrl(TestDetails.SearchURL);
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
        public void CompareListings()
        {
            Tests test = new Tests(driver);
            test.CompareListings();
        }

        [Test]
        public void DetailsInfo()
        {// Confirm expected information on TestOps page
            Tests test = new Tests(driver);
            test.DetailsInfo();
        }

        [Test]
        public void SimilarListingsFoundMsg()
        {// Similar Listings Found Message
            Tests test = new Tests(driver);
            test.SimilarListingsFoundMsg();
        }

        [Test]
        public void FilterCategory()
        {// Filter By Category
            Tests test = new Tests(driver);
            test.FilterCategory();
        }

        [Test]
        public void FilterMake()
        {// Filter By Make
            Tests test = new Tests(driver);
            test.FilterMake();
        }

        [Test]
        public void FilterModel()
        {// Filter By Model
            Tests test = new Tests(driver);
            test.FilterModel();
        }

        [Test]
        public void FilterType()
        {// Filter By Type
            Tests test = new Tests(driver);
            test.FilterType();
        }

        [Test]
        public void FilterYear()
        {// Filter Listings by Equipment Year 
            Tests test = new Tests(driver);
            test.FilterYear();
        }

        [Test]
        public void FilterTags()
        {// Confirm presence of filter tags
            Tests test = new Tests(driver);
            test.FilterTags();
        }

        [Test]
        public void LocateADealer()
        {// Search dealers in given location
            Tests test = new Tests(driver);
            test.LocateADealer();
        }

        [Test]
        public void PerformKeywordSearch()
        {// Confirm Keyword Search Functionality
            Tests test = new Tests(driver);
            test.PerformKeywordSearch();
        }

        [Test]
        public void PersistAdvancedSearchCriteria()
        {// Confirm advanced search info persists to Results
            Tests test = new Tests(driver);
            test.PersistAdvancedSearchCriteria();
        }

        [Test]
        public void SortResults()
        {// Sort By: Distance(s) Near & Far
            Tests test = new Tests(driver);
            test.SortResults();
        }
    }
}