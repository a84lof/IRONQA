namespace IRONQA.GUIDES.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class CustomerInfo
    {
        private IWebDriver driver;
        public CustomerInfo(IWebDriver _driver) => driver = _driver;
        private IWebElement ContinueAppraisal => driver.FindElement(By.CssSelector("#back--button > div > span"));
        private IWebElement FirstName => driver.FindElement(By.CssSelector("#customer-info-form > div:nth-child(1) > div.small-6.medium-4.medium-offset-1.columns > input[type='text']"));
        private IWebElement LastName => driver.FindElement(By.CssSelector("#customer-info-form > div:nth-child(1) > div.small-6.medium-4.columns.end > input[type='text']"));
        private IWebElement Company => driver.FindElement(By.CssSelector("#customer-info-form > div:nth-child(2) > div > input[type='text']"));
        private IWebElement PhoneNumber => driver.FindElement(By.CssSelector("#phone-number-label > input[type='text']"));
        private IWebElement EmailAddress => driver.FindElement(By.CssSelector("#email-label > input[type='text']"));
        private IWebElement SaveChanges => driver.FindElement(By.CssSelector("#customer-info-form > div:nth-child(4) > div > div > button.button.button--save"));
        private IWebElement Cancel => driver.FindElement(By.CssSelector("#customer-info-form > div:nth-child(4) > div > div > button.button.button--cancel"));


        public void ConfirmOnCustomerInfoPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("customer");
            Util.Log("On Customer Info Page.");
        }

        public void EnterFirstName(string name)
        {
            FirstName.SendKeys(name);
            Util.Log("First Name Entered.");
        }

        public void EnterLastName(string name)
        {
            LastName.SendKeys(name);
            Util.Log("Last Name Entered.");
        }

        public void EnterCompany(string company)
        {
            Company.SendKeys(company);
            Util.Log("Company Entered.");
        }

        public void EnterPhoneNumber(string number)
        {
            PhoneNumber.SendKeys(number);
            Util.Log("Phone Number Entered.");
        }

        public void EnterEmail(string email)
        {
            EmailAddress.SendKeys(email);
            Util.Log("Email Address Entered.");
        }

        public void ClickSaveChanges()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#customer-info-form > div:nth-child(4) > div > div > button.button.button--save");
            SaveChanges.Click();
            Util.Log("Clicked Save Changes.");
        }

        public Step2 ClickContinueAppraisal()
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript("arguments[0].scrollIntoView(false);", ContinueAppraisal);
            Util util = new Util(driver);
            util.WaitForClickableElement("Id","back--button");
            Thread.Sleep(500);
            ContinueAppraisal.Click();
            Util.Log("Clicked Continue Appraisal.");
            return new Step2(driver);
        }
    }
}
