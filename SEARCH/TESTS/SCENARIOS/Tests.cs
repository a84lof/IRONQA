namespace IRONQA.SEARCH.TESTS.SCENARIOS
{
    using IRONQA.SEARCH.PAGES;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;
    
    public class Tests
    {
        private IWebDriver driver;
        public Tests(IWebDriver _driver) => driver = _driver;

        public void CompareListings()
        {// Compare two equipment listings
            Landing landing = new Landing(driver);
            landing.ConfirmOnSearchPage();
            Results results = landing.ClickManufacturer("Caterpillar");
            results.ConfirmOnListingsPage();
            results.ClickAddToCompare();
            Compare compare = results.ClickViewComparison();
            compare.ConfirmOnComparePage();
        }

        public void DetailsInfo()
        {// Confirm expected information on dealer and fsbo details pages
            Landing landing = new Landing(driver);
            landing.ConfirmOnSearchPage();
            Results results = landing.ClickManufacturer("John-Deere");
            results.ConfirmOnListingsPage();
            ListingDetails details = results.ClickViewDetails();
            details.ConfirmOnDetailsPage();
        }

        public void SimilarListingsFoundMsg()
        {// Similar Listings Found Message
            Landing landing = new Landing(driver);
            landing.ConfirmOnSearchPage();
            driver.Navigate().GoToUrl(TestDetails.SearchURL + "/equipment/manufacturers/john-deere?ModelPartial=1020j&TypeCode=TR");
            Results results = new Results(driver);
            results.ConfirmSimilarListingsFound();
        }

        public void FilterCategory()
        {// Filter By Category
            Landing landing = new Landing(driver);
            // Starting on the search page
            landing.ConfirmOnSearchPage();
            Results results = landing.ClickManufacturer("John-Deere");
            results.ConfirmOnListingsPage();
            results.EnterCategory("Crop care");
            results.ConfirmFilterTags("Crop care");
        }

        public void FilterMake()
        {// Filter By Make
            Landing landing = new Landing(driver);
            landing.ConfirmOnSearchPage();
            Results results = landing.ClickEquipmentType("Tractor");
            results.ConfirmOnListingsPage();
            results.EnterMake("AGCO");
            results.ConfirmFilterTags("AGCO");
        }

        public void FilterModel()
        {// Filter By Make
            Landing landing = new Landing(driver);
            landing.ConfirmOnSearchPage();
            Results results = landing.ClickManufacturer("John-Deere");
            results.ConfirmOnListingsPage();
            results.EnterModel("4455");
            results.ConfirmFilterTags("4455");
        }

        public void FilterType()
        {// Filter By Type
            Landing landing = new Landing(driver);
            landing.ConfirmOnSearchPage();
            Results results = landing.ClickManufacturer("Combine");
            results.ConfirmOnListingsPage();
            results.ConfirmFilterTags("Combine");
        }

        public void FilterYear()
        {// Filter Listings by Equipment Year Min
            Landing landing = new Landing(driver);
            landing.ConfirmOnSearchPage();
            Results results = landing.ClickManufacturer("Caterpillar");
            results.ConfirmOnListingsPage();
            results.EnterYearMin("2000");
            results.EnterYearMax("2010");
        }

        public void FilterTags()
        {// Confirm presence of Keyword, Condition, Make, Model, Type, 
         // Min/Max Year Range, Identical Min/Max Year Range, Normal Min/Max Year Range
         // Min/Max Price Range, Identical Min/Max Price Range, Normal Min/Max Price Range
         // & Date Range tags
            Landing landing = new Landing(driver);
            landing.ConfirmOnSearchPage();
            Results results = landing.ClickManufacturer("John-Deere");
            results.ConfirmOnListingsPage();
            //Model
            results.EnterModel("1023E");
            //Year
            results.EnterYearMin("2012");
            results.EnterYearMax("2012");
            //Price
            results.EnterPriceMin("10000");
            results.EnterPriceMax("100001");
            results.EnterPriceMin("1");
        }

        public void LocateADealer()
        {// Confirm Locate-A-Dealer Elementss Are Displayed
            Landing landing = new Landing(driver);
            landing.ConfirmOnSearchPage();
            SearchNav nav = new SearchNav(driver);
            DealerLocator dealerLocator = nav.ClickLocateADealer();
            dealerLocator.ConfirmOnDealerLocatorPage();
            dealerLocator.VerifyInitialObjectsDisplayed(); // Initial Page
            dealerLocator.EnterInitialLocation("38401");
            dealerLocator.VerifyRemainingObjectsDisplayed(); // Second Page
        }

        public void PerformKeywordSearch()
        {// Confirm Keyword Search Functionality
            Landing landing = new Landing(driver);
            landing.ConfirmOnSearchPage();
            Results results = landing.EnterKeywordSearch("John Deere Tractor");
            results.ConfirmOnListingsPage();
            results.ConfirmFilterTags("Keyword");
        }

        public void PersistAdvancedSearchCriteria() //Blocked by IS-1190
        {// Confirm Zip is Carried to Listings Page
            // Landing landing = new Landing(driver);
            // landing.ConfirmOnSearchPage();
            // AdvancedSearch advancedSearch = landing.ClickAdvancedSearch();
            // advancedSearch.ConfirmOnAdvancedSearchPage();
            // advancedSearch.ClickCategoriesTab();
            // advancedSearch.ClickPopularCategory("Tractors");
            // advancedSearch.EnterEquipmentType("Tractor");
            // advancedSearch.EnterManufacturer("John Deere");
            // advancedSearch.EnterModelNumber("4400");
            // advancedSearch.EnterLocation("37067");
            // Results results = advancedSearch.ClickGo();
            // results.ConfirmOnListingsPage();
            // results.ConfirmLocation("37067");
            // results.ConfirmCategory("Tractors");
            // results.ConfirmType("Tractor");
            // results.ConfirmManufacturer("John Deere");
            // results.ConfirmModel("4400");
        }

        public void SortResults()
        {// Sort By: Date Updated Newest & Oldest
            Landing landing = new Landing(driver);
            landing.ConfirmOnSearchPage();
            Results results = landing.ClickManufacturer("John-Deere");
            results.ConfirmOnListingsPage();
            results.ConfirmManufacturerSelectorContains("John Deere");
            //Date updated
            results.SortByDateUpdatedNewToOld();
            results.SortByDateUpdatedOldToNew();
            //Distance
            results.SortByDistanceNearToFar();
            results.SortByDistanceFarToNear();
            //Model
            results.SortByModelAsc();
            results.SortByModelDesc();
            //Price
            results.SortByPriceAsc();
            results.SortByPriceDesc();
            //Usage
            results.SortByUsageAsc();
            results.SortByUsageDesc();
        }
    }
}