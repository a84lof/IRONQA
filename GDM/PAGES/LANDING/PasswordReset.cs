namespace IRONQA.GDM.PAGES.LANDING
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    
    public class ResetPassword
    {
        private IWebDriver driver;
        public ResetPassword(IWebDriver _driver) => driver = _driver;

        public void ConfirmOnResetPasswordPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("Login/ForgotPassword");
            Util.Log("On Forgot Password Page");
        }
    }
}