﻿using System.Data;
using WindowsDesktop.Common;
using MySql.Data.MySqlClient;

namespace WindowsDesktop.DbContext
{
    public class Db
    {
        // SQL connection
        //private static string _server = "localhost";
        private static string _databaseName = "madrasah_db";
        private static string _userId = "shakikul";
        //private static string _password = "";
        private static string _password = "Shakikul@77";

        private static string _connectionString = "Server=" + GlobalSettings.Server + ";Database=" + _databaseName + ";Uid=" + _userId + ";Pwd=" + _password;

        private static MySqlConnection conn = new MySqlConnection(_connectionString);
        private static MySqlCommand cmd = new MySqlCommand("", conn);
        private static MySqlDataReader dr;
        private static MySqlDataAdapter da;
        private static DataTable dt;

        //Method

        public static bool HasExisted(string query)
        {
            GetConnection();
            cmd.CommandText = query;
            da = new MySqlDataAdapter(cmd);
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

        public static bool QueryExecute(MySqlCommand mySqlCommand)
        {
            GetConnection();
            cmd.Parameters.Clear();
            cmd.CommandText = mySqlCommand.CommandText;
            foreach (MySqlParameter parameter in mySqlCommand.Parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            return cmd.ExecuteNonQuery() > 0;
        }

        public static MySqlDataReader GetDataReader(string query)
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
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
    }
}
