namespace IRONQA.STORE.TESTS.SCENARIOS
{
    using IRONQA.NETSUITE.PAGES.SHARED;
    using IRONQA.NETSUITE.TESTS.SCENARIOS;
    using IRONQA.SSO.PAGES;
    using IRONQA.STORE.PAGES.MYACCOUNT;
    using IRONQA.STORE.PAGES.SHARED;
    using IRONQA.STORE.PAGES.CART;
    using IRONQA.STORE.PAGES.CHECKOUT;
    using IRONQA.TESTRUN;
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;

    public class Tests
    {
        private static IWebDriver driver;
        public Tests(IWebDriver _driver) => driver = _driver;

        public void Purchase()
        {// Complete a Purchase and Close SO 
            SSOLogin login = new SSOLogin(driver);
            login.ConfirmOnLoginPage();
            SSOHome sso = login.SubmitValidCredentials(Users.USBasicAdmin ,Users.TestPassword);
            sso.ConfirmOnSSOHomePage();
            //Navigate to eStore
            Overview overview = sso.ClickMyAccount();
            overview.ConfirmOnOverviewPage();
            StoreNav nav = new StoreNav(driver);
            //Select an appraisal
            Shop shop = nav.ClickShop();
            shop.ConfirmOnShopPage();
            shop.ClickFullAppraisal();
            shop.EnterQuantity("1");
            shop.ClickAddToCart();
            //Adjust accumulated quantity
            MyCart cart = shop.ClickViewCart();
            cart.ConfirmOnCartPage();
            cart.AdjustQuantity("1");
            Shipping ship = cart.ClickProceedToCheckout();
            ship.ConfirmOnshippingPage();
            ship.ClickContinue();
            //Enter payment info
            Billing bill = ship.ClickContinue();
            bill.ClickPromoCode();
            bill.EnterPromoCode("");
            bill.ClickApply();
            bill.EnterSecurityNumber("123");
            Review review = bill.ClickContinue();
            review.ConfirmReviewPage();
            //Place Order creating the Sales Order in NetSuite
            Confirmation confirm = review.ClickPlaceOrder();
            confirm.ConfirmConfirmationPage();
            confirm.GetSalesOrderNumber();
            //Log into NetSuite
            driver.Navigate().GoToUrl(TestDetails.NSURL);
            NSLogin nslogin = new NSLogin(driver);
            nslogin.ConfirmLoginPage();
            //Satisfy 2FA
            HQ test = new HQ(driver);
            test.CloseSalesOrder(Confirmation.SalesOrderNumber);
        }
    }
}
