namespace IRONQA.NETSUITE.PAGES.SHARED
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OtpNet;
    using System;
    using System.Threading;

    public class Authentication
    {
        private IWebDriver driver;
        public Authentication(IWebDriver _driver) => driver = _driver;
        private IWebElement VerificationCode => driver.FindElement(By.XPath("//div[contains(@class,'n-loginchallenge-phone_digit-code')]/input"));
        private IWebElement Submit => driver.FindElement(By.XPath("//div[contains(@n-login-id,'button-login-next')]/span"));

        public void ConfirmAuthenticationPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//div[contains(@class,'n-loginchallenge-phone_digit-code')]/input");
            try{
                Assert.IsTrue(VerificationCode.Displayed);
                Util.Log("On Authentication Page.");
            }
            catch (Exception ex) {Util.Log("\n"+ex+"\n");}
        }
        
        public string TwoFactorKeyGen()
        {
            var otpKeyStr = "VVQU3OIPLDTKBMBFTHRPMZY5AYCPO7HJ"; // <- this 2FA secret key.
            var otpKeyBytes = Base32Encoding.ToBytes(otpKeyStr);
            var totp = new Totp(otpKeyBytes);
            var twoFactorCode = totp.ComputeTotp();
            return twoFactorCode;
             /*
                Backup Codes: one time use
                20260600
                40412466
                58877382
                96485394
                24392361
                62801359
                15612850
                33753342
              */
        }

        public void EnterTwoFactorKey()
        {
            string key = TwoFactorKeyGen();
            VerificationCode.SendKeys(key);
        }

        public Nav ClickSubmit()
        {
            Thread.Sleep(1000);
            Submit.Click();
            Util.Log("Clicked Submit.");
            return new Nav(driver);
        }
        
    }
}