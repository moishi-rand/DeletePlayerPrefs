using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class DeletePlayerPrefs : EditorWindow
	{
		string key = "";

		[MenuItem("Tools/DeletePlayerPrefs")]
		static void Init()
		{
			DeletePlayerPrefs window = (DeletePlayerPrefs)EditorWindow.GetWindow(typeof(DeletePlayerPrefs));
			window.Show();
		}

		static void DeletePlayerPrefsAccordingKey(string key)
		{
			PlayerPrefs.DeleteKey(key);
		}

		void OnGUI()
		{
			GUILayout.Label("Enter PlayerPrefs Key", EditorStyles.boldLabel);
			key = EditorGUILayout.TextField("Text Field", key);

			if (GUILayout.Button("Delete"))
			{
				DeletePlayerPrefsAccordingKey(key);
				Close();
			}
		}
	}
