using System;
using System.Data.SqlClient;

namespace HelloWorldLibrary {
    public class Lib {
        public static string About() {
            return "About Hello World Library";
        }
        public static void Get() {
            var connStr = "Server=tcp:prsbc30db.database.windows.net,1433;" +
                            "Initial Catalog=PrsBc30Server_db;" +
                            "Persist Security Info=False;" +
                            "User ID=prsbc30admin;Password=prsbc30Il0v3cnk;" +
                            "MultipleActiveResultSets=False;" +
                            "Encrypt=True;TrustServerCertificate=False;" +
                            "Connection Timeout=30;";
            var conn = new SqlConnection(connStr);
            conn.Open();
            if(conn.State != System.Data.ConnectionState.Open) {
                throw new Exception("Could not open connection");
            }
            Console.WriteLine("Success!");
            conn.Close();
        }
    }
}
