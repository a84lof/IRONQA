namespace IRONQA.UTILITIES
{
    using OpenQA.Selenium;

    public class Users
    {
        private IWebDriver driver;
        public Users(IWebDriver _driver) => driver = _driver;

        public static string USBasicAdmin;
        public static string USBasicUser;
        public static string USPlusAdmin;
        public static string USPlusUser;
        public static string USProAdmin;
        public static string USProUser;
        public static string CANBasicAdmin;
        public static string CANBasicUser;
        public static string CANPlusAdmin;
        public static string CANPlusUser;
        public static string CANProAdmin;
        public static string CANProUser;
        public static string FSBOUser;
        public static string GDMQA;
        public static string GDMAdmin;
        public static string GDMEditor;
        public static string GDMEntry;
        public static string GDMViewer;
        public static string NetSuiteQA;
        public static string ProInvAdmin; //MultiLocationAdmin Role usigqa
        public static string PlusInvAdmin; //SingleLocationAdmin Role canigqa
        public static string TestPassword;
        public static string NSPassword;

        public static void GetUser(string environment)
        {
            switch (environment)
            {
                case "Beta":
                    USBasicAdmin = "BasicAdmin@usigqa.com";
                    USBasicUser = "BasicUser@usigqa.com";
                    USPlusAdmin = "PlusAdmin@usigqa.com";
                    USPlusUser = "PlusUser@usigqa.com";
                    USProAdmin = "ProAdmin@usigqa.com";
                    USProUser = "ProUser@usigqa.com";
                    CANBasicAdmin = "BasicAdmin@canigqa.com";
                    CANBasicUser = "BasicUser@canigqa.com";
                    CANPlusAdmin = "PlusAdmin@canigqa.com";
                    CANPlusUser = "PlusUser@canigqa.com";
                    CANProAdmin = "ProAdmin@canigqa.com";
                    CANProUser = "ProUser@canigqa.com";
                    FSBOUser = "FSBOUser@FSBOrg.com";
                    GDMQA = "qa@ironsolutions.com";
                    GDMAdmin = "gdmadmin@usigqa.com";
                    GDMEditor = "gdmeditor@usigqa.com";
                    GDMEntry = "gdmentry@usigqa.com";
                    GDMViewer = "gdmviewer@usigqa.com";
                    NetSuiteQA = "qa@ironsolutions.com";
                    ProInvAdmin = "ProInvAdmin@usigqa.com";
                    PlusInvAdmin = "PlusInvAdmin@usigqa.com";
                    TestPassword = "";
                    NSPassword = "";
                    break;
                case "Production":
                    USBasicAdmin = "qa+BasicAdmin@ironsolutions.com";
                    USBasicUser = "qa+BasicUser@ironsolutions.com";
                    USPlusAdmin = "qa+PlusAdmin@ironsolutions.com";
                    USPlusUser = "qa+PlusUser@ironsolutions.com";
                    USProAdmin = "qa+ProAdmin@ironsolutions.com";
                    USProUser = "qa+ProUser@ironsolutions.com";
                    CANBasicAdmin = "qa+CANBasicAdmin@ironsolutions.com";
                    CANBasicUser = "qa+CANBasicUser@ironsolutions.com";
                    CANPlusAdmin = "qa+CANPlusAdmin@ironsolutions.com";
                    CANPlusUser = "qa+CANPlusUser@ironsolutions.com"; //broken account
                    CANProAdmin = "qa+CANProAdmin@ironsolutions.com";
                    CANProUser = "qa+CANProUser@ironsolutions.com";
                    GDMQA = "qa@ironsolutions.com";
                    GDMAdmin = "qa+gdmadmin@ironsolutions.com";
                    GDMEditor = "qa+gdmeditor@ironsolutions.com";
                    GDMEntry = "qa+gdmentry@ironsolutions.com";
                    GDMViewer = "qa+gdmviewer@ironsolutions.com";
                    NetSuiteQA = "qa@ironsolutions.com";
                    ProInvAdmin = "qa+multilocadmin@usiga.com";
                    PlusInvAdmin = "qa+singlelocadmin@usigqa.com";
                    TestPassword = "";
                    NSPassword = "";
                    break;
            }
        }

        public static string RandomQAEmail = "qa+" + Util.GetRandomNumber(2) + Util.GetRandomString(4) + "@ironsolutions.com";

        // Generate User Account Info (store.ironsearch.com)
        public static string FirstName = "QA";
        public static string LastName = "Test_" + Util.GetRandomString(1) + Util.GetRandomNumber(2) + Util.GetRandomString(1) + Util.GetRandomNumber(1);
        public static string FullName = FirstName + " " + LastName;
        public static string CompanyName = FirstName + LastName;

        // Address Info (store.ironsearch.com)
        public static string Address = "660 Bakers Bridge Ave.";
        public static string City = "Franklin";
        public static string State = "TN";
        public static string Zip = "37067";
        public static string HyphenatedPhoneNumber = Util.GetRandomNumber(3) + "-" + Util.GetRandomNumber(3) + "-" + Util.GetRandomNumber(4);
        public static string PhoneNumber = Util.GetRandomNumber(10);
        public static string Email = "qa@test.com";

        // Payment Info (store.ironsearch.com)
        public static string CreditCard = "4111111111111111";
        public static string CardType = "Visa";
        public static string SecurityCode = "123";

        public enum NetSuiteRoles { SandboxAdminNoHR, SandboxSalesAdmin, SandboxSalesRep, ProdAdminNoHR, QA24IronAdmin, QA24SalesManager, QA24SalesRep, QA44IronAdmin, QA44SalesManager, QA44SalesRep }
    }
}