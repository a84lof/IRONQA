namespace IRONQA.GUIDES.PAGES.DASHBOARD
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    public class News
    {
        private IWebDriver driver;
        public News(IWebDriver _driver) => driver = _driver;
        private IWebElement NewsTab => driver.FindElement(By.CssSelector("#my-iron-tabs > li.tabs-title.is-active"));
        private IWebElement Article => driver.FindElement(By.XPath("//*[@class='accordion-title']"));

        public void ConfirmNews()
        {
            try
            {
                Assert.True(NewsTab.GetAttribute("class").Contains("is-active"));
                Util.Log("News Tab Active.");
            }
            catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void ClickArticle(string row)
        {
            ////*[@id="s0d273-accordion-label"]
            string path = "#news > ul > li:nth-child(" + row + ")";
            IWebElement Article = driver.FindElement(By.CssSelector(path));
            Article.Click();
        }
    }
}