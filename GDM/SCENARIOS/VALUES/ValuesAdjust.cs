namespace IRONQA.GDM.SCENARIOS.VALUES
{
    using IRONQA.GDM.PAGES.LANDING;
    using IRONQA.GDM.PAGES.SHARED;
    using IRONQA.GDM.PAGES.VALUESMGR;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class ValuesAdjust
    {
        private IWebDriver driver;
        public ValuesAdjust(IWebDriver _driver) => driver = _driver;

        public void BMV_EditBaseModel()
        {// Verify Base Model BMV Table Edits
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
            vmnav.SelectValuationGroup("Class 7");
            vmnav.ClickValuationGroupSettings();
            vmnav.ToggleEditingRules();
            vmnav.CloseValuationGroupSettings();
            BaseModelValuation bmv = vmnav.ClickBaseModelValuation();
            bmv.ConfirmOnBaseModelValuationPage();
            bmv.EditBaseModelPercent("2016", Util.GetRandomNumber(1));
        }

        public void BMV_EditComparableModel()
        {// Verify Comparable Model BMV Table Edits
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
            vmnav.SelectValuationGroup("Class 7");
            vmnav.ClickValuationGroupSettings();
            vmnav.ToggleEditingRules();
            vmnav.CloseValuationGroupSettings();
            BaseModelValuation bmv = vmnav.ClickBaseModelValuation();
            bmv.ConfirmOnBaseModelValuationPage();
            bmv.EditComparableModelPercent("2016", Util.GetRandomNumber(1));
        }
    }
}
