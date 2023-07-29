using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotDrop : MonoBehaviour, IDropHandler
{
    private Slot slot;

    private void Start()
    {
        slot = GetComponent<Slot>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        var temp = this.slot.item;
        this.slot.item = GameData.droppedObejct.GetComponent<Slot>().item;
        GameData.droppedObejct.GetComponent<Slot>().item = temp;

    }
}
