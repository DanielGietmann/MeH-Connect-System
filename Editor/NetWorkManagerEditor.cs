using UnityEditor;
using UnityEngine;

namespace MeHmysql
{
    [CustomEditor(typeof(NetWorkManager))]
    public class NetWorkManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            NetWorkManager netWorkmanager = (NetWorkManager)target;
            serializedObject.Update();
            GUILayout.Label("MySql Server Settings", EditorStyles.label);
            GUILayout.Space(5);
            netWorkmanager.Server = EditorGUILayout.TextField("Server IP", netWorkmanager.Server);
            GUILayout.Space(2);
            netWorkmanager.User = EditorGUILayout.TextField("UserName", netWorkmanager.User);
            GUILayout.Space(2);
            netWorkmanager.Database = EditorGUILayout.TextField("Database", netWorkmanager.Database);
            GUILayout.Space(2);
            netWorkmanager.Port = EditorGUILayout.TextField("Port", netWorkmanager.Port);
            GUILayout.Space(2);
            netWorkmanager.Password = EditorGUILayout.PasswordField("Password", netWorkmanager.Password);
            GUILayout.Space(10);
            GUILayout.Label("Debug Setting", EditorStyles.label);
            GUILayout.Space(5);
            netWorkmanager.isDebug = GUILayout.Toggle(netWorkmanager.isDebug, "Enable Debug Mode");
            serializedObject.ApplyModifiedProperties();
        }
    }
}
