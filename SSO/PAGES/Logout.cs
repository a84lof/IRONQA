namespace IRONQA.SSO.PAGES
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;

    public class Logout
    {
        private IWebDriver driver;
        public Logout(IWebDriver _driver) => driver = _driver;
        private IWebElement LoginAgain => driver.FindElement(By.Id("loginagain"));

        public void ConfirmOnLogoutPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/Logout");
            Util.Log("On Logout Page.");
        }

        public SSOLogin ClickLoginAgain()
        {
            LoginAgain.Click();
            Util.Log("Clicked Login Again Button.");
            return new SSOLogin(driver);
        }
    }
}