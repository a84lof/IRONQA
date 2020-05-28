namespace IRONQA.GUIDES.PAGES.HELPCENTER
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    
    public class Profile
    {
        private IWebDriver driver;
        public Profile(IWebDriver _driver) => driver = _driver;
        private IWebElement Something => driver.FindElement(By.CssSelector(""));

        public void ConfirmOnMyProfilePage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("account/profile/");
            Util.Log("On My Profile Page");
        }
    }
}
