namespace IRONQA.GDM.PAGES.REPORTMGR
{
    using IRONQA.UTILITIES;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Threading;

    public class ReportGrid
    {
        private IWebDriver driver;
        public ReportGrid(IWebDriver _driver) => driver = _driver;
        private IWebElement ToggleFilters => driver.FindElement(By.CssSelector("#Reportmanager > div.row.sold-report-filters-row-wrapper > div > div > h5"));
        private IWebElement ReportIdSearch => driver.FindElement(By.Id("report-id-filter"));
        private IWebElement ClearAllFilters => driver.FindElement(By.Id("lnk-clear-all-filters"));
        private IWebElement ShowApproved => driver.FindElement(By.Id("filter-ShowApprovedReports"));
        private IWebElement ShowUnapproved => driver.FindElement(By.Id("filter-ShowUnApprovedReports"));
        private IWebElement ShowOnHold => driver.FindElement(By.Id("filter-ShowOnHoldReports"));
        private IWebElement ShowRejected => driver.FindElement(By.Id("filter-ShowRejectedReports"));
        private IWebElement ShowDuplicates => driver.FindElement(By.Id("filter-ShowDuplicates"));
        private IWebElement StartDate => driver.FindElement(By.Id("start-date-filter"));
        private IWebElement EndDate => driver.FindElement(By.Id("end-date-filter"));
        private IWebElement EnteredBy => driver.FindElement(By.XPath("//label[contains(text(),'Entered By')]/..//div[@class='Select-placeholder']"));
        private IWebElement EnteredByInput => driver.FindElement(By.XPath("//label[contains(text(),'Entered By')]/..//div[@class='Select-input']/input"));
        private IWebElement ApprovedBy => driver.FindElement(By.XPath("//label[contains(text(),'Approved By')]/..//div[@class='Select-placeholder']"));
        private IWebElement ApprovedByInput => driver.FindElement(By.XPath("//label[contains(text(),'Approved By')]/..//div[@class='Select-input']"));
        private IWebElement ReportSource => driver.FindElement(By.XPath("//label[contains(text(),'Report Source')]/..//div[@class='Select-placeholder']"));
        private IWebElement ReportSourceInput => driver.FindElement(By.XPath("//label[contains(text(),'Report Source')]/..//div[@class='Select-input']"));
        private IWebElement DealershipFilter => driver.FindElement(By.XPath("//label[contains(text(),'Dealership')]/..//div[@class='Select-placeholder']"));
        private IWebElement DealershipInput => driver.FindElement(By.XPath("//label[contains(text(),'Dealership')]/..//div[@class='Select-input']"));
        private IWebElement TypeFilter => driver.FindElement(By.XPath("//label[contains(text(),'Type')]/..//div[@class='Select-placeholder']"));
        private IWebElement TypeInput => driver.FindElement(By.XPath("//label[contains(text(),'Type')]/..//div[@class='Select-input']"));
        private IWebElement MakeFilter => driver.FindElement(By.XPath("//label[contains(text(),'Make')]/..//div[@class='Select-placeholder']"));
        private IWebElement MakeInput => driver.FindElement(By.XPath("//label[contains(text(),'Make')]/..//div[@class='Select-input']"));
        private IWebElement ModelFilter => driver.FindElement(By.XPath("//label[contains(text(),'Model')]/..//div[@class='Select-placeholder']"));
        private IWebElement ModelInput => driver.FindElement(By.XPath("//label[contains(text(),'Model')]/..//div[@class='Select-input']"));
        private IWebElement EstimatedYear => driver.FindElement(By.XPath("//label[contains(text(),'Estimated Year')]/..//div[@class='Select-placeholder']"));
        private IWebElement EstimatedYearInput => driver.FindElement(By.XPath("//label[contains(text(),'Estimated Year')]/..//div[@class='Select-input']"));
        private IWebElement RegionFilter => driver.FindElement(By.XPath("//label[contains(text(),'Region')]/..//div[@class='Select-placeholder']"));
        private IWebElement RegionInput => driver.FindElement(By.XPath("//label[contains(text(),'Region')]/..//div[@class='Select-input']"));
        private IWebElement GuideIssue => driver.FindElement(By.XPath("//label[contains(text(),'Guide Issue')]/..//div[@class='Select-placeholder']"));
        private IWebElement GuideIssueInput => driver.FindElement(By.XPath("//label[contains(text(),'Guide Issue')]/..//div[@class='Select-input']"));
        private IWebElement GuideIndustryFilter => driver.FindElement(By.XPath("//label[contains(text(),'Guide Industry')]/..//div[@class='Select-placeholder']"));
        private IWebElement GuideIndustryInput => driver.FindElement(By.XPath("//label[contains(text(),'Guide Industry')]/..//div[@class='Select-input']"));
        
        
        private IWebElement ToggleColumns => driver.FindElement(By.CssSelector("#Reportmanager > div:nth-child(3) > div > div > div > div > div.kendo-grid-column-menu > div"));
        private IWebElement ColumnMenu => driver.FindElement(By.CssSelector("#Reportmanager > div:nth-child(3) > div > div > div > div > div.kendo-grid-container > div.kendo-grid-column-menu > div"));
        private IWebElement AllColumns => driver.FindElement(By.Id("show-column-all"));
        private IWebElement AGRegion => driver.FindElement(By.Id("chk-show-column-Region"));
        private IWebElement AdjPriceAdvList => driver.FindElement(By.Id("chk-show-column-AdvertisedAdjustedPrice"));
        private IWebElement AdjPriceSoldWhs => driver.FindElement(By.Id("chk-show-column-AdjustedPrice"));
        private IWebElement AvgUsage => driver.FindElement(By.Id("chk-show-column-PublishedAverageMeter"));
        private IWebElement Condition => driver.FindElement(By.Id("chk-show-column-Condition"));
        private IWebElement CustomerType => driver.FindElement(By.Id("chk-show-column-CustomerTypeDescr"));
        private IWebElement DateAdded => driver.FindElement(By.Id("chk-show-column-DateAdded"));
        private IWebElement DateUpdated => driver.FindElement(By.Id("chk-show-column-DateUpdated"));
        private IWebElement DealerReportedYear => driver.FindElement(By.Id("chk-show-column-EstimatedYear"));
        private IWebElement Dealership => driver.FindElement(By.Id("chk-show-column-Dealership"));
        private IWebElement EditorEstimatedYear => driver.FindElement(By.Id("chk-show-column-Dealership"));
        private IWebElement GuideIndustry => driver.FindElement(By.Id("chk-show-column-MatchedGuideIndustry"));
        private IWebElement InvalidMeteres => driver.FindElement(By.Id("chk-show-column-HasInvalidMeters"));
        private IWebElement IssueNameFiltered => driver.FindElement(By.Id("chk-show-column-IssueName"));
        private IWebElement IssueNames => driver.FindElement(By.Id("chk-show-column-GuideIssues"));
        private IWebElement IssuePubDateFiltered => driver.FindElement(By.Id("chk-show-column-IssuePublishedDate"));
        private IWebElement MSRPCurrency => driver.FindElement(By.Id("chk-show-column-MsrpCurrency"));
        private IWebElement Mainline => driver.FindElement(By.Id("chk-show-column-Mainline"));
        private IWebElement Make => driver.FindElement(By.Id("chk-show-column-Make"));
        private IWebElement Model => driver.FindElement(By.Id("chk-show-column-Model"));
        private IWebElement OptionPriceAdvList => driver.FindElement(By.Id("chk-show-column-AdvertisedOptionsPrice"));
        private IWebElement OptionPriceSoldWhs => driver.FindElement(By.Id("chk-show-column-OptionsPrice"));
        private IWebElement PercentVariance => driver.FindElement(By.Id("chk-show-column-VariancePercent"));
        private IWebElement PriceAdvList => driver.FindElement(By.Id(""));
        private IWebElement PriceSoldWhs => driver.FindElement(By.Id(""));
        private IWebElement PublishedResaleCash => driver.FindElement(By.Id(""));
        private IWebElement ReportDate => driver.FindElement(By.Id(""));
        private IWebElement ReportId => driver.FindElement(By.Id(""));
        private IWebElement ReportIndustry => driver.FindElement(By.Id(""));
        private IWebElement ReportType => driver.FindElement(By.Id(""));
        private IWebElement Source => driver.FindElement(By.Id(""));
        private IWebElement State => driver.FindElement(By.Id(""));
        private IWebElement Status => driver.FindElement(By.Id("chk-show-column-ReportStatus"));
        private IWebElement TransactionCurrency => driver.FindElement(By.Id(""));
        private IWebElement Type => driver.FindElement(By.Id("chk-show-column-Type"));
        private IWebElement UsageAdjAdvList => driver.FindElement(By.Id(""));
        private IWebElement UsageAdjSoldWhs => driver.FindElement(By.Id(""));
        private IWebElement UsageMeters => driver.FindElement(By.Id(""));
        private IWebElement WarrantyType => driver.FindElement(By.Id(""));
        private IWebElement ResetColumns => driver.FindElement(By.CssSelector("#Reportmanager > div:nth-child(3) > div > div > div.sold-report-inner-wrap > div > div.kendo-grid-column-menu > div.ReactCollapse--collapse > div > div.kendo-grid-column-menu-reset > a"));
        
