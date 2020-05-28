namespace IRONQA.STORE.PAGES.CHECKOUT
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;
    
    public class Confirmation
    {
        private IWebDriver driver;
        public Confirmation(IWebDriver _driver) => driver = _driver;
        public static string SalesOrderNumber;

        public void ConfirmConfirmationPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            try
            {
                Thread.Sleep(15000);
                Assert.IsTrue(driver.Url.Contains("#confirmation"));
                Util.Log("On Confirmation Page.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + ex); }
        }

        public void GetSalesOrderNumber()
        {
            Thread.Sleep(1000);
            IWebElement Number = driver.FindElement(By.XPath("//*[contains(@class, 'order-wizard-confirmation-module-body')]/strong/a"));
            SalesOrderNumber = Number.Text.ToString().Replace("#",string.Empty).Replace(".",string.Empty);
            Util.Log("Sales Order #"+SalesOrderNumber);
        }
    }
}
