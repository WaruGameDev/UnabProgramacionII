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

    public ItemInventory tempItem;


    public void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
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
    public void DropItem(Item item, int value)
    {
        if(inventory.Count > 0)
        {
            foreach (ItemInventory i in inventory)
            {
                if (i.item.nameItem == item.nameItem)
                {
                    // si el valor es mayor a la cantidad... entonces no dropiar o dropiar lo que tiene.
                    if(i.count >= value)
                    {
                        i.count -= value;
                        if (i.count <= 0)
                        {
                            inventory.Remove(i);
                        }
                    }
                    else
                    {
                        // no tienes suficiente objetos.
                    }
                    
                    return;
                }


            }
            
        }
        else
        {
            //no tengo item para dropear
        }
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            DropItem(tempItem.item, tempItem.count);
        }
    }

}
