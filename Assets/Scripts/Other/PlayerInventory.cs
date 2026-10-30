#region Libraries
using System.Collections.Generic;
using UnityEngine;
#endregion

[System.Serializable]
public class PlayerInventory
{
    private static readonly int maxItems = 20;
    public List<Item> inventoryContents = new();

    public void AddItem(Item item)
    {
        if (inventoryContents.Count < maxItems)
        {
            inventoryContents.Add(item);
        }
    }
}
