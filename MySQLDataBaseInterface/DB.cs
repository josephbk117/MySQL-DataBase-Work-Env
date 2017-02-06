using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MySQLDataBaseInterface
{
    //TODO : Display all available tables in a database
    //TODO : Make all results show up in a data table
    class DB
    {       

        private MySqlConnectionStringBuilder builder;
        public static MySqlConnection conn;
        private bool isConnected = false;
        private List<string> tables;

        public DB(string server,string database,string userId,string password)
        {
            builder = new MySqlConnectionStringBuilder();
            
            builder.Server = server;
            builder.UserID = userId;
            builder.Password = password;
            builder.Database = database;
        }
        
        public MySqlConnectionStringBuilder getBuilder()
        {
            return builder;
        }
        public MySqlCommand giveCommand(string command)
        {
            return new MySqlCommand(command, conn);
        }
        public void connect()
        {
            conn = new MySqlConnection(builder.ToString());
            
        }
        public void openConnection()
        {
            isConnected = true;
            conn.Open();
        }
        public void closeConnection()
        {           
            conn.Close();
        }
        public MySqlDataAdapter getAdapter()
        {
            tables = new List<string>();
            DataTable dt = conn.GetSchema("Tables");
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                tables.Add(tablename);                
            }            
            return new MySqlDataAdapter("select * from " +tables[0], conn);          

        }
        public bool isDataBaseConnected()
        {
            return isConnected;
        }
        public string getTableNames()
        {
            tables = new List<string>();
            DataTable dt = conn.GetSchema("Tables");
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                tables.Add(tablename);
            }
            return tables[0];
        }

    }
}
