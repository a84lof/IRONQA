namespace IRONQA.STORE.PAGES.SHARED
{
    using IRONQA.STORE.PAGES.CART;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class Shop
    {
        private IWebDriver driver;
        public Shop(IWebDriver _driver) => driver = _driver;
        private IWebElement FSBO10Pack => driver.FindElement(By.CssSelector("#facet-browse > section > div.facets-facet-browse-content > div.facets-facet-browse-results > div.facets-facet-browse-items > div:nth-child(1) > div:nth-child(1) > div > div.facets-item-cell-grid-image-wrapper > a"));
        private IWebElement FullAppraisal => driver.FindElement(By.XPath("//*[contains(@data-sku,'Iron Appraiser Download Test Item')]"));
        private IWebElement HomeBreadcrumb => driver.FindElement(By.CssSelector("#main-container > div.shopping-layout-breadcrumb > div > ul > li.global-views-breadcrumb-item > a"));
        private IWebElement CountFilter => driver.FindElement(By.ClassName("#list-header-filters > div > div > div:nth-child(1) > select"));
        private IWebElement SortBy => driver.FindElement(By.CssSelector("#list-header-filters > div > div > div:nth-child(2) > select"));
        private IWebElement DisplayList => driver.FindElement(By.CssSelector("#facet-browse > section > div.facets-facet-browse-content > div.facets-facet-browse-results > header > nav > div.facets-facet-browse-list-header-actions > a:nth-child(1) > i"));
        private IWebElement DisplayTable => driver.FindElement(By.CssSelector("#facet-browse > section > div.facets-facet-browse-content > div.facets-facet-browse-results > header > nav > div.facets-facet-browse-list-header-actions > a:nth-child(2) > i"));
        private IWebElement DisplayGrid => driver.FindElement(By.CssSelector("#facet-browse > section > div.facets-facet-browse-content > div.facets-facet-browse-results > header > nav > div.facets-facet-browse-list-header-actions > a.facets-item-list-display-selector.facets-item-list-display-selector-grid > i"));
        private IWebElement Quantity => driver.FindElement(By.Id("quantity"));
        private IWebElement AddToCart => driver.FindElement(By.CssSelector("#product-details-full-form > section.product-details-full-actions > div:nth-child(1) > div > div > div > button"));
        private IWebElement Checkout => driver.FindElement(By.CssSelector("#modal-body > div > div.cart-confirmation-modal-details > div.cart-confirmation-modal-actions > div.cart-confirmation-modal-view-cart > a"));
        private IWebElement ViewCartAndCheckout => driver.FindElement(By.XPath("//*[contains(@class,'cart-confirmation-modal-view-cart')]/a"));
        private IWebElement ContinueShopping => driver.FindElement(By.CssSelector("#modal-body > div > div.cart-confirmation-modal-details > div.cart-confirmation-modal-actions > div.cart-confirmation-modal-continue-shopping > button"));

        public void ConfirmOnShopPage()
        {
            Util util = new Util(driver);
            util.SwitchToNewTab();
            util.ExecuteScript(Scripts.WaitForPage);
            try
            {
                Assert.IsTrue(driver.Url.Contains("/search"));
                Util.Log("On Shop Page.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ClickFSBO10Pack()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#facet-browse > section > div.facets-facet-browse-content > div.facets-facet-browse-results > div.facets-facet-browse-items > div:nth-child(1) > div:nth-child(1) > div > div.facets-item-cell-grid-image-wrapper > a");
            FSBO10Pack.Click();
            Util.Log("Clicked FSBO 10-Pack.");
        }

        public void ClickFullAppraisal()
        {
            Thread.Sleep(1250);
            FullAppraisal.Click();
            Util.Log("Clicked Full Appraisal.");
        }

        public void EnterQuantity(string number)
        {
            Thread.Sleep(1000);
            Quantity.Click();
            Quantity.Click();
            Quantity.SendKeys(Keys.Delete);
            Thread.Sleep(250);
            Quantity.SendKeys(number);
            Util.Log("Entered Quantity Of: " + number);
        }

        public void ClickAddToCart()
        {
            Thread.Sleep(1250);
            AddToCart.Click();
            Util.Log("Clicked Add to Cart Button.");
        }

        public MyCart ClickViewCart()
        {
            Thread.Sleep(1500);
            ViewCartAndCheckout.Click();
            return new MyCart(driver);
        }

        public void ClickContinueShopping()
        {
            Thread.Sleep(250);
            ContinueShopping.Click();
            Util.Log("Clicked Continue Shopping");
        }

        public void AddFSBOToCart()
        {
            ClickFSBO10Pack();
            ClickAddToCart();
            ClickContinueShopping();
            Util.Log("10 FSBO Listings Added To Cart.");
        }

        public void AddAppraisalsToCart()
        {
            ClickFullAppraisal();
            ClickContinueShopping();
        }
    }
}
