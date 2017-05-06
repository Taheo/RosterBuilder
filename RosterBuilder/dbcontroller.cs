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
            string connStr = @"data source=DESKTOP-NN2FSE0\INSTANCJA;initial catalog=RosterDB;trusted_connection=true";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }
        public static void AddUser(string _username, string _password, string _email)
        {
            string insStmt = "INSERT INTO [UserTable] (Username, Email, Password) VALUES (@username, @email, @password)";
            SqlConnection conn = GetConnection();
            SqlCommand insCmd = new SqlCommand(insStmt, conn);
            insCmd.Parameters.AddWithValue("@username", _username);
            insCmd.Parameters.AddWithValue("@email", _email);
            insCmd.Parameters.AddWithValue("@password", _password);

            try { conn.Open(); insCmd.ExecuteNonQuery(); }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
        }

        public static void AddUnit(string _unitname, string _unittype, int _cost)
        {
            string insStmt = "INSERT INTO Unit (UnitName, UnitType, CostPerModel) VALUES (@unitname, @unittype, @cost)";
            SqlConnection conn = GetConnection();
            SqlCommand insCmd = new SqlCommand(insStmt, conn);
            insCmd.Parameters.AddWithValue("@unitname", _unitname);
            insCmd.Parameters.AddWithValue("@unittype", _unittype);
            insCmd.Parameters.AddWithValue("@cost", _cost);

            try { conn.Open(); insCmd.ExecuteNonQuery(); }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
        }


        public static List<User> GetUser()
        {
            List<User> UserList = new List<User>();

            SqlConnection conn = GetConnection();
            string selStmt = "SELECT * FROM UserTable ORDER BY Username";
            SqlCommand selCmd = new SqlCommand(selStmt, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = selCmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.id = (int)reader["IDuser"];
                    user.username = reader["Username"].ToString();
                    user.email = reader["Email"].ToString();
                    user.password = reader["Password"].ToString();
                    UserList.Add(user);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
            return UserList;
        }

        public static List<Unit> GetUnit()
        {
            List<Unit> UnitList = new List<Unit>();

            SqlConnection conn = GetConnection();
            string selStmt = "SELECT * FROM Unit ORDER BY UnitName";
            SqlCommand selCmd = new SqlCommand(selStmt, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = selCmd.ExecuteReader();
                while (reader.Read())
                {
                    Unit unit = new Unit();
                   // unit.getID = (int)reader["Id"];
                    unit.getUnitName = reader["UnitName"].ToString();
                    unit.getUnitType = reader["UnitType"].ToString();
                    unit.getUnitCost = (int)reader["CostPerModel"];
                    UnitList.Add(unit);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
            return UnitList;
        }


        public static bool LoginUser(string _username, string _password)
        {
            SqlConnection conn = GetConnection();
            SqlDataAdapter selStmt = new SqlDataAdapter("SELECT Username, Password FROM UserTable WHERE Username = '" + _username + "' AND Password = '" + _password + "'", conn);
            DataTable dt = new System.Data.DataTable();
            selStmt.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }
}
