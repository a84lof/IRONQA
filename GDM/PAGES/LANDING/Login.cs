namespace IRONQA.GDM.PAGES.LANDING
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    
    public class Login
    {
        private IWebDriver driver;
        public Login(IWebDriver _driver) => driver = _driver;
        private IWebElement Email => driver.FindElement(By.Name("username"));
        private IWebElement Password => driver.FindElement(By.Name("password"));
        private IWebElement LoginButton => driver.FindElement(By.CssSelector("body > div.div-body-wrapper > div > div > div > form > fieldset > div > p > button"));
        private IWebElement ErrEmail => driver.FindElement(By.CssSelector("body > div:nth-child(5) > div > div > form > fieldset > div > label:nth-child(2) > span"));
        private IWebElement ErrPassword => driver.FindElement(By.CssSelector("body > div:nth-child(5) > div > div > form > fieldset > div > label:nth-child(3) > span"));
        private IWebElement ForgotPassword => driver.FindElement(By.Id("forgot"));
        private IWebElement RememberMe => driver.FindElement(By.CssSelector("body > div:nth-child(5) > div > div > form > fieldset > div > label:nth-child(5) > input[type='checkbox']"));

        public void ConfirmOnLoginPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/Login");
            Util.Log("On GDM Login Page");
        }

        public Home SubmitValidCredentials(string email, string password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
            LoginButton.Click();
            System.Threading.Thread.Sleep(500);
            Util.Log("Valid Credentials Submitted.. Logging In");
            return new Home(driver);
        }

        public void EmailErrorGenerated()
        {
            try
            {
                Assert.IsTrue(ErrEmail.Displayed);
                Util.Log("Email Error Displayed");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void PasswordErrorGenerated()
        {
            try
            {
                Assert.IsTrue(ErrPassword.Displayed);
                Util.Log("Password Error Displayed");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public ResetPassword ClickForgotMyPassword()
        {
            ForgotPassword.Click();
            Util.Log("Clicked Forgot My Password");
            return new ResetPassword(driver);
        }
    }
}