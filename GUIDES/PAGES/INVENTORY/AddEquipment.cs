namespace IRONQA.GUIDES.PAGES.INVENTORY
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class AddEquipment
    {
        private IWebDriver driver;
        public AddEquipment(IWebDriver _driver) => driver = _driver;

        public void ConfirmOnAddEquipmentTab()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//div[@id='root']/div/main/div[3]/div[contains(@class,'prompt-modal') and not(contains(@class,'show'))]");
            Thread.Sleep(1000);
            Util.Log("On Add Equipment Tab.");
        }
    }
}
