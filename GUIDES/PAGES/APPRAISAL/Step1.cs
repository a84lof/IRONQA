namespace IRONQA.GUIDES.PAGES.APPRAISAL
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System.Threading;

    public class Step1
    {
        private IWebDriver driver;
        public Step1(IWebDriver _driver) => driver = _driver;
        private IWebElement InstructionLabel => driver.FindElement(By.Id("panel1__instruction-label"));
        private IWebElement Instructions => driver.FindElement(By.Id("panel1__instruction"));
        private IWebElement StateProv => driver.FindElement(By.ClassName("medium-6"));
        private IWebElement StateProvInput => driver.FindElement(By.CssSelector("#react-select-2-input"));
        private IWebElement Issue => driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div/div[2]/main/div[1]/div[2]/section/div/div[1]/div[2]"));
        private IWebElement IssueInput => driver.FindElement(By.Id("react-select-3-input"));
        private IWebElement CurrencyLabel => driver.FindElement(By.Id("panel-currency-label"));
        private IWebElement ExchangeCurrency => driver.FindElement(By.Id("currency--latest-target"));
        private IWebElement ExchangeRate => driver.FindElement(By.Id("currency--latest-exchange-rate"));
        private IWebElement Type => driver.FindElement(By.XPath("//*[contains(@id,\'typeahead__home--type-drop\') and not(contains(@class,\'appraisal-typeahead--is-disabled\'))]"));
        private IWebElement TypeInput => driver.FindElement(By.CssSelector(".appraisal-typeahead__input > #react-select-6-input"));
        private IWebElement Make => driver.FindElement(By.XPath("//*[contains(@id,\'typeahead__home--make-drop\') and not(contains(@class,\'appraisal-typeahead--is-disabled\'))]"));
        private IWebElement MakeInput => driver.FindElement(By.CssSelector(".appraisal-typeahead__input > #react-select-7-input"));
        private IWebElement Model => driver.FindElement(By.XPath("//*[contains(@id,\'typeahead__home--model-drop\') and not(contains(@class,\'appraisal-typeahead--is-disabled\'))]"));
        private IWebElement ModelInput => driver.FindElement(By.CssSelector("#react-select-8-input"));
        private IWebElement SerialNumberInput => driver.FindElement(By.Id("home--serial-input"));
        private IWebElement LookupValue => driver.FindElement(By.CssSelector("#root > div > div.off-canvas-wrapper > div > div.off-canvas-content > main > div.main-inner-wrap > nav > div > div > button"));
        private IWebElement WaitGear => driver.FindElement(By.CssSelector("#reveal > p > i"));

        public void ConfirmOnStep1()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'typeahead__region--select-issue') and not (contains(@class,'--is-disabled'))]");
            Util.Log("On Step 1.");
        }

        public void SelectStateProv(string region)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'typeahead__region--select-region') and not (contains(@class,'--is-disabled'))]");
            StateProv.Click();
            StateProvInput.SendKeys(region);
            StateProvInput.SendKeys(Keys.Tab);
            Util.Log("Selected Region: " + region);
        }

        public void SelectIssue(string issue)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'typeahead__region--select-issue') and not (contains(@class,'--is-disabled'))]");
            Issue.Click();
            IssueInput.SendKeys(issue);
            IssueInput.SendKeys(Keys.Tab);
            Util.Log("Selected Issue: " + issue);
        }

        public void ExpandCurrencyConverter()
        {
            ExchangeCurrency.Click();
            Util.Log("Expanded Currency Converter.");
        }

        public enum Currency {AUD, CAD, CNY, EUR, INR, MXN, RUB, USD}

        public void SelectCurrency(Currency currency)
        {   
            // Expand Exchange Currency Dropdown
            ExchangeCurrency.Click();
            // Dynamically select the currency.
            IWebElement element = driver.FindElement(By.XPath("//form//div[contains(text(),'"+currency+"')]"));
            element.Click();
            Util.Log("Selected Currency: "+currency.ToString());
        }

        public void SelectType(string type)
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("XPath","//*[contains(@id,'typeahead__home--type-drop') and not (contains(@class,'--is-disabled'))]");
            Type.Click();
            TypeInput.SendKeys(type);
            Thread.Sleep(250);
            TypeInput.SendKeys(Keys.Tab);
            Util.Log("Selected Type: " + type);
        }

        public void SelectMake(string make)
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("XPath","//*[contains(@id,'typeahead__home--make-drop') and not (contains(@class,'--is-disabled'))]");
            Make.Click();
            MakeInput.SendKeys(make);
            Thread.Sleep(250);
            MakeInput.SendKeys(Keys.Tab);
            Util.Log("Selected Make: " + make);
        }

        public void SelectModel(string model)
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("XPath","//*[contains(@id,'typeahead__home--model-drop') and not (contains(@class,'--is-disabled'))]");
            Model.Click();
            ModelInput.SendKeys(model);
            Thread.Sleep(250);
            ModelInput.SendKeys(Keys.Enter);
            Util.Log("Selected Model: " + model);
        }

        public void ClickYear(string year)
        {
            Util util = new Util(driver);
            util.WaitForClickableElement("XPath","//*[contains(@id,'production-year--"+year+"') and (contains(@type,'radio'))]");
            IWebElement Year = driver.FindElement(By.XPath("//*[contains(@id,'production-year--"+year+"') and (contains(@type,'radio'))]"));
            Year.Click();
            Util.Log("Selected Year "+ year);
        }

        public void EnterSerialNumber(string serialNo)
        {
            SerialNumberInput.SendKeys(serialNo);
            Util.Log("Entered Serial Number");
        }

        public Step2 ClickLookupValue()
        {
            LookupValue.Click();
            Thread.Sleep(5000); // this can take forever in Beta
            Util.Log("Clicked Lookup Value Button");
            return new Step2(driver);
        }
    }
}
