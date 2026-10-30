#region Libraries
using System.Collections.Generic;
using UnityEngine;
#endregion

[CreateAssetMenu(fileName = "ItemDatabase", menuName = "Scriptable Objects/ItemDatabase")]
public class ItemDatabase : ScriptableObject
{
    public List<Item> itemDatabase = new();

    public Item GetItem(string itemName)
    {
        for (int i = 0; i < itemDatabase.Count; i++)
        {
            if (itemDatabase[i].name == itemName)
            {
                return itemDatabase[i];
            }
        }

        return null;
    }
}
