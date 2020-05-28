namespace IRONQA.SEARCH.PAGES
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;

    public class ListingDetails
    {
        private IWebDriver driver;
        public ListingDetails(IWebDriver _driver) => driver = _driver;
        private IWebElement HomeCrumb => driver.FindElement(By.CssSelector("body > main > div.row.columns > nav > ul > li:nth-child(1) > a"));
        private IWebElement EquipmentSearchCrumb => driver.FindElement(By.CssSelector("body > main > div.row.columns > nav > ul > li:nth-child(2) > a"));
        private IWebElement SearchResultsCrumb => driver.FindElement(By.CssSelector("body > main > div.row.columns > nav > ul > li:nth-child(3) > a"));
        private IWebElement ListingTitle => driver.FindElement(By.CssSelector("#siteContainer > main > div:nth-child(2) > div > div.large-9.cell.left-side > div.title-price-wrapper > h1"));
        private IWebElement Condition => driver.FindElement(By.Id("condition"));
        private IWebElement SerialNumber => driver.FindElement(By.Id("serial"));
        private IWebElement StockNumber => driver.FindElement(By.Id("stock"));
        private IWebElement Location => driver.FindElement(By.Id("location"));
        private IWebElement DateListed => driver.FindElement(By.Id("listed"));
        private IWebElement DateUpdated => driver.FindElement(By.Id("updated"));
        private IWebElement Phone => driver.FindElement(By.Id("phoneClick"));
        private IWebElement MoreDealerListings => driver.FindElement(By.Id("dealership-listings"));
        private IWebElement MoreSellerListings => driver.FindElement(By.Id("fsbo-listings"));
        private IWebElement FSBOListings => driver.FindElement(By.Id("fsbo-listings"));
        private IWebElement Captcha => driver.FindElement(By.XPath("//*[@id='recaptcha - anchor']/div[5]"));
        private IWebElement GetDirections => driver.FindElement(By.Id("directions"));
        private IWebElement AddToCompare => driver.FindElement(By.CssSelector("body > main > div:nth-child(2) > div.large-8.columns > div.row.listing-details > div:nth-child(2) > label"));
        private IWebElement IronNumber => driver.FindElement(By.Id("ironnum"));
        private IWebElement ItemUsage => driver.FindElement(By.Id("usages"));
        private IWebElement ItemSize => driver.FindElement(By.Id("sizes"));
        private IWebElement ItemOptions => driver.FindElement(By.Id("options"));
        private IWebElement FirstName => driver.FindElement(By.Id("leadFormFirstName"));
        private IWebElement LastName => driver.FindElement(By.Id("leadFormLastName"));
        private IWebElement Zip => driver.FindElement(By.CssSelector("#leadFormZipPostalCode"));
        private IWebElement City => driver.FindElement(By.CssSelector("#leadFormCity"));
        private IWebElement State => driver.FindElement(By.CssSelector("#leadFormStateProvince"));
        private IWebElement EquipmentAvailable => driver.FindElement(By.Id("leadFormIsEquipmentStillAvailable"));
        private IWebElement TradeInterest => driver.FindElement(By.Id("leadFormIsInterestedInTradeForUnit"));
        private IWebElement ViewingInterest => driver.FindElement(By.Id("leadFormIsLikeToSeeUnit"));
        private IWebElement NewInterest => driver.FindElement(By.Id("leadFormisBuyNewVersionOfUnit"));
        private IWebElement FinanceInterest => driver.FindElement(By.Id("leadFormisInterestedInFinanceOptions"));
        private IWebElement MyEmail => driver.FindElement(By.CssSelector("#leadFormEmail"));
        private IWebElement MyPhone => driver.FindElement(By.CssSelector("#leadFormPhone"));
        private IWebElement Message => driver.FindElement(By.CssSelector("#leadFormMessage"));
        private IWebElement Send => driver.FindElement(By.CssSelector("#btnDealerInquiry"));
        private IWebElement ImageGallery => driver.FindElement(By.Id("images"));
        private IWebElement SellerName => driver.FindElement(By.Id("dealerName"));
        private IWebElement SellerLogo => driver.FindElement(By.Id("logo"));
        private IWebElement CheckAvailability => driver.FindElement(By.CssSelector("#siteContainer > main > div:nth-child(2) > div > div.large-3.cell.right-side.show-for-large > div.inquiry-toggle-wrapper > div > a"));

        public void ConfirmOnDetailsPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("for-sale");
            Util.Log("On Detail Page");
        }

        public void ClickForPhoneNumber()
        {
            Phone.Click();
            Util.Log("Clicked For Phone Number.");
        }

        public Results ClickMoreListingsFromThisDealer()
        {
            MoreDealerListings.Click();
            Util.Log("Clicked More Dealer Listings.");
            return new Results(driver);
        }

        public Results ClickMoreListingsFromAll()
        {
            MoreSellerListings.Click();
            Util.Log("Clicked More Listings From All.");
            return new Results(driver);
        }

        public DealerLocator ClickGetDirections()
        {
            GetDirections.Click();
            Util.Log("Clicked Get Directions.");
            return new DealerLocator(driver);
        }

        public Compare ClickCompare()
        {
            AddToCompare.Click();
            Util.Log("Clicked Compare.");
            return new Compare(driver);
        }

        public void ClickCheckAvailability()
        {
            CheckAvailability.Click();
            Util.Log("Clicked Check Availability.");
        }

        public void EnterFirstName(string name)
        {
            FirstName.SendKeys(name);
            Util.Log("Entered First Name.");
        }

        public void EnterLastName(string name)
        {
            LastName.SendKeys(name);
            Util.Log("Entered Last Name.");
        }

        public void EnterEmail(string email)
        {
            MyEmail.SendKeys(email);
            Util.Log("Entered Email.");
        }

        public void EnterPhone(string numbers)
        {
            MyPhone.SendKeys(numbers);
            Util.Log("Entered Phone Number.");
        }

        public void EnterMessage(string text)
        {
            Message.SendKeys(text);
            Util.Log("Entered Message.");
        }

        public void ClickSend()
        {
            Send.Click();
            Util.Log("Clicked Send Button");
        }
    }
}
