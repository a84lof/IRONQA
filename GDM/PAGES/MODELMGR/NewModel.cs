namespace IRONQA.GDM.PAGES.MODELMGR
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class NewModel
    {
        private IWebDriver driver;
        public NewModel(IWebDriver _driver) => driver = _driver;

        private IWebElement Type => driver.FindElement(By.Id("CurrentProductEditor_TypeDropDown_Input"));
        private IWebElement Make => driver.FindElement(By.Id("CurrentProductEditor_MakeDropDown_Input"));
        private IWebElement Model => driver.FindElement(By.Id("CurrentProductEditor_Model"));
        private IWebElement PrintModel => driver.FindElement(By.Id("CurrentProductEditor_PrintModel"));
        private IWebElement EqtClass => driver.FindElement(By.Id("CurrentProductEditor_EqtClassCB_Input"));
        private IWebElement ModelSort => driver.FindElement(By.Id("CurrentProductEditor_ModelSort"));
        private IWebElement FullMake => driver.FindElement(By.Id("CurrentProductEditor_FullMake_Input"));
        private IWebElement CurrentMfr => driver.FindElement(By.Id("CurrentProductEditor_CurrentMfr_Input"));
        private IWebElement ModelKey => driver.FindElement(By.Id("CurrentProductEditor_ModelKey"));
        private IWebElement USAnnualDepreciation => driver.FindElement(By.Id("CurrentProductEditor_DeprUs"));
        private IWebElement CanAnnualDepreciation => driver.FindElement(By.Id("CurrentProductEditor_DeprCan"));
        private IWebElement USStartYear => driver.FindElement(By.Id("CurrentProductEditor_StartUs"));
        private IWebElement USEndYear => driver.FindElement(By.Id("CurrentProductEditor_EndUs"));
        private IWebElement CanStartYear => driver.FindElement(By.Id("CurrentProductEditor_StartCan"));
        private IWebElement CanEndYear => driver.FindElement(By.Id("CurrentProductEditor_EndCan"));
        private IWebElement Replaces => driver.FindElement(By.Id("CurrentProductEditor_Replaces"));
        private IWebElement ReplacedBy => driver.FindElement(By.Id("CurrentProductEditor_ReplacedBy"));
        private IWebElement ModelFamily => driver.FindElement(By.Id("CurrentProductEditor_ModelFamily_Input"));
        private IWebElement PublishComment => driver.FindElement(By.Id("CurrentProductEditor_PublishComment"));
        private IWebElement EditorComment => driver.FindElement(By.Id("CurrentProductEditor_EditorComment"));
        private IWebElement Location => driver.FindElement(By.Id("CurrentProductEditor_SN_Location"));
        private IWebElement PublishSerialNoAG => driver.FindElement(By.Id("CurrentProductEditor_SN_AG"));
        private IWebElement PublishSerialNoOPE => driver.FindElement(By.Id("CurrentProductEditor_SN_OPE"));
        private IWebElement SerialNoPublishComment => driver.FindElement(By.Id("CurrentProductEditor_SN_PublishComments"));
        private IWebElement SerialNoEditorComment => driver.FindElement(By.Id("CurrentProductEditor_SN_EditorComments"));
        private IWebElement Insert => driver.FindElement(By.Id("CurrentProductEditor_btnInsert_input"));
        private IWebElement Cancel => driver.FindElement(By.Id("CurrentProductEditor_btnCancel_input"));

        public void ConfirmNewModelPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","CurrentProductEditor_btnInsert_input");
            Util.Log("On New Model Page.");
        }

        public void EnterModel(string model)
        {
            Model.SendKeys(model);
            Util.Log("Entered Model: "+model);
        }

        public void EnterPrintModel(string model)
        {
            PrintModel.SendKeys(model);
            Util.Log("Entered Print Model: "+model);
        }

        public void EnterEqtClass(string eqt)
        {
            EqtClass.SendKeys(eqt);
            Util.Log("Entered EqtClass: "+eqt);
        }

        public void EnterUSStartYear(string year)
        {
            USStartYear.SendKeys(year);
            Util.Log("Entered US Start Year: "+year);
        }

        public void EnterUSEndYear(string year)
        {
            USEndYear.SendKeys(year);
            Util.Log("Entered US End Year: "+year);
        }

        public void EnterCanStartYear(string year)
        {
            CanStartYear.SendKeys(year);
            Util.Log("Entered Canadian Start Year: "+year);
        }

        public void EnterCanEndYear(string year)
        {
            CanEndYear.SendKeys(year);
            Util.Log("Entered Canadian End Year: "+year);
        }

        public void SelectModelFamily(string family)
        {
            ModelFamily.SendKeys(family);
            Util.Log("Entered Model Family: "+family);
        }

        public void EnterPublishComment(string comment)
        {
            PublishComment.SendKeys(comment);
            Util.Log("entered Publish Comment: "+comment);
        }

        public void EnterEditorComment(string comment)
        {
            EditorComment.SendKeys(comment);
            Util.Log("Entered Editor Comment: "+comment);
        }

        public void EnterLocation(string location)
        {
            Location.SendKeys(location);
            Util.Log("Entered Location: "+location);
        }

        public void EnterSerialNoPublishComment(string comment)
        {
            SerialNoPublishComment.SendKeys(comment);
            Util.Log("Entered Serial Number Publish Comment: "+comment);
        }

        public void EnterSerialNoEditorComment(string comment)
        {
            SerialNoEditorComment.SendKeys(comment);
            Util.Log("Entered Serial Number Editor Comment: "+comment);
        }

        public void ClickPublishSerialNoInAG()
        {
            PublishSerialNoAG.Click();
            Util.Log("Clicked Publish Serial Number In AG Checkbox.");
        }

        public void ClickPublishSerialNoInOPE()
        {
            PublishSerialNoOPE.Click();
            Util.Log("Clicked Publish Serial Number in OPT Checkbox.");
        }

        public ModelYear ClickInsert()
        {
            Insert.Click();
            Util.Log("Clicked Insert New Model.");
            return new ModelYear(driver);
        }

        public EquipmentModels ClickCancel()
        {
            Cancel.Click();
            Util util = new Util(driver);
            util.DismissAlert();
            Util.Log("Clicked Cancel.");
            return new EquipmentModels(driver);
        }
    }
}