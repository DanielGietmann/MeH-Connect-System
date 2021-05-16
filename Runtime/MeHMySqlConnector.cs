using UnityEngine;
using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MeHmysql
{
    public class MeHMySqlConnector : MonoBehaviour
    {

        //Debug mode
        private static bool isDebug;

        public static void EnableDebug()
        {
            isDebug = true;
            Debug.Log("MYSQL DEBUG is ON");
        }

        public static void DisableDebug()
        {
            isDebug = false;
            Debug.Log("MYSQL DEBUG is OFF");
        }


        //DB Connection

        private static string connString;

        public static void CreateDBConString(string Server, string User, string Database, string Port,string Password)
        {
            connString = "server="+ Server +";user="+ User +";database="+Database+";port="+Port+";password="+Password+"";
        }
                    

        public static void DBConnection(string sqlbefehl)
        {
            string connStr = connString;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                if (isDebug)
                {
                    Debug.Log("Connecting to MySQL...");
                }
                conn.Open();

                string sql = sqlbefehl;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    int r = Convert.ToInt32(result);
                }

            }
            catch (Exception ex)
            {
                if (isDebug)
                {
                    Debug.LogError(ex.ToString());
                }
            }
        }
    }
}
