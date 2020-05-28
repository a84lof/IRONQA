namespace IRONQA.UTILITIES
{
    using NUnit.Framework;
    using OpenQA.Selenium;

    public class Scripts
    {
        public IWebDriver driver;
        public Scripts(IWebDriver _driver) => driver = _driver;

        public static string EnableQUIC = "chrome.send('enableExperimentalFeature',['enable-quic' + '@' + 1, 'true'])";

        public static string EnableTCPFastOpen = "chrome.send('enableExperimentalFeature', ['enable-tcp-fast-open', 'true'])";

        public static string EnableSameSiteByDefaultCookies = "chrome.send('enableExperimentalFeature',['enable-same-site-by-default-cookies' + '@' + 1, 'true'])";

        public static string EnableCookiesWithoutSameSiteMustBeSecure = "chrome.send('enableExperimentalFeature',['enable-cookies-without-same-site-must-be-secure' + '@' + 1, 'true'])";

        public static string WaitForPage = @"var MyDefaultTimeout = 1500; 
            var loaded = false;
            do {
                var comps = document.getElementsByClassName('//*[contains(@id,\'reveal\') and not(contains(@style,\'display: block; top: -100px\'))]');
                var forecast = document.getElementsByClassName('//*[@class=\'is-reveal-open\' and @aria-hidden=\'true\']');
                var gdm = document.getElementsByClassName('//*[contains(@id,\'hover-gear\') and not(contains(@style,\'display: none;\'))]');
                var sso = document.getElementsByClassName('//*[@class=\'atm--loading-icon\']');
                var loadingGear = document.getElementsByClassName('/html/body/div[3]/div/div/div/div/div/img');
                var loadingIndicator = document.getElementsByClassName('//*[contains(@class,\'global-loading-indicator\') and not (@display,\'none\')]');
                var savedAppraisalLoading = document.getElementsByClassName('//*[contains(@id,\'loading-spinner\') and not (contains(@style,\'display: inline-block\'))]');
                
                if((!comps.length == 0) || (!forecast.length == 0) || (!gdm.length == 0) || (!sso.length == 0) || (!loadingGear.length == 0) || (!loadingIndicator.length == 0) || (!savedAppraisalLoading.length == 0))
                {
                    setTimeout(function() { loaded = false }, MyDefaultTimeout);
                }
                else
                { 
                    if(!document.readyState === 'complete')
                    {
                        setTimeout(function() { loaded = false }, MyDefaultTimeout);
                    }
                    else
                    {
                        loaded = true;
                        return document.readyState;
                    }
                }
            }
            while(loaded === false);";


        public string SetEvaluatorXMLVariables(string region, string type, string make, string model, string year, string usage)
        {
            string xml = @"
            <evaluator xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xsi:noNamespaceSchemaLocation='https://betaservices.ironsolutions.com/TradeguideRest2.0/UxEvaluator.xsd'>
                <requests>
                    <auth>
                        <clientId>ux</clientId>
                        <dealerId>123456</dealerId>
                        <email>qa@ironsolutions.com</email>
                        <tier>2</tier>
                    </auth>
                <requestId>19292948191291</requestId>
                <timestamp>24/12/2011 16:00:00 PM UTC</timestamp>
                    <request>
                        <returnVariableUsageAdjustmentRequest>
                            <pricingDate>2019-10-10</pricingDate>
                            <typeCode>"+type+@"</typeCode>
                            <modelYear>"+year+@"</modelYear>
                            <userHours>"+usage+@"</userHours>
                            <makeCode>"+make+@"</makeCode>
                            <model>"+model+@"</model>
                            <issueRegionCode>"+region+@"</issueRegionCode>
                            <guideIndustry>AG</guideIndustry>
                        </returnVariableUsageAdjustmentRequest>
                    </request>
                </requests>
            </evaluator>";
            return xml;
        }
    }
}