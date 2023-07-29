using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotForDrag : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public Vector2 startPos;


    public void OnBeginDrag(PointerEventData eventData)
    {
        startPos = this.transform.position;
        GameData.droppedObejct = this.gameObject;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.position = startPos;
        
    }
}
