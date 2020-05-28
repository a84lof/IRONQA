namespace IRONQA.SSO.PAGES
{
    using IRONQA.FSBO.PAGES.APPRAISAL;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class SSOLogin
    {
        private IWebDriver driver;
        public SSOLogin(IWebDriver _driver) => driver = _driver;
        private IWebElement Email => driver.FindElement(By.CssSelector("#email"));
        private IWebElement Password => driver.FindElement(By.CssSelector("#password"));
        private IWebElement Log_In => driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div/form/fieldset/div/button"));
        private IWebElement Register => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > aside.register > a"));
        private IWebElement ForgotMyPassword => driver.FindElement(By.Id("forgot-password"));
        private IWebElement PasswordError => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > form > fieldset > div.alert.callout > p"));
        private IWebElement CallSupport => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > aside.help > a:nth-child(3)"));
        private IWebElement EmailSupport => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > aside.help > a:nth-child(4)"));
        private IWebElement PrivacyNotice => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > aside.copyright-tos > div > a:nth-child(1)"));
        private IWebElement TermsOfService => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > aside.copyright-tos > div > a:nth-child(2)"));

        public void ConfirmOnLoginPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForElement("id","forgot-password");
            Util.Log("On Login Page.");
        }

        public PasswordReset ClickForgotMyPassword()
        {
            ForgotMyPassword.Click();
            Util.Log("Clicked Forgot My Password.");
            return new PasswordReset(driver);
        }

        public Registration ClickRegister()
        {
            Register.Click();
            Util.Log("Clicked Register Button.");
            return new Registration(driver);
        }

        public SSOHome SubmitValidCredentials(string email, string password)
        {
            Thread.Sleep(1000);
            Email.SendKeys(email);
            Password.SendKeys(password);
            Log_In.Click();
            Util.Log(email + " Logged In");
            return new SSOHome(driver);
        }

        public void ConfirmPasswordError()
        {
            try
            {
                Assert.IsTrue(PasswordError.Displayed);
                Util.Log("Password Error Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public PurchaseAppraisals LoginToContinueAppraisal(string email, string password)
        {
            Util util = new Util(driver);
            util.WaitForElement("CssSelector","body > div.page--sso > div > div > div > div > form > fieldset > div > button");
            Email.SendKeys(email);
            Password.SendKeys(password);
            Log_In.Click();
            Util.Log("Valid Credentials Submitted.. Logging In");
            return new PurchaseAppraisals(driver);
        }

        public CompleteAppraisal LoginToCompleteAppraisal(string email, string password)
        {
            Util util = new Util(driver);
            util.WaitForElement("CssSelector","body > div.page--sso > div > div > div > div > form > fieldset > div > button");
            Email.SendKeys(email);
            Password.SendKeys(password);
            Log_In.Click();
            Util.Log("Valid Credentials Submitted.. Logging In");
            return new CompleteAppraisal(driver);
        }
    }
}