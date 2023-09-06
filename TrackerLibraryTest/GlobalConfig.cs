using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAcess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DataBaseType db) 
        {
            switch (db) 
            {
                case DataBaseType.Sql:
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                    break;
                case DataBaseType.TextFile:
                    TextConnector text = new TextConnector();
                    Connection = text;
                    break;
                default: 
                    break;
            }
            //Connection Handler using if statement
            //if(db== DataBaseType.Sql) 
            //{
            //    // TODO - Set up the SQL Connector properly
            //    SqlConnector sql = new SqlConnector();
            //    Connections = sql;
            //}
            //else if (db == DataBaseType.TextFile)
            //{
            //    // TODO - Create the Text Connection
            //    TextConnector text = new TextConnector();
            //    Connections = text;
            //}
        }

        public static string CnnString(string name) 
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;  
        }
    }
}
