namespace IRONQA.GDM.PAGES.VALUESMGR
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class PublishStatus
    {
        private IWebDriver driver;
        public PublishStatus(IWebDriver _driver) => driver = _driver;
        private IWebElement Countdown => driver.FindElement(By.CssSelector("#guides-manager-application > div > div.issue-table-row.single-cell > div > span"));
        private IWebElement Status => driver.FindElement(By.Id("status-selector-31"));
        private IWebElement NoteText => driver.FindElement(By.CssSelector("#guides-manager-application > div.prompt-modal > textarea"));
        private IWebElement Ok => driver.FindElement(By.CssSelector("#guides-manager-application > div.prompt-modal > div > div.modal-button.modal-button-ok"));
        private IWebElement Cancel => driver.FindElement(By.CssSelector("#guides-manager-application > div.prompt-modal > div > div.modal-button.modal-button-cancel"));

        public void ConfirmOnPublishStatusPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("GuidesManager");
            Util.Log("On Manage Publish Progress Page");
        }

        public void CreateNote()
        {
            //Row1OpenNote.Click();
            NoteText.SendKeys("This is a note.");
            Ok.Click();
            Util.Log("Note Created");
        }

        public void ChangeStatus(string equipmentType, string valuationGroup, string desiredStatus)
        {
            Thread.Sleep(2000);
            IWebElement StatusDropdown = driver.FindElement(By.XPath("//*[contains(@class,'"+equipmentType+"') and contains(@class,'"+valuationGroup+"')]/td[contains(@class,'status')]/select"));
            StatusDropdown.Click();
            Thread.Sleep(500);
            // Accepts desiredStatus: 'Not Started', 'In Progress', 'Hole', 'Complete', 'Approved' 
            StatusDropdown.SendKeys(desiredStatus);
            Util.Log("Changed VG Status To "+ desiredStatus);
        }

        public decimal GetCountdown()
        {
            return Decimal.Parse(Countdown.Text.Replace("%", ""));
        }

        public void CompareCountdown(decimal percent1, decimal percent2)
        {
            try
            {
                Assert.IsTrue(percent1 >= percent2);
                Util.Log("Countdown Confirmed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ClickPrePublish(string valuationGroup, string equipmentType)
        {// Status must be 'Complete' or 'Accepted' for Prepublish Button to display.
            IWebElement Prepublish = driver.FindElement(By.XPath("//*[contains(@class,'"+equipmentType+"') and contains(@class,'"+valuationGroup+"')]/td[7]/span/button[contains(@id,'prepublishValuationGroup')]"));
            Prepublish.Click();
            Util util = new Util(driver);
            util.DismissAlert();
            Thread.Sleep(10000);

            //Wait for Prepublishing to Complete
            util.WaitForElementNotDisplayed("XPath", "//*[contains(@class,'"+equipmentType+"') and contains(@class,'"+valuationGroup+"')]/td/span[contains(@class,'prepublishPanel')]/button[contains(text(),'Prepublishing')]");
            Thread.Sleep(1000);
            Util.Log("Prepublished "+ valuationGroup +" "+equipmentType);
        }
    }
}