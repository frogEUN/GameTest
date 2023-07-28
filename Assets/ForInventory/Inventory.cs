using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items;

    [SerializeField]
    private Transform slotParent;
    [SerializeField]
    private Slot[] slots;

    private void OnValidate()
    {
        slots = slotParent.GetComponentsInChildren<Slot>();
    }

    private void Awake()
    {
        FreshSlot();
    }

    public void FreshSlot()
    {
        int i = 0;
        for(;i < items.Count && i < slots.Length;i++)
        {
            slots[i].item = items[i];
        }
        for(;i<slots.Length;i++)
        {
            slots[i].item = null;
        }
    }

    public void AddItem(Item _item)
    {
        if(!GameData.inventoryOpen)
        {
            if (items.Count < slots.Length)
            {
                /*for(var i = 0; i <= slots.Length; i++)
                {
                    if (slots[i].item == _item)
                    {
                        slots[i].item.amount += 1;
                        break;
                    }     
                }*/
                if(_item.amount == 0)
                {
                    items.Add(_item);
                    FreshSlot();
                }
                
                _item.amount += 1;



            }
            else
            {
                print("½½·ÔÀÌ °¡µæ Â÷ ÀÖ½À´Ï´Ù.");
            }
        }
        
    }
}
