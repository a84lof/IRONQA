namespace IRONQA.GUIDES.PAGES.INVENTORY.EQUIPMENT
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class ListingPreview
    {
        private IWebDriver driver;
        public ListingPreview(IWebDriver _driver) => driver = _driver;

        public void ConfirmOnListingPreviewPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","ironsearch-preview");
            Util.Log("On Listing Preview Page.");
        }
    }
}