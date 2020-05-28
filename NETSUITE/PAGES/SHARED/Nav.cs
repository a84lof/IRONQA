namespace IRONQA.NETSUITE.PAGES.SHARED
{
    using IRONQA.NETSUITE.PAGES.CORP;
    using IRONQA.STORE.PAGES.CHECKOUT;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class Nav
    {
        private IWebDriver driver;
        public Nav(IWebDriver _driver) => driver = _driver;
        private IWebElement Search => driver.FindElement(By.Id("_searchstring"));
        private IWebElement QuickMenu => driver.FindElement(By.CssSelector("#ns-header-quick-menu-item0 > a"));
        private IWebElement Help => driver.FindElement(By.CssSelector("#ns_header > div.ns-header-item-container > a > div:nth-child(2)"));
        private IWebElement RoleSelector => driver.FindElement(By.Id("spn_cRR_d1"));
        private IWebElement RecentRecords => driver.FindElement(By.CssSelector("#recent-records-menu-item > img"));
        private IWebElement Home => driver.FindElement(By.CssSelector("#ns-header-menu-home-item0 > a > img"));
        private IWebElement Shortcuts => driver.FindElement(By.CssSelector("#ns-header-menu-shortcuts-item0 > a > img"));
        private IWebElement Activities => driver.FindElement(By.CssSelector("#ns-header-menu-main-item0 > a > span"));
        private IWebElement ContractRenewals => driver.FindElement(By.CssSelector("#ns-header-menu-main-item1 > a > span"));
        private IWebElement TribeHR => driver.FindElement(By.CssSelector("#ns-header-menu-main-item2 > a > span"));
        private IWebElement FinancialPlanning => driver.FindElement(By.CssSelector("#ns-header-menu-main-item3 > a > span"));
        private IWebElement Transactions => driver.FindElement(By.CssSelector("#ns-header-menu-main-item4 > a > span"));
        private IWebElement Lists => driver.FindElement(By.CssSelector("#ns-header-menu-main-item5 > a > span"));
        private IWebElement Reports => driver.FindElement(By.CssSelector("#ns-header-menu-main-item6 > a > span"));
        private IWebElement Documents => driver.FindElement(By.CssSelector("#ns-header-menu-main-item7 > a > span"));
        private IWebElement Setup => driver.FindElement(By.CssSelector("#ns-header-menu-main-item8 > a > span"));
        private IWebElement Customization => driver.FindElement(By.CssSelector("#ns-header-menu-main-item9 > a > span"));
        private IWebElement Support => driver.FindElement(By.CssSelector("#ns-header-menu-main-item10 > a > span"));
        private IWebElement Menu => driver.FindElement(By.CssSelector("#NS_MENU_ID0"));
        private IWebElement IronDocs => driver.FindElement(By.CssSelector("#ns-header-menu-main-item11"));
        private IWebElement NewOpportunity => driver.FindElement(By.CssSelector("#ns-header-quick-menu-item7 > a > span"));
        private IWebElement NewSalesOrder => driver.FindElement(By.CssSelector("#ns-header-quick-menu-item8 > a > span"));
        private IWebElement ViewAllRoles => driver.FindElement(By.XPath("//*[contains(@class,'uir-menuitem-viewall')]/a"));

        public void ConfirmNSNav()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","spn_cRR_d1");
        }

        public Opportunity StartAnOpportunity()
        {
            QuickMenu.Click();
            NewOpportunity.Click();
            Util.Log("Started A New Opportunity");
            return new Opportunity(driver);
        }

        public SalesOrder StartASalesOrder()
        {
            QuickMenu.Click();
            NewSalesOrder.Click();
            Util.Log("Started A New Sales Order");
            return new SalesOrder(driver);
        }

        public void SearchByCustomer(string customer)
        {
            Thread.Sleep(2000);
            Search.SendKeys("cu:" + customer);
            Search.SendKeys(Keys.Enter);
            Util.Log("Searched For Customer " + customer);
        }

        public void SearchByOpportunity(string opportunityNumber)
        {
            Search.SendKeys("op:" + opportunityNumber);
            Search.SendKeys(Keys.Enter);
            Util.Log("Searched for Opportunity " + opportunityNumber);
        }

        public SalesOrder SearchForSalesOrder(string salesOrderNumber)
        {
            Thread.Sleep(2000);
            Search.SendKeys(salesOrderNumber);
            Thread.Sleep(1000);
            // Find returned result that contains the Latest SO Number
            IWebElement link = driver.FindElement(By.XPath("//*[contains(@id,'/app/accounting/transactions/transaction') and contains(text(),'"+Confirmation.SalesOrderNumber+"')]"));
            link.Click();
            Util.Log("Searched for Sales Order " + salesOrderNumber);
            return new SalesOrder(driver);
        }

        public void SearchByContract(string contractNumber)
        {
            Search.SendKeys("co:" + contractNumber);
            Search.SendKeys(Keys.Enter);
            Util.Log("Searched for Contract " + contractNumber);
        }

        public RoleSelection ClickRoles()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Thread.Sleep(2000);
            RoleSelector.Click();
            Util.Log("Clicked Role Selector.");
            return new RoleSelection(driver);
        }

        public RoleSelection ClickViewAllRoles()
        {
            Thread.Sleep(500);
            ViewAllRoles.Click();
            Util.Log("Clicked View All Roles.");
            return new RoleSelection(driver);
        }
    }
}