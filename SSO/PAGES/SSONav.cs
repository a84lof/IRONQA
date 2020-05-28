namespace IRONQA.SSO.PAGES
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class SSONav
    {
        private IWebDriver driver;
        public SSONav(IWebDriver _driver) => driver = _driver;
        private IWebElement Logo => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.menu-text.show-for-large > a > img"));
        private IWebElement OurSolutions => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li:nth-child(2) > a"));
        private IWebElement Products => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li:nth-child(3) > a"));
        private IWebElement Resources => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.menu > a"));
        private IWebElement About => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li:nth-child(5) > a"));
        private IWebElement Contact => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li:nth-child(6) > a"));
        private IWebElement Logout => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-right > ul > li > a"));
        private IWebElement Register => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-right > ul > li > a"));
        private IWebElement Login => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-right > ul > li > a"));
        private IWebElement SolutionsForDealers => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(1) > a"));
        private IWebElement SolutionsForLendersAndInsurers => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(2) > a"));
        private IWebElement SolutionsForManufacturers => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(3) > a"));
        private IWebElement SolutionsForAnalysts => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(4) > a"));
        private IWebElement SolutionsForFarmersAndRanchers => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(5) > a"));
        private IWebElement IronGuides => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(1) > a"));
        private IWebElement IronSearch => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(2) > a"));
        private IWebElement IronAppraiser => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(3) > a"));
        private IWebElement IronHQ => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(4) > a"));
        private IWebElement PrecisionHQ => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(5) > a"));
        private IWebElement IronForecast => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(6) > a"));
        private IWebElement IronTrends => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(7) > a"));
        private IWebElement IronIndex => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(8) > a"));
        private IWebElement IronMonthly => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(9) > a"));
        private IWebElement IronAPI => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(10) > a"));
        private IWebElement PrintBooks => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(11) > a"));
        private IWebElement IronSolutions => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(1) > a"));
        private IWebElement IronData => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(2) > a"));
        private IWebElement OurTeam => driver.FindElement(By.CssSelector("#iron-solutions-menu > div.top-bar-left > ul > li.is-dropdown-submenu-parent.opens-right.is-active > ul > li:nth-child(3) > a"));

        public void ClickOurSolutions()
        {
            OurSolutions.Click();
            Util.Log("Clicked Our Solutions Nav.");
        }

        public void ClickProducts()
        {
            Products.Click();
            Util.Log("Clicked Products Nav.");
        }

        public void ClickResources()
        {
            Resources.Click();
            Util.Log("Clicked Resources Nav.");
        }

        public void ClickAbout()
        {
            About.Click();
            Util.Log("Clicked About Nav.");
        }

        public void ClickContact()
        {
            Contact.Click();
            Util.Log("Clicked Contact Nav.");
        }
    }
}