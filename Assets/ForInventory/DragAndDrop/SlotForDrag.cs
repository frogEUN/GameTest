using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotForDrag : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private Vector2 startPos;
    private Transform parent;
    public TextMeshProUGUI numberText;



    private void Start()
    {
        parent = this.transform.parent;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPos = this.transform.position;
        GameData.droppedObejct = this.gameObject;
        this.transform.SetParent(parent.parent);
        this.GetComponent<Image>().raycastTarget = false;
        numberText.transform.SetParent(parent.parent);
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
        this.transform.position = startPos;
        Debug.Log("OnEndDrag");
        this.transform.SetParent(parent);
        this.GetComponent<Image>().raycastTarget = true;
        numberText.transform.SetParent(parent);



    }
}
