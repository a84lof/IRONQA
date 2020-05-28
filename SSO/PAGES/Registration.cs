namespace IRONQA.SSO.PAGES
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    public class Registration
    {
        private IWebDriver driver;
        public Registration(IWebDriver _driver) => driver = _driver;
        private IWebElement Email => driver.FindElement(By.CssSelector("#Email"));
        private IWebElement EmailAgain => driver.FindElement(By.CssSelector("#EmailConfirm"));
        private IWebElement FirstName => driver.FindElement(By.CssSelector("#FirstName"));
        private IWebElement LastName => driver.FindElement(By.CssSelector("#LastName"));
        private IWebElement PhoneNumber => driver.FindElement(By.CssSelector("#PhoneNumber"));
        private IWebElement Country => driver.FindElement(By.Name("Country"));
        private IWebElement Register => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > form > fieldset > div.flex-wrapper > input"));
        private IWebElement Login => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > aside.login > a"));
        private IWebElement Success => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > aside.confirmation > h1"));
        private IWebElement Message => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > aside.confirmation > div"));
        private IWebElement SuccessLogin => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > aside.login > a"));

        public void ConfirmOnRegistrationPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/home/register");
            Util.Log("On Registration Page.");
        }

        public void ClickRegister()
        {
            Register.Click();
            Util.Log("Clicked Register.");
        }

        public void ConfirmSuccessMessage()
        {
            Assert.IsTrue(Success.Displayed);
            Util.Log("Success Message Displayed.");
        }

        public void EnterEmail(string email)
        {
            Util util = new Util(driver);
            util.WaitForElement("CssSelector","#Email");
            Email.SendKeys(email);
            Util.Log("Entered Email Address.");
        }

        public void EnterEmailAgain(string email)
        {
            EmailAgain.SendKeys(email);
            Util.Log("Entered Email Address Again.");
        }

        public void EnterFirstName(string first)
        {
            FirstName.SendKeys(first);
            Util.Log("Entered First Name.");
        }

        public void EnterLastName(string last)
        {
            LastName.SendKeys(last);
            Util.Log("Entered Last Name.");
        }

        public void EnterPhoneNumber(string number)
        {
            PhoneNumber.SendKeys(number);
            Util.Log("Entered Phone Number.");
        }

        public void SelectCountry(string country)
        {
            Country.SendKeys(country);
            Util.Log("Selected Country "+country);
        }

        public static string RandomEmail { get; set; }

        public string GetRandomEmail()
        {
            string re = Users.RandomQAEmail;
            RandomEmail = re;
            return re;
        }

        public void ConfirmRegistrationSuccess()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);

            try
            {
                Assert.True(Success.Displayed);
                Util.Log("Success Message Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex + "Success Message Not Displayed."); }
        }
    }
}