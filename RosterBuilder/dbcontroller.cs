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
        public static SqlConnection GetConnection()
        {
            //    string connstr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\RosterBuilder\RosterBuilder\db.mdf; Integrated Security = True";
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\programowanie\c#\RosterBuilder\RosterBuilder\db.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }
        public static void AddPlayer(string _username, string _password)
        {
            string insStmt = "INSERT INTO User (Username, Password) VALUES (@username, @password)";
            SqlConnection conn = GetConnection();
            SqlCommand insCmd = new SqlCommand(insStmt, conn);
            insCmd.Parameters.AddWithValue("@username", _username);
            insCmd.Parameters.AddWithValue("@password", _password);

            try { conn.Open(); insCmd.ExecuteNonQuery(); }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
        }
        public static List<User> GetUser()
        {
            List<User> UserList = new List<User>();
            SqlConnection conn = GetConnection();
            string selStmt = "SELECT * FROM Player ORDER BY PlayerName";
            SqlCommand selCmd = new SqlCommand(selStmt, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = selCmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    //player.PlayerId = (int)reader["PlayerId"];
                    //player.PlayerName = reader["PlayerName"].ToString();
                    //player.PlayerPassword = reader["Password"].ToString();
                    //player.PlayerCash = (int)reader["PlayerCash"];
                    //player.PlayerTokens = (int)reader["PlayerTokens"];
                    UserList.Add(user);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
            return UserList;
        }
        //public static bool LoginPlayer(string playerName, string password)
        //{
        //    SqlConnection conn = GetConnection();
        //    SqlDataAdapter selStmt = new SqlDataAdapter("SELECT * FROM Player WHERE PlayerName = '" + playerName + "' AND Password = '" + password + "'", conn);
        //    DataTable dt = new System.Data.DataTable();
        //    selStmt.Fill(dt);
        //    if (dt.Rows.Count == 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}
    }
}
