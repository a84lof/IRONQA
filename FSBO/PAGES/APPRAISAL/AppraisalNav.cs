namespace IRONQA.FSBO.PAGES.APPRAISAL
{
    using IRONQA.FSBO.PAGES.FORSALEBYOWNER;
    using IRONQA.SSO.PAGES;
    using IRONQA.STORE.PAGES.MYACCOUNT;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    
    public class AppraisalNav
    {
        private IWebDriver driver;
        public AppraisalNav(IWebDriver _driver) => driver = _driver;
        private IWebElement SampleAppraisal => driver.FindElement(By.CssSelector("#Content_A1"));
        private IWebElement StartNewAppraisal => driver.FindElement(By.CssSelector("#Content_A2"));
        private IWebElement BuyAppraisals => driver.FindElement(By.CssSelector("#Content_A3"));
        private IWebElement ViewMyAppraisals => driver.FindElement(By.CssSelector("#Content_A4"));
        private IWebElement ModifyAccount => driver.FindElement(By.CssSelector("#Content_A5"));
        private IWebElement LogOut => driver.FindElement(By.Id("Content_LogoutLink"));
        private IWebElement FSBO => driver.FindElement(By.CssSelector("#Content_A6"));

        public void ConfirmAppraiserNav()
        {
            try
            {
                Assert.IsTrue(SampleAppraisal.Displayed);
                Util.Log("Appraiser Nav Confirmed.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public SampleAppraisal ClickSampleAppraisal()
        {
            SampleAppraisal.Click();
            Util.Log("Clicked Sample Appraisal Button.");
            return new SampleAppraisal(driver);
        }

        public AppraisalLanding ClickStartNewAppraisal()
        {
            StartNewAppraisal.Click();
            Util.Log("Clicked Start New Appraisal.");
            return new AppraisalLanding(driver);
        }

        public SSOLogin ClickBuyAppraisals()
        {
            BuyAppraisals.Click();
            Util.Log("Clicked Buy Appraisals Button.");
            return new SSOLogin(driver);
        }

        public MyAppraisals ClickMyAppraisals()
        {
            ViewMyAppraisals.Click();
            Util.Log("Clicked View My Appraisals Button.");
            return new MyAppraisals(driver);
        }

        public Overview ClickModifyAccount()
        {
            ModifyAccount.Click();
            Util.Log("Clicked Modify Account Button.");
            return new Overview(driver);
        }

        public AppraisalLanding ClickLogOut()
        {
            LogOut.Click();
            Util.Log("Clicked Log Out Button.");
            return new AppraisalLanding(driver);
        }

        public Step1 ClickForSaleByOwner()
        {
            FSBO.Click();
            return new Step1(driver);
        }
    }
}

