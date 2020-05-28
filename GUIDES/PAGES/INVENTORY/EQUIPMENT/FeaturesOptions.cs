namespace IRONQA.GUIDES.PAGES.INVENTORY.EQUIPMENT
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class FeaturesOptions
    {
        private IWebDriver driver;
        public FeaturesOptions(IWebDriver _driver) => driver = _driver;
        private IWebElement AddRow => driver.FindElement(By.CssSelector("#features-options > div.grid-container > div > div.flex-table.flex-table--custom-options > div.button-wrapper > div.button.primary"));
        private IWebElement StandardSpecsList => driver.FindElement(By.XPath("//*[contains(@id,'fleetStandardSpecs')]/div")); // only displays when guide model
        private IWebElement StandardSpecs => driver.FindElement(By.Id("fleetStandardSpecs-label"));

        public void ConfirmOnFeaturesOptionsPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","optionsInstructions-label");
            Thread.Sleep(1000);
            Util.Log("On Features & Options Page.");
        }

        public void ClickAddRow()
        {
            AddRow.Click();
            Util.Log("Clicked Add Row Button");
        }

        public void ExpandStandardSpecs()
        {
            StandardSpecs.Click();
            Thread.Sleep(2000);
            Util.Log("Expanded Standard Specs.");
        }

        public void ConfirmStandardSpecsList()
        {
            try
            {
                Assert.IsTrue(StandardSpecsList.Displayed);
                Util.Log("Standard Specs Listed.");
            }
            catch (Exception ex) { Util.Log(ex.ToString()); }
            
        }
    }
}