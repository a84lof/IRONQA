namespace IRONQA.NETSUITE.PAGES.CORP
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class SalesOrder
    {
        private IWebDriver driver;
        public SalesOrder(IWebDriver _driver) => driver = _driver;
        private IWebElement CloseOrder => driver.FindElement(By.XPath("//*[contains(@id,'tbl_closeremaining')]/tbody/tr/td[2]"));
        
        public void ConfirmOnSalesOrderPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'tbl_closeremaining')]/tbody/tr/td[2]");
        }

        public void ClickCloseOrder()
        {
            Thread.Sleep(1500);
            CloseOrder.Click();
            Util.Log("Clicked Close Order Button");
        }

        public void ConfirmClosed()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@class,'uir-record-status') and text() = 'Closed']");
        }
    }
}
