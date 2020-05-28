namespace IRONQA.DEALERDASH.PAGES
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class DealerDashboard
    {
        private IWebDriver driver;
        public DealerDashboard(IWebDriver _driver) => driver = _driver;

        public void ConfirmIronDealerPage()
        {
            Util util = new Util(driver);
            util.SwitchToNewTab();
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("ws/sales_report");
            Util.Log("On Iron Dealer Page.");
        }
    }
}