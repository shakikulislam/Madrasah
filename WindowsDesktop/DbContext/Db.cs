using System.Data;
using System.Data.SqlClient;
using WindowsDesktop.Common;

namespace WindowsDesktop.DbContext
{
    public class Db
    {
        // SQL connection
        private static string _databaseName = "MadrasahDb";
        private static string _userId = "sa";
        private static string _password = "bkbabu";
        //private static string _connectionString = @"Data Source=" + GlobalSettings.Server +
        //                                          "; Initial Catalog=" + _databaseName +
        //                                          "; User ID=" + _userId +
        //                                          "; Password=" + _password + "";

        private static string _connectionString = @"Data Source=" + GlobalSettings.Server +
                                                  "; Initial Catalog=" + _databaseName +
                                                  "; Integrated Security = True";

        private static SqlConnection conn = new SqlConnection(_connectionString);
        private static SqlCommand cmd = new SqlCommand("", conn);
        private static SqlDataReader dr;
        private static SqlDataAdapter da;
        private static DataTable dt;

        public static string DbName { get; } = _databaseName;

        //Method

        public static bool HasExisted(string query)
        {
            GetConnection();
            cmd.CommandText = query;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt.Rows.Count>0;
        }

        public static void GetConnection()
        {
            CloseConnection();
            conn.Open();
        }

        public static void CloseConnection()
        {

            if (conn.State == ConnectionState.Open || conn.State == ConnectionState.Broken)
            {
                conn.Close();
            }
        }

        public static bool QueryExecute(string query)
        {
            GetConnection();
            cmd.CommandText = query;
            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool QueryExecute(SqlCommand sqlCommand)
        {
            GetConnection();
            //var cmd1 = new SqlCommand(sqlCommand.CommandText, conn);
            //cmd1.Parameters.Clear();
            //foreach (SqlParameter parameter in sqlCommand.Parameters)
            //{
            //    cmd1.Parameters.Add(parameter);
            //}
            sqlCommand.Connection = conn;
            return sqlCommand.ExecuteNonQuery() > 0;
        }

        public static SqlDataReader GetDataReader(string query)
        {
            GetConnection();

            cmd.CommandText = query;
            dr = cmd.ExecuteReader();
            return dr;
        }

        public static DataTable GetDataTable(string query)
        {
            GetConnection();
            cmd.CommandText = query;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
    }
}
