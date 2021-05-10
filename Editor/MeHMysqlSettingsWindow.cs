using System;
using UnityEditor;
using UnityEngine;

namespace MeHmysql
{
    public class MeHMysqlSettingsWindow : EditorWindow
    {

        public string Server;
        public string User;
        public string Database;
        public string Port;
        public string Password;



        private void OnEnable()
        {
            Server = EditorPrefs.GetString("MeHMysqlServer");
            User = EditorPrefs.GetString("MeHMysqlUser");
            Database = EditorPrefs.GetString("MeHMysqlDatabase");
            Port = EditorPrefs.GetString("MeHMysqlPort");
            Password = EditorPrefs.GetString("MeHMysqlPassword");          
        }

        private void SaveData()
        {
             EditorPrefs.SetString("MeHMysqlServer", Server);
             EditorPrefs.SetString("MeHMysqlUser", User);
             EditorPrefs.SetString("MeHMysqlDatabase", Database);
             EditorPrefs.SetString("MeHMysqlPort", Port);
             EditorPrefs.SetString("MeHMysqlPassword", Password);
        }


        void OnGUI()
        {
            GUILayout.Label ("Base Settings", EditorStyles.boldLabel);
            Server = EditorGUILayout.TextField("ServerIP",Server);
            User = EditorGUILayout.TextField("Username",User);
            Database = EditorGUILayout.TextField("Database",Database);
            Port = EditorGUILayout.TextField("Port",Port);
            Password = EditorGUILayout.TextField("Password",Password);

            if(GUILayout.Button("Save Data"))
            {
                SaveData();
                MeHMySqlConnector.CreateDBConString(Server, User, Database, Port, Password);
            }
        }
    }    
}
