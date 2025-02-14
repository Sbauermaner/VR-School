using UnityEditor;
using UnityEngine;

public static class CreateAIConfigMenu
{
    [MenuItem("Config/Create AIConfig")]
    public static void CreateConfig()
    {
        AIConfig config = ScriptableObject.CreateInstance<AIConfig>();
        AssetDatabase.CreateAsset(config, "Assets/Resources/Configs/AIConfig.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = config;
    }
}