        private IWebElement ReportStatus => driver.FindElement(By.Id("#Reportmanager > div:nth-child(3) > div > div > div > div > div.kendo-grid-container > div.kendo-grid-column-menu > div"));
        private IWebElement EditPencil => driver.FindElement(By.XPath("//*[contains(@id,'lnk-view-edit-report')]"));
        private IWebElement ViewEye => driver.FindElement(By.XPath("//*[contains(@class, 'fa-eye')]"));
        private IWebElement ViewPencil => driver.FindElement(By.XPath("//*[contains(@class, 'fa-pencil')]"));
        private IWebElement PerformSearch => driver.FindElement(By.Id("btnPerformSearch"));

        public void ClickClearAllFilters()
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//*[contains(@id,'lnk-view-edit-report')]");
            util.WaitForElementNotDisplayed("XPath","//*[contains(@class,'k-loading-mask')]");

            ClearAllFilters.Click();
            Thread.Sleep(500);
            
            util.DismissAlert();
            Util.Log("Clicked Clear All Filters Button.");
            util.WaitForElementNotDisplayed("XPath","//*[contains(@class,'k-loading-mask')]");
        }

        public SoldReportEntry ClickEditPencil()
        {
            EditPencil.Click();
            Util.Log("Clicked Edit Pencil.");
            Util util = new Util(driver);
            util.SwitchToNewTab();
            return new SoldReportEntry(driver);
        }

