namespace IRONQA.NETSUITE.PAGES.SHARED
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    
    public class NSLogin
    {
        private IWebDriver driver;
        public NSLogin(IWebDriver _driver) => driver = _driver;
        private IWebElement Email => driver.FindElement(By.Id("userName"));
        private IWebElement Password => driver.FindElement(By.Id("password"));
        private IWebElement RememberMe => driver.FindElement(By.Name("rememberme"));
        private IWebElement ForgotPassword => driver.FindElement(By.CssSelector("#maininterior > div > form > table:nth-child(1) > tbody > tr > td > table > tbody > tr > td > table > tbody > tr:nth-child(5) > td > a"));
        private IWebElement LoginButton => driver.FindElement(By.Id("submitButton"));
        private IWebElement Challenge => driver.FindElement(By.CssSelector("#null"));

        public void ConfirmLoginPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            try
            {
                Assert.IsTrue(driver.Url.Contains(""));
                Util.Log("On Login Page.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "Assert Failed." + ex); }
        }

        public Authentication SubmitLogin(string email, string password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
            LoginButton.Click();
            Util.Log("Login Credentials Submitted.");
            return new Authentication(driver);
        }

        public void ClickRememberMe()
        {
            RememberMe.Click();
            Util.Log("Clicked Remember Me Checkbox");
        }
        
        public PasswordReset ClickForgotPassword()
        {
            ForgotPassword.Click();
            Util.Log("Clicked Forgot Password");
            return new PasswordReset(driver);
        }

        public Nav AnswerValidationQuestion()
        {
            Challenge.SendKeys("Bakers Bridge");
            Challenge.SendKeys(Keys.Enter);
            return new Nav(driver);
        }
    }
}