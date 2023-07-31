using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEditor.Progress;

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
        GameData.droppedObejct = null;

        

        Debug.Log("���� ����");

        /*Slot droppedSlot = GameData.droppedObejct.GetComponent<Slot>();  //chatGPT�� �� �ڵ�
        if (droppedSlot != null)
        {
            Item temp = slot.item;
            slot.item = droppedSlot.item;
            droppedSlot.item = temp;
        }*/
    }
}
