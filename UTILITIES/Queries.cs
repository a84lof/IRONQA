namespace IRONQA.UTILITIES
{
    using NUnit.Framework;
    using OpenQA.Selenium;

    public class Queries
    {
        public IWebDriver driver;
        public Queries(IWebDriver _driver) => driver = _driver;

        /* 
            Requires: TypeCode, MakeCode, Model, Region and IssueName
            Returns: ResaleCash from last year issued model for ∆%LY calculation in GDM.
            NOTE: this should be from 4 ISSUES PRIOR (same season, but 1 year earlier)
        */
        public static string GetLastYearGuideValue = "select ppv.ResaleCash from ogrepo..PublishedProductValues ppv join ogrepo..OG_ProductYear py on py.productyearid = ppv.productyearid join ogrepo..OG_Product p on p.ProductID = py.ProductID"
        + "where p.Type = 'TR' and p.Make = 'JD' and p.Model = '6145R' and p.Year = '2017' and IssueID in (select IssueID from ogrepo..OG_IssueCalendar"
        + "where IssueRegionCode='D' and IssueName = 'Spring 2018')";

        public static string GetUserId = "select top 1 userId from auth..users_master";

        public static string GetUserAPIFeatures = "select * from Auth.dbo.usersApiFeatures where userId in (select userId from auth.dbo.users_master where email like '%BasicAdmin@usigqa.com%')";
    }
}