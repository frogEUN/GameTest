using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ContentController : MonoBehaviour
{
    public GameObject[] slots = new GameObject[4];

    public static ContentController instance;
    public GameObject content;

    public GameObject player;
    

    private void Start()
    {
        instance = this;
        slots[0] = null;
        content.SetActive(false);
    }

    private void Update()
    {
        this.gameObject.transform.position = Camera.main.WorldToScreenPoint(player.transform.position + new Vector3(20,-10,0));
    }

    public void AddItem(Item item)
    {
        content.SetActive(true);

        for (int i = 1; i < slots.Length; i++)
        {
            if (slots[i].GetComponent<SlotController>().item == null)
            {
                slots[i].GetComponent<SlotController>().item = item;
                break;
            }
        }
    }

    public void DeleteItem(Item item)
    {
        
        for (int i = 1; i < slots.Length; i++)
        {
            
            if (slots[i].GetComponent<SlotController>().item == item)
            {
                slots[i].GetComponent<SlotController>().item = null;
                CleanItem();
                SetContent();
                break;
            }
        }
    }

    private void CleanItem()
    {
        Item currentItem;
        Item nextItem;
        for (int i = 1; i < slots.Length - 1; i++)
        {
            currentItem = slots[i].GetComponent<SlotController>().item;
            nextItem = slots[i+1].GetComponent<SlotController>().item;
 
            if(currentItem == null && nextItem != null)
            {
                currentItem = nextItem;
                nextItem = null;
            }
        }
    }

    private void SetContent()
    {
        if (slots[1].GetComponent<SlotController>().item == null)
        {
            content.SetActive(false);

        }
    }
}
