#region Libraries
using System;
using TMPro;
using UnityEngine;
#endregion

public class InventoryManager : MonoBehaviour
{
    #region Variables
    public static InventoryManager instance;
    [SerializeField] bool displayTestInv;
    [SerializeField] TextMeshProUGUI testInvText;
    [SerializeField] ItemDatabase itemDatabase;
    [SerializeField] PlayerInventory playerInventory;
    #endregion

    #region Unity Methods
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        testInvText.enabled = displayTestInv;

        playerInventory.AddItem(itemDatabase.GetItem("Apple"));

        WriteTestInv();
    }

    void Update()
    {
        if (displayTestInv)
        {

        }
    }
    #endregion

    #region Methods
    private void WriteTestInv()
    {
        if (displayTestInv)
        {
            testInvText.text = $"{String.Join(",", playerInventory.inventoryContents)}";
        }
    }
    #endregion
}
