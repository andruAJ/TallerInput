using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 0)
        {
            Iobject iobject = eventData.pointerDrag.GetComponent<Iobject>();
            iobject.parentAfterDrag = transform;
        }
    }
}
