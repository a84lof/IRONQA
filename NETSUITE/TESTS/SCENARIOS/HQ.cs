namespace IRONQA.NETSUITE.TESTS.SCENARIOS
{
    using IRONQA.NETSUITE.PAGES.CORP;
    using IRONQA.NETSUITE.PAGES.SHARED;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class HQ
    {
        private IWebDriver driver;
        public HQ(IWebDriver _driver) => driver = _driver;

        public void Login()
        {
            NSLogin login = new NSLogin(driver);
            login.ConfirmLoginPage();
            Authentication auth = login.SubmitLogin(Users.NetSuiteQA, Users.TestPassword);
            // auth.ConfirmAuthenticationPage();
            // auth.EnterTwoFactorKey();
            // auth.ClickSubmit();
            login.AnswerValidationQuestion();
        }

        public void CloseSalesOrder(string salesOrder)
        {
            NSLogin login = new NSLogin(driver);
            login.ConfirmLoginPage();
            Authentication auth = login.SubmitLogin(Users.NetSuiteQA, Users.TestPassword);
            auth.ConfirmAuthenticationPage();
            auth.EnterTwoFactorKey();
            Nav nsnav = auth.ClickSubmit();
            nsnav.ConfirmNSNav();
            SalesOrder so = nsnav.SearchForSalesOrder(salesOrder);
            so.ConfirmOnSalesOrderPage();
            so.ClickCloseOrder();
            so.ConfirmClosed();
        }

        public void ChangeRole()
        {
            NSLogin login = new NSLogin(driver);
            login.ConfirmLoginPage();
            Authentication auth = login.SubmitLogin(Users.NetSuiteQA, Users.TestPassword);
            auth.ConfirmAuthenticationPage();
            auth.EnterTwoFactorKey();
            Nav nsnav = auth.ClickSubmit();
            RoleSelection role = nsnav.ClickRoles();
            nsnav = role.SelectRole(Users.NetSuiteRoles.QA44IronAdmin);
        }
    }
}