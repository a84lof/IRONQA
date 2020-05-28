namespace IRONQA.FSBO.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using System;
    using OpenQA.Selenium;

    public class IncompleteAppraisals
    {
        private IWebDriver driver;
        public IncompleteAppraisals(IWebDriver _driver) => driver = _driver;
        private IWebElement NameLabel => driver.FindElement(By.CssSelector("#Content_Content_LoggedMessage1_ThisControl > p"));
        private IWebElement AppraisalTokens => driver.FindElement(By.CssSelector("#Content_Content_LoggedMessage1_appraisalwithouttokens > a > strong"));
        private IWebElement FSBOTokens => driver.FindElement(By.Id("#Content_Content_LoggedMessage1_appraisalwithouttokens > a > strong"));
        private IWebElement ZeroIncompleteMessage => driver.FindElement(By.Id("#Content_Content_incompleteAppraisalsNonePanel > h3"));
        private IWebElement BuyAppraisals => driver.FindElement(By.Id("#Content_Content_LoggedMessage1_buyTokenButtonAppraiser"));
        private IWebElement BuyFSBO => driver.FindElement(By.Id("#Content_Content_LoggedMessage1_buyTokenButtonFsbo"));

        public void ConfirmOnIncompleteAppraisalsPage()
        {
            Util util = new Util(driver);
            util.SwitchToNewTab();
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/incompleteappraisals");
            Util.Log("On Appraisal Page.");
        }
    }
}
