using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace RosterBuilder
{
    public class dbcontroller
    {
        public static SqlConnection Getconnect()
        {
            string connstr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\RosterBuilder\RosterBuilder\db.mdf; Integrated Security = True";
            SqlConnection connect = new SqlConnection(connstr);
            return connect;
        }

        public static void AddUser(string username, string password)
        {
            string insStmt = "INSERT INTO User(Username, Password) VALUES (@username, @password)";
            SqlConnection conn = Getconnect();
            SqlCommand insCmd = new SqlCommand(insStmt, conn);
            insCmd.Parameters.AddWithValue("@username",username);
            insCmd.Parameters.AddWithValue("@password",password);
                try
                {
                    conn.Open();
                    insCmd.ExecuteNonQuery();
                }
                catch
                (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
         }

        public static List<User> GetUser()
        {
            List<User> userlist = new List<User>();
            SqlConnection conn = Getconnect();
            string selStmt = "SELECT * FROM User ORDER BY Username";
            SqlCommand selCmd = new SqlCommand(selStmt, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = selCmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.id = (int)
                }
            }

        }

        }
    }
}
