namespace IRONQA.NETSUITE.PAGES.SHARED
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;

    public class RoleSelection
    {
        private IWebDriver driver;
        public RoleSelection(IWebDriver _driver) => driver = _driver;

        public void ConfirmOnRoleSelectionPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id", "div__body");
        }

        public Nav SelectRole(Users.NetSuiteRoles role)
        {
            string roleName;
            IWebElement link;
            switch (role.ToString())
            {
                case "SandboxAdminNoHR":
                    roleName = "IS_Administrator (No HR) - IRON Solutions -SANDBOX";
                    link = driver.FindElement(By.XPath("//*[contains(@aria-label,'" + roleName + "')]"));
                    link.Click();
                    Util.Log("Clicked Role " + roleName);
                    break;
                case "SandboxSalesAdmin":
                    roleName = "IS_Sales Administrator - IRON Solutions -SANDBOX";
                    link = driver.FindElement(By.XPath("//*[contains(@aria-label,'" + roleName + "')]"));
                    link.Click();
                    Util.Log("Clicked Role " + roleName);
                    break;
                case "SandboxSalesRep":
                    roleName = "IS_Sales Rep - IRON Solutions -SANDBOX";
                    link = driver.FindElement(By.XPath("//*[contains(@aria-label,'" + roleName + "')]"));
                    link.Click();
                    Util.Log("Clicked Role " + roleName);
                    break;
                case "ProdAdminNoHR":
                    roleName = "IS_Administrator (No HR) - IRON Solutions";
                    link = driver.FindElement(By.XPath("//*[contains(@aria-label,'" + roleName + "')]"));
                    link.Click();
                    Util.Log("Clicked Role " + roleName);
                    break;
                case "QA24IronAdmin":
                    roleName = "IRON Administrator - IRON Solutions CAN QA24 - Production Test Account";
                    link = driver.FindElement(By.XPath("//*[contains(@aria-label,'" + roleName + "')]"));
                    link.Click();
                    Util.Log("Clicked Role " + roleName);
                    break;
                case "QA24SalesManager":
                    roleName = "IRON Sales Manager - IRON Solutions CAN QA24 - Production Test Account";
                    link = driver.FindElement(By.XPath("//*[contains(@aria-label,'" + roleName + "')]"));
                    link.Click();
                    Util.Log("Clicked Role " + roleName);
                    break;
                case "QA24SalesRep":
                    roleName = "IRON Sales Rep - IRON Solutions CAN QA24 - Production Test Account";
                    link = driver.FindElement(By.XPath("//*[contains(@aria-label,'" + roleName + "')]"));
                    link.Click();
                    Util.Log("Clicked Role " + roleName);
                    break;
                case "QA44IronAdmin":
                    roleName = "IRON Administrator - IRON Solutions QA44 - Kleiber - Trailing1";
                    link = driver.FindElement(By.XPath("//*[contains(@aria-label,'" + roleName + "')]"));
                    link.Click();
                    Util.Log("Clicked Role " + roleName);
                    break;
                case "QA44SalesManager":
                    roleName = "IRON Sales Manager - IRON Solutions QA44 - Kleiber - Trailing1";
                    link = driver.FindElement(By.XPath("//*[contains(@aria-label,'" + roleName + "')]"));
                    link.Click();
                    Util.Log("Clicked Role " + roleName);
                    break;
                case "QA44SalesRep":
                    roleName = "IRON Sales Rep - IRON Solutions QA44 - Kleiber - Trailing1";
                    link = driver.FindElement(By.XPath("//*[contains(@aria-label,'" + roleName + "')]"));
                    link.Click();
                    Util.Log("Clicked Role " + roleName);
                    break;
            }
            return new Nav(driver);
        }
    }
}