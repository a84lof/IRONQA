namespace IRONQA.GUIDES.PAGES.SHARED
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class ProvideFeedback
    {
        private IWebDriver driver;
        public ProvideFeedback(IWebDriver _driver) => driver = _driver;
        private IWebElement General => driver.FindElement(By.Id("panel1v-label"));
        private IWebElement Comments => driver.FindElement(By.CssSelector("#panel1v > div > div > div:nth-child(6)>#Questions_0__UserEnteredValue"));
        private IWebElement FeedBackModal => driver.FindElement(By.CssSelector("#addFeedbackModal"));
        private IWebElement Cancel => driver.FindElement(By.CssSelector("#beforeFeedbackFooter>#modal-close-button"));
        private IWebElement Submit => driver.FindElement(By.CssSelector("#beforeFeedbackFooter > button.button.success"));

        public void ConfirmOnProvideFeedbackPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForElement("CssSelector","#panel1v > div > div > div:nth-child(6)>#Questions_0__UserEnteredValue");
        }
        
        public void AddComments(string comment)
        {
            Comments.Click();
            Comments.SendKeys(comment);
            Thread.Sleep(500);
            Util.Log("Added Comment.");
        }

        public void ClickCancel()
        {
            Cancel.Click();
            Thread.Sleep(500);
            Util.Log("Clicked Cancel Button");
        }

        public void ClickSubmit()
        {
            Submit.Click();
            Thread.Sleep(500);
            Util.Log("Clicked Submit Button");
        }
    }
}
