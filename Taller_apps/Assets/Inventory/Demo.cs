using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public InventoryManager inventorymanager;
    public Item[] itemtopickup;

    public void PickupItem(int id)
    {
        bool result = inventorymanager.AddItem(itemtopickup[id]);
        if(result == true)
        {
            Debug.Log("Object added");
        }
        else
        {
            Debug.Log("Object not added");
        }

    }
}
