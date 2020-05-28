namespace IRONQA.GDM.SCENARIOS.VALUES
{
    using IRONQA.GDM.PAGES.LANDING;
    using IRONQA.GDM.PAGES.SHARED;
    using IRONQA.GDM.PAGES.VALUESMGR;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class ValuesComparison
    {
        private IWebDriver driver;
        public ValuesComparison(IWebDriver _driver) => driver = _driver;

        public void BaseValuesComparison_USD()
        {//Compare BMV, LV, RV, & GV Base Values
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            PublishStatus pub = nav.ClickPublishStatus();
            pub.ChangeStatus("Combine", "Class 5", "Complete");
            pub.ClickPrePublish("Combine","Class 5");
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Agricultural);
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 5");
            RegionalValuation rgv = vmnav.ClickRegionalValuation();
            rgv.ConfirmOnRegionalValuationPage();
            rgv.GetAllValues(true,"S650","D"); 
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.GetAllValues(true,"2017","S650"); 
            BaseModelValuation bmv = vmnav.ClickBaseModelValuation();
            bmv.ConfirmOnBaseModelValuationPage();
            bmv.GetAllValues(true,"2017","S650"); 
            bmv.Compare_BaseBMV_To_RGV();
            bmv.Compare_BaseBMV_To_Lineages();
            lineages.CompareBaseLineageToRGV();
            GuideValidation gval = vmnav.ClickGuideValidation();
            gval.ConfirmOnGuideValidationPage();
            gval.SelectManufacturer("John Deere");
            gval.SelectModel("S650");
            gval.GetAllValues("D","Combine","JD","2017");
            gval.ComparePrepublishedGVtoLineages();
        }

        public void BaseValuesComparison_CAD()
        {//Compare BMV, LV, RV, & GV Base Values
            PAGES.LANDING.Login login = new PAGES.LANDING.Login(driver);
            login.ConfirmOnLoginPage();
            Home home = login.SubmitValidCredentials(Users.GDMAdmin, Users.TestPassword);
            home.ConfirmOnHomePage();
            GDMNav nav = new GDMNav(driver);
            nav.ClickValues();
            PublishStatus pub = nav.ClickPublishStatus();
            pub.ChangeStatus("Combine", "Class 5", "Complete");
            pub.ClickPrePublish("Combine","Class 5");
            nav.ClickValues();
            VMNav vmnav = nav.ClickCalculate();
            vmnav.ConfirmValuesManager();
            vmnav.SelectGuideIndustry(VMNav.GuideIndustries.Agricultural);
            vmnav.SelectGuideIssue(TestDetails.AGIssue);
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 5");
            RegionalValuation rgv = vmnav.ClickRegionalValuation();
            rgv.ConfirmOnRegionalValuationPage();
            rgv.GetAllValues(true,"S650","F"); 
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.SelectRegion("F");
            lineages.GetAllValues(true,"2017","S650"); 
            BaseModelValuation bmv = vmnav.ClickBaseModelValuation();
            bmv.ConfirmOnBaseModelValuationPage();
            bmv.SelectRegion("F");
            bmv.GetAllValues(true,"2017","S650"); 
            bmv.Compare_BaseBMV_To_RGV();
            bmv.Compare_BaseBMV_To_Lineages();
            lineages.CompareBaseLineageToRGV();
            GuideValidation gval = vmnav.ClickGuideValidation();
            gval.ConfirmOnGuideValidationPage();
            gval.SelectManufacturer("John Deere");
            gval.SelectModel("S650");
            gval.GetAllValues("F","Combine","JD","2017");
            gval.ComparePrepublishedGVtoLineages();
        }

        public void ComparableValuesComparison()
        {//Compare BMV, LV, * RV Comparable Values
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
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 5");
            RegionalValuation rv = vmnav.ClickRegionalValuation();
            rv.ConfirmOnRegionalValuationPage();
            rv.GetAllValues(false,"5140","D"); 
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.ToggleSelectedFilters();
            lineages.ToggleJDLineageCheckbox();
            lineages.ToggleAGCOLineageCheckbox();
            lineages.ToggleSelectedFilters();
            lineages.GetAllValues(false,"2017","5140");  
            BaseModelValuation bmv = vmnav.ClickBaseModelValuation();
            bmv.ConfirmOnBaseModelValuationPage();
            bmv.GetAllValues(false,"2017","5140"); 
            bmv.Compare_CompBMV_To_RGV();
            bmv.Compare_CompBMV_To_Lineages();
            lineages.CompareCompLineageToRGV();
        }

        public void CompareLVToRV_RegionA()
        {//Compare LV to RV for Region A
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
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 5");
            RegionalValuation rgv = vmnav.ClickRegionalValuation();
            rgv.ConfirmOnRegionalValuationPage();
            rgv.GetAllValues(true,"S650","A");
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.SelectRegion("A");
            lineages.GetAllValues(true,"2017","S650");
            lineages.CompareBaseLineageToRGV();
        }

        public void CompareLVToRV_RegionB()
        {//Compare LV to RV for Region B
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
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 5");
            RegionalValuation rgv = vmnav.ClickRegionalValuation();
            rgv.ConfirmOnRegionalValuationPage();
            rgv.GetAllValues(true,"S650","B");
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.SelectRegion("B");
            lineages.GetAllValues(true,"2017","S650");
            lineages.CompareBaseLineageToRGV();
        }

        public void CompareLVToRV_RegionC()
        {//Compare LV to RV for Region C
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
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 5");
            RegionalValuation rgv = vmnav.ClickRegionalValuation();
            rgv.ConfirmOnRegionalValuationPage();
            rgv.GetAllValues(true,"S650","C");
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.SelectRegion("C");
            lineages.GetAllValues(true,"2017","S650");
            lineages.CompareBaseLineageToRGV();
        }

        public void CompareLVToRV_RegionD()
        {//Compare LV to RV for Region D
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
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 5");
            RegionalValuation rgv = vmnav.ClickRegionalValuation();
            rgv.ConfirmOnRegionalValuationPage();
            rgv.GetAllValues(true,"S650","D");
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.SelectRegion("D");
            lineages.GetAllValues(true,"2017","S650");
            lineages.CompareBaseLineageToRGV();
        }

        public void CompareLVToRV_RegionE()
        {//Compare LV to RV for Region E
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
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 5");
            RegionalValuation rgv = vmnav.ClickRegionalValuation();
            rgv.ConfirmOnRegionalValuationPage();
            rgv.GetAllValues(true,"S650","E");
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.SelectRegion("E");
            lineages.GetAllValues(true,"2017","S650");
            lineages.CompareBaseLineageToRGV();
        }

        public void CompareLVToRV_RegionF()
        {//Compare LV to RV for Region F
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
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 5");
            RegionalValuation rgv = vmnav.ClickRegionalValuation();
            rgv.ConfirmOnRegionalValuationPage();
            rgv.GetAllValues(true,"S650","F");
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.SelectRegion("F");
            lineages.GetAllValues(true,"2017","S650");
            lineages.CompareBaseLineageToRGV();
        }

         public void CompareLVToRV_RegionG()
        {//Compare LV to RV for Region G
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
            vmnav.SelectEquipmentType(VMNav.EquipmentTypes.Combine);
            vmnav.SelectValuationGroup("Class 5");
            RegionalValuation rgv = vmnav.ClickRegionalValuation();
            rgv.ConfirmOnRegionalValuationPage();
            rgv.GetAllValues(true,"S650","G");
            LineageValuation lineages = vmnav.ClickLineageValuation();
            lineages.ConfirmOnLineageValuationPage();
            lineages.SelectRegion("G");
            lineages.GetAllValues(true,"2017","S650");
            lineages.CompareBaseLineageToRGV();
        }
    }
}
