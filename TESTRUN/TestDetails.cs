namespace IRONQA.TESTRUN
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Edge;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Safari;
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class TestDetails
    {
        private IWebDriver driver;
        public TestDetails(IWebDriver _driver) => driver = _driver;

        // ASSIGN TARGET ENVIRONMENT & LOCATION FOR ALL TESTS.
        public enum Environment { Production, Beta, Alpha, Demo }
        public static Environment TargetEnvironment = Environment.Beta; //def: Environment.Beta
        public enum Location { Local, BrowserStackLocal }
        public static Location TargetLocation = Location.Local; //def: Location.BrowserStackLocal

        // BrowserStack Connection Info
        public static string USERNAME = "";
        public static string AUTOMATE_KEY = "";
        public static string BSURL = "https://" + USERNAME + ":" + AUTOMATE_KEY + "@hub-cloud.browserstack.com/wd/hub";

        // Selenium/Appium Version
        public static string AppiumVersion = "1.12.1";
        public static string ChromeSeleniumVersion = "3.13.0";
        public static string FirefoxSeleniumVersion = "3.13.0";
        public static string SafariSeleniumVersion = "3.13.0";
        public static string EdgeSeleniumVersion = "3.14.0";

        // OS Info
        public static string AndroidVersion = "9.0";
        public static string AndroidDevice = "Samsung Galaxy S9 Plus";
        public static string iOSVersion = "13.0";
        public static string iOSDevice = "iPad Pro 12.9 2018";
        public static string iPhoneVersion = "11";
        public static string iPhoneDevice= "iPhone 8";

        // Browser Info
        public static string ChromeVersion = "81.0 beta";
        public static string EdgeVersion = "81.0 beta";
        public static string FirefoxVersion = "75.0 beta";
        public static string MojaveSafariVersion = "12.1";
        public static string HighSierraSafariVersion = "11.1";

        // For IG & GDM
        public static string AGIssue = "Fall 2019";
        public static string CEIssue = "Fall 2019";
        public static string CurrentIssue = "Fall 2019";

        // Guides Appraisal Workflow
        // Step 1
        // AG
        public static string USAGRegion = "Montana";
        public static string CanAGRegion = "Manitoba";
        public static string AGType = "Combine";
        public static string AGMake = "John Deere";
        public static string AGModel = "S670";
        public static string AGYear = "2017";
        // OPE
        public static string USOPERegion = "Montana";
        public static string CanOPERegion = "Manitoba";
        public static string OPEType = "Garden Tractor";
        public static string OPEMake = "Cub Cadet";
        public static string OPEModel = "1440";
        public static string OPEYear = "1997";
        // ISBG
        public static string ISBGRegion = "Colorado";
        public static string ISBGType = "Cotton Picker";
        public static string ISBGMake = "Case IH";
        public static string ISBGModel = "Cotton Express 620";
        public static string ISBGYear = "2008";
        
        // Step 2
        public static string CustomOptionName = "QA Option.";
        public static string CustomOptionValue = "1234";
        public static string CashPriceAdjustment = "250";
        public static string DealershipMargin = "";
        public static string Reconditioning = "800";
        public static string DeliveryAllowance = "125";
        public static string OtherReserve = "";

        // Guides - Other Equipment Models
        public static string USRegion = "Southwest";
        public static string USType = "Backhoe";
        public static string USMake = "Case";
        public static string USModel = "580M";
        public static string CANRegion = "Western Canada - CAD";
        public static string CANType = "Air Seeder";
        public static string CANMake = "John Deere";
        public static string CANModel = "1830";

        // Other Test Details
        public static string SerialNumber = Util.GetRandomNumber(5);
        public static string GetTestName => TestContext.CurrentContext.Test.Name;
        public static string GetParent => TestContext.CurrentContext.Test.ClassName;
        public static string Pass = "\n";

        // Test URL Placeholders
        public static string SSOURL;
        public static string SearchURL;
        public static string StoreURL;
        public static string AppraiserURL;
        public static string AdminURL;
        public static string LoggedOutAppraiserURL;
        public static string LoggedOutTMMYUrl;
        public static string FSBOURL;
        public static string GuidesURL;
        public static string NSURL;
        public static string GDMURL;
        public static string ModelManagerURL;
        public static string DealerDashboardURL;

        // Test Browsers
        public enum Browsers { Android, Chrome, Edge, Firefox, iPad, iPhone, Safari }

        // Browser Config
        public void GetTestEnvironment() => GetURL(TargetEnvironment);

        public IWebDriver GetTestBrowser(Browsers browser) => SetTestBrowser(browser, TargetLocation, TargetEnvironment);

        private IWebDriver SetTestBrowser(Browsers webBrowser, Location location, Environment environment)
        {
            switch (location.ToString())
            {
                case "Local":   // For testing on local machine browsers.
                    switch (webBrowser.ToString())
                    {
                        case "Chrome":
                            if (!GetParent.Contains("NETSUITE"))
                            {
                                ChromeOptions options_ = new ChromeOptions();
                                options_.AddArguments("--incognito");
                                driver = new ChromeDriver(options_);
                            }
                            else
                            {
                                driver = new ChromeDriver();
                            }
                            driver.Manage().Window.Maximize();
                            return driver;
                        case "Edge":
                            // EdgeOptions eOptions = new EdgeOptions();
                            // eOptions.BinaryLocation = "Applications/Microsoft Edge.app";

                            // driver = new ChromeDriver(eOptions);
                            // return driver;
                            // var service = EdgeDriverService.CreateDefaultService(@"⁨usr/local/bin", @"msedgedriver");
                            // service.UseVerboseLogging = true;
                            // service.UseSpecCompliantProtocol = true;

                            // service.Start();

                            // var caps_ = new DesiredCapabilities(new Dictionary<string, object>()
                            // {{ "ms:edgeOptions", new Dictionary<string, object>() {{  "binary", @"/Applications/Microsoft\ Edge.app" }}}});

                            // driver = new RemoteWebDriver(service.ServiceUrl, caps_);;
                            // driver.Manage().Window.Maximize();
                            // if (environment.Equals(Environment.Beta))
                            // { // Edge doesn't always open a clean session, regardless of incognito. This navigates to logout followed by login.
                            //     driver.Navigate().GoToUrl("https://betalogin.ironsolutions.com/Logout"); 
                            //     driver.Navigate().GoToUrl("https://betalogin.ironsolutions.com/Login?ReturnUrl=%2f");
                            // }
                            // else
                            // {
                            //     driver.Navigate().GoToUrl("https://login.ironsolutions.com/Logout"); 
                            //     driver.Navigate().GoToUrl("https://login.ironsolutions.com/Login?ReturnUrl=%2f");
                            // }
                            // return driver;
                        case "Firefox":
                            driver = new FirefoxDriver();
                            driver.Manage().Window.Maximize();
                            return driver;
                        case "Safari":
                            driver = new SafariDriver();
                            driver.Manage().Window.FullScreen();
                            return driver;
                    }
                    return driver;

                case "BrowserStackLocal":   // For testing internal-only ip's.
                    var caps = new DesiredCapabilities();
                    Dictionary<string, object> opts = new Dictionary<string, object>();

                    switch (webBrowser.ToString())
                    {
                        case "Chrome":
                            opts = GetBrowserStackOptions(Browsers.Chrome, true);
                            caps.SetCapability("browserNmae","Chrome");
                            caps.SetCapability("browserVersion", ChromeVersion);
                            caps.SetCapability("bstack:options", opts);
                            driver = new RemoteWebDriver(new Uri(BSURL), caps);
                            driver.Manage().Window.Maximize();
                            break;
                        case "Edge":
                            opts = GetBrowserStackOptions(Browsers.Edge, true);
                            caps.SetCapability("browserName","Edge");
                            caps.SetCapability("browserVersion", EdgeVersion);
                            caps.SetCapability("bstack:options", opts);
                            driver = new RemoteWebDriver(new Uri(BSURL), caps);
                            driver.Manage().Window.Maximize();
                            if (environment.Equals(Environment.Beta))
                            {
                                driver.Navigate().GoToUrl("https://betalogin.ironsolutions.com/Logout"); 
                                Thread.Sleep(3000); 
                                Util.Log("Logged Out");
                                driver.Navigate().GoToUrl("https://betalogin.ironsolutions.com/Login?ReturnUrl=%2f");
                            }
                            else
                            {
                                driver.Navigate().GoToUrl("https://login.ironsolutions.com/Logout"); 
                                Thread.Sleep(3000); 
                                Util.Log("Logged Out");
                                driver.Navigate().GoToUrl("https://login.ironsolutions.com/Login?ReturnUrl=%2f");
                            }
                            break;
                        case "Firefox":
                            opts = GetBrowserStackOptions(Browsers.Firefox, true);
                            caps.SetCapability("browserName", "Firefox");
                            caps.SetCapability("browserVersion", FirefoxVersion);
                            caps.SetCapability("bstack:options", opts);
                            driver = new RemoteWebDriver(new Uri(BSURL), caps);
                            driver.Manage().Window.Maximize();
                            break;
                        case "Safari":
                            opts = GetBrowserStackOptions(Browsers.Safari, true);
                            caps.SetCapability("browserName", "Safari");
                            caps.SetCapability("browserVersion", MojaveSafariVersion);
                            caps.SetCapability("bstack:options", opts);
                            driver = new RemoteWebDriver(new Uri(BSURL), caps);
                            driver.Manage().Window.Maximize();
                            break;
                    }
                    return driver;
            }
            return driver;
        }

        private void GetURL(Environment env)
        {
            switch (env.ToString())  
            {
                case "Beta":
                    Users.GetUser("Beta");
                    AdminURL = "http://beta.admin.ironsearch.com/";
                    SSOURL = "https://betalogin.ironsolutions.com";
                    SearchURL = "https://beta.ironsearch.com";
                    StoreURL = "https://betastore.ironsearch.com";
                    AppraiserURL = "https://betasecure.ironsolutions.com/fsbo/Default.aspx";
                    LoggedOutAppraiserURL = "https://betasecure.ironsolutions.com/fsbo/?hostName=IS";
                    LoggedOutTMMYUrl = "https://betasecure.ironsolutions.com/fsbo/Appraise.aspx?r=F";
                    FSBOURL = "https://betasecure.ironsolutions.com/fsbo/Classifieds/Default.aspx";
                    GuidesURL = "https://betasecure.ironguides.com";
                    NSURL = "https://system.netsuite.com/pages/customerlogin.jsp?country=US&vid=-juE989HAo8GV8-1&chrole=17&ck=CrwxTs9HAosGV4bu&cktime=149456&promocode=&promocodeaction=overwrite";
                    GDMURL = "http://beta.dataentry.ironguides.com/Login";
                    ModelManagerURL = "http://beta.legacydataentry.ironguides.com/Login.aspx?ReturnUrl=%2fMainMenu.aspx";
                    DealerDashboardURL = "https://betasecure.ironsolutions.com/admin/Login.aspx?ReturnUrl=%2fadmin";
                    break;
                case "Production":
                    Users.GetUser("Production");
                    AdminURL = "http://admin.ironsearch.com/";
                    SSOURL = "https://login.ironsolutions.com";
                    SearchURL = "https://ironsearch.com";
                    StoreURL = "https://store.ironsearch.com";
                    AppraiserURL = "https://securesearch.ironsolutions.com/fsbo/?hostName=IS";
                    FSBOURL = "https://securesearch.ironsolutions.com/fsbo/Login.aspx?ReturnUrl=%2ffsbo%2fClassifieds%2fDefault.aspx";
                    GuidesURL = "https://secure.ironguides.com/security/login";
                    GDMURL = "http://dataentry.ironguides.com/Login";
                    NSURL = "https://system.netsuite.com/pages/customerlogin.jsp?country=US&vid=-juE989HAo8GV8-1&chrole=17&ck=CrwxTs9HAosGV4bu&cktime=149456&promocode=&promocodeaction=overwrite";
                    break;
            }
        }

        private Dictionary<string, object> GetBrowserStackOptions(Browsers browser, bool isBSLocal)
        {
            Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
            Dictionary<string, object> ieOptions = new Dictionary<string, object>();

            switch (browser.ToString())
            {
                case "Android":
                    browserstackOptions.Add("osVersion", AndroidVersion);
                    browserstackOptions.Add("deviceName", AndroidDevice);
                    browserstackOptions.Add("realMobile", "true");
                    browserstackOptions.Add("buildName", GetTestName);
                    browserstackOptions.Add("projectName", GetParent);
                    browserstackOptions.Add("sessionName", GetTestName);
                    browserstackOptions.Add("local", isBSLocal);
                    browserstackOptions.Add("appiumVersion", AppiumVersion);
                    browserstackOptions.Add("userName", USERNAME);
                    browserstackOptions.Add("accessKey", AUTOMATE_KEY);
                    break;
                case "Chrome":
                    browserstackOptions.Add("os", "Windows");
                    browserstackOptions.Add("osVersion", "10");
                    browserstackOptions.Add("resolution", "1920x1200");
                    browserstackOptions.Add("buildName", GetTestName);
                    browserstackOptions.Add("projectName", GetParent);
                    browserstackOptions.Add("sessionName", GetTestName);
                    browserstackOptions.Add("local", isBSLocal);
                    browserstackOptions.Add("seleniumVersion", ChromeSeleniumVersion);
                    browserstackOptions.Add("userName", USERNAME);
                    browserstackOptions.Add("accessKey", AUTOMATE_KEY);
                    browserstackOptions.Add("w3c", false);
                    break;
                case "Edge":
                    browserstackOptions.Add("os", "Windows");
                    browserstackOptions.Add("osVersion", "10");
                    browserstackOptions.Add("resolution", "1920x1200");
                    browserstackOptions.Add("buildName", GetTestName);
                    browserstackOptions.Add("projectName", GetParent);
                    browserstackOptions.Add("sessionName", GetTestName);
                    browserstackOptions.Add("local", isBSLocal);
                    browserstackOptions.Add("seleniumVersion", EdgeSeleniumVersion);
                    browserstackOptions.Add("userName", USERNAME);
                    browserstackOptions.Add("accessKey", AUTOMATE_KEY);
                    break;
                case "Firefox":
                    browserstackOptions.Add("os", "Windows");
                    browserstackOptions.Add("osVersion", "10");
                    browserstackOptions.Add("resolution", "1920x1200");
                    browserstackOptions.Add("buildName", GetTestName);
                    browserstackOptions.Add("projectName", GetParent);
                    browserstackOptions.Add("sessionName", GetTestName);
                    browserstackOptions.Add("local", isBSLocal);
                    browserstackOptions.Add("seleniumVersion", FirefoxSeleniumVersion);
                    browserstackOptions.Add("userName", USERNAME);
                    browserstackOptions.Add("accessKey", AUTOMATE_KEY);
                    break;
                case "iPad":
                    browserstackOptions.Add("osVersion", iOSVersion);
                    browserstackOptions.Add("deviceName", iOSDevice);
                    browserstackOptions.Add("realMobile", "true");
                    browserstackOptions.Add("buildName", GetTestName);
                    browserstackOptions.Add("projectName", GetParent);
                    browserstackOptions.Add("sessionName", GetTestName);
                    browserstackOptions.Add("deviceOrientation", "landscape");
                    browserstackOptions.Add("local", isBSLocal);
                    browserstackOptions.Add("userName", USERNAME);
                    browserstackOptions.Add("accessKey", AUTOMATE_KEY);
                    break;
                case "iPhone":
                    browserstackOptions.Add("osVersion", iPhoneVersion);
                    browserstackOptions.Add("deviceName", iPhoneDevice);
                    browserstackOptions.Add("realMobile", "true");
                    browserstackOptions.Add("buildName", GetTestName);
                    browserstackOptions.Add("projectName", GetParent);
                    browserstackOptions.Add("sessionName", GetTestName);
                    browserstackOptions.Add("local", isBSLocal);
                    browserstackOptions.Add("appiumVersion", AppiumVersion);
                    browserstackOptions.Add("userName", USERNAME);
                    browserstackOptions.Add("accessKey", AUTOMATE_KEY);
                    break;
                case "Safari":
                    browserstackOptions.Add("os", "OS X");
                    browserstackOptions.Add("osVersion", "Mojave");
                    browserstackOptions.Add("resolution", "1920x1080");
                    browserstackOptions.Add("buildName", GetTestName);
                    browserstackOptions.Add("projectName", GetParent);
                    browserstackOptions.Add("sessionName", GetTestName);
                    browserstackOptions.Add("local", isBSLocal);
                    browserstackOptions.Add("seleniumVersion", SafariSeleniumVersion);
                    browserstackOptions.Add("userName", USERNAME);
                    browserstackOptions.Add("accessKey", AUTOMATE_KEY);
                    break;
            }
            return browserstackOptions;
        }
    }
}