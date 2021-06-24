using UnityEditor;
using UnityEngine;
using MeHConnect.Mysql;

namespace MeHmysql
{
    public class MenuItems : MonoBehaviour
    {
        [MenuItem("GameObject/MeH Connect System/Add Network Manager To Scene", false, 33)]
        [MenuItem("Assets/MeH Connect System/Add Network Manager To Scene", false, 33)]
        [MenuItem("Tools/MeH Connect System/Add Network Manager To Scene", false, 33)]
        private static void AddNetworkManagerScripts()
        {
            GameObject myGameobject = new GameObject("NetworkManager");

            if (myGameobject == null)
            {
                Debug.LogError("Select A GameObject");
            }
            else
            {
                myGameobject.AddComponent<NetWorkManager>();               
            }
        }
        /*
        [MenuItem("Tools/MeH Mysql System/SettingsWindow", false)]
        public static void ShowWindow()
        {
            EditorWindow.GetWindow(typeof(MeHMysqlSettingsWindow));
        }
        */
    }
}
