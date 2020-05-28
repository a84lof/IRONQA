namespace IRONQA.GUIDES.PAGES.INVENTORY.EQUIPMENT
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Photos
    {
        private IWebDriver driver;
        public Photos(IWebDriver _driver) => driver = _driver;

        public void ConfirmOnPhotosPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","photos");
            Util.Log("On Photos Page.");
        }
    }
}