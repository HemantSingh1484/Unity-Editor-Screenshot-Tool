using UnityEngine;
using UnityEditor;


public class ScreenshotToolWindow : EditorWindow
{
    [MenuItem("Tools/Screenshot Tool")]
    public static void ShowWindow()
    {
        GetWindow<ScreenshotToolWindow>("Screenshot Tool");
    }
    private int screenshotWidth = 1920;
    private int screenshotHeight = 1080;
    private string fileName = "Screenshot";

    private string saveFolder = "Screenshots";
    private void OnGUI()
    {
        GUILayout.Label("Unity Screenshot Tool", EditorStyles.boldLabel);
        EditorGUILayout.Space(10);
        GUILayout.Label("Resolution", EditorStyles.boldLabel);
        if (GUILayout.Button("Take Screenshot"))
        {
            Debug.Log("Screenshot button clicked!");
        }
    }

}




// private void OnGUI()
// {
//     GUILayout.Label("Unity Screenshot Tool", EditorStyles.boldLabel);

//     EditorGUILayout.Space(10);

//     // Resolution
//     EditorGUILayout.LabelField("Screenshot Resolution", EditorStyles.boldLabel);

//     screenshotWidth = EditorGUILayout.IntField("Width", screenshotWidth);
//     screenshotHeight = EditorGUILayout.IntField("Height", screenshotHeight);

//     EditorGUILayout.Space(10);

//     // File name
//     EditorGUILayout.LabelField("File Settings", EditorStyles.boldLabel);

//     fileName = EditorGUILayout.TextField("File Name", fileName);

//     EditorGUILayout.Space(10);

//     // Save location
//     EditorGUILayout.LabelField("Save Location", EditorStyles.boldLabel);

//     EditorGUILayout.BeginHorizontal();

//     EditorGUILayout.TextField(saveFolder);

//     if (GUILayout.Button("Browse", GUILayout.Width(70)))
//     {
//         SelectSaveFolder();
//     }

//     EditorGUILayout.EndHorizontal();

//     EditorGUILayout.Space(15);

//     if (GUILayout.Button("Take Screenshot", GUILayout.Height(30)))
//     {
//         CaptureScreenshot();
//     }
// }