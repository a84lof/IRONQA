namespace IRONQA.GUIDES.SCENARIOS.APPRAISALS
{
    using IRONQA.GUIDES.PAGES.TESTHARNESS.PAGES;
    using IRONQA.GUIDES.PAGES.APPRAISAL;
    using IRONQA.GUIDES.PAGES.SHARED;
    using IRONQA.GUIDES.PAGES.DASHBOARD;
    using IRONQA.SSO.PAGES;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Appraisal
    {
        private IWebDriver driver;
        public Appraisal(IWebDriver _driver) => driver = _driver;

        /* TEST LIST:
        [1] Add Custom Options to Appraisal
        [2] Add Prospect to Appraisal
        [3] AG Appraisal 
            - BasicAdmin (2 Step)
            - BasicUser (2 Step)
            - PlusAdmin (3 Step)
            - PlusUser (3 Step)
            - ProAdmin (5 Step with Forecast)
            - ProUser (5 Step with Forecast)
        [4] ISBG Appraisal
        [5] 5Edit Appraisal
            - PlusAdmin
            - ProAdmin
        [6] OPE Appraisal
            - BasicAdmin (2 Step)
            - BasicUser (2 Step)
            - PlusAdmin (3 Step)
            - PlusUser (3 Step)
            - ProAdmin (5 Step)
            - ProUser (5 Step)
        [7] Submit Appraisal To Canadian Inventory
        [8] Submit Appraisal To US Inventory
        [9] Trade Guide Variable Usage
        [10] Upgrade Appraisal
            - BasicAdmin
            - BasicUser
            - PlusAdmin
            - PlusUser
            - ProAdmin
            - ProUser
        */ 

        public void AddCustomOptionsToAppraisal()
        {// Download and Save Pro Appraisal at each Step 
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickAgricultureEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USAGRegion);
            step1.SelectIssue(TestDetails.AGIssue);
            step1.SelectType(TestDetails.AGType);
            step1.SelectMake(TestDetails.AGMake);
            step1.SelectModel(TestDetails.AGModel);
            step1.ClickYear(TestDetails.AGYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            step2.ToggleSelectedOptions();
            step2.SelectOption();
            step2.ToggleSelectedOptions();
            step2.ToggleMyOptions();
            step2.EnterNewCustomOption(TestDetails.CustomOptionName);
            step2.ClickAddOption();
            step2.EnterCustomOptionValue(TestDetails.CustomOptionValue);
            step2.ToggleMyOptions();
            step2.EnterCashSellingPriceAdj(TestDetails.CashPriceAdjustment);
            step2.EnterDealershipMargin(TestDetails.DealershipMargin);
            step2.EnterReconditioning(TestDetails.Reconditioning);
            step2.EnterDeliveryAllowance(TestDetails.DeliveryAllowance);
            step2.EnterOtherReserve(TestDetails.OtherReserve);
            step2.ClickSaveDownload();
        }

        public void AddProspectToAppraisal()
        {// Download and Save Pro Appraisal at each Step
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickAgricultureEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.CanAGRegion);
            step1.SelectType(TestDetails.AGType);
            step1.SelectMake(TestDetails.AGMake);
            step1.SelectModel(TestDetails.AGModel);
            step1.ClickYear(TestDetails.AGYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            Step3 step3 = step2.ClickCheckComparables();
            step3.ConfirmOnStep3();
            Step4 step4 = step3.ClickFloorPlan();
            step4.ConfirmOnStep4();
            Step5 step5 = step4.ClickAddProspects();
            step5.GenerateProspect();
            step5.ConfirmProspectAdded();
            step5.ClickEditThisProspect();
            step5.ClickDeleteThisProspect();
            step5.ConfirmProspectDeleted();
        }

        public void AGAppraisal_BasicAdmin()
        {// Download and save a Basic Appraisal
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickAgricultureEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USAGRegion);
            step1.SelectType(TestDetails.AGType);
            step1.SelectMake(TestDetails.AGMake);
            step1.SelectModel(TestDetails.AGModel);
            step1.ClickYear(TestDetails.AGYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            step2.ConfirmIronBaseValues();
            step2.ConfirmIronAppraiserValues();
            step2.ConfirmVariableUsage();
            step2.ConfirmCustomAdjustCalculation();
        }

        public void AGAppraisal_BasicUser()
        {// Download and save a Basic Appraisal
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickAgricultureEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USAGRegion);
            step1.SelectType(TestDetails.AGType);
            step1.SelectMake(TestDetails.AGMake);
            step1.SelectModel(TestDetails.AGModel);
            step1.ClickYear(TestDetails.AGYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            step2.ConfirmIronBaseValues();
            step2.ConfirmIronAppraiserValues();
            step2.ConfirmVariableUsage();
            step2.ConfirmCustomAdjustCalculation();
        }

        public void AGAppraisal_PlusAdmin()
        {// Download and save Plus Appraisal at each Step
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USPlusAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickAgricultureEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USAGRegion);
            step1.SelectType(TestDetails.AGType);
            step1.SelectMake(TestDetails.AGMake);
            step1.SelectModel(TestDetails.AGModel);
            step1.ClickYear(TestDetails.AGYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            step2.ConfirmIronBaseValues();
            step2.ConfirmIronAppraiserValues();
            step2.ConfirmVariableUsage();
            step2.ConfirmCustomAdjustCalculation();
            Step3 step3 = step2.ClickCheckComparables();
            step3.ConfirmOnStep3();
        }

        public void AGAppraisal_PlusUser()
        {// Download and save Plus Appraisal at each Step
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USPlusUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickAgricultureEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USAGRegion);
            step1.SelectType(TestDetails.AGType);
            step1.SelectMake(TestDetails.AGMake);
            step1.SelectModel(TestDetails.AGModel);
            step1.ClickYear(TestDetails.AGYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            step2.ConfirmIronBaseValues();
            step2.ConfirmIronAppraiserValues();
            step2.ConfirmVariableUsage();
            step2.ConfirmCustomAdjustCalculation();
            Step3 step3 = step2.ClickCheckComparables();
            step3.ConfirmOnStep3();
        }

        public void AGAppraisal_ProAdmin()
        {// Download and Save Pro Appraisal at each Step
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickAgricultureEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USAGRegion);
            step1.SelectType(TestDetails.AGType);
            step1.SelectMake(TestDetails.AGMake);
            step1.SelectModel(TestDetails.AGModel);
            step1.ClickYear(TestDetails.AGYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            step2.ConfirmIronBaseValues();
            step2.ConfirmIronAppraiserValues();
            step2.ConfirmVariableUsage();
            step2.ConfirmCustomAdjustCalculation();
            step2.ConfirmMarketForecast();
            Step3 step3 = step2.ClickCheckComparables();
            step3.ConfirmOnStep3();
            Step4 step4 = step3.ClickFloorPlan();
            step4.ConfirmOnStep4();
            Step5 step5 = step4.ClickAddProspects();
            step5.ConfirmOnStep5();
        }

        public void AGAppraisal_ProUser()
        {// Download and Save Pro Appraisal at each Step
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickAgricultureEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USAGRegion);
            step1.SelectType(TestDetails.AGType);
            step1.SelectMake(TestDetails.AGMake);
            step1.SelectModel(TestDetails.AGModel);
            step1.ClickYear(TestDetails.AGYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            step2.ConfirmIronBaseValues();
            step2.ConfirmIronAppraiserValues();
            step2.ConfirmVariableUsage();
            step2.ConfirmCustomAdjustCalculation();
            Step3 step3 = step2.ClickCheckComparables();
            step3.ConfirmOnStep3();
            Step4 step4 = step3.ClickFloorPlan();
            step4.ConfirmOnStep4();
            Step5 step5 = step4.ClickAddProspects();
            step5.ConfirmOnStep5();
        }

        public void ISBGAppraisal()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickIronSearchBuyersGuide();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.ISBGRegion);
            step1.SelectType(TestDetails.ISBGType);
            step1.SelectMake(TestDetails.ISBGMake);
            step1.SelectModel(TestDetails.ISBGModel);
            step1.ClickYear(TestDetails.ISBGYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
        }

        public void EditAppraisal_Pro()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            SavedAppraisals saved = dashNav.ClickMySavedAppraisals();
            saved.ClickProAppraisalPencil();
            //sa.GetAppraisalID();
            Step2 step2 = saved.ClickEditProAppraisal();
            step2.ConfirmOnStep2();
        }

        public void EditAppraisal_Plus()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USPlusAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            SavedAppraisals saved = dashNav.ClickMySavedAppraisals();
            saved.ClickPlusAppraisalPencil();
            //sa.GetAppraisalID();
            Step2 step2 = saved.ClickEditPlusAppraisal();
            step2.ConfirmOnStep2();
        }

        public void OPEAppraisal_BasicAdmin()
        {// Download and save a Basic Appraisal
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickOutdoorPowerEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USOPERegion);
            step1.SelectType(TestDetails.OPEType);
            step1.SelectMake(TestDetails.OPEMake);
            step1.SelectModel(TestDetails.OPEModel);
            step1.ClickYear(TestDetails.OPEYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
        }

        public void OPEAppraisal_BasicUser()
        {// Download and save a Basic Appraisal
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickOutdoorPowerEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USOPERegion);
            step1.SelectType(TestDetails.OPEType);
            step1.SelectMake(TestDetails.OPEMake);
            step1.SelectModel(TestDetails.OPEModel);
            step1.ClickYear(TestDetails.OPEYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
        }

        public void OPEAppraisal_PlusAdmin()
        {// Download and save Plus Appraisal at each Step
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USPlusAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickOutdoorPowerEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USOPERegion);
            step1.SelectType(TestDetails.OPEType);
            step1.SelectMake(TestDetails.OPEMake);
            step1.SelectModel(TestDetails.OPEModel);
            step1.ClickYear(TestDetails.OPEYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            Step3 step3 = step2.ClickCheckComparables();
            step3.ConfirmOnStep3();
        }

        public void OPEAppraisal_PlusUser()
        {// Download and save Plus Appraisal at each Step
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USPlusUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickOutdoorPowerEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USOPERegion);
            step1.SelectType(TestDetails.OPEType);
            step1.SelectMake(TestDetails.OPEMake);
            step1.SelectModel(TestDetails.OPEModel);
            step1.ClickYear(TestDetails.OPEYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            Step3 step3 = step2.ClickCheckComparables();
            step3.ConfirmOnStep3();
        }

        public void OPEAppraisal_ProAdmin()
        {// Download and Save Pro Appraisal at each Step
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            new GuidesNav(driver);
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickOutdoorPowerEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USOPERegion);
            step1.SelectType(TestDetails.OPEType);
            step1.SelectMake(TestDetails.OPEMake);
            step1.SelectModel(TestDetails.OPEModel);
            step1.ClickYear(TestDetails.OPEYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            Step3 step3 = step2.ClickCheckComparables();
            step3.ConfirmOnStep3();
            Step4 step4 = step3.ClickFloorPlan();
            step4.ConfirmOnStep4();
            Step5 step5 = step4.ClickAddProspects();
            step5.ConfirmOnStep5();
        }

        public void OPEAppraisal_ProUser()
        {// Download and Save Pro Appraisal at each Step
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            new GuidesNav(driver);
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickOutdoorPowerEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USAGRegion);
            step1.SelectType(TestDetails.OPEType);
            step1.SelectMake(TestDetails.OPEMake);
            step1.SelectModel(TestDetails.OPEModel);
            step1.ClickYear(TestDetails.OPEYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            Step3 step3 = step2.ClickCheckComparables();
            step3.ConfirmOnStep3();
            Step4 step4 = step3.ClickFloorPlan();
            step4.ConfirmOnStep4();
            Step5 step5 = step4.ClickAddProspects();
            step5.ConfirmOnStep5();
        }

        public void SubmitAppraisalToCanadianInventory()
        {// Complete an Appraisal and then send it to Inventory
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.CANProAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickAgricultureEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USAGRegion);
            step1.SelectType(TestDetails.AGType);
            step1.SelectMake(TestDetails.AGMake);
            step1.SelectModel(TestDetails.AGModel);
            step1.ClickYear(TestDetails.AGYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            step2.ClickCopyToInventory();
        }

        public void SubmitAppraisalToUSInventory()
        {// Complete an Appraisal and then send it to Inventory
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            guidesNav.ClickStartAppraisal();
            Step1 step1 = guidesNav.ClickAgricultureEquipment();
            step1.ConfirmOnStep1();
            step1.SelectStateProv(TestDetails.USAGRegion);
            step1.SelectType(TestDetails.AGType);
            step1.SelectMake(TestDetails.AGMake);
            step1.SelectModel(TestDetails.AGModel);
            step1.ClickYear(TestDetails.AGYear);
            step1.EnterSerialNumber(TestDetails.SerialNumber);
            Step2 step2 = step1.ClickLookupValue();
            step2.ConfirmOnStep2();
            step2.ClickCopyToInventory();
        }

        public void TradeGuideVariableUsage()
        {// Confirm response from HQ Appraisal using test harness
            driver.Navigate().GoToUrl("https://betaservices.ironsolutions.com/tradeguiderest2/test/");
            Scripts script = new Scripts(driver);
            string xml = script.SetEvaluatorXMLVariables("D","CO","JD","S670","2018","456");
            TestHarness harness = new TestHarness(driver);
            harness.EnterRequestXML(xml);
            harness.ClickPostXML();
            harness.ConfirmResponse();
        }

        public void UpgradeAppraisal_ProAdmin()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            SavedAppraisals saved = dashNav.ClickMySavedAppraisals();
            saved.ClickProAppraisalPencil();
            //sa.GetAppraisalID();
            Step2 step2 = saved.ClickProUpdateAppraisal();
            step2.ConfirmOnStep2();
        }

        public void UpgradeAppraisal_PlusAdmin()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USPlusAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            SavedAppraisals saved = dashNav.ClickMySavedAppraisals();
            saved.ClickPlusAppraisalPencil();
            //sa.GetAppraisalID();
            Step2 step2 = saved.ClickPlusUpdateAppraisal();
            step2.ConfirmOnStep2();
        }

        public void UpgradeAppraisal_BasicAdmin()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            SavedAppraisals saved = dashNav.ClickMySavedAppraisals();
            saved.ClickBasicAppraisalPencil();
            //sa.GetAppraisalID();
            Step2 step2 = saved.ClickBasicUpdateAppraisal();
            step2.ConfirmOnStep2();
        }

        public void UpgradeAppraisal_ProUser()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USProUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            SavedAppraisals saved = dashNav.ClickMySavedAppraisals();
            saved.ClickProAppraisalPencil();
            //sa.GetAppraisalID();
            Step2 step2 = saved.ClickProUpdateAppraisal();
            step2.ConfirmOnStep2();
        }

        public void UpgradeAppraisal_PlusUser()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USPlusUser, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            SavedAppraisals saved = dashNav.ClickMySavedAppraisals();
            saved.ClickPlusAppraisalPencil();
            //sa.GetAppraisalID();
            Step2 step2 = saved.ClickPlusUpdateAppraisal();
            step2.ConfirmOnStep2();
        }

        public void UpgradeAppraisal_BasicUser()
        {
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicAdmin, Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            DashboardNav dashNav = sso.ClickIronGuides();
            dashNav.ConfirmDashboard();
            GuidesNav guidesNav = new GuidesNav(driver);
            SavedAppraisals saved = dashNav.ClickMySavedAppraisals();
            saved.ClickBasicAppraisalPencil();
            //sa.GetAppraisalID();
            Step2 step2 = saved.ClickBasicUpdateAppraisal();
            step2.ConfirmOnStep2();
        }
    }
}