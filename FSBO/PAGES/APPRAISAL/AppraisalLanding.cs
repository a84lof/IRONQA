namespace IRONQA.FSBO.PAGES.APPRAISAL
{
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class AppraisalLanding
    {
        private IWebDriver driver;
        public AppraisalLanding(IWebDriver _driver) => driver = _driver;
        private IWebElement Type => driver.FindElement(By.XPath("//select[@onchange='CallServer(document.forms[0].region.value + '|' + document.forms[0].SelOptType.value + '|' + document.forms[0].SelOptMake.value + '|' + document.forms[0].SelOptModel.value, 'Type')']"));
        private IWebElement Make => driver.FindElement(By.XPath("//select[@onchange='CallServer(document.forms[0].region.value + '|' + document.forms[0].SelOptType.value + '|' + document.forms[0].SelOptMake.value + '|' + document.forms[0].SelOptModel.value, 'Make')']"));
        private IWebElement Model => driver.FindElement(By.XPath("//select[@onchange='CallServer(document.forms[0].region.value + '|' + document.forms[0].SelOptType.value + '|' + document.forms[0].SelOptMake.value + '|' + document.forms[0].SelOptModel.value, 'Model')']"));
        private IWebElement Year => driver.FindElement(By.XPath("//select[@onchange='YearSelected()']"));
        private IWebElement Buying => driver.FindElement(By.Name("Buying"));

        public void ConfirmOnAppraiserPage()
        {
            Util util = new Util(driver);
            util.SwitchToNewTab();
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/fsbo/");
            Util.Log("On Appraisal Page.");
        }

        public void ConfirmOnBasicUserAppraisal()
        {
            Util util = new Util(driver);
            util.SwitchToNewTab();
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL(TestDetails.AppraiserURL);
            Util.Log("On Basic User Appraisal Page.");
        }

        public void ConfirmOnLoggedOutAppraiserPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL(TestDetails.LoggedOutAppraiserURL);
            Util.Log("On Logged out Appraiser Page");
        }

        public void ConfirmOnTMMYPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL(TestDetails.LoggedOutTMMYUrl);
            Util.Log("On Logged Out TMMY Page");
        }

        public enum Regions { WC, EC, NE, SE, SW, NW, NC};

        public void SelectRegion(Regions region)
        {
            IWebElement area = driver.FindElement(By.XPath("//*[contains(@id,'regions')]/a [contains(@id,'"+region.ToString()+"')]"));
            area.Click();
            Util.Log("Selected "+region+" Region.");
        }

        public void SelectType(string type)
        {
            Type.Click();
            Type.SendKeys(type);
            Type.SendKeys(Keys.Tab);
            Thread.Sleep(1500);
            Util.Log("Entered Type "+type);
        }

        public void SelectMake(string make)
        {
            Make.Click();
            Make.SendKeys(make);
            Make.SendKeys(Keys.Tab);
            Thread.Sleep(1500);
            Util.Log("Entered Make "+make);
        }
        public void SelectModel(string model)
        {
            Model.Click();
            Model.SendKeys(model);
            Model.SendKeys(Keys.Tab);
            Thread.Sleep(1500);
            Util.Log("Entered Model "+model);
        }

        public void SelectYear(string year)
        {
            Year.Click();
            Year.SendKeys(year);
            Year.SendKeys(Keys.Enter);
            Thread.Sleep(500);
            Util.Log("Entered Year "+Year);
        }

        public EquipmentDetails ClickBuying()
        {
            Buying.Click();
            Util.Log("Clicked Buying");
            return new EquipmentDetails(driver);
        }
    }
}
