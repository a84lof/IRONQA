namespace IRONQA.SEARCH.PAGES
{
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class Results
    {
        private IWebDriver driver;
        public Results(IWebDriver _driver) => driver = _driver;
        private IWebElement RefineSearch => driver.FindElement(By.XPath("//*[contains(@class,'refine-search-results')]"));
        private IWebElement ViewResults => driver.FindElement(By.XPath("//*[contains(text(),'View Results')]"));
        private IWebElement Breadcrumb => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > nav > ul > li:nth-child(1) > a"));
        private IWebElement LocationValue => driver.FindElement(By.CssSelector("#react-select-3--value-item"));
        private IWebElement LocationInput => driver.FindElement(By.CssSelector("#react-select-3--value > div.Select-input > input"));
        private IWebElement RangeWrapper => driver.FindElement(By.Id("large-distance-selector-wrapper"));
        private IWebElement Range => driver.FindElement(By.CssSelector("#large-distance-input"));
        private IWebElement RangeSlider => driver.FindElement(By.ClassName("rangeslider__fill"));
        private IWebElement Category => driver.FindElement(By.Id("react-select-4--value"));
        private IWebElement CategoryValue => driver.FindElement(By.CssSelector("#react-select-4--value-item"));
        private IWebElement CategoryInput => driver.FindElement(By.CssSelector("#react-select-4--value > div.Select-input > input"));
        private IWebElement ClearCategory => driver.FindElement(By.CssSelector("#large-category-selector > div > div > span.Select-clear-zone"));
        private IWebElement Type => driver.FindElement(By.Id("react-select-5--value"));
        private IWebElement TypeValue => driver.FindElement(By.CssSelector("#react-select-5--value"));
        private IWebElement TypeInput => driver.FindElement(By.CssSelector("#react-select-5--value > div.Select-input > input"));
        private IWebElement ClearType => driver.FindElement(By.CssSelector("#large-type-selector > div > div > span.Select-clear-zone"));
        private IWebElement Manufacturer => driver.FindElement(By.Id("react-select-6--value-item"));
        private IWebElement ManufacturerValue => driver.FindElement(By.CssSelector("#react-select-6--value-item"));
        private IWebElement ManufacturerInput => driver.FindElement(By.CssSelector("#react-select-6--value > div.Select-input > input"));
        private IWebElement ManufacturerClear => driver.FindElement(By.CssSelector("#large-manufacturer-selector > div > div > span.Select-clear-zone > span"));
        private IWebElement Model => driver.FindElement(By.Id("react-select-7--value"));
        private IWebElement ModelValue => driver.FindElement(By.CssSelector("#react-select-7--value-item"));
        private IWebElement ModelInput => driver.FindElement(By.CssSelector("#react-select-7--value > div.Select-input > input"));
        private IWebElement ModelTags => driver.FindElement(By.ClassName("tags-title"));
        private IWebElement ModelTagX => driver.FindElement(By.CssSelector("#model-tag-3 > span.tag-close-icon > i"));
        private IWebElement ClearModel => driver.FindElement(By.CssSelector("#large-model-selector > div > div > span.Select-clear-zone > span"));
        private IWebElement YearMin => driver.FindElement(By.Id("large-year-min-input"));
        private IWebElement YearMax => driver.FindElement(By.Id("large-year-max-input"));
        private IWebElement PriceMin => driver.FindElement(By.Id("large-price-min-input"));
        private IWebElement PriceMax => driver.FindElement(By.Id("large-price-max-input"));
        private IWebElement OptionKeyword => driver.FindElement(By.CssSelector("#large-option-input"));
        private IWebElement AnyKeyword => driver.FindElement(By.CssSelector("#nav-search-input"));
        private IWebElement UsedOrNew => driver.FindElement(By.Id("large-inventory-type-selector"));
        private IWebElement UpdateResults => driver.FindElement(By.Id("large-update-results"));
        private IWebElement ViewDetails => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.cell.container--search-results > div > ul > li.listing-0 > a"));
        private IWebElement AddToCompare => driver.FindElement(By.XPath("//*[@id='search-results-react-root']/div/main/div/div/div[1]/div/ul/li[1]/div"));
        private IWebElement ComparedImage => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.cell.container--search-results > div > div.color-wrapper > div.tags-sort-compare-wrapper > aside.search-results__compare > ul > li > a"));
        private IWebElement ViewComparison => driver.FindElement(By.XPath("//*[contains(@class,'button--compare')]"));
        private IWebElement ManufacturerHeader => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.section--search-results.large-8.cell > h4 > span"));
        private IWebElement ItemDetails => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.section--search-results.large-8.cell > ul > li:nth-child(1) > a > div:nth-child(2)"));
        private IWebElement SimilarListingsFound => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.cell.container--search-results > div > div:nth-child(3) > div"));
        private IWebElement NoListingsFound => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.cell.container--search-results > div > div:nth-child(3) > div"));
        private IWebElement ListingInfo_NewOrUsed => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.large-9.cell > div > ul > li.listing-0 > a > div.wrapper.desc-0 > h5"));
        private IWebElement ListingInfo4 => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.cell.container--search-results > div > ul > li.listing-0 > a > div:nth-child(3) > p:nth-child(3) > span"));
        private IWebElement ListingInfo5 => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.cell.container--search-results > div > ul > li.listing-0 > a > div.wrapper.desc-0 > p:nth-child(5) > span"));
        private IWebElement FilterTags => driver.FindElement(By.CssSelector("#search-filter-tags > span"));
        private IWebElement FilterTagX => driver.FindElement(By.CssSelector("#tag-0 > span.tag-close-icon > i"));
        private IWebElement SortSelector => driver.FindElement(By.Id("sort-selector"));
        private IWebElement BestMatch => driver.FindElement(By.Id("BestMatch-true"));
        private IWebElement YearLatestToEarliest => driver.FindElement(By.Id("Year-false"));
        private IWebElement YearEarliestToLatest => driver.FindElement(By.Id("Year-true"));
        private IWebElement DistanceNearToFar => driver.FindElement(By.Id("Distance-true"));
        private IWebElement DistanceFarToNear => driver.FindElement(By.Id("Distance-false"));
        private IWebElement PriceLowToHigh => driver.FindElement(By.Id("Price-true"));
        private IWebElement PriceHighToLow => driver.FindElement(By.Id("Price-false"));
        private IWebElement UsageHighToLow => driver.FindElement(By.Id("Usage-true"));
        private IWebElement UsageLowToHigh => driver.FindElement(By.Id("Usage-false"));
        private IWebElement DateUpdatedNewestToOldest => driver.FindElement(By.Id("DateUpdated-false"));
        private IWebElement DateUpdatedOldestToNewest => driver.FindElement(By.Id("DateUpdated-true"));
        private IWebElement ModelAscending => driver.FindElement(By.Id("Model-true"));
        private IWebElement ModelDescending => driver.FindElement(By.Id("Model-false"));
        private IWebElement SortListingAge => driver.FindElement(By.Id("large-age-selector"));
        private IWebElement ListingPrice => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.cell.container--search-results > div > ul > li.listing-0 > a > div.wrapper.desc-0 > div"));
        private IWebElement ListingUsage => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.cell.container--search-results > div > ul > li.listing-0 > a > div.wrapper.desc-0 > p:nth-child(3) > span"));
        private IWebElement ListingDate => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.cell.container--search-results > div > ul > li.listing-0 > a > div:nth-child(3) > p.update-notice.text--small"));
        private IWebElement ListingTitle => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.cell.container--search-results > div > ul > li.listing-0 > a > div.wrapper.desc-0 > h2"));
        private IWebElement Tags => driver.FindElement(By.XPath("//*[@id='search - filter - tags');"));
        private IWebElement FirstListingFirstAttribute => driver.FindElement(By.CssSelector("#search-results-react-root > div > main > div > div > div.large-9.cell > div > ul > li.listing-0 > a > div.wrapper.desc-0 > p:nth-child(2) > span"));

        public void ConfirmOnListingsPage()
        {// Confirm On Listings Page
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForElement("XPath", "//*[contains(@class,'listing-0')]");
            Thread.Sleep(5000);
            Util.Log("On Listings Page.");
        }

        public void ConfirmResultsDisplayed()
        {// Page confirmation for SSO Navigation
            Util util = new Util(driver);
            util.SwitchToNewTab();
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/equipment/");
            Util.Log("On Listings Page");
        }

        public void ConfirmFilterTags(string tagName)
        {
            if (isMobile)
            {
                driver.FindElement(By.XPath("//span[contains(text(),'"+tagName+"')]"));
            }
            else
            {
                driver.FindElement(By.XPath("//*[contains(@id,'search-filter-tags')]/div/span[contains(text(),'" + tagName + "')]"));
            }
            Util.Log("Filter Displayed.");
        }

        public void ConfirmManufacturerSelectorContains(string manufacturer)
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Thread.Sleep(2000);
            string man = manufacturer.ToLower().Replace(" ", string.Empty);
            try
            {

                Assert.IsTrue(ManufacturerValue.Text.ToLower().Replace(" ", string.Empty).Contains(man));
                Util.Log(TestDetails.Pass + manufacturer + " Confirmed Present in Manufacturer Selector");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ConfirmSimilarListingsFound()
        {
            try
            {
                Assert.IsTrue(SimilarListingsFound.Displayed);
                Util.Log("Similar Listings Message Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        private static Boolean IsMobile()
        {
            bool isMobile = false;
            if (TestDetails.GetParent.Contains("iPhone") || TestDetails.GetParent.Contains("Android"))
            {
                isMobile = true;
            }
            return isMobile;
        }

        private static bool isMobile => IsMobile();

        private void ClickRefineSearch()
        {// If IsMobile = true, this method is needed to open Search Filters.
            RefineSearch.Click();
            Thread.Sleep(1500);
            Util.Log("Clicked Refine Search Button.");
        }

        private void ClickViewResults()
        {// If IsMobile = true, this method is needed to close Search Filters.
            ViewResults.Click();
            Util.Log("Clicked View Results Button.");
        }

        public void EnterCategory(string category)
        {
            if (isMobile)
            {// Elements have different id's
                ClickRefineSearch();    // Opens a popup containing multiple selects
                IWebElement CategorySelector = driver.FindElement(By.XPath("//*[contains(@aria-activedescendant,'react-select-8--value')]"));
                CategorySelector.Click();   // Expands Category dropdown with 13 options
                Util.Log("Expanded Categories.");  // Works up to here
                CategorySelector.SendKeys(Keys.ArrowDown);
                CategorySelector.SendKeys(Keys.Tab);
                Util.Log("Selected Category: "+ category);
                ClickViewResults();
            }
            else
            {// use regular id's
                CategoryInput.SendKeys(category);
                Thread.Sleep(2000);
                CategoryInput.SendKeys(Keys.Enter);
                CategoryInput.SendKeys(Keys.Tab);
                Util.Log("Entered Category.");
            }
        }

        public void EnterMake(string make)
        {
            ClickRefineSearch();
            ManufacturerInput.SendKeys(make);
            Thread.Sleep(2000);
            ManufacturerInput.SendKeys(Keys.Enter);
            ManufacturerInput.SendKeys(Keys.Tab);
            ClickViewResults();
            Util.Log("Entered Make.");
        }

        public void EnterModel(string model)
        {
            ClickRefineSearch();
            ModelInput.SendKeys(model);
            Thread.Sleep(2000);
            ModelInput.SendKeys(Keys.Enter);
            ModelInput.SendKeys(Keys.Tab);
            ClickViewResults();
            Util.Log("Entered Model.");
        }

        public void EnterYearMin(string year)
        {
            ClickRefineSearch();
            YearMin.SendKeys(year);
            YearMin.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            ClickViewResults();
            Util.Log("Entered Min Year.");
        }

        public void EnterYearMax(string year)
        {
            ClickRefineSearch();
            YearMax.SendKeys(year);
            YearMax.SendKeys(Keys.Enter);
            YearMax.SendKeys(Keys.Tab);
            Thread.Sleep(2000);
            ClickViewResults();
            Util.Log("Entered Max Year");
        }

        public void EnterPriceMin(string price)
        {
            ClickRefineSearch();
            PriceMin.SendKeys(price);
            PriceMin.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            ClickViewResults();
            Util.Log("Entered Min Price.");
        }

        public void EnterPriceMax(string price)
        {
            ClickRefineSearch();
            PriceMax.SendKeys(price);
            PriceMax.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            ClickViewResults();
            Util.Log("Entered Max Price.");
        }

        public ListingDetails ClickViewDetails()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(ViewDetails);
            Util.Log("Clicked View Details Button");
            return new ListingDetails(driver);
        }

        public void ClickAddToCompare()
        {
            AddToCompare.Click();
            Thread.Sleep(250);
            Util.Log("Clicked Add To Compare Button");
        }

        public Compare ClickViewComparison()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(ViewComparison);
            Thread.Sleep(250);
            Util.Log("Clicked View Comparison.");
            return new Compare(driver);
        }

        public void SortByDistanceNearToFar()
        {
            DistanceNearToFar.Click();
            Thread.Sleep(3000);
            Util.Log("Sorted Listings by Distance Near to Far");
        }

        public void SortByDistanceFarToNear()
        {
            DistanceFarToNear.Click();
            Thread.Sleep(3000);
            Util.Log("Sorted Listings by Distance Far to Near");
        }

        public void SortByPriceAsc()
        {
            PriceLowToHigh.Click();
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Util.Log("Sorted Listings By Price Ascending");
        }

        public void SortByPriceDesc()
        {
            PriceHighToLow.Click();
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Util.Log("Sorted Listings By Price Descending");
        }

        public void SortByUsageAsc()
        {
            UsageLowToHigh.Click();
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Util.Log("Sorted Listings By Usage Ascending");
        }

        public void SortByUsageDesc()
        {
            UsageHighToLow.Click();
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Util.Log("Sorted Listings By Usage Descending");
        }

        public void SortByDateUpdatedNewToOld()
        {
            DateUpdatedNewestToOldest.Click();
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Util.Log("Sorted Listings by Date Updated New to Old");
        }

        public void SortByDateUpdatedOldToNew()
        {
            DateUpdatedOldestToNewest.Click();
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Util.Log("Sorted Listings by Date Updated Old to New");
        }

        public void SortByModelAsc()
        {
            ModelAscending.Click();
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Util.Log("Sorted Listings by Model Number Ascending");
        }

        public void SortByModelDesc()
        {
            ModelDescending.Click();
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Util.Log("Sorted Listings by Model Number Descending");
        }
    }
}
