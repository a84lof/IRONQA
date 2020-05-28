namespace IRONQA.GUIDES.PAGES.INVENTORY
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class Reports
    {
        private IWebDriver driver;
        public Reports(IWebDriver _driver) => driver = _driver;

        public void ConfirmOnReportsTab()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//div[@id='root']/div/main/div[3]/div[contains(@class,'prompt-modal') and not(contains(@class,'show'))]");
            Thread.Sleep(1000);
            Util.Log("On Reports Tab.");
        }
    }
}