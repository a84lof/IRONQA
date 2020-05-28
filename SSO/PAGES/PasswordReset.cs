namespace IRONQA.SSO.PAGES
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class PasswordReset
    {
        private IWebDriver driver;
        public PasswordReset(IWebDriver _driver) => driver = _driver;
        private IWebElement Email => driver.FindElement(By.CssSelector("#email"));
        private IWebElement RecoverPassword => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > form > fieldset > div > button"));
        private IWebElement ReturnToLogin => driver.FindElement(By.CssSelector("#return-to-login"));
        private IWebElement ResetSuccessMessage => driver.FindElement(By.CssSelector("body > div.page--sso > div > div > div > div > form > fieldset > div.success.callout > p"));

        public void ConfirmOnPasswordResetPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("ForgotPassword");
            Util.Log("On Password Reset Page.");
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
            Util.Log("Entered Email Address.");
        }

        public void ClickRecoverPassword()
        {
            RecoverPassword.Click();
            Util.Log("Clicked Recover Password.");
        }

        public SSOLogin ClickReturnToLogin()
        {
            ReturnToLogin.Click();
            Util.Log("Clicked Return To Login.");
            return new SSOLogin(driver);
        }

        public void ConfirmSuccessMessage()
        {
            Thread.Sleep(3000);
            try
            {
                Assert.IsTrue(RecoverPassword.Displayed);
                Util.Log("Success Message Displayed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }
    }
}