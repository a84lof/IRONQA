namespace IRONQA.SEARCH.PAGES
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class SearchNav
    {
        private IWebDriver driver;
        public SearchNav(IWebDriver _driver) => driver = _driver;
        public IWebElement CollapsedMenu => driver.FindElement(By.CssSelector("body > div.title-bar > button"));
        public IWebElement IronSearchLogo => driver.FindElement(By.Id("nav-logo"));
        public IWebElement StartSearch => driver.FindElement(By.CssSelector("body > main > div > div > section.small-12.large-5.cell.left-section > aside > a"));
        public IWebElement BuySearch => driver.FindElement(By.Id("nav-buy-search"));
        public IWebElement UsedEquipment => driver.FindElement(By.Id("nav-used-equipment"));
        public IWebElement NewEquipment => driver.FindElement(By.Id("nav-new-equipment"));
        public IWebElement AllEquipment => driver.FindElement(By.Id("nav-all-equipment"));
        public IWebElement Sell => driver.FindElement(By.Id("nav-sell"));
        public IWebElement FSBO => driver.FindElement(By.Id("nav-fsbo"));
        public IWebElement ImADealer => driver.FindElement(By.Id("nav-dealer"));
        public IWebElement Appraise => driver.FindElement(By.CssSelector("#iron-search-menu > div.top-bar-left > ul > li:nth-child(4) > a"));
        public IWebElement Products => driver.FindElement(By.Id("nav-products"));
        public IWebElement OPEBook => driver.FindElement(By.Id("nav-outoor-power"));
        public IWebElement SerialNumberBook => driver.FindElement(By.Id("nav-serial-number"));
        public IWebElement TractorBook => driver.FindElement(By.Id("nav-tractor-book"));
        public IWebElement LocateADealer => driver.FindElement(By.Id("nav-locate-a-dealer"));

        public void ToggleMenu()
        {
            CollapsedMenu.Click();
            Thread.Sleep(500);
            Util.Log("Toggled Collapsed Menu.");
        }

        public void ClickBuySearch()
        {
            BuySearch.Click();
            Util.Log("Clicked Buy/Search");
        }

        public AdvancedSearch ClickUsedEquipment()
        {
            UsedEquipment.Click();
            Util.Log("Clicked Used Equipment");
            return new AdvancedSearch(driver);
        }

        public AdvancedSearch ClickNewEquipment()
        {
            NewEquipment.Click();
            Util.Log("Clicked New Equipment");
            return new AdvancedSearch(driver);
        }

        public AdvancedSearch ClickAllEquipment()
        {
            AllEquipment.Click();
            Util.Log("Clicked All Equipment");
            return new AdvancedSearch(driver);
        }

        public void ClickSell()
        {
            Sell.Click();
            Util.Log("Clicked Sell");
        }

        public void ClickForSaleByOwner()
        {
            FSBO.Click();
            Util.Log("Clicked FSBO");
        }

        public void ClickImADealer()
        {
            ImADealer.Click();
            Util.Log("Clicked I'm A Dealer");
        }

        public void ClickAppraise()
        {
            Appraise.Click();
            Util.Log("Clicked Appraise");
        }

        public void ClickProducts()
        {
            Products.Click();
            Util.Log("Clicked Products");
        }

        public void ClickOPEBook()
        {
            OPEBook.Click();
            Util.Log("Clicked OPE Book");
        }

        public void ClickSerialNoBook()
        {
            SerialNumberBook.Click();
            Util.Log("Clicked Serial Number Book");
        }

        public void ClickTractorBook()
        {
            TractorBook.Click();
            Util.Log("Clicked Tractor Book");
        }

        public DealerLocator ClickLocateADealer()
        {
            LocateADealer.Click();
            Util.Log("Clicked Locate A Dealer");
            return new DealerLocator(driver);
        }
    }
}
