using UnityEditor;
using UnityEngine;

namespace OghiVrTools
{
    public static class VrTools
    {
        private static readonly string uiCanvasPrefabLocation =
            "Packages/com.oghina.oghivrtools/UI/Prefabs/VR_Canvas.prefab";

        private static readonly string packageFolderLocation = "Packages/com.oghina.oghivrtools/";

        public static GameObject InitializeVrTools()
        {
            var prefab = (GameObject)AssetDatabase.LoadAssetAtPath(uiCanvasPrefabLocation, typeof(GameObject));
            if (prefab != null)
                Debug.Log($"Prefab name is {prefab.name}");
            else
                Debug.LogError("Failed to load prefab: " + uiCanvasPrefabLocation);
            return prefab;
            
            // Just a comment to test git ignore
        }
    }
}