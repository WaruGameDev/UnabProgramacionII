using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public Item item;
    public int value;


    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        AddItemToInventory();
    }
    public void AddItemToInventory()
    {
        InventoryManager.instance.AddItem(item, value);
    }
}
