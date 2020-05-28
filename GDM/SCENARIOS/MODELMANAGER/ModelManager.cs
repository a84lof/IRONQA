namespace IRONQA.GDM.SCENARIOS.MODELMANAGER
{
    using IRONQA.GDM.PAGES.MODELMGR;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class ModelManager
    {
        private IWebDriver driver;
        public ModelManager(IWebDriver _driver) => driver = _driver;

        public void OpenModelFromSideRail()
        {
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            login.EnterEmail(Users.GDMAdmin);
            login.EnterPassword(Users.TestPassword);
            EquipmentModels equip = login.ClickLogin();
            equip.ConfirmOnEquipmentModelsPage();
            equip.ExpandType("Combine");
            equip.ExpandMake("John Deere");
            equip.EditModel("John Deere","S650");
            equip.ConfirmAllModelYearsDisplayed();
        }

        public void OpenModelFromHeaders()
        {
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            login.EnterEmail(Users.GDMAdmin);
            login.EnterPassword(Users.TestPassword);
            EquipmentModels equip = login.ClickLogin();
            equip.ConfirmOnEquipmentModelsPage();
            equip.EnterHeaderType("Combine");
            equip.EnterHeaderMake("John Deere");
            equip.EnterHeaderModel("S650");
            equip.ConfirmAllModelYearsDisplayed();
        }

        public void AddNewModelYear()
        {
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            login.EnterEmail(Users.GDMAdmin);
            login.EnterPassword(Users.TestPassword);
            EquipmentModels equip = login.ClickLogin();
            equip.ConfirmOnEquipmentModelsPage();
            equip.EnterHeaderType("Combine");
            equip.EnterHeaderMake("John Deere");
            equip.EnterHeaderModel("S650");
            equip.ConfirmAllModelYearsDisplayed();
            ModelYear modelYear = equip.ClickAddNewYear();
            modelYear.ConfirmModelYearPage();
            modelYear.ClickInsert();
            modelYear.ConfirmStandardFeaturesDisplayed();
        }

        public void DeleteModelYear()
        {
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            login.EnterEmail(Users.GDMAdmin);
            login.EnterPassword(Users.TestPassword);
            EquipmentModels equip = login.ClickLogin();
            equip.ConfirmOnEquipmentModelsPage();
            equip.EnterHeaderType("Combine");
            equip.EnterHeaderMake("John Deere");
            equip.EnterHeaderModel("S650");
            equip.ConfirmAllModelYearsDisplayed();
            equip.DeleteLatestModelYear();
        }

        public void AddOption()
        {
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            login.EnterEmail(Users.GDMAdmin);
            login.EnterPassword(Users.TestPassword);
            EquipmentModels equip = login.ClickLogin();
            equip.ConfirmOnEquipmentModelsPage();
            equip.EnterHeaderType("Combine");
            equip.EnterHeaderMake("John Deere");
            equip.EnterHeaderModel("S650");
            equip.ConfirmAllModelYearsDisplayed();
            ModelYear modelYear = equip.SelectModelYearOptions("2014");
            modelYear.ConfirmModelYearPage();
            modelYear.ConfirmOptionsDisplayed();
            modelYear.ClickAddNewOption();
            modelYear.EnterOptionDescription("Test"+Util.GetRandomString(3));
            modelYear.ClickInsertOption();
            modelYear.ConfirmOptionDisplayed("Test"+Util.StoredString);
        }

        public void EditOptionOEMCode()
        {/* confirm ability to exit OEM Code and that doing so doesn't 
            break the link to Pick List Manager */ 
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            login.EnterEmail(Users.GDMAdmin);
            login.EnterPassword(Users.TestPassword);
            EquipmentModels equip = login.ClickLogin();
            equip.ConfirmOnEquipmentModelsPage();
            equip.EnterHeaderType("Combine");
            equip.EnterHeaderMake("John Deere");
            equip.EnterHeaderModel("S650");
            equip.ConfirmAllModelYearsDisplayed();
            ModelYear modelYear = equip.SelectModelYearOptions("2014");
            modelYear.ConfirmModelYearPage();
            modelYear.ConfirmOptionDisplayed("Cab Deluxe");
            modelYear.ClickEditOption("Cab Deluxe");
            modelYear.EditOEMCode("TEST");
            modelYear.ClickSaveOption();
            modelYear.ConfirmOptionOEM("TEST");
            modelYear.ConfirmLinkedtoPicklist("Cab Deluxe", "T");
            modelYear.ClickEditOption("Cab Deluxe");
            modelYear.EditOEMCode("0");
            modelYear.ClickSaveOption();
            modelYear.ConfirmOptionOEM("0");
        }

        public void EditOptionDescription()
        {/* Confirm ability to change the Option Description and Print Description 
            and that doing so breaks the link with Pick List Manager */
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            login.EnterEmail(Users.GDMAdmin);
            login.EnterPassword(Users.TestPassword);
            EquipmentModels equip = login.ClickLogin();
            equip.ConfirmOnEquipmentModelsPage();
            equip.EnterHeaderType("Combine");
            equip.EnterHeaderMake("John Deere");
            equip.EnterHeaderModel("S650");
            equip.ConfirmAllModelYearsDisplayed();
            ModelYear modelYear = equip.SelectModelYearOptions("2014");
            modelYear.ConfirmModelYearPage();
            // find option and confirm linked
            modelYear.ConfirmOptionDisplayed("Cab Deluxe");
            modelYear.ConfirmLinkedtoPicklist("Cab Deluxe","T");
            modelYear.ClickEditOption("Cab Deluxe");
            // edit option descriptions and confirm link broken
            modelYear.EditOptionDescription("CabDeluxe");
            modelYear.EditPrintDescription("CabDeluxe");
            modelYear.ClickSaveOption();
            modelYear.ConfirmOptionDisplayed("CabDeluxe");
            modelYear.ConfirmLinkedtoPicklist("CabDeluxe", "F");
            // delete broken option and replace with linked
            modelYear.DeleteOption("CabDeluxe");
            modelYear.ConfirmModelYearPage();
            modelYear.ConfirmOptionsDisplayed();
            modelYear.ConfirmOptionDeleted("CabDeluxe");
            modelYear.ClickAddNewOption();
            modelYear.EnterOptionDescription("Cab Deluxe");
            modelYear.ClickInsertOption();
            modelYear.ConfirmOptionDisplayed("Cab Deluxe");
        }

        public void DeleteOption()
        {
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            login.EnterEmail(Users.GDMAdmin);
            login.EnterPassword(Users.TestPassword);
            EquipmentModels equip = login.ClickLogin();
            equip.ConfirmOnEquipmentModelsPage();
            equip.EnterHeaderType("Combine");
            equip.EnterHeaderMake("John Deere");
            equip.EnterHeaderModel("S650");
            equip.ConfirmAllModelYearsDisplayed();
            ModelYear modelYear = equip.SelectModelYearOptions("2014");
            modelYear.ConfirmModelYearPage();
            // find option and confirm linked
            modelYear.ConfirmOptionDisplayed("CabDeluxe");
            modelYear.DeleteOption("CabDeluxe");
            modelYear.ConfirmModelYearPage();
            modelYear.ConfirmOptionsDisplayed();
            modelYear.ConfirmOptionDeleted("CabDeluxe");
        }

        public void EnterNewPriceNotesUS()
        {
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            login.EnterEmail(Users.GDMAdmin);
            login.EnterPassword(Users.TestPassword);
            EquipmentModels equip = login.ClickLogin();
            equip.ConfirmOnEquipmentModelsPage();
            equip.EnterHeaderType("Combine");
            equip.EnterHeaderMake("John Deere");
            equip.EnterHeaderModel("S650");
            equip.ConfirmAllModelYearsDisplayed();
            equip.ClickNewPriceNotesUS("2014");
            equip.ClearNotes();
            equip.EnterNotes(Util.GetRandomString(25));
            equip.ClickSaveNotes();
        }

        public void EnterNewPriceNotesCA()
        {
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            login.EnterEmail(Users.GDMAdmin);
            login.EnterPassword(Users.TestPassword);
            EquipmentModels equip = login.ClickLogin();
            equip.ConfirmOnEquipmentModelsPage();
            equip.EnterHeaderType("Combine");
            equip.EnterHeaderMake("John Deere");
            equip.EnterHeaderModel("S650");
            equip.ConfirmAllModelYearsDisplayed();
            equip.ClickNewPriceNotesUS("2014");
            equip.ClearNotes();
            equip.EnterNotes(Util.GetRandomString(25));
            equip.ClickSaveNotes();
        }

        public void EnterStdSpecNotes()
        {
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            login.EnterEmail(Users.GDMAdmin);
            login.EnterPassword(Users.TestPassword);
            EquipmentModels equip = login.ClickLogin();
            equip.ConfirmOnEquipmentModelsPage();
            equip.EnterHeaderType("Combine");
            equip.EnterHeaderMake("John Deere");
            equip.EnterHeaderModel("S650");
            equip.ConfirmAllModelYearsDisplayed();
            equip.ClickStdSpecNotes("2014");
            equip.ClearNotes();
            equip.EnterNotes(Util.GetRandomString(25));
            equip.ClickSaveNotes();
        }

        public void ClearNotes()
        {
            Login login = new Login(driver);
            login.ConfirmOnLoginPage();
            login.EnterEmail(Users.GDMAdmin);
            login.EnterPassword(Users.TestPassword);
            EquipmentModels equip = login.ClickLogin();
            equip.ConfirmOnEquipmentModelsPage();
            equip.EnterHeaderType("Combine");
            equip.EnterHeaderMake("John Deere");
            equip.EnterHeaderModel("S650");
            equip.ConfirmAllModelYearsDisplayed();
            equip.ClickNewPriceNotesUS("2014");
            equip.ClearNotes();
        }
    }
}