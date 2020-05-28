namespace IRONQA.GDM.PAGES.SHARED
{
    using IRONQA.GDM.PAGES.LANDING;
    using IRONQA.GDM.PAGES.REPORTMGR;
    using IRONQA.GDM.PAGES.USERMGR;
    using IRONQA.GDM.PAGES.VALUESMGR;
    using OpenQA.Selenium;
    using System.Threading;
    using IRONQA.UTILITIES;

    public class GDMNav
    {
        private IWebDriver driver;
        public GDMNav(IWebDriver _driver) => driver = _driver;
        private IWebElement Home => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__product.top-bar-left > ul > li.menu-li.active > a"));
        private IWebElement Reports => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__product.top-bar-left > ul > li:nth-child(2) > a"));
        private IWebElement Entry => driver.FindElement(By.CssSelector(".top-bar>.nav__product>ul>li:nth-child(2)>ul>li:nth-child(1)>a"));
        private IWebElement Edit => driver.FindElement(By.XPath("//*[contains(@href,ManageReports) and (contains(text(),'Edit'))]"));
        private IWebElement ResolveDuplicates => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__product.top-bar-left > ul > li:nth-child(2) > ul > li:nth-child(3) > a"));
        private IWebElement Values => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__product.top-bar-left > ul > li:nth-child(3)"));
        private IWebElement Calculate => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__product.top-bar-left > ul > li:nth-child(3) > ul > li:nth-child(1) > a"));
        private IWebElement PublishStatus => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__product.top-bar-left > ul > li:nth-child(3) > ul > li:nth-child(2) > a"));
        private IWebElement Models => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__product.top-bar-left > ul > li:nth-child(4) > a"));
        private IWebElement Users => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__product.top-bar-left > ul > li:nth-child(5) > a"));
        private IWebElement SignOut => driver.FindElement(By.CssSelector("#desktop-menu > div.nav__account.top-bar-right > ul > li > a"));

        public Home ClickHome()
        {
            Home.Click();
            Util.Log("Clicked Nav > Home");
            return new Home(driver);
        }

        public void ClickReports()
        {
            Thread.Sleep(2000);
            Reports.Click();
            Thread.Sleep(500);
            Util.Log("Clicked Nav > Reports.");
        }

        public SoldReportEntry ClickEntry()
        {
            Thread.Sleep(1000);
            Entry.Click();
            Util.Log("Clicked Nav > Reports > Entry.");
            return new SoldReportEntry(driver);
        }

        public ReportGrid ClickEdit()
        {
            Edit.Click();
            Util.Log("Clicked Nav > Reports > Edit.");
            return new ReportGrid(driver);
        }

        public ResolveDuplicates ClickResolveDuplicates()
        {
            Reports.Click();
            ResolveDuplicates.Click();
            Util.Log("Clicked Nav > Reports > Resolve Duplicates.");
            return new ResolveDuplicates(driver);
        }

        public VMNav ClickCalculate()
        {
            Calculate.Click();
            Util.Log("Clicked Values > Calculate.");
            Thread.Sleep(1000);
            return new VMNav(driver);
        }

        public PublishStatus ClickPublishStatus()
        {
            PublishStatus.Click();
            Util.Log("Clicked Publish Progress.");
            return new PublishStatus(driver);
        }

        public MODELMGR.Login ClickModels()
        {
            Models.Click();
            Util.Log("Clicked Manage Models");
            return new MODELMGR.Login(driver);
        }

        public UserManager ClickUsers()
        {
            Users.Click();
            Util.Log("Clicked Manage Users");
            return new UserManager(driver);
        }

        public LANDING.Login ClickSignOut()
        {
            SignOut.Click();
            Util.Log("Clicked Sign Out");
            return new LANDING.Login(driver);
        }

        public VMNav ClickValues()
        {
            Values.Click();
            Thread.Sleep(1000);
            Util.Log("Clicked Values.");
            return new VMNav(driver);
        }
    }
}
