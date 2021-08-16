using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TYPE_ITEM
{
    Material,
    Consumible,
    trash
}

[System.Serializable]
public class Item 
{
    public string nameItem;
    public TYPE_ITEM type_Item;

}
[System.Serializable]
public class ItemInventory
{
    public Item item;
    public int count;

}

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    

    public List<ItemInventory> inventory;


    public void Awake()
    {
        instance = this;
    }

    public void AddItem(Item item, int value)
    {
        if(inventory.Count > 0)
        {
            foreach (ItemInventory i in inventory)
            {
                if(i.item.nameItem == item.nameItem)
                {
                    i.count += value;
                    return;
                }  
                

            }
            ItemInventory itemTemp = new ItemInventory();
            itemTemp.item = item;
            itemTemp.count = value;
            inventory.Add(itemTemp);
        }
        else
        {
            //esto si no hay item en el inventario
            ItemInventory itemTemp = new ItemInventory();
            itemTemp.item = item;
            itemTemp.count = value;
            inventory.Add(itemTemp);
        }
        
    }

}
