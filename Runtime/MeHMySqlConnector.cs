using UnityEngine;
using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MeHmysql
{
    public class MeHMySqlConnector : MonoBehaviour
    {

        static string connString;



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
                Debug.Log("Connecting to MySQL...");
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
                Debug.LogError(ex.ToString());
            }
        }
    }
}
