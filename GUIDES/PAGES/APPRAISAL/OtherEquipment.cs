namespace IRONQA.GUIDES.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class OtherEquipment
    {
        private IWebDriver driver;
        public OtherEquipment(IWebDriver _driver) => driver = _driver;
        private IWebElement TMMSuggest => driver.FindElement(By.XPath("//section//div/input"));
        private IWebElement ShowFilters => driver.FindElement(By.XPath("//button[contains(@class,'show-hide-filters')]"));

        public void ConfirmOnOtherEquipment()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//section//div/input");
            Util.Log("On Other Equipment Page.");
        }

        public void EnterTMM(string search)
        {
            TMMSuggest.SendKeys(search);
            Util.Log("Entered Suggest Text; "+search);
        }

        public void SelectTMMSuggest(string text)
        {   Thread.Sleep(3000);
            IWebElement element = driver.FindElement(By.XPath("//div[contains(@class,'fleet-manager-typeahead__option')]//div[contains(text(),'"+text+"')]/.."));
            element.Click();
        }

        public void ConfirmReportsDisplayed()
        {
            Thread.Sleep(3000);
            ShowFilters.Click();
        }

        public void SelectReports()
        {
            
        }






    // ##################################
    // OLD OTHER EQUIPMENT - DEPRECATED #
    // ##################################
    //     private IWebElement Region => driver.FindElement(By.XPath("//*[contains(@placeholder,'Region')]"));
    //     private IWebElement Type => driver.FindElement(By.XPath("//*[@id='content']/div[4]/div/div[3]/div[2]/div[2]/div/span/span/input"));
    //     private IWebElement Make => driver.FindElement(By.XPath("//*[@id='content']/div[4]/div/div[3]/div[2]/div[3]/div/span/span/input"));
    //     private IWebElement Model => driver.FindElement(By.XPath("//*[@id='content']/div[4]/div/div[3]/div[2]/div[4]/div/span/span/input"));
    //     private IWebElement GetReports => driver.FindElement(By.CssSelector("#btnGetReports"));
    //     private IWebElement ListingSold => driver.FindElement(By.CssSelector("#SoldReportList > div.k-grid-content > table > tbody > tr > td:nth-child(1)"));

    //     public void ConfirmOnOtherEquipmentPage()
    //     {
    //         Util util = new Util(driver);
    //         util.ExecuteScript(Scripts.WaitForPage);
    //         util.WaitForElement("CssSelector","#btnGetReports",10);
    //         Util.Log("On Additional Models Page");
    //     }

    //     public void SelectRegion(string region)
    //     {
    //         Util util = new Util(driver);
    //         util.WaitForClickableElement("XPath", "//*[contains(@placeholder,'Region')]", 15);
    //         Region.SendKeys(region);
    //         Thread.Sleep(1200);
    //         Region.SendKeys(Keys.Enter);
    //         Region.SendKeys(Keys.Tab);
    //         Util.Log("Selected Region: " + region);
    //     }

    //     public void SelectType(string type)
    //     {
    //         Util util = new Util(driver);
    //         util.WaitForClickableElement("XPath", "//*[contains(@placeholder,'Type')]", 15);
    //         Thread.Sleep(1200);
    //         Type.SendKeys(type);
    //         Thread.Sleep(1200);
    //         Type.SendKeys(Keys.Tab);
    //         Util.Log("Selected Type: " + type);
    //     }

    //     public void SelectMake(string make)
    //     {
    //         Util util = new Util(driver);
    //         util.WaitForClickableElement("XPath", "//*[contains(@placeholder,'Make')]", 15);
    //         Thread.Sleep(1200);
    //         Make.SendKeys(make);
    //         Thread.Sleep(1200);
    //         Type.SendKeys(Keys.Tab);
    //         Util.Log("Selected Make: " + make);
    //     }

    //     public void SelectModel(string model)
    //     {
    //         Util util = new Util(driver);
    //         util.WaitForClickableElement("XPath", "//*[contains(@placeholder,'Model')]", 15);
    //         Thread.Sleep(1200);
    //         Model.SendKeys(model);
    //         Thread.Sleep(1200);
    //         Model.SendKeys(Keys.Tab);
    //         Util.Log("Selected Model: " + model);
    //     }

    //     public void ClickGetReports()
    //     {
    //         GetReports.Click();
    //         Util.Log("Clicked Get Reports");
    //     }

    //     public void ConfirmSoldReports()
    //     {
    //         Util util = new Util(driver);
    //         util.WaitForElement("CssSelector", "#SoldReportList > div.k-grid-content > table > tbody > tr > td:nth-child(1)", 20);
    //         Assert.IsTrue(ListingSold.Text != null);
    //         Util.Log("Sold Report Confirmed");
    //     }
    }
}

