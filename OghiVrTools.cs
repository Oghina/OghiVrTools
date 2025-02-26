using UnityEditor;
using UnityEngine;

namespace OghiVrTools
{
    public static class OghiVrTools 
    {
        private static readonly string uiCanvasPrefabLocation = "Packages/com.oghina.oghivrtools/UI/Prefabs/VR_Canvas.prefab";

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
        }
    }
}
