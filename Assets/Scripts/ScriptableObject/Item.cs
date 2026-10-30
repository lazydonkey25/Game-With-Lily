#region Libaries
using UnityEngine;
#endregion

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public bool isConsumable;
}
