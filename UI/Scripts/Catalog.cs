using System.Collections.Generic;
using UnityEngine;

namespace OghiVrTools.UI.Scripts
{
    public class Catalog
    {
        public Dictionary<string, Sprite> Products { get; } = new();

        public void AddProduct(string productName, Sprite product)
        {
            if (Products.TryGetValue(productName, out var productSprite))
            {
                Debug.LogWarning("Trying to add a product which has already been added to your catalog.");
                return;
            }

            Products.Add(productName, product);
        }

        public void RemoveProduct(string productName)
        {
            // Check if the product is there
            if (!Products.Remove(productName, out var product))
                Debug.LogWarning("Trying to remove a non-existing product from catalog");
        }
    }
}