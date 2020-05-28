namespace IRONQA.GUIDES.PAGES.INVENTORY
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class MarkSold
    {
        private IWebDriver driver;
        public MarkSold(IWebDriver _driver) => driver = _driver;

        private IWebElement MarkSoldLabel => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/header/h1"));
        private IWebElement StockNumber => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[1]/div/div[1]/div/input"));
        private IWebElement SoldDate => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[1]/div/div[2]/div/div/div/input"));
        private IWebElement SaleTypeDropdown => driver.FindElement(By.XPath("//*[@id='dropdown__inventory-report-sold-sale-type']/div/div[1]"));
        private IWebElement SaleTypeRetail => driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/main/div[3]/div[1]/div/section/div[6]/div/main/section[1]/div/div[3]/div/div/div[2]/div/div[1]"));
        private IWebElement SaleTypeWholeSale => driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/main/div[3]/div[1]/div/section/div[6]/div/main/section[1]/div/div[3]/div/div/div[2]/div/div[2]"));
        private IWebElement SaleTypeAuction => driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/main/div[3]/div[1]/div/section/div[6]/div/main/section[1]/div/div[3]/div/div/div[2]/div/div[3]"));
        private IWebElement NetCashSellingPrice => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[1]/div/div[4]/div/input"));
        private IWebElement SerialNumberEdit => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[2]/div/div[1]/div[1]/button"));
        private IWebElement SerialNumberInput => driver.FindElement(By.XPath("//*[@id='inventory__reportSoldEditable-serialNumber']"));
        private IWebElement SerialNumberCheckmark => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[2]/div/div[1]/div[1]/button[1]/i"));
        private IWebElement AskingPriceEdit => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[2]/div/div[1]/div[2]/button"));
        private IWebElement AskingPriceInput => driver.FindElement(By.XPath("//*[@id='inventory__reportSoldEditable-askingPrice']"));
        private IWebElement AskingPriceCheckmark => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[2]/div/div[1]/div[2]/button[1]"));
        private IWebElement WorkOrderEdit => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[2]/div/div[1]/div[3]/button"));
        private IWebElement WorkOrderInput => driver.FindElement(By.XPath("//*[@id='inventory__reportSoldEditable-workOrder']"));
        private IWebElement WorkOrderCheckmark => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[2]/div/div[1]/div[3]/button[1]/i"));
        private IWebElement SepHoursEdit => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[2]/div/div[2]/div[1]/button"));
        private IWebElement SepHoursInput => driver.FindElement(By.XPath("//*[@id='inventory__reportSoldEditable-meter_0']"));
        private IWebElement SepHoursCheckmark => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[2]/div/div[2]/div[1]/button[1]/i"));
        private IWebElement EngHoursEdit => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[2]/div/div[2]/div[2]/button"));
        private IWebElement EngHoursInput => driver.FindElement(By.XPath("//*[@id='inventory__reportSoldEditable-meter_1']"));
        private IWebElement EngHoursCheckmark => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/main/section[2]/div/div[2]/div[2]/button[1]/i"));
        private IWebElement MarkSoldButton => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/footer/div/button[1]"));
        private IWebElement Cancel => driver.FindElement(By.XPath("//*[@id='inventoryModalReportSold']/footer/div/button[2]"));
        public static string Price = "";

        public void ConfirmMarkSoldModal()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[@id='inventoryModalReportSold']/header/h1");
            Util.Log("On Mark Equipment Sold Modal.");
        }

        public void EnterStockNumber(string stockNum)
        {
            StockNumber.SendKeys(stockNum);
            Util.Log("Entered Stock Number: "+stockNum);
        }

        public void EnterSoldDate(string date)
        {
            SoldDate.SendKeys(date);
            Util.Log("Entered Sold Date: "+date);
        }

        public enum SaleType {Retail, Wholesale, Auction};

        public void SelectSaleType(SaleType saleType)
        {
            SaleTypeDropdown.Click();
            switch (saleType.ToString())
            {
                case "Retail":
                    SaleTypeRetail.Click();
                    break;
                case "Wholesale":
                    SaleTypeWholeSale.Click();
                    break;
                case "Auction":
                    SaleTypeAuction.Click();
                    break;
            }
            Util.Log("Selected Sale Type: "+saleType.ToString());
        }

        public void EnterNetCashSellingPrice(string price)
        {
            Price = price.ToString();
            NetCashSellingPrice.SendKeys(price);
            Util.Log("Entered Net Cash Selling Price: "+price);
        }

        public void EnterSerialNumber(string serialNum)
        {
            SerialNumberEdit.Click();
            SerialNumberInput.SendKeys(serialNum);
            SerialNumberCheckmark.Click();
            Util.Log("Entered Serial Number: "+serialNum);
        }

        public void EnterAskingPrice()
        {
            AskingPriceEdit.Click();
            AskingPriceInput.SendKeys(Price); // local static Price
            AskingPriceCheckmark.Click();
            Util.Log("Entered Asking Price: "+Price);
        }

        public void EnterWorkOrder(string orderNum)
        {
            WorkOrderEdit.Click();
            WorkOrderInput.SendKeys(orderNum);
            WorkOrderCheckmark.Click();
            Util.Log("Entered Work Order: "+orderNum);
        }

        public void EnterSepHours(string hours)
        {
            SepHoursEdit.Click();
            SepHoursInput.SendKeys(hours);
            SepHoursCheckmark.Click();
            Util.Log("Entered SepHours: "+hours);
        }

        public void EnterEngHours(string hours)
        {
            EngHoursEdit.Click();
            EngHoursInput.SendKeys(hours);
            EngHoursCheckmark.Click();
            Util.Log("Entered EngHours: "+hours);
        }

        public MyEquipment ClickMarkSold()
        {
            Thread.Sleep(10000); // just to see what was entered before the test ends
            MarkSoldButton.Click();
            Util.Log("Clicked Mark Sold Button.");
            return new MyEquipment(driver);
        }

        public MyEquipment ClickCancel()
        {
            Thread.Sleep(10000); // just to see what was entered before the test ends
            Cancel.Click();
            Util.Log("Clicked Cancel Button.");
            return new MyEquipment(driver);
        }

        public void ConfirmSuccess()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//div[@class='notification-alert__container inventory-alert']/*");
        }
    }
}