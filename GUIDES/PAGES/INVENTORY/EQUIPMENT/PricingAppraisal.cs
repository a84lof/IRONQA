namespace IRONQA.GUIDES.PAGES.INVENTORY.EQUIPMENT
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    public class PricingAppraisal
    {
        private IWebDriver driver;
        public PricingAppraisal(IWebDriver _driver) => driver = _driver;
        private IWebElement WholesaleInput => driver.FindElement(By.CssSelector("#pricing-appraisal > div > div > div > div > div:nth-child(3) > div > div:nth-child(2) > input[type=number]"));
        private IWebElement WholeSaleValue => driver.FindElement(By.CssSelector("#pricing-appraisal > div > div > div > div > div:nth-child(3) > div > div:nth-child(2) > span"));
        private IWebElement AdvertisedInput => driver.FindElement(By.CssSelector("#pricing-appraisal > div > div > div > div > div:nth-child(3) > div > div:nth-child(3) > input[type=number]"));
        private IWebElement AdvertisedValue => driver.FindElement(By.CssSelector("#pricing-appraisal > div > div > div > div > div:nth-child(3) > div > div:nth-child(3) > span"));
        private IWebElement PriceNotes => driver.FindElement(By.CssSelector("#pricing-appraisal > div > div > div > div > div.flex-row.flex-row--price-notes > div.flex-cell.flex-cell--price-notes > textarea"));

        public void ConfirmOnAppraisalPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id", "optionsInstructions-label");
            Util.Log("On Appraisal Page.");
        }

        public void EnterWholesaleValue(string value)
        {
            WholesaleInput.SendKeys(value);
            Util.Log("Entered Wholesale Value.");
        }

        public void EnterAdvertisedValue(string value)
        {
            AdvertisedInput.SendKeys(value);
            Util.Log("Entered Advertised Value.");
        }

        public void EnterePriceNotes(string note)
        {
            PriceNotes.SendKeys(note);
            Util.Log("Entered Note.");
        }

        public void ConfirmDoneEditing()
        {
            try
            {// When done editing, spans replace inputs and values elements are displayed
                Assert.IsTrue(WholeSaleValue.Displayed);
                Assert.IsTrue(AdvertisedValue.Displayed);
            }
            catch (Exception ex) { Util.Log("Not Done Editing.\n" + ex + "\n"); }
        }
    }
}