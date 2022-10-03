using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class EditorMenu
{
    [MenuItem("Scene To C#/Export Active Scene")]
    public static void Menu_ExportSceneToAssetsFolder()
    {
        string sceneName = EditorSceneManager.GetActiveScene().name;
        Debug.Log($"Scene Exported: {sceneName}");
    }
}
