namespace IRONQA.GDM.PAGES.MODELMGR
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    
    public class Login
    {
        private IWebDriver driver;
        public Login(IWebDriver _driver) => driver = _driver;
        public IWebElement Email => driver.FindElement(By.Id("Email"));
        public IWebElement Password => driver.FindElement(By.Id("Password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("btnLogin"));

        public void ConfirmOnLoginPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","Email");
            Util.Log("On Model Manager Login.");
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
            Util.Log("Entered Email.");
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
            Util.Log("Entered Password.");
        }

        public EquipmentModels ClickLogin()
        {
            LoginButton.Click();
            Util.Log("Clicked Login.");
            return new EquipmentModels(driver);
        }
    }
}