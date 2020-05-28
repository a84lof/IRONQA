namespace IRONQA.GUIDES.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class SerialNumber
    {
        private IWebDriver driver;
        public SerialNumber(IWebDriver _driver) => driver = _driver;
        private IWebElement ContinueAppraisal => driver.FindElement(By.Id("back--button"));
        private IWebElement SerialNumberInput => driver.FindElement(By.Id("serial--input"));
        private IWebElement SaveChanges => driver.FindElement(By.Id("serial--save"));
        private IWebElement Cancel => driver.FindElement(By.Id("serial--cancel"));

        public void ConfirmOnSerialNumberPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("serial-number");
            Util.Log("On Serial Number Page");
        }

        public void EnterSerialNumber(string number)
        {
            SerialNumberInput.SendKeys(number);
            Util.Log("Serial Number Entered");
        }

        public void ClickSaveChanges()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("Id","serial--save");
            SaveChanges.Click();
            Util.Log("Clicked Save Changes");
        }

        public Step2 ClickContinueAppraisal()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("Id","back--button");
            ContinueAppraisal.Click();
            Util.Log("Clicked Continue Appraisal");
            return new Step2(driver);
        }
    }
}
