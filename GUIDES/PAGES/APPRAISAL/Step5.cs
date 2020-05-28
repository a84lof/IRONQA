namespace IRONQA.GUIDES.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class Step5
    {
        private IWebDriver driver;
        public Step5(IWebDriver _driver) => driver = _driver;
        private IWebElement Specifications => driver.FindElement(By.CssSelector("#panel1d-label > h2 > i"));
        private IWebElement FirstName => driver.FindElement(By.CssSelector("div.flex-row:nth-child(1) > div:nth-child(1) > input:nth-child(2)"));
        private IWebElement LastName => driver.FindElement(By.CssSelector("div.flex-row:nth-child(1) > div:nth-child(2) > input:nth-child(2)"));
        private IWebElement Company => driver.FindElement(By.CssSelector("div.flex-row:nth-child(1) > div:nth-child(3) > input:nth-child(2)"));
        private IWebElement Address => driver.FindElement(By.CssSelector("div.flex-row:nth-child(2) > div:nth-child(1) > input:nth-child(2)"));
        private IWebElement City => driver.FindElement(By.CssSelector("div.flex-row:nth-child(2) > div:nth-child(2) > input:nth-child(2)"));
        private IWebElement StateProvince => driver.FindElement(By.CssSelector("div.flex-row:nth-child(2) > div:nth-child(3) > label:nth-child(1) > input:nth-child(2)"));
        private IWebElement PhoneNumber => driver.FindElement(By.CssSelector("div.flex-row:nth-child(3) > div:nth-child(1) > label:nth-child(1) > input:nth-child(2)"));
        private IWebElement EmailAddress => driver.FindElement(By.CssSelector("div.flex-row:nth-child(3) > div:nth-child(2) > label:nth-child(1) > input:nth-child(2)"));
        private IWebElement TradeValue => driver.FindElement(By.CssSelector("div.flex-row:nth-child(4) > div:nth-child(1) > input:nth-child(2)"));
        private IWebElement TradeDetails => driver.FindElement(By.CssSelector(".trade-details > textarea:nth-child(2)"));
        private IWebElement AddThisProspect => driver.FindElement(By.CssSelector(".button--save"));
        private IWebElement DeleteThisProspect => driver.FindElement(By.CssSelector("#prospect-info-form > div:nth-child(7) > div > button.button.button--delete"));
        private IWebElement Clear => driver.FindElement(By.CssSelector("button.button:nth-child(2)"));
        private IWebElement EditThisProspect => driver.FindElement(By.CssSelector("#prospect-0 > div:nth-child(7) > div > button"));
        private IWebElement StartNewAppraisalConfirmation => driver.FindElement(By.Id("modal--accept"));
        private IWebElement SaveDownload => driver.FindElement(By.Id("link--save-and-download-appraisal"));
        private IWebElement StartNewAppraisal => driver.FindElement(By.CssSelector("#root > div > div.off-canvas-wrapper > div > div.off-canvas-content > main > div > nav > div > div:nth-child(2) > a"));

        public void ConfirmOnStep5()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/step5");
            Util.Log("On Step 5.");
        }

        public void GenerateProspect()
        {
            FirstName.SendKeys(Users.FirstName);
            LastName.SendKeys(Users.LastName);
            Company.SendKeys(Users.CompanyName);
            Address.SendKeys(Users.Address);
            City.SendKeys(Users.City);
            StateProvince.SendKeys(Users.Zip);
            PhoneNumber.SendKeys(Users.HyphenatedPhoneNumber);
            EmailAddress.SendKeys(Users.USBasicUser);
            ClickAddProspect();
            Util.Log("Prospect Generated.");
        }

        public void EnterFirstName(string firstname)
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","div.flex-row:nth-child(1) > div:nth-child(1) > input:nth-child(2)");
            FirstName.SendKeys(firstname);
            Util.Log("First Name Entered");
        }

        public void EnterLastName(string lastName)
        {
            LastName.SendKeys(lastName);
            Util.Log("Last Name Entered");
        }

        public void EnterCompany(string company)
        {
            Company.SendKeys(company);
            Util.Log("Company Entered");
        }

        public void EnterAddress(string address)
        {
            Address.SendKeys(address);
            Util.Log("Address Entered");
        }

        public void EnterCity(string city)
        {
            City.SendKeys(city);
            Util.Log("City Entered");
        }

        public void EnterStateProvince(string stateProv)
        {
            StateProvince.SendKeys(stateProv);
            Util.Log("State/Province Entered");
        }

        public void EnterPhoneNumber(string phoneNumber)
        {
            PhoneNumber.SendKeys(phoneNumber);
            Util.Log("Phone Number Entered");
        }

        public void EnterEmailAddress(string emailAddress)
        {
            EmailAddress.SendKeys(emailAddress);
            Util.Log("Email Address Entered");
        }

        public void EnterTradeValue(string value)
        {
            TradeValue.SendKeys(value);
            Util.Log("Trade Value Entered");
        }

        public void EnterTradeDetails(string details)
        {
            TradeDetails.SendKeys(details);
            Util.Log("Trade Details Entered");
        }

        public void ClickAddProspect()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            AddThisProspect.Click();
            Thread.Sleep(1000);
            Util.Log("Add Prospect Button Clicked");
        }

        public void ClickClear()
        {
            Clear.Click();
            Util.Log("Clear Button Clicked");
        }

        public void ConfirmProspectAdded()
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("CssSelector","#prospect-0 > div:nth-child(7) > div > button");
            Util.Log("Prospect Confirmed.");
        }

        public void ClickSaveDownloadStep5()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            Thread.Sleep(1000);
            SaveDownload.Click();
            util.CloseNewTab();
            Util.Log("Clicked Save & Download Button.");
        }

        public void ClickEditThisProspect()
        {
            EditThisProspect.Click();
            Util.Log("Edit This Prospect Clicked.");
        }

        public void ClickDeleteThisProspect()
        {
            DeleteThisProspect.Click();
            Util.Log("Delete This Prospect Clicked.");
        }

        public void ConfirmProspectDeleted()
        {
            try
            {
                Thread.Sleep(1500);
                Assert.IsTrue(!EditThisProspect.Displayed);
                Util.Log("Confirmed Prospect Deleted.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }
    }
}
