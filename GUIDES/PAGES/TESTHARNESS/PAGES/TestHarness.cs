namespace IRONQA.GUIDES.PAGES.TESTHARNESS.PAGES
{
    
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.IO;
    using System.Threading;

    public class TestHarness
    {
        public IWebDriver driver;
        public TestHarness(IWebDriver _driver) => driver = _driver;

        private IWebElement RequestInput => driver.FindElement(By.Id("postXML"));
        private IWebElement PostXML => driver.FindElement(By.Id("Button1"));
        private IWebElement Response => driver.FindElement(By.Id("errorMsg"));

        public void ConfirmTestHarnessPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","postXML");
            Util.Log("On Test Harness Page.");
        }

        public void EnterRequestXML(string xml)
        {// samples in UTIL > Scripts
            RequestInput.SendKeys(xml);
            Util.Log("Entered Request XML.");
        }

        public void ClickPostXML()
        {
            PostXML.Click();
            Util.Log("Clicked PostXML.");
        }

        public void ConfirmResponse()
        {
            // Allow time for response.
            Thread.Sleep(3000);
            string response = Response.Text;
            
            // Log response to EvaluatorResponse.xml.
            string path = "/Users/aloflin/Projects/IRONQA/GUIDES/PAGES/TESTHARNESS/EvaluatorResponse.txt";

            // Append txt to file.
            using (StreamWriter sw = new StreamWriter(path,true))
            {
                sw.WriteLine(DateTime.Now.ToString());
                sw.WriteLine(response);
                Util.Log("Logged Response: "+ response);
            }

            // Confirm response contains adjust node.
            Assert.IsTrue(response.Contains("<adjust>"));
        }
    }
}