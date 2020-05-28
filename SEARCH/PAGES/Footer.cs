namespace IRONQA.SEARCH.PAGES
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Footer
    {
        private IWebDriver driver;
        public Footer(IWebDriver _driver) => driver = _driver;
        private IWebElement Categories => driver.FindElement(By.Id("footer-categories-list"));
        private IWebElement Categories_1 => driver.FindElement(By.XPath("//*[@id='footer - categories - list']/ul/li[1]/a"));
        private IWebElement Categories_2 => driver.FindElement(By.XPath("//*[@id='footer - categories - list']/ul/li[2]/a"));
        private IWebElement Categories_3 => driver.FindElement(By.XPath("//*[@id='footer - categories - list']/ul/li[3]/a"));
        private IWebElement Categories_4 => driver.FindElement(By.XPath("//*[@id='footer - categories - list']/ul/li[4]/a"));
        private IWebElement Categories_5 => driver.FindElement(By.XPath("//*[@id='footer - categories - list']/ul/li[5]/a"));
        private IWebElement Manufacturers => driver.FindElement(By.Id("footer-manufacturers-list"));
        private IWebElement Manufacturer_1 => driver.FindElement(By.XPath("//*[@id='footer - manufacturers - list']/ul/li[1]/a"));
        private IWebElement Manufacturer_2 => driver.FindElement(By.XPath("//*[@id='footer - manufacturers - list']/ul/li[1]/a"));
        private IWebElement Manufacturer_3 => driver.FindElement(By.XPath("//*[@id='footer - manufacturers - list']/ul/li[1]/a"));
        private IWebElement Manufacturer_4 => driver.FindElement(By.XPath("//*[@id='footer - manufacturers - list']/ul/li[1]/a"));
        private IWebElement Manufacturer_5 => driver.FindElement(By.XPath("//*[@id='footer - manufacturers - list']/ul/li[1]/a"));
        private IWebElement EquipmentTypes => driver.FindElement(By.Id("footer-equipment-types-list"));
        private IWebElement EquipmentType_1 => driver.FindElement(By.XPath("//*[@id='footer - equipment - types - list']/ul/li[1]/a"));
        private IWebElement EquipmentType_2 => driver.FindElement(By.XPath("//*[@id='footer - equipment - types - list']/ul/li[1]/a"));
        private IWebElement EquipmentType_3 => driver.FindElement(By.XPath("//*[@id='footer - equipment - types - list']/ul/li[1]/a"));
        private IWebElement EquipmentType_4 => driver.FindElement(By.XPath("//*[@id='footer - equipment - types - list']/ul/li[1]/a"));
        private IWebElement EquipmentType_5 => driver.FindElement(By.XPath("//*[@id='footer - equipment - types - list']/ul/li[1]/a"));
        private IWebElement CustomeSupport => driver.FindElement(By.Id("footer-customer-support"));
        private IWebElement SiteMap => driver.FindElement(By.Id("footer-site-map"));
        private IWebElement AboutUs => driver.FindElement(By.Id("footer-about-us"));
        private IWebElement Contact => driver.FindElement(By.Id("footer-contact"));
        private IWebElement PrivacyPolicy => driver.FindElement(By.Id("footer-privacy-policy"));
        private IWebElement Terms => driver.FindElement(By.Id("footer-terms-conditions"));
        private IWebElement Logo => driver.FindElement(By.XPath("/html/body/footer/div[2]/div/div[2]/img"));

        public void ClickAboutUs()
        {
            AboutUs.Click();
            Util.Log("Clicked About Us Link");
        }

        public void ClickContact()
        {
            Contact.Click();
            Util.Log("Clicked Contact Link");
        }

        public void ClickTerms()
        {
            Terms.Click();
            Util.Log("Clicked Terms & Conditions Link");
        }

        public void ClickCustomerSupport()
        {
            CustomeSupport.Click();
            Util.Log("Clicked Customer Support Link");
        }

        public void ClickPrivacyPolicy()
        {
            PrivacyPolicy.Click();
            Util.Log("Clicked Privacy Policy");
        }

        public void ClickSiteMap()
        {
            SiteMap.Click();
            Util.Log("Clicked Site Map");
        }

        public void ClickCategoryLink(int rowPosition)
        {
            switch (rowPosition)
            {
                case 1:
                    Categories_1.Click();
                    break;
                case 2:
                    Categories_2.Click();
                    break;
                case 3:
                    Categories_3.Click();
                    break;
                case 4:
                    Categories_4.Click();
                    break;
                case 5:
                    Categories_5.Click();
                    break;
                default:
                    break;
            }
            Util.Log("Clicked Category Link #" + rowPosition);
        }

        public void ClickManufacturerLink(int rowPosition)
        {
            switch (rowPosition)
            {
                case 1:
                    Manufacturer_1.Click();
                    break;
                case 2:
                    Manufacturer_2.Click();
                    break;
                case 3:
                    Manufacturer_3.Click();
                    break;
                case 4:
                    Manufacturer_4.Click();
                    break;
                case 5:
                    Manufacturer_5.Click();
                    break;
                default:
                    break;
            }
            Util.Log("Clicked Manufacturer Link #" + rowPosition);
        }

        public void ClickEquipmentTypeLink(int rowPosition)
        {
            switch (rowPosition)
            {
                case 1:
                    EquipmentType_1.Click();
                    break;
                case 2:
                    EquipmentType_2.Click();
                    break;
                case 3:
                    EquipmentType_3.Click();
                    break;
                case 4:
                    EquipmentType_4.Click();
                    break;
                case 5:
                    EquipmentType_5.Click();
                    break;
                default:
                    break;
            }
            Util.Log("Clicked Equipment Type Link #" + rowPosition);
        }
    }
}
