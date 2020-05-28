namespace IRONQA.GDM.SCENARIOS.ROLES
{
    using IRONQA.GDM.PAGES.LANDING;
    using IRONQA.GDM.PAGES.REPORTMGR;
    using IRONQA.GDM.PAGES.SHARED;
    using IRONQA.GDM.PAGES.VALUESMGR;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class RolesMatrix
    {
        private IWebDriver driver;
        public RolesMatrix(IWebDriver _driver) => driver = _driver;

        public void EditSoldReport_Admin()
        {// Ensure admins can edit sold reports from the grid.
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

        public void EditSoldReport_Editor()
        {// Ensure editors can edit sold reports from the grid.
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMEditor, Users.TestPassword);
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
            edit.RefreshPage();
            edit.ExpandManualOptions();
            edit.EnterManualOptionDescription("fake rake");
            edit.EnterManualOptionValue("500");
            edit.SubmitManuallyEnteredOption();
            edit.SaveSoldReport();
            edit.ConfirmEditSuccess();
        }

        public void EditSoldReport_Entry()
        {// Ensure entry roles can edit sold reports from the grid.
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMEntry, Users.TestPassword);
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
            edit.RefreshPage();
            edit.ExpandManualOptions();
            edit.EnterManualOptionDescription("fake rake");
            edit.EnterManualOptionValue("500");
            edit.SubmitManuallyEnteredOption();
            edit.SaveSoldReport();
            edit.ConfirmEditSuccess();
        }

        public void EnterSoldReport_Admin()
        {// Ensure admins can enter sold reports from scratch.
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
            entry.EnterEditorEstimatedYear(""); 
            entry.EnterSerialNumber(Util.GetRandomNumber(3) + Util.GetRandomString(2));
            entry.EnterSeparatorHours("1"+Util.GetRandomNumber(3));
            entry.EnterEngineHours(""); 
            entry.EnterAcreMeter("");
            entry.EnterChopperHours("");
            entry.EnterEngineHP("220");
            entry.EnterBushels("");
            entry.EnterCashPrice("53795");
            entry.EnterAdvertisedPrice("55900");
            entry.SaveSoldReport();
            entry.ConfirmSaveSuccess();
        }

        public void EnterSoldReport_Editor()
        {// Ensure editors can enter sold reports from scratch.
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMEditor, Users.TestPassword);
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
            entry.EnterEditorEstimatedYear(""); 
            entry.EnterSerialNumber(Util.GetRandomNumber(3) + Util.GetRandomString(2));
            entry.EnterSeparatorHours("1"+Util.GetRandomNumber(3));
            entry.EnterEngineHours(""); 
            entry.EnterAcreMeter("");
            entry.EnterChopperHours("");
            entry.EnterEngineHP("220");
            entry.EnterBushels("");
            entry.EnterCashPrice("53795");
            entry.EnterAdvertisedPrice("55900");
            entry.SaveSoldReport();
            entry.ConfirmSaveSuccess();
        }

        public void EnterSoldReport_Entry()
        {// Ensure entry roles can enter sold reports from scratch.
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMEntry, Users.TestPassword);
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
            entry.EnterEditorEstimatedYear(""); 
            entry.EnterSerialNumber(Util.GetRandomNumber(3) + Util.GetRandomString(2));
            entry.EnterSeparatorHours("1"+Util.GetRandomNumber(3));
            entry.EnterEngineHours(""); 
            entry.EnterAcreMeter("");
            entry.EnterChopperHours("");
            entry.EnterEngineHP("220");
            entry.EnterBushels("");
            entry.EnterCashPrice("53795");
            entry.EnterAdvertisedPrice("55900");
            entry.SaveSoldReport();
            entry.ConfirmSaveSuccess();
        }

        public void ResolveDuplicates_Admin()
        {// Ensure admins can resolve duplicate reports.
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickReports();
            ResolveDuplicates duplicates = nav.ClickResolveDuplicates();
            duplicates.ConfirmOnResolveDuplicatesPage();
        }

        public void Calculate_ValuesManager_Admin()
        {//Roles Matrix Check for Admin
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 6");
            Exceptions ex = vmnav.ClickExceptions();                                         
            ex.ConfirmOnExceptionsPage();
            BaseModelValuation bmv = vmnav.ClickBaseModelValuation();
            bmv.ConfirmOnBaseModelValuationPage();
            bmv.ConfirmBaseDeltaPercentAdjustEditable(true);
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.ConfirmGroupYearAdjustEditable(true);
            RegionalValuation regionalValuation = vmnav.ClickRegionalValuation();
            regionalValuation.ConfirmOnRegionalValuationPage();
            regionalValuation.ConfirmBaseModelDataDisplayed();
            regionalValuation.ConfirmComparableModelDataDisplayed();
            GuideValidation guideValidation = vmnav.ClickGuideValidation();
            guideValidation.ConfirmOnGuideValidationPage();
            nav.ClickValues();
            PublishStatus publishProgress = nav.ClickPublishStatus();
            publishProgress.ConfirmOnPublishStatusPage();
        }

        public void Calculate_ValuesManager_Editor()
        {//Roles Matrix Check for Editor
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMEditor, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 6");
            Exceptions ex = vmnav.ClickExceptions();                                             
            ex.ConfirmOnExceptionsPage();
            BaseModelValuation bmv = vmnav.ClickBaseModelValuation();
            bmv.ConfirmOnBaseModelValuationPage();
            bmv.ConfirmBaseDeltaPercentAdjustEditable(true);
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.ConfirmGroupYearAdjustEditable(true);
            RegionalValuation regionalValuation = vmnav.ClickRegionalValuation();
            regionalValuation.ConfirmOnRegionalValuationPage();
            regionalValuation.ConfirmBaseModelDataDisplayed();
            regionalValuation.ConfirmComparableModelDataDisplayed();
            GuideValidation guideValidation = vmnav.ClickGuideValidation();
            guideValidation.ConfirmOnGuideValidationPage();
            nav.ClickValues();
            PublishStatus publishProgress = nav.ClickPublishStatus();
            publishProgress.ConfirmOnPublishStatusPage();
        }

        public void ViewAllPages()
        {//Roles Matrix Check for Viewer
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMViewer, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickReports();
            ReportGrid manager = nav.ClickEdit();
            manager.ConfirmOnReportManager();
            manager.ConfirmReadOnly("true");
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Agricultural);
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 6");
            Exceptions ex = vmnav.ClickExceptions();                                             
            ex.ConfirmOnExceptionsPage();
            BaseModelValuation bmv = vmnav.ClickBaseModelValuation();
            bmv.ConfirmOnBaseModelValuationPage();
            bmv.ConfirmBaseDeltaPercentAdjustEditable(true);
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.ConfirmGroupYearAdjustEditable(true);
            RegionalValuation regionalValuation = vmnav.ClickRegionalValuation();
            regionalValuation.ConfirmOnRegionalValuationPage();
            regionalValuation.ConfirmBaseModelDataDisplayed();
            regionalValuation.ConfirmComparableModelDataDisplayed();
            GuideValidation guideValidation = vmnav.ClickGuideValidation();
            guideValidation.ConfirmOnGuideValidationPage();
            nav.ClickValues();
            PublishStatus publishProgress = nav.ClickPublishStatus();
            publishProgress.ConfirmOnPublishStatusPage();
        }
    }
}