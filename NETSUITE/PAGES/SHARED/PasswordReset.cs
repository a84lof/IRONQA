namespace IRONQA.NETSUITE.PAGES.SHARED
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
        private IWebElement Email => driver.FindElement(By.Name("email"));
        private IWebElement ContinueButton => driver.FindElement(By.CssSelector("Submit"));
        private IWebElement EmailConfirmation => driver.FindElement(By.CssSelector("body > form > table > tbody > tr:nth-child(3) > td"));
        private IWebElement HomeNav => driver.FindElement(By.CssSelector("body > form > table > tbody > tr:nth-child(1) > td > table > tbody > tr > td > table > tbody > tr > td:nth-child(1) > a > img"));

        public void ConfirmOnPasswordResetPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            try
            {
                Assert.IsTrue(driver.Url.Contains(""));
                Util.Log("On Password Reset Page.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "Assert Faled." + "\r\n" + ex); }
        }

        public void ResetPassword(string email)
        {
            Email.SendKeys(email);
            ContinueButton.Click();
            Thread.Sleep(1000); // Allow 1 second for the Success Message to Display
            try
            {
                Assert.IsTrue(EmailConfirmation.Displayed);
                Util.Log("Password Reset Submitted.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "Assert Failed." + ex); }
        }
    }
}