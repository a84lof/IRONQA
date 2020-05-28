namespace IRONQA.GDM.PAGES.MODELMGR
{
    using System.Collections.Generic;
    using System.Threading;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    
    public class EquipmentModels
    {
        private IWebDriver driver;
        public EquipmentModels(IWebDriver _driver) => driver = _driver;

        private IWebElement HeaderType => driver.FindElement(By.Id("TypeCB_Input"));
        private IWebElement HeaderMake => driver.FindElement(By.Id("MakeCB_Input"));
        private IWebElement HeaderModel => driver.FindElement(By.Id("ModelCB_Input"));
        private IWebElement ModelMenu => driver.FindElement(By.Id("HeaderLinkArea_lnkMainMenu_input"));
        private IWebElement Exit => driver.FindElement(By.Id("HeaderLinkArea_lnkLogout_input"));
        private IWebElement AddNew => driver.FindElement(By.Id("AddTypeMakeModel"));
        private IWebElement Model => driver.FindElement(By.Id("CurrentProductEditor_Model"));
        private IWebElement PrintModel => driver.FindElement(By.Id("CurrentProductEditor_PrintModel"));
        private IWebElement EqtClass => driver.FindElement(By.Id("CurrentProductEditor_EqtClassCB_Input"));
        private IWebElement ModelSort => driver.FindElement(By.Id("CurrentProductEditor_ModelSort"));
        private IWebElement FullMake => driver.FindElement(By.Id("CurrentProductEditor_FullMake_Input"));
        private IWebElement CurrentMfr => driver.FindElement(By.Id("CurrentProductEditor_CurrentMfr_Input"));
        private IWebElement ModelKey => driver.FindElement(By.Id("CurrentProductEditor_ModelKey"));
        private IWebElement Save => driver.FindElement(By.Id("CurrentProductEditor_btnUpdate_input"));
        private IWebElement Delete => driver.FindElement(By.Id("CurrentProductEditor_Delete_input"));
        private IWebElement Cancel => driver.FindElement(By.Id("CurrentProductEditor_btnCancel_input"));
        private IWebElement USDepr => driver.FindElement(By.Id("CurrentProductEditor_DeprUs"));
        private IWebElement CanDepr => driver.FindElement(By.Id("CurrentProductEditor_DeprCan"));
        private IWebElement USStartYear => driver.FindElement(By.Id("CurrentProductEditor_StartUs"));
        private IWebElement USEndYear => driver.FindElement(By.Id("CurrentProductEditor_EndUs"));
        private IWebElement CanStartYear => driver.FindElement(By.Id("CurrentProductEditor_StartCan"));
        private IWebElement CanEndYear => driver.FindElement(By.Id("CurrentProductEditor_EndCan"));
        private IWebElement Replaces => driver.FindElement(By.Id("CurrentProductEditor_Replaces"));
        private IWebElement AddReplacedBy => driver.FindElement(By.Id("CurrentProductEditor_SelectTypeMakeModel_input"));
        private IWebElement Clear => driver.FindElement(By.Id("CurrentProductEditor_ClearTypeMakeModel_input"));
        private IWebElement ReplacedBy => driver.FindElement(By.Id("CurrentProductEditor_ReplacedBy"));
        private IWebElement ModelFamily => driver.FindElement(By.Id("CurrentProductEditor_ModelFamily_Input"));
        private IWebElement BaseModelOF => driver.FindElement(By.Id("CurrentProductEditor_BaseModelOfVG"));
        private IWebElement PublishComment => driver.FindElement(By.Id("CurrentProductEditor_PublishComment"));
        private IWebElement EditorComment => driver.FindElement(By.Id("CurrentProductEditor_EditorComment"));
        private IWebElement Location => driver.FindElement(By.Id("CurrentProductEditor_SN_Location"));
        private IWebElement PublishSerialNoInAG => driver.FindElement(By.Id("CurrentProductEditor_SN_AG")) ;
        private IWebElement PublishSerialNoInOPE => driver.FindElement(By.Id("CurrentProductEditor_SN_OPE"));
        private IWebElement PublishSerialNoInCE => driver.FindElement(By.Id("CurrentProductEditor_SN_CE"));
        private IWebElement SNPublishComment => driver.FindElement(By.Id("CurrentProductEditor_SN_PublishComments"));
        private IWebElement SNEditorComment => driver.FindElement(By.Id("CurrentProductEditor_SN_EditorComments"));
        private IWebElement YearTab => driver.FindElement(By.XPath("//*[@id='CurrentProductEditor_RadTabStrip1']/div/ul/li[1]/a/span/span"));
        private IWebElement NebraskaTests => driver.FindElement(By.XPath("//*[@id='CurrentProductEditor_RadTabStrip1']/div/ul/li[2]/a/span"));
        private IWebElement SerialNoTab => driver.FindElement(By.XPath("//*[@id='CurrentProductEditor_RadTabStrip1']/div/ul/li[3]/a/span/span/span"));
        private IWebElement AddNewYear => driver.FindElement(By.Id("CurrentProductEditor_ProductYearList_YearGrid_ctl00_ctl02_ctl00_ExportToCsvButton"));
        private IWebElement NoteTextBox => driver.FindElement(By.Id("NoteTextBox"));
        private IWebElement SaveNotes => driver.FindElement(By.Id("Submit"));
        private IWebElement CancelNotes => driver.FindElement(By.Id("Cancel"));

        public void ConfirmOnEquipmentModelsPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","AddTypeMakeModel");
            Thread.Sleep(500);
            Util.Log("On Manage Models");
        }

        public void EnterHeaderType(string type)
        {
            HeaderType.SendKeys(type);
            HeaderType.SendKeys(Keys.Tab);
            Util.Log("Entered Type: "+type);
        }

        public void EnterHeaderMake(string make)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//body/div[1][not(contains(@id,'SmallPanelTypeCB'))]");
            Thread.Sleep(1000);
            HeaderMake.SendKeys(make);
            HeaderMake.SendKeys(Keys.Tab);
            Util.Log("Entered Make: "+make);
        }

        public void EnterHeaderModel(string model)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//body/div[1][not(contains(@id,'SmallPanelModelCB'))]");
            Thread.Sleep(1000);
            HeaderModel.SendKeys(model);
            HeaderModel.SendKeys(Keys.Tab);
            Util.Log("Entered Model: "+ model);
        }

        public NewModel ClickAdd()
        {
            AddNew.Click();
            Util.Log("Clicked Add Button.");
            return new NewModel(driver);
        }

        public void ExpandType(string type)
        {// Case sensitive.
            IWebElement element = driver.FindElement(By.XPath("//td[@id='treePane']//tbody/tr//td[contains(text(),'"+type+"')]/../td"));
            element.Click();
            Util.Log("Expanded Type: "+type);
        }

        public void ExpandMake(string make)
        {// Case sensitive
            Util util = new Util(driver);
            util.WaitForElement("XPath","//td[contains(text(),'"+make+"')]/../td[2]");
            IWebElement element = driver.FindElement(By.XPath("//td[contains(text(),'"+make+"')]/../td[2]"));
            element.Click();
            Util.Log("Expanded Make: "+make);
        }

        public NewModel ClickMakePlus(string make)
        {
            IWebElement element = driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'"+make+"')]/../td/span[@title='Add']"));
            element.Click();
            Util.Log("Clicked Make Plus.");
            return new NewModel(driver);
        }

        public void EditModel(string make, string model)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//td[contains(text(),'"+make+"')]/../../tr/td[contains(text(),'"+model+"')]/../td/span/..");
            IWebElement element = driver.FindElement(By.XPath("//td[contains(text(),'"+make+"')]/../../tr/td[contains(text(),'"+model+"')]/../td/span/.."));
            element.Click();
            Util.Log("Clicked Edit Pencil For "+model);
        }

        public void ConfirmAllModelYearsDisplayed()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//div/h1[contains(text(),'Editing')]");
            Util.Log("All Model Years Displayed.");
        }

        public ModelYear SelectModelYearOptions(string year)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='CurrentProductEditor_ProductYearList_YearGrid_ctl00__0']/td[contains(text(),'"+year+"')]/../td[4]/a"));
            element.Click();
            return new ModelYear(driver);
        }

        public ModelYear SelectModelYearStdFeatures(string year)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='CurrentProductEditor_ProductYearList_YearGrid_ctl00__0']/td[contains(text(),'"+year+"')]/../td[5]/a"));
            element.Click();
            return new ModelYear(driver);
        }

        public void DeleteModelYear(string year)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[@id='CurrentProductEditor_ProductYearList_YearGrid_ctl00__0']/../tr/td[contains(text(),'"+year+"')]/../td[17]");
            IWebElement element = driver.FindElement(By.XPath("//*[@id='CurrentProductEditor_ProductYearList_YearGrid_ctl00__0']/../tr/td[contains(text(),'"+year+"')]/../td[17]"));
            element.Click();
            util.DismissAlert();
            Util.Log("Deleted Model Year: "+year);
        }

        public void DeleteLatestModelYear()
        {// finds the latest ModelYear and passes it to DeleteModelYear()
            IList<IWebElement> list = driver.FindElements(By.XPath("//tr[contains(@id,'ProductYearList')]/td[3]"));
            string latest = list[list.Count-1].Text;
            DeleteModelYear(latest);
        }

        public ModelYear ClickAddNewYear()
        {
            AddNewYear.Click();
            Util.Log("Clicked Add New Year.");
            return new ModelYear(driver);
        }

        public void ClickNewPriceNotesUS(string year)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[@id='CurrentProductEditor_ProductYearList_YearGrid_ctl00__0']/td[contains(text(),'"+year+"')]/../td/img[contains(@data-id,'notes-NewPriceNotesUS')]");
            IWebElement element = driver.FindElement(By.XPath("//*[@id='CurrentProductEditor_ProductYearList_YearGrid_ctl00__0']/td[contains(text(),'"+year+"')]/../td/img[contains(@data-id,'notes-NewPriceNotesUS')]"));
            element.Click();
            Util.Log("Clicked New Price Notes US.");
            util.SwitchToFrame();
        }

        public void ClickNewPriceNotesCA(string year)
        {
            Util util = new Util(driver);
             util.WaitForElement("XPath","//*[@id='CurrentProductEditor_ProductYearList_YearGrid_ctl00__0']/td[contains(text(),'"+year+"')]/../td/img[contains(@data-id,'notes-NewPriceNotesCA')]");
            IWebElement element = driver.FindElement(By.XPath("//*[@id='CurrentProductEditor_ProductYearList_YearGrid_ctl00__0']/td[contains(text(),'"+year+"')]/../td/img[contains(@data-id,'notes-NewPriceNotesCA')]"));
            element.Click();
            Util.Log("Clicked New Price Notes CA.");
            util.SwitchToFrame();
        }

        public void ClickStdSpecNotes(string year)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[@id='CurrentProductEditor_ProductYearList_YearGrid_ctl00__0']/td[contains(text(),'"+year+"')]/../td[14]/img[2]");
            IWebElement element = driver.FindElement(By.XPath("//*[@id='CurrentProductEditor_ProductYearList_YearGrid_ctl00__0']/td[contains(text(),'"+year+"')]/../td/img[contains(@data-id,'notes-StandardModelNotes')]"));
            element.Click();
            Util.Log("Clicked Std Spec Notes.");
            util.SwitchToFrame();
        }

        public void ClearNotes()
        {
            // wait for the box to open
            Util util = new Util(driver);
            util.WaitForElement("Id","NoteTextBox");
            // delete its contents
            IWebElement element = driver.FindElement(By.Id("NoteTextBox"));
            int count = element.Text.Length;
            for (int i=0; i<count; i++)
            {
                element.SendKeys(Keys.Backspace);
            }
            Util.Log("Cleared Notes.");
        }

        public void EnterNotes(string notes)
        {
            NoteTextBox.SendKeys(notes);
            Util.Log("Entered Notes: "+notes);
        }

        public void ClickSaveNotes()
        {
            SaveNotes.Click();
            driver.SwitchTo().DefaultContent();
            Util.Log("Clicked Save Notes.");
        }

        public void ClickCancelNotes()
        {
            CancelNotes.Click();
            driver.SwitchTo().DefaultContent();
            Util.Log("Clicked Cancel Notes.");
        }

        public void ConfirmPriceNotes(string notes)
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","NoteTextBox");
            Util.Log(NoteTextBox.Text);
            Assert.IsTrue(NoteTextBox.Text.Contains(notes));
            Util.Log("Confirmed Price Notes.");
        }
    }
}