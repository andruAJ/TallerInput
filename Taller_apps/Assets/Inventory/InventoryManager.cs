using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int MaxStack = 4;
    public Slot[] slots;
    public GameObject Iobjectprefab;
    public bool AddItem(Item item)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            Slot slot = slots[i];
            Iobject iteminslot = slot.GetComponentInChildren<Iobject>();
            if (iteminslot != null && iteminslot.item == item && iteminslot.count < MaxStack && iteminslot.item.stackable == true)
            {
                iteminslot.count++;
                iteminslot.RefreshCount();
                return true;
            }
        }
        for (int i = 0; i < slots.Length; i++)
        {
            Slot slot = slots[i];
            Iobject iteminslot = slot.GetComponentInChildren<Iobject>();
            if(iteminslot == null)
            {
                SpawnNewItem(item, slot);
                return true;
            }
        }
        return false;
    }
    void SpawnNewItem(Item item, Slot slot)
    {
        GameObject newItem = Instantiate(Iobjectprefab, slot.transform);
        Iobject Ivitem = newItem.GetComponent<Iobject>();
        Ivitem.InitialiseItem(item);
    }
}
