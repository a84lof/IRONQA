namespace IRONQA.FSBO.PAGES.APPRAISAL
{
    using IRONQA.SSO.PAGES;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class EquipmentDetails
    {
        private IWebDriver driver;
        public EquipmentDetails(IWebDriver _driver) => driver = _driver;
        private IWebElement SerialNumber => driver.FindElement(By.XPath("//*[contains(@class,'col')]/input [(contains(@id,'SerialNo'))]"));
        private IWebElement Meters => driver.FindElement(By.XPath("//*[contains(@class,'col')]/input [(contains(@id,'MachineHour'))]"));
        private IWebElement Condition => driver.FindElement(By.ClassName("rad-unchecked"));
        private IWebElement MachineOptions => driver.FindElement(By.ClassName("chk-area"));
        private IWebElement LoginAndContinue => driver.FindElement(By.Id("Content_Content_continueLoggedOutLogin"));
        private IWebElement Continue => driver.FindElement(By.Id("Content_Content_continueLoggedIn"));

        public void ConfirmOnEquipmentDetailsPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForElement("XPath","//*[contains(@class,'col')]/input [(contains(@id,'SerialNo'))]");
            Util.Log("On Equipment Details Page.");
        }

        public void EnterSerialNumber(string value)
        {
            Thread.Sleep(1500);
            SerialNumber.SendKeys(value);
            InitialSerialNumber = SerialNumber.Text;
            Util.Log("Enterd Serial Number.");
        }

        public static string InitialSerialNumber = "";


        public void EnterMeters(string value)
        {
            Meters.Click();
            Meters.SendKeys(value);
            InitialMeterValue = driver.FindElement(By.Id("MachineHour")).GetAttribute("value");
            Util.Log("Entered Meters.");
        }

        public static string InitialMeterValue = "";


        public void SelectMachineCondition()
        {
            Condition.Click();
            // pick a condition value.
            Util.Log("Clicked a Condition Radial Button");
        }

        public void CheckMachineOption()
        {
            MachineOptions.Click();
            Util.Log("Checked a Machine Option Checkbox");
        }

        public SSOLogin ClickLoginAndContinue()
        {
            LoginAndContinue.Click();
            Util.Log("Clicked Login and continue button");
            return new SSOLogin(driver);
        }

        public PurchaseAppraisals ClickContinue()
        {
            Continue.Click();
            Util.Log("Clicked the Continue Button");
            return new PurchaseAppraisals(driver);
        }

        public CompleteAppraisal ClickContinueToComplete()
        {
            Continue.Click();
            Util.Log("Clicked the Continue Button");
            return new CompleteAppraisal(driver);
        }
    }
}