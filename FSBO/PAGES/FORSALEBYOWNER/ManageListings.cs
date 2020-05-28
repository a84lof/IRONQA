namespace IRONQA.FSBO.PAGES.FORSALEBYOWNER
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;

    public class ManageListings
    {
        private IWebDriver driver;
        public ManageListings(IWebDriver _driver) => driver = _driver;

        public void ConfirmOnManageListingsPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("fsbo/Classifieds/manage/");
            Util.Log("On Manage Listings Page.");
        }
    }
}
