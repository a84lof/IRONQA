namespace IRONQA.FSBO.PAGES.FORSALEBYOWNER
{
    using System;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Step1
    {
        private IWebDriver driver;
        public Step1(IWebDriver _driver) => driver = _driver;
        private IWebElement Type => driver.FindElement(By.Id("Content_Content_Type"));
        private IWebElement Make => driver.FindElement(By.Id("Content_Content_Make"));
        private IWebElement Model => driver.FindElement(By.Id("Content_Content_Model"));
        private IWebElement AskingPrice => driver.FindElement(By.Id("Content_Content_Price"));
        private IWebElement Currency => driver.FindElement(By.Id("Content_Content_Currency"));
        private IWebElement Year => driver.FindElement(By.Id("Content_Content_Year"));
        private IWebElement SerialNumber => driver.FindElement(By.Id("Content_Content_SerialNo"));
        private IWebElement Meter1 => driver.FindElement(By.Id("Content_Content_meter1"));
        private IWebElement Meter1Type => driver.FindElement(By.Id("Content_Content_metertype1"));
        private IWebElement Meter2 => driver.FindElement(By.Id("Content_Content_meter2"));
        private IWebElement Meter2Type => driver.FindElement(By.Id("Content_Content_metertype2"));
        private IWebElement Size => driver.FindElement(By.Id("Content_Content_size"));
        private IWebElement SizeType => driver.FindElement(By.Id("Content_Content_sizetype"));
        private IWebElement Condition => driver.FindElement(By.Id("Content_Content_Condition"));
        private IWebElement Conditionnotes => driver.FindElement(By.Id("Content_Content_ConditionNotes"));
        private IWebElement Options => driver.FindElement(By.Id("Content_Content_Options"));
        private IWebElement Next => driver.FindElement(By.Id("Content_Content_ImageButton1"));
        private IWebElement Next2 => driver.FindElement(By.CssSelector("#Content_Content_Message > a:nth-child(34) > div > div"));

        public void ConfirmOnStep1()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForElement("Id","Content_Content_LoggedMessage1_ThisControl");
            Util.Log("On FSBO Page.");
        }

        public void SelectType(string type)
        {
            Type.SendKeys(type);
            Type.SendKeys(Keys.Enter);
            Util.Log("Selected Type.");
        }

        public void SelectMake(string make)
        {
            Make.SendKeys(make);
            Make.SendKeys(Keys.Enter);
            Util.Log("Selected Make.");
        }

        public void EnterModel(string model)
        {
            Model.SendKeys(model);
            Model.SendKeys(Keys.Enter);
            Util.Log("Selected Model.");
        }

        public void EnterAskingPrice(string price)
        {
            AskingPrice.SendKeys(price);
            Util.Log("Entered Asking Price.");
        }

        public void SelectCurrency(string currency)
        {
            Currency.SendKeys(currency);
            Currency.SendKeys(Keys.Tab);
            Util.Log("Selected Currency.");
        }

        public void EnterYear(string year)
        {
            Year.SendKeys(year);
            Util.Log("Entered Year.");
        }

        public void EnterSerialNumber(string serial)
        {
            SerialNumber.SendKeys(serial);
            Util.Log("Entered Serial Number.");
        }

        public void EnterMeter1(string meter)
        {
            Meter1.SendKeys(meter);
            Util.Log("Entered Meter1.");
        }

        public void SelectMeter1Type(string type)
        {
            Meter1Type.SendKeys(type);
            Meter1Type.SendKeys(Keys.Tab);
            Util.Log("Selected Meter1 Type of " + type);
        }

        public void EnterMeter2(string meter)
        {
            Meter2.SendKeys(meter);
            Util.Log("Entered Meter2.");
        }

        public void SelectMeter2Type(string type)
        {
            Meter2Type.SendKeys(type);
            Meter2Type.SendKeys(Keys.Tab);
            Util.Log("Selected Meter2 Type of " + type);
        }

        public void EnterSize(string meter)
        {
            Meter1.SendKeys(meter);
            Util.Log("Entered Size.");
        }

        public void SelectSizeType(string type)
        {
            SizeType.SendKeys(type);
            SizeType.SendKeys(Keys.Tab);
            Util.Log("Selected Size Type.");
        }

        public void SelectCondition(string condition)
        {
            Condition.SendKeys(condition);
            Util.Log("Selected Condition.");
        }

        public void EnterConditionNotes(string notes)
        {
            Conditionnotes.SendKeys(notes);
            Util.Log("Entered Condition Notes.");
        }

        public void EnterOptions(string options)
        {
            Options.SendKeys(options);
            Util.Log("Entered Options.");
        }

        public void ClickNext()
        {
            Next.Click();
            Util.Log("Clicked Next.");
        }

        public Step2 ConfirmEquipment()
        {
            // Loads a new page that shows what was entered.
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage); 
            Next2.Click();
            Util.Log("Confirmed Equipment Entered.");
            return new Step2(driver);
        }
    }
}