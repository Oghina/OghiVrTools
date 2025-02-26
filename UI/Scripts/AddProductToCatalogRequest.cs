using OghiUnityTools.EventBus;
using UnityEngine;

namespace OghiVrTools.UI.Scripts
{
    public struct AddProductToCatalogRequest : IEvent
    {
        public readonly string ItemName;
        public readonly Sprite ItemPicture;

        public AddProductToCatalogRequest(string itemName, Sprite itemPicture = null)
        {
            ItemName = itemName;
            ItemPicture = itemPicture;
        }
    }
}