namespace IRONQA.STORE.PAGES.SHARED
{
    using IRONQA.SSO.PAGES;
    using IRONQA.STORE.PAGES.CART;
    using IRONQA.STORE.PAGES.MYACCOUNT;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System.Threading;

    public class StoreNav
    {
        private IWebDriver driver;
        public StoreNav(IWebDriver _driver) => driver = _driver;
        private IWebElement Logo => driver.FindElement(By.CssSelector("#site-header > div.header-main-wrapper > nav > div.header-content > div.header-logo-wrapper > div > a"));
        private IWebElement Welcome => driver.FindElement(By.CssSelector("#site-header > div.header-main-wrapper > nav > div.header-content > div.header-right-menu > div.header-menu-profile > a > strong"));
        private IWebElement AccountOverview => driver.FindElement(By.CssSelector("#site-header > div.header-main-wrapper > nav > div.header-content > div.header-right-menu > div.header-menu-profile.open > ul > li > ul > li.header-menu-myaccount-overview > a.header-menu-myaccount-overview-anchor"));
        private IWebElement PurchasesHistory => driver.FindElement(By.CssSelector("#site-header > div.header-main-wrapper > nav > div.header-content > div.header-right-menu > div.header-menu-profile.open > ul > li > ul > li.header-menu-myaccount-item-level2.header-menu-myaccount-level2-orders > ul > li:nth-child(2) > a"));
        private IWebElement Home => driver.FindElement(By.CssSelector("#site-header > div.header-secondary-wrapper > nav > ul > li:nth-child(1) > a"));
        private IWebElement Shop => driver.FindElement(By.CssSelector("#site-header > div.header-secondary-wrapper > nav > ul > li:nth-child(2) > a"));
        private IWebElement IronGuides => driver.FindElement(By.CssSelector("#site-header > div.header-secondary-wrapper > nav > ul > li:nth-child(3) > a"));
        private IWebElement ForSaleListing => driver.FindElement(By.CssSelector("#site-header > div.header-secondary-wrapper > nav > ul > li:nth-child(4) > a"));
        private IWebElement Appraisals => driver.FindElement(By.CssSelector("#site-header > div.header-secondary-wrapper > nav > ul > li:nth-child(5) > a"));
        private IWebElement Login => driver.FindElement(By.CssSelector("#site-header > div.header-main-wrapper > nav > div.header-content > div.header-right-menu > div.header-menu-profile > div > ul > li:nth-child(2) > a"));
        private IWebElement Register => driver.FindElement(By.CssSelector("#site-header > div.header-main-wrapper > nav > div.header-content > div.header-right-menu > div.header-menu-profile > div > ul > li:nth-child(4) > a"));
        private IWebElement Cart => driver.FindElement(By.CssSelector("#site-header > div.header-main-wrapper > nav > div.header-content > div.header-right-menu > div.header-menu-cart > div > div > a > i"));
        private IWebElement Search => driver.FindElement(By.CssSelector("#site-header > div.header-secondary-wrapper > nav > div > button > i"));

        public void ConfirmNav()
        {
            Util cfg = new Util(driver);
            cfg.ExecuteScript(Scripts.WaitForPage);
            cfg.WaitForClickableElement("CssSelector","#site-header > div.header-main-wrapper > nav > div.header-content > div.header-right-menu > div.header-menu-profile > div > ul > li:nth-child(2) > a");
            Assert.IsTrue(Login.Displayed);
            Util.Log("Login Displayed.");
        }

        public Home ClickHome()
        {
            Home.Click();
            Util.Log("Clicked Home Button.");
            return new Home(driver);
        }

        public Shop ClickShop()
        {
            Shop.Click();
            Util.Log("Clicked Shop Button.");
            return new Shop(driver);
        }

        public PurchaseGuides ClickGuides()
        {
            IronGuides.Click();
            Util.Log("Clicked Guides Button.");
            return new PurchaseGuides(driver);
        }

        public PurchaseListings ClickFSBO()
        {
            ForSaleListing.Click();
            Util.Log("Clicked FSBO Button.");
            return new PurchaseListings(driver);
        }

        public PurchaseAppraisals ClickAppraiser()
        {
            Appraisals.Click();
            Util.Log("Clicked Appraiser Button.");
            return new PurchaseAppraisals(driver);
        }

        public SSOLogin ClickLogin()
        {
            Login.Click();
            Util.Log("Clicked Login Button.");
            return new SSOLogin(driver);
        }

        public SSOLogin ClickRegister()
        {
            Register.Click();
            Util.Log("Clicked Registration Button.");
            return new SSOLogin(driver);
        }

        public MyCart ClickCart()
        {
            Cart.Click();
            Util.Log("Clicked Cart Button.");
            return new MyCart(driver);
        }

        public void ClickSearch()
        {
            Search.Click();
            Util.Log("Clicked Search Button.");
        }

        public void ClickWelcome()
        {
            Welcome.Click();
            Util.Log("Clicked Welcome.");
        }

        public Overview ClickAccountOverview()
        {
            Thread.Sleep(1000);
            AccountOverview.Click();
            Util.Log("Clicked Account Overview.");
            return new Overview(driver);
        }

        public Overview ClickPurchasesHistory()
        {
            PurchasesHistory.Click();
            Util.Log("Clicked Purchases History.");
            return new Overview(driver);
        }
    }
}
