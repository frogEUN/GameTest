using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragEventTest : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{ 

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        Debug.Log("Drag");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");

    }


}
