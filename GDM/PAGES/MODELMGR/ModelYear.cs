namespace IRONQA.GDM.PAGES.MODELMGR
{
    using System.Collections.Generic;
    using System.Threading;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;

    public class ModelYear
    {
        private IWebDriver driver;
        public ModelYear(IWebDriver _driver) => driver = _driver;

        private IWebElement Year => driver.FindElement(By.Id("YearEditor1_Year"));
        private IWebElement USNewPrice => driver.FindElement(By.Id("YearEditor1_NewPriceUS"));
        private IWebElement USPriceNotes => driver.FindElement(By.Id("YearEditor1_NewPriceNotesUS"));
        private IWebElement CanNewPrice => driver.FindElement(By.Id("YearEditor1_NewPriceCAN"));
        private IWebElement StandardSpecChange => driver.FindElement(By.Id("YearEditor1_StandardModel"));
        private IWebElement CanPriceNotes => driver.FindElement(By.Id("YearEditor1_NewPriceNotesCAN"));
        private IWebElement Save => driver.FindElement(By.Id("YearEditor1_btnUpdate_input"));
        private IWebElement GoBack => driver.FindElement(By.Id("YearEditor1_btnCancel_input"));
        private IWebElement USMSRP => driver.FindElement(By.Id("YearEditor1_MSRPPriceUS"));
        private IWebElement CanMSRP => driver.FindElement(By.Id("YearEditor1_MSRPPriceCAN"));
        private IWebElement StandardSpecChangeNotes => driver.FindElement(By.Id("YearEditor1_StandardModelNotes"));
        private IWebElement Complete => driver.FindElement(By.Id("YearEditor1_CompleteFlag"));
        private IWebElement StandardFeatures => driver.FindElement(By.XPath("//div[@id='RadTabStrip1']/div/ul/li/a/span/span/span[contains(text(),'Standard')]"));
        private IWebElement Options => driver.FindElement(By.XPath("//div[@id='RadTabStrip1']/div/ul/li/a/span/span/span[contains(text(),'Options')]"));
        private IWebElement ExpandAll => driver.FindElement(By.Id("Options_userControl_ExpColPanel"));
        private IWebElement CloneOptions => driver.FindElement(By.Id("Options_userControl_CloneButton_input"));
        private IWebElement AddNewOption => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl00_AddNewRecordButton"));
        private IWebElement OptionDescription => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl03_EditFormControl_OptionDescription_Input"));
        private IWebElement OEMCode => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl03_EditFormControl_OEMCode"));
        private IWebElement OptionCode => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl03_EditFormControl_OptionCode"));
        private IWebElement PrintDescription => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl03_EditFormControl_OptionPrintDescription"));
        private IWebElement NewOptionNotes => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl03_EditFormControl_Notes"));
        private IWebElement Description => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl03_EditFormControl_GroupDescriptionDropDown_Input"));
        private IWebElement SortOrder => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl03_EditFormControl_GroupDescriptionSortOrder"));
        private IWebElement InsertOption => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl03_EditFormControl_btnInsert"));
        private IWebElement CancelOption => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl03_EditFormControl_btnCancel_ClientState"));
        private IWebElement OPEOrder => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl03_EditFormControl_OPE"));
        private IWebElement RegionOrder => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl03_EditFormControl_Regional"));
        private IWebElement FarmOrder => driver.FindElement(By.Id("Options_userControl_OptionsGrid_ctl00_ctl02_ctl03_EditFormControl_Farm"));
        private IWebElement Note => driver.FindElement(By.Id("NoteTextBox"));
        private IWebElement SaveNote => driver.FindElement(By.Id("Submit"));
        private IWebElement CancelNote => driver.FindElement(By.Id("Cancel"));
        private IWebElement InsertModelYear => driver.FindElement(By.Id("YearEditor1_btnInsert_input"));

        public void ConfirmModelYearPage()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","YearEditor1_Year");
            Util.Log("On Model Year Page.");
        }

        public void ConfirmStandardFeaturesDisplayed()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","Standard Features_userControl_FeaturesList_ctl00");
        }

        public void ConfirmOptionsDisplayed()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//td/a[contains(text(),'Add new option')]");
        }

        public void EnterYear(string year)
        {
            Year.SendKeys(year);
            Util.Log("Entered Year: "+year);
        }

        public void EnterUSNewPrice(string price)
        {
            USNewPrice.SendKeys(price);
            Util.Log("Entered US New Price: "+price);
        }

        public void EnterUSPriceNotes(string notes)
        {
            USPriceNotes.SendKeys(notes);
            Util.Log("Entered US Price Notes: "+notes);
        }

        public void EnterCanNewPrice(string price)
        {
            CanNewPrice.SendKeys(price);
            Util.Log("Entered Canadian New Price: "+price);
        }

        public void EnterCanPriceNotes(string notes)
        {
            CanPriceNotes.SendKeys(notes);
            Util.Log("Entered Canadian Price Notes: "+notes);
        }

        public void EntereUSMSRP(string msrp)
        {
            USMSRP.SendKeys(msrp);
            Util.Log("Entered US MSRP: "+msrp);
        }

        public void EnterCanMSRP(string msrp)
        {
            CanMSRP.SendKeys(msrp);
            Util.Log("Entered Canadian MSRP: "+msrp);
        }

        public void ClickStandardSpecChange()
        {
            StandardSpecChange.Click();
            Util.Log("Clicked Standard Spec Change Checkbox.");
        }

        public void EnterStandardSpecChangeNotes(string notes)
        {
            StandardSpecChangeNotes.SendKeys(notes);
            Util.Log("Entered Standard Spec Change Notes: "+notes);
        }

        public void ClickPublishInIronGuides(string industry, string region)
        {
            // ex. ClickPublishInIronGuides("OP","O");
            // ex. ClickPublishInIronGuides("AG","E");
            IWebElement element = driver.FindElement(By.XPath("//div/h2[contains(text(),'Publish')]/..//td/input[@value='"+industry+"']/../../td[2]//td/label[contains(text(),'"+region+"')]/../input"));
            element.Click();
            Util.Log("Clicked Publish In IronGuides Checkbox For "+industry+" Region "+region);
        }

        public void ClickPrintInRegion(string industry, string region)
        {
            // ex. ClickPrintInRegion("OP","O");
            // ex. ClickPrintInRegion("AG","E");
            IWebElement element = driver.FindElement(By.XPath("//div/h2[contains(text(),'Print')]/..//td/input[@value='"+industry+"']/../../td[2]//td/label[contains(text(),'"+region+"')]/../input"));
            element.Click();
            Util.Log("Clicked Print In Region Checkbox For "+industry+" Region "+region);
        }

        public void ClickComplete()
        {
            Complete.Click();
            Util.Log("Clicked Complete Checkbox.");
        }

        public EquipmentModels ClickSave()
        {
            Save.Click();
            Util.Log("Clicked Save.");
            return new EquipmentModels(driver);
        }

        public void ClickAddNewOption()
        {
            WaitForLoading();
            AddNewOption.Click();
            Util.Log("Clicked Add New Option.");
        }

        public void EnterOptionDescription(string description)
        {
            WaitForLoading();
            OptionDescription.SendKeys(description);
            OptionDescription.SendKeys(Keys.Tab);
            Util.Log("Entered Option Description: "+description);
        }

        public void ClickInsertOption()
        {
            WaitForLoading();
            InsertOption.Click();
            Util.Log("Clicked Insert Option.");
        }

        public void ConfirmOptionDisplayed(string description)
        {
            WaitForLoading();
            IWebElement element = driver.FindElement(By.XPath("//tbody//tr/td[contains(text(),'"+description+"')]"));
        }

        public void ExpandOption(string description)
        {
            // ex. ExpandOption("Test");
            IWebElement element = driver.FindElement(By.XPath("//tbody//tr/td[contains(text(),'"+description+"')]/../td/input"));
            element.Click();
            Util.Log("Expanded Option With Description: "+description);
        }

        public void ClickEditOption(string description)
        {
            WaitForLoading();
            IWebElement element = driver.FindElement(By.XPath("//tbody//tr/td[contains(text(),'"+description+"')]/../td/a[contains(text(),'Edit')]"));
            element.Click();
            Util.Log("Clicked Edit For Option With Description: "+description);
        }

        public void EditOEMCode(string code)
        {
            // ex. EditOEMCode("Long Stick","1234");
            WaitForLoading();
            IWebElement element = driver.FindElement(By.XPath("//td/span/input[contains(@id,'OEM')]"));
            int count = element.GetAttribute("value").Length;
            for (int i=0; i<count; i++)
            {
                element.SendKeys(Keys.Delete);
            }
            element.SendKeys(code);
            Util.Log("Entered OEM Code: "+code);
        }

        public void ConfirmOptionOEM(string code)
        {
            WaitForLoading();
            IWebElement element = driver.FindElement(By.XPath("//tr/td[contains(text(),'"+code+"')]/../td[5]"));
            Assert.IsTrue(element.Text.Contains(code));
        }

        public void EditOptionDescription(string descriptionNew)
        {
            WaitForLoading();
            IWebElement element = driver.FindElement(By.XPath("//tr/td/span/input[contains(@id,'OptionDescription')]"));
            int count = element.GetAttribute("value").Length;
            for (int i=0; i<count; i++)
            {
                element.SendKeys(Keys.Backspace);
            }
            element.SendKeys(descriptionNew);
            Util.Log("Entered Option Description: "+descriptionNew);
        }

        public void EditPrintDescription(string descriptionNew)
        {
            WaitForLoading();
            IWebElement element = driver.FindElement(By.XPath("//td/span/input[contains(@id,'PrintDescription')]"));
            int count = element.GetAttribute("value").Length;
            for (int i=0; i<count; i++)
            {
                element.SendKeys(Keys.Backspace);
            }
            element.SendKeys(descriptionNew);
            Util.Log("Entered Print Description: "+descriptionNew);
        }

        public void ConfirmLinkedtoPicklist(string description, string TF)
        {
            IWebElement element = driver.FindElement(By.XPath("//tr/td[contains(text(),'"+description+"')]/../td[8]"));
            Assert.IsTrue(element.Text.Contains(TF));
        }

        public void ClickSaveOption()
        {
            // ex. SaveOption("LongStick");
            IWebElement element = driver.FindElement(By.XPath("//tr/td/a[contains(text(),'Save')]"));
            element.Click();
            Util.Log("Clicked Save Option.");
        }

        public void ClickCancelOption()
        {
            // ex. CancelOption("LongStick");
            IWebElement element = driver.FindElement(By.XPath("//tr/td/a[contains(text(),'Cancel')]"));
            element.Click();
            WaitForLoading();
            Util.Log("Clicked Cancel Option.");
        }

        public void EditOptionOPEOrder(string description, string order)
        {
            IWebElement element = driver.FindElement(By.XPath("//tbody//tr/td[contains(text(),'"+description+"')]/../td/span[contains(@id,'OPE')]/input"));
            element.SendKeys(order);
            Util.Log("Entered OPE Order: "+order);
        }

        public void EditOptionFarmOrder(string description, string order)
        {
            IWebElement element = driver.FindElement(By.XPath("//tbody//tr/td[contains(text(),'"+description+"')]/../td/span[contains(@id,'Farm')]/input"));
            element.SendKeys(order);
            Util.Log("Entered Farm Order: "+order);
        }

        public void EditOptionRegionOrder(string description, string order)
        {
            IWebElement element = driver.FindElement(By.XPath("//tbody//tr/td[contains(text(),'"+description+"')]/../td/span[contains(@id,'Region')]/input"));
            element.SendKeys(order);
            Util.Log("Entered Region Order: "+order);
        }

        public void ClickEditNotes(string description, string note)
        {
            IWebElement element = driver.FindElement(By.XPath("//tbody//tr/td[contains(text(),'"+description+"')]/../td/img[2]"));
            element.Click();
            Util.Log("Opened Option Note Editor.");
        }

        public void EnterOptionNotes(string note)
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","NoteTextBox");
            Note.SendKeys(note);
            Util.Log("Entered Note: "+note);
        }

        public void SaveAndCloseNote()
        {
            SaveNote.Click();
            Util.Log("Clicked Save Note.");
        }

        public void CancelAndCloseNote()
        {
            CancelNote.Click();
            Util.Log("Clicked Cancel Note.");
        }

        public void DeleteOption(string description)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//tbody//tr/td[contains(text(),'"+description+"')]/../td/input[@title='Delete']");
            IWebElement element = driver.FindElement(By.XPath("//tbody//tr/td[contains(text(),'"+description+"')]/../td/input[@title='Delete']"));
            element.Click();
            util.DismissAlert();
            util.WaitForElement("Id","YearEditor1_Year");
            Util.Log("Deleted Option: "+description);
        }

        public void ConfirmOptionDeleted(string description)
        {
            IList<IWebElement> list = driver.FindElements(By.XPath("//tr[contains(@id,'ProductYearList')]/td[3]"));
            foreach (IWebElement e in list)
            {
                string text = e.Text;
                if (text == description)
                {
                    Assert.Fail();
                    Util.Log("Option Not Deleted.");
                }
            }
            Util.Log("Confirmed Option Deleted.");
        }

        public void ClickInsert()
        {
            Util util = new Util(driver);
            util.WaitForElement("Id","YearEditor1_btnInsert_input");
            InsertModelYear.Click();
        }

        private IWebDriver WaitForLoading()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//body/div[1][not(contains(@id,'LargePanelOptions_userControl_OptionsGrid'))]");
            return driver;
        }
    }
}