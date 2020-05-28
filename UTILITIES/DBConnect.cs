namespace IRONQA.UTIL
{
    using IRONQA.UTILITIES;
    using OpenQA.Selenium;
    using System;
    using System.Data.SqlClient;

    public class SQLUtil
    {
        public IWebDriver driver;
        public SQLUtil(IWebDriver _driver) => driver = _driver;

        public static string ExecuteSQL(string query)
        {
            string connString = "Data Source=;User ID=;Password=";
            var DBConnection = new SqlConnection(connString);
            DBConnection.Open();
            var MemTable = new SqlCommand();
            MemTable.CommandText = query;
            MemTable.Connection = DBConnection;
            var dr = MemTable.ExecuteReader();
            var value = "";

            while (dr.Read())
            {
                value = dr.ToString();
                Util.Log(value);
            }
            return value;
        }

        public static string Response = "";

        public void ConfirmResponse(string query)
        {
            Response = ExecuteSQL(query);
            Util.HoldValue(Response);
            Util.Log("It's an old code, but it checks out." + "\r\n" + Response);
        }
    }
}
