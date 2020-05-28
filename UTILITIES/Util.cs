namespace IRONQA.UTILITIES
{
    using IRONQA.TESTRUN;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using SeleniumExtras.WaitHelpers;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Threading;

    public class Util // Common Page Helpers
    {
        private static IWebDriver driver;
        public Util(IWebDriver _driver) => driver = _driver;

        public IWebDriver ClickToNewTab(IWebElement element)
        {
            GetTabs(); //Tabs[0] will always be 1st Tab
            element.Click();
            Thread.Sleep(2000); //Let the new tab open
            Log("Element clicked.");
            GetTabs(); //Tabs[1&2] will not always be in logical order.
            SwitchToNewTab();
            Log("On new tab.");
            return driver;
        }

        public void CloseDriver()
        {// Universal End Test
            Thread.Sleep(2000); // helps iOS & Android drivers
            driver.Close(); // Close Browser
            driver.Quit(); // Kill Session
            Log("Driver Closed.");
        }

        public IWebDriver CloseNewTab()
        {
            Thread.Sleep(2000);
            var handle = driver.WindowHandles.Last();
            driver.SwitchTo().Window(handle);
            driver.Close();
            Thread.Sleep(2000);
            handle = driver.WindowHandles.Last();
            driver.SwitchTo().Window(handle);
            return driver;
        }

        public IWebDriver DismissAlert()
        {
            try
            {
                driver.SwitchTo().Alert().Accept();
                Log("Alert dismissed");
                Thread.Sleep(1000);
                return driver;
            }
            catch (NoAlertPresentException)
            {
                Log("No alert present.");
                return driver;
            }
        }

        public static string Fail()
        {// Returns Class.MethodName at point of failure.
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            string msg = "\n >>> Assert Failed In Method: " + sf.GetMethod().Name;
            return msg;
        }

        public static string GetRandomNumber(int length)
        {// Generate Custom Numbers
            const string chars = "0123456789";
            string random = new string(Enumerable.Repeat(chars, length).Select(s => s[Random.Next(s.Length)]).ToArray());
            StoredString = random;
            return random;
        }

        public static string GetRandomString(int length)
        {// Generate Custom Strings
            const string chars = "ABCDEFGHIJKLMOPQRSTUVWXYZ1234567890-_";
            string random = new string(Enumerable.Repeat(chars, length).Select(s => s[Random.Next(s.Length)]).ToArray());
            StoredString = random;
            return random;
        }

         public static string StoredString;

        private static IList<string> List;
        private static List<string> Tabs = new List<string>();

        public static void GetTabs()
        {
            List = driver.WindowHandles;
            foreach (string tab in List)
            {
                Tabs.Add(tab);
            }
        }

        private static TimeSpan MyDefaultTimeout { get; set; }

        private static Random Random = new Random();

        public IWebDriver ExecuteScript(string script)
        {
            var wait = new WebDriverWait(driver, MyDefaultTimeout)      // Wait for js command to complete
            .Until(e => ((IJavaScriptExecutor)e)
            .ExecuteScript(script, null))
            .Equals("complete");
            Log("Executed Script");
            return driver;
        }

        public IWebDriver ScrollTo(IWebElement element)
        {
            IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
            Log("Scrolled To Element.");
            return driver;
        }

        public IWebDriver ScrollToBottom()
        {
            IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Log("Scrolled To Bottom.");
            return driver;
        }

        public IWebDriver SwitchToNewTab()
        {
            string browser = TestDetails.GetParent; // Like "IRONQA.IronGuides.Tests.Chrome"
            if (browser.Contains("IE")) browser = "IE";
            else if (browser.Contains("Safari")) browser = "Safari";
            else if (browser.Contains("Chrome")) browser = "Chrome";
            else if (browser.Contains("Firefox")) browser = "Firefox";
            else if (browser.Contains("Edge")) browser = "Edge";

            switch (browser)
            {
                case "IE":
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                    driver.Manage().Window.Maximize();
                    Log("Switched to new IE window.");
                    break;
                case "Safari":
                    Log("Safari detected.");
                    // after ClickToNewTab() thisTab expects WindowHandles.Last() to be > Tabs[0] 
                    string last = driver.WindowHandles.Last();
                    int count = Tabs.Count();

                    // if we have 2 tabs and we're on the last one, focus the driver on the last one.
                    if (count.Equals(3))
                    {
                        // if [0]=[2], new tab must be [1]
                        if (Tabs[0].Equals(Tabs[2]))
                        {
                            driver.SwitchTo().Window(Tabs[1]);
                            Log("Switched to second tab.");
                            break;
                        }
                        // if [0]=[1], new tab must be [2]
                        else if (Tabs[0].Equals(Tabs[1]))
                        {
                            driver.SwitchTo().Window(Tabs[2]);
                            Log("Switched to second tab.");
                            break;
                        }
                        break;
                    }
                    // if we have 3 tabs and this is the last one, focus the driver on the last one.
                    else if (count.Equals(5)) //probably gonna fail
                    {
                        // elimination. 
                        // if [0]=[2]or[3] & [1]=[2]or[3] then [4] must be new tab
                        if ((Tabs[0].Equals(Tabs[2]) || Tabs[0].Equals(Tabs[3])) && (Tabs[1].Equals(Tabs[2]) || Tabs[1].Equals(Tabs[3])))
                        {
                            // new tab must be Tabs[4]
                            driver.SwitchTo().Window(Tabs[4]);
                            Log("Switched to third tab.");
                            break;
                        }
                        // if [0]=[2]or[4] & [1]=[2]or[4] then [3] must be new tab
                        else if ((Tabs[0].Equals(Tabs[2]) || Tabs[0].Equals(Tabs[4])) && (Tabs[1].Equals(Tabs[2]) || Tabs[1].Equals(Tabs[4])))
                        {
                            // new tab must be Tabs[3]
                            driver.SwitchTo().Window(Tabs[3]);
                            Log("Switched to third tab.");
                            break;
                        }
                        // if [0]=[3]or[4] & [1]=[3]or[4] then [2] must be new tab
                        else if ((Tabs[0].Equals(Tabs[3]) || Tabs[0].Equals(Tabs[4])) && (Tabs[1].Equals(Tabs[3]) || Tabs[1].Equals(Tabs[4])))
                        {
                            // new tab must be Tabs[2]
                            driver.SwitchTo().Window(Tabs[2]);
                            Log("Switched to third tab.");
                            break;
                        }
                        else
                            break;
                    }
                    // if we only have one tab, something went wrong or the last tab crashed.
                    else if (count.Equals(2))
                    {
                        driver.SwitchTo().Window(driver.CurrentWindowHandle);
                        Log("No new tabs detected.");
                        break;
                    }
                    else
                        break;
                default:
                    Thread.Sleep(1500);
                    string l = driver.WindowHandles.Last();
                    driver.SwitchTo().Window(l);
                    Log("Switched to last tab.");
                    break;
            }
            return driver;
        }

        public IWebDriver SwitchToFrame()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe")));
            Log("Switched To Frame.");
            return driver;
        }

        public IWebDriver WaitForClickableElement(string locatorType, string locator)
        {
            var timeout = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            switch (locatorType)
            {
                case "XPath":
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
                    break;
                case "CssSelector":
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locator)));
                    break;
                case "Id":
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locator)));
                    break;
                case "Name":
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.Name(locator)));
                    break;
            }
            return driver;
        }

        public IWebDriver WaitForElement(string locatorType, string locator)
        {
            var timeout = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            switch (locatorType)
            {
                case "XPath":
                    wait.Until(ExpectedConditions.ElementExists(By.XPath(locator)));
                    break;
                case "CssSelector":
                    wait.Until(ExpectedConditions.ElementExists(By.CssSelector(locator)));
                    break;
                case "Id":
                    wait.Until(ExpectedConditions.ElementExists(By.Id(locator)));
                    break;
                case "Name":
                    wait.Until(ExpectedConditions.ElementExists(By.Name(locator)));
                    break;
            }
            return driver;
        }

        public IWebDriver WaitForElementNotDisplayed(string locatorType, string locator)
        {
            var timeout = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            switch (locatorType)
            {
                case "XPath":
                    wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(locator)));
                    break;
                case "CssSelector":
                    wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector(locator)));
                    break;
                case "Id":
                    wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id(locator)));
                    break;
                case "Name":
                    wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Name(locator)));
                    break;
            }
            return driver;
        }

        public IWebDriver WaitForURL(string url)
        {
            var timeout = driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains(url));
            Thread.Sleep(2000);
            return driver;
        }

        public static string HoldValue(string value)
        {
            string v = value;
            return v;
        }

        public static void Log(string text, string text2 = "")
        {// Append text to TestLog.txt & Console
            // string path = "/Users/aloflin/Projects/IRONQA/TESTRUN/TestLog.txt";
            // using (StreamWriter sw = new StreamWriter(path, true))
            {
                if (text2 != "")
                {
                    // sw.WriteLine(text+"\n"+text2);
                    Console.WriteLine(text+"\n"+text2);
                }
                else
                {
                    // sw.WriteLine(text);
                    Console.WriteLine(text);
                }
            }
        }
    }
}
