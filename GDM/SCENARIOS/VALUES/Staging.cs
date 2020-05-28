namespace IRONQA.GDM.SCENARIOS.VALUES
{
    using IRONQA.GDM.PAGES.LANDING;
    using IRONQA.GDM.PAGES.SHARED;
    using IRONQA.GDM.PAGES.VALUESMGR;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using static IRONQA.GDM.PAGES.VALUESMGR.VMNav;

    public class Staging
    {
        private IWebDriver driver;
        public Staging(IWebDriver _driver) => driver = _driver;

        public void ConfirmAGLineages_RegionA()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Agricultural);
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Round,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Square,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Combine,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Cotton,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Forage,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Header,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Mower,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Skid,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Sprayer,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Track,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Tractor,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Windrower,"A");
        }

        public void ConfirmAGLineages_RegionB()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Agricultural);
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            LineageValuation lineages = vmnav.ClickLineageValuation();
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Round,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Square,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Combine,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Cotton,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Forage,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Header,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Mower,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Skid,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Sprayer,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Track,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Tractor,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Windrower,"B");
        }
        
        public void ConfirmAGLineages_RegionC()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Agricultural);
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            LineageValuation lineages = vmnav.ClickLineageValuation();
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Round,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Square,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Combine,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Cotton,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Forage,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Header,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Mower,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Skid,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Sprayer,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Track,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Tractor,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Windrower,"C");
        }

        public void ConfirmAGLineages_RegionD()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Agricultural);
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            LineageValuation lineages = vmnav.ClickLineageValuation();
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Round,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Square,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Combine,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Cotton,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Forage,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Header,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Mower,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Skid,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Sprayer,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Track,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Tractor,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Windrower,"D");
        }

        public void ConfirmAGLineages_RegionE()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Agricultural);
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            LineageValuation lineages = vmnav.ClickLineageValuation();
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Round,"E");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Square,"E");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Combine,"E");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Cotton,"E");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Forage,"E");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Header,"E");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Mower,"E");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Skid,"E");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Sprayer,"E");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Track,"E");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Tractor,"E");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Windrower,"E");
        }

        public void ConfirmAGLineages_RegionF()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Agricultural);
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            LineageValuation lineages = vmnav.ClickLineageValuation();
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Round,"F");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Square,"F");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Combine,"F");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Cotton,"F");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Forage,"F");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Header,"F");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Mower,"F");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Skid,"F");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Sprayer,"F");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Track,"F");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Tractor,"F");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Windrower,"F");
        }

        public void ConfirmAGLineages_RegionG()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Agricultural);
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            LineageValuation lineages = vmnav.ClickLineageValuation();
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Round,"G");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Square,"G");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Combine,"G");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Cotton,"G");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Forage,"G");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Header,"G");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Mower,"G");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Skid,"G");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Sprayer,"G");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Track,"G");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Tractor,"G");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Windrower,"G");
        }

        public void ConfirmCELineages_RegionA()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Construction);
            vmnav.SelectGuideIssue(TestDetails.CEIssue);
            LineageValuation lineages = vmnav.ClickLineageValuation();
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Backhoe,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Dozer,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Excavator,"A");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Wheel,"A");
        }

        public void ConfirmCELineages_RegionB()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Construction);
            vmnav.SelectGuideIssue(TestDetails.CEIssue);
            LineageValuation lineages = vmnav.ClickLineageValuation();
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Backhoe,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Dozer,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Excavator,"B");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Wheel,"B");
        }

        public void ConfirmCELineages_RegionC()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Construction);
            vmnav.SelectGuideIssue(TestDetails.CEIssue);
            LineageValuation lineages = vmnav.ClickLineageValuation();
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Backhoe,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Dozer,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Excavator,"C");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Wheel,"C");
        }

        public void ConfirmCELineages_RegionD()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Construction);
            vmnav.SelectGuideIssue(TestDetails.CEIssue);
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Backhoe,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Dozer,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Excavator,"D");
            vmnav.ConfirmLineage(VMNav.EquipmentTypes.Wheel,"D");
        }

        public void AllVGBMV()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(GuideIndustries.Agricultural);
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            vmnav.SelectEquipmentType(EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 6");
            BaseModelValuation bmv = vmnav.ClickBaseModelValuation();
            bmv.ConfirmOnBaseModelValuationPage();
        }

        public void PrepublishValuationGroup()
        {
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            PublishStatus status = nav.ClickPublishStatus();
            status.ChangeStatus("Combine","Class 5","Complete");
            status.ClickPrePublish("Combine","Class 5");
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(GuideIndustries.Agricultural);
            vmnav.SelectGuideIssue(TestDetails.CurrentIssue);
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 5");
            GuideValidation gval = vmnav.ClickGuideValidation();
            gval.ConfirmOnGuideValidationPage();
            gval.ConfirmPrepublishedValues();
        }
    }
}