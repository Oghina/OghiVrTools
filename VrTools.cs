using UnityEditor;
using UnityEngine;

namespace OghiVrTools.OghiVrTools
{
    public static class OghiVrTools
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
        }
    }
}