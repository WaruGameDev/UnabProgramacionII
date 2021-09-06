using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItemEvent : MonoBehaviour
{
    public ItemInventory itemToDrop;

    public void DropItem()
    {
        InventoryManager.instance.DropItem(itemToDrop.item, itemToDrop.count);
    }

}
