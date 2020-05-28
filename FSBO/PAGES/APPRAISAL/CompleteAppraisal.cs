namespace IRONQA.FSBO.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    public class CompleteAppraisal
    {
        private IWebDriver driver;
        public CompleteAppraisal(IWebDriver _driver) => driver = _driver;
        private IWebElement ConfirmCompleteAppraisal => driver.FindElement(By.ClassName("your-appraisal-value"));
        private IWebElement tdTest => driver.FindElement(By.ClassName("value-td"));

        public void ConfirmOnCompleteAppraisalPage()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForElement("Name","your-appraisal-value");
            Util.Log("On Complete Appraisal Page.");
        }

        public static string FinalAppraisalSerial = "";

        public void GetAppraisalSerial()
        {
            // switching driver to handle the iFrame
            driver.SwitchTo().Frame(driver.FindElement(By.Id("childframe")));
            FinalAppraisalSerial = driver.FindElement(By.CssSelector("#header-table>tbody>tr:nth-child(3)>.value-td")).Text;
            // switching driver back to the original
            driver.SwitchTo().DefaultContent();
            Util.Log("found the value of the Serial No on the appraisal");
        }

        public static string FinalMeterValue = "";

        public void GetAppraisalMeter()
        {
            // switching driver to handle the iFrame
            driver.SwitchTo().Frame(driver.FindElement(By.Id("childframe")));
            var AppMeterNo = driver.FindElement(By.CssSelector("#header-table>tbody>tr:nth-child(4)>.value-td")).Text;
            // switching driver back to the original
            driver.SwitchTo().DefaultContent();
            Util.Log("found the value of the Meter No on the appraisal");
            // having to split the result to only get the numbers back
            string[] meterNum = AppMeterNo.Split(" ");
            FinalMeterValue = int.Parse(meterNum[0]).ToString();
        }

        public void CheckAppraisalForAccuracy(string initialSerial, string finalSerial, string intitialMeter, string finalMeter)
        {
            try
            {
                Assert.AreEqual(initialSerial, finalSerial);
                Assert.AreEqual(intitialMeter, finalMeter);
                Util.Log("Completed the Serial and Meter Comparisons");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }
    }
}