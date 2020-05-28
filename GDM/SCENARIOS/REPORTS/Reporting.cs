namespace IRONQA.GDM.SCENARIOS.REPORTS
{
    using System;
    using IRONQA.GDM.PAGES.LANDING;
    using IRONQA.GDM.PAGES.REPORTMGR;
    using IRONQA.GDM.PAGES.SHARED;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Reporting
    {
        private IWebDriver driver;
        public Reporting(IWebDriver _driver) => driver = _driver;

        public void EditSoldReport()
        {// Ensure sold reports can be selected and edited.
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickReports();
            ReportGrid manager = nav.ClickEdit();
            manager.ConfirmOnReportManager();
            manager.ExpandSoldReportFilters();
            manager.SelectEnteredBy("gdmadmin@usigqa.com");
            manager.ClickPerformSearch();
            SoldReportEntry edit = manager.ClickEditPencil();
            edit.ConfirmOnReportEditPage();
            edit.ExpandManualOptions();
            edit.EnterManualOptionDescription("fake rake");
            edit.EnterManualOptionValue("500");
            edit.SubmitManuallyEnteredOption();
            edit.SaveSoldReport();
            edit.ConfirmEditSuccess();
        }

        public void EnterSoldReport_Combine()
        {// Ensure sold reports can be entered from scratch.
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickReports();
            SoldReportEntry entry = nav.ClickEntry();
            entry.ConfirmOnReportEntryPage();
            entry.EnterDealership("USIGQA");
            entry.EnterType("CO");
            entry.EnterMake("JD");
            entry.EnterModel("S650");
            entry.EnterDealerReportedYear("2017");
            entry.EnterEditorEstimatedYear("2017");
            entry.EnterSerialNumber(Util.GetRandomNumber(3) + Util.GetRandomString(2));
            entry.EnterSeparatorHours("1"+Util.GetRandomNumber(3));
            entry.EnterEngineHours(Util.GetRandomNumber(3)); 
            entry.EnterAcreMeter(Util.GetRandomNumber(3));
            entry.EnterChopperHours(Util.GetRandomNumber(3));
            entry.EnterEngineHP("220");
            entry.EnterBushels(Util.GetRandomNumber(3));
            entry.EnterCashPrice(Util.GetRandomNumber(5));
            entry.EnterAdvertisedPrice(Int32.Parse(Util.StoredString)+10.ToString());
            entry.SaveSoldReport();
            entry.ConfirmSaveSuccess();
        }

        public void EnterSoldReport_SkidSteerLoader()
        {// Ensure sold reports can be entered from scratch.
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickReports();
            SoldReportEntry entry = nav.ClickEntry();
            entry.ConfirmOnReportEntryPage();
            entry.EnterDealership("USIGQA");
            entry.EnterType("SS");
            entry.EnterMake("JD");
            entry.EnterModel("325");
            entry.EnterDealerReportedYear("2007");
            entry.EnterEditorEstimatedYear("2007");
            entry.EnterSerialNumber(Util.GetRandomNumber(3) + Util.GetRandomString(2));
            entry.EnterEngineHours("1"+Util.GetRandomNumber(3));
            entry.EnterEngineHP(Util.GetRandomNumber(3));
            entry.EnterBucketWidthInInches(Util.GetRandomNumber(2));
            entry.EnterEngineHP("220");
            entry.EnterBushels(Util.GetRandomNumber(3));
            entry.EnterCashPrice(Util.GetRandomNumber(5));
            entry.EnterAdvertisedPrice(Int32.Parse(Util.StoredString)+10.ToString());
            entry.SaveSoldReport();
            entry.ConfirmSaveSuccess();
        }

        public void LoadEnteredSoldReport()
        {// Open a sold report from the success message banner link.
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickReports();
            SoldReportEntry entry = nav.ClickEntry();
            entry.ConfirmOnReportEntryPage();
            entry.EnterDealership("USIGQA");
            entry.EnterType("CO");
            entry.EnterMake("JD");
            entry.EnterModel("9550");
            entry.EnterDealerReportedYear("2001");
            entry.EnterSerialNumber(Util.GetRandomNumber(3) + Util.GetRandomString(2));
            entry.EnterSeparatorHours("1"+Util.GetRandomNumber(3));
            entry.EnterEngineHours(Util.GetRandomNumber(3)); 
            entry.EnterAcreMeter(Util.GetRandomNumber(3));
            entry.EnterChopperHours(Util.GetRandomNumber(3));
            entry.EnterEngineHP("220");
            entry.EnterBushels(Util.GetRandomNumber(3));
            entry.EnterCashPrice(Util.GetRandomNumber(5));
            entry.EnterAdvertisedPrice(Int32.Parse(Util.StoredString)+10.ToString());
            entry.SaveSoldReport();
            entry.ConfirmSaveSuccess();
            entry.FollowReportSavedLink();
            entry.ConfirmOnReportEditPage();
        }

        public void ResolveDuplicates()
        {// Ensure sold repor duplicates can be resolved.
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickReports();
            ResolveDuplicates duplicates = nav.ClickResolveDuplicates();
            duplicates.ConfirmOnResolveDuplicatesPage();
        }
    }
}
