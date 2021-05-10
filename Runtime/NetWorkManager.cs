using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MeHmysql
{
    public class NetWorkManager : MonoBehaviour
    {

        public string Server;
        public string User;
        public string Database;
        public string Port;
        public string Password;


        private void Awake()
        {
            MeHMySqlConnector.CreateDBConString(Server, User, Database, Port, Password);
        }

    }
}