        public void ClickPerformSearch()
        {
            PerformSearch.Click();
            Util util = new Util(driver);
            util.WaitForElementNotDisplayed("XPath","//*[contains(@class,'k-loading-mask')]");
            util.WaitForElement("XPath","//*[contains(@id,'lnk-view-edit-report')]");
            Util.Log("Clicked Perform Search Button.");
        }

        public SoldReportEntry ClickViewEye()
        {
            ViewEye.Click();
            Util.Log("Clicked View Eye.");
            Util util = new Util(driver);
            util.SwitchToNewTab();
            return new SoldReportEntry(driver);
        }

        public void ConfirmOnReportManager()
        {
            Util util = new Util(driver);
            util.ExecuteScript(Scripts.WaitForPage);
            util.WaitForURL("/ReportManager/SoldReport/ManageReports");
            Util.Log("On Report Manager Page");
        }

        public void ConfirmReadOnly(string true_false)
        {// In Read Only Mode editPencils are not displayed so this checks to see if the pencil is or isn't displayed.
            switch (true_false)
            {
                case "true":
                    try
                    {
                        Assert.IsTrue(!ViewPencil.Displayed);
                        Util.Log("Read Only Confirmed.");
                    }
                    catch (Exception ex) { Util.Log("Grid is not in Read Only Mode but should be." + "\r\n" + ex); }
                break;
                case "false":
                    try
                    {
                        Assert.IsTrue(ViewPencil.Displayed);
                        Util.Log("Grid not in read only mode.");
                    }
                    catch (Exception ex) { Util.Log("Grid in Read Only Mode but should not be." + "\r\n" + ex); }
                break;
            }
        }

        public void EnterReportId(string id)
        {
            ReportIdSearch.SendKeys(id);
            ReportIdSearch.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            Util.Log("Entered Report Id.");
        }

        public void ExpandSoldReportFilters()
        {
            ToggleFilters.Click();
            Util.Log("Expanded Report Filters.");
            Thread.Sleep(500);
        }

        public void SelectEnteredBy(string email)
        {
            Util util = new Util(driver);
            util.WaitForElement("XPath","//label[contains(text(),'Entered By')]/..//div/span[1][not(contains(@class,'Select-loading'))]");
            Util.Log("Field Done Loading.");
            EnteredByInput.SendKeys(email);
            EnteredByInput.SendKeys(Keys.Tab);
            Util.Log("Selected Entered By: "+email);
        }

        public void ToggleColumnMenu()
        {
            ColumnMenu.Click();
            Thread.Sleep(1000);
            Util.Log("Clicked Hide Column Menu.");
        }

        public SoldReportEntry ViewReport(string reportId)
        {
            IWebElement link = driver.FindElement(By.Id("lnk-view-edit-report-" + reportId));
            link.Click();
            Util.Log("Opening Report: " + reportId);
            Util util = new Util(driver);
            util.SwitchToNewTab();
            return new SoldReportEntry(driver);
        }
    }
}