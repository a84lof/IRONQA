namespace IRONQA.GDM.PAGES.USERMGR
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class UserManager
    {
        private IWebDriver driver;
        public UserManager(IWebDriver _driver) => driver = _driver;
        private IWebElement NewUserEmail => driver.FindElement(By.Id("UserSelector"));
        private IWebElement ModelManagerRole => driver.FindElement(By.Id("NewUserModelsRoleId"));
        private IWebElement ReportManagerRole => driver.FindElement(By.Id("NewUserReportsRoleId"));
        private IWebElement ValueManagerRole => driver.FindElement(By.Id("NewUserValuesRoleId"));
        private IWebElement AddUser => driver.FindElement(By.Id("addUserButton"));
        private IWebElement Reset => driver.FindElement(By.CssSelector("#productYearDiv > div > div.small-2.columns > a"));

        public void ConfirmOnManageUsersPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("Admin/UserAdmin");
            Util.Log("On Manage Users");
        }
    }
}