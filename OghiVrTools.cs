using UnityEditor;
using UnityEngine;

namespace OghiVrTools
{
    public static class OghiVrTools 
    {
        private static readonly string uiCanvasPrefabLocation = "Packages/com.oghina.oghivrtools/UI/Prefabs/VR_Canvas.prefab";
        private static readonly string packageFolderLocation = "Packages/com.oghina.oghivrtools/";
        
        public static void InitializeVrTools()
        {
            GameObject prefab = (GameObject)AssetDatabase.LoadAssetAtPath(uiCanvasPrefabLocation, typeof(GameObject));
            if (prefab != null)
            {
                Debug.Log($"Prefab name is {prefab.name}");
            }
            else
            {
                Debug.LogError("Failed to load prefab: " + uiCanvasPrefabLocation);
            }
            
            string[] guids = AssetDatabase.FindAssets("", new[] { packageFolderLocation });
            foreach (string guid in guids)
            {
                string assetPath = AssetDatabase.GUIDToAssetPath(guid);
                Debug.Log("Asset found: " + assetPath);
            }
        }
    }
}
