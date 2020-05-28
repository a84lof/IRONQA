namespace IRONQA.GUIDES.PAGES.DASHBOARD
{
    using IRONQA.GUIDES.PAGES.APPRAISAL;
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class SavedAppraisals
    {
        private IWebDriver driver;
        public SavedAppraisals(IWebDriver _driver) => driver = _driver;
        private IWebElement SortBy => driver.FindElement(By.Id("appraisal-sort-select"));
        private IWebElement AppraisalTitle => driver.FindElement(By.CssSelector("#my-appraisal-list-ul > li > div.line-item > span.appraisal-title"));
        private IWebElement Date1 => driver.FindElement(By.XPath("//*[@id='my-appraisal-list-ul']/li[1]/div[1]/div[2]/span[1]"));
        private IWebElement Customer1 => driver.FindElement(By.CssSelector("#my-appraisal-list-ul > li:nth-child(1) > div.sub-line-item > span:nth-child(8)"));
        private IWebElement Creator1 => driver.FindElement(By.CssSelector("#my-appraisal-list-ul > li:nth-child(1) > div.sub-line-item > span:nth-child(6)"));
        private IWebElement FilterModel => driver.FindElement(By.CssSelector("#model_filter_chosen > ul > li > input"));
        private IWebElement FilterModelChoice => driver.FindElement(By.CssSelector("#model_filter_chosen > ul > li.search-choice > span"));
        private IWebElement FilterCustomer => driver.FindElement(By.CssSelector("#customer_filter_chosen > ul > li > input"));
        private IWebElement FilterCustomerChoice => driver.FindElement(By.CssSelector("#customer_filter_chosen > ul > li.search-choice > span"));
        private IWebElement FilterCreator => driver.FindElement(By.CssSelector("#creator_filter_chosen > ul > li > input"));
        private IWebElement FilterCreatorChoice => driver.FindElement(By.CssSelector("#creator_filter_chosen > ul > li.search-choice > span"));
        private IWebElement SerialNumber => driver.FindElement(By.CssSelector("ul#my-appraisal-list-ul li div.line-item span.appraisal-serial-number-value"));
        private IWebElement EditUpdateProPencil => driver.FindElement(By.XPath("//*[contains(@class,'button--update-edit-appraisal') and (contains(@onclick,'cloneOrEditAppraisalModal'))]"));
        private IWebElement EditUpdatePlusPencil => driver.FindElement(By.XPath("//*[contains(@class,'button--update-edit-appraisal') and (contains(@onclick,'cloneOrEditAppraisalModal'))]"));
        private IWebElement UpdateOnlyProPencil => driver.FindElement(By.Id("plusProCloneWithEditDisabledAppraisalButton"));
        private IWebElement UpdateOnlyPlusPencil => driver.FindElement(By.Id("plusProCloneWithEditDisabledAppraisalButton"));
        private IWebElement UpdateBasicPencil => driver.FindElement(By.XPath("//*[contains(@class,'button--update-edit-appraisal') and (contains(@onclick,'cloneAppraisalOnlyModal'))]"));
        private IWebElement EditPlusProAppraisal => driver.FindElement(By.XPath("//div[contains(@id,'cloneOrEditAppraisalModal')]//div/a[contains(@id,'plusProEditAppraisalButton')]"));
        private IWebElement UpdatePlusProAppraisal => driver.FindElement(By.XPath("//div[contains(@id,'cloneOrEditAppraisalModal')]//div/a[contains(@id,'plusProCloneAppraisalButton')]"));
        private IWebElement UpdateOnlyProAppraisal => driver.FindElement(By.Id("plusProCloneWithEditDisabledAppraisalButton"));
        private IWebElement UpdateOnlyPlusAppraisal => driver.FindElement(By.Id("plusProCloneWithEditDisabledAppraisalButton"));
        private IWebElement UpdateBasicAppraisal => driver.FindElement(By.Id("basicCloneAppraisalButton"));
        private IWebElement FilterAppraisalID => driver.FindElement(By.CssSelector("#saved_appraisal_appraisal_id_filter_chosen > ul > li > input"));
        private IWebElement AppraisalLabel => driver.FindElement(By.XPath("//*[contains(@class,'type-make-model-year')]"));
        private IWebElement FilteredAppraisal => driver.FindElement(By.XPath("//*[@id='my-appraisal-list-ul']/li/div[1]/div[1]/span[3]"));
        private IWebElement AppraisalSerials => driver.FindElement(By.XPath("//*[contains(@id,'my-appraisal-list-ul')]//*[contains(@class,'serial-number')]"));
        private IWebElement AppraisalModels => driver.FindElement(By.XPath("//*[contains(@id,'my-appraisal-list-ul')]//*[contains(@class,'model')]/span[contains(@class,'model')]"));
        private IWebElement ModelFilterClear => driver.FindElement(By.Id("model-clear-button"));
        private IWebElement AppraisalIds => driver.FindElement(By.XPath("//*[contains(@id,'my-appraisal-list-ul')]//*[contains(@class,'secondary')]/span[contains(@class,'appraisal-ID')]"));
        private IWebElement AppraisalIdFilterClear => driver.FindElement(By.Id("saved-appraisal-appraisal-id-clear-button"));
        private IWebElement AppraisalCreators => driver.FindElement(By.XPath("//*[contains(@id,'my-appraisal-list-ul')]//*[contains(@class,'secondary')]/span[contains(@class,'creator')]/strong"));
        private IWebElement CreatorFilterClear => driver.FindElement(By.Id("creator-clear-button"));
        private IWebElement AppraisalCustomers => driver.FindElement(By.XPath("//*[contains(@id,'my-appraisal-list-ul')]//*[contains(@class,'secondary')]/span[contains(@class,'customer')]/strong"));
        private IWebElement CustomerFilterClear => driver.FindElement(By.Id("customer-clear-button"));
        
        public void AppraisalSortBy(string sort)
        {
            Util util = new Util(driver);
            SortBy.SendKeys(sort);
            util.WaitForElement("XPath","//div[@id='savedAppraisalsLoadingIndicator']/em[contains(@id,'loading-spinner') and not(contains(@style,'display: inline-block'))]");
            Thread.Sleep(3000);
            Util.Log("Sort By Complete");
        }

        public void ConfirmAppraisalDisplayed(string searchFor, string value)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//div[@id='savedAppraisalsLoadingIndicator']/em[contains(@id,'loading-spinner') and not(contains(@style,'display: inline-block'))]");
            Thread.Sleep(3000);
            switch (searchFor)
            {
                case "AppraisalId":
                    try{
                        Assert.IsTrue(AppraisalIds.Text.Contains(value));
                    } catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
                break;
                case "Creator":
                    try{    
                        Assert.IsTrue(AppraisalCreators.Text.Contains(value));
                        Util.Log("Filtered By Creator.");
                    } catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
                break;
                case "Customer":
                    try{
                        Assert.IsTrue(AppraisalCustomers.Text.Contains(value));
                        Util.Log("Filtered By Customer.");
                    } catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
                break;
                case "Model":
                    try{
                        Assert.IsTrue(AppraisalModels.Text.Contains(value));
                        Util.Log("Filtered By Model.");
                    } catch (Exception ex) { Util.Log(Util.Fail() + "\r\n" + ex); }
                break;
            }
        }

        public void CompareDates(string date1, string date2)
        {
            try{
                Assert.IsTrue(DateTime.Parse(date1) <= DateTime.Parse(date2));
                Util.Log("Date 1 < Date 2, As Expected");
            }
            catch (Exception ex) 
            { Util.Log(Util.Fail() + "\r\n" + ex); }
        }

        public void FilterByModel(string model)
        {
            FilterModel.Click();
            FilterModel.SendKeys(model);
            FilterModel.SendKeys(Keys.Enter);
        }

        public void FilterByCustomer(string customer)
        {
            FilterCustomer.Click();
            FilterCustomer.SendKeys(customer);
            FilterCustomer.SendKeys(Keys.Enter);
        }

        public void FilterByCreator(string creator)
        {
            FilterCreator.Click();
            FilterCreator.SendKeys(creator);
            FilterCreator.SendKeys(Keys.Enter);
        }

        public void ClearModelsFilter()
        {
            ModelFilterClear.Click();
            Thread.Sleep(500);
            Util.Log("Cleared Models");
        }

        public void ClearAppraisalIdFilter()
        {
            AppraisalIdFilterClear.Click();
            Thread.Sleep(500);
            Util.Log("Cleared Appraisal Ids");
        }

        public void ClearCreatorsFilter()
        {
            CreatorFilterClear.Click();
            Thread.Sleep(500);
            Util.Log("Cleared Creators");
        }

        public void ClearCustomersFilter()
        {
            CustomerFilterClear.Click();
            Thread.Sleep(500);
            Util.Log("Cleared Creators");
        }


        public string GetAppraisalDate()
        {
            string[] dateArray = Date1.Text.Split(":");
            string date = dateArray[1].Substring(0, dateArray[1].Length - 3).Trim();
            return date;
        }

        public void ClickProAppraisalPencil()
        {
            EditUpdateProPencil.Click();
            Util.Log("Clicked First Updateable/Editable Appraisal.");
        }

        public void ClickPlusAppraisalPencil()
        {
            EditUpdatePlusPencil.Click();
            Util.Log("Clicked First Updateable/Editable Appraisal.");
        }

        public void ClickBasicAppraisalPencil()
        {
            UpdateBasicPencil.Click();
            Util.Log("Clicked First Updateable/Editable Appraisal.");
        }

        public Step2 ClickProUpdateAppraisal()
        {
            UpdatePlusProAppraisal.Click();
            Util.Log("Clicked Update Appraisal Button");
            Util util = new Util(driver);
            util.SwitchToNewTab();
            return new Step2(driver);
        }

        public Step2 ClickPlusUpdateAppraisal()
        {
            UpdatePlusProAppraisal.Click();
            Util.Log("Clicked Update Appraisal Button");
            Util util = new Util(driver);
            util.SwitchToNewTab();
            return new Step2(driver);
        }

        public Step2 ClickBasicUpdateAppraisal()
        {
            Util util = new Util(driver);
            util.ClickToNewTab(UpdateBasicAppraisal);
            Util.Log("Clicked Update Appraisal Button");
            return new Step2(driver);
        }

        public Step2 ClickEditProAppraisal()
        {
            EditPlusProAppraisal.Click();
            Util.Log("Clicked Edit Appraisal.");
            Util util = new Util(driver);
            util.SwitchToNewTab();
            return new Step2(driver);
        }

        public Step2 ClickEditPlusAppraisal()
        {
            EditPlusProAppraisal.Click();
            Util.Log("Clicked Edit Appraisal.");
            Util util = new Util(driver);
            util.SwitchToNewTab();
            return new Step2(driver);
        }
    }
